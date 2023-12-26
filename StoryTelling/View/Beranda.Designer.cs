namespace StoryTelling.View
{
    partial class Beranda
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.changeBtn = new System.Windows.Forms.Button();
            this.payout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.TextBox();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.balance = new System.Windows.Forms.TextBox();
            this.post = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.greeting = new System.Windows.Forms.Label();
            this.reportBtn = new System.Windows.Forms.Button();
            this.showListBtn = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.DarkGray;
            this.changeBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBtn.Location = new System.Drawing.Point(685, 307);
            this.changeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(89, 28);
            this.changeBtn.TabIndex = 3;
            this.changeBtn.Text = "Ganti";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // payout
            // 
            this.payout.BackColor = System.Drawing.Color.DarkGray;
            this.payout.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payout.Location = new System.Drawing.Point(121, 343);
            this.payout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.payout.Name = "payout";
            this.payout.Size = new System.Drawing.Size(653, 33);
            this.payout.TabIndex = 4;
            this.payout.Text = "Tarik Saldo";
            this.payout.UseVisualStyleBackColor = false;
            this.payout.Click += new System.EventHandler(this.payout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rekening Bank";
            // 
            // payment
            // 
            this.payment.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.payment.Location = new System.Drawing.Point(121, 311);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(558, 22);
            this.payment.TabIndex = 10;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.DarkGray;
            this.refreshBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(694, 42);
            this.refreshBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(80, 28);
            this.refreshBtn.TabIndex = 11;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // balance
            // 
            this.balance.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.balance.Location = new System.Drawing.Point(189, 115);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(185, 22);
            this.balance.TabIndex = 12;
            // 
            // post
            // 
            this.post.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.post.Location = new System.Drawing.Point(189, 156);
            this.post.Name = "post";
            this.post.ReadOnly = true;
            this.post.Size = new System.Drawing.Size(185, 22);
            this.post.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Saldo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Post";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // total
            // 
            this.total.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.total.Location = new System.Drawing.Point(452, 112);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Size = new System.Drawing.Size(185, 22);
            this.total.TabIndex = 17;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greeting.Location = new System.Drawing.Point(115, 42);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(98, 32);
            this.greeting.TabIndex = 18;
            this.greeting.Text = "label5";
            this.greeting.Click += new System.EventHandler(this.label5_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.DarkGray;
            this.reportBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.Location = new System.Drawing.Point(121, 380);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(653, 33);
            this.reportBtn.TabIndex = 19;
            this.reportBtn.Text = "Laporan Penarikan";
            this.reportBtn.UseVisualStyleBackColor = false;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // showListBtn
            // 
            this.showListBtn.BackColor = System.Drawing.Color.DarkGray;
            this.showListBtn.Font = new System.Drawing.Font("Segoe UI Emoji", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showListBtn.Location = new System.Drawing.Point(121, 191);
            this.showListBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showListBtn.Name = "showListBtn";
            this.showListBtn.Size = new System.Drawing.Size(144, 28);
            this.showListBtn.TabIndex = 20;
            this.showListBtn.Text = "Lihat Unggahan";
            this.showListBtn.UseVisualStyleBackColor = false;
            this.showListBtn.Click += new System.EventHandler(this.showListBtn_Click);
            // 
            // view
            // 
            this.view.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.view.Location = new System.Drawing.Point(452, 156);
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Size = new System.Drawing.Size(185, 22);
            this.view.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Pembaca";
            // 
            // Beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(884, 502);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.view);
            this.Controls.Add(this.showListBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.post);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.payment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payout);
            this.Controls.Add(this.changeBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Beranda";
            this.Text = "UserProfile";
            this.Load += new System.EventHandler(this.Beranda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.Button payout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payment;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox post;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button showListBtn;
        private System.Windows.Forms.TextBox view;
        private System.Windows.Forms.Label label5;
    }
}