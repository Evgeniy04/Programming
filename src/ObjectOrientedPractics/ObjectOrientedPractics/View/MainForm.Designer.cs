namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MainTabControl = new TabControl();
            ItemsPage = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            CustomersPage = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            MainTabControl.SuspendLayout();
            ItemsPage.SuspendLayout();
            CustomersPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsPage);
            MainTabControl.Controls.Add(CustomersPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(800, 450);
            MainTabControl.TabIndex = 0;
            // 
            // ItemsPage
            // 
            ItemsPage.Controls.Add(itemsTab1);
            ItemsPage.Location = new Point(4, 29);
            ItemsPage.Name = "ItemsPage";
            ItemsPage.Padding = new Padding(3);
            ItemsPage.Size = new Size(792, 417);
            ItemsPage.TabIndex = 0;
            ItemsPage.Text = "Items";
            ItemsPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(786, 411);
            itemsTab1.TabIndex = 0;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(customersTab1);
            CustomersPage.Location = new Point(4, 29);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(192, 67);
            CustomersPage.TabIndex = 1;
            CustomersPage.Text = "Customers";
            CustomersPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(186, 61);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainTabControl);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            FormClosed += MainForm_FormClosed;
            MainTabControl.ResumeLayout(false);
            ItemsPage.ResumeLayout(false);
            CustomersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsPage;
        private TabPage CustomersPage;
        private View.Tabs.ItemsTab itemsTab1;
        private View.Tabs.CustomersTab customersTab1;
    }
}
