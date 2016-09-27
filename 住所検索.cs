using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [ZŠŒŸõ]
	/// </summary>
	//--------------------------------------------------------------------------
	// C³—š—ğ
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ 
	//--------------------------------------------------------------------------
	public class ZŠŒŸõ : ‹¤’ÊƒtƒH[ƒ€
	{
		public short OldRow = 0;
		public string s—X•Ö”Ô†‚P = "";
		public string s—X•Ö”Ô†‚Q = "";
		public string sŠÇ—“XŠ   = "";
		public string sZŠ       = "";
		public string sZŠ‚b‚c   = "";
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ START
		public string s‚¨‹q—l‚b‚c   = "";
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ END
		private string s“s“¹•{Œ§‚b‚c = "";
		private string ss‹æ’¬‘º‚b‚c = "";

		private string[] sZŠˆê——;
		private int      iŒ»İ•Å”;
		private int      iÅ‘å•Å”;
		private int      iŠJn”;
		private int      iI—¹”;
		private int      iƒAƒNƒeƒBƒu‚e‚f = 0;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lab—X•Ö”Ô†;
		private System.Windows.Forms.Label lab“s“¹•{Œ§;
		private System.Windows.Forms.Label labZŠŒŸõƒ^ƒCƒgƒ‹;
		private System.Windows.Forms.Button btnŠm’è;
		private System.Windows.Forms.ComboBox cmb“s“¹•{Œ§;
		private ‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX tex—X•Ö”Ô†‚Q;
		private ‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX tex—X•Ö”Ô†‚P;
		private ‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texƒƒbƒZ[ƒW;
		private System.Windows.Forms.Button btn•Â‚¶‚é;
		private System.Windows.Forms.Button btnŒŸõ;
		private AxGTABLE32V2Lib.AxGTable32 axGTZŠ;
		private System.Windows.Forms.Label labZŠ;
		private System.Windows.Forms.Label lab•Å”Ô†;
		private System.Windows.Forms.Button btnŸ•Å;
		private System.Windows.Forms.Button btn‘O•Å;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		/// <summary>
		/// •K—v‚ÈƒfƒUƒCƒi•Ï”‚Å‚·B
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ZŠŒŸõ()
		{
			//
			// Windows ƒtƒH[ƒ€ ƒfƒUƒCƒi ƒTƒ|[ƒg‚É•K—v‚Å‚·B
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent ŒÄ‚Ño‚µ‚ÌŒã‚ÉAƒRƒ“ƒXƒgƒ‰ƒNƒ^ ƒR[ƒh‚ğ’Ç‰Á‚µ‚Ä‚­‚¾‚³‚¢B
			//
		}

		/// <summary>
		/// g—p‚³‚ê‚Ä‚¢‚éƒŠƒ\[ƒX‚ÉŒãˆ—‚ğÀs‚µ‚Ü‚·B
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows ƒtƒH[ƒ€ ƒfƒUƒCƒi‚Å¶¬‚³‚ê‚½ƒR[ƒh 
		/// <summary>
		/// ƒfƒUƒCƒi ƒTƒ|[ƒg‚É•K—v‚Èƒƒ\ƒbƒh‚Å‚·B‚±‚Ìƒƒ\ƒbƒh‚Ì“à—e‚ğ
		/// ƒR[ƒh ƒGƒfƒBƒ^‚Å•ÏX‚µ‚È‚¢‚Å‚­‚¾‚³‚¢B
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ZŠŒŸõ));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab•Å”Ô† = new System.Windows.Forms.Label();
			this.btnŸ•Å = new System.Windows.Forms.Button();
			this.btn‘O•Å = new System.Windows.Forms.Button();
			this.labZŠ = new System.Windows.Forms.Label();
			this.axGTZŠ = new AxGTABLE32V2Lib.AxGTable32();
			this.btnŠm’è = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.cmb“s“¹•{Œ§ = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tex—X•Ö”Ô†‚Q = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.tex—X•Ö”Ô†‚P = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.lab—X•Ö”Ô† = new System.Windows.Forms.Label();
			this.lab“s“¹•{Œ§ = new System.Windows.Forms.Label();
			this.btnŒŸõ = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labZŠŒŸõƒ^ƒCƒgƒ‹ = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texƒƒbƒZ[ƒW = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.btn•Â‚¶‚é = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGTZŠ)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.lab•Å”Ô†);
			this.panel1.Controls.Add(this.btnŸ•Å);
			this.panel1.Controls.Add(this.btn‘O•Å);
			this.panel1.Controls.Add(this.labZŠ);
			this.panel1.Controls.Add(this.axGTZŠ);
			this.panel1.Controls.Add(this.btnŠm’è);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 380);
			this.panel1.TabIndex = 0;
			// 
			// lab•Å”Ô†
			// 
			this.lab•Å”Ô†.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab•Å”Ô†.ForeColor = System.Drawing.Color.Green;
			this.lab•Å”Ô†.Location = new System.Drawing.Point(236, 330);
			this.lab•Å”Ô†.Name = "lab•Å”Ô†";
			this.lab•Å”Ô†.Size = new System.Drawing.Size(48, 14);
			this.lab•Å”Ô†.TabIndex = 70;
			this.lab•Å”Ô†.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnŸ•Å
			// 
			this.btnŸ•Å.BackColor = System.Drawing.Color.SteelBlue;
			this.btnŸ•Å.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnŸ•Å.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnŸ•Å.ForeColor = System.Drawing.Color.White;
			this.btnŸ•Å.Location = new System.Drawing.Point(284, 326);
			this.btnŸ•Å.Name = "btnŸ•Å";
			this.btnŸ•Å.Size = new System.Drawing.Size(48, 22);
			this.btnŸ•Å.TabIndex = 7;
			this.btnŸ•Å.Text = "Ÿ•Å";
			this.btnŸ•Å.Click += new System.EventHandler(this.btnŸ•Å_Click);
			// 
			// btn‘O•Å
			// 
			this.btn‘O•Å.BackColor = System.Drawing.Color.SteelBlue;
			this.btn‘O•Å.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn‘O•Å.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn‘O•Å.ForeColor = System.Drawing.Color.White;
			this.btn‘O•Å.Location = new System.Drawing.Point(188, 326);
			this.btn‘O•Å.Name = "btn‘O•Å";
			this.btn‘O•Å.Size = new System.Drawing.Size(48, 22);
			this.btn‘O•Å.TabIndex = 6;
			this.btn‘O•Å.Text = "‘O•Å";
			this.btn‘O•Å.Click += new System.EventHandler(this.btn‘O•Å_Click);
			// 
			// labZŠ
			// 
			this.labZŠ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
			this.labZŠ.ForeColor = System.Drawing.Color.Green;
			this.labZŠ.Location = new System.Drawing.Point(30, 6);
			this.labZŠ.Name = "labZŠ";
			this.labZŠ.Size = new System.Drawing.Size(314, 20);
			this.labZŠ.TabIndex = 4;
			// 
			// axGTZŠ
			// 
			this.axGTZŠ.ContainingControl = this;
			this.axGTZŠ.DataSource = null;
			this.axGTZŠ.Location = new System.Drawing.Point(40, 32);
			this.axGTZŠ.Name = "axGTZŠ";
			this.axGTZŠ.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGTZŠ.OcxState")));
			this.axGTZŠ.Size = new System.Drawing.Size(293, 290);
			this.axGTZŠ.TabIndex = 5;
			this.axGTZŠ.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGTZŠ_KeyDownEvent);
			this.axGTZŠ.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGTZŠ_CelDblClick);
			this.axGTZŠ.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGTZŠ_CurPlaceChanged);
			// 
			// btnŠm’è
			// 
			this.btnŠm’è.BackColor = System.Drawing.Color.Blue;
			this.btnŠm’è.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnŠm’è.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnŠm’è.ForeColor = System.Drawing.Color.White;
			this.btnŠm’è.Location = new System.Drawing.Point(302, 354);
			this.btnŠm’è.Name = "btnŠm’è";
			this.btnŠm’è.Size = new System.Drawing.Size(64, 22);
			this.btnŠm’è.TabIndex = 8;
			this.btnŠm’è.Text = "Šm’è";
			this.btnŠm’è.Click += new System.EventHandler(this.btnŠm’è_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Honeydew;
			this.panel5.Controls.Add(this.cmb“s“¹•{Œ§);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.tex—X•Ö”Ô†‚Q);
			this.panel5.Controls.Add(this.tex—X•Ö”Ô†‚P);
			this.panel5.Controls.Add(this.lab—X•Ö”Ô†);
			this.panel5.Controls.Add(this.lab“s“¹•{Œ§);
			this.panel5.Controls.Add(this.btnŒŸõ);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(362, 60);
			this.panel5.TabIndex = 0;
			// 
			// cmb“s“¹•{Œ§
			// 
			this.cmb“s“¹•{Œ§.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmb“s“¹•{Œ§.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cmb“s“¹•{Œ§.Location = new System.Drawing.Point(88, 32);
			this.cmb“s“¹•{Œ§.Name = "cmb“s“¹•{Œ§";
			this.cmb“s“¹•{Œ§.Size = new System.Drawing.Size(102, 24);
			this.cmb“s“¹•{Œ§.TabIndex = 2;
			this.cmb“s“¹•{Œ§.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb“s“¹•{Œ§_KeyDown);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.Green;
			this.label2.Location = new System.Drawing.Point(124, 10);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(14, 16);
			this.label2.TabIndex = 1;
			this.label2.Text = "-";
			// 
			// tex—X•Ö”Ô†‚Q
			// 
			this.tex—X•Ö”Ô†‚Q.BackColor = System.Drawing.SystemColors.Window;
			this.tex—X•Ö”Ô†‚Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex—X•Ö”Ô†‚Q.Location = new System.Drawing.Point(140, 6);
			this.tex—X•Ö”Ô†‚Q.MaxLength = 4;
			this.tex—X•Ö”Ô†‚Q.Name = "tex—X•Ö”Ô†‚Q";
			this.tex—X•Ö”Ô†‚Q.Size = new System.Drawing.Size(42, 23);
			this.tex—X•Ö”Ô†‚Q.TabIndex = 1;
			this.tex—X•Ö”Ô†‚Q.Text = "";
			this.tex—X•Ö”Ô†‚Q.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex—X•Ö”Ô†‚Q_KeyDown);
			// 
			// tex—X•Ö”Ô†‚P
			// 
			this.tex—X•Ö”Ô†‚P.BackColor = System.Drawing.SystemColors.Window;
			this.tex—X•Ö”Ô†‚P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex—X•Ö”Ô†‚P.Location = new System.Drawing.Point(88, 6);
			this.tex—X•Ö”Ô†‚P.MaxLength = 3;
			this.tex—X•Ö”Ô†‚P.Name = "tex—X•Ö”Ô†‚P";
			this.tex—X•Ö”Ô†‚P.Size = new System.Drawing.Size(34, 23);
			this.tex—X•Ö”Ô†‚P.TabIndex = 0;
			this.tex—X•Ö”Ô†‚P.Text = "";
			// 
			// lab—X•Ö”Ô†
			// 
			this.lab—X•Ö”Ô†.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab—X•Ö”Ô†.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab—X•Ö”Ô†.Location = new System.Drawing.Point(8, 10);
			this.lab—X•Ö”Ô†.Name = "lab—X•Ö”Ô†";
			this.lab—X•Ö”Ô†.Size = new System.Drawing.Size(76, 16);
			this.lab—X•Ö”Ô†.TabIndex = 46;
			this.lab—X•Ö”Ô†.Text = "—X•Ö”Ô†";
			// 
			// lab“s“¹•{Œ§
			// 
			this.lab“s“¹•{Œ§.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab“s“¹•{Œ§.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab“s“¹•{Œ§.Location = new System.Drawing.Point(8, 34);
			this.lab“s“¹•{Œ§.Name = "lab“s“¹•{Œ§";
			this.lab“s“¹•{Œ§.Size = new System.Drawing.Size(76, 16);
			this.lab“s“¹•{Œ§.TabIndex = 6;
			this.lab“s“¹•{Œ§.Text = "“s“¹•{Œ§";
			// 
			// btnŒŸõ
			// 
			this.btnŒŸõ.BackColor = System.Drawing.Color.SteelBlue;
			this.btnŒŸõ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnŒŸõ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnŒŸõ.ForeColor = System.Drawing.Color.White;
			this.btnŒŸõ.Location = new System.Drawing.Point(292, 32);
			this.btnŒŸõ.Name = "btnŒŸõ";
			this.btnŒŸõ.Size = new System.Drawing.Size(64, 22);
			this.btnŒŸõ.TabIndex = 3;
			this.btnŒŸõ.TabStop = false;
			this.btnŒŸõ.Text = "ŒŸõ";
			this.btnŒŸõ.Click += new System.EventHandler(this.btnŒŸõ_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.labZŠŒŸõƒ^ƒCƒgƒ‹);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// labZŠŒŸõƒ^ƒCƒgƒ‹
			// 
			this.labZŠŒŸõƒ^ƒCƒgƒ‹.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labZŠŒŸõƒ^ƒCƒgƒ‹.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labZŠŒŸõƒ^ƒCƒgƒ‹.ForeColor = System.Drawing.Color.White;
			this.labZŠŒŸõƒ^ƒCƒgƒ‹.Location = new System.Drawing.Point(12, 2);
			this.labZŠŒŸõƒ^ƒCƒgƒ‹.Name = "labZŠŒŸõƒ^ƒCƒgƒ‹";
			this.labZŠŒŸõƒ^ƒCƒgƒ‹.Size = new System.Drawing.Size(264, 24);
			this.labZŠŒŸõƒ^ƒCƒgƒ‹.TabIndex = 0;
			this.labZŠŒŸõƒ^ƒCƒgƒ‹.Text = "ZŠŒŸõ";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.texƒƒbƒZ[ƒW);
			this.panel8.Controls.Add(this.btn•Â‚¶‚é);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(388, 58);
			this.panel8.TabIndex = 2;
			// 
			// texƒƒbƒZ[ƒW
			// 
			this.texƒƒbƒZ[ƒW.BackColor = System.Drawing.Color.PaleGreen;
			this.texƒƒbƒZ[ƒW.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texƒƒbƒZ[ƒW.ForeColor = System.Drawing.Color.Red;
			this.texƒƒbƒZ[ƒW.Location = new System.Drawing.Point(68, 4);
			this.texƒƒbƒZ[ƒW.Multiline = true;
			this.texƒƒbƒZ[ƒW.Name = "texƒƒbƒZ[ƒW";
			this.texƒƒbƒZ[ƒW.ReadOnly = true;
			this.texƒƒbƒZ[ƒW.Size = new System.Drawing.Size(314, 50);
			this.texƒƒbƒZ[ƒW.TabIndex = 0;
			this.texƒƒbƒZ[ƒW.TabStop = false;
			this.texƒƒbƒZ[ƒW.Text = "";
			// 
			// btn•Â‚¶‚é
			// 
			this.btn•Â‚¶‚é.ForeColor = System.Drawing.Color.Red;
			this.btn•Â‚¶‚é.Location = new System.Drawing.Point(8, 6);
			this.btn•Â‚¶‚é.Name = "btn•Â‚¶‚é";
			this.btn•Â‚¶‚é.Size = new System.Drawing.Size(54, 48);
			this.btn•Â‚¶‚é.TabIndex = 0;
			this.btn•Â‚¶‚é.TabStop = false;
			this.btn•Â‚¶‚é.Text = "•Â‚¶‚é";
			this.btn•Â‚¶‚é.Click += new System.EventHandler(this.btn•Â‚¶‚é_Click);
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(396, 26);
			this.panel6.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Location = new System.Drawing.Point(7, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(365, 68);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(7, 122);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 388);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// ZŠŒŸõ
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(388, 574);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(394, 607);
			this.Name = "ZŠŒŸõ";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ZŠŒŸõ";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ƒGƒ“ƒ^[ˆÚ“®);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ƒGƒ“ƒ^[ƒLƒƒƒ“ƒZƒ‹);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.ZŠŒŸõ_Closed);
			this.Activated += new System.EventHandler(this.ZŠŒŸõ_Activated);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGTZŠ)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// ƒAƒvƒŠƒP[ƒVƒ‡ƒ“‚ÌƒƒCƒ“ ƒGƒ“ƒgƒŠ ƒ|ƒCƒ“ƒg‚Å‚·B
		/// </summary>
		private void Form1_Load(object sender, System.EventArgs e)
		{
			iƒAƒNƒeƒBƒu‚e‚f = 0;
			// —X•Ö”Ô†‚Ìİ’è
			tex—X•Ö”Ô†‚P.Text = s—X•Ö”Ô†‚P;
			tex—X•Ö”Ô†‚Q.Text = s—X•Ö”Ô†‚Q;

			// Œ§–¼‚Ì‰Šúİ’è
			cmb“s“¹•{Œ§.Items.Clear();
			cmb“s“¹•{Œ§.Items.AddRange(saŒ§);
			cmb“s“¹•{Œ§.SelectedIndex = 0;

			axGTZŠ.Cols = 4;
			axGTZŠ.Rows = 15;
			axGTZŠ.ColSep = "|";
			axGTZŠ.CaretRow = 1;
			axGTZŠ.NoBeep = true;

			axGTZŠ.set_RowsText(0, "|—X•Ö”Ô†|ZŠ|ƒR[ƒh|“XŠ");
			axGTZŠ.ColsWidth = "0|5.5|17|0|0|";
			axGTZŠ.ColsAlignHorz = "1|1|0|0|0|";
            
//			axGTZŠ.set_CelForeColor(axGTZŠ.CaretRow,0,111111);
			axGTZŠ.set_CelForeColor(axGTZŠ.CaretRow,0,0x98FB98);  //BGR
			axGTZŠ.set_CelBackColor(axGTZŠ.CaretRow,0,0x006000);

			btn‘O•Å.Enabled = false;
			btnŸ•Å.Enabled = false;
			lab•Å”Ô†.Text = "";
		}

		private void btn•Â‚¶‚é_Click(object sender, System.EventArgs e)
		{
			s—X•Ö”Ô†‚P = "";
			s—X•Ö”Ô†‚Q = "";
			this.Close();
		}

		private void axGTZŠ_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGTZŠ.set_CelForeColor(OldRow,0,0);
			axGTZŠ.set_CelBackColor(OldRow,0,0xFFFFFF);
//			axGTZŠ.set_CelForeColor(axGTZŠ.CaretRow,0,111111);
			axGTZŠ.set_CelForeColor(axGTZŠ.CaretRow,0,0x98FB98);  //BGR
			axGTZŠ.set_CelBackColor(axGTZŠ.CaretRow,0,0x006000);
			OldRow = axGTZŠ.CaretRow;
		}

		private void btnŒŸõ_Click(object sender, System.EventArgs e)
		{
			iƒAƒNƒeƒBƒu‚e‚f = 1;
			texƒƒbƒZ[ƒW.Text = "";
			// ‹ó”’œ‹
			tex—X•Ö”Ô†‚P.Text = tex—X•Ö”Ô†‚P.Text.Trim();
			tex—X•Ö”Ô†‚Q.Text = tex—X•Ö”Ô†‚Q.Text.Trim();
			iŒ»İ•Å” = 1;

			if(tex—X•Ö”Ô†‚P.Text.Length == 3)
			{
				cmb“s“¹•{Œ§.Text          = "";
				cmb“s“¹•{Œ§.SelectedIndex = 0;
				s“s“¹•{Œ§‚b‚c = "";
				ss‹æ’¬‘º‚b‚c = "";
				labZŠ.Text = "";
				axGTZŠ.Clear();

				sZŠˆê—— = new string[1];
				// ƒJ[ƒ\ƒ‹‚ğ»Œv‚É‚·‚é
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				try
				{
					texƒƒbƒZ[ƒW.Text = "ŒŸõ’†DDD";
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ START
					if ((s‚¨‹q—l‚b‚c == "") || (s‚¨‹q—l‚b‚c.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ END
					sZŠˆê—— = sv_maintenance.Get_byPostcode(gsaƒ†[ƒU, tex—X•Ö”Ô†‚P.Text + tex—X•Ö”Ô†‚Q.Text);
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ START
					}else{
						sZŠˆê—— = sv_oji.Get_byPostcodeM(gsaƒ†[ƒU, tex—X•Ö”Ô†‚P.Text + tex—X•Ö”Ô†‚Q.Text);
					}
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ END

				
				}
// ADD 2005.05.25 “Œ“sj¬“¶’J ’ÊMƒGƒ‰[‚ÌƒƒbƒZ[ƒWC³ START
				catch (System.Net.WebException)
				{
					sZŠˆê——[0] = gs’ÊMƒGƒ‰[;
				}
// ADD 2005.05.25 “Œ“sj¬“¶’J ’ÊMƒGƒ‰[‚ÌƒƒbƒZ[ƒWC³ END
				catch (Exception ex)
				{
					sZŠˆê——[0] = "’ÊMƒGƒ‰[F" + ex.Message;
				}
				// ƒJ[ƒ\ƒ‹‚ğƒfƒtƒHƒ‹ƒg‚É–ß‚·
				Cursor = System.Windows.Forms.Cursors.Default;

				if (sZŠˆê——[0].Equals("³íI—¹"))
				{
					texƒƒbƒZ[ƒW.Text = "";
// MOD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‹ó”’ START
//					iÅ‘å•Å” = (sZŠˆê——.Length - 2) / axGTZŠ.Rows + 1;
					iÅ‘å•Å” = (sZŠˆê——.Length - 2) / (axGTZŠ.Rows - 1) + 1;
// MOD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‹ó”’ END
					if (iŒ»İ•Å” > iÅ‘å•Å”)
						iŒ»İ•Å” = iÅ‘å•Å”;
					•Åî•ñİ’è();

					axGTZŠ.Focus();
				}
				else
				{
					if (sZŠˆê——[0].Equals("ŠY“–ƒf[ƒ^‚ª‚ ‚è‚Ü‚¹‚ñ"))
					{
						texƒƒbƒZ[ƒW.Text = "";
						MessageBox.Show("ŠY“–ƒf[ƒ^‚ª‚ ‚è‚Ü‚¹‚ñ","ZŠŒŸõ",MessageBoxButtons.OK);
					}
					else
					{
						texƒƒbƒZ[ƒW.Text = sZŠˆê——[0];
						axGTZŠ.Clear();
						iŒ»İ•Å” = 1;
						btn‘O•Å.Enabled = false;
						btnŸ•Å.Enabled = false;
						lab•Å”Ô†.Text = "";
						ƒr[ƒv‰¹();
					}
					tex—X•Ö”Ô†‚P.Focus();
				}
			}
			else if(cmb“s“¹•{Œ§.SelectedIndex > 0)
			{
				tex—X•Ö”Ô†‚P.Text = "";
				tex—X•Ö”Ô†‚Q.Text = "";
				labZŠ.Text = cmb“s“¹•{Œ§.Text;
				s“s“¹•{Œ§‚b‚c = cmb“s“¹•{Œ§.SelectedIndex.ToString();
				ss‹æ’¬‘º‚b‚c = "";
				if(s“s“¹•{Œ§‚b‚c.Length == 1) s“s“¹•{Œ§‚b‚c = "0" + s“s“¹•{Œ§‚b‚c;
				axGTZŠ.Clear();

				sZŠˆê—— = new string[1];
				// ƒJ[ƒ\ƒ‹‚ğ»Œv‚É‚·‚é
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				try
				{
					texƒƒbƒZ[ƒW.Text = "ŒŸõ’†DDD";
					sZŠˆê—— = sv_maintenance.Get_byKen(gsaƒ†[ƒU, s“s“¹•{Œ§‚b‚c);
				}
// ADD 2005.05.25 “Œ“sj¬“¶’J ’ÊMƒGƒ‰[‚ÌƒƒbƒZ[ƒWC³ START
				catch (System.Net.WebException)
				{
					sZŠˆê——[0] = gs’ÊMƒGƒ‰[;
				}
// ADD 2005.05.25 “Œ“sj¬“¶’J ’ÊMƒGƒ‰[‚ÌƒƒbƒZ[ƒWC³ END
				catch (Exception ex)
				{
					sZŠˆê——[0] = "’ÊMƒGƒ‰[F" + ex.Message;
				}
				// ƒJ[ƒ\ƒ‹‚ğƒfƒtƒHƒ‹ƒg‚É–ß‚·
				Cursor = System.Windows.Forms.Cursors.Default;

				if(sZŠˆê——[0].Length == 4)
				{
					texƒƒbƒZ[ƒW.Text = "";
// MOD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‹ó”’ START
//					iÅ‘å•Å” = (sZŠˆê——.Length - 2) / axGTZŠ.Rows + 1;
					iÅ‘å•Å” = (sZŠˆê——.Length - 2) / (axGTZŠ.Rows - 1) + 1;
// MOD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‹ó”’ END
					if (iŒ»İ•Å” > iÅ‘å•Å”)
						iŒ»İ•Å” = iÅ‘å•Å”;
					•Åî•ñİ’è();

// ADD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‘I‘ğ START
					axGTZŠ.CaretRow = 1;
					axGTZŠ_CurPlaceChanged(null,null);
// ADD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‘I‘ğ END

					axGTZŠ.Focus();
				}
				else
				{
					texƒƒbƒZ[ƒW.Text = sZŠˆê——[0];
					axGTZŠ.Clear();
					iŒ»İ•Å” = 1;
					btn‘O•Å.Enabled = false;
					btnŸ•Å.Enabled = false;
					lab•Å”Ô†.Text = "";
					ƒr[ƒv‰¹();
					cmb“s“¹•{Œ§.Focus();
				}
			}
			else if (axGTZŠ.Focused == true)
			{
			
				tex—X•Ö”Ô†‚P.Focus();
			}
		}

		private void tex—X•Ö”Ô†‚Q_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btnŒŸõ_Click(sender, e);
				return;
			}
		}

		private void cmb“s“¹•{Œ§_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btnŒŸõ_Click(sender, e);
				return;
			}
		}

		private void btnŠm’è_Click(object sender, System.EventArgs e)
		{
			if(axGTZŠ.CaretRow < 0) return;
			if(axGTZŠ.get_CelText(axGTZŠ.CaretRow,3).Length == 0) return;
			if(ss‹æ’¬‘º‚b‚c.Length == 0 && s“s“¹•{Œ§‚b‚c.Length > 0)
			{
				iŒ»İ•Å” = 1;

				texƒƒbƒZ[ƒW.Text = "";
				labZŠ.Text += axGTZŠ.get_CelText(axGTZŠ.CaretRow,2);
				ss‹æ’¬‘º‚b‚c = axGTZŠ.get_CelText(axGTZŠ.CaretRow,3);

				sZŠˆê—— = new string[1];
				// ƒJ[ƒ\ƒ‹‚ğ»Œv‚É‚·‚é
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				try
				{
					texƒƒbƒZ[ƒW.Text = "ŒŸõ’†DDD";
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ START
					if ((s‚¨‹q—l‚b‚c == "") || (s‚¨‹q—l‚b‚c.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ END
						sZŠˆê—— = sv_maintenance.Get_byKenShi(gsaƒ†[ƒU, s“s“¹•{Œ§‚b‚c,ss‹æ’¬‘º‚b‚c);
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ START
					}else{
						sZŠˆê—— = sv_oji.Get_byKenShiM(gsaƒ†[ƒU, s“s“¹•{Œ§‚b‚c,ss‹æ’¬‘º‚b‚c);
					}
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ END
				}
// ADD 2005.05.25 “Œ“sj¬“¶’J ’ÊMƒGƒ‰[‚ÌƒƒbƒZ[ƒWC³ START
				catch (System.Net.WebException)
				{
					sZŠˆê——[0] = gs’ÊMƒGƒ‰[;
				}
// ADD 2005.05.25 “Œ“sj¬“¶’J ’ÊMƒGƒ‰[‚ÌƒƒbƒZ[ƒWC³ END
				catch (Exception ex)
				{
					sZŠˆê——[0] = "’ÊMƒGƒ‰[F" + ex.Message;
				}
				// ƒJ[ƒ\ƒ‹‚ğƒfƒtƒHƒ‹ƒg‚É–ß‚·
				Cursor = System.Windows.Forms.Cursors.Default;

				if(sZŠˆê——[0].Length == 4)
				{
					texƒƒbƒZ[ƒW.Text = "";
					axGTZŠ.Clear();
// MOD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‹ó”’ START
//					iÅ‘å•Å” = (sZŠˆê——.Length - 2) / axGTZŠ.Rows + 1;
					iÅ‘å•Å” = (sZŠˆê——.Length - 2) / (axGTZŠ.Rows - 1) + 1;
// MOD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‹ó”’ END
					if (iŒ»İ•Å” > iÅ‘å•Å”)
						iŒ»İ•Å” = iÅ‘å•Å”;
					•Åî•ñİ’è();

// ADD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‘I‘ğ START
					axGTZŠ.CaretRow = 1;
					axGTZŠ_CurPlaceChanged(null,null);
// ADD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‘I‘ğ END

					axGTZŠ.Focus();
				}
				else
				{
					texƒƒbƒZ[ƒW.Text = sZŠˆê——[0];
					ƒr[ƒv‰¹();
					axGTZŠ.Focus();
				}
			}
			else
			{
				labZŠ.Text += axGTZŠ.get_CelText(axGTZŠ.CaretRow,2);
				s—X•Ö”Ô†‚P = axGTZŠ.get_CelText(axGTZŠ.CaretRow,1);
				s—X•Ö”Ô†‚P = s—X•Ö”Ô†‚P.Replace("-","");
				if(s—X•Ö”Ô†‚P.Length > 3)
				{
					s—X•Ö”Ô†‚Q = s—X•Ö”Ô†‚P.Substring(3);
					s—X•Ö”Ô†‚P = s—X•Ö”Ô†‚P.Substring(0,3);
				}
				sZŠ       = labZŠ.Text;
				sZŠ‚b‚c   = axGTZŠ.get_CelText(axGTZŠ.CaretRow,3);
				sŠÇ—“XŠ   = axGTZŠ.get_CelText(axGTZŠ.CaretRow,4);
				//ƒ_ƒCƒAƒƒO‚ğ•Â‚¶‚é
				this.Close();
			}
		}

		private void axGTZŠ_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			btnŠm’è_Click(sender, null);
		}

		private void axGTZŠ_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 13)
			{
				btnŠm’è_Click(sender, null);
			}
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGTZŠ, true, true, true, true);
			}
		}

		private void btn‘O•Å_Click(object sender, System.EventArgs e)
		{
			iŒ»İ•Å”--;
			•Åî•ñİ’è();
// ADD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‘I‘ğ START
			axGTZŠ.CaretRow = 1;
			axGTZŠ_CurPlaceChanged(null,null);
// ADD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‘I‘ğ END
		}

		private void btnŸ•Å_Click(object sender, System.EventArgs e)
		{
			iŒ»İ•Å”++;
			•Åî•ñİ’è();
// ADD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‘I‘ğ START
			axGTZŠ.CaretRow = 1;
			axGTZŠ_CurPlaceChanged(null,null);
// ADD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‘I‘ğ END
		}

		private void •Åî•ñİ’è()
		{
			axGTZŠ.Clear();

// MOD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‹ó”’ START
//			iŠJn” = (iŒ»İ•Å” - 1) * axGTZŠ.Rows + 1;
			iŠJn” = (iŒ»İ•Å” - 1) * (axGTZŠ.Rows - 1) + 1;
//			iI—¹” = iŒ»İ•Å” * axGTZŠ.Rows;
			iI—¹” = iŒ»İ•Å” * (axGTZŠ.Rows - 1);

//			short s•\¦” = (short)1;
			short s•\¦” = (short)2;
// MOD 2005.05.12 “Œ“sj¬“¶’J ˆês–Ú‹ó”’ START
			for(short sCnt = (short)iŠJn”; sCnt < sZŠˆê——.Length && sCnt <= iI—¹” ; sCnt++)
			{
				axGTZŠ.set_RowsText(s•\¦”, sZŠˆê——[sCnt]);
				s•\¦”++;
			}
			lab•Å”Ô†.Text = iŒ»İ•Å”.ToString() + " / " + iÅ‘å•Å”.ToString();
			if (iŒ»İ•Å” == 1)
				btn‘O•Å.Enabled = false;
			else
				btn‘O•Å.Enabled = true;
			if (iŒ»İ•Å” == iÅ‘å•Å”)
				btnŸ•Å.Enabled = false;
			else
				btnŸ•Å.Enabled = true;
			axGTZŠ.Focus();
		}

		private void ZŠŒŸõ_Activated(object sender, System.EventArgs e)
		{
			if(tex—X•Ö”Ô†‚P.Text.Trim().Length == 3 && iƒAƒNƒeƒBƒu‚e‚f == 0)
				btnŒŸõ_Click(sender,e);
		}

// ADD 2005.05.25 “Œ“sj¬“¶’J ƒtƒH[ƒJƒXˆÚ“® START
		private void ZŠŒŸõ_Closed(object sender, System.EventArgs e)
		{
			labZŠ.Text = "";
			axGTZŠ.Clear();
			axGTZŠ.CaretRow = 1;
			axGTZŠ_CurPlaceChanged(null,null);
			tex—X•Ö”Ô†‚P.Focus();
		}
// ADD 2005.05.24 “Œ“sj¬“¶’J ƒtƒH[ƒJƒXˆÚ“® END

	}
}
