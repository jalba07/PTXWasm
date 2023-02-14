using ProTraxx.Shared.Dto.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProTraxx.Shared.Dto.Authentication
{
    public class AuthToken : DataModelBase
    {
        public string Token { get; set; }
        public string Key { get; set; }
        public string Secret { get; set; }
        public string OAuthAccount { get; set; }
        public string GrantType { get; set; }

        public AuthToken authToken { get; set; }

        public AuthToken() { }

        public AuthToken(AuthToken authToken)
        {
            Token = authToken.Token;
            Key = authToken.Key;
            Secret = authToken.Secret;
            OAuthAccount = authToken.OAuthAccount;
            GrantType = authToken.GrantType;
        }
    }
}
