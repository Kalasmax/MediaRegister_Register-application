namespace Mediaregister_Uppgift_4
{
    //-----Sub class-----
    public class Book : Media
    {
        //-----Properties-----
        private string author;
        private int pages;

        //-----Constructor-----
        public Book(string title, string author, int pages) : base(title)
        {
            this.title = title;
            this.author = author;
            this.pages = pages;
        }

        //-----Method override-----
        public override string ToString()
        {
            //string info = "Title of the book: " + title + " Author of the book: " + author + " Amount of pages: " + pages;           
            //return info;
           
            return $"{title}, {author}, {pages} pages (Book)";
        }
    }
}
