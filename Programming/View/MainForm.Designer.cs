namespace Programming
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
            this.TabPageEnums = new System.Windows.Forms.TabPage();
            this.GroupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.SeasonsHandlePanel = new Programming.View.Panels.SeasonsHandlePanel();
            this.GroupBoxWeekdayParsing = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingPanel = new Programming.View.Panels.WeekdayParsingPanel();
            this.GroupBoxEnumerations = new System.Windows.Forms.GroupBox();
            this.EnumerationsPanel = new Programming.View.Panels.EnumerationsPanel();
            this.TabControlEnumerations = new System.Windows.Forms.TabControl();
            this.TabPageClasses = new System.Windows.Forms.TabPage();
            this.GroupBoxMovies = new System.Windows.Forms.GroupBox();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.GroupBoxRectangles = new System.Windows.Forms.GroupBox();
            this.rectanglesControl1 = new Programming.View.Panels.RectanglesControl();
            this.TabPageRectangles = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.TabPageEnums.SuspendLayout();
            this.GroupBoxSeasonHandle.SuspendLayout();
            this.GroupBoxWeekdayParsing.SuspendLayout();
            this.GroupBoxEnumerations.SuspendLayout();
            this.TabControlEnumerations.SuspendLayout();
            this.TabPageClasses.SuspendLayout();
            this.GroupBoxMovies.SuspendLayout();
            this.GroupBoxRectangles.SuspendLayout();
            this.TabPageRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPageEnums
            // 
            this.TabPageEnums.Controls.Add(this.GroupBoxSeasonHandle);
            this.TabPageEnums.Controls.Add(this.GroupBoxWeekdayParsing);
            this.TabPageEnums.Controls.Add(this.GroupBoxEnumerations);
            this.TabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.TabPageEnums.Name = "TabPageEnums";
            this.TabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEnums.Size = new System.Drawing.Size(792, 424);
            this.TabPageEnums.TabIndex = 0;
            this.TabPageEnums.Text = "Enums";
            this.TabPageEnums.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSeasonHandle
            // 
            this.GroupBoxSeasonHandle.Controls.Add(this.SeasonsHandlePanel);
            this.GroupBoxSeasonHandle.Location = new System.Drawing.Point(409, 252);
            this.GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            this.GroupBoxSeasonHandle.Size = new System.Drawing.Size(377, 164);
            this.GroupBoxSeasonHandle.TabIndex = 9;
            this.GroupBoxSeasonHandle.TabStop = false;
            this.GroupBoxSeasonHandle.Text = "Season Handle";
            // 
            // SeasonsHandlePanel
            // 
            this.SeasonsHandlePanel.Location = new System.Drawing.Point(6, 16);
            this.SeasonsHandlePanel.Name = "SeasonsHandlePanel";
            this.SeasonsHandlePanel.Size = new System.Drawing.Size(273, 39);
            this.SeasonsHandlePanel.TabIndex = 0;
            this.SeasonsHandlePanel.SeasonChanged += new System.EventHandler<Programming.View.Panels.SeasonChangedEventArgs>(this.SeasonsHandlePanel_SeasonChanged);
            // 
            // GroupBoxWeekdayParsing
            // 
            this.GroupBoxWeekdayParsing.Controls.Add(this.WeekdayParsingPanel);
            this.GroupBoxWeekdayParsing.Location = new System.Drawing.Point(8, 252);
            this.GroupBoxWeekdayParsing.Name = "GroupBoxWeekdayParsing";
            this.GroupBoxWeekdayParsing.Size = new System.Drawing.Size(377, 164);
            this.GroupBoxWeekdayParsing.TabIndex = 12;
            this.GroupBoxWeekdayParsing.TabStop = false;
            this.GroupBoxWeekdayParsing.Text = "Weekday Parsing";
            // 
            // WeekdayParsingPanel
            // 
            this.WeekdayParsingPanel.Color = System.Drawing.Color.Empty;
            this.WeekdayParsingPanel.Location = new System.Drawing.Point(3, 16);
            this.WeekdayParsingPanel.Name = "WeekdayParsingPanel";
            this.WeekdayParsingPanel.Size = new System.Drawing.Size(272, 56);
            this.WeekdayParsingPanel.TabIndex = 0;
            // 
            // GroupBoxEnumerations
            // 
            this.GroupBoxEnumerations.AutoSize = true;
            this.GroupBoxEnumerations.BackColor = System.Drawing.Color.Transparent;
            this.GroupBoxEnumerations.Controls.Add(this.EnumerationsPanel);
            this.GroupBoxEnumerations.Location = new System.Drawing.Point(8, 6);
            this.GroupBoxEnumerations.Name = "GroupBoxEnumerations";
            this.GroupBoxEnumerations.Size = new System.Drawing.Size(778, 240);
            this.GroupBoxEnumerations.TabIndex = 10;
            this.GroupBoxEnumerations.TabStop = false;
            this.GroupBoxEnumerations.Text = "Enumerations";
            // 
            // EnumerationsPanel
            // 
            this.EnumerationsPanel.Color = System.Drawing.Color.Empty;
            this.EnumerationsPanel.Location = new System.Drawing.Point(3, 16);
            this.EnumerationsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.EnumerationsPanel.Name = "EnumerationsPanel";
            this.EnumerationsPanel.Size = new System.Drawing.Size(433, 204);
            this.EnumerationsPanel.TabIndex = 11;
            // 
            // TabControlEnumerations
            // 
            this.TabControlEnumerations.Controls.Add(this.TabPageEnums);
            this.TabControlEnumerations.Controls.Add(this.TabPageClasses);
            this.TabControlEnumerations.Controls.Add(this.TabPageRectangles);
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
            this.GroupBoxMovies.Controls.Add(this.moviesControl1);
            this.GroupBoxMovies.Location = new System.Drawing.Point(406, 3);
            this.GroupBoxMovies.Name = "GroupBoxMovies";
            this.GroupBoxMovies.Size = new System.Drawing.Size(378, 212);
            this.GroupBoxMovies.TabIndex = 9;
            this.GroupBoxMovies.TabStop = false;
            this.GroupBoxMovies.Text = "Movies";
            // 
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(6, 17);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(358, 188);
            this.moviesControl1.TabIndex = 0;
            // 
            // GroupBoxRectangles
            // 
            this.GroupBoxRectangles.Controls.Add(this.rectanglesControl1);
            this.GroupBoxRectangles.Location = new System.Drawing.Point(8, 3);
            this.GroupBoxRectangles.Name = "GroupBoxRectangles";
            this.GroupBoxRectangles.Size = new System.Drawing.Size(378, 212);
            this.GroupBoxRectangles.TabIndex = 13;
            this.GroupBoxRectangles.TabStop = false;
            this.GroupBoxRectangles.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(6, 17);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(355, 189);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // TabPageRectangles
            // 
            this.TabPageRectangles.Controls.Add(this.rectanglesCollisionControl1);
            this.TabPageRectangles.Location = new System.Drawing.Point(4, 22);
            this.TabPageRectangles.Name = "TabPageRectangles";
            this.TabPageRectangles.Size = new System.Drawing.Size(792, 424);
            this.TabPageRectangles.TabIndex = 2;
            this.TabPageRectangles.Text = "Rectangles";
            this.TabPageRectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(792, 424);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControlEnumerations);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.TabPageEnums.ResumeLayout(false);
            this.TabPageEnums.PerformLayout();
            this.GroupBoxSeasonHandle.ResumeLayout(false);
            this.GroupBoxWeekdayParsing.ResumeLayout(false);
            this.GroupBoxEnumerations.ResumeLayout(false);
            this.TabControlEnumerations.ResumeLayout(false);
            this.TabPageClasses.ResumeLayout(false);
            this.GroupBoxMovies.ResumeLayout(false);
            this.GroupBoxRectangles.ResumeLayout(false);
            this.TabPageRectangles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabPageEnums;
        private System.Windows.Forms.TabControl TabControlEnumerations;
        private System.Windows.Forms.TabPage TabPageClasses;
        private System.Windows.Forms.TabPage TabPageRectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private System.Windows.Forms.GroupBox GroupBoxEnumerations;
        private View.Panels.EnumerationsPanel EnumerationsPanel;
        private System.Windows.Forms.GroupBox GroupBoxWeekdayParsing;
        private View.Panels.WeekdayParsingPanel WeekdayParsingPanel;
        private System.Windows.Forms.GroupBox GroupBoxSeasonHandle;
        private System.Windows.Forms.GroupBox GroupBoxRectangles;
        private View.Panels.RectanglesControl rectanglesControl1;
        private System.Windows.Forms.GroupBox GroupBoxMovies;
        private View.Panels.MoviesControl moviesControl1;
        private View.Panels.SeasonsHandlePanel SeasonsHandlePanel;
    }
}

