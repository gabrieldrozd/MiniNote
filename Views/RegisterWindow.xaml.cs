using MiniNote.Database;
using MiniNote.Database.Models;
using System.Windows;

namespace MiniNote.Views
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        // goes back to LoginWindow
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // checks important conditions and then creates new user
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            // user creation
            if (CheckRegisterCondition())
            {
                using (var db = new MiniNoteContext())
                {
                    var userTable = db.User;
                    var userDetailsTable = db.UserLoginDetail;

                    var userLogin = new UserLoginDetail
                    {
                        UserName = usernameTextBox.Text,
                        Password = passwordFirstPassBox.Password.ToString()
                    };

                    var user = new User
                    {
                        FirstName = firstNameTextBox.Text,
                        LastName = lastNameTextBox.Text,
                        EmailAddress = emailTextBox.Text,
                        UserLoginDetail = userLogin
                    };

                    userTable.Add(user);
                    userDetailsTable.Add(userLogin);
                    db.SaveChanges();

                    MessageBox.Show("User created succesfully!", "Information", MessageBoxButton.OK);
                    this.Close();
                }
            }
            // if empty fields
            else if (!BoxHasValue())
            {
                MessageBox.Show("Empty field! Write necesarry informations.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }
            // problems with fields
            else
            {
                if (usernameTextBox.Text.Length < 6)
                {
                    MessageBox.Show("Username too short!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (passwordFirstPassBox.Password.ToString() != passwordConfirmPassBox.Password.ToString())
                {
                    MessageBox.Show("Password and Confirm password are different!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
                else if (!emailTextBox.Text.Contains("@"))
                {
                    MessageBox.Show("Wrong e-mail format!", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }
            }
        }

        // conditions needed to create new user
        bool CheckRegisterCondition()
        {
            var registerCondition = BoxHasValue() && (usernameTextBox.Text.Length >= 6 && emailTextBox.Text.Contains("@") &&
                (passwordFirstPassBox.Password.ToString() == passwordConfirmPassBox.Password.ToString()));

            return registerCondition;
        }

        // every box has value?
        bool BoxHasValue()
        {
            var hasValue = (usernameTextBox.Text.Length > 0 &&
                passwordFirstPassBox.Password.ToString().Length > 0 &&
                passwordConfirmPassBox.Password.ToString().Length > 0 &&
                emailTextBox.Text.Length > 0 &&
                firstNameTextBox.Text.Length > 0 &&
                lastNameTextBox.Text.Length > 0);

            return hasValue;
        }
    }
}
