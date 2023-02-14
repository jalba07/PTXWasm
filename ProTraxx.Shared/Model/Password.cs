namespace ProTraxx.Shared.Model
{
    public class Password
    {
        public string CurrentPassword { get; set; }
        public string NewPassword { get; set; }
        public void Clear() => CurrentPassword = NewPassword = null;
    }
}
