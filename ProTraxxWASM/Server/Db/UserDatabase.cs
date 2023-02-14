using Microsoft.AspNetCore.Hosting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Threading;

namespace ProTraxxWASM.Server.Db
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
    }
    public interface IUserDatabase
    {
        Task<User> AuthenticateUser(string email, string password, CancellationToken cancel);
        Task<User> AddUser(string email, string password, string name, CancellationToken cancel);
        Task<bool> ChangePassword(string email, string currentPassword, string newPassword, CancellationToken cancel);
        Task<bool> AdminChangePassword(string email, string newPassword, CancellationToken cancel);
    }
    public class UserDatabase : IUserDatabase
    {
        private readonly IWebHostEnvironment env;
        public UserDatabase(IWebHostEnvironment env) => this.env = env;
        private static string CreateHash(string password)
        {
            var salt = "997eff51db1544c7a3c2ddeb2053f052";
            var md5 = new HMACMD5(Encoding.UTF8.GetBytes(salt + password));
            byte[] data = md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            return System.Convert.ToBase64String(data);
        }
        public async Task<User> AuthenticateUser(string email, string password, CancellationToken cancel = default(CancellationToken))
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
                return null;
            var path = Path.Combine(env.ContentRootPath, "Users");
            if (!Directory.Exists(path))
                return null;
            path = Path.Combine(path, email);
            if (!File.Exists(path))
                return null;
            var user = JsonSerializer.Deserialize<User>(await File.ReadAllTextAsync(path, cancel));
            if (user.Password != CreateHash(password))
                return null;
            return user;
        }
        public async Task<User> AddUser(string email, string password, string name, CancellationToken cancel = default(CancellationToken))
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(name))
                return null;
            var path = Path.Combine(env.ContentRootPath, "Users"); // NOTE: THIS WILL CREATE THE "USERS" FOLDER IN THE SERVER'S ROOT!!!
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path); // NOTE: MAKE SURE THERE ARE CREATE/WRITE PERMISSIONS
            path = Path.Combine(path, email);
            if (File.Exists(path))
                return null;
            var user = new User { Email = email, Password = CreateHash(password), Name = name };
            await File.WriteAllTextAsync(path, JsonSerializer.Serialize(user), cancel);
            return user;
        }
        public async Task<bool> ChangePassword(string email, string currentPassword, string newPassword, CancellationToken cancel = default(CancellationToken))
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword))
                return false;
            var path = Path.Combine(env.ContentRootPath, "Users");
            if (!Directory.Exists(path))
                return false;
            path = Path.Combine(path, email);
            if (!File.Exists(path))
                return false;
            var user = JsonSerializer.Deserialize<User>(await File.ReadAllTextAsync(path, cancel));
            if (user.Password != CreateHash(currentPassword))
                return false;
            user.Password = CreateHash(newPassword);
            await File.WriteAllTextAsync(path, JsonSerializer.Serialize(user), cancel);
            return true;
        }
        public async Task<bool> AdminChangePassword(string email, string newPassword, CancellationToken cancel = default(CancellationToken)) // THIS IS USED FOR ADMINISTRATORS TO CHANGE THE PASSWORD
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword))
                return false;
            var path = Path.Combine(env.ContentRootPath, "Users");
            if (!Directory.Exists(path))
                return false;
            path = Path.Combine(path, email);
            if (!File.Exists(path))
                return false;
            var user = JsonSerializer.Deserialize<User>(await File.ReadAllTextAsync(path, cancel));
            user.Password = CreateHash(newPassword);
            await File.WriteAllTextAsync(path, JsonSerializer.Serialize(user), cancel);
            return true;
        }
    }
}