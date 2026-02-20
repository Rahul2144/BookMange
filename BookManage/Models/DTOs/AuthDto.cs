namespace BookManage.Models.DTOs
{
    public class AuthDto
    {
        public class GoogleLoginDto 
        {
            public string Token { get; set; }
        }

        public class AuthResponseDto
        {
            public string Token { get; set; }
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string ProfilePicture { get; set; }
            public DateTime Expiration { get; set; }
        }



    }
}
