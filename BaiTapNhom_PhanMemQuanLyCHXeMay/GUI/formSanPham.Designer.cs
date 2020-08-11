namespace GUI
{
	partial class formSanPham
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
            this.groupTimKiem = new System.Windows.Forms.GroupBox();
            this.btnXoaTimKiem = new System.Windows.Forms.Button();
            this.lblLoaiSP = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cboTimKiem = new System.Windows.Forms.ComboBox();
            this.lblTimKiemSP = new System.Windows.Forms.Label();
            this.btnTKSanPham = new System.Windows.Forms.Button();
            this.dataGridViewSanPham = new System.Windows.Forms.DataGridView();
            this.groupThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.cboSapXepSP = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupThongTInSP = new System.Windows.Forms.GroupBox();
            this.cboNSX = new System.Windows.Forms.ComboBox();
            this.cboMaLoai = new System.Windows.Forms.ComboBox();
            this.lblBaoHanh = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.txtBaoHanh = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaSanPham = new System.Windows.Forms.TextBox();
            this.lblXuatXu = new System.Windows.Forms.Label();
            this.lblMaNCC = new System.Windows.Forms.Label();
            this.lblMoTa = new System.Windows.Forms.Label();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblNSX = new System.Windows.Forms.Label();
            this.lblMaSP = new System.Windows.Forms.Label();
            this.lblSoLuongKho = new System.Windows.Forms.Label();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.panel_title_SP = new System.Windows.Forms.Panel();
            this.lblBanHang = new System.Windows.Forms.Label();
            this.groupTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).BeginInit();
            this.groupThaoTac.SuspendLayout();
            this.groupThongTInSP.SuspendLayout();
            this.panel_title_SP.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupTimKiem
            // 
            this.groupTimKiem.Controls.Add(this.btnXoaTimKiem);
            this.groupTimKiem.Controls.Add(this.lblLoaiSP);
            this.groupTimKiem.Controls.Add(this.txtTimKiem);
            this.groupTimKiem.Controls.Add(this.cboTimKiem);
            this.groupTimKiem.Controls.Add(this.lblTimKiemSP);
            this.groupTimKiem.Controls.Add(this.btnTKSanPham);
            this.groupTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTimKiem.Location = new System.Drawing.Point(861, 68);
            this.groupTimKiem.Name = "groupTimKiem";
            this.groupTimKiem.Size = new System.Drawing.Size(690, 129);
            this.groupTimKiem.TabIndex = 25;
            this.groupTimKiem.TabStop = false;
            this.groupTimKiem.Text = "Tìm kiếm";
            // 
            // btnXoaTimKiem
            // 
            this.btnXoaTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTimKiem.Location = new System.Drawing.Point(503, 77);
            this.btnXoaTimKiem.Name = "btnXoaTimKiem";
            this.btnXoaTimKiem.Size = new System.Drawing.Size(168, 33);
            this.btnXoaTimKiem.TabIndex = 8;
            this.btnXoaTimKiem.Text = "BỎ TÌM KIẾM";
            this.btnXoaTimKiem.UseVisualStyleBackColor = true;
            this.btnXoaTimKiem.Click += new System.EventHandler(this.btnXoaBoLoc_Click);
            // 
            // lblLoaiSP
            // 
            this.lblLoaiSP.AutoSize = true;
            this.lblLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiSP.Location = new System.Drawing.Point(10, 84);
            this.lblLoaiSP.Name = "lblLoaiSP";
            this.lblLoaiSP.Size = new System.Drawing.Size(139, 20);
            this.lblLoaiSP.TabIndex = 7;
            this.lblLoaiSP.Text = "TÌM KIẾM THEO:";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(283, 26);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(182, 35);
            this.txtTimKiem.TabIndex = 1;
            // 
            // cboTimKiem
            // 
            this.cboTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTimKiem.FormattingEnabled = true;
            this.cboTimKiem.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm"});
            this.cboTimKiem.Location = new System.Drawing.Point(283, 77);
            this.cboTimKiem.Name = "cboTimKiem";
            this.cboTimKiem.Size = new System.Drawing.Size(182, 28);
            this.cboTimKiem.TabIndex = 3;
            // 
            // lblTimKiemSP
            // 
            this.lblTimKiemSP.AutoSize = true;
            this.lblTimKiemSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimKiemSP.Location = new System.Drawing.Point(8, 29);
            this.lblTimKiemSP.Name = "lblTimKiemSP";
            this.lblTimKiemSP.Size = new System.Drawing.Size(185, 20);
            this.lblTimKiemSP.TabIndex = 2;
            this.lblTimKiemSP.Text = "TÌM KIẾM SẢN PHẨM: ";
            // 
            // btnTKSanPham
            // 
            this.btnTKSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTKSanPham.Location = new System.Drawing.Point(503, 26);
            this.btnTKSanPham.Name = "btnTKSanPham";
            this.btnTKSanPham.Size = new System.Drawing.Size(168, 35);
            this.btnTKSanPham.TabIndex = 0;
            this.btnTKSanPham.Text = "TÌM KIẾM";
            this.btnTKSanPham.UseVisualStyleBackColor = true;
            this.btnTKSanPham.Click += new System.EventHandler(this.btnTKSanPham_Click);
            // 
            // dataGridViewSanPham
            // 
            this.dataGridViewSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSanPham.Location = new System.Drawing.Point(30, 384);
            this.dataGridViewSanPham.Name = "dataGridViewSanPham";
            this.dataGridViewSanPham.RowHeadersWidth = 51;
            this.dataGridViewSanPham.RowTemplate.Height = 24;
            this.dataGridViewSanPham.Size = new System.Drawing.Size(1506, 425);
            this.dataGridViewSanPham.TabIndex = 24;
            this.dataGridViewSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSanPham_CellClick);
            // 
            // groupThaoTac
            // 
            this.groupThaoTac.Controls.Add(this.btnThem);
            this.groupThaoTac.Controls.Add(this.cboSapXepSP);
            this.groupThaoTac.Controls.Add(this.label1);
            this.groupThaoTac.Controls.Add(this.btnXoa);
            this.groupThaoTac.Controls.Add(this.btnSua);
            this.groupThaoTac.Controls.Add(this.btnLuu);
            this.groupThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThaoTac.Location = new System.Drawing.Point(861, 203);
            this.groupThaoTac.Name = "groupThaoTac";
            this.groupThaoTac.Size = new System.Drawing.Size(690, 175);
            this.groupThaoTac.TabIndex = 27;
            this.groupThaoTac.TabStop = false;
            this.groupThaoTac.Text = "Thao tác";
            this.groupThaoTac.Enter += new System.EventHandler(this.groupThaoTac_Enter);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(14, 34);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(115, 65);
            this.btnThem.TabIndex = 32;
            this.btnThem.Text = "THÊM";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // cboSapXepSP
            // 
            this.cboSapXepSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSapXepSP.FormattingEnabled = true;
            this.cboSapXepSP.Items.AddRange(new object[] {
            "Giá tăng dần",
            "Giá giảm dần",
            "Số lượng tăng dần",
            "Số lượng giảm dần",
            "Loại sản phẩm"});
            this.cboSapXepSP.Location = new System.Drawing.Point(428, 141);
            this.cboSapXepSP.Name = "cboSapXepSP";
            this.cboSapXepSP.Size = new System.Drawing.Size(192, 28);
            this.cboSapXepSP.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Sắp xếp theo: ";
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(308, 34);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(111, 65);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(164, 34);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 65);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "SỬA";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(452, 34);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(111, 65);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupThongTInSP
            // 
            this.groupThongTInSP.Controls.Add(this.cboNSX);
            this.groupThongTInSP.Controls.Add(this.cboMaLoai);
            this.groupThongTInSP.Controls.Add(this.lblBaoHanh);
            this.groupThongTInSP.Controls.Add(this.cboNCC);
            this.groupThongTInSP.Controls.Add(this.txtBaoHanh);
            this.groupThongTInSP.Controls.Add(this.txtSoLuong);
            this.groupThongTInSP.Controls.Add(this.txtTenSanPham);
            this.groupThongTInSP.Controls.Add(this.txtMota);
            this.groupThongTInSP.Controls.Add(this.txtDonGia);
            this.groupThongTInSP.Controls.Add(this.txtMaSanPham);
            this.groupThongTInSP.Controls.Add(this.lblXuatXu);
            this.groupThongTInSP.Controls.Add(this.lblMaNCC);
            this.groupThongTInSP.Controls.Add(this.lblMoTa);
            this.groupThongTInSP.Controls.Add(this.lblTenSP);
            this.groupThongTInSP.Controls.Add(this.lblNSX);
            this.groupThongTInSP.Controls.Add(this.lblMaSP);
            this.groupThongTInSP.Controls.Add(this.lblSoLuongKho);
            this.groupThongTInSP.Controls.Add(this.lblDonGia);
            this.groupThongTInSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupThongTInSP.Location = new System.Drawing.Point(30, 68);
            this.groupThongTInSP.Name = "groupThongTInSP";
            this.groupThongTInSP.Size = new System.Drawing.Size(810, 310);
            this.groupThongTInSP.TabIndex = 26;
            this.groupThongTInSP.TabStop = false;
            this.groupThongTInSP.Text = "Thông tin chi tiết";
            // 
            // cboNSX
            // 
            this.cboNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNSX.FormattingEnabled = true;
            this.cboNSX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cboNSX.Location = new System.Drawing.Point(594, 120);
            this.cboNSX.Name = "cboNSX";
            this.cboNSX.Size = new System.Drawing.Size(194, 28);
            this.cboNSX.TabIndex = 7;
            // 
            // cboMaLoai
            // 
            this.cboMaLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMaLoai.FormattingEnabled = true;
            this.cboMaLoai.Location = new System.Drawing.Point(594, 166);
            this.cboMaLoai.Name = "cboMaLoai";
            this.cboMaLoai.Size = new System.Drawing.Size(194, 28);
            this.cboMaLoai.TabIndex = 9;
            // 
            // lblBaoHanh
            // 
            this.lblBaoHanh.AutoSize = true;
            this.lblBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBaoHanh.Location = new System.Drawing.Point(16, 175);
            this.lblBaoHanh.Name = "lblBaoHanh";
            this.lblBaoHanh.Size = new System.Drawing.Size(189, 20);
            this.lblBaoHanh.TabIndex = 3;
            this.lblBaoHanh.Text = "THỜI GIAN BẢO HÀNH";
            // 
            // cboNCC
            // 
            this.cboNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(237, 121);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(194, 28);
            this.cboNCC.TabIndex = 6;
            // 
            // txtBaoHanh
            // 
            this.txtBaoHanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaoHanh.Location = new System.Drawing.Point(237, 166);
            this.txtBaoHanh.Name = "txtBaoHanh";
            this.txtBaoHanh.Size = new System.Drawing.Size(194, 27);
            this.txtBaoHanh.TabIndex = 8;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(594, 77);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(194, 27);
            this.txtSoLuong.TabIndex = 5;
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSanPham.Location = new System.Drawing.Point(594, 37);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(194, 27);
            this.txtTenSanPham.TabIndex = 3;
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(237, 211);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(551, 27);
            this.txtMota.TabIndex = 10;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(237, 77);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(194, 27);
            this.txtDonGia.TabIndex = 4;
            // 
            // txtMaSanPham
            // 
            this.txtMaSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSanPham.Location = new System.Drawing.Point(237, 38);
            this.txtMaSanPham.Name = "txtMaSanPham";
            this.txtMaSanPham.Size = new System.Drawing.Size(194, 27);
            this.txtMaSanPham.TabIndex = 2;
            // 
            // lblXuatXu
            // 
            this.lblXuatXu.AutoSize = true;
            this.lblXuatXu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXuatXu.Location = new System.Drawing.Point(437, 173);
            this.lblXuatXu.Name = "lblXuatXu";
            this.lblXuatXu.Size = new System.Drawing.Size(74, 20);
            this.lblXuatXu.TabIndex = 8;
            this.lblXuatXu.Text = "LOẠI SP";
            // 
            // lblMaNCC
            // 
            this.lblMaNCC.AutoSize = true;
            this.lblMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNCC.Location = new System.Drawing.Point(16, 130);
            this.lblMaNCC.Name = "lblMaNCC";
            this.lblMaNCC.Size = new System.Drawing.Size(168, 20);
            this.lblMaNCC.TabIndex = 4;
            this.lblMaNCC.Text = "MÃ NHÀ CUNG CẤP";
            // 
            // lblMoTa
            // 
            this.lblMoTa.AutoSize = true;
            this.lblMoTa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Location = new System.Drawing.Point(16, 220);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(62, 20);
            this.lblMoTa.TabIndex = 6;
            this.lblMoTa.Text = "MÔ TẢ";
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(435, 41);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(135, 20);
            this.lblTenSP.TabIndex = 16;
            this.lblTenSP.Text = "TÊN SẢN PHẨM";
            // 
            // lblNSX
            // 
            this.lblNSX.AutoSize = true;
            this.lblNSX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNSX.Location = new System.Drawing.Point(437, 129);
            this.lblNSX.Name = "lblNSX";
            this.lblNSX.Size = new System.Drawing.Size(133, 20);
            this.lblNSX.TabIndex = 7;
            this.lblNSX.Text = "NHÀ SẢN XUẤT";
            // 
            // lblMaSP
            // 
            this.lblMaSP.AutoSize = true;
            this.lblMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSP.Location = new System.Drawing.Point(16, 40);
            this.lblMaSP.Name = "lblMaSP";
            this.lblMaSP.Size = new System.Drawing.Size(127, 20);
            this.lblMaSP.TabIndex = 0;
            this.lblMaSP.Text = "MÃ SẢN PHẨM";
            // 
            // lblSoLuongKho
            // 
            this.lblSoLuongKho.AutoSize = true;
            this.lblSoLuongKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongKho.Location = new System.Drawing.Point(435, 85);
            this.lblSoLuongKho.Name = "lblSoLuongKho";
            this.lblSoLuongKho.Size = new System.Drawing.Size(98, 20);
            this.lblSoLuongKho.TabIndex = 0;
            this.lblSoLuongKho.Text = "SỐ LƯỢNG";
            // 
            // lblDonGia
            // 
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Location = new System.Drawing.Point(16, 85);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(79, 20);
            this.lblDonGia.TabIndex = 5;
            this.lblDonGia.Text = "ĐƠN GIÁ";
            // 
            // panel_title_SP
            // 
            this.panel_title_SP.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel_title_SP.Controls.Add(this.lblBanHang);
            this.panel_title_SP.Location = new System.Drawing.Point(0, 1);
            this.panel_title_SP.Name = "panel_title_SP";
            this.panel_title_SP.Size = new System.Drawing.Size(1569, 56);
            this.panel_title_SP.TabIndex = 28;
            // 
            // lblBanHang
            // 
            this.lblBanHang.AutoSize = true;
            this.lblBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanHang.Location = new System.Drawing.Point(661, 12);
            this.lblBanHang.Name = "lblBanHang";
            this.lblBanHang.Size = new System.Drawing.Size(173, 36);
            this.lblBanHang.TabIndex = 0;
            this.lblBanHang.Text = "SẢN PHẨM";
            // 
            // formSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1563, 850);
            this.Controls.Add(this.panel_title_SP);
            this.Controls.Add(this.groupTimKiem);
            this.Controls.Add(this.dataGridViewSanPham);
            this.Controls.Add(this.groupThaoTac);
            this.Controls.Add(this.groupThongTInSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSanPham";
            this.Text = "formSanPham";
            this.Load += new System.EventHandler(this.formSanPham_Load);
            this.groupTimKiem.ResumeLayout(false);
            this.groupTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSanPham)).EndInit();
            this.groupThaoTac.ResumeLayout(false);
            this.groupThaoTac.PerformLayout();
            this.groupThongTInSP.ResumeLayout(false);
            this.groupThongTInSP.PerformLayout();
            this.panel_title_SP.ResumeLayout(false);
            this.panel_title_SP.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupTimKiem;
		private System.Windows.Forms.Button btnXoaTimKiem;
		private System.Windows.Forms.Label lblLoaiSP;
		private System.Windows.Forms.TextBox txtTimKiem;
		private System.Windows.Forms.ComboBox cboTimKiem;
		private System.Windows.Forms.Label lblTimKiemSP;
		private System.Windows.Forms.Button btnTKSanPham;
		private System.Windows.Forms.DataGridView dataGridViewSanPham;
		private System.Windows.Forms.GroupBox groupThaoTac;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.GroupBox groupThongTInSP;
		private System.Windows.Forms.ComboBox cboNSX;
		private System.Windows.Forms.ComboBox cboMaLoai;
		private System.Windows.Forms.Label lblBaoHanh;
		private System.Windows.Forms.ComboBox cboNCC;
		private System.Windows.Forms.TextBox txtBaoHanh;
		private System.Windows.Forms.TextBox txtSoLuong;
		private System.Windows.Forms.TextBox txtTenSanPham;
		private System.Windows.Forms.TextBox txtMota;
		private System.Windows.Forms.TextBox txtDonGia;
		private System.Windows.Forms.TextBox txtMaSanPham;
		private System.Windows.Forms.Label lblXuatXu;
		private System.Windows.Forms.Label lblMaNCC;
		private System.Windows.Forms.Label lblMoTa;
		private System.Windows.Forms.Label lblTenSP;
		private System.Windows.Forms.Label lblNSX;
		private System.Windows.Forms.Label lblMaSP;
		private System.Windows.Forms.Label lblSoLuongKho;
		private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.Panel panel_title_SP;
        private System.Windows.Forms.Label lblBanHang;
        private System.Windows.Forms.ComboBox cboSapXepSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThem;
    }
}