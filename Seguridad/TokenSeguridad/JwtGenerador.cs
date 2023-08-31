using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Aplicacion.Contratos;
using Dominio.Entities;
using Microsoft.IdentityModel.Tokens;

namespace Seguridad.TokenSeguridad;
public class JwtGenerador : IJwtGenerador
{
    public string CrearToken(Usuario usuario)
    {
        var claims = new List<Claim>{
            new Claim(JwtRegisteredClaimNames.NameId, usuario.Username)
        };
        var key= new SymmetricSecurityKey(Encoding.UTF8.GetBytes("N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw$@EgWH5N5NHNr9Vw"));
        var credenciales= new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
        var tokenDescripcion = new SecurityTokenDescriptor
        {
            Subject= new ClaimsIdentity(claims),
            Expires = DateTime.Now.AddDays(20),
            SigningCredentials= credenciales
        };
        var tokenManejador= new JwtSecurityTokenHandler();
        var token = tokenManejador.CreateToken(tokenDescripcion);
        return tokenManejador.WriteToken(token);
    }
}
