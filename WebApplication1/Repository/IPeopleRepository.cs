using WebApplication1.Collection;

namespace WebApplication1.Repository
{
    public interface IPeopleRepository
    {
        Task<List<People>> GetAllAsync();
        Task<People> GetByIdAsync(string id);
        Task CreateNewPeopleAsync(People newPeople);
        Task UpdatePeopleAsync(People peopleToUpdate);
        Task DeletePeopleAsync(string id);
    }
}
