using DataAccessLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QUANLYHOCSINH
{
    public partial class frmMonHoc : DevExpress.XtraEditors.XtraForm
    {
        public frmMonHoc()
        {
            InitializeComponent();
        }
       
        void _showHide(bool kt)
        {
            btnLuu.Enabled = !kt;
            btnHuy.Enabled = !kt;
            btnThem.Enabled = !kt;
            btnSua.Enabled = !kt;
            btnXoa.Enabled = !kt;
            btnDong.Enabled = !kt;
            btnIn.Enabled = !kt;
            txtTenMH.Enabled = !kt;
            spinSoTiet.Enabled = !kt;
        }
        void SaveData()
        {
            if (_them)
            {
                MonHoc mh = new MonHoc();
                mh.TENMH = txtTenMH.Text;
                mh.SOTIET = int.Parse(spinSoTiet.Text);
                mh.HESO = int.Parse(spinHeSo.Text);

            }
        }
        private void frmMonHoc_Load(object sender, EventArgs e)
        {
            _showHide(false);
        }

        private void btnDong_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(false);
        }

        private void btnHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _showHide(true);
        }
        private void btnThem_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {    

        }
    }
}