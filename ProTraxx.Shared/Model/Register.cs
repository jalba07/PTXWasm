namespace ProTraxx.Shared.Model
{
    public class RegisterAccount
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public void Clear() => Email = Password = Name = null;
    }
    public class RegisterResult
    {
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}

