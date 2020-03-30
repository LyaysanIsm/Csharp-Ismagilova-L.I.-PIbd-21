namespace ForgeShopView
{
    partial class FormReportForgeProductBillets
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Columnbillet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnforgeproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columncount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonSaveToExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Columnbillet,
            this.Columnforgeproduct,
            this.Columncount});
            this.dataGridView.Location = new System.Drawing.Point(1, 40);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(462, 303);
            this.dataGridView.TabIndex = 0;
            // 
            // Columnbillet
            // 
            this.Columnbillet.HeaderText = "Billet";
            this.Columnbillet.Name = "Columnbillet";
            // 
            // Columnforgeproduct
            // 
            this.Columnforgeproduct.HeaderText = "Forge Product";
            this.Columnforgeproduct.Name = "Columnforgeproduct";
            // 
            // Columncount
            // 
            this.Columncount.HeaderText = "Count";
            this.Columncount.Name = "Columncount";
            // 
            // ButtonSaveToExcel
            // 
            this.ButtonSaveToExcel.Location = new System.Drawing.Point(10, 8);
            this.ButtonSaveToExcel.Name = "ButtonSaveToExcel";
            this.ButtonSaveToExcel.Size = new System.Drawing.Size(122, 26);
            this.ButtonSaveToExcel.TabIndex = 1;
            this.ButtonSaveToExcel.Text = "Save to Excel";
            this.ButtonSaveToExcel.UseVisualStyleBackColor = true;
            this.ButtonSaveToExcel.Click += new System.EventHandler(this.ButtonSaveToExcel_Click);
            // 
            // FormReportForgeProductBillets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 343);
            this.Controls.Add(this.ButtonSaveToExcel);
            this.Controls.Add(this.dataGridView);
            this.Name = "FormReportForgeProductBillets";
            this.Text = "Billets by Forge Product";
            this.Load += new System.EventHandler(this.FormReportForgeProductBillets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnbillet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columnforgeproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Columncount;
        private System.Windows.Forms.Button ButtonSaveToExcel;
    }
}