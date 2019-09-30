using Google.Apis.Auth.OAuth2;
using Google.Apis.Books.v1;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleBooks.Integracoes
{
    public class GoogleAuthService
    {
        private readonly string CLIENT_ID = "974538339611-d4otc92voi93v011chfn1c6no9g1bd35.apps.googleusercontent.com";
        private readonly string CLIENT_SECRET = "gfyWhYv3To_jxflBfg_wh_n7";

        public async Task<UserCredential> Login()
        {
            var clientSecrets = new ClientSecrets
            {
                ClientId = CLIENT_ID,
                ClientSecret = CLIENT_SECRET
            };

            var credenciais = await GoogleWebAuthorizationBroker.AuthorizeAsync(
               clientSecrets,
               new[] { BooksService.ScopeConstants.Books },
               "user",
               CancellationToken.None
            );
            
            return credenciais;
        }

        public async Task RefreshToken(UserCredential credenciais)
            => await GoogleWebAuthorizationBroker.ReauthorizeAsync(credenciais, CancellationToken.None);

        public async Task Logout(UserCredential credenciais)
            => await credenciais.RevokeTokenAsync(CancellationToken.None);
    }
}
