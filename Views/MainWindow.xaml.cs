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
using System.Windows.Shapes;

namespace MiniNote.Views
{
    /// <summary>
    /// Interaction logic for MainStartWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string currentUser { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            setUserNameToLabel();
        }

        // gets username from CurrentUser static class and sets it to Label content
        void setUserNameToLabel()
        {
            currentUser = CurrentUser.UserName;
            userNameLabel.Content = currentUser;
        }
    }
}
