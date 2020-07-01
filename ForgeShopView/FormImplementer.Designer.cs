namespace ForgeShopView
{
    partial class FormImplementer
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
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.textBoxWorkingTime = new System.Windows.Forms.TextBox();
            this.labelWorkingTime = new System.Windows.Forms.Label();
            this.textBoxPauseTime = new System.Windows.Forms.TextBox();
            this.labelPauseTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(13, 24);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 0;
            this.labelFIO.Text = "ФИО";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(119, 21);
            this.textBoxFIO.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(245, 20);
            this.textBoxFIO.TabIndex = 1;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(189, 93);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(89, 29);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(282, 93);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(82, 29);
            this.ButtonCancel.TabIndex = 3;
            this.ButtonCancel.Text = "Отменить";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textBoxWorkingTime
            // 
            this.textBoxWorkingTime.Location = new System.Drawing.Point(119, 45);
            this.textBoxWorkingTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxWorkingTime.Name = "textBoxWorkingTime";
            this.textBoxWorkingTime.Size = new System.Drawing.Size(245, 20);
            this.textBoxWorkingTime.TabIndex = 5;
            // 
            // labelWorkingTime
            // 
            this.labelWorkingTime.AutoSize = true;
            this.labelWorkingTime.Location = new System.Drawing.Point(13, 48);
            this.labelWorkingTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWorkingTime.Name = "labelWorkingTime";
            this.labelWorkingTime.Size = new System.Drawing.Size(92, 13);
            this.labelWorkingTime.TabIndex = 4;
            this.labelWorkingTime.Text = "Время на работу";
            // 
            // textBoxPauseTime
            // 
            this.textBoxPauseTime.Location = new System.Drawing.Point(119, 69);
            this.textBoxPauseTime.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPauseTime.Name = "textBoxPauseTime";
            this.textBoxPauseTime.Size = new System.Drawing.Size(245, 20);
            this.textBoxPauseTime.TabIndex = 7;
            // 
            // labelPauseTime
            // 
            this.labelPauseTime.AutoSize = true;
            this.labelPauseTime.Location = new System.Drawing.Point(13, 72);
            this.labelPauseTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPauseTime.Name = "labelPauseTime";
            this.labelPauseTime.Size = new System.Drawing.Size(102, 13);
            this.labelPauseTime.TabIndex = 6;
            this.labelPauseTime.Text = "Время на перерыв";
            // 
            // FormImplementer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 137);
            this.Controls.Add(this.textBoxPauseTime);
            this.Controls.Add(this.labelPauseTime);
            this.Controls.Add(this.textBoxWorkingTime);
            this.Controls.Add(this.labelWorkingTime);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormImplementer";
            this.Text = "Исполнитель";
            this.Load += new System.EventHandler(this.FormImplementer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.TextBox textBoxWorkingTime;
        private System.Windows.Forms.Label labelWorkingTime;
        private System.Windows.Forms.TextBox textBoxPauseTime;
        private System.Windows.Forms.Label labelPauseTime;
    }
}