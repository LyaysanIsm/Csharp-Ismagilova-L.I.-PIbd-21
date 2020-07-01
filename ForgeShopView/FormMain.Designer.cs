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
            this.ЗаготовкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ИзделияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.КлиентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ИсполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СообщенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СписокИзделийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СписокЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СписокИзделийпоЗаготовкамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ЗапускРаботToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.СоздатьБэкапToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonСreateOrder = new System.Windows.Forms.Button();
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
            this.отчетыToolStripMenuItem,
            this.ЗапускРаботToolStripMenuItem,
            this.СоздатьБэкапToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1018, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ЗаготовкиToolStripMenuItem,
            this.ИзделияToolStripMenuItem,
            this.КлиентыToolStripMenuItem,
            this.ИсполнителиToolStripMenuItem,
            this.СообщенияToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // ЗаготовкиToolStripMenuItem
            // 
            this.ЗаготовкиToolStripMenuItem.Name = "ЗаготовкиToolStripMenuItem";
            this.ЗаготовкиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ЗаготовкиToolStripMenuItem.Text = "Заготовки";
            this.ЗаготовкиToolStripMenuItem.Click += new System.EventHandler(this.ЗаготовкиToolStripMenuItem_Click);
            // 
            // ИзделияToolStripMenuItem
            // 
            this.ИзделияToolStripMenuItem.Name = "ИзделияToolStripMenuItem";
            this.ИзделияToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ИзделияToolStripMenuItem.Text = "Изделия";
            this.ИзделияToolStripMenuItem.Click += new System.EventHandler(this.ИзделияToolStripMenuItem_Click);
            // 
            // КлиентыToolStripMenuItem
            // 
            this.КлиентыToolStripMenuItem.Name = "КлиентыToolStripMenuItem";
            this.КлиентыToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.КлиентыToolStripMenuItem.Text = "Клиенты";
            this.КлиентыToolStripMenuItem.Click += new System.EventHandler(this.КлиентыToolStripMenuItem_Click);
            // 
            // ИсполнителиToolStripMenuItem
            // 
            this.ИсполнителиToolStripMenuItem.Name = "ИсполнителиToolStripMenuItem";
            this.ИсполнителиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ИсполнителиToolStripMenuItem.Text = "Исполнители";
            this.ИсполнителиToolStripMenuItem.Click += new System.EventHandler(this.ИсполнителиToolStripMenuItem_Click);
            // 
            // СообщенияToolStripMenuItem
            // 
            this.СообщенияToolStripMenuItem.Name = "СообщенияToolStripMenuItem";
            this.СообщенияToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.СообщенияToolStripMenuItem.Text = "Сообщения";
            this.СообщенияToolStripMenuItem.Click += new System.EventHandler(this.СообщенияToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.СписокИзделийToolStripMenuItem,
            this.СписокЗаказовToolStripMenuItem,
            this.СписокИзделийпоЗаготовкамToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // СписокИзделийToolStripMenuItem
            // 
            this.СписокИзделийToolStripMenuItem.Name = "СписокИзделийToolStripMenuItem";
            this.СписокИзделийToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.СписокИзделийToolStripMenuItem.Text = "Список изделий";
            this.СписокИзделийToolStripMenuItem.Click += new System.EventHandler(this.СписокИзделийToolStripMenuItem_Click);
            // 
            // СписокЗаказовToolStripMenuItem
            // 
            this.СписокЗаказовToolStripMenuItem.Name = "СписокЗаказовToolStripMenuItem";
            this.СписокЗаказовToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.СписокЗаказовToolStripMenuItem.Text = "Список заказов";
            this.СписокЗаказовToolStripMenuItem.Click += new System.EventHandler(this.СписокЗаказовToolStripMenuItem_Click);
            // 
            // СписокИзделийпоЗаготовкамToolStripMenuItem
            // 
            this.СписокИзделийпоЗаготовкамToolStripMenuItem.Name = "СписокИзделийпоЗаготовкамToolStripMenuItem";
            this.СписокИзделийпоЗаготовкамToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.СписокИзделийпоЗаготовкамToolStripMenuItem.Text = "Список изделий по заготовкам";
            this.СписокИзделийпоЗаготовкамToolStripMenuItem.Click += new System.EventHandler(this.СписокИзделийпоЗаготовкамToolStripMenuItem_Click);
            // 
            // ЗапускРаботToolStripMenuItem
            // 
            this.ЗапускРаботToolStripMenuItem.Name = "ЗапускРаботToolStripMenuItem";
            this.ЗапускРаботToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.ЗапускРаботToolStripMenuItem.Text = "Запуск работ";
            this.ЗапускРаботToolStripMenuItem.Click += new System.EventHandler(this.ЗапускРаботToolStripMenuItem_Click);
            // 
            // СоздатьБэкапToolStripMenuItem
            // 
            this.СоздатьБэкапToolStripMenuItem.Name = "СоздатьБэкапToolStripMenuItem";
            this.СоздатьБэкапToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.СоздатьБэкапToolStripMenuItem.Text = "Создать бэкап";
            this.СоздатьБэкапToolStripMenuItem.Click += new System.EventHandler(this.СоздатьБэкапToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(2, 23);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(862, 307);
            this.dataGridView.TabIndex = 1;
            // 
            // ButtonСreateOrder
            // 
            this.ButtonСreateOrder.Location = new System.Drawing.Point(882, 45);
            this.ButtonСreateOrder.Name = "ButtonСreateOrder";
            this.ButtonСreateOrder.Size = new System.Drawing.Size(126, 29);
            this.ButtonСreateOrder.TabIndex = 2;
            this.ButtonСreateOrder.Text = "Создать заказ";
            this.ButtonСreateOrder.UseVisualStyleBackColor = true;
            this.ButtonСreateOrder.Click += new System.EventHandler(this.ButtonCreateOrder_Click);
            // 
            // ButtonPayOrder
            // 
            this.ButtonPayOrder.Location = new System.Drawing.Point(882, 80);
            this.ButtonPayOrder.Name = "ButtonPayOrder";
            this.ButtonPayOrder.Size = new System.Drawing.Size(126, 29);
            this.ButtonPayOrder.TabIndex = 5;
            this.ButtonPayOrder.Text = "Заказ оплачен";
            this.ButtonPayOrder.UseVisualStyleBackColor = true;
            this.ButtonPayOrder.Click += new System.EventHandler(this.ButtonPayOrder_Click);
            // 
            // ButtonRef
            // 
            this.ButtonRef.Location = new System.Drawing.Point(882, 115);
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
            this.ClientSize = new System.Drawing.Size(1018, 335);
            this.Controls.Add(this.ButtonRef);
            this.Controls.Add(this.ButtonPayOrder);
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
        private System.Windows.Forms.ToolStripMenuItem ЗаготовкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ИзделияToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButtonСreateOrder;
        private System.Windows.Forms.Button ButtonPayOrder;
        private System.Windows.Forms.Button ButtonRef;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СписокИзделийToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СписокЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СписокИзделийпоЗаготовкамToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem КлиентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ИсполнителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ЗапускРаботToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СообщенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem СоздатьБэкапToolStripMenuItem;
    }
}