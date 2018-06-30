using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using MahApps.Metro.Controls;
using DALOrganizerClientWPF;
using OrganizerClientWPF.DTO;

namespace OrganizerClientWPF
{
    /// <summary>
    /// Interaction logic for WISH.xaml
    /// </summary>
    public partial class WISH : MetroWindow
    {
        private readonly DataDAL _dalCl = new DataDAL();
        public User CurrentUser { get; } = new User();

        public WISH (User currentUser)
        {
            InitializeComponent();
            CurrentUser = currentUser;
            //title.Text = CurrentUser.Login.ToString().ToUpper() + "'s Wish-List";

        }
    }
}
