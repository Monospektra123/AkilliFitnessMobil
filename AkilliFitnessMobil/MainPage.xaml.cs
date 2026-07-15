using AkilliFitnessMobil.Services;

namespace AkilliFitnessMobil
{
    public partial class MainPage : ContentPage
    {
        private readonly FirebaseService _firebaseService;

        public MainPage()
        {
            InitializeComponent();
            _firebaseService = new FirebaseService(); // Servisi başlatmak için
        }

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            await ProcessAuth(isLogin: true);
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            await ProcessAuth(isLogin: false);
        }

        private async Task ProcessAuth(bool isLogin)
        {
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            // Boş alan kontrolü için
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageLabel.Text = "E-posta ve şifre boş olamaz!";
                MessageLabel.TextColor = Colors.Red;
                return;
            }

            LoadingIndicator.IsRunning = true;
            LoadingIndicator.IsVisible = true;
            MessageLabel.Text = "";

            if (isLogin)
            {
                // Giriş yapmak için
                var token = await _firebaseService.LoginAsync(email, password);
                if (!string.IsNullOrEmpty(token))
                {
                    MessageLabel.Text = "Giriş Başarılı!";
                    MessageLabel.TextColor = Colors.Green;

                    // Ekran değişimini ana iş parçacığında zorla yaptırmak için
                    MainThread.BeginInvokeOnMainThread(() =>
                    {
                        Application.Current.MainPage = new DashboardPage();
                    });
                }
                else
                {
                    MessageLabel.Text = "Giriş Başarısız! Bilgileri kontrol edin.";
                    MessageLabel.TextColor = Colors.Red;
                }
            }
            else
            {
                // Kayıt işlemi için
                bool isRegistered = await _firebaseService.RegisterAsync(email, password);
                if (isRegistered)
                {
                    MessageLabel.Text = "Kayıt Başarılı! Şimdi giriş yapabilirsiniz.";
                    MessageLabel.TextColor = Colors.Green;
                }
                else
                {
                    MessageLabel.Text = "Kayıt Başarısız! (Şifre en az 6 karakter olmalı)";
                    MessageLabel.TextColor = Colors.Red;
                }
            }

            LoadingIndicator.IsRunning = false;
            LoadingIndicator.IsVisible = false;
        }
    }
}