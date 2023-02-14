namespace ProTraxx.Shared.Model
{
    public class LoginProTraxx
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public void Clear() => Email = Password = null;
    }
    public class LoginResult
    {
        public string Message { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string JWT { get; set; }
    }
}