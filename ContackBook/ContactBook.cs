using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContackBook
{
    class ContactBook
    {
        private const string TEXT_FILE_NAME = "ContactBook.txt";
       
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public static void WriteContacBook(ContactBook contactBook)
        {
            var contactBookData =
                $"Full Name: {contactBook.FullName}\n" +
                $"Email: {contactBook.Email} \n" +
                $"Phone Number: {contactBook.PhoneNumber}\n" +
                $"Address: {contactBook.Address} \n";

            FileHelper.WriteTextFileAsync(TEXT_FILE_NAME, contactBookData);
            
        }
        public async static void ReadContent()
        {

            await FileHelper.ReadTextFileAsync(TEXT_FILE_NAME);
           
           
        }

    }
}
