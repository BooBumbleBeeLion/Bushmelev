using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ООО__41_размер_2.Windows;

namespace ООО__41_размер_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
            this.WindowStartupLocation=System.Windows.WindowStartupLocation.CenterScreen;
            Classes.Manager.FrameMain = frmMain;
            frmMain.Navigate(new Pages.PageProduct());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (new AuthorizationWindow()).Show();
            this.Close();
        }
    }
}
