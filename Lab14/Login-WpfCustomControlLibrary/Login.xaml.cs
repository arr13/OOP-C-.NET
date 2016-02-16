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

namespace Login_WpfCustomControlLibrary
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : UserControl
    {
        public string Login
        {
            get
            {
                return txtBoxLogin.Text;
            }
        }

        public string Password
        {
            get
            {
                return txtBoxPassword.Text;
            }
        }

        public Login()
        {
            InitializeComponent();
        }


    }
}
