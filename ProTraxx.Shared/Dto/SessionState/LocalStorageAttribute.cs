using System;

namespace ProTraxx.Shared.Dto.SessionState
{
    /// <summary>
    /// Specifies which key a property should be given in Local Storage.
    /// </summary>
    [AttributeUsage(AttributeTargets.All)]
    public class LocalStorageAttribute : Attribute
    {
        public LocalStorageAttribute(string keyName)
        {
            KeyName = keyName;
        }

        public string KeyName { get; set; }
    }
}
