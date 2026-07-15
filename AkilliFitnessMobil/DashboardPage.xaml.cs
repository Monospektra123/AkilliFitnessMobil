namespace AkilliFitnessMobil
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void OnLogoutClicked(object sender, EventArgs e)
        {
            // Çýkýþ yapýnca tekrar giriþ sayfasýna yönlendirmek için
            Application.Current.MainPage = new MainPage();
        }
    }
}