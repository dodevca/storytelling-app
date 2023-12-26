namespace StoryTelling.View
{
    partial class PostDetail
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
            this.title = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.view = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(92, 32);
            this.title.TabIndex = 0;
            this.title.Text = "label1";
            // 
            // content
            // 
            this.content.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.content.Location = new System.Drawing.Point(18, 89);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(852, 349);
            this.content.TabIndex = 2;
            // 
            // date
            // 
            this.date.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.date.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.date.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.date.Location = new System.Drawing.Point(18, 48);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(420, 15);
            this.date.TabIndex = 3;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.view.Location = new System.Drawing.Point(444, 48);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(426, 15);
            this.view.TabIndex = 4;
            // 
            // PostDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.view);
            this.Controls.Add(this.date);
            this.Controls.Add(this.content);
            this.Controls.Add(this.title);
            this.Name = "PostDetail";
            this.Text = "Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox view;
    }
}