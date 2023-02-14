// AuthController.cs
using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Threading;
using ProTraxx.Shared.Model;
using ProTraxxWASM.Server.Db;

namespace ProTraxxWASM.Server.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        private string CreateJWT(User user)
        {
            var secretkey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("THIS IS YOUR SECRET KEY RIGHT HERE")); // NOTE: SAME KEY AS USED IN Startup.cs FILE
            var credentials = new SigningCredentials(secretkey, SecurityAlgorithms.HmacSha256);

            var claims = new[] // NOTE: could also use List<Claim> here
			{
                new Claim(ClaimTypes.Name, user.Email), // NOTE: this will be the "User.Identity.Name" value to retrieve the user name on the server side
				new Claim(JwtRegisteredClaimNames.Sub, user.Email),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, user.Email) // NOTE: this could a unique ID assigned to the user by a database
			};

            var token = new JwtSecurityToken(issuer: "protraxx.com", audience: "protraxx.com", claims: claims, expires: DateTime.Now.AddMinutes(60), signingCredentials: credentials);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private IUserDatabase userdb { get; }

        public AuthController(IUserDatabase userdb) => this.userdb = userdb;

        [HttpPost]
        [Route("api/auth/register")]
        public async Task<RegisterResult> Post([FromBody] RegisterAccount reg, CancellationToken cancel)
        {
            try
            {
                User newuser = await userdb.AddUser(reg.Email, reg.Password, reg.Name, cancel);
                if (newuser != null)
                    return new RegisterResult { Message = "Registration successful.", Success = true };
                return new RegisterResult { Message = "Registration unsuccessful.", Success = false };
            }
            catch (Exception ex)
            {
                return new RegisterResult { Message = ex.Message, Success = false };
            }
        }

        [HttpPost]
        [Route("api/auth/login")]
        public async Task<LoginResult> Post([FromBody] LoginProTraxx log, CancellationToken cancel)
        {
            try
            {
                User user = await userdb.AuthenticateUser(log.Email, log.Password, cancel);
                if (user != null)
                    return new LoginResult { JWT = CreateJWT(user), Email = user.Email, Name = user.Name };
                return new LoginResult { Message = "User/password not found." };
            }
            catch (Exception ex)
            {
                return new LoginResult { Message = ex.Message };
            }
        }

        [HttpPatch]
        [Authorize]
        [Route("api/auth/password")]
        public async Task<bool> Patch([FromBody] Password pwd, CancellationToken cancel)
        {
            try
            {
                return await userdb.ChangePassword(User.Identity.Name, pwd.CurrentPassword, pwd.NewPassword, cancel);
            }
            catch
            {
                return false;
            }
        }
    }
}