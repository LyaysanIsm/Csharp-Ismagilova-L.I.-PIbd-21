namespace ForgeShopView
{
    partial class FormReportStorageBillet
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
            this.ButtonSaveToExcel = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Columnstorage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnbillet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columncount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSaveToExcel
            // 
            this.ButtonSaveToExcel.Location = new System.Drawing.Point(430, 10);
            this.ButtonSaveToExcel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSaveToExcel.Name = "ButtonSaveToExcel";
            this.ButtonSaveToExcel.Size = new System.Drawing.Size(128, 24);
            this.ButtonSaveToExcel.TabIndex = 0;
            this.ButtonSaveToExcel.Text = "Сохранить в Excel";
            this.ButtonSaveToExcel.UseVisualStyleBackColor = true;
            this.ButtonSaveToExcel.Click += new System.EventHandler(this.ButtonSaveToExcel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnstorage,
            this.Columnbillet,
            this.Columncount});
            this.dataGridView.Location = new System.Drawing.Point(5, 46);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(590, 312);
            this.dataGridView.TabIndex = 1;
            // 
            // Columnstorage
            // 
            this.Columnstorage.HeaderText = "Склад";
            this.Columnstorage.MinimumWidth = 6;
            this.Columnstorage.Name = "Columnstorage";
            this.Columnstorage.Width = 125;
            // 
            // Columnbillet
            // 
            this.Columnbillet.HeaderText = "Заготовка";
            this.Columnbillet.MinimumWidth = 6;
            this.Columnbillet.Name = "Columnbillet";
            this.Columnbillet.Width = 125;
            // 
            // Columncount
            // 
            this.Columncount.HeaderText = "Количество";
            this.Columncount.MinimumWidth = 6;
            this.Columncount.Name = "Columncount";
            this.Columncount.Width = 125;
            // 
            // FormReportStorageBillet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.ButtonSaveToExcel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormReportStorageBillet";
            this.Text = "Отчет по заготовкам на складах";
            this.Load += new System.EventHandler(this.FormReportStorageBillet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonSaveToExcel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnstorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnbillet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncount;
    }
}