using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_BLL.Models.Forms
{
    public class CreateUserForm
    {

        public string? Name { get; set; }

        [MinLength(8)]
        public string Password { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
