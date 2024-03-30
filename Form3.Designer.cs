namespace FilmSite
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.moviesTableAdapter1 = new FilmSite.FilmDatabaseDataSetTableAdapters.MoviesTableAdapter();
            this.moviesTableAdapter2 = new FilmSite.FilmDatabaseDataSetTableAdapters.MoviesTableAdapter();
            this.moviesTableAdapter3 = new FilmSite.FilmDatabaseDataSetTableAdapters.MoviesTableAdapter();
            this.moviesTableAdapter4 = new FilmSite.FilmDatabaseDataSetTableAdapters.MoviesTableAdapter();
            this.LoadAllMovies = new System.Windows.Forms.Button();
            this.moviesTableAdapter5 = new FilmSite.FilmDatabaseDataSetTableAdapters.MoviesTableAdapter();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(515, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movies DB";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // moviesTableAdapter1
            // 
            this.moviesTableAdapter1.ClearBeforeFill = true;
            // 
            // moviesTableAdapter2
            // 
            this.moviesTableAdapter2.ClearBeforeFill = true;
            // 
            // moviesTableAdapter3
            // 
            this.moviesTableAdapter3.ClearBeforeFill = true;
            // 
            // moviesTableAdapter4
            // 
            this.moviesTableAdapter4.ClearBeforeFill = true;
            // 
            // LoadAllMovies
            // 
            this.LoadAllMovies.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadAllMovies.Location = new System.Drawing.Point(23, 29);
            this.LoadAllMovies.Name = "LoadAllMovies";
            this.LoadAllMovies.Size = new System.Drawing.Size(256, 40);
            this.LoadAllMovies.TabIndex = 2;
            this.LoadAllMovies.Text = "Load all movies";
            this.LoadAllMovies.UseVisualStyleBackColor = true;
            this.LoadAllMovies.Click += new System.EventHandler(this.LoadAllMovies_Click);
            // 
            // moviesTableAdapter5
            // 
            this.moviesTableAdapter5.ClearBeforeFill = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(23, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(1101, 276);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(299, 400);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(825, 226);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(23, 400);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(972, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1137, 646);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.LoadAllMovies);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label label1;
        private FilmDatabaseDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter1;
        private FilmDatabaseDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter2;
        private FilmDatabaseDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter3;
        private FilmDatabaseDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter4;
        private System.Windows.Forms.Button LoadAllMovies;
        private FilmDatabaseDataSetTableAdapters.MoviesTableAdapter moviesTableAdapter5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}