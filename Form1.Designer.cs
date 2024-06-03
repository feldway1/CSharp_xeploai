namespace CSharp_xeploai
{
    partial class Form1
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
            this.lblten = new System.Windows.Forms.Label();
            this.txtten = new System.Windows.Forms.TextBox();
            this.lbltoan = new System.Windows.Forms.Label();
            this.txttoan = new System.Windows.Forms.TextBox();
            this.lblvan = new System.Windows.Forms.Label();
            this.txtvan = new System.Windows.Forms.TextBox();
            this.lblTB = new System.Windows.Forms.Label();
            this.lblxeploai = new System.Windows.Forms.Label();
            this.lblloai = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtTB = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lbltinhdiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.Location = new System.Drawing.Point(114, 67);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(36, 19);
            this.lblten.TabIndex = 0;
            this.lblten.Text = "Tên";
            this.lblten.Click += new System.EventHandler(this.lblten_Click);
            // 
            // txtten
            // 
            this.txtten.Location = new System.Drawing.Point(296, 69);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 20);
            this.txtten.TabIndex = 1;
            this.txtten.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbltoan
            // 
            this.lbltoan.AutoSize = true;
            this.lbltoan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltoan.Location = new System.Drawing.Point(114, 109);
            this.lbltoan.Name = "lbltoan";
            this.lbltoan.Size = new System.Drawing.Size(45, 19);
            this.lbltoan.TabIndex = 0;
            this.lbltoan.Text = "Toán";
            this.lbltoan.Click += new System.EventHandler(this.lbltoan_Click);
            // 
            // txttoan
            // 
            this.txttoan.Location = new System.Drawing.Point(296, 111);
            this.txttoan.Name = "txttoan";
            this.txttoan.Size = new System.Drawing.Size(100, 20);
            this.txttoan.TabIndex = 1;
            this.txttoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblvan
            // 
            this.lblvan.AutoSize = true;
            this.lblvan.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvan.Location = new System.Drawing.Point(114, 156);
            this.lblvan.Name = "lblvan";
            this.lblvan.Size = new System.Drawing.Size(36, 19);
            this.lblvan.TabIndex = 0;
            this.lblvan.Text = "Văn";
            this.lblvan.Click += new System.EventHandler(this.lblvan_Click);
            // 
            // txtvan
            // 
            this.txtvan.Location = new System.Drawing.Point(296, 158);
            this.txtvan.Name = "txtvan";
            this.txtvan.Size = new System.Drawing.Size(100, 20);
            this.txtvan.TabIndex = 1;
            this.txtvan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTB
            // 
            this.lblTB.AutoSize = true;
            this.lblTB.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTB.Location = new System.Drawing.Point(114, 201);
            this.lblTB.Name = "lblTB";
            this.lblTB.Size = new System.Drawing.Size(88, 19);
            this.lblTB.TabIndex = 0;
            this.lblTB.Text = "Trung Bình";
            this.lblTB.Click += new System.EventHandler(this.lblTB_Click);
            // 
            // lblxeploai
            // 
            this.lblxeploai.AutoSize = true;
            this.lblxeploai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxeploai.Location = new System.Drawing.Point(114, 247);
            this.lblxeploai.Name = "lblxeploai";
            this.lblxeploai.Size = new System.Drawing.Size(69, 19);
            this.lblxeploai.TabIndex = 0;
            this.lblxeploai.Text = "Xếp Loại";
            this.lblxeploai.Click += new System.EventHandler(this.lblxeploai_Click);
            // 
            // lblloai
            // 
            this.lblloai.AutoSize = true;
            this.lblloai.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloai.Location = new System.Drawing.Point(311, 247);
            this.lblloai.Name = "lblloai";
            this.lblloai.Size = new System.Drawing.Size(38, 19);
            this.lblloai.TabIndex = 0;
            this.lblloai.Text = "Loại";
            this.lblloai.Click += new System.EventHandler(this.lblloai_Click);
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(296, 310);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 2;
            this.btntinh.Text = "Tính";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtTB
            // 
            this.txtTB.Location = new System.Drawing.Point(296, 203);
            this.txtTB.Name = "txtTB";
            this.txtTB.Size = new System.Drawing.Size(100, 20);
            this.txtTB.TabIndex = 1;
            this.txtTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(252, 375);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lbltinhdiem
            // 
            this.lbltinhdiem.AutoSize = true;
            this.lbltinhdiem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltinhdiem.Location = new System.Drawing.Point(311, 34);
            this.lbltinhdiem.Name = "lbltinhdiem";
            this.lbltinhdiem.Size = new System.Drawing.Size(83, 19);
            this.lbltinhdiem.TabIndex = 0;
            this.lbltinhdiem.Text = "Tính Điểm";
            this.lbltinhdiem.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(616, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.txtTB);
            this.Controls.Add(this.txtvan);
            this.Controls.Add(this.txttoan);
            this.Controls.Add(this.txtten);
            this.Controls.Add(this.lblloai);
            this.Controls.Add(this.lblxeploai);
            this.Controls.Add(this.lblTB);
            this.Controls.Add(this.lblvan);
            this.Controls.Add(this.lbltoan);
            this.Controls.Add(this.lbltinhdiem);
            this.Controls.Add(this.lblten);
            this.Name = "Form1";
            this.Text = "Xếp Loại";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.Label lbltoan;
        private System.Windows.Forms.TextBox txttoan;
        private System.Windows.Forms.Label lblvan;
        private System.Windows.Forms.TextBox txtvan;
        private System.Windows.Forms.Label lblTB;
        private System.Windows.Forms.Label lblxeploai;
        private System.Windows.Forms.Label lblloai;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtTB;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label lbltinhdiem;
    }
}

