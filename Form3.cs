using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmSite
{
    public partial class Form3 : Form
    {
        private const string ConnectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=FilmDatabase;Integrated Security=True";

        Movie[] movies = null;


        public Form3()
        {
            InitializeComponent();
            richTextBox1.MouseClick += richTextBox1_MouseClick;
            button1.Click += button1_Click;

            richTextBox1.SelectionChanged += RichTextBox1_SelectionChanged;
            
        }

        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            // Get the line index of the selected text
            int lineIndex = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart);

            // Highlight the selected line by changing its background color
            HighlightSelectedLine(lineIndex);


           
        }

        private void HighlightSelectedLine(int lineIndex)
        {
            /*
            // Get the start and end indices of the selected line
            int startIndex = richTextBox1.GetFirstCharIndexFromLine(lineIndex);
            int endIndex = richTextBox1.GetFirstCharIndexFromLine(lineIndex + 1);
            if (endIndex == -1)
            {
                // If the line is the last line, endIndex is the end of the text
                endIndex = richTextBox1.TextLength;
            }

            // Apply formatting to the selected line (change background color)
            richTextBox1.Select(startIndex, endIndex - startIndex);
            richTextBox1.SelectionBackColor = Color.Yellow; // You can change this to any color you prefer
            richTextBox1.DeselectAll(); // Deselect the text to avoid keeping it highlighted           

            */


        }            


        private void button1_Click(object sender, MouseEventArgs e)
        { 
            Close();
        }

        private async void richTextBox1_MouseClick(object sender, MouseEventArgs e) 
        {
            // Get the index of the character clicked
            int charIndex = richTextBox1.GetCharIndexFromPosition(e.Location);
            // Get the line index from the character index
            int lineIndex = richTextBox1.GetLineFromCharIndex(charIndex);
            StringBuilder movieDetails = new StringBuilder();

            // Get the text of the clicked line
            string[] lines = richTextBox1.Lines;
            if (lineIndex >= 0 && lineIndex < lines.Length)
            {
                string selectedLine = lines[lineIndex];

                drawMovieDetails(selectedLine);

            }




        }

        private async void drawMovieDetails(string title) {


            try
            {
                Movie[] movies = await MovieArrayCreator.CreateMoviesArrayAsync(ConnectionString);
                StringBuilder movieDetails = new StringBuilder();
                for (int i = 0; i < movies.Length; i++)
                {
                    if (movies[i].Title.Equals(title))
                    {

                        movieDetails.AppendLine("Title: " + movies[i].Title);
                        movieDetails.AppendLine("Year: " + movies[i].ReleaseYear);
                        movieDetails.AppendLine("Genre: " + movies[i].Genre);
                        movieDetails.AppendLine("Director: " + movies[i].Director);
                        movieDetails.AppendLine("Rating: " + movies[i].Rating);
                        movieDetails.AppendLine("Description: " + movies[i].Description);

                        String posterFile = movies[i].PosterImage + "\\" + movies[i].Title + ".jpg";
                        richTextBox2.Text = movieDetails.ToString();
                        pictureBox1.Image = Image.FromFile(posterFile);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading all movie images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private async void LoadMoviesList() {

            try
            {
                Movie[] movies = await MovieArrayCreator.CreateMoviesArrayAsync(ConnectionString);
                int i = 0;
                StringBuilder text = new StringBuilder();

                foreach (var movie in movies)
                {
                    if (movie.Title != null)
                    {
                        text.AppendLine(movie.Title);
                    }

                   
                }

                richTextBox1.AppendText(text.ToString());
                

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading all movie images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        } 

        private void InitializeTextControl()
        {
            //this.textBox1.Font.Height = 16;
            //this.textBox1.Font.Size = 16;
            //this.textBox1.Font.Style = FontStyle.Bold;
        }

      
        private async void LoadAllMovies_Click(object sender, EventArgs e)
        {
            //await LoadAllMovieImagesAsync();
            //LoadAllMovieImagesAsync();
            LoadMoviesList();
              
        }

       

     
        private async Task LoadAllMovieImagesAsync()
        {
            string posterImagePath = null;
 
            try
            {
                Movie[] movies = await MovieArrayCreator.CreateMoviesArrayAsync(ConnectionString);
                foreach (var movie in movies)
                {
                    if (movie.PosterImage != null) {

                        //CONSTRUCT IMAGE PATH
                        if (movie.Title != null) {

                            posterImagePath = movie.PosterImage + "\\" + movie.Title + ".jpg";
                        }
                    }

                    //await DisplayImageAsync(posterImagePath);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading all movie images: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task DisplayImageAsync(string imagePath)
        {
            try
            {
                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    using (var fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        var image = await Task.Run(() => Image.FromStream(fileStream));
                        AddPictureBoxToFlowLayout(image);
                    }
                }
                else
                {
                    MessageBox.Show("Image file not found or path is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPictureBoxToFlowLayout(Image image)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Image = image;
           
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Red, 2))
            {
                //e.Graphics.DrawRectangle(pen, 0, 0, flowLayoutPanel.Width - 1, flowLayoutPanel.Height - 1);
                //e.Graphics.DrawRectangle(pen, 0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

    public static class MovieArrayCreator
    {
        public static Movie[] movies;
        public static async Task<Movie[]> CreateMoviesArrayAsync(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                string query = "SELECT MovieID, Title, ReleaseYear, Genre, Rating, Description, PosterImage, Director FROM Movies";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dtable = new DataTable();
                        await Task.Run(() => adapter.Fill(dtable));

                        movies = new Movie[dtable.Rows.Count];
                        for (int i = 0; i < dtable.Rows.Count; i++)
                        {
                            DataRow row = dtable.Rows[i];
                            movies[i] = new Movie
                            {
                                MovieID = Convert.ToInt32(row["MovieID"]),
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
        }
    }

    public class Movie
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string Description { get; set; }
        public string PosterImage { get; set; }
        public string Director { get; set; }
    }
}
