namespace StoryTelling.View
{
    partial class ReportPayout
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
            this.listPayout = new System.Windows.Forms.ListView();
            this.showBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.sortAsc = new System.Windows.Forms.RadioButton();
            this.sortDesc = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listPayout
            // 
            this.listPayout.HideSelection = false;
            this.listPayout.Location = new System.Drawing.Point(13, 101);
            this.listPayout.Margin = new System.Windows.Forms.Padding(4);
            this.listPayout.Name = "listPayout";
            this.listPayout.Size = new System.Drawing.Size(858, 388);
            this.listPayout.TabIndex = 4;
            this.listPayout.UseCompatibleStateImageBehavior = false;
            // 
            // showBtn
            // 
            this.showBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showBtn.Location = new System.Drawing.Point(704, 11);
            this.showBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(168, 40);
            this.showBtn.TabIndex = 6;
            this.showBtn.Text = "Tampilkan";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(704, 55);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(168, 40);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // sortAsc
            // 
            this.sortAsc.AutoSize = true;
            this.sortAsc.Location = new System.Drawing.Point(13, 65);
            this.sortAsc.Name = "sortAsc";
            this.sortAsc.Size = new System.Drawing.Size(79, 20);
            this.sortAsc.TabIndex = 8;
            this.sortAsc.TabStop = true;
            this.sortAsc.Text = "Terlama";
            this.sortAsc.UseVisualStyleBackColor = true;
            // 
            // sortDesc
            // 
            this.sortDesc.AutoSize = true;
            this.sortDesc.Checked = true;
            this.sortDesc.Location = new System.Drawing.Point(13, 39);
            this.sortDesc.Name = "sortDesc";
            this.sortDesc.Size = new System.Drawing.Size(76, 20);
            this.sortDesc.TabIndex = 9;
            this.sortDesc.TabStop = true;
            this.sortDesc.Text = "Terbaru";
            this.sortDesc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Urutkan";
            // 
            // ReportPayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sortDesc);
            this.Controls.Add(this.sortAsc);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.listPayout);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportPayout";
            this.Text = "searching";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listPayout;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.RadioButton sortAsc;
        private System.Windows.Forms.RadioButton sortDesc;
        private System.Windows.Forms.Label label1;
    }
}