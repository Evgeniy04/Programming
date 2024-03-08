namespace Programming.View.Panels
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBoxRatingMovie = new System.Windows.Forms.TextBox();
            this.TextBoxGenreMovie = new System.Windows.Forms.TextBox();
            this.LabelRatingMovie = new System.Windows.Forms.Label();
            this.LabelGenreMovie = new System.Windows.Forms.Label();
            this.ButtonFindMovieWithMaxRating = new System.Windows.Forms.Button();
            this.TextBoxReleaseYearMovie = new System.Windows.Forms.TextBox();
            this.TextBoxDurationMinutesMovie = new System.Windows.Forms.TextBox();
            this.TextBoxTitleMovie = new System.Windows.Forms.TextBox();
            this.LabelTitleMovie = new System.Windows.Forms.Label();
            this.LabelDurationMinutesMovie = new System.Windows.Forms.Label();
            this.LabelReleaseYearMovie = new System.Windows.Forms.Label();
            this.ListBoxMovies = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextBoxRatingMovie
            // 
            this.TextBoxRatingMovie.Location = new System.Drawing.Point(254, 64);
            this.TextBoxRatingMovie.Name = "TextBoxRatingMovie";
            this.TextBoxRatingMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRatingMovie.TabIndex = 10;
            this.TextBoxRatingMovie.TextChanged += new System.EventHandler(this.TextBoxRatingMovie_TextChanged);
            // 
            // TextBoxGenreMovie
            // 
            this.TextBoxGenreMovie.Location = new System.Drawing.Point(254, 16);
            this.TextBoxGenreMovie.Name = "TextBoxGenreMovie";
            this.TextBoxGenreMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxGenreMovie.TabIndex = 9;
            this.TextBoxGenreMovie.TextChanged += new System.EventHandler(this.TextBoxGenreMovie_TextChanged);
            // 
            // LabelRatingMovie
            // 
            this.LabelRatingMovie.AutoSize = true;
            this.LabelRatingMovie.Location = new System.Drawing.Point(251, 48);
            this.LabelRatingMovie.Name = "LabelRatingMovie";
            this.LabelRatingMovie.Size = new System.Drawing.Size(41, 13);
            this.LabelRatingMovie.TabIndex = 8;
            this.LabelRatingMovie.Text = "Rating:";
            // 
            // LabelGenreMovie
            // 
            this.LabelGenreMovie.AutoSize = true;
            this.LabelGenreMovie.Location = new System.Drawing.Point(251, 0);
            this.LabelGenreMovie.Name = "LabelGenreMovie";
            this.LabelGenreMovie.Size = new System.Drawing.Size(39, 13);
            this.LabelGenreMovie.TabIndex = 7;
            this.LabelGenreMovie.Text = "Genre:";
            // 
            // ButtonFindMovieWithMaxRating
            // 
            this.ButtonFindMovieWithMaxRating.Location = new System.Drawing.Point(126, 157);
            this.ButtonFindMovieWithMaxRating.Name = "ButtonFindMovieWithMaxRating";
            this.ButtonFindMovieWithMaxRating.Size = new System.Drawing.Size(100, 29);
            this.ButtonFindMovieWithMaxRating.TabIndex = 1;
            this.ButtonFindMovieWithMaxRating.Text = "Find";
            this.ButtonFindMovieWithMaxRating.UseVisualStyleBackColor = true;
            this.ButtonFindMovieWithMaxRating.Click += new System.EventHandler(this.ButtonFindMovieWithMaxRating_Click);
            // 
            // TextBoxReleaseYearMovie
            // 
            this.TextBoxReleaseYearMovie.Location = new System.Drawing.Point(126, 112);
            this.TextBoxReleaseYearMovie.Name = "TextBoxReleaseYearMovie";
            this.TextBoxReleaseYearMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxReleaseYearMovie.TabIndex = 6;
            this.TextBoxReleaseYearMovie.TextChanged += new System.EventHandler(this.TextBoxReleaseYearMovie_TextChanged);
            // 
            // TextBoxDurationMinutesMovie
            // 
            this.TextBoxDurationMinutesMovie.Location = new System.Drawing.Point(126, 64);
            this.TextBoxDurationMinutesMovie.Name = "TextBoxDurationMinutesMovie";
            this.TextBoxDurationMinutesMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDurationMinutesMovie.TabIndex = 5;
            this.TextBoxDurationMinutesMovie.TextChanged += new System.EventHandler(this.TextBoxDurationMinutesMovie_TextChanged);
            // 
            // TextBoxTitleMovie
            // 
            this.TextBoxTitleMovie.Location = new System.Drawing.Point(126, 16);
            this.TextBoxTitleMovie.Name = "TextBoxTitleMovie";
            this.TextBoxTitleMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTitleMovie.TabIndex = 4;
            this.TextBoxTitleMovie.TextChanged += new System.EventHandler(this.TextBoxTitleMovie_TextChanged);
            // 
            // LabelTitleMovie
            // 
            this.LabelTitleMovie.AutoSize = true;
            this.LabelTitleMovie.Location = new System.Drawing.Point(123, 0);
            this.LabelTitleMovie.Name = "LabelTitleMovie";
            this.LabelTitleMovie.Size = new System.Drawing.Size(30, 13);
            this.LabelTitleMovie.TabIndex = 1;
            this.LabelTitleMovie.Text = "Title:";
            // 
            // LabelDurationMinutesMovie
            // 
            this.LabelDurationMinutesMovie.AutoSize = true;
            this.LabelDurationMinutesMovie.Location = new System.Drawing.Point(123, 48);
            this.LabelDurationMinutesMovie.Name = "LabelDurationMinutesMovie";
            this.LabelDurationMinutesMovie.Size = new System.Drawing.Size(106, 13);
            this.LabelDurationMinutesMovie.TabIndex = 2;
            this.LabelDurationMinutesMovie.Text = "Duration (in minutes):";
            // 
            // LabelReleaseYearMovie
            // 
            this.LabelReleaseYearMovie.AutoSize = true;
            this.LabelReleaseYearMovie.Location = new System.Drawing.Point(126, 96);
            this.LabelReleaseYearMovie.Name = "LabelReleaseYearMovie";
            this.LabelReleaseYearMovie.Size = new System.Drawing.Size(72, 13);
            this.LabelReleaseYearMovie.TabIndex = 3;
            this.LabelReleaseYearMovie.Text = "Release year:";
            // 
            // ListBoxMovies
            // 
            this.ListBoxMovies.FormattingEnabled = true;
            this.ListBoxMovies.Location = new System.Drawing.Point(0, 0);
            this.ListBoxMovies.Name = "ListBoxMovies";
            this.ListBoxMovies.Size = new System.Drawing.Size(120, 186);
            this.ListBoxMovies.TabIndex = 0;
            this.ListBoxMovies.SelectedIndexChanged += new System.EventHandler(this.ListBoxMovies_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxRatingMovie);
            this.Controls.Add(this.TextBoxGenreMovie);
            this.Controls.Add(this.ListBoxMovies);
            this.Controls.Add(this.LabelRatingMovie);
            this.Controls.Add(this.LabelReleaseYearMovie);
            this.Controls.Add(this.LabelGenreMovie);
            this.Controls.Add(this.LabelDurationMinutesMovie);
            this.Controls.Add(this.ButtonFindMovieWithMaxRating);
            this.Controls.Add(this.LabelTitleMovie);
            this.Controls.Add(this.TextBoxReleaseYearMovie);
            this.Controls.Add(this.TextBoxTitleMovie);
            this.Controls.Add(this.TextBoxDurationMinutesMovie);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(358, 188);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxRatingMovie;
        private System.Windows.Forms.TextBox TextBoxGenreMovie;
        private System.Windows.Forms.Label LabelRatingMovie;
        private System.Windows.Forms.Label LabelGenreMovie;
        private System.Windows.Forms.Button ButtonFindMovieWithMaxRating;
        private System.Windows.Forms.TextBox TextBoxReleaseYearMovie;
        private System.Windows.Forms.TextBox TextBoxDurationMinutesMovie;
        private System.Windows.Forms.TextBox TextBoxTitleMovie;
        private System.Windows.Forms.Label LabelTitleMovie;
        private System.Windows.Forms.Label LabelDurationMinutesMovie;
        private System.Windows.Forms.Label LabelReleaseYearMovie;
        private System.Windows.Forms.ListBox ListBoxMovies;
    }
}
