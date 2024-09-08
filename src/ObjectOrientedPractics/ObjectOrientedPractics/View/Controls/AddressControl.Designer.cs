namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            panel1 = new Panel();
            StreetLabel = new Label();
            StreetTextBox = new TextBox();
            CityTextBox = new TextBox();
            CountryTextBox = new TextBox();
            PostIndexTextBox = new TextBox();
            BuildingTextBox = new TextBox();
            ApartmentTextBox = new TextBox();
            ApartmentLabel = new Label();
            BuildingLabel = new Label();
            CountryLabel = new Label();
            CityLabel = new Label();
            PostIndexLabel = new Label();
            DeliveryAddressLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(StreetLabel);
            panel1.Controls.Add(StreetTextBox);
            panel1.Controls.Add(CityTextBox);
            panel1.Controls.Add(CountryTextBox);
            panel1.Controls.Add(PostIndexTextBox);
            panel1.Controls.Add(BuildingTextBox);
            panel1.Controls.Add(ApartmentTextBox);
            panel1.Controls.Add(ApartmentLabel);
            panel1.Controls.Add(BuildingLabel);
            panel1.Controls.Add(CountryLabel);
            panel1.Controls.Add(CityLabel);
            panel1.Controls.Add(PostIndexLabel);
            panel1.Controls.Add(DeliveryAddressLabel);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 183);
            panel1.TabIndex = 0;
            // 
            // StreetLabel
            // 
            StreetLabel.AutoSize = true;
            StreetLabel.Location = new Point(13, 114);
            StreetLabel.Name = "StreetLabel";
            StreetLabel.Size = new Size(51, 20);
            StreetLabel.TabIndex = 13;
            StreetLabel.Text = "Street:";
            // 
            // StreetTextBox
            // 
            StreetTextBox.Location = new Point(98, 111);
            StreetTextBox.MinimumSize = new Size(290, 0);
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.Size = new Size(290, 27);
            StreetTextBox.TabIndex = 11;
            StreetTextBox.TextChanged += StreetTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(301, 78);
            CityTextBox.MinimumSize = new Size(87, 0);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(87, 27);
            CityTextBox.TabIndex = 10;
            CityTextBox.TextChanged += CityTextBox_TextChanged;
            // 
            // CountryTextBox
            // 
            CountryTextBox.Location = new Point(98, 78);
            CountryTextBox.MinimumSize = new Size(131, 0);
            CountryTextBox.Name = "CountryTextBox";
            CountryTextBox.Size = new Size(131, 27);
            CountryTextBox.TabIndex = 9;
            CountryTextBox.TextChanged += CountryTextBox_TextChanged;
            // 
            // PostIndexTextBox
            // 
            PostIndexTextBox.Location = new Point(98, 45);
            PostIndexTextBox.MinimumSize = new Size(87, 0);
            PostIndexTextBox.Name = "PostIndexTextBox";
            PostIndexTextBox.Size = new Size(87, 27);
            PostIndexTextBox.TabIndex = 8;
            PostIndexTextBox.TextChanged += PostIndexTextBox_TextChanged;
            // 
            // BuildingTextBox
            // 
            BuildingTextBox.Location = new Point(98, 144);
            BuildingTextBox.MinimumSize = new Size(87, 0);
            BuildingTextBox.Name = "BuildingTextBox";
            BuildingTextBox.Size = new Size(87, 27);
            BuildingTextBox.TabIndex = 7;
            BuildingTextBox.TextChanged += BuildingTextBox_TextChanged;
            // 
            // ApartmentTextBox
            // 
            ApartmentTextBox.Location = new Point(301, 144);
            ApartmentTextBox.MinimumSize = new Size(87, 0);
            ApartmentTextBox.Name = "ApartmentTextBox";
            ApartmentTextBox.Size = new Size(87, 27);
            ApartmentTextBox.TabIndex = 6;
            ApartmentTextBox.TextChanged += ApartmentTextBox_TextChanged;
            // 
            // ApartmentLabel
            // 
            ApartmentLabel.AutoSize = true;
            ApartmentLabel.Location = new Point(212, 147);
            ApartmentLabel.Name = "ApartmentLabel";
            ApartmentLabel.Size = new Size(83, 20);
            ApartmentLabel.TabIndex = 5;
            ApartmentLabel.Text = "Apartment:";
            // 
            // BuildingLabel
            // 
            BuildingLabel.AutoSize = true;
            BuildingLabel.Location = new Point(13, 147);
            BuildingLabel.Name = "BuildingLabel";
            BuildingLabel.Size = new Size(64, 20);
            BuildingLabel.TabIndex = 4;
            BuildingLabel.Text = "Building";
            // 
            // CountryLabel
            // 
            CountryLabel.AutoSize = true;
            CountryLabel.Location = new Point(13, 81);
            CountryLabel.Name = "CountryLabel";
            CountryLabel.Size = new Size(63, 20);
            CountryLabel.TabIndex = 3;
            CountryLabel.Text = "Country:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(258, 81);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(37, 20);
            CityLabel.TabIndex = 2;
            CityLabel.Text = "City:";
            // 
            // PostIndexLabel
            // 
            PostIndexLabel.AutoSize = true;
            PostIndexLabel.Location = new Point(13, 48);
            PostIndexLabel.Name = "PostIndexLabel";
            PostIndexLabel.Size = new Size(79, 20);
            PostIndexLabel.TabIndex = 1;
            PostIndexLabel.Text = "Post Index:";
            // 
            // DeliveryAddressLabel
            // 
            DeliveryAddressLabel.AutoSize = true;
            DeliveryAddressLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            DeliveryAddressLabel.Location = new Point(13, 8);
            DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            DeliveryAddressLabel.Size = new Size(128, 20);
            DeliveryAddressLabel.TabIndex = 0;
            DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // AddressControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "AddressControl";
            Size = new Size(408, 189);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label CityLabel;
        private Label PostIndexLabel;
        private Label DeliveryAddressLabel;
        private Label ApartmentLabel;
        private Label BuildingLabel;
        private Label CountryLabel;
        private TextBox StreetTextBox;
        private TextBox CityTextBox;
        private TextBox CountryTextBox;
        private TextBox PostIndexTextBox;
        private TextBox BuildingTextBox;
        private TextBox ApartmentTextBox;
        private Label StreetLabel;
    }
}
