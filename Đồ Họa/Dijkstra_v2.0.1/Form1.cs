using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Dijkstra_v2._0._1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        /* ------------------------  BIẾN  ------------------------------*/
        string path = "";
        const int VC = 1000000;
        int _sodinh, _socanh, _s, _t, _i, _min;
        int[] _nhan, _kc, _xet;
        List<string[]> _dscanh;
        int[,] _mt;
        int[] _kq;
        FlowLayoutPanel flowLayout = new FlowLayoutPanel();

        /*--------------------------- SỰ KIỆN -----------------------*/
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mess = "BẠN CHẮC CHẮN MUỐN THOÁT ỨNG DỤNG";
            var result = MessageBox.Show(mess, "THOÁT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (path == "")
                MessageBox.Show("BẠN CHƯA CHỌN DỮ LIỆU FILE");
            else
            {
                if(txtdinhs.Text != "" && txtdinht.Text != "")
                {
                    try
                    {
                        _s = int.Parse(txtdinhs.Text);
                        _t = int.Parse(txtdinht.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi nhập đỉnh");
                    }
                    
                }    
                ThucThi();
                MoDoThi();
            }    
                
        }
        private void btnMoFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                lblPath.Text = path;
                DocFile();
            }
        }

        /* ------------------------  ĐỌC FILE ---------------------------*/
        void DocFile()
        {
            string[] lines;
            string[] arr;
            if (File.Exists(path))
            {
                _dscanh = new List<string[]>();
                lines = File.ReadAllLines(path);
                arr = lines[0].Split();
                _sodinh = int.Parse(arr[0]);
                _socanh = int.Parse(arr[1]);
                _s = int.Parse(arr[2]);
                _t = int.Parse(arr[3]);

                _nhan = new int[_sodinh + 1];
                _kc = new int[_sodinh + 1];
                _xet = new int[_sodinh + 1];
                _mt = new int[_sodinh + 1, _sodinh + 1];

                for (byte y = 1; y <= _sodinh; y++)
                    for (byte z = 1; z <= _sodinh; z++)
                        _mt[y, z] = VC;

                for (byte y = 1; y <= _socanh; y++)
                {
                    arr = lines[y].Split();
                    _dscanh.Add(arr);
                    int d1 = int.Parse(arr[0]);
                    int d2 = int.Parse(arr[1]);
                    int ts = int.Parse(arr[2]);
                    _mt[d1, d2] = ts;
                    _mt[d2, d1] = ts;
                }
            }
        }

        void TaoLabel(int width, int height,int x, int y, string text)
        {
            Label lbltam = new Label();
            lbltam.AutoSize = false;
            lbltam.Width = width;
            lbltam.Height = height;
            lbltam.TextAlign = ContentAlignment.MiddleCenter;
            Point toado  = new Point(x, y);
            lbltam.Location = toado;
            lbltam.Text = text;
            pnGiaiThuat.Controls.Add(lbltam);
        }

        void ThucThi()
        {
            pnGiaiThuat.Controls.Clear();
            Button btnGoc = new Button();
            btnGoc.AutoSize = true;
            btnGoc.Font = this.Font;
            btnGoc.Text = "Bước / Đỉnh";
            Point local = new Point(20, 20);
            btnGoc.Location = local;
            pnGiaiThuat.Controls.Add(btnGoc);

            int X = btnGoc.Location.X;
            int Y = btnGoc.Location.Y;
            int width = btnGoc.Width;
            int height = btnGoc.Height;
            string tt = "";
            int sodinhchon = 0;

            TaoLabel(width, height, X, Y + height, "Bước 1");
            TaoLabel(width, height, X + width * (_sodinh + 1), Y, "CHỌN");

            for (byte y = 1; y <= _sodinh; y++)
            {
                _kc[y] = _mt[_s, y];
                _nhan[y] = _s;
                _xet[y] = 0;
                if (y == 1) tt = "0";
                else if (_kc[y] == VC)
                    tt = "*";
                else
                    tt = _kc[y] + "";
                TaoLabel(width, height, X + width * y, Y, y + "");
                TaoLabel(width, height, X + width * y, Y + height, "[" + _s + "," + tt + "]");
            }

            _nhan[_s] = 0;
            _kc[_s] = 0;
            _xet[_s] = 1;
            while (_xet[_t] == 0)
            {
                _min = VC;
                for (byte y = 1; y <= _sodinh; y++)
                {
                    if (_xet[y] == 0 && _min > _kc[y])
                    {
                        _i = y;
                        _min = _kc[y];
                    }
                }
                _xet[_i] = 1;
                TaoLabel(width, height, X + width * (_sodinh + 1), Y + height * (sodinhchon + 1), _i + "");
                if (_xet[_t] == 0)
                {
                    // in ra số bước
                    TaoLabel(width, height, X, Y + height * (sodinhchon + 2), "Bước " + (sodinhchon + 2));
                    for (byte y = 1; y <= _sodinh; y++)
                    {
                        if (_xet[y] == 0 && (_kc[_i] + _mt[_i, y] < _kc[y]))
                        {
                            _kc[y] = _kc[_i] + _mt[_i, y];
                            _nhan[y] = _i;
                        }
                        if (_xet[y] == 0)
                        {
                            if (_kc[y] == VC)
                                tt = "*";
                            else tt = _kc[y] + "";
                            TaoLabel(width, height, X + width * y, Y + height * (sodinhchon + 2),
                                "[" + _nhan[y] + "," + tt + "]");
                        }
                        else
                        {
                            TaoLabel(width, height, X + width * y, Y + height * (sodinhchon + 2), "-");
                        }
                    }
                }
                sodinhchon++;
            }
            _kq = new int[_sodinh];
            int dem = 0;
            while (_i != _s)
            {
                _kq[dem] = _i;
                _i = _nhan[_i];
                dem++;
            }
            _kq[dem] = _s;
            // dán kết quả

            flowLayout.FlowDirection = FlowDirection.LeftToRight;
            flowLayout.Dock = DockStyle.Bottom;
            flowLayout.WrapContents = true;
            flowLayout.Controls.Clear();
            Button lbl_title = new Button();
            /*Button lbl_dinhchon = new Button();
            lbl_dinhchon.Text = "ĐƯỜNG ĐI NGẮN NHÂST TỪ " + _s + " ĐẾN ĐIÊM " + _t;
            lbl_dinhchon.TextAlign = ContentAlignment.MiddleCenter;*/

            lbl_title.Text = "KẾT QUẢ SAU KHI THỰC HIỆN THUẬT TOÁN";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            lbl_title.AutoSize = false;
            lbl_title.Width = pnGiaiThuat.Width;
            flowLayout.Controls.Add(lbl_title);

            for (int i = dem; i >= 0 ; i--)
            {               
                Button lbl_dinh = new Button();
                lbl_dinh.Text = _kq[i] + "";
                flowLayout.Controls.Add(lbl_dinh);
                if(i != 0)
                {
                    Button lbl_arrow = new Button();
                    lbl_arrow.Text = "-->";
                    flowLayout.Controls.Add(lbl_arrow);
                }
                else
                {
                    Button lbl_kc = new Button();
                    lbl_kc.AutoSize = false;
                    lbl_kc.Text = "Chi Phí : " + _kc[_t];
                    lbl_kc.Size = new Size(lbl_kc.Text.Length * 10 , lbl_dinh.Height);
                    flowLayout.Controls.Add(lbl_kc);
                }    
            }
            this.Controls.Add(flowLayout);          
        }

        void MoDoThi()
        {
            DoThi f2 = new DoThi();
            f2.DuLieu(_dscanh, _kq, _sodinh, _s, _t, _kc, _mt);
            f2.ShowDialog();
        }
        
        
    }
}
