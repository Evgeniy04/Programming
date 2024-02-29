namespace Programming.View.Panels
{
    partial class ClassesRectanglesControl
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
            this.GroupBoxRectangles = new System.Windows.Forms.GroupBox();
            this.TextBoxClassesRectanglesId = new System.Windows.Forms.TextBox();
            this.LabelIdRectangle = new System.Windows.Forms.Label();
            this.TextBoxClassesRectanglesCoordinateY = new System.Windows.Forms.TextBox();
            this.LabelCenterCoordinateYRectangle = new System.Windows.Forms.Label();
            this.TextBoxClassesRectanglesCoordinateX = new System.Windows.Forms.TextBox();
            this.LabelCenterCoordinateXRectangle = new System.Windows.Forms.Label();
            this.ButtonFindRectangleWithMaxWidth = new System.Windows.Forms.Button();
            this.TextBoxClassesRectanglesColor = new System.Windows.Forms.TextBox();
            this.TextBoxClassesRectanglesWidth = new System.Windows.Forms.TextBox();
            this.TextBoxClassesRectanglesLength = new System.Windows.Forms.TextBox();
            this.LabelLengthRectangle = new System.Windows.Forms.Label();
            this.LabelWidthRectangle = new System.Windows.Forms.Label();
            this.LabelColorRectangle = new System.Windows.Forms.Label();
            this.ListBoxClassesRectangles = new System.Windows.Forms.ListBox();
            this.GroupBoxRectangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxRectangles
            // 
            this.GroupBoxRectangles.Controls.Add(this.TextBoxClassesRectanglesId);
            this.GroupBoxRectangles.Controls.Add(this.LabelIdRectangle);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxClassesRectanglesCoordinateY);
            this.GroupBoxRectangles.Controls.Add(this.LabelCenterCoordinateYRectangle);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxClassesRectanglesCoordinateX);
            this.GroupBoxRectangles.Controls.Add(this.LabelCenterCoordinateXRectangle);
            this.GroupBoxRectangles.Controls.Add(this.ButtonFindRectangleWithMaxWidth);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxClassesRectanglesColor);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxClassesRectanglesWidth);
            this.GroupBoxRectangles.Controls.Add(this.TextBoxClassesRectanglesLength);
            this.GroupBoxRectangles.Controls.Add(this.LabelLengthRectangle);
            this.GroupBoxRectangles.Controls.Add(this.LabelWidthRectangle);
            this.GroupBoxRectangles.Controls.Add(this.LabelColorRectangle);
            this.GroupBoxRectangles.Controls.Add(this.ListBoxClassesRectangles);
            this.GroupBoxRectangles.Location = new System.Drawing.Point(0, 0);
            this.GroupBoxRectangles.Name = "GroupBoxRectangles";
            this.GroupBoxRectangles.Size = new System.Drawing.Size(378, 212);
            this.GroupBoxRectangles.TabIndex = 1;
            this.GroupBoxRectangles.TabStop = false;
            this.GroupBoxRectangles.Text = "Rectangles";
            // 
            // TextBoxClassesRectanglesId
            // 
            this.TextBoxClassesRectanglesId.Location = new System.Drawing.Point(259, 131);
            this.TextBoxClassesRectanglesId.Name = "TextBoxClassesRectanglesId";
            this.TextBoxClassesRectanglesId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesId.TabIndex = 12;
            this.TextBoxClassesRectanglesId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // LabelIdRectangle
            // 
            this.LabelIdRectangle.AutoSize = true;
            this.LabelIdRectangle.Location = new System.Drawing.Point(256, 115);
            this.LabelIdRectangle.Name = "LabelIdRectangle";
            this.LabelIdRectangle.Size = new System.Drawing.Size(19, 13);
            this.LabelIdRectangle.TabIndex = 11;
            this.LabelIdRectangle.Text = "Id:";
            // 
            // TextBoxClassesRectanglesCoordinateY
            // 
            this.TextBoxClassesRectanglesCoordinateY.Location = new System.Drawing.Point(259, 35);
            this.TextBoxClassesRectanglesCoordinateY.Name = "TextBoxClassesRectanglesCoordinateY";
            this.TextBoxClassesRectanglesCoordinateY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesCoordinateY.TabIndex = 10;
            this.TextBoxClassesRectanglesCoordinateY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // LabelCenterCoordinateYRectangle
            // 
            this.LabelCenterCoordinateYRectangle.AutoSize = true;
            this.LabelCenterCoordinateYRectangle.Location = new System.Drawing.Point(256, 19);
            this.LabelCenterCoordinateYRectangle.Name = "LabelCenterCoordinateYRectangle";
            this.LabelCenterCoordinateYRectangle.Size = new System.Drawing.Size(104, 13);
            this.LabelCenterCoordinateYRectangle.TabIndex = 9;
            this.LabelCenterCoordinateYRectangle.Text = "Center coordinate Y:";
            // 
            // TextBoxClassesRectanglesCoordinateX
            // 
            this.TextBoxClassesRectanglesCoordinateX.Location = new System.Drawing.Point(259, 83);
            this.TextBoxClassesRectanglesCoordinateX.Name = "TextBoxClassesRectanglesCoordinateX";
            this.TextBoxClassesRectanglesCoordinateX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesCoordinateX.TabIndex = 8;
            this.TextBoxClassesRectanglesCoordinateX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // LabelCenterCoordinateXRectangle
            // 
            this.LabelCenterCoordinateXRectangle.AutoSize = true;
            this.LabelCenterCoordinateXRectangle.Location = new System.Drawing.Point(256, 67);
            this.LabelCenterCoordinateXRectangle.Name = "LabelCenterCoordinateXRectangle";
            this.LabelCenterCoordinateXRectangle.Size = new System.Drawing.Size(104, 13);
            this.LabelCenterCoordinateXRectangle.TabIndex = 7;
            this.LabelCenterCoordinateXRectangle.Text = "Center coordinate X:";
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
            // TextBoxClassesRectanglesColor
            // 
            this.TextBoxClassesRectanglesColor.Location = new System.Drawing.Point(132, 131);
            this.TextBoxClassesRectanglesColor.Name = "TextBoxClassesRectanglesColor";
            this.TextBoxClassesRectanglesColor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesColor.TabIndex = 6;
            this.TextBoxClassesRectanglesColor.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesColor_TextChanged);
            // 
            // TextBoxClassesRectanglesWidth
            // 
            this.TextBoxClassesRectanglesWidth.Location = new System.Drawing.Point(132, 83);
            this.TextBoxClassesRectanglesWidth.Name = "TextBoxClassesRectanglesWidth";
            this.TextBoxClassesRectanglesWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesWidth.TabIndex = 5;
            this.TextBoxClassesRectanglesWidth.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesWidth_TextChanged);
            // 
            // TextBoxClassesRectanglesLength
            // 
            this.TextBoxClassesRectanglesLength.Location = new System.Drawing.Point(132, 35);
            this.TextBoxClassesRectanglesLength.Name = "TextBoxClassesRectanglesLength";
            this.TextBoxClassesRectanglesLength.Size = new System.Drawing.Size(100, 20);
            this.TextBoxClassesRectanglesLength.TabIndex = 4;
            this.TextBoxClassesRectanglesLength.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesLength_TextChanged);
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
            // ListBoxClassesRectangles
            // 
            this.ListBoxClassesRectangles.FormattingEnabled = true;
            this.ListBoxClassesRectangles.Location = new System.Drawing.Point(6, 19);
            this.ListBoxClassesRectangles.Name = "ListBoxClassesRectangles";
            this.ListBoxClassesRectangles.Size = new System.Drawing.Size(120, 186);
            this.ListBoxClassesRectangles.TabIndex = 0;
            this.ListBoxClassesRectangles.SelectedIndexChanged += new System.EventHandler(this.ListBoxClassesRectangles_SelectedIndexChanged);
            // 
            // ClassesRectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxRectangles);
            this.Name = "ClassesRectanglesControl";
            this.Size = new System.Drawing.Size(378, 212);
            this.GroupBoxRectangles.ResumeLayout(false);
            this.GroupBoxRectangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxRectangles;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesId;
        private System.Windows.Forms.Label LabelIdRectangle;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesCoordinateY;
        private System.Windows.Forms.Label LabelCenterCoordinateYRectangle;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesCoordinateX;
        private System.Windows.Forms.Label LabelCenterCoordinateXRectangle;
        private System.Windows.Forms.Button ButtonFindRectangleWithMaxWidth;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesColor;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesWidth;
        private System.Windows.Forms.TextBox TextBoxClassesRectanglesLength;
        private System.Windows.Forms.Label LabelLengthRectangle;
        private System.Windows.Forms.Label LabelWidthRectangle;
        private System.Windows.Forms.Label LabelColorRectangle;
        private System.Windows.Forms.ListBox ListBoxClassesRectangles;
    }
}
