
    using DevExpress.XtraSplashScreen;
    using System.Drawing;
    using System.Windows.Forms;
    using System;

namespace QUANLYHOCSINH
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lblFullName = new DevExpress.XtraBars.BarStaticItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.btnDoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocSinh = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanToc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTonGiao = new DevExpress.XtraBars.BarButtonItem();
            this.btnGiaoVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnTrinhDo = new DevExpress.XtraBars.BarButtonItem();
            this.btnChucVu = new DevExpress.XtraBars.BarButtonItem();
            this.btnViPham = new DevExpress.XtraBars.BarButtonItem();
            this.btnLoaiViPham = new DevExpress.XtraBars.BarButtonItem();
            this.btnMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.btnNamHoa = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocKy = new DevExpress.XtraBars.BarButtonItem();
            this.btnKhoiLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLViPham = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLDiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnHocLuc = new DevExpress.XtraBars.BarButtonItem();
            this.btnHanhKiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLHanhKiem = new DevExpress.XtraBars.BarButtonItem();
            this.btnQLHocLuc = new DevExpress.XtraBars.BarButtonItem();
            this.btnTheoTuan = new DevExpress.XtraBars.BarButtonItem();
            this.btnTheoThang = new DevExpress.XtraBars.BarButtonItem();
            this.btnTheoNam = new DevExpress.XtraBars.BarButtonItem();
            this.btnKQLop = new DevExpress.XtraBars.BarButtonItem();
            this.btnKQMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup10 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup11 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup12 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup13 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage8 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.CaptionBarItemLinks.Add(this.lblFullName);
            this.ribbon.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(621, 640, 621, 640);
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.lblFullName,
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnBackup,
            this.btnRestore,
            this.btnThoat,
            this.skinRibbonGalleryBarItem1,
            this.btnDoiMK,
            this.btnHocSinh,
            this.btnDanToc,
            this.btnTonGiao,
            this.btnGiaoVien,
            this.btnTrinhDo,
            this.btnChucVu,
            this.btnViPham,
            this.btnLoaiViPham,
            this.btnMonHoc,
            this.btnLopHoc,
            this.btnNamHoa,
            this.btnHocKy,
            this.btnKhoiLop,
            this.btnQLViPham,
            this.btnQLDiem,
            this.btnHocLuc,
            this.btnHanhKiem,
            this.btnQLHanhKiem,
            this.btnQLHocLuc,
            this.btnTheoTuan,
            this.btnTheoThang,
            this.btnTheoNam,
            this.btnKQLop,
            this.btnKQMonHoc});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(60, 72, 60, 72);
            this.ribbon.MaxItemId = 38;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsMenuMinWidth = 6885;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage6,
            this.ribbonPage3,
            this.ribbonPage5});
            this.ribbon.Size = new System.Drawing.Size(1658, 226);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // lblFullName
            // 
            this.lblFullName.Caption = "FullName";
            this.lblFullName.Id = 37;
            this.lblFullName.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("lblFullName.ImageOptions.SvgImage")));
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btnBackup
            // 
            this.btnBackup.Caption = "Backup";
            this.btnBackup.Id = 1;
            this.btnBackup.Name = "btnBackup";
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Restore";
            this.btnRestore.Id = 2;
            this.btnRestore.Name = "btnRestore";
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.Id = 3;
            this.btnThoat.Name = "btnThoat";
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 5;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.Caption = "Đổi mật khẩu";
            this.btnDoiMK.Id = 6;
            this.btnDoiMK.Name = "btnDoiMK";
            // 
            // btnHocSinh
            // 
            this.btnHocSinh.Caption = "Học sinh";
            this.btnHocSinh.Id = 10;
            this.btnHocSinh.Name = "btnHocSinh";
            // 
            // btnDanToc
            // 
            this.btnDanToc.Caption = "Dân tộc";
            this.btnDanToc.Id = 11;
            this.btnDanToc.Name = "btnDanToc";
            // 
            // btnTonGiao
            // 
            this.btnTonGiao.Caption = "Tôn giáo";
            this.btnTonGiao.Id = 12;
            this.btnTonGiao.Name = "btnTonGiao";
            // 
            // btnGiaoVien
            // 
            this.btnGiaoVien.Caption = "Giáo viên";
            this.btnGiaoVien.Id = 13;
            this.btnGiaoVien.Name = "btnGiaoVien";
            // 
            // btnTrinhDo
            // 
            this.btnTrinhDo.Caption = "Trình độ";
            this.btnTrinhDo.Id = 14;
            this.btnTrinhDo.Name = "btnTrinhDo";
            // 
            // btnChucVu
            // 
            this.btnChucVu.Caption = "Chức vụ";
            this.btnChucVu.Id = 15;
            this.btnChucVu.Name = "btnChucVu";
            // 
            // btnViPham
            // 
            this.btnViPham.Caption = "Vi phạm";
            this.btnViPham.Id = 16;
            this.btnViPham.Name = "btnViPham";
            // 
            // btnLoaiViPham
            // 
            this.btnLoaiViPham.Caption = "Loại vi phạm";
            this.btnLoaiViPham.Id = 17;
            this.btnLoaiViPham.Name = "btnLoaiViPham";
            // 
            // btnMonHoc
            // 
            this.btnMonHoc.Caption = "Môn học";
            this.btnMonHoc.Id = 18;
            this.btnMonHoc.Name = "btnMonHoc";
            this.btnMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMonHoc_ItemClick);
            // 
            // btnLopHoc
            // 
            this.btnLopHoc.Caption = "Lớp học";
            this.btnLopHoc.Enabled = false;
            this.btnLopHoc.Id = 19;
            this.btnLopHoc.Name = "btnLopHoc";
            // 
            // btnNamHoa
            // 
            this.btnNamHoa.Caption = "Năm học";
            this.btnNamHoa.Id = 20;
            this.btnNamHoa.Name = "btnNamHoa";
            // 
            // btnHocKy
            // 
            this.btnHocKy.Caption = "Học kỳ";
            this.btnHocKy.Id = 22;
            this.btnHocKy.Name = "btnHocKy";
            // 
            // btnKhoiLop
            // 
            this.btnKhoiLop.Caption = "Khối lớp";
            this.btnKhoiLop.Id = 23;
            this.btnKhoiLop.Name = "btnKhoiLop";
            // 
            // btnQLViPham
            // 
            this.btnQLViPham.Caption = "Quản lý vi phạm";
            this.btnQLViPham.Id = 24;
            this.btnQLViPham.Name = "btnQLViPham";
            // 
            // btnQLDiem
            // 
            this.btnQLDiem.Caption = "Quản lý điểm";
            this.btnQLDiem.Id = 25;
            this.btnQLDiem.Name = "btnQLDiem";
            // 
            // btnHocLuc
            // 
            this.btnHocLuc.Caption = "Học lực";
            this.btnHocLuc.Id = 28;
            this.btnHocLuc.Name = "btnHocLuc";
            // 
            // btnHanhKiem
            // 
            this.btnHanhKiem.Caption = "Hạnh kiểm";
            this.btnHanhKiem.Id = 29;
            this.btnHanhKiem.Name = "btnHanhKiem";
            // 
            // btnQLHanhKiem
            // 
            this.btnQLHanhKiem.Caption = "Quản lý hạnh kiểm";
            this.btnQLHanhKiem.Id = 30;
            this.btnQLHanhKiem.Name = "btnQLHanhKiem";
            // 
            // btnQLHocLuc
            // 
            this.btnQLHocLuc.Caption = "Quản lý học lực";
            this.btnQLHocLuc.Id = 31;
            this.btnQLHocLuc.Name = "btnQLHocLuc";
            // 
            // btnTheoTuan
            // 
            this.btnTheoTuan.Caption = "Theo tuần";
            this.btnTheoTuan.Id = 32;
            this.btnTheoTuan.Name = "btnTheoTuan";
            // 
            // btnTheoThang
            // 
            this.btnTheoThang.Caption = "Theo tháng";
            this.btnTheoThang.Id = 33;
            this.btnTheoThang.Name = "btnTheoThang";
            // 
            // btnTheoNam
            // 
            this.btnTheoNam.Caption = "Theo năm";
            this.btnTheoNam.Id = 34;
            this.btnTheoNam.Name = "btnTheoNam";
            // 
            // btnKQLop
            // 
            this.btnKQLop.Caption = "Kết quả theo lớp";
            this.btnKQLop.Id = 35;
            this.btnKQLop.Name = "btnKQLop";
            // 
            // btnKQMonHoc
            // 
            this.btnKQMonHoc.Caption = "Kết quả theo môn học";
            this.btnKQMonHoc.Id = 36;
            this.btnKQMonHoc.Name = "btnKQMonHoc";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDoiMK);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBackup, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnRestore, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnThoat, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.skinRibbonGalleryBarItem1, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8,
            this.ribbonPageGroup9,
            this.ribbonPageGroup10,
            this.ribbonPageGroup11});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Danh mục";
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.ItemLinks.Add(this.btnHocSinh);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnDanToc, true);
            this.ribbonPageGroup8.ItemLinks.Add(this.btnTonGiao, true);
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            this.ribbonPageGroup8.Text = "Học sinh";
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.ItemLinks.Add(this.btnGiaoVien);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnTrinhDo, true);
            this.ribbonPageGroup9.ItemLinks.Add(this.btnChucVu, true);
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            this.ribbonPageGroup9.Text = "Giáo viên";
            // 
            // ribbonPageGroup10
            // 
            this.ribbonPageGroup10.ItemLinks.Add(this.btnViPham);
            this.ribbonPageGroup10.ItemLinks.Add(this.btnLoaiViPham, true);
            this.ribbonPageGroup10.Name = "ribbonPageGroup10";
            this.ribbonPageGroup10.Text = "Vi phạm";
            // 
            // ribbonPageGroup11
            // 
            this.ribbonPageGroup11.ItemLinks.Add(this.btnMonHoc);
            this.ribbonPageGroup11.ItemLinks.Add(this.btnNamHoa, true);
            this.ribbonPageGroup11.ItemLinks.Add(this.btnHocKy, true);
            this.ribbonPageGroup11.ItemLinks.Add(this.btnLopHoc, true);
            this.ribbonPageGroup11.ItemLinks.Add(this.btnKhoiLop, true);
            this.ribbonPageGroup11.ItemLinks.Add(this.btnHocLuc);
            this.ribbonPageGroup11.ItemLinks.Add(this.btnHanhKiem);
            this.ribbonPageGroup11.Name = "ribbonPageGroup11";
            this.ribbonPageGroup11.Text = "Chung";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup4});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Chức năng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLDiem, true);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnQLHocLuc, true);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lý điểm";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnQLViPham);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnQLHanhKiem, true);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Quản lý thi đua";
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup12,
            this.ribbonPageGroup13});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Thống kê";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTheoTuan);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTheoThang, true);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTheoNam, true);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Thi đua";
            // 
            // ribbonPageGroup12
            // 
            this.ribbonPageGroup12.ItemLinks.Add(this.btnKQLop);
            this.ribbonPageGroup12.ItemLinks.Add(this.btnKQMonHoc);
            this.ribbonPageGroup12.Name = "ribbonPageGroup12";
            this.ribbonPageGroup12.Text = "Học tập";
            // 
            // ribbonPageGroup13
            // 
            this.ribbonPageGroup13.Name = "ribbonPageGroup13";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 753);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(60, 72, 60, 72);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1658, 42);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Danh mục";
            // 
            // ribbonPage8
            // 
            this.ribbonPage8.Name = "ribbonPage8";
            this.ribbonPage8.Text = "ribbonPage8";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1658, 795);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnThoat;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.BarButtonItem btnDoiMK;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnHocSinh;
        private DevExpress.XtraBars.BarButtonItem btnDanToc;
        private DevExpress.XtraBars.BarButtonItem btnTonGiao;
        private DevExpress.XtraBars.BarButtonItem btnGiaoVien;
        private DevExpress.XtraBars.BarButtonItem btnTrinhDo;
        private DevExpress.XtraBars.BarButtonItem btnChucVu;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnViPham;
        private DevExpress.XtraBars.BarButtonItem btnLoaiViPham;
        private DevExpress.XtraBars.BarButtonItem btnMonHoc;
        private DevExpress.XtraBars.BarButtonItem btnLopHoc;
        private DevExpress.XtraBars.BarButtonItem btnNamHoa;
        private DevExpress.XtraBars.BarButtonItem btnHocKy;
        private DevExpress.XtraBars.BarButtonItem btnKhoiLop;
        private DevExpress.XtraBars.BarButtonItem btnQLViPham;
        private DevExpress.XtraBars.BarButtonItem btnQLDiem;
        private DevExpress.XtraBars.BarButtonItem btnHocLuc;
        private DevExpress.XtraBars.BarButtonItem btnHanhKiem;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup10;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup11;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage8;
        private DevExpress.XtraBars.BarButtonItem btnQLHanhKiem;
        private DevExpress.XtraBars.BarButtonItem btnQLHocLuc;
        private DevExpress.XtraBars.BarButtonItem btnTheoTuan;
        private DevExpress.XtraBars.BarButtonItem btnTheoThang;
        private DevExpress.XtraBars.BarButtonItem btnTheoNam;
        private DevExpress.XtraBars.BarButtonItem btnKQLop;
        private DevExpress.XtraBars.BarButtonItem btnKQMonHoc;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup12;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup13;
        public DevExpress.XtraBars.BarStaticItem lblFullName;
    }
}
