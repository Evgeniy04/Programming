namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.ButtonAddRectangle = new System.Windows.Forms.Button();
            this.ButtonRemoveRectangle = new System.Windows.Forms.Button();
            this.TextBoxRectanglesHeight = new System.Windows.Forms.TextBox();
            this.TextBoxRectanglesWidth = new System.Windows.Forms.TextBox();
            this.TextBoxRectanglesY = new System.Windows.Forms.TextBox();
            this.TextBoxRectanglesX = new System.Windows.Forms.TextBox();
            this.TextBoxRectanglesId = new System.Windows.Forms.TextBox();
            this.ListBoxRectangles = new System.Windows.Forms.ListBox();
            this.LabelHeightRectangleCollision = new System.Windows.Forms.Label();
            this.LabelWidthRectangleCollision = new System.Windows.Forms.Label();
            this.LabelYRectangleCollision = new System.Windows.Forms.Label();
            this.LabelXRectangleCollision = new System.Windows.Forms.Label();
            this.LabelIdRectangleCollision = new System.Windows.Forms.Label();
            this.LabelSelectedRectangleCollision = new System.Windows.Forms.Label();
            this.LabelRectanglesCollision = new System.Windows.Forms.Label();
            this.PanelRectangles = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ButtonAddRectangle
            // 
            this.ButtonAddRectangle.FlatAppearance.BorderSize = 0;
            this.ButtonAddRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ButtonAddRectangle.Image")));
            this.ButtonAddRectangle.Location = new System.Drawing.Point(35, 192);
            this.ButtonAddRectangle.Name = "ButtonAddRectangle";
            this.ButtonAddRectangle.Size = new System.Drawing.Size(25, 25);
            this.ButtonAddRectangle.TabIndex = 29;
            this.ButtonAddRectangle.UseVisualStyleBackColor = true;
            this.ButtonAddRectangle.Click += new System.EventHandler(this.ButtonAddRectangle_Click);
            // 
            // ButtonRemoveRectangle
            // 
            this.ButtonRemoveRectangle.FlatAppearance.BorderSize = 0;
            this.ButtonRemoveRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemoveRectangle.ForeColor = System.Drawing.Color.Black;
            this.ButtonRemoveRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ButtonRemoveRectangle.Image")));
            this.ButtonRemoveRectangle.Location = new System.Drawing.Point(130, 192);
            this.ButtonRemoveRectangle.Name = "ButtonRemoveRectangle";
            this.ButtonRemoveRectangle.Size = new System.Drawing.Size(25, 25);
            this.ButtonRemoveRectangle.TabIndex = 16;
            this.ButtonRemoveRectangle.UseVisualStyleBackColor = true;
            this.ButtonRemoveRectangle.Click += new System.EventHandler(this.ButtonRemoveRectangle_Click);
            // 
            // TextBoxRectanglesHeight
            // 
            this.TextBoxRectanglesHeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRectanglesHeight.Location = new System.Drawing.Point(55, 361);
            this.TextBoxRectanglesHeight.Name = "TextBoxRectanglesHeight";
            this.TextBoxRectanglesHeight.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesHeight.TabIndex = 28;
            this.TextBoxRectanglesHeight.Click += new System.EventHandler(this.TextBoxRectanglesHeight_TextChanged);
            this.TextBoxRectanglesHeight.TextChanged += new System.EventHandler(this.TextBoxRectanglesHeight_TextChanged);
            // 
            // TextBoxRectanglesWidth
            // 
            this.TextBoxRectanglesWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRectanglesWidth.Location = new System.Drawing.Point(55, 335);
            this.TextBoxRectanglesWidth.Name = "TextBoxRectanglesWidth";
            this.TextBoxRectanglesWidth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesWidth.TabIndex = 27;
            this.TextBoxRectanglesWidth.Click += new System.EventHandler(this.TextBoxRectanglesWidth_TextChanged);
            this.TextBoxRectanglesWidth.TextChanged += new System.EventHandler(this.TextBoxRectanglesWidth_TextChanged);
            // 
            // TextBoxRectanglesY
            // 
            this.TextBoxRectanglesY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRectanglesY.Location = new System.Drawing.Point(55, 309);
            this.TextBoxRectanglesY.Name = "TextBoxRectanglesY";
            this.TextBoxRectanglesY.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesY.TabIndex = 26;
            this.TextBoxRectanglesY.Click += new System.EventHandler(this.TextBoxRectanglesY_TextChanged);
            this.TextBoxRectanglesY.TextChanged += new System.EventHandler(this.TextBoxRectanglesY_TextChanged);
            // 
            // TextBoxRectanglesX
            // 
            this.TextBoxRectanglesX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRectanglesX.Location = new System.Drawing.Point(55, 283);
            this.TextBoxRectanglesX.Name = "TextBoxRectanglesX";
            this.TextBoxRectanglesX.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesX.TabIndex = 25;
            this.TextBoxRectanglesX.TextChanged += new System.EventHandler(this.TextBoxRectanglesX_TextChanged);
            // 
            // TextBoxRectanglesId
            // 
            this.TextBoxRectanglesId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRectanglesId.Location = new System.Drawing.Point(55, 257);
            this.TextBoxRectanglesId.Name = "TextBoxRectanglesId";
            this.TextBoxRectanglesId.Size = new System.Drawing.Size(100, 20);
            this.TextBoxRectanglesId.TabIndex = 24;
            this.TextBoxRectanglesId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxDisable);
            // 
            // ListBoxRectangles
            // 
            this.ListBoxRectangles.FormattingEnabled = true;
            this.ListBoxRectangles.Location = new System.Drawing.Point(11, 39);
            this.ListBoxRectangles.Name = "ListBoxRectangles";
            this.ListBoxRectangles.Size = new System.Drawing.Size(267, 147);
            this.ListBoxRectangles.TabIndex = 23;
            this.ListBoxRectangles.SelectedIndexChanged += new System.EventHandler(this.ListBoxRectangles_SelectedIndexChanged);
            // 
            // LabelHeightRectangleCollision
            // 
            this.LabelHeightRectangleCollision.AutoSize = true;
            this.LabelHeightRectangleCollision.Location = new System.Drawing.Point(8, 364);
            this.LabelHeightRectangleCollision.Name = "LabelHeightRectangleCollision";
            this.LabelHeightRectangleCollision.Size = new System.Drawing.Size(41, 13);
            this.LabelHeightRectangleCollision.TabIndex = 22;
            this.LabelHeightRectangleCollision.Text = "Height:";
            // 
            // LabelWidthRectangleCollision
            // 
            this.LabelWidthRectangleCollision.AutoSize = true;
            this.LabelWidthRectangleCollision.Location = new System.Drawing.Point(11, 338);
            this.LabelWidthRectangleCollision.Name = "LabelWidthRectangleCollision";
            this.LabelWidthRectangleCollision.Size = new System.Drawing.Size(38, 13);
            this.LabelWidthRectangleCollision.TabIndex = 21;
            this.LabelWidthRectangleCollision.Text = "Width:";
            // 
            // LabelYRectangleCollision
            // 
            this.LabelYRectangleCollision.AutoSize = true;
            this.LabelYRectangleCollision.Location = new System.Drawing.Point(32, 312);
            this.LabelYRectangleCollision.Name = "LabelYRectangleCollision";
            this.LabelYRectangleCollision.Size = new System.Drawing.Size(17, 13);
            this.LabelYRectangleCollision.TabIndex = 20;
            this.LabelYRectangleCollision.Text = "Y:";
            // 
            // LabelXRectangleCollision
            // 
            this.LabelXRectangleCollision.AutoSize = true;
            this.LabelXRectangleCollision.Location = new System.Drawing.Point(32, 286);
            this.LabelXRectangleCollision.Name = "LabelXRectangleCollision";
            this.LabelXRectangleCollision.Size = new System.Drawing.Size(17, 13);
            this.LabelXRectangleCollision.TabIndex = 19;
            this.LabelXRectangleCollision.Text = "X:";
            // 
            // LabelIdRectangleCollision
            // 
            this.LabelIdRectangleCollision.AutoSize = true;
            this.LabelIdRectangleCollision.Location = new System.Drawing.Point(30, 260);
            this.LabelIdRectangleCollision.Name = "LabelIdRectangleCollision";
            this.LabelIdRectangleCollision.Size = new System.Drawing.Size(19, 13);
            this.LabelIdRectangleCollision.TabIndex = 18;
            this.LabelIdRectangleCollision.Text = "Id:";
            // 
            // LabelSelectedRectangleCollision
            // 
            this.LabelSelectedRectangleCollision.AutoSize = true;
            this.LabelSelectedRectangleCollision.Location = new System.Drawing.Point(8, 241);
            this.LabelSelectedRectangleCollision.Name = "LabelSelectedRectangleCollision";
            this.LabelSelectedRectangleCollision.Size = new System.Drawing.Size(104, 13);
            this.LabelSelectedRectangleCollision.TabIndex = 17;
            this.LabelSelectedRectangleCollision.Text = "Selected Rectangle:";
            // 
            // LabelRectanglesCollision
            // 
            this.LabelRectanglesCollision.AutoSize = true;
            this.LabelRectanglesCollision.Location = new System.Drawing.Point(8, 23);
            this.LabelRectanglesCollision.Name = "LabelRectanglesCollision";
            this.LabelRectanglesCollision.Size = new System.Drawing.Size(64, 13);
            this.LabelRectanglesCollision.TabIndex = 14;
            this.LabelRectanglesCollision.Text = "Rectangles:";
            // 
            // PanelRectangles
            // 
            this.PanelRectangles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelRectangles.AutoScroll = true;
            this.PanelRectangles.AutoScrollMinSize = new System.Drawing.Size(100, 150);
            this.PanelRectangles.AutoSize = true;
            this.PanelRectangles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelRectangles.Location = new System.Drawing.Point(284, 6);
            this.PanelRectangles.Name = "PanelRectangles";
            this.PanelRectangles.Size = new System.Drawing.Size(500, 413);
            this.PanelRectangles.TabIndex = 15;
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAddRectangle);
            this.Controls.Add(this.ButtonRemoveRectangle);
            this.Controls.Add(this.TextBoxRectanglesHeight);
            this.Controls.Add(this.TextBoxRectanglesWidth);
            this.Controls.Add(this.TextBoxRectanglesY);
            this.Controls.Add(this.TextBoxRectanglesX);
            this.Controls.Add(this.TextBoxRectanglesId);
            this.Controls.Add(this.ListBoxRectangles);
            this.Controls.Add(this.LabelHeightRectangleCollision);
            this.Controls.Add(this.LabelWidthRectangleCollision);
            this.Controls.Add(this.LabelYRectangleCollision);
            this.Controls.Add(this.LabelXRectangleCollision);
            this.Controls.Add(this.LabelIdRectangleCollision);
            this.Controls.Add(this.LabelSelectedRectangleCollision);
            this.Controls.Add(this.LabelRectanglesCollision);
            this.Controls.Add(this.PanelRectangles);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(792, 424);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAddRectangle;
        private System.Windows.Forms.Button ButtonRemoveRectangle;
        private System.Windows.Forms.TextBox TextBoxRectanglesHeight;
        private System.Windows.Forms.TextBox TextBoxRectanglesWidth;
        private System.Windows.Forms.TextBox TextBoxRectanglesY;
        private System.Windows.Forms.TextBox TextBoxRectanglesX;
        private System.Windows.Forms.TextBox TextBoxRectanglesId;
        private System.Windows.Forms.ListBox ListBoxRectangles;
        private System.Windows.Forms.Label LabelHeightRectangleCollision;
        private System.Windows.Forms.Label LabelWidthRectangleCollision;
        private System.Windows.Forms.Label LabelYRectangleCollision;
        private System.Windows.Forms.Label LabelXRectangleCollision;
        private System.Windows.Forms.Label LabelIdRectangleCollision;
        private System.Windows.Forms.Label LabelSelectedRectangleCollision;
        private System.Windows.Forms.Label LabelRectanglesCollision;
        private System.Windows.Forms.Panel PanelRectangles;
    }
}
