using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    class Book
    {
        private string bookId;
        private string title;
        private string categories;
        private List<string> categoriesList;
        private string imageUrl;
        private string description;
        private string downloadLink;
        private string publishDate;
        private string publisher;
        private string authors;
        private List<string> authorsList;
        private int noDownloads;
        private int pageCount;

        public Book()
        {

        }
        public Book(string bookId, string title)
        {

            this.bookId = bookId;
            this.title = title;
        }
        public string BookId
        {
            get { return bookId; }
            set { bookId = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string DownloadLink
        {
            get { return downloadLink; }
            set { downloadLink = value; }
        }
        public string PublishDate
        {
            get { return publishDate; }
            set { publishDate = value; }
        }
        public string Publisher
        {
            get { return publisher; }
            set { publisher = value; }
        }

        public int NoDownloads
        {
            get { return noDownloads; }
            set { noDownloads = value; }
        }

        public int PageCount
        {
            get { return pageCount; }
            set { pageCount = value; }
        }
        public List<string> CategoriesList
        {
            get { return categoriesList; }
            set { categoriesList = value; }
        }
        public List<string> AuthorsList
        {
            get { return authorsList; }
            set { authorsList = value; }
        }
        public string Authors
        {
           get { string result = String.Empty;
           foreach(string author in authorsList){
                    if(result != String.Empty)
                    {
                        result = String.Concat(result, ";", author);
                    }
                    else
                    {
                        result = String.Concat(author); ;
                    }
                    
            }
            return result;}
            set { authors = value; }

        }
        public string Categories
        {
            get
            {
                string result = String.Empty;
                foreach (string categ in categoriesList)
                {
                    result += categ + ";";
                }
                return result;
            }

        }

    }
}
