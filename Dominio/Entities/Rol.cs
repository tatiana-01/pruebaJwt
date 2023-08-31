using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entities;
    public class Rol:BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Usuario> Usuarios { get; set; } = new HashSet<Usuario>();
        public ICollection<UsuariosRoles> UsuariosRoles { get; set; }
    }
