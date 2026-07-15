using Firebase.Auth;
using System.Threading.Tasks;

namespace AkilliFitnessMobil.Services
{
    public class FirebaseService
    {
        // Web API Key
        private const string WebApiKey = "AIzaSyDF7ALee1LVPKXLOxSzNVt61J-DA1MVrhs";

        private readonly FirebaseAuthProvider _authProvider;

        public FirebaseService()
        {
            _authProvider = new FirebaseAuthProvider(new FirebaseConfig(WebApiKey));
        }

        // Kullanıcı kaydı için
        public async Task<bool> RegisterAsync(string email, string password)
        {
            try
            {
                await _authProvider.CreateUserWithEmailAndPasswordAsync(email, password);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Kullanıcı girişi için
        public async Task<string> LoginAsync(string email, string password)
        {
            try
            {
                var auth = await _authProvider.SignInWithEmailAndPasswordAsync(email, password);
                return auth.FirebaseToken;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}
