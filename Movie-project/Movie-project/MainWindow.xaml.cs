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

namespace Movie_project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (userNameText.Text == "Gajen" && passwordBox.Password == "fantasy")
            {
                MessageBox.Show("You logged in!");
                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.ShowDialog();
            }             
            else
                MessageBox.Show("Incorrect credentials");
        }

        private void pnlMainGrid_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("You clicked me at " + e.GetPosition(this).ToString());
        }

        private void pnlMainGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(e.Device.ToString());
        }
    }
}
