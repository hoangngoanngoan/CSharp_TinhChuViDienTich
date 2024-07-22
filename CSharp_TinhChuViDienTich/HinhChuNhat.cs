using System.Diagnostics.Eventing.Reader;

namespace CSharp_TinhChuViDienTich
{
    public partial class HinhChuNhat : Form
    {
        private double dai;
        private double rong;

        public HinhChuNhat()
        {
            InitializeComponent();
        }

        private bool GetInfo()
        {
            try
            {
                dai = Convert.ToDouble(txtDai.Text);
                rong = Convert.ToDouble(txtRong.Text);
                return true;
            }
            catch { 
                return false;
            }
        }
        
        private void ThongBao()
        {
            MessageBox.Show("Phải nhập số", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private double TinhCV()
        {   
               GetInfo();
            return (dai + rong) * 2;
        }

        private double TinhDT()
        {
            GetInfo();
            return dai * rong;
        }

        private void butTinh_Click(object sender, EventArgs e)
        {
            if (GetInfo()) labKQ.Text = "- Chu vi: " + TinhCV() + Environment.NewLine + "- Diện tích: " + TinhDT();
            else ThongBao();
        }

        private void butTinhChuVi_Click(object sender, EventArgs e)
        {
            if(GetInfo()) labKQ.Text = "- Chu vi: " + TinhCV();
            else
        }


        private void butTinhDienTich_Click_1(object sender, EventArgs e)
        {
            GetInfo();
            labKQ.Text = "- Diện tích: " + TinhDT();
        }

        private void butThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
