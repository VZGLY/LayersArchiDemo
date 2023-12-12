using LayersArchiDemo_BLL.Interfaces;
using LayersArchiDemo_BLL.Mappers;
using LayersArchiDemo_BLL.Models.Forms;
using LayersArchiDemo_DAL.Entities;
using LayersArchiDemo_DAL.Interfaces;

namespace LayersArchiDemo_BLL.Services;

public class JobService : IJobService
{
    private readonly IJobRepository _jobRepository;

    public JobService(IJobRepository jobRepository)
    {
        _jobRepository = jobRepository;
    }
    
    public IEnumerable<Job> GetAll()
    {
        return _jobRepository.GetAll();
    }

    public Job? GetById(int id)
    {
        return _jobRepository.GetById(id);
    }

    public Job? Create(CreateJobForm form)
    {
        return _jobRepository.Create(form.ToJob());
    }

    public bool Update(int id, UpdateJobForm form)
    {
        Job? job = _jobRepository.GetById(id);

        if (job is not null)
        {
            job.MinimalSalary = form.MinimalSalary;
            job.CP = form.CP;
            job.Name = form.Name;
            job.Sector = form.Sector;

            return _jobRepository.Update(job);
        }

        return false;
    }

    public bool Delete(int id)
    {
        Job? job = _jobRepository.GetById(id);

        if (job is not null)
        {
            return _jobRepository.Delete(job);
        }

        return false;
    }
}