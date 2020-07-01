﻿namespace ForgeShopView
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
            this.ClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ImplementersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StoragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfForgeProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListForgeProductswithBilletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfBilletsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfBilletsToStoragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListStoragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗапускРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FillStoragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonСreateOrder = new System.Windows.Forms.Button();
            this.ButtonRef = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.toolStripMenuItem1,
            this.ЗапускРаботToolStripMenuItem,
            this.FillStoragesToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(993, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BilletsToolStripMenuItem,
            this.ForgeProductsToolStripMenuItem,
            this.ClientsToolStripMenuItem,
            this.ImplementersToolStripMenuItem,
            this.StoragesToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // BilletsToolStripMenuItem
            // 
            this.BilletsToolStripMenuItem.Name = "BilletsToolStripMenuItem";
            this.BilletsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.BilletsToolStripMenuItem.Text = "Заготовки";
            this.BilletsToolStripMenuItem.Click += new System.EventHandler(this.BilletsToolStripMenuItem_Click);
            // 
            // ForgeProductsToolStripMenuItem
            // 
            this.ForgeProductsToolStripMenuItem.Name = "ForgeProductsToolStripMenuItem";
            this.ForgeProductsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ForgeProductsToolStripMenuItem.Text = "Изделия";
            this.ForgeProductsToolStripMenuItem.Click += new System.EventHandler(this.ForgeProductsToolStripMenuItem_Click);
            // 
            // ClientsToolStripMenuItem
            // 
            this.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem";
            this.ClientsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ClientsToolStripMenuItem.Text = "Клиенты";
            this.ClientsToolStripMenuItem.Click += new System.EventHandler(this.ClientsToolStripMenuItem_Click);
            // 
            // ImplementersToolStripMenuItem
            // 
            this.ImplementersToolStripMenuItem.Name = "ImplementersToolStripMenuItem";
            this.ImplementersToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ImplementersToolStripMenuItem.Text = "Исполнители";
            this.ImplementersToolStripMenuItem.Click += new System.EventHandler(this.ImplementersToolStripMenuItem_Click);
            // 
            // StoragesToolStripMenuItem
            // 
            this.StoragesToolStripMenuItem.Name = "StoragesToolStripMenuItem";
            this.StoragesToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.StoragesToolStripMenuItem.Text = "Склады";
            this.StoragesToolStripMenuItem.Click += new System.EventHandler(this.StoragesToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListOfForgeProductsToolStripMenuItem,
            this.ListOfOrdersToolStripMenuItem,
            this.ListForgeProductswithBilletsToolStripMenuItem,
            this.ListOfBilletsToolStripMenuItem,
            this.ListOfBilletsToStoragesToolStripMenuItem,
            this.ListStoragesToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // ListOfForgeProductsToolStripMenuItem
            // 
            this.ListOfForgeProductsToolStripMenuItem.Name = "ListOfForgeProductsToolStripMenuItem";
            this.ListOfForgeProductsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ListOfForgeProductsToolStripMenuItem.Text = "Список изделий";
            this.ListOfForgeProductsToolStripMenuItem.Click += new System.EventHandler(this.ListOfForgeProductsToolStripMenuItem_Click);
            // 
            // ListOfOrdersToolStripMenuItem
            // 
            this.ListOfOrdersToolStripMenuItem.Name = "ListOfOrdersToolStripMenuItem";
            this.ListOfOrdersToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ListOfOrdersToolStripMenuItem.Text = "Список заказов";
            this.ListOfOrdersToolStripMenuItem.Click += new System.EventHandler(this.ListOfOrdersToolStripMenuItem_Click);
            // 
            // ListForgeProductswithBilletsToolStripMenuItem
            // 
            this.ListForgeProductswithBilletsToolStripMenuItem.Name = "ListForgeProductswithBilletsToolStripMenuItem";
            this.ListForgeProductswithBilletsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ListForgeProductswithBilletsToolStripMenuItem.Text = "Список изделий по заготовкам";
            this.ListForgeProductswithBilletsToolStripMenuItem.Click += new System.EventHandler(this.ListForgeProductswithBilletsToolStripMenuItem_Click);
            // 
            // ListOfBilletsToolStripMenuItem
            // 
            this.ListOfBilletsToolStripMenuItem.Name = "ListOfBilletsToolStripMenuItem";
            this.ListOfBilletsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ListOfBilletsToolStripMenuItem.Text = "Список заготовок";
            this.ListOfBilletsToolStripMenuItem.Click += new System.EventHandler(this.ListOfBilletsToolStripMenuItem_Click);
            // 
            // ListOfBilletsToStoragesToolStripMenuItem
            // 
            this.ListOfBilletsToStoragesToolStripMenuItem.Name = "ListOfBilletsToStoragesToolStripMenuItem";
            this.ListOfBilletsToStoragesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ListOfBilletsToStoragesToolStripMenuItem.Text = "Список заготовок на складах";
            this.ListOfBilletsToStoragesToolStripMenuItem.Click += new System.EventHandler(this.ListOfBilletsToStoragesToolStripMenuItem_Click);
            // 
            // ListStoragesToolStripMenuItem
            // 
            this.ListStoragesToolStripMenuItem.Name = "ListStoragesToolStripMenuItem";
            this.ListStoragesToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.ListStoragesToolStripMenuItem.Text = "Список складов";
            this.ListStoragesToolStripMenuItem.Click += new System.EventHandler(this.ListStoragesToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // ЗапускРаботToolStripMenuItem
            // 
            this.ЗапускРаботToolStripMenuItem.Name = "ЗапускРаботToolStripMenuItem";
            this.ЗапускРаботToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ЗапускРаботToolStripMenuItem.Text = "Запуск работ";
            this.ЗапускРаботToolStripMenuItem.Click += new System.EventHandler(this.ЗапускРаботToolStripMenuItem_Click);
            // 
            // FillStoragesToolStripMenuItem
            // 
            this.FillStoragesToolStripMenuItem.Name = "FillStoragesToolStripMenuItem";
            this.FillStoragesToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.FillStoragesToolStripMenuItem.Text = "Пополнение складов";
            this.FillStoragesToolStripMenuItem.Click += new System.EventHandler(this.FillStoragesToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(847, 307);
            this.dataGridView.TabIndex = 1;
            // 
            // ButtonСreateOrder
            // 
            this.ButtonСreateOrder.Location = new System.Drawing.Point(855, 45);
            this.ButtonСreateOrder.Name = "ButtonСreateOrder";
            this.ButtonСreateOrder.Size = new System.Drawing.Size(126, 29);
            this.ButtonСreateOrder.TabIndex = 2;
            this.ButtonСreateOrder.Text = "Создать заказ";
            this.ButtonСreateOrder.UseVisualStyleBackColor = true;
            this.ButtonСreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // ButtonRef
            // 
            this.ButtonRef.Location = new System.Drawing.Point(855, 91);
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
            this.ClientSize = new System.Drawing.Size(993, 332);
            this.Controls.Add(this.ButtonRef);
            this.Controls.Add(this.ButtonСreateOrder);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Кузнечная мастерская";
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
        private System.Windows.Forms.Button ButtonRef;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfForgeProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListForgeProductswithBilletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ImplementersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЗапускРаботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StoragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FillStoragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfBilletsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListOfBilletsToStoragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListStoragesToolStripMenuItem;
    }
}