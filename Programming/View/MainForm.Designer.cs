﻿namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.GroupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.ButtonSeasonHandleGo = new System.Windows.Forms.Button();
            this.ComboBoxSeasons = new System.Windows.Forms.ComboBox();
            this.LabelChoseSeason = new System.Windows.Forms.Label();
            this.GroupBoxWeekdayParsing = new System.Windows.Forms.GroupBox();
            this.LabelResultWeekdayParsing = new System.Windows.Forms.Label();
            this.ButtonWeekdayParsing = new System.Windows.Forms.Button();
            this.TextBoxDayInput = new System.Windows.Forms.TextBox();
            this.LabelTypeValueForParsing = new System.Windows.Forms.Label();
            this.GroupBoxEnumerations = new System.Windows.Forms.GroupBox();
            this.LabelIntValue = new System.Windows.Forms.Label();
            this.IntValue = new System.Windows.Forms.TextBox();
            this.LabelChooseValue = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.LabelChooseEnumeration = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.TabControlEnumerations = new System.Windows.Forms.TabControl();
            this.TabPageClasses = new System.Windows.Forms.TabPage();
            this.GroupBoxMovies = new System.Windows.Forms.GroupBox();
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
            this.GroupBoxRectangles = new System.Windows.Forms.GroupBox();
            this.ButtonFindRectangleWithMaxWidth = new System.Windows.Forms.Button();
            this.TextBoxColorRectangle = new System.Windows.Forms.TextBox();
            this.TextBoxWidthRectangle = new System.Windows.Forms.TextBox();
            this.TextBoxLengthRectangle = new System.Windows.Forms.TextBox();
            this.LabelLengthRectangle = new System.Windows.Forms.Label();
            this.LabelWidthRectangle = new System.Windows.Forms.Label();
            this.LabelColorRectangle = new System.Windows.Forms.Label();
            this.ListBoxRectangles = new System.Windows.Forms.ListBox();
            this.TextBoxCenterCoordinateXRectangle = new System.Windows.Forms.TextBox();
            this.LabelCenterCoordinateXRectangle = new System.Windows.Forms.Label();
            this.TextBoxCenterCoordinateYRectangle = new System.Windows.Forms.TextBox();
            this.LabelCenterCoordinateYRectangle = new System.Windows.Forms.Label();
            this.EnumsTabPage.SuspendLayout();
            this.GroupBoxSeasonHandle.SuspendLayout();
            this.GroupBoxWeekdayParsing.SuspendLayout();
            this.GroupBoxEnumerations.SuspendLayout();
            this.TabControlEnumerations.SuspendLayout();
            this.TabPageClasses.SuspendLayout();
            this.GroupBoxMovies.SuspendLayout();
            this.GroupBoxRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.GroupBoxSeasonHandle);
            this.EnumsTabPage.Controls.Add(this.GroupBoxWeekdayParsing);
            this.EnumsTabPage.Controls.Add(this.GroupBoxEnumerations);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(792, 424);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSeasonHandle
            // 
            this.GroupBoxSeasonHandle.Controls.Add(this.ButtonSeasonHandleGo);
            this.GroupBoxSeasonHandle.Controls.Add(this.ComboBoxSeasons);
            this.GroupBoxSeasonHandle.Controls.Add(this.LabelChoseSeason);
            this.GroupBoxSeasonHandle.Location = new System.Drawing.Point(409, 252);
            this.GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            this.GroupBoxSeasonHandle.Size = new System.Drawing.Size(377, 164);
            this.GroupBoxSeasonHandle.TabIndex = 7;
            this.GroupBoxSeasonHandle.TabStop = false;
            this.GroupBoxSeasonHandle.Text = "Season Handle";
            // 
            // ButtonSeasonHandleGo
            // 
            this.ButtonSeasonHandleGo.Location = new System.Drawing.Point(195, 30);
            this.ButtonSeasonHandleGo.Name = "ButtonSeasonHandleGo";
            this.ButtonSeasonHandleGo.Size = new System.Drawing.Size(79, 23);
            this.ButtonSeasonHandleGo.TabIndex = 2;
            this.ButtonSeasonHandleGo.Text = "Go!";
            this.ButtonSeasonHandleGo.UseVisualStyleBackColor = true;
            this.ButtonSeasonHandleGo.Click += new System.EventHandler(this.ButtonSeasonHandleGo_Click);
            // 
            // ComboBoxSeasons
            // 
            this.ComboBoxSeasons.FormattingEnabled = true;
            this.ComboBoxSeasons.Location = new System.Drawing.Point(6, 31);
            this.ComboBoxSeasons.Name = "ComboBoxSeasons";
            this.ComboBoxSeasons.Size = new System.Drawing.Size(183, 21);
            this.ComboBoxSeasons.TabIndex = 1;
            // 
            // LabelChoseSeason
            // 
            this.LabelChoseSeason.AutoSize = true;
            this.LabelChoseSeason.Location = new System.Drawing.Point(6, 16);
            this.LabelChoseSeason.Name = "LabelChoseSeason";
            this.LabelChoseSeason.Size = new System.Drawing.Size(77, 13);
            this.LabelChoseSeason.TabIndex = 0;
            this.LabelChoseSeason.Text = "Chose season:";
            // 
            // GroupBoxWeekdayParsing
            // 
            this.GroupBoxWeekdayParsing.Controls.Add(this.LabelResultWeekdayParsing);
            this.GroupBoxWeekdayParsing.Controls.Add(this.ButtonWeekdayParsing);
            this.GroupBoxWeekdayParsing.Controls.Add(this.TextBoxDayInput);
            this.GroupBoxWeekdayParsing.Controls.Add(this.LabelTypeValueForParsing);
            this.GroupBoxWeekdayParsing.Location = new System.Drawing.Point(8, 252);
            this.GroupBoxWeekdayParsing.Name = "GroupBoxWeekdayParsing";
            this.GroupBoxWeekdayParsing.Size = new System.Drawing.Size(377, 164);
            this.GroupBoxWeekdayParsing.TabIndex = 1;
            this.GroupBoxWeekdayParsing.TabStop = false;
            this.GroupBoxWeekdayParsing.Text = "Weekday Parsing";
            // 
            // LabelResultWeekdayParsing
            // 
            this.LabelResultWeekdayParsing.AutoSize = true;
            this.LabelResultWeekdayParsing.Location = new System.Drawing.Point(6, 55);
            this.LabelResultWeekdayParsing.Name = "LabelResultWeekdayParsing";
            this.LabelResultWeekdayParsing.Size = new System.Drawing.Size(0, 13);
            this.LabelResultWeekdayParsing.TabIndex = 1;
            // 
            // ButtonWeekdayParsing
            // 
            this.ButtonWeekdayParsing.Location = new System.Drawing.Point(195, 30);
            this.ButtonWeekdayParsing.Name = "ButtonWeekdayParsing";
            this.ButtonWeekdayParsing.Size = new System.Drawing.Size(79, 23);
            this.ButtonWeekdayParsing.TabIndex = 8;
            this.ButtonWeekdayParsing.Text = "Parse";
            this.ButtonWeekdayParsing.UseVisualStyleBackColor = true;
            this.ButtonWeekdayParsing.Click += new System.EventHandler(this.ButtonWeekdayParsing_Click);
            // 
            // TextBoxDayInput
            // 
            this.TextBoxDayInput.Location = new System.Drawing.Point(6, 31);
            this.TextBoxDayInput.Name = "TextBoxDayInput";
            this.TextBoxDayInput.Size = new System.Drawing.Size(183, 20);
            this.TextBoxDayInput.TabIndex = 7;
            // 
            // LabelTypeValueForParsing
            // 
            this.LabelTypeValueForParsing.AutoSize = true;
            this.LabelTypeValueForParsing.Location = new System.Drawing.Point(3, 16);
            this.LabelTypeValueForParsing.Name = "LabelTypeValueForParsing";
            this.LabelTypeValueForParsing.Size = new System.Drawing.Size(115, 13);
            this.LabelTypeValueForParsing.TabIndex = 0;
            this.LabelTypeValueForParsing.Text = "Type value for parsing:";
            // 
            // GroupBoxEnumerations
            // 
            this.GroupBoxEnumerations.AutoSize = true;
            this.GroupBoxEnumerations.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxEnumerations.Controls.Add(this.LabelIntValue);
            this.GroupBoxEnumerations.Controls.Add(this.IntValue);
            this.GroupBoxEnumerations.Controls.Add(this.LabelChooseValue);
            this.GroupBoxEnumerations.Controls.Add(this.EnumsListBox);
            this.GroupBoxEnumerations.Controls.Add(this.LabelChooseEnumeration);
            this.GroupBoxEnumerations.Controls.Add(this.ValuesListBox);
            this.GroupBoxEnumerations.Location = new System.Drawing.Point(8, 6);
            this.GroupBoxEnumerations.Name = "GroupBoxEnumerations";
            this.GroupBoxEnumerations.Size = new System.Drawing.Size(778, 240);
            this.GroupBoxEnumerations.TabIndex = 6;
            this.GroupBoxEnumerations.TabStop = false;
            this.GroupBoxEnumerations.Text = "Enumerations";
            // 
            // LabelIntValue
            // 
            this.LabelIntValue.AutoSize = true;
            this.LabelIntValue.Location = new System.Drawing.Point(311, 15);
            this.LabelIntValue.Name = "LabelIntValue";
            this.LabelIntValue.Size = new System.Drawing.Size(51, 13);
            this.LabelIntValue.TabIndex = 5;
            this.LabelIntValue.Text = "Int value:";
            // 
            // IntValue
            // 
            this.IntValue.Location = new System.Drawing.Point(314, 31);
            this.IntValue.Name = "IntValue";
            this.IntValue.Size = new System.Drawing.Size(120, 20);
            this.IntValue.TabIndex = 2;
            this.IntValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IntValue_KeyPress);
            // 
            // LabelChooseValue
            // 
            this.LabelChooseValue.AutoSize = true;
            this.LabelChooseValue.Location = new System.Drawing.Point(157, 15);
            this.LabelChooseValue.Name = "LabelChooseValue";
            this.LabelChooseValue.Size = new System.Drawing.Size(75, 13);
            this.LabelChooseValue.TabIndex = 4;
            this.LabelChooseValue.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Color",
            "EducationForm",
            "Genre",
            "Manufactures",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(6, 31);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(120, 186);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // LabelChooseEnumeration
            // 
            this.LabelChooseEnumeration.AutoSize = true;
            this.LabelChooseEnumeration.Location = new System.Drawing.Point(3, 15);
            this.LabelChooseEnumeration.Name = "LabelChooseEnumeration";
            this.LabelChooseEnumeration.Size = new System.Drawing.Size(107, 13);
            this.LabelChooseEnumeration.TabIndex = 3;
            this.LabelChooseEnumeration.Text = "Choose enumaration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(160, 31);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(120, 186);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // TabControlEnumerations
            // 
            this.TabControlEnumerations.Controls.Add(this.EnumsTabPage);
            this.TabControlEnumerations.Controls.Add(this.TabPageClasses);
            this.TabControlEnumerations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlEnumerations.Location = new System.Drawing.Point(0, 0);
            this.TabControlEnumerations.Name = "TabControlEnumerations";
            this.TabControlEnumerations.SelectedIndex = 0;
            this.TabControlEnumerations.Size = new System.Drawing.Size(800, 450);
            this.TabControlEnumerations.TabIndex = 0;
            // 
            // TabPageClasses
            // 
            this.TabPageClasses.Controls.Add(this.GroupBoxMovies);
            this.TabPageClasses.Controls.Add(this.GroupBoxRectangles);
            this.TabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.TabPageClasses.Name = "TabPageClasses";
            this.TabPageClasses.Size = new System.Drawing.Size(792, 424);
            this.TabPageClasses.TabIndex = 1;
            this.TabPageClasses.Text = "Classes";
            this.TabPageClasses.UseVisualStyleBackColor = true;
            // 
            // GroupBoxMovies
            // 
            this.GroupBoxMovies.Controls.Add(this.TextBoxRatingMovie);
            this.GroupBoxMovies.Controls.Add(this.TextBoxGenreMovie);
            this.GroupBoxMovies.Controls.Add(this.LabelRatingMovie);
            this.GroupBoxMovies.Controls.Add(this.LabelGenreMovie);
            this.GroupBoxMovies.Controls.Add(this.ButtonFindMovieWithMaxRating);
            this.GroupBoxMovies.Controls.Add(this.TextBoxReleaseYearMovie);
            this.GroupBoxMovies.Controls.Add(this.TextBoxDurationMinutesMovie);
            this.GroupBoxMovies.Controls.Add(this.TextBoxTitleMovie);
            this.GroupBoxMovies.Controls.Add(this.LabelTitleMovie);
            this.GroupBoxMovies.Controls.Add(this.LabelDurationMinutesMovie);
            this.GroupBoxMovies.Controls.Add(this.LabelReleaseYearMovie);
            this.GroupBoxMovies.Controls.Add(this.ListBoxMovies);
            this.GroupBoxMovies.Location = new System.Drawing.Point(404, 3);
            this.GroupBoxMovies.Name = "GroupBoxMovies";
            this.GroupBoxMovies.Size = new System.Drawing.Size(378, 212);
            this.GroupBoxMovies.TabIndex = 7;
            this.GroupBoxMovies.TabStop = false;
            this.GroupBoxMovies.Text = "Movies";
            // 
            // TextBoxRatingMovie
            // 
            this.TextBoxRatingMovie.Location = new System.Drawing.Point(260, 83);
            this.TextBoxRatingMovie.Name = "TextBoxRatingMovie";
            this.TextBoxRatingMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRatingMovie.TabIndex = 10;
            this.TextBoxRatingMovie.TextChanged += new System.EventHandler(this.TextBoxRatingMovie_TextChanged);
            // 
            // TextBoxGenreMovie
            // 
            this.TextBoxGenreMovie.Location = new System.Drawing.Point(260, 35);
            this.TextBoxGenreMovie.Name = "TextBoxGenreMovie";
            this.TextBoxGenreMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxGenreMovie.TabIndex = 9;
            this.TextBoxGenreMovie.TextChanged += new System.EventHandler(this.TextBoxGenreMovie_TextChanged);
            // 
            // LabelRatingMovie
            // 
            this.LabelRatingMovie.AutoSize = true;
            this.LabelRatingMovie.Location = new System.Drawing.Point(257, 67);
            this.LabelRatingMovie.Name = "LabelRatingMovie";
            this.LabelRatingMovie.Size = new System.Drawing.Size(41, 13);
            this.LabelRatingMovie.TabIndex = 8;
            this.LabelRatingMovie.Text = "Rating:";
            // 
            // LabelGenreMovie
            // 
            this.LabelGenreMovie.AutoSize = true;
            this.LabelGenreMovie.Location = new System.Drawing.Point(257, 19);
            this.LabelGenreMovie.Name = "LabelGenreMovie";
            this.LabelGenreMovie.Size = new System.Drawing.Size(39, 13);
            this.LabelGenreMovie.TabIndex = 7;
            this.LabelGenreMovie.Text = "Genre:";
            // 
            // ButtonFindMovieWithMaxRating
            // 
            this.ButtonFindMovieWithMaxRating.Location = new System.Drawing.Point(132, 176);
            this.ButtonFindMovieWithMaxRating.Name = "ButtonFindMovieWithMaxRating";
            this.ButtonFindMovieWithMaxRating.Size = new System.Drawing.Size(100, 29);
            this.ButtonFindMovieWithMaxRating.TabIndex = 1;
            this.ButtonFindMovieWithMaxRating.Text = "Find";
            this.ButtonFindMovieWithMaxRating.UseVisualStyleBackColor = true;
            this.ButtonFindMovieWithMaxRating.Click += new System.EventHandler(this.ButtonFindMovieWithMaxRating_Click);
            // 
            // TextBoxReleaseYearMovie
            // 
            this.TextBoxReleaseYearMovie.Location = new System.Drawing.Point(132, 131);
            this.TextBoxReleaseYearMovie.Name = "TextBoxReleaseYearMovie";
            this.TextBoxReleaseYearMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxReleaseYearMovie.TabIndex = 6;
            this.TextBoxReleaseYearMovie.TextChanged += new System.EventHandler(this.TextBoxReleaseYearMovie_TextChanged);
            // 
            // TextBoxDurationMinutesMovie
            // 
            this.TextBoxDurationMinutesMovie.Location = new System.Drawing.Point(132, 83);
            this.TextBoxDurationMinutesMovie.Name = "TextBoxDurationMinutesMovie";
            this.TextBoxDurationMinutesMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDurationMinutesMovie.TabIndex = 5;
            this.TextBoxDurationMinutesMovie.TextChanged += new System.EventHandler(this.TextBoxDurationMinutesMovie_TextChanged);
            // 
            // TextBoxTitleMovie
            // 
            this.TextBoxTitleMovie.Location = new System.Drawing.Point(132, 35);
            this.TextBoxTitleMovie.Name = "TextBoxTitleMovie";
            this.TextBoxTitleMovie.Size = new System.Drawing.Size(100, 20);
            this.TextBoxTitleMovie.TabIndex = 4;
            this.TextBoxTitleMovie.TextChanged += new System.EventHandler(this.TextBoxTitleMovie_TextChanged);
            // 
            // LabelTitleMovie
            // 
            this.LabelTitleMovie.AutoSize = true;
            this.LabelTitleMovie.Location = new System.Drawing.Point(129, 19);
            this.LabelTitleMovie.Name = "LabelTitleMovie";
            this.LabelTitleMovie.Size = new System.Drawing.Size(30, 13);
            this.LabelTitleMovie.TabIndex = 1;
            this.LabelTitleMovie.Text = "Title:";
            // 
            // LabelDurationMinutesMovie
            // 
            this.LabelDurationMinutesMovie.AutoSize = true;
            this.LabelDurationMinutesMovie.Location = new System.Drawing.Point(129, 67);
            this.LabelDurationMinutesMovie.Name = "LabelDurationMinutesMovie";
            this.LabelDurationMinutesMovie.Size = new System.Drawing.Size(106, 13);
            this.LabelDurationMinutesMovie.TabIndex = 2;
            this.LabelDurationMinutesMovie.Text = "Duration (in minutes):";
            // 
            // LabelReleaseYearMovie
            // 
            this.LabelReleaseYearMovie.AutoSize = true;
            this.LabelReleaseYearMovie.Location = new System.Drawing.Point(132, 115);
            this.LabelReleaseYearMovie.Name = "LabelReleaseYearMovie";
            this.LabelReleaseYearMovie.Size = new System.Drawing.Size(72, 13);
            this.LabelReleaseYearMovie.TabIndex = 3;
            this.LabelReleaseYearMovie.Text = "Release year:";
            // 
            // ListBoxMovies
            // 
            this.ListBoxMovies.FormattingEnabled = true;
            this.ListBoxMovies.Location = new System.Drawing.Point(6, 19);
            this.ListBoxMovies.Name = "ListBoxMovies";
            this.ListBoxMovies.Size = new System.Drawing.Size(120, 186);
            this.ListBoxMovies.TabIndex = 0;
            this.ListBoxMovies.SelectedIndexChanged += new System.EventHandler(this.ListBoxMovies_SelectedIndexChanged);
            // 
            // GroupBoxRectangles
            // 
            this.GroupBoxRectangles.Controls.Add(this.TextBoxCenterCoordinateYRectangle);
            this.GroupBoxRectangles.Controls.Add(this.LabelCenterCoordinateYRectangle);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxCenterCoordinateXRectangle);
            this.GroupBoxRectangles.Controls.Add(this.LabelCenterCoordinateXRectangle);
            this.GroupBoxRectangles.Controls.Add(this.ButtonFindRectangleWithMaxWidth);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxColorRectangle);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxWidthRectangle);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxLengthRectangle);
            this.GroupBoxRectangles.Controls.Add(this.LabelLengthRectangle);
            this.GroupBoxRectangles.Controls.Add(this.LabelWidthRectangle);
            this.GroupBoxRectangles.Controls.Add(this.LabelColorRectangle);
            this.GroupBoxRectangles.Controls.Add(this.ListBoxRectangles);
            this.GroupBoxRectangles.Location = new System.Drawing.Point(11, 3);
            this.GroupBoxRectangles.Name = "GroupBoxRectangles";
            this.GroupBoxRectangles.Size = new System.Drawing.Size(378, 212);
            this.GroupBoxRectangles.TabIndex = 0;
            this.GroupBoxRectangles.TabStop = false;
            this.GroupBoxRectangles.Text = "Rectangles";
            // 
            // ButtonFindRectangleWithMaxWidth
            // 
            this.ButtonFindRectangleWithMaxWidth.Location = new System.Drawing.Point(132, 176);
            this.ButtonFindRectangleWithMaxWidth.Name = "ButtonFindRectangleWithMaxWidth";
            this.ButtonFindRectangleWithMaxWidth.Size = new System.Drawing.Size(100, 29);
            this.ButtonFindRectangleWithMaxWidth.TabIndex = 1;
            this.ButtonFindRectangleWithMaxWidth.Text = "Find";
            this.ButtonFindRectangleWithMaxWidth.UseVisualStyleBackColor = true;
            this.ButtonFindRectangleWithMaxWidth.Click += new System.EventHandler(this.ButtonFindRectangleWithMaxWidth_Click);
            // 
            // TextBoxColorRectangle
            // 
            this.TextBoxColorRectangle.Location = new System.Drawing.Point(132, 131);
            this.TextBoxColorRectangle.Name = "TextBoxColorRectangle";
            this.TextBoxColorRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxColorRectangle.TabIndex = 6;
            this.TextBoxColorRectangle.TextChanged += new System.EventHandler(this.TextBoxColorRectangle_TextChanged);
            // 
            // TextBoxWidthRectangle
            // 
            this.TextBoxWidthRectangle.Location = new System.Drawing.Point(132, 83);
            this.TextBoxWidthRectangle.Name = "TextBoxWidthRectangle";
            this.TextBoxWidthRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxWidthRectangle.TabIndex = 5;
            this.TextBoxWidthRectangle.TextChanged += new System.EventHandler(this.TextBoxWidthRectangle_TextChanged);
            // 
            // TextBoxLengthRectangle
            // 
            this.TextBoxLengthRectangle.Location = new System.Drawing.Point(132, 35);
            this.TextBoxLengthRectangle.Name = "TextBoxLengthRectangle";
            this.TextBoxLengthRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLengthRectangle.TabIndex = 4;
            this.TextBoxLengthRectangle.TextChanged += new System.EventHandler(this.TextBoxLengthRectangle_TextChanged);
            // 
            // LabelLengthRectangle
            // 
            this.LabelLengthRectangle.AutoSize = true;
            this.LabelLengthRectangle.Location = new System.Drawing.Point(129, 19);
            this.LabelLengthRectangle.Name = "LabelLengthRectangle";
            this.LabelLengthRectangle.Size = new System.Drawing.Size(43, 13);
            this.LabelLengthRectangle.TabIndex = 1;
            this.LabelLengthRectangle.Text = "Length:";
            // 
            // LabelWidthRectangle
            // 
            this.LabelWidthRectangle.AutoSize = true;
            this.LabelWidthRectangle.Location = new System.Drawing.Point(129, 67);
            this.LabelWidthRectangle.Name = "LabelWidthRectangle";
            this.LabelWidthRectangle.Size = new System.Drawing.Size(38, 13);
            this.LabelWidthRectangle.TabIndex = 2;
            this.LabelWidthRectangle.Text = "Width:";
            // 
            // LabelColorRectangle
            // 
            this.LabelColorRectangle.AutoSize = true;
            this.LabelColorRectangle.Location = new System.Drawing.Point(132, 115);
            this.LabelColorRectangle.Name = "LabelColorRectangle";
            this.LabelColorRectangle.Size = new System.Drawing.Size(34, 13);
            this.LabelColorRectangle.TabIndex = 3;
            this.LabelColorRectangle.Text = "Color:";
            // 
            // ListBoxRectangles
            // 
            this.ListBoxRectangles.FormattingEnabled = true;
            this.ListBoxRectangles.Location = new System.Drawing.Point(6, 19);
            this.ListBoxRectangles.Name = "ListBoxRectangles";
            this.ListBoxRectangles.Size = new System.Drawing.Size(120, 186);
            this.ListBoxRectangles.TabIndex = 0;
            this.ListBoxRectangles.SelectedIndexChanged += new System.EventHandler(this.ListBoxRectangles_SelectedIndexChanged);
            // 
            // TextBoxCenterCoordinateXRectangle
            // 
            this.TextBoxCenterCoordinateXRectangle.Location = new System.Drawing.Point(259, 35);
            this.TextBoxCenterCoordinateXRectangle.Name = "TextBoxCenterCoordinateXRectangle";
            this.TextBoxCenterCoordinateXRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCenterCoordinateXRectangle.TabIndex = 8;
            this.TextBoxCenterCoordinateXRectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCenterCoordinateXRectangle_KeyPress);
            // 
            // LabelCenterCoordinateXRectangle
            // 
            this.LabelCenterCoordinateXRectangle.AutoSize = true;
            this.LabelCenterCoordinateXRectangle.Location = new System.Drawing.Point(256, 19);
            this.LabelCenterCoordinateXRectangle.Name = "LabelCenterCoordinateXRectangle";
            this.LabelCenterCoordinateXRectangle.Size = new System.Drawing.Size(104, 13);
            this.LabelCenterCoordinateXRectangle.TabIndex = 7;
            this.LabelCenterCoordinateXRectangle.Text = "Center coordinate X:";
            // 
            // TextBoxCenterCoordinateYRectangle
            // 
            this.TextBoxCenterCoordinateYRectangle.Location = new System.Drawing.Point(259, 83);
            this.TextBoxCenterCoordinateYRectangle.Name = "TextBoxCenterCoordinateYRectangle";
            this.TextBoxCenterCoordinateYRectangle.Size = new System.Drawing.Size(100, 20);
            this.TextBoxCenterCoordinateYRectangle.TabIndex = 10;
            this.TextBoxCenterCoordinateYRectangle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCenterCoordinateYRectangle_KeyPress);
            // 
            // LabelCenterCoordinateYRectangle
            // 
            this.LabelCenterCoordinateYRectangle.AutoSize = true;
            this.LabelCenterCoordinateYRectangle.Location = new System.Drawing.Point(256, 67);
            this.LabelCenterCoordinateYRectangle.Name = "LabelCenterCoordinateYRectangle";
            this.LabelCenterCoordinateYRectangle.Size = new System.Drawing.Size(104, 13);
            this.LabelCenterCoordinateYRectangle.TabIndex = 9;
            this.LabelCenterCoordinateYRectangle.Text = "Center coordinate Y:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlEnumerations);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsTabPage.PerformLayout();
            this.GroupBoxSeasonHandle.ResumeLayout(false);
            this.GroupBoxSeasonHandle.PerformLayout();
            this.GroupBoxWeekdayParsing.ResumeLayout(false);
            this.GroupBoxWeekdayParsing.PerformLayout();
            this.GroupBoxEnumerations.ResumeLayout(false);
            this.GroupBoxEnumerations.PerformLayout();
            this.TabControlEnumerations.ResumeLayout(false);
            this.TabPageClasses.ResumeLayout(false);
            this.GroupBoxMovies.ResumeLayout(false);
            this.GroupBoxMovies.PerformLayout();
            this.GroupBoxRectangles.ResumeLayout(false);
            this.GroupBoxRectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TextBox IntValue;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TabControl TabControlEnumerations;
        private System.Windows.Forms.Label LabelIntValue;
        private System.Windows.Forms.Label LabelChooseValue;
        private System.Windows.Forms.Label LabelChooseEnumeration;
        private System.Windows.Forms.GroupBox GroupBoxEnumerations;
        private System.Windows.Forms.GroupBox GroupBoxWeekdayParsing;
        private System.Windows.Forms.Label LabelTypeValueForParsing;
        private System.Windows.Forms.Button ButtonWeekdayParsing;
        private System.Windows.Forms.TextBox TextBoxDayInput;
        private System.Windows.Forms.Label LabelResultWeekdayParsing;
        private System.Windows.Forms.GroupBox GroupBoxSeasonHandle;
        private System.Windows.Forms.Button ButtonSeasonHandleGo;
        private System.Windows.Forms.ComboBox ComboBoxSeasons;
        private System.Windows.Forms.Label LabelChoseSeason;
        private System.Windows.Forms.TabPage TabPageClasses;
        private System.Windows.Forms.GroupBox GroupBoxRectangles;
        private System.Windows.Forms.ListBox ListBoxRectangles;
        private System.Windows.Forms.Button ButtonFindRectangleWithMaxWidth;
        private System.Windows.Forms.GroupBox GroupBoxMovies;
        private System.Windows.Forms.Button ButtonFindMovieWithMaxRating;
        private System.Windows.Forms.ListBox ListBoxMovies;
        private System.Windows.Forms.Label LabelGenreMovie;
        private System.Windows.Forms.Label LabelRatingMovie;
        private System.Windows.Forms.TextBox TextBoxRatingMovie;
        private System.Windows.Forms.TextBox TextBoxGenreMovie;
        private System.Windows.Forms.TextBox TextBoxReleaseYearMovie;
        private System.Windows.Forms.TextBox TextBoxDurationMinutesMovie;
        private System.Windows.Forms.TextBox TextBoxTitleMovie;
        private System.Windows.Forms.Label LabelTitleMovie;
        private System.Windows.Forms.Label LabelDurationMinutesMovie;
        private System.Windows.Forms.Label LabelReleaseYearMovie;
        private System.Windows.Forms.TextBox TextBoxColorRectangle;
        private System.Windows.Forms.TextBox TextBoxWidthRectangle;
        private System.Windows.Forms.TextBox TextBoxLengthRectangle;
        private System.Windows.Forms.Label LabelLengthRectangle;
        private System.Windows.Forms.Label LabelWidthRectangle;
        private System.Windows.Forms.Label LabelColorRectangle;
        private System.Windows.Forms.TextBox TextBoxCenterCoordinateXRectangle;
        private System.Windows.Forms.Label LabelCenterCoordinateXRectangle;
        private System.Windows.Forms.TextBox TextBoxCenterCoordinateYRectangle;
        private System.Windows.Forms.Label LabelCenterCoordinateYRectangle;
    }
}
