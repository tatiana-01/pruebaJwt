using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiPrueba.Dtos;

namespace apiPrueba.Services;
    public interface IUserService
    {
        Task<string> ResgisterAsync(RegisterDto model);
        Task<DatosUsuarioDto> GetTokenAsync (LoginDto model);
        Task<string> AddRolAsync(AddRolDto model);
    }
