using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FilmSite
{
    public partial class Form3 : Form
    {
        private const string ConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=FilmDatabase;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        public static class MovieArrayCreator
        {
            public static Movie[] CreateMoviesArray(string connectionString)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Id, Title, ReleaseYear, Genre, Rating, Description, PosterImage, Director FROM Movies";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dtable = new DataTable();
                    adapter.Fill(dtable);

                    // Populate the Movie array
                    Movie[] movies = new Movie[dtable.Rows.Count];
                    for (int i = 0; i < dtable.Rows.Count; i++)
                    {
                        DataRow row = dtable.Rows[i];
                        movies[i] = new Movie
                        {
                            Id = Convert.ToInt32(row["Id"]),
                            Title = row["Title"].ToString(),
                            ReleaseYear = Convert.ToInt32(row["ReleaseYear"]),
                            Genre = row["Genre"].ToString(),
                            Rating = Convert.ToDouble(row["Rating"]),
                            Description = row["Description"].ToString(),
                            PosterImage = row["PosterImage"].ToString(),
                            Director = row["Director"].ToString()
                        };
                    }

                    return movies;
                }
            }
        }

        public class Movie
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public int ReleaseYear { get; set; }
            public string Genre { get; set; }
            public double Rating { get; set; }
            public string Description { get; set; }
            public string PosterImage { get; set; }
            public string Director { get; set; }
        }
    }
}
