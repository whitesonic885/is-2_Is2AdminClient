using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// Form1 の概要の説明です。
	/// </summary>
	public class 加入検索 : 共通フォーム
	{
		public short nOldRow = 0;

		public string s受付ＮＯ;
		public string s店所コード;

		private string[] s申込一覧;
		private int      i現在頁数;
		private int      i最大頁数;
		private int      i開始数;
		private int      i終了数;
//		private int      iアクティブＦＧ = 0;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btn確定;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn検索;
		private AxGTABLE32V2Lib.AxGTable32 axGT会員;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private System.Windows.Forms.Label lab受付ＮＯ;
		private System.Windows.Forms.Label lab申込者名;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.共通テキストボックス tex店所コード;
		private System.Windows.Forms.Label label2;
		private is2AdminClient.共通テキストボックス tex申込者カナ;
		private is2AdminClient.共通テキストボックス tex受付ＮＯ;
		private is2AdminClient.共通テキストボックス tex申込者名;
		private System.Windows.Forms.Label lab受付ＮＯ検索;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 加入検索()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent 呼び出しの後に、コンストラクタ コードを追加してください。
			//
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
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

		#region Windows フォーム デザイナで生成されたコード 
		/// <summary>
		/// デザイナ サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディタで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(加入検索));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab頁番号 = new System.Windows.Forms.Label();
			this.btn次頁 = new System.Windows.Forms.Button();
			this.btn前頁 = new System.Windows.Forms.Button();
			this.axGT会員 = new AxGTABLE32V2Lib.AxGTable32();
			this.btn確定 = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab受付ＮＯ検索 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texメッセージ = new is2AdminClient.共通テキストボックス();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tex申込者カナ = new is2AdminClient.共通テキストボックス();
			this.tex店所コード = new is2AdminClient.共通テキストボックス();
			this.tex受付ＮＯ = new is2AdminClient.共通テキストボックス();
			this.lab受付ＮＯ = new System.Windows.Forms.Label();
			this.lab申込者名 = new System.Windows.Forms.Label();
			this.tex申込者名 = new is2AdminClient.共通テキストボックス();
			this.btn検索 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT会員)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel5.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.lab頁番号);
			this.panel1.Controls.Add(this.btn次頁);
			this.panel1.Controls.Add(this.btn前頁);
			this.panel1.Controls.Add(this.axGT会員);
			this.panel1.Controls.Add(this.btn確定);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 348);
			this.panel1.TabIndex = 0;
			// 
			// lab頁番号
			// 
			this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab頁番号.ForeColor = System.Drawing.Color.Green;
			this.lab頁番号.Location = new System.Drawing.Point(220, 292);
			this.lab頁番号.Name = "lab頁番号";
			this.lab頁番号.Size = new System.Drawing.Size(58, 14);
			this.lab頁番号.TabIndex = 76;
			this.lab頁番号.Text = "999 / 999";
			this.lab頁番号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn次頁
			// 
			this.btn次頁.BackColor = System.Drawing.Color.SteelBlue;
			this.btn次頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn次頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn次頁.ForeColor = System.Drawing.Color.White;
			this.btn次頁.Location = new System.Drawing.Point(278, 288);
			this.btn次頁.Name = "btn次頁";
			this.btn次頁.Size = new System.Drawing.Size(48, 22);
			this.btn次頁.TabIndex = 2;
			this.btn次頁.TabStop = false;
			this.btn次頁.Text = "次頁";
			this.btn次頁.Click += new System.EventHandler(this.btn次頁_Click);
			// 
			// btn前頁
			// 
			this.btn前頁.BackColor = System.Drawing.Color.SteelBlue;
			this.btn前頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn前頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn前頁.ForeColor = System.Drawing.Color.White;
			this.btn前頁.Location = new System.Drawing.Point(172, 288);
			this.btn前頁.Name = "btn前頁";
			this.btn前頁.Size = new System.Drawing.Size(48, 22);
			this.btn前頁.TabIndex = 1;
			this.btn前頁.TabStop = false;
			this.btn前頁.Text = "前頁";
			this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
			// 
			// axGT会員
			// 
			this.axGT会員.ContainingControl = this;
			this.axGT会員.DataSource = null;
			this.axGT会員.Location = new System.Drawing.Point(8, 8);
			this.axGT会員.Name = "axGT会員";
			this.axGT会員.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT会員.OcxState")));
			this.axGT会員.Size = new System.Drawing.Size(357, 271);
			this.axGT会員.TabIndex = 0;
			this.axGT会員.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT会員_KeyDownEvent);
			this.axGT会員.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT会員_CelDblClick);
			this.axGT会員.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT会員_CurPlaceChanged);
			// 
			// btn確定
			// 
			this.btn確定.BackColor = System.Drawing.Color.Blue;
			this.btn確定.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn確定.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn確定.ForeColor = System.Drawing.Color.White;
			this.btn確定.Location = new System.Drawing.Point(302, 318);
			this.btn確定.Name = "btn確定";
			this.btn確定.Size = new System.Drawing.Size(64, 22);
			this.btn確定.TabIndex = 3;
			this.btn確定.Text = "確定";
			this.btn確定.Click += new System.EventHandler(this.btn確定_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab受付ＮＯ検索);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab受付ＮＯ検索
			// 
			this.lab受付ＮＯ検索.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab受付ＮＯ検索.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab受付ＮＯ検索.ForeColor = System.Drawing.Color.White;
			this.lab受付ＮＯ検索.Location = new System.Drawing.Point(12, 2);
			this.lab受付ＮＯ検索.Name = "lab受付ＮＯ検索";
			this.lab受付ＮＯ検索.Size = new System.Drawing.Size(264, 24);
			this.lab受付ＮＯ検索.TabIndex = 0;
			this.lab受付ＮＯ検索.Text = "受付ＮＯ検索";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(388, 58);
			this.panel8.TabIndex = 2;
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(68, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(314, 50);
			this.texメッセージ.TabIndex = 6;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
			// 
			// btn閉じる
			// 
			this.btn閉じる.ForeColor = System.Drawing.Color.Red;
			this.btn閉じる.Location = new System.Drawing.Point(8, 6);
			this.btn閉じる.Name = "btn閉じる";
			this.btn閉じる.Size = new System.Drawing.Size(54, 48);
			this.btn閉じる.TabIndex = 5;
			this.btn閉じる.TabStop = false;
			this.btn閉じる.Text = "閉じる";
			this.btn閉じる.Click += new System.EventHandler(this.btn閉じる_Click);
			// 
			// button13
			// 
			this.button13.Location = new System.Drawing.Point(0, 0);
			this.button13.Name = "button13";
			this.button13.TabIndex = 0;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(0, 0);
			this.button12.Name = "button12";
			this.button12.TabIndex = 0;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(396, 26);
			this.panel6.TabIndex = 15;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Honeydew;
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.tex申込者カナ);
			this.panel5.Controls.Add(this.tex店所コード);
			this.panel5.Controls.Add(this.tex受付ＮＯ);
			this.panel5.Controls.Add(this.lab受付ＮＯ);
			this.panel5.Controls.Add(this.lab申込者名);
			this.panel5.Controls.Add(this.tex申込者名);
			this.panel5.Controls.Add(this.btn検索);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(373, 90);
			this.panel5.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(192, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 16);
			this.label2.TabIndex = 50;
			this.label2.Text = "店所コード";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.LimeGreen;
			this.label1.Location = new System.Drawing.Point(20, 64);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(54, 16);
			this.label1.TabIndex = 49;
			this.label1.Text = "フリガナ";
			// 
			// tex申込者カナ
			// 
			this.tex申込者カナ.BackColor = System.Drawing.SystemColors.Window;
			this.tex申込者カナ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者カナ.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex申込者カナ.Location = new System.Drawing.Point(74, 60);
			this.tex申込者カナ.MaxLength = 20;
			this.tex申込者カナ.Name = "tex申込者カナ";
			this.tex申込者カナ.Size = new System.Drawing.Size(230, 23);
			this.tex申込者カナ.TabIndex = 3;
			this.tex申込者カナ.Text = "";
			this.tex申込者カナ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex申込者カナ_KeyDown);
			// 
			// tex店所コード
			// 
			this.tex店所コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex店所コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex店所コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex店所コード.Location = new System.Drawing.Point(268, 8);
			this.tex店所コード.MaxLength = 3;
			this.tex店所コード.Name = "tex店所コード";
			this.tex店所コード.Size = new System.Drawing.Size(36, 23);
			this.tex店所コード.TabIndex = 1;
			this.tex店所コード.Text = "";
			// 
			// tex受付ＮＯ
			// 
			this.tex受付ＮＯ.BackColor = System.Drawing.SystemColors.Window;
			this.tex受付ＮＯ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex受付ＮＯ.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex受付ＮＯ.Location = new System.Drawing.Point(74, 8);
			this.tex受付ＮＯ.MaxLength = 7;
			this.tex受付ＮＯ.Name = "tex受付ＮＯ";
			this.tex受付ＮＯ.Size = new System.Drawing.Size(72, 23);
			this.tex受付ＮＯ.TabIndex = 0;
			this.tex受付ＮＯ.Text = "";
			// 
			// lab受付ＮＯ
			// 
			this.lab受付ＮＯ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab受付ＮＯ.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab受付ＮＯ.Location = new System.Drawing.Point(8, 12);
			this.lab受付ＮＯ.Name = "lab受付ＮＯ";
			this.lab受付ＮＯ.Size = new System.Drawing.Size(66, 16);
			this.lab受付ＮＯ.TabIndex = 46;
			this.lab受付ＮＯ.Text = "受付ＮＯ";
			// 
			// lab申込者名
			// 
			this.lab申込者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab申込者名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab申込者名.Location = new System.Drawing.Point(2, 38);
			this.lab申込者名.Name = "lab申込者名";
			this.lab申込者名.Size = new System.Drawing.Size(72, 16);
			this.lab申込者名.TabIndex = 6;
			this.lab申込者名.Text = "申込者名";
			// 
			// tex申込者名
			// 
			this.tex申込者名.BackColor = System.Drawing.SystemColors.Window;
			this.tex申込者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex申込者名.Location = new System.Drawing.Point(74, 34);
			this.tex申込者名.MaxLength = 20;
			this.tex申込者名.Name = "tex申込者名";
			this.tex申込者名.Size = new System.Drawing.Size(230, 23);
			this.tex申込者名.TabIndex = 2;
			this.tex申込者名.Text = "";
			// 
			// btn検索
			// 
			this.btn検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn検索.ForeColor = System.Drawing.Color.White;
			this.btn検索.Location = new System.Drawing.Point(306, 60);
			this.btn検索.Name = "btn検索";
			this.btn検索.Size = new System.Drawing.Size(64, 22);
			this.btn検索.TabIndex = 4;
			this.btn検索.TabStop = false;
			this.btn検索.Text = "検索";
			this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Location = new System.Drawing.Point(7, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 98);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(7, 152);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 356);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// 加入検索
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
			this.Name = "加入検索";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 受付ＮＯ検索";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.加入検索_Closed);
			this.Activated += new System.EventHandler(this.加入検索_Activated);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT会員)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>

		private void Form1_Load(object sender, System.EventArgs e)
		{
//			iアクティブＦＧ = 0;
			tex店所コード.Text = s店所コード;
			if(s店所コード.Length > 0) tex店所コード.Enabled = false;
			
			axGT会員.Cols = 4;
			axGT会員.Rows = 14;
			axGT会員.ColSep = "|";
			axGT会員.CaretRow = 1;
			axGT会員.NoBeep = true;
			
			axGT会員.set_RowsText(0, "|受付ＮＯ|お客様名|フリガナ||");

			axGT会員.ColsWidth = "0|4.6|12|9.4|0|";
			axGT会員.ColsAlignHorz = "1|1|0|0|0|";
//			axGT会員.set_CelForeColor(axGT会員.CaretRow,0,111111);
			axGT会員.set_CelForeColor(axGT会員.CaretRow,0,0x98FB98);  //BGR
			axGT会員.set_CelBackColor(axGT会員.CaretRow,0,0x006000);

			btn前頁.Enabled = false;
			btn次頁.Enabled = false;
			lab頁番号.Text = "";
			i現在頁数 = 1;

			axGT会員.CaretRow = 1;
			axGT会員_CurPlaceChanged(null,null);

			tex受付ＮＯ.Focus();
		}

		private void 桁数表示()
		{
			tex受付ＮＯ.Text = "1234567";
			tex店所コード.Text = "123";
			tex申込者名.Text = "全角１３";
			tex申込者カナ.Text = "全角１３";

			lab頁番号.Text = "999 / 999";
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			s受付ＮＯ = "";
			s店所コード   = "";
			this.Close();
		}

		private void axGT会員_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			s受付ＮＯ = axGT会員.get_CelText(axGT会員.CaretRow,1);
			s店所コード   = axGT会員.get_CelText(axGT会員.CaretRow,4);
			if(!s受付ＮＯ.Equals(""))
				this.Close();
		}

		private void axGT会員_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT会員.set_CelForeColor(nOldRow,0,0);
			axGT会員.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT会員.set_CelForeColor(axGT会員.CaretRow,0,111111);
			axGT会員.set_CelForeColor(axGT会員.CaretRow,0,0x98FB98);  //BGR
			axGT会員.set_CelBackColor(axGT会員.CaretRow,0,0x006000);
			nOldRow = axGT会員.CaretRow;

		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			申込一覧検索();
		}

		private void btn確定_Click(object sender, System.EventArgs e)
		{
			s受付ＮＯ = axGT会員.get_CelText(axGT会員.CaretRow,1);
			s店所コード   = axGT会員.get_CelText(axGT会員.CaretRow,4);
			if(!s受付ＮＯ.Equals(""))
				this.Close();
		}

		private void 申込一覧検索()
		{
//			iアクティブＦＧ = 1;
			//Ｔｒｉｍ
			tex受付ＮＯ.Text = tex受付ＮＯ.Text.Trim();
			tex店所コード.Text = tex店所コード.Text.Trim();
			tex申込者名.Text = tex申込者名.Text.Trim();
			tex申込者カナ.Text = tex申込者カナ.Text.Trim();
			//型チェック
			if(!半角チェック(tex受付ＮＯ, "受付ＮＯ")) return;
			if(!半角チェック(tex店所コード, "店所コード")) return;
			if(!全角チェック(tex申込者名, "申込者名")) return;
			if(!全角チェック(tex申込者カナ, "申込者カナ")) return;

			axGT会員.Clear();

			texメッセージ.Text = "検索中．．．";

			s申込一覧 = new string[1];
			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey  = new string[4]{"","","",""};
				sKey[0] = tex受付ＮＯ.Text;
				sKey[1] = tex店所コード.Text;
				sKey[2] = tex申込者名.Text;
				sKey[3] = tex申込者カナ.Text;
				s申込一覧 = sv_maintenance.Get_Mosikomi(gsaユーザ, sKey);
			}
			catch (System.Net.WebException)
			{
				s申込一覧[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				s申込一覧[0] = "通信エラー：" + ex.Message;
			}
			
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			if (s申込一覧[0].Equals("正常終了"))
			{
				texメッセージ.Text = "";
				i最大頁数 = (s申込一覧.Length - 2) / (axGT会員.Rows - 1) + 1;
				if (i現在頁数 > i最大頁数)
					i現在頁数 = i最大頁数;
				頁情報設定();

				//一行目選択
				axGT会員.CaretRow = 1;
				axGT会員_CurPlaceChanged(null,null);

				axGT会員.Focus();
			}
			else
			{
				if (s申込一覧[0].Equals("該当データがありません"))
				{
					texメッセージ.Text = "";
					MessageBox.Show("該当データがありません","受付ＮＯ検索",MessageBoxButtons.OK);
				}
				else
				{
					texメッセージ.Text = s申込一覧[0];
					i現在頁数 = 1;
					btn前頁.Enabled = false;
					btn次頁.Enabled = false;
					lab頁番号.Text = "";
					ビープ音();
				}
				tex受付ＮＯ.Focus();
			}
		}

		private void axGT会員_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				s受付ＮＯ = axGT会員.get_CelText(axGT会員.CaretRow,1);
				s店所コード   = axGT会員.get_CelText(axGT会員.CaretRow,4);
				if(!s受付ＮＯ.Equals(""))
					this.Close();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT会員, true, true, true, true);
			}
		}

		private void tex申込者カナ_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				申込一覧検索();
			}
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();

			axGT会員.CaretRow = 1;
			axGT会員_CurPlaceChanged(null,null);
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();

			axGT会員.CaretRow = 1;
			axGT会員_CurPlaceChanged(null,null);
		}

		private void 頁情報設定()
		{
			axGT会員.Clear();

			i開始数 = (i現在頁数 - 1) * (axGT会員.Rows - 1) + 1;
			i終了数 = i現在頁数 * (axGT会員.Rows - 1);

			short s表示数 = (short)2;
			for(short sCnt = (short)i開始数; sCnt < s申込一覧.Length && sCnt <= i終了数 ; sCnt++)
			{
				axGT会員.set_RowsText(s表示数, s申込一覧[sCnt]);
				s表示数++;
			}
			lab頁番号.Text = i現在頁数.ToString() + " / " + i最大頁数.ToString();
			if (i現在頁数 == 1)
				btn前頁.Enabled = false;
			else
				btn前頁.Enabled = true;
			if (i現在頁数 == i最大頁数)
				btn次頁.Enabled = false;
			else
				btn次頁.Enabled = true;
			axGT会員.Focus();
		}

		private void 加入検索_Activated(object sender, System.EventArgs e)
		{
//			if(iアクティブＦＧ == 0)
//				申込一覧検索();		
		}

		private void 加入検索_Closed(object sender, System.EventArgs e)
		{
			tex受付ＮＯ.Text = "";
			tex店所コード.Text = "";
			tex申込者名.Text = "";
			tex申込者カナ.Text = "";
			texメッセージ.Text = "";
			axGT会員.Clear();
			tex受付ＮＯ.Focus();
		}
	}
}
