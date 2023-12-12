using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Mappers
{
    public static class UserMapper
    {
        public static User ToUser(this CreateUserForm form)
        {
            return new User()
            {
                Id = 0,
                Email = form.Email,
                Name = form.Name,
                Password = form.Password
            };
        }
    }
}
