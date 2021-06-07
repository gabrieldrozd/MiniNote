using MiniNote.Database;
using MiniNote.Database.Models;
using System.Linq;
using System.Windows;

namespace MiniNote.Views
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        
        public LoginWindow()
        {
            InitializeComponent();
        }


        private void LogInButton_Click(object sender, RoutedEventArgs e)
        {
            using (var db = new MiniNoteContext())
            {
                if (db.User.Any(u => u.UserName == loginUsernameTextBox.Text) && 
                    db.UserLoginDetail.Any(u => u.Password == loginPasswordPasswordBox.Password.ToString()))
                {
                    MessageBox.Show("Log in succesful!", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    CurrentUser.UserName = loginUsernameTextBox.Text;
                    var mainWindow = new MainWindow();
                    mainWindow.Show();
                    this.Close();
                }
                else
                {
                    return;
                }
            }
        }

        // closes LoginWindow -> App
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            var messageBoxResult = MessageBox.Show("Do you want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (messageBoxResult == MessageBoxResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
            
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            var registerWindow = new RegisterWindow();
            registerWindow.ShowDialog();
        }
    }
}
