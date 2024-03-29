﻿using Datos.BaseDatos;
using Datos.BaseDatos.Modelos;
using Datos.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DCategoriaClientes
    {
        //private FerreteriaContext context;
        //Repository<CategoriaClientes> _repository;
        UnitOfWork _unitOfWork;
 
        public DCategoriaClientes()
        {
            //context = new FerreteriaContext();
            //_repository = new Repository<CategoriaClientes>();
            _unitOfWork = new UnitOfWork();
        }
        public int CategoriaClienteId { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaModificacion { get; set; }

        public List<CategoriaClientes> categoriaClientesTodas() 
        {
            //return context.CategoriaClientes.ToList();
            //return _repository.Consulta().ToList();
            return _unitOfWork.Repository<CategoriaClientes>().Consulta().ToList();
        }

        public int GuardarCategoria(CategoriaClientes categoria) 
        {
            if (categoria.CategoriaClienteId == 0)
            {
                categoria.FechaCreacion = DateTime.Now;
                categoria.FechaModificacion = DateTime.Now;
                //context.CategoriaClientes.Add(categoria);
                //_repository.Agregar(categoria);
                _unitOfWork.Repository<CategoriaClientes>().Agregar(categoria);
                return _unitOfWork.Guardar();
            }
            else 
            {
                //var CategoriaInDb = context.CategoriaClientes.Find(categoria.CategoriaClienteId);
                var CategoriaInDb = _unitOfWork.Repository<CategoriaClientes>().Consulta().FirstOrDefault(c=>c.CategoriaClienteId == categoria.CategoriaClienteId);

                if (CategoriaInDb != null)
                {
                    CategoriaInDb.FechaModificacion = DateTime.Now;
                    CategoriaInDb.Codigo = categoria.Codigo;
                    CategoriaInDb.Descripcion = categoria.Descripcion;
                    CategoriaInDb.Estado = categoria.Estado;
                    //_repository.Editar(CategoriaInDb);
                    _unitOfWork.Repository<CategoriaClientes>().Editar(categoria);
                    return _unitOfWork.Guardar();
                }
                return 0;
            }
            
        }

        public int EliminarCategoria(int categoriaId)
        {
            //var CategoriaInDb = context.CategoriaClientes.Find(categoriaId);
            var CategoriaInDb = _unitOfWork.Repository<CategoriaClientes>().Consulta().FirstOrDefault(c => c.CategoriaClienteId == categoriaId);
            if (CategoriaInDb != null)
            {
                //_repository.Eliminar(CategoriaInDb);
                _unitOfWork.Repository<CategoriaClientes>().Eliminar(CategoriaInDb);
                return _unitOfWork.Guardar();
            }
            return 0;
        }
    }
}
