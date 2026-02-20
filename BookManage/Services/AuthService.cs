using BookManage.Models.DTOs;
using BookManage.Services.IServices;
using static BookManage.Models.DTOs.LoginDto;

namespace BookManage.Services
{
    public class AuthService : IAuthService
    {
        public async Task GoogleLoginAsync(GoogleLoginDto request)
        {
            throw new NotImplementedException();
        }
    }
}
