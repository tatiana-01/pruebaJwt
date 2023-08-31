using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;

namespace Dominio.Interfaces;
    public interface IUsuario: IGeneric<Usuario>
    {
        Task<Usuario> GetByUsernameAsync(string username);
    }
