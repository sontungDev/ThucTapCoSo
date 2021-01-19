
namespace Dijkstra_v2._0._1
{
    partial class frmMain
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
            this.pnMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMoFile = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnGiaiThuat = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdinht = new System.Windows.Forms.TextBox();
            this.txtdinhs = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnMoFile);
            this.pnMenu.Controls.Add(this.btnStart);
            this.pnMenu.Controls.Add(this.lblPath);
            this.pnMenu.Controls.Add(this.btnThoat);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnMenu.Location = new System.Drawing.Point(20, 20);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Padding = new System.Windows.Forms.Padding(0, 13, 0, 0);
            this.pnMenu.Size = new System.Drawing.Size(1302, 140);
            this.pnMenu.TabIndex = 0;
            // 
            // btnMoFile
            // 
            this.btnMoFile.Location = new System.Drawing.Point(4, 17);
            this.btnMoFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(149, 49);
            this.btnMoFile.TabIndex = 0;
            this.btnMoFile.Text = "MỞ FILE";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(4, 74);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(149, 49);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "BẮT ĐẦU";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblPath
            // 
            this.lblPath.Location = new System.Drawing.Point(161, 13);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.lblPath.Size = new System.Drawing.Size(864, 58);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "CHỌN FILE CẦN ĐỌC";
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(160, 74);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 49);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt";
            this.openFileDialog1.Title = "Open File Text";
            // 
            // pnGiaiThuat
            // 
            this.pnGiaiThuat.Location = new System.Drawing.Point(20, 260);
            this.pnGiaiThuat.Margin = new System.Windows.Forms.Padding(4);
            this.pnGiaiThuat.Name = "pnGiaiThuat";
            this.pnGiaiThuat.Size = new System.Drawing.Size(1302, 390);
            this.pnGiaiThuat.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdinht);
            this.panel1.Controls.Add(this.txtdinhs);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 93);
            this.panel1.TabIndex = 2;
            // 
            // txtdinht
            // 
            this.txtdinht.Location = new System.Drawing.Point(370, 29);
            this.txtdinht.Name = "txtdinht";
            this.txtdinht.Size = new System.Drawing.Size(71, 27);
            this.txtdinht.TabIndex = 11;
            // 
            // txtdinhs
            // 
            this.txtdinhs.Location = new System.Drawing.Point(132, 29);
            this.txtdinhs.Name = "txtdinhs";
            this.txtdinhs.Size = new System.Drawing.Size(71, 27);
            this.txtdinhs.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(235, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "ĐỈNH T";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(4, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "ĐỈNH S";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1342, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnGiaiThuat);
            this.Controls.Add(this.pnMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DIJKSTRA v2.0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnMenu;
        private System.Windows.Forms.Button btnMoFile;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel pnGiaiThuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdinht;
        private System.Windows.Forms.TextBox txtdinhs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

