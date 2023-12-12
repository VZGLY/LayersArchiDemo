using LayersArchiDemo_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_DAL.Context
{
    internal static class FakeDB
    {
        public static List<User> Users = new List<User>()
        {
            new User()
            {
                Id = 1,
                Name = "Sophie Marceau",
                Email = "SosoMarceau@cinema.fr",
                Password = "Test123="
            },
            new User()
            {
                Id = 2,
                Name = "Brigitte bardot",
                Email = "Bribridamour@Dco.fr",
                Password = "Test123="
            },
            new User()
            {
                Id = 3,
                Name = "Jason Statham",
                Email = "JasonDu79@labagarre.us",
                Password = "Test123="
            },
        };

        public static List<Job> Jobs = new List<Job>()
        {
            new Job()
            {
                Id = 1,
                Name = "Developer",
                MinimalSalary = 1800,
                CP = "200",
                Sector = "IT"
            },
            new Job()
            {
                Id=2,
                Name = "Electronic Engineer",
                MinimalSalary = 3000,
                CP = "200",
                Sector = "Technic"
            },
            new Job()
            {
                Id=3,
                Name = "Poissonnier",
                MinimalSalary = 1400,
                CP = "300",
                Sector = "Les fishsticks"
            }
        };
    }
}
