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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Media media;
        public MainWindow()
        {
            InitializeComponent();
            Library.mediaList.AddRange(Library.booksList);
            Library.mediaList.AddRange(Library.magazinesList);
            Library.mediaList.AddRange(Library.moviesList);
            libraryList.ItemsSource = Library.mediaList;
            membersName.ItemsSource = Library.membersList;
        }

        private void lendMedia_Click(object sender, RoutedEventArgs e)
        {
            if (libraryList.SelectedItem != null && membersName.SelectedItem != null)
            {
                media = (Media)libraryList.SelectedItem;
                if (media.isAvailable)
                {
                    LibraryMember member = (LibraryMember)membersName.SelectedItem;
                    media.isAvailable = false;
                    media.currentBorrowingMember = member.name;
                    RefreshListings();
                    MessageBox.Show(member.name + " is borrowing the media");
                    media = null;
                    libraryList.SelectedItem = null;
                    membersName.SelectedItem = null;
                }
                else
                {
                    MessageBox.Show("Selected media is not available");
                }
            }
            else
            {
                MessageBox.Show("Please select both member and a media to borrow");
            }

        }

        private void returnMedia_Click(object sender, RoutedEventArgs e)
        {
            if (libraryList.SelectedItem != null)
            {
                media = (Media)libraryList.SelectedItem;
                if (media.isAvailable)
                {
                    MessageBox.Show(media.title + " is already available, cannot be returned back");
                }
                else
                {
                    media.isAvailable = true;
                    media.currentBorrowingMember = "";
                    RefreshListings();
                    MessageBox.Show(media.title + " returned back to Library.");
                }
                media = null;
                libraryList.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Please select media to return");
            }
        }

        private void modifyMedia_Click(object sender, RoutedEventArgs e)
        {
            object currentContent = this.Content;
            media = (Media)libraryList.SelectedItem;
            if (media != null)
            {
                ModifyMedia modifiedMedia = new ModifyMedia(currentContent, media);
                this.Content = modifiedMedia;
                media = null;
                libraryList.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Please select media to modify!");
            }
        }
        private void modifyMember_Click(object sender, RoutedEventArgs e)
        {
            object currentContent = this.Content;
            LibraryMember memberName = (LibraryMember)membersName.SelectedItem;
            if (memberName != null)
            {
                ModifyMember modifiedMember = new ModifyMember(currentContent, memberName);
                this.Content = modifiedMember;
                membersName.SelectedItem = null;
            }
            else
            {
                MessageBox.Show("Please select member to modify");
            }
        }

        public void RefreshListings()
        {
            libraryList.ItemsSource = Library.mediaList.ToList();
            membersName.ItemsSource = Library.membersList.ToList();
        }
    }
}
