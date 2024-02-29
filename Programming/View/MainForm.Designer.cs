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
            this.seasonsHandlePanel1 = new Programming.View.Panels.SeasonsHandlePanel();
            this.weekdayParsingPanel1 = new Programming.View.Panels.WeekdayParsingPanel();
            this.enumerationsPanel1 = new Programming.View.Panels.EnumerationsPanel();
            this.TabControlEnumerations = new System.Windows.Forms.TabControl();
            this.TabPageClasses = new System.Windows.Forms.TabPage();
            this.TabPageRectangles = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.classesRectanglesControl1 = new Programming.View.Panels.ClassesRectanglesControl();
            this.classesMoviesControl1 = new Programming.View.Panels.ClassesMoviesControl();
            this.TabPageEnums.SuspendLayout();
            this.TabControlEnumerations.SuspendLayout();
            this.TabPageClasses.SuspendLayout();
            this.TabPageRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPageEnums
            // 
            this.TabPageEnums.Controls.Add(this.seasonsHandlePanel1);
            this.TabPageEnums.Controls.Add(this.weekdayParsingPanel1);
            this.TabPageEnums.Controls.Add(this.enumerationsPanel1);
            this.TabPageEnums.Location = new System.Drawing.Point(4, 22);
            this.TabPageEnums.Name = "TabPageEnums";
            this.TabPageEnums.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageEnums.Size = new System.Drawing.Size(792, 424);
            this.TabPageEnums.TabIndex = 0;
            this.TabPageEnums.Text = "Enums";
            this.TabPageEnums.UseVisualStyleBackColor = true;
            // 
            // seasonsHandlePanel1
            // 
            this.seasonsHandlePanel1.Location = new System.Drawing.Point(407, 252);
            this.seasonsHandlePanel1.Name = "seasonsHandlePanel1";
            this.seasonsHandlePanel1.Size = new System.Drawing.Size(377, 164);
            this.seasonsHandlePanel1.TabIndex = 3;
            // 
            // weekdayParsingPanel1
            // 
            this.weekdayParsingPanel1.Color = System.Drawing.Color.Empty;
            this.weekdayParsingPanel1.Location = new System.Drawing.Point(8, 252);
            this.weekdayParsingPanel1.Name = "weekdayParsingPanel1";
            this.weekdayParsingPanel1.Size = new System.Drawing.Size(377, 164);
            this.weekdayParsingPanel1.TabIndex = 9;
            // 
            // enumerationsPanel1
            // 
            this.enumerationsPanel1.Color = System.Drawing.Color.Empty;
            this.enumerationsPanel1.Location = new System.Drawing.Point(8, 6);
            this.enumerationsPanel1.Name = "enumerationsPanel1";
            this.enumerationsPanel1.Size = new System.Drawing.Size(778, 240);
            this.enumerationsPanel1.TabIndex = 8;
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
            this.TabPageClasses.Controls.Add(this.classesMoviesControl1);
            this.TabPageClasses.Controls.Add(this.classesRectanglesControl1);
            this.TabPageClasses.Location = new System.Drawing.Point(4, 22);
            this.TabPageClasses.Name = "TabPageClasses";
            this.TabPageClasses.Size = new System.Drawing.Size(792, 424);
            this.TabPageClasses.TabIndex = 1;
            this.TabPageClasses.Text = "Classes";
            this.TabPageClasses.UseVisualStyleBackColor = true;
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
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(792, 424);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // classesRectanglesControl1
            // 
            this.classesRectanglesControl1.Location = new System.Drawing.Point(8, 3);
            this.classesRectanglesControl1.Name = "classesRectanglesControl1";
            this.classesRectanglesControl1.Size = new System.Drawing.Size(378, 212);
            this.classesRectanglesControl1.TabIndex = 11;
            // 
            // classesMoviesControl1
            // 
            this.classesMoviesControl1.Location = new System.Drawing.Point(406, 3);
            this.classesMoviesControl1.Name = "classesMoviesControl1";
            this.classesMoviesControl1.Size = new System.Drawing.Size(378, 212);
            this.classesMoviesControl1.TabIndex = 12;
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
            this.TabControlEnumerations.ResumeLayout(false);
            this.TabPageClasses.ResumeLayout(false);
            this.TabPageRectangles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage TabPageEnums;
        private System.Windows.Forms.TabControl TabControlEnumerations;
        private System.Windows.Forms.TabPage TabPageClasses;
        private System.Windows.Forms.TabPage TabPageRectangles;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Panels.EnumerationsPanel enumerationsPanel1;
        private View.Panels.WeekdayParsingPanel weekdayParsingPanel1;
        private View.Panels.SeasonsHandlePanel seasonsHandlePanel1;
        private View.Panels.ClassesMoviesControl classesMoviesControl1;
        private View.Panels.ClassesRectanglesControl classesRectanglesControl1;
    }
}

