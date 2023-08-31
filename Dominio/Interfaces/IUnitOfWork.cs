using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Interfaces;
    public interface IUnitOfWork
    {
        IUsuario Usuarios {get;}
        IRol Roles {get;}
        Task<int> SaveAsync();
    }
