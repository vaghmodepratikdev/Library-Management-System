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
    /// Interaction logic for ModifyMedia.xaml
    /// </summary>
    public partial class ModifyMedia : Page
    {
        object previousContent;
        Media mediaData;
        public ModifyMedia(object previousContent, Media mediaData)
        {
            InitializeComponent();
            this.previousContent = previousContent;
            this.mediaData = mediaData;
        }

        private void modifyMedia_Click(object sender, RoutedEventArgs e)
        {
            if(mediaTitle.Text != "" && mediaType.Text != "")
            {
                mediaData.title = mediaTitle.Text;
                mediaData.mediaType = mediaType.Text;
                ((MainWindow)Application.Current.MainWindow).RefreshListings();
                ((MainWindow)Application.Current.MainWindow).Content = previousContent;
            }
            else
            {
                MessageBox.Show("Please enter both values.");
            }
        }
    }
}
