using System;
using System.Linq;
using System.Windows.Forms;

namespace Mediaregister_Uppgift_4
{
    //-----Partial class-----
    public partial class FormMediaRegister : Form
    {
        //-----Properties-----
        protected HandleList handler;

        //-----Constructor-----
        public FormMediaRegister()
        {
            handler = new HandleList();
            InitializeComponent();
        }

        //-----Events-----
        private void Form1_Load(object sender, EventArgs e)
        {
            numericUpDownRuntime.Maximum = int.MaxValue;
            numericUpDownPages.Maximum = int.MaxValue;
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {                     
            string title = textBoxBookTitle.Text;
            string author = textBoxAuthor.Text;
            int pages = (int)numericUpDownPages.Value;

            handler.AddBook(title, author, pages);          

            listBoxMedia.Items.Add(new Book(title, author, pages));          

            textBoxBookTitle.Clear();
            textBoxAuthor.Clear();
            numericUpDownPages.ResetText();        
        }

        private void buttonAddFilm_Click(object sender, EventArgs e)
        {
            string title = textBoxFilmTitle.Text;
            string director = textBoxDirector.Text;
            int runtime = (int)numericUpDownRuntime.Value;

            handler.AddFilm(title, director, runtime);

            listBoxMedia.Items.Add(new Film(title, director, runtime));
          
            textBoxFilmTitle.Clear();
            textBoxDirector.Clear();
            numericUpDownRuntime.ResetText();           
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAll.Checked)
            {
                listBoxMedia.Items.Clear();

                foreach (var media in handler.MediaList)
                {
                    listBoxMedia.Items.Add(media);
                }
            }
        }

        private void radioButtonBooks_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBooks.Checked)
            {
                listBoxMedia.Items.Clear();

                foreach (var book in handler.BookList)
                {
                    listBoxMedia.Items.Add(book);
                }
            }
        }

        private void radioButtonFilms_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFilms.Checked)
            {
                listBoxMedia.Items.Clear();

                foreach (var film in handler.FilmList)
                {
                    listBoxMedia.Items.Add(film);
                }
            }
        }

        private void buttonClearList_Click(object sender, EventArgs e)
        {
            listBoxMedia.Items.Clear();
        }

        private void labelSucess_Click(object sender, EventArgs e)
        {

        }
    }   
}
