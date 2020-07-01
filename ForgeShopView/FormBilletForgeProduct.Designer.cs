namespace ForgeShopView
{
    partial class FormBilletForgeProduct
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
            this.comboBoxBillet = new System.Windows.Forms.ComboBox();
            this.labelbillet = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxBillet
            // 
            this.comboBoxBillet.FormattingEnabled = true;
            this.comboBoxBillet.Location = new System.Drawing.Point(97, 21);
            this.comboBoxBillet.Name = "comboBoxBillet";
            this.comboBoxBillet.Size = new System.Drawing.Size(136, 21);
            this.comboBoxBillet.TabIndex = 0;
            // 
            // labelbillet
            // 
            this.labelbillet.AutoSize = true;
            this.labelbillet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelbillet.Location = new System.Drawing.Point(12, 21);
            this.labelbillet.Name = "labelbillet";
            this.labelbillet.Size = new System.Drawing.Size(79, 17);
            this.labelbillet.TabIndex = 1;
            this.labelbillet.Text = "Заготовка:";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcount.Location = new System.Drawing.Point(10, 52);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(90, 17);
            this.labelcount.TabIndex = 2;
            this.labelcount.Text = "Количество:";
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(97, 51);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(136, 20);
            this.textBoxCount.TabIndex = 3;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(111, 87);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(104, 27);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(232, 87);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(104, 27);
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // FormBilletForgeProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 130);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labelbillet);
            this.Controls.Add(this.comboBoxBillet);
            this.Name = "FormBilletForgeProduct";
            this.Text = "Заготовка изделия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxBillet;
        private System.Windows.Forms.Label labelbillet;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.TextBox textBoxCount;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
    }
}