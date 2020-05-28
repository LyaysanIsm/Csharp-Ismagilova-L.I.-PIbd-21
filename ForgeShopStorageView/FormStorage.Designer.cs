namespace ForgeShopStorageView
{
    partial class FormStorage
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
            this.storageNameLabel = new System.Windows.Forms.Label();
            this.storageNameTextBox = new System.Windows.Forms.TextBox();
            this.BilletsGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.BilletsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // storageNameLabel
            // 
            this.storageNameLabel.AutoSize = true;
            this.storageNameLabel.Location = new System.Drawing.Point(21, 9);
            this.storageNameLabel.Name = "storageNameLabel";
            this.storageNameLabel.Size = new System.Drawing.Size(60, 13);
            this.storageNameLabel.TabIndex = 0;
            this.storageNameLabel.Text = "Название:";
            // 
            // storageNameTextBox
            // 
            this.storageNameTextBox.Location = new System.Drawing.Point(87, 6);
            this.storageNameTextBox.Name = "storageNameTextBox";
            this.storageNameTextBox.Size = new System.Drawing.Size(234, 20);
            this.storageNameTextBox.TabIndex = 1;
            // 
            // BilletsGroupBox
            // 
            this.BilletsGroupBox.Controls.Add(this.dataGridView);
            this.BilletsGroupBox.Location = new System.Drawing.Point(11, 43);
            this.BilletsGroupBox.Name = "BilletsGroupBox";
            this.BilletsGroupBox.Size = new System.Drawing.Size(405, 362);
            this.BilletsGroupBox.TabIndex = 2;
            this.BilletsGroupBox.TabStop = false;
            this.BilletsGroupBox.Text = "Компоненты";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 19);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(403, 342);
            this.dataGridView.TabIndex = 0;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(260, 411);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(341, 411);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormStorage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 443);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.BilletsGroupBox);
            this.Controls.Add(this.storageNameTextBox);
            this.Controls.Add(this.storageNameLabel);
            this.Name = "FormStorage";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.FormStorage_Load);
            this.BilletsGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label storageNameLabel;
        private System.Windows.Forms.TextBox storageNameTextBox;
        private System.Windows.Forms.GroupBox BilletsGroupBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
    }
}