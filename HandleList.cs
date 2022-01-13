using System;
using System.Collections.Generic;

namespace Mediaregister_Uppgift_4
{
    //-----Class for error-handling-----
    public class HandleList
    {
        //-----Properties-----
        public List<Media> MediaList;
        public List<Book> BookList;
        public List<Film> FilmList;
        
        //-----Constructor-----
        public HandleList()
        {
            MediaList = new List<Media>();
            BookList = new List<Book>();
            FilmList = new List<Film>();          
        }

        //-----Methods with error handling-----
        public string AddBook(string title, string author, int pages)
        {
            string message = string.Empty;

            try
            {
                if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author) && pages >= 1)
                {
                    var book = new Book(title, author, pages);

                    MediaList.Add(book);
                    BookList.Add(book);

                    message = $"Successfully added {title} to the list.";
                }              
            }
            catch (Exception ex)
            {
                message = ex.Message;              
            }
                       
            return message;
        }

        public string AddFilm(string title, string director, int runtime)
        {
            string message = string.Empty;

            try
            {
                if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(director) && runtime >= 1)
                {
                    var film = new Film(title, director, runtime);

                    MediaList.Add(film);
                    FilmList.Add(film);

                    message = $"Successfully added {title} to the list.";
                }
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }

            return message;
        }
    }
}
