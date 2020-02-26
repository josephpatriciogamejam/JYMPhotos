using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MYJ.Data.Context;
using MYJ.Services.DTO;

namespace MYJ.Data.Services.Repositories
{
    public class UsuarioRepository
    {
        public List<Usuario> GetAllUsuarios()
        {
            using(var model = new MYJContext())
            {
                return model.Usuarios.ToList();
            }
        }

        public void CreateUsuarios(Usuario usuario)
        {
            using (var model = new MYJContext())
            {
                model.Usuarios.Add(usuario);
                model.SaveChanges();
            }
        }
    }
}
