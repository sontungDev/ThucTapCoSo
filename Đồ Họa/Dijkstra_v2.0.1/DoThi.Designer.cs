
namespace Dijkstra_v2._0._1
{
    partial class DoThi
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
            this.pnBangVe = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnBangVe
            // 
            this.pnBangVe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBangVe.Location = new System.Drawing.Point(0, 0);
            this.pnBangVe.Name = "pnBangVe";
            this.pnBangVe.Size = new System.Drawing.Size(882, 453);
            this.pnBangVe.TabIndex = 0;
            this.pnBangVe.SizeChanged += new System.EventHandler(this.pnBangVe_SizeChanged);
            this.pnBangVe.Paint += new System.Windows.Forms.PaintEventHandler(this.pnBangVe_Paint);
            // 
            // DoThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.pnBangVe);
            this.Name = "DoThi";
            this.Text = "DoThi";
            this.Load += new System.EventHandler(this.DoThi_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DoThi_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DoThi_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnBangVe;
    }
}