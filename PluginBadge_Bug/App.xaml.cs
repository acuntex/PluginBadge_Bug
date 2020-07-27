using Xamarin.Forms;

namespace PluginBadge_Bug
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new TestTabbedPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
