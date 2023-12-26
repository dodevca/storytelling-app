namespace StoryTelling.View
{
    partial class NewPost
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
            this.title = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.content = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.title.Location = new System.Drawing.Point(113, 65);
            this.title.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(600, 22);
            this.title.TabIndex = 0;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.description.Location = new System.Drawing.Point(113, 130);
            this.description.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(600, 80);
            this.description.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Masukan Judul Artikel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Deskripsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Isi";
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.uploadBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadBtn.Location = new System.Drawing.Point(628, 456);
            this.uploadBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(85, 26);
            this.uploadBtn.TabIndex = 6;
            this.uploadBtn.Text = "Upload";
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.content.Location = new System.Drawing.Point(113, 247);
            this.content.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(600, 183);
            this.content.TabIndex = 7;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.cancelBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Location = new System.Drawing.Point(537, 456);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(85, 26);
            this.cancelBtn.TabIndex = 8;
            this.cancelBtn.Text = "Batal";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // NewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(884, 502);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.content);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NewPost";
            this.Text = "UploadArtikel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Button cancelBtn;
    }
}