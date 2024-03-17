using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Core
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : class;
        // SaveChanges
        int Guardar();

        // BeginTransaction
        void ComenzarTransaccion();

        // RollBackTransaction
        void ReversarTransaccion();

        // CommitTransaction
        void ConfirmarTransaccion();
    }
}
