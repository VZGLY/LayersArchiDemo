using LayersArchiDemo_DAL.Context;
using LayersArchiDemo_DAL.Entities;
using LayersArchiDemo_DAL.Interfaces;

namespace LayersArchiDemo_DAL.Repository;

public class JobRepository : IJobRepository
{
    public IEnumerable<Job> GetAll()
    {
        return FakeDB.Jobs;
    }

    public Job? GetById(int id)
    {
        return FakeDB.Jobs.SingleOrDefault(x => x.Id == id);
    }

    public Job? Create(Job elem)
    {
        elem.Id = FakeDB.Jobs.Max(x => x.Id) + 1;

        FakeDB.Jobs.Add(elem);

        return elem;
    }

    public bool Update(Job elem)
    {
        int index = FakeDB.Jobs.FindIndex(x => x.Id == elem.Id);

        FakeDB.Jobs[index] = elem;

        return true;
    }

    public bool Delete(Job elem)
    {
        FakeDB.Jobs.Remove(elem);
        return true;
    }
}