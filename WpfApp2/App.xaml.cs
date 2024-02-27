using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using WpfApp2.View;
namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, StartupEventArgs e)
        {
            /*var loginView = new LoginView();
            loginView.Show();
            loginView.IsVisibleChanged += (s, ev) =>
            {
                if (loginView.IsVisible == false && loginView.IsLoaded)
                {*/
                    var mainView = new MainView();
                    mainView.Show();
/*                    mainView.Close();
                }
            };*/
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {

        }
    }
}
