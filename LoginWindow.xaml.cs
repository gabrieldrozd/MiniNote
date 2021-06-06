using MiniNote.Database;
using MiniNote.Database.Models;
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

namespace MiniNote
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            // TestAddUser();
        }



        private void TestAddUser()
        {
            /*
             dodawanie uzytkownika - REJESTRACJA

            tworzymy HASLO oraz NAZWE UZYTKOWNIKA w zmiennej var userLogin
            nastepnie tworzymy WYSWIETLANA_NAZWE, IMIE, NAZWISKO oraz jako czwarty parametr podajemy userLogin jako referencje do drugiej tabeli w DB
            
            po tym dodajemy oba obiekty do DB
            i zapisujemy na koniec zmiany w DB
             */

            using (var db = new MiniNoteContext())
            {
                var userTable = db.User;
                var userDetailsTable = db.UserLoginDetail;

                var userLogin = new UserLoginDetail
                {
                    UserName = "wero",
                    Password = "321321"
                };

                var user = new User
                {
                    DisplayName = "wer",
                    FirstName = "Weronika",
                    LastName = "Ochal",
                    UserLoginDetail = userLogin
                };
                
                userTable.Add(user);
                userDetailsTable.Add(userLogin);
                db.SaveChanges();
            }
        }
    }
}
