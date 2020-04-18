using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookList : ContentPage
    {
        List<Book> bookList = new List<Book>();

        public BookList()
        {
            Book book1 = new Book("5d2c61939022d519f83f858c", "Emma");
            book1.ImageUrl = "https://i.imgur.com/R2t6UIz.jpg";
            List<string> auth = new List<string>();
            auth.Add("Jane Austen");
            book1.AuthorsList = auth;
               
            Book book2 = new Book("5d2c63e39022d519f83f858d", "Don Quijote");
            book2.ImageUrl = "https://i.imgur.com/Ji15P9e.jpg";
            List<string> auth2 = new List<string>();
            auth2.Add("Miguel de Cervantes Saavedra");
            book2.AuthorsList = auth2;

            bookList.Add(book1);
            bookList.Add(book2);

            InitializeComponent();

            lvBooks.ItemsSource = bookList;

        }
        private void BookList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            {
                Book book = (Book)e.SelectedItem;
                Navigation.PushAsync(new BookDetails(book.BookId));
            }
        }
        public void btnShowDetails(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string selectedItem = button.AutomationId.ToString();
            Navigation.PushAsync(new BookDetails(selectedItem));
        }
        public void btnAddToWishList(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string selectedItem = button.AutomationId.ToString();
            DisplayAlert("Wishlist", "The book was added on your wishlist!"+selectedItem, "OK");
        }
    }
}