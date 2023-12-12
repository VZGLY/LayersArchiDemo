using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;

namespace LayersArchiDemo_BLL.Interfaces;

public interface IJobService
{
    IEnumerable<Job> GetAll();

    Job? GetById(int id);

    Job? Create(CreateJobForm form);

    bool Update(int id, UpdateJobForm form);

    bool Delete(int id);
}