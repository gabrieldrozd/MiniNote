using MiniNote.Database;
using System.Windows;

namespace MiniNote
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using (var dbContext = new MiniNoteContext())
            {
                dbContext.Database.EnsureCreated();
            }
        }
    }
}
