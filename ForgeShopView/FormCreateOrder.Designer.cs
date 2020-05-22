namespace ForgeShopView
{
    partial class FormCreateOrder
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
            this.labelforgeproduct = new System.Windows.Forms.Label();
            this.labelcount = new System.Windows.Forms.Label();
            this.labelsum = new System.Windows.Forms.Label();
            this.ComboBoxForgeProduct = new System.Windows.Forms.ComboBox();
            this.TextBoxCount = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ComboBoxClient = new System.Windows.Forms.ComboBox();
            this.labelclient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelforgeproduct
            // 
            this.labelforgeproduct.AutoSize = true;
            this.labelforgeproduct.Location = new System.Drawing.Point(17, 28);
            this.labelforgeproduct.Name = "labelforgeproduct";
            this.labelforgeproduct.Size = new System.Drawing.Size(77, 13);
            this.labelforgeproduct.TabIndex = 0;
            this.labelforgeproduct.Text = "Forge Product:";
            // 
            // labelcount
            // 
            this.labelcount.AutoSize = true;
            this.labelcount.Location = new System.Drawing.Point(17, 94);
            this.labelcount.Name = "labelcount";
            this.labelcount.Size = new System.Drawing.Size(38, 13);
            this.labelcount.TabIndex = 1;
            this.labelcount.Text = "Count:";
            this.labelcount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelsum
            // 
            this.labelsum.AutoSize = true;
            this.labelsum.Location = new System.Drawing.Point(17, 130);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(31, 13);
            this.labelsum.TabIndex = 2;
            this.labelsum.Text = "Sum:";
            // 
            // ComboBoxForgeProduct
            // 
            this.ComboBoxForgeProduct.FormattingEnabled = true;
            this.ComboBoxForgeProduct.Location = new System.Drawing.Point(100, 25);
            this.ComboBoxForgeProduct.Name = "ComboBoxForgeProduct";
            this.ComboBoxForgeProduct.Size = new System.Drawing.Size(170, 21);
            this.ComboBoxForgeProduct.TabIndex = 3;
            this.ComboBoxForgeProduct.SelectedIndexChanged += new System.EventHandler(this.ComboBoxForgeProduct_SelectedIndexChanged);
            // 
            // TextBoxCount
            // 
            this.TextBoxCount.Location = new System.Drawing.Point(100, 91);
            this.TextBoxCount.Name = "TextBoxCount";
            this.TextBoxCount.Size = new System.Drawing.Size(170, 20);
            this.TextBoxCount.TabIndex = 4;
            this.TextBoxCount.TextChanged += new System.EventHandler(this.TextBoxCount_TextChanged);
            // 
            // textBoxSum
            // 
            this.textBoxSum.Location = new System.Drawing.Point(100, 127);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(170, 20);
            this.textBoxSum.TabIndex = 5;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(100, 153);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(82, 25);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(199, 153);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(71, 25);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ComboBoxClient
            // 
            this.ComboBoxClient.FormattingEnabled = true;
            this.ComboBoxClient.Location = new System.Drawing.Point(100, 57);
            this.ComboBoxClient.Name = "ComboBoxClient";
            this.ComboBoxClient.Size = new System.Drawing.Size(170, 21);
            this.ComboBoxClient.TabIndex = 8;
            // 
            // labelclient
            // 
            this.labelclient.AutoSize = true;
            this.labelclient.Location = new System.Drawing.Point(17, 60);
            this.labelclient.Name = "labelclient";
            this.labelclient.Size = new System.Drawing.Size(46, 13);
            this.labelclient.TabIndex = 9;
            this.labelclient.Text = "Клиент:";
            // 
            // FormCreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 199);
            this.Controls.Add(this.labelclient);
            this.Controls.Add(this.ComboBoxClient);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.TextBoxCount);
            this.Controls.Add(this.ComboBoxForgeProduct);
            this.Controls.Add(this.labelsum);
            this.Controls.Add(this.labelcount);
            this.Controls.Add(this.labelforgeproduct);
            this.Name = "FormCreateOrder";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.FormCreateOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelforgeproduct;
        private System.Windows.Forms.Label labelcount;
        private System.Windows.Forms.Label labelsum;
        private System.Windows.Forms.ComboBox ComboBoxForgeProduct;
        private System.Windows.Forms.TextBox TextBoxCount;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox ComboBoxClient;
        private System.Windows.Forms.Label labelclient;
    }
}