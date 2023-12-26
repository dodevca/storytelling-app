namespace StoryTelling.View
{
    partial class List
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
            this.query = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.listPost = new System.Windows.Forms.ListView();
            this.createBtn = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // query
            // 
            this.query.Location = new System.Drawing.Point(12, 35);
            this.query.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.query.Name = "query";
            this.query.Size = new System.Drawing.Size(781, 22);
            this.query.TabIndex = 1;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(799, 26);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(73, 40);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // listPost
            // 
            this.listPost.HideSelection = false;
            this.listPost.Location = new System.Drawing.Point(13, 90);
            this.listPost.Margin = new System.Windows.Forms.Padding(4);
            this.listPost.Name = "listPost";
            this.listPost.Size = new System.Drawing.Size(858, 355);
            this.listPost.TabIndex = 4;
            this.listPost.UseCompatibleStateImageBehavior = false;
            // 
            // createBtn
            // 
            this.createBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.Location = new System.Drawing.Point(703, 451);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(168, 40);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Tambah Unggahan";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // refresh
            // 
            this.refresh.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refresh.Location = new System.Drawing.Point(13, 451);
            this.refresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(168, 40);
            this.refresh.TabIndex = 6;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 502);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.listPost);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.query);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "List";
            this.Text = "searching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox query;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ListView listPost;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button refresh;
    }
}