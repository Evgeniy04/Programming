namespace Programming.View.Panels
{
    partial class RectanglesControl
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
            this.TextBoxRectanglesId = new System.Windows.Forms.TextBox();
            this.LabelIdRectangle = new System.Windows.Forms.Label();
            this.TextBoxRectanglesCoordinateY = new System.Windows.Forms.TextBox();
            this.LabelCenterCoordinateYRectangle = new System.Windows.Forms.Label();
            this.TextBoxRectanglesCoordinateX = new System.Windows.Forms.TextBox();
            this.LabelCenterCoordinateXRectangle = new System.Windows.Forms.Label();
            this.ButtonFindRectangleWithMaxWidth = new System.Windows.Forms.Button();
            this.TextBoxRectanglesColor = new System.Windows.Forms.TextBox();
            this.TextBoxRectanglesWidth = new System.Windows.Forms.TextBox();
            this.TextBoxRectanglesLength = new System.Windows.Forms.TextBox();
            this.LabelLengthRectangle = new System.Windows.Forms.Label();
            this.LabelWidthRectangle = new System.Windows.Forms.Label();
            this.LabelColorRectangle = new System.Windows.Forms.Label();
            this.ListBoxRectangles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TextBoxRectanglesId
            // 
            this.TextBoxRectanglesId.Location = new System.Drawing.Point(253, 112);
            this.TextBoxRectanglesId.Name = "TextBoxRectanglesId";
            this.TextBoxRectanglesId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesId.TabIndex = 12;
            this.TextBoxRectanglesId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // LabelIdRectangle
            // 
            this.LabelIdRectangle.AutoSize = true;
            this.LabelIdRectangle.Location = new System.Drawing.Point(250, 96);
            this.LabelIdRectangle.Name = "LabelIdRectangle";
            this.LabelIdRectangle.Size = new System.Drawing.Size(19, 13);
            this.LabelIdRectangle.TabIndex = 11;
            this.LabelIdRectangle.Text = "Id:";
            // 
            // TextBoxRectanglesCoordinateY
            // 
            this.TextBoxRectanglesCoordinateY.Location = new System.Drawing.Point(253, 16);
            this.TextBoxRectanglesCoordinateY.Name = "TextBoxRectanglesCoordinateY";
            this.TextBoxRectanglesCoordinateY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesCoordinateY.TabIndex = 10;
            this.TextBoxRectanglesCoordinateY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // LabelCenterCoordinateYRectangle
            // 
            this.LabelCenterCoordinateYRectangle.AutoSize = true;
            this.LabelCenterCoordinateYRectangle.Location = new System.Drawing.Point(250, 0);
            this.LabelCenterCoordinateYRectangle.Name = "LabelCenterCoordinateYRectangle";
            this.LabelCenterCoordinateYRectangle.Size = new System.Drawing.Size(104, 13);
            this.LabelCenterCoordinateYRectangle.TabIndex = 9;
            this.LabelCenterCoordinateYRectangle.Text = "Center coordinate Y:";
            // 
            // TextBoxRectanglesCoordinateX
            // 
            this.TextBoxRectanglesCoordinateX.Location = new System.Drawing.Point(253, 64);
            this.TextBoxRectanglesCoordinateX.Name = "TextBoxRectanglesCoordinateX";
            this.TextBoxRectanglesCoordinateX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesCoordinateX.TabIndex = 8;
            this.TextBoxRectanglesCoordinateX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // LabelCenterCoordinateXRectangle
            // 
            this.LabelCenterCoordinateXRectangle.AutoSize = true;
            this.LabelCenterCoordinateXRectangle.Location = new System.Drawing.Point(250, 48);
            this.LabelCenterCoordinateXRectangle.Name = "LabelCenterCoordinateXRectangle";
            this.LabelCenterCoordinateXRectangle.Size = new System.Drawing.Size(104, 13);
            this.LabelCenterCoordinateXRectangle.TabIndex = 7;
            this.LabelCenterCoordinateXRectangle.Text = "Center coordinate X:";
            // 
            // ButtonFindRectangleWithMaxWidth
            // 
            this.ButtonFindRectangleWithMaxWidth.Location = new System.Drawing.Point(126, 157);
            this.ButtonFindRectangleWithMaxWidth.Name = "ButtonFindRectangleWithMaxWidth";
            this.ButtonFindRectangleWithMaxWidth.Size = new System.Drawing.Size(100, 29);
            this.ButtonFindRectangleWithMaxWidth.TabIndex = 1;
            this.ButtonFindRectangleWithMaxWidth.Text = "Find";
            this.ButtonFindRectangleWithMaxWidth.UseVisualStyleBackColor = true;
            this.ButtonFindRectangleWithMaxWidth.Click += new System.EventHandler(this.ButtonFindRectangleWithMaxWidth_Click);
            // 
            // TextBoxRectanglesColor
            // 
            this.TextBoxRectanglesColor.Location = new System.Drawing.Point(126, 112);
            this.TextBoxRectanglesColor.Name = "TextBoxRectanglesColor";
            this.TextBoxRectanglesColor.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesColor.TabIndex = 6;
            this.TextBoxRectanglesColor.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesColor_TextChanged);
            // 
            // TextBoxRectanglesWidth
            // 
            this.TextBoxRectanglesWidth.Location = new System.Drawing.Point(126, 64);
            this.TextBoxRectanglesWidth.Name = "TextBoxRectanglesWidth";
            this.TextBoxRectanglesWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesWidth.TabIndex = 5;
            this.TextBoxRectanglesWidth.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesWidth_TextChanged);
            // 
            // TextBoxRectanglesLength
            // 
            this.TextBoxRectanglesLength.Location = new System.Drawing.Point(126, 16);
            this.TextBoxRectanglesLength.Name = "TextBoxRectanglesLength";
            this.TextBoxRectanglesLength.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesLength.TabIndex = 4;
            this.TextBoxRectanglesLength.TextChanged += new System.EventHandler(this.TextBoxClassesRectanglesLength_TextChanged);
            // 
            // LabelLengthRectangle
            // 
            this.LabelLengthRectangle.AutoSize = true;
            this.LabelLengthRectangle.Location = new System.Drawing.Point(123, 0);
            this.LabelLengthRectangle.Name = "LabelLengthRectangle";
            this.LabelLengthRectangle.Size = new System.Drawing.Size(43, 13);
            this.LabelLengthRectangle.TabIndex = 1;
            this.LabelLengthRectangle.Text = "Length:";
            // 
            // LabelWidthRectangle
            // 
            this.LabelWidthRectangle.AutoSize = true;
            this.LabelWidthRectangle.Location = new System.Drawing.Point(123, 48);
            this.LabelWidthRectangle.Name = "LabelWidthRectangle";
            this.LabelWidthRectangle.Size = new System.Drawing.Size(38, 13);
            this.LabelWidthRectangle.TabIndex = 2;
            this.LabelWidthRectangle.Text = "Width:";
            // 
            // LabelColorRectangle
            // 
            this.LabelColorRectangle.AutoSize = true;
            this.LabelColorRectangle.Location = new System.Drawing.Point(126, 96);
            this.LabelColorRectangle.Name = "LabelColorRectangle";
            this.LabelColorRectangle.Size = new System.Drawing.Size(34, 13);
            this.LabelColorRectangle.TabIndex = 3;
            this.LabelColorRectangle.Text = "Color:";
            // 
            // ListBoxRectangles
            // 
            this.ListBoxRectangles.FormattingEnabled = true;
            this.ListBoxRectangles.Location = new System.Drawing.Point(0, 0);
            this.ListBoxRectangles.Name = "ListBoxRectangles";
            this.ListBoxRectangles.Size = new System.Drawing.Size(120, 186);
            this.ListBoxRectangles.TabIndex = 0;
            this.ListBoxRectangles.SelectedIndexChanged += new System.EventHandler(this.ListBoxClassesRectangles_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBoxRectanglesId);
            this.Controls.Add(this.LabelIdRectangle);
            this.Controls.Add(this.ListBoxRectangles);
            this.Controls.Add(this.TextBoxRectanglesCoordinateY);
            this.Controls.Add(this.LabelColorRectangle);
            this.Controls.Add(this.LabelCenterCoordinateYRectangle);
            this.Controls.Add(this.LabelWidthRectangle);
            this.Controls.Add(this.TextBoxRectanglesCoordinateX);
            this.Controls.Add(this.LabelLengthRectangle);
            this.Controls.Add(this.LabelCenterCoordinateXRectangle);
            this.Controls.Add(this.TextBoxRectanglesLength);
            this.Controls.Add(this.ButtonFindRectangleWithMaxWidth);
            this.Controls.Add(this.TextBoxRectanglesWidth);
            this.Controls.Add(this.TextBoxRectanglesColor);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(355, 189);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextBoxRectanglesId;
        private System.Windows.Forms.Label LabelIdRectangle;
        private System.Windows.Forms.TextBox TextBoxRectanglesCoordinateY;
        private System.Windows.Forms.Label LabelCenterCoordinateYRectangle;
        private System.Windows.Forms.TextBox TextBoxRectanglesCoordinateX;
        private System.Windows.Forms.Label LabelCenterCoordinateXRectangle;
        private System.Windows.Forms.Button ButtonFindRectangleWithMaxWidth;
        private System.Windows.Forms.TextBox TextBoxRectanglesColor;
        private System.Windows.Forms.TextBox TextBoxRectanglesWidth;
        private System.Windows.Forms.TextBox TextBoxRectanglesLength;
        private System.Windows.Forms.Label LabelLengthRectangle;
        private System.Windows.Forms.Label LabelWidthRectangle;
        private System.Windows.Forms.Label LabelColorRectangle;
        private System.Windows.Forms.ListBox ListBoxRectangles;
    }
}
