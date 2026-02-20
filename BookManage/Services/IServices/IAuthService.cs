using static BookManage.Models.DTOs.AuthDto;
using static BookManage.Models.DTOs.LoginDto;

namespace BookManage.Services.IServices
{
    public interface IAuthService
    {
        Task<AuthResponseDto> GoogleLoginAsync(string googleToken);
    }
}
