using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_DAL.Entities
{
    public class Job
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Sector { get; set; }

        public string CP { get; set; }

        public int MinimalSalary { get; set; }
    }
}
