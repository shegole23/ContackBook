using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ContackBook
{
    
    public sealed partial class AddContact : Page
    {
        private const string TEXT_FILE_NAME = "ContactBook.txt";
    

        
    public AddContact()
        {
            this.InitializeComponent();
        }

    private void Save_Click(object sender, RoutedEventArgs e)
    {
        var contactBook = new ContactBook
        {
            FullName = fullName.Text,
            Email = email.Text,
            PhoneNumber = phoneNumber.Text,
            Address = address.Text,
            //ListBox = listBox.ItemeSources

        };
        ContactBook.WriteContacBook(contactBook);


        this.Frame.Navigate(typeof(AddContact));
    }
            

        private void Back_Click(object sender, RoutedEventArgs e)
        {
        this.Frame.Navigate(typeof(MainPage));
        }
    }
}
