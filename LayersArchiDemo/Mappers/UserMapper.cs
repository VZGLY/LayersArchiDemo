using API.Models.DTO;
using LayersArchiDemo_DAL.Entities;

namespace API.Mappers
{
    public static class UserMapper
    {
        public static UserDTO ToDTO(this User user)
        {
            return new UserDTO()
            {
                Email = user.Email,
                Id = user.Id,
                Name = user.Name,
            };
        }
    }
}
