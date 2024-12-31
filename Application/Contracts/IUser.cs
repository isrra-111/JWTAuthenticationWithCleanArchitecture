using Application.DTOs;

namespace Application.Contracts
{
    public interface IUser
    {
        Task<RegisterationResponse> RegisterUserAsync(RegisterUserDTO registerUserDTO);
        Task<LoginResponse> LoginUserAsync (LoginDTO loginDTO);
    }
}
