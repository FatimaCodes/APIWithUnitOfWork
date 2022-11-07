using APIWithUnitOfWork.Models;
using System.Threading.Tasks;

namespace APIWithUnitOfWork.Services
{
    public interface IAuthManager
    {
        Task<bool> ValidateUser(LoginUserDTO userDTO);
        Task<string> CreateToken();
    }
}
