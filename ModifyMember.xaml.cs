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

namespace FinalProject
{
    /// <summary>
    /// Interaction logic for ModifyMember.xaml
    /// </summary>
    public partial class ModifyMember : Page
    {
        object previousContent;
        LibraryMember memberName;
        public ModifyMember(object previousContent, LibraryMember memberName)
        {
            InitializeComponent();
            this.previousContent = previousContent;
            this.memberName = memberName;
            name.Text = memberName.name;
        }

        private void modifyMember_Click(object sender, RoutedEventArgs e)
        {
            if (name.Text != "")
            {
                memberName.name = name.Text;
                ((MainWindow)Application.Current.MainWindow).RefreshListings();
                ((MainWindow)Application.Current.MainWindow).Content = previousContent;
            }
            else
            {
                MessageBox.Show("Name cannot be empty.");
            }
        }
    }
}
