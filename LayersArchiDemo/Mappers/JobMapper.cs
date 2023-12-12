using API.Models.DTO;
using LayersArchiDemo_DAL.Entities;

namespace API.Mappers;

public static class JobMapper
{
    public static JobDTO ToDTO(this Job job)
    {
        return new JobDTO()
        {
            Id = job.Id,
            Name = job.Name,
            MinimalSalary = job.MinimalSalary,
            CP = job.CP,
            Sector = job.Sector
        };
    }
}