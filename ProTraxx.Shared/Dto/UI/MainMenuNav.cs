using System.Diagnostics;

namespace ProTraxx.Shared.Dto.UI
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    public class DrawerItem
    {
        public string Text { get; set; }
        public string Url { get; set; }
        public string Icon { get; set; }
        public bool IsSeparator { get; set; }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
