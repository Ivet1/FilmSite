namespace FilmSite
{
    internal class MovieRepository
    {
        private string connectionString;

        public MovieRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}