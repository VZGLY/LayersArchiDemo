using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;

namespace LayersArchiDemo_BLL.Mappers;

public static class JobMapper
{
    public static Job ToJob(this CreateJobForm form)
    {
        return new Job()
        {
            Name = form.Name,
            MinimalSalary = form.MinimalSalary,
            CP = form.CP,
            Sector = form.Sector,
            Id = 0
        };
    }
}