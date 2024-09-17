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
            ItemsTab = new View.Tabs.ItemsTab();
            CustomersPage = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
            CartsPage = new TabPage();
            CartsTab = new View.Tabs.CartsTab();
            OrdersPage = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            PriorityOrdersPage = new TabPage();
            PriorityOrdersTab = new View.Tabs.PriorityOrdersTab();
            MainTabControl.SuspendLayout();
            ItemsPage.SuspendLayout();
            CustomersPage.SuspendLayout();
            CartsPage.SuspendLayout();
            OrdersPage.SuspendLayout();
            PriorityOrdersPage.SuspendLayout();
            SuspendLayout();
            // 
            // MainTabControl
            // 
            MainTabControl.Controls.Add(ItemsPage);
            MainTabControl.Controls.Add(CustomersPage);
            MainTabControl.Controls.Add(CartsPage);
            MainTabControl.Controls.Add(OrdersPage);
            MainTabControl.Controls.Add(PriorityOrdersPage);
            MainTabControl.Dock = DockStyle.Fill;
            MainTabControl.Location = new Point(0, 0);
            MainTabControl.Name = "MainTabControl";
            MainTabControl.SelectedIndex = 0;
            MainTabControl.Size = new Size(800, 450);
            MainTabControl.TabIndex = 0;
            MainTabControl.SelectedIndexChanged += MainTabControl_SelectedIndexChanged;
            // 
            // ItemsPage
            // 
            ItemsPage.Controls.Add(ItemsTab);
            ItemsPage.Location = new Point(4, 29);
            ItemsPage.Name = "ItemsPage";
            ItemsPage.Padding = new Padding(3);
            ItemsPage.Size = new Size(792, 417);
            ItemsPage.TabIndex = 0;
            ItemsPage.Text = "Items";
            ItemsPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ItemsTab.Items = null;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(786, 411);
            ItemsTab.TabIndex = 0;
            // 
            // CustomersPage
            // 
            CustomersPage.Controls.Add(CustomersTab);
            CustomersPage.Location = new Point(4, 29);
            CustomersPage.Name = "CustomersPage";
            CustomersPage.Padding = new Padding(3);
            CustomersPage.Size = new Size(192, 67);
            CustomersPage.TabIndex = 1;
            CustomersPage.Text = "Customers";
            CustomersPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CustomersTab.Customers = null;
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Items = null;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(186, 61);
            CustomersTab.TabIndex = 0;
            // 
            // CartsPage
            // 
            CartsPage.Controls.Add(CartsTab);
            CartsPage.Location = new Point(4, 29);
            CartsPage.Name = "CartsPage";
            CartsPage.Size = new Size(192, 67);
            CartsPage.TabIndex = 2;
            CartsPage.Text = "Carts";
            CartsPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Customers = null;
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Items = null;
            CartsTab.Location = new Point(0, 0);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(192, 67);
            CartsTab.TabIndex = 0;
            // 
            // OrdersPage
            // 
            OrdersPage.Controls.Add(OrdersTab);
            OrdersPage.Location = new Point(4, 29);
            OrdersPage.Name = "OrdersPage";
            OrdersPage.Padding = new Padding(3);
            OrdersPage.Size = new Size(192, 67);
            OrdersPage.TabIndex = 3;
            OrdersPage.Text = "Orders";
            OrdersPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Customers = null;
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(186, 61);
            OrdersTab.TabIndex = 0;
            // 
            // PriorityOrdersPage
            // 
            PriorityOrdersPage.Controls.Add(PriorityOrdersTab);
            PriorityOrdersPage.Location = new Point(4, 29);
            PriorityOrdersPage.Name = "PriorityOrdersPage";
            PriorityOrdersPage.Padding = new Padding(3);
            PriorityOrdersPage.Size = new Size(792, 417);
            PriorityOrdersPage.TabIndex = 4;
            PriorityOrdersPage.Text = "Priority Orders";
            PriorityOrdersPage.UseVisualStyleBackColor = true;
            // 
            // PriorityOrdersTab
            // 
            PriorityOrdersTab.Dock = DockStyle.Fill;
            PriorityOrdersTab.Items = null;
            PriorityOrdersTab.Location = new Point(3, 3);
            PriorityOrdersTab.Name = "PriorityOrdersTab";
            PriorityOrdersTab.Size = new Size(786, 411);
            PriorityOrdersTab.TabIndex = 0;
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
            CartsPage.ResumeLayout(false);
            OrdersPage.ResumeLayout(false);
            PriorityOrdersPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTabControl;
        private TabPage ItemsPage;
        private TabPage CustomersPage;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage CartsPage;
        private View.Tabs.CartsTab CartsTab;
        private TabPage OrdersPage;
        private View.Tabs.OrdersTab OrdersTab;
        private TabPage PriorityOrdersPage;
        private View.Tabs.PriorityOrdersTab PriorityOrdersTab;
    }
}
