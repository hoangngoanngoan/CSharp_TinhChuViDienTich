namespace CSharp_TinhChuViDienTich
{
    partial class HinhChuNhat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labKQ = new Label();
            butTinhChuVi = new Button();
            butTinh = new Button();
            butTinhDienTich = new Button();
            butThoat = new Button();
            txtDai = new TextBox();
            txtRong = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 25F, FontStyle.Bold);
            label1.Location = new Point(24, 25);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(691, 41);
            label1.TabIndex = 0;
            label1.Text = "ỨNG DỤNG TÍNH CHU VI VÀ DIỆN TÍCH";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 122);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Chiều dài";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 182);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 28);
            label3.TabIndex = 2;
            label3.Text = "Chiều rộng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 241);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(91, 28);
            label4.TabIndex = 3;
            label4.Text = "Kết quả";
            // 
            // labKQ
            // 
            labKQ.AutoSize = true;
            labKQ.Location = new Point(304, 241);
            labKQ.Margin = new Padding(5, 0, 5, 0);
            labKQ.Name = "labKQ";
            labKQ.Size = new Size(0, 28);
            labKQ.TabIndex = 4;
            // 
            // butTinhChuVi
            // 
            butTinhChuVi.Location = new Point(24, 372);
            butTinhChuVi.Margin = new Padding(5, 4, 5, 4);
            butTinhChuVi.Name = "butTinhChuVi";
            butTinhChuVi.Size = new Size(248, 66);
            butTinhChuVi.TabIndex = 6;
            butTinhChuVi.Text = "Tính Chu Vi";
            butTinhChuVi.UseVisualStyleBackColor = true;
            butTinhChuVi.Click += butTinhChuVi_Click;
            // 
            // butTinh
            // 
            butTinh.Font = new Font("Tahoma", 17F);
            butTinh.Location = new Point(24, 301);
            butTinh.Margin = new Padding(5, 4, 5, 4);
            butTinh.Name = "butTinh";
            butTinh.Size = new Size(154, 63);
            butTinh.TabIndex = 5;
            butTinh.Text = "Tính";
            butTinh.UseVisualStyleBackColor = true;
            butTinh.Click += butTinh_Click;
            // 
            // butTinhDienTich
            // 
            butTinhDienTich.Location = new Point(304, 372);
            butTinhDienTich.Margin = new Padding(5, 4, 5, 4);
            butTinhDienTich.Name = "butTinhDienTich";
            butTinhDienTich.Size = new Size(249, 66);
            butTinhDienTich.TabIndex = 7;
            butTinhDienTich.Text = "Tính Diện Tích";
            butTinhDienTich.UseVisualStyleBackColor = true;
            butTinhDienTich.Click += butTinhDienTich_Click_1;
            // 
            // butThoat
            // 
            butThoat.Location = new Point(586, 372);
            butThoat.Margin = new Padding(5, 4, 5, 4);
            butThoat.Name = "butThoat";
            butThoat.Size = new Size(184, 66);
            butThoat.TabIndex = 8;
            butThoat.Text = "Thoát";
            butThoat.UseVisualStyleBackColor = true;
            butThoat.Click += butThoat_Click;
            // 
            // txtDai
            // 
            txtDai.Location = new Point(304, 122);
            txtDai.Margin = new Padding(5, 4, 5, 4);
            txtDai.Name = "txtDai";
            txtDai.Size = new Size(466, 35);
            txtDai.TabIndex = 9;
            // 
            // txtRong
            // 
            txtRong.Location = new Point(304, 175);
            txtRong.Margin = new Padding(5, 4, 5, 4);
            txtRong.Name = "txtRong";
            txtRong.Size = new Size(466, 35);
            txtRong.TabIndex = 9;
            // 
            // HinhChuNhat
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 500);
            Controls.Add(txtRong);
            Controls.Add(txtDai);
            Controls.Add(butThoat);
            Controls.Add(butTinhDienTich);
            Controls.Add(butTinhChuVi);
            Controls.Add(butTinh);
            Controls.Add(labKQ);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 17F);
            Margin = new Padding(6, 7, 6, 7);
            Name = "HinhChuNhat";
            Text = "CSharp_TinhChuViDienTich";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labKQ;
        private Button butTinh;
        private Button butTinhChuVi;
        private Button butTinhDienTich;
        private Button butThoat;
        private TextBox txtDai;
        private TextBox txtRong;
    }
}
