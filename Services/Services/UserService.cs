using Application.Interfaces;
using Domain.Entities;

namespace Services.Services
{
    public class UserService
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly IUsersPepository _usersPepository;
        private readonly IJsonWebTokenProvider _jwtProvider;

        public UserService(IUsersPepository usersPepository,
            IPasswordHasher passwordHasher,
            IJsonWebTokenProvider jwtProvider)
        {
            _passwordHasher = passwordHasher;
            _usersPepository = usersPepository;
            _jwtProvider = jwtProvider;
        }
        public async Task Register(string userName, string email,
            string password, CancellationToken cancellationToken)
        {
            var hashedPassword = _passwordHasher.Generate(password);

            var user = new User
            {
                Id = Guid.NewGuid(),
                Name = userName,
                PasswordHash = hashedPassword,
                Email = email
            };
            //User.Create(Guid.NewGuid, userName, hashedPassword, email);
            await _usersPepository.Add(user, cancellationToken);
        }

        public async Task<string> Login(string email, string password,
            CancellationToken cancellationToken)
        {
            // проверить email и пароль
            var user = await _usersPepository.GetByEmail(email, cancellationToken);

            if (!_passwordHasher.Verify(password, user.PasswordHash))
                throw new Exception("Failed to Login");

            var token = _jwtProvider.GenerateToken(user);

            return token;
        }
    }
}
