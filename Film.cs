namespace Mediaregister_Uppgift_4
{
    //-----Sub class-----
    public class Film : Media
    {
        //-----Properties-----
        private string director;
        private int runtime;

        //-----Constructor-----
        public Film(string title, string director, int length) : base(title)
        {
            this.title = title;
            this.director = director;
            this.runtime = length;
        }

        //-----Method override-----
        public override string ToString()
        {
            //string info = "Title of the film: " + title + " Director of the film: " + director + " Total running time: " + runtime;          
            //return info;

            return $"{title}, {director}, {runtime} minutes (Film)";
        }
    }
}
