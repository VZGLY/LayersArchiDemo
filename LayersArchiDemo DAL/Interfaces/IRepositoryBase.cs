using LayersArchiDemo_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayersArchiDemo_DAL.Interfaces
{
    public interface IRepositoryBase<Tkey, TElem>
    {
        IEnumerable<TElem> GetAll();

        TElem? GetById(Tkey id);

        TElem? Create(TElem elem);

        bool Update(TElem elem);

        bool Delete(TElem elem);
    }
}
