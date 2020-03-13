namespace ForgeShopView
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BilletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ForgeProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StoragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FillStoragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonСreateOrder = new System.Windows.Forms.Button();
            this.ButtonTakeOrderInWork = new System.Windows.Forms.Button();
            this.ButtonOrderReady = new System.Windows.Forms.Button();
            this.ButtonPayOrder = new System.Windows.Forms.Button();
            this.ButtonRef = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.FillStoragesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(850, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BilletsToolStripMenuItem,
            this.ForgeProductsToolStripMenuItem,
            this.StoragesToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // BilletsToolStripMenuItem
            // 
            this.BilletsToolStripMenuItem.Name = "BilletsToolStripMenuItem";
            this.BilletsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BilletsToolStripMenuItem.Text = "Billets";
            this.BilletsToolStripMenuItem.Click += new System.EventHandler(this.BilletsToolStripMenuItem_Click);
            // 
            // ForgeProductsToolStripMenuItem
            // 
            this.ForgeProductsToolStripMenuItem.Name = "ForgeProductsToolStripMenuItem";
            this.ForgeProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ForgeProductsToolStripMenuItem.Text = "Forge Products";
            this.ForgeProductsToolStripMenuItem.Click += new System.EventHandler(this.ForgeProductsToolStripMenuItem_Click);
            // 
            // StoragesToolStripMenuItem
            // 
            this.StoragesToolStripMenuItem.Name = "StoragesToolStripMenuItem";
            this.StoragesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.StoragesToolStripMenuItem.Text = "Storages";
            this.StoragesToolStripMenuItem.Click += new System.EventHandler(this.StoragesToolStripMenuItem_Click);
            // 
            // FillStoragesToolStripMenuItem
            // 
            this.FillStoragesToolStripMenuItem.Name = "FillStoragesToolStripMenuItem";
            this.FillStoragesToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.FillStoragesToolStripMenuItem.Text = "Fill Storages";
            this.FillStoragesToolStripMenuItem.Click += new System.EventHandler(this.FillStoragesToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(704, 307);
            this.dataGridView.TabIndex = 1;
            // 
            // ButtonСreateOrder
            // 
            this.ButtonСreateOrder.Location = new System.Drawing.Point(712, 43);
            this.ButtonСreateOrder.Name = "ButtonСreateOrder";
            this.ButtonСreateOrder.Size = new System.Drawing.Size(126, 29);
            this.ButtonСreateOrder.TabIndex = 2;
            this.ButtonСreateOrder.Text = "Создать заказ";
            this.ButtonСreateOrder.UseVisualStyleBackColor = true;
            this.ButtonСreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // ButtonTakeOrderInWork
            // 
            this.ButtonTakeOrderInWork.Location = new System.Drawing.Point(712, 88);
            this.ButtonTakeOrderInWork.Name = "ButtonTakeOrderInWork";
            this.ButtonTakeOrderInWork.Size = new System.Drawing.Size(126, 40);
            this.ButtonTakeOrderInWork.TabIndex = 3;
            this.ButtonTakeOrderInWork.Text = "Отдать на выполнение";
            this.ButtonTakeOrderInWork.UseVisualStyleBackColor = true;
            this.ButtonTakeOrderInWork.Click += new System.EventHandler(this.ButtonTakeOrderInWork_Click);
            // 
            // ButtonOrderReady
            // 
            this.ButtonOrderReady.Location = new System.Drawing.Point(712, 144);
            this.ButtonOrderReady.Name = "ButtonOrderReady";
            this.ButtonOrderReady.Size = new System.Drawing.Size(126, 29);
            this.ButtonOrderReady.TabIndex = 4;
            this.ButtonOrderReady.Text = "Заказ готов";
            this.ButtonOrderReady.UseVisualStyleBackColor = true;
            this.ButtonOrderReady.Click += new System.EventHandler(this.ButtonOrderReady_Click);
            // 
            // ButtonPayOrder
            // 
            this.ButtonPayOrder.Location = new System.Drawing.Point(712, 190);
            this.ButtonPayOrder.Name = "ButtonPayOrder";
            this.ButtonPayOrder.Size = new System.Drawing.Size(126, 29);
            this.ButtonPayOrder.TabIndex = 5;
            this.ButtonPayOrder.Text = "Заказ оплачен";
            this.ButtonPayOrder.UseVisualStyleBackColor = true;
            this.ButtonPayOrder.Click += new System.EventHandler(this.ButtonPayOrder_Click);
            // 
            // ButtonRef
            // 
            this.ButtonRef.Location = new System.Drawing.Point(712, 237);
            this.ButtonRef.Name = "ButtonRef";
            this.ButtonRef.Size = new System.Drawing.Size(126, 29);
            this.ButtonRef.TabIndex = 6;
            this.ButtonRef.Text = "Обновить список";
            this.ButtonRef.UseVisualStyleBackColor = true;
            this.ButtonRef.Click += new System.EventHandler(this.ButtonRef_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 331);
            this.Controls.Add(this.ButtonRef);
            this.Controls.Add(this.ButtonPayOrder);
            this.Controls.Add(this.ButtonOrderReady);
            this.Controls.Add(this.ButtonTakeOrderInWork);
            this.Controls.Add(this.ButtonСreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "ForgeShop";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BilletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ForgeProductsToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButtonСreateOrder;
        private System.Windows.Forms.Button ButtonTakeOrderInWork;
        private System.Windows.Forms.Button ButtonOrderReady;
        private System.Windows.Forms.Button ButtonPayOrder;
        private System.Windows.Forms.Button ButtonRef;
        private System.Windows.Forms.ToolStripMenuItem StoragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FillStoragesToolStripMenuItem;
    }
}