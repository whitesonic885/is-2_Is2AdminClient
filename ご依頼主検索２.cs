// ADD 2007.11.14 KCL) 森本 [ご依頼主検索]フォームをコピーし、名前を[ご依頼主検索２]に変更（global対応） START
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [ご依頼主検索２]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 東都）高木 ご依頼主名の全角チェックの追加 
	//--------------------------------------------------------------------------
	// MOD 2009.05.11 東都）高木 未出荷対応 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	public class ご依頼主検索２ : 共通フォーム
	{
		private short nOldRow = 0;
		public string sIcode;     //ご依頼主ＣＤ
		public string sIname;     //ご依頼主名
		public string sBcode;     //部門ＣＤ
		public string sKcode;     //お客様ＣＤ
		public string sKname;     //お客様名
// MOD 2009.05.11 東都）高木 未出荷対応 START
		public string s店所コード;
// MOD 2009.05.11 東都）高木 未出荷対応 END

		private int      iアクティブＦＧ = 0;

		private string[] s依頼主一覧;
		private int      i現在頁数;
		private int      i最大頁数;
		private int      i開始数;
		private int      i終了数;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lab依頼主コード;
		private 共通テキストボックス tex依頼主コード;
		private System.Windows.Forms.Label lab依頼主タイトル;
		private System.Windows.Forms.Button btn確定;
		private System.Windows.Forms.Button btn検索;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private AxGTABLE32V2Lib.AxGTable32 axGT依頼主;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label labご依頼主名;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.共通テキストボックス texお客様コード;
		private System.Windows.Forms.Button btnお客様検索;
		private is2AdminClient.共通テキストボックス tex依頼主名;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ご依頼主検索２()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ご依頼主検索２));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab頁番号 = new System.Windows.Forms.Label();
			this.btn次頁 = new System.Windows.Forms.Button();
			this.btn前頁 = new System.Windows.Forms.Button();
			this.axGT依頼主 = new AxGTABLE32V2Lib.AxGTable32();
			this.btn確定 = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnお客様検索 = new System.Windows.Forms.Button();
			this.texお客様コード = new is2AdminClient.共通テキストボックス();
			this.label1 = new System.Windows.Forms.Label();
			this.tex依頼主名 = new is2AdminClient.共通テキストボックス();
			this.labご依頼主名 = new System.Windows.Forms.Label();
			this.lab依頼主コード = new System.Windows.Forms.Label();
			this.tex依頼主コード = new is2AdminClient.共通テキストボックス();
			this.btn検索 = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab依頼主タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT依頼主)).BeginInit();
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
			this.panel1.Controls.Add(this.lab頁番号);
			this.panel1.Controls.Add(this.btn次頁);
			this.panel1.Controls.Add(this.btn前頁);
			this.panel1.Controls.Add(this.axGT依頼主);
			this.panel1.Controls.Add(this.btn確定);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(741, 350);
			this.panel1.TabIndex = 1;
			// 
			// lab頁番号
			// 
			this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab頁番号.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab頁番号.Location = new System.Drawing.Point(606, 294);
			this.lab頁番号.Name = "lab頁番号";
			this.lab頁番号.Size = new System.Drawing.Size(48, 14);
			this.lab頁番号.TabIndex = 70;
			this.lab頁番号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn次頁
			// 
			this.btn次頁.BackColor = System.Drawing.Color.SteelBlue;
			this.btn次頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn次頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn次頁.ForeColor = System.Drawing.Color.White;
			this.btn次頁.Location = new System.Drawing.Point(654, 290);
			this.btn次頁.Name = "btn次頁";
			this.btn次頁.Size = new System.Drawing.Size(48, 22);
			this.btn次頁.TabIndex = 69;
			this.btn次頁.Text = "次頁";
			this.btn次頁.Click += new System.EventHandler(this.btn次頁_Click);
			// 
			// btn前頁
			// 
			this.btn前頁.BackColor = System.Drawing.Color.SteelBlue;
			this.btn前頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn前頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn前頁.ForeColor = System.Drawing.Color.White;
			this.btn前頁.Location = new System.Drawing.Point(558, 290);
			this.btn前頁.Name = "btn前頁";
			this.btn前頁.Size = new System.Drawing.Size(48, 22);
			this.btn前頁.TabIndex = 68;
			this.btn前頁.Text = "前頁";
			this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
			// 
			// axGT依頼主
			// 
			this.axGT依頼主.ContainingControl = this;
			this.axGT依頼主.DataSource = null;
			this.axGT依頼主.Location = new System.Drawing.Point(20, 8);
			this.axGT依頼主.Name = "axGT依頼主";
			this.axGT依頼主.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT依頼主.OcxState")));
			this.axGT依頼主.Size = new System.Drawing.Size(700, 271);
			this.axGT依頼主.TabIndex = 2;
			this.axGT依頼主.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT依頼主_KeyDownEvent);
			this.axGT依頼主.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT依頼主_CelDblClick);
			this.axGT依頼主.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT依頼主_CurPlaceChanged);
			// 
			// btn確定
			// 
			this.btn確定.BackColor = System.Drawing.Color.SteelBlue;
			this.btn確定.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn確定.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn確定.ForeColor = System.Drawing.Color.White;
			this.btn確定.Location = new System.Drawing.Point(652, 320);
			this.btn確定.Name = "btn確定";
			this.btn確定.Size = new System.Drawing.Size(64, 22);
			this.btn確定.TabIndex = 1;
			this.btn確定.TabStop = false;
			this.btn確定.Text = "確定";
			this.btn確定.Click += new System.EventHandler(this.btn確定_Click);
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Honeydew;
			this.panel5.Controls.Add(this.btnお客様検索);
			this.panel5.Controls.Add(this.texお客様コード);
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.tex依頼主名);
			this.panel5.Controls.Add(this.labご依頼主名);
			this.panel5.Controls.Add(this.lab依頼主コード);
			this.panel5.Controls.Add(this.tex依頼主コード);
			this.panel5.Controls.Add(this.btn検索);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(435, 82);
			this.panel5.TabIndex = 0;
			// 
			// btnお客様検索
			// 
			this.btnお客様検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btnお客様検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnお客様検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnお客様検索.ForeColor = System.Drawing.Color.White;
			this.btnお客様検索.Location = new System.Drawing.Point(228, 4);
			this.btnお客様検索.Name = "btnお客様検索";
			this.btnお客様検索.Size = new System.Drawing.Size(64, 22);
			this.btnお客様検索.TabIndex = 49;
			this.btnお客様検索.TabStop = false;
			this.btnお客様検索.Text = "検索";
			this.btnお客様検索.Click += new System.EventHandler(this.btnお客様検索_Click);
			// 
			// texお客様コード
			// 
			this.texお客様コード.BackColor = System.Drawing.SystemColors.Window;
			this.texお客様コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texお客様コード.ImeMode = System.Windows.Forms.ImeMode.Off;
			this.texお客様コード.Location = new System.Drawing.Point(118, 2);
			this.texお客様コード.MaxLength = 10;
			this.texお客様コード.Name = "texお客様コード";
			this.texお客様コード.Size = new System.Drawing.Size(104, 23);
			this.texお客様コード.TabIndex = 0;
			this.texお客様コード.Text = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.LimeGreen;
			this.label1.Location = new System.Drawing.Point(8, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 16);
			this.label1.TabIndex = 47;
			this.label1.Text = "お客様コード";
			// 
			// tex依頼主名
			// 
			this.tex依頼主名.BackColor = System.Drawing.SystemColors.Window;
			this.tex依頼主名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex依頼主名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex依頼主名.Location = new System.Drawing.Point(118, 28);
			this.tex依頼主名.MaxLength = 10;
			this.tex依頼主名.Name = "tex依頼主名";
			this.tex依頼主名.Size = new System.Drawing.Size(174, 23);
			this.tex依頼主名.TabIndex = 1;
			this.tex依頼主名.Text = "";
			// 
			// labご依頼主名
			// 
			this.labご依頼主名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labご依頼主名.ForeColor = System.Drawing.Color.LimeGreen;
			this.labご依頼主名.Location = new System.Drawing.Point(8, 32);
			this.labご依頼主名.Name = "labご依頼主名";
			this.labご依頼主名.Size = new System.Drawing.Size(110, 16);
			this.labご依頼主名.TabIndex = 46;
			this.labご依頼主名.Text = "ご依頼主名";
			// 
			// lab依頼主コード
			// 
			this.lab依頼主コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab依頼主コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab依頼主コード.Location = new System.Drawing.Point(8, 58);
			this.lab依頼主コード.Name = "lab依頼主コード";
			this.lab依頼主コード.Size = new System.Drawing.Size(110, 16);
			this.lab依頼主コード.TabIndex = 6;
			this.lab依頼主コード.Text = "ご依頼主コード";
			// 
			// tex依頼主コード
			// 
			this.tex依頼主コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex依頼主コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex依頼主コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex依頼主コード.Location = new System.Drawing.Point(118, 54);
			this.tex依頼主コード.MaxLength = 12;
			this.tex依頼主コード.Name = "tex依頼主コード";
			this.tex依頼主コード.Size = new System.Drawing.Size(174, 23);
			this.tex依頼主コード.TabIndex = 2;
			this.tex依頼主コード.Text = "";
			this.tex依頼主コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex依頼主コード_KeyDown);
			// 
			// btn検索
			// 
			this.btn検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn検索.ForeColor = System.Drawing.Color.White;
			this.btn検索.Location = new System.Drawing.Point(358, 56);
			this.btn検索.Name = "btn検索";
			this.btn検索.Size = new System.Drawing.Size(64, 22);
			this.btn検索.TabIndex = 2;
			this.btn検索.TabStop = false;
			this.btn検索.Text = "検索";
			this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab依頼主タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(794, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab依頼主タイトル
			// 
			this.lab依頼主タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab依頼主タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab依頼主タイトル.ForeColor = System.Drawing.Color.White;
			this.lab依頼主タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab依頼主タイトル.Name = "lab依頼主タイトル";
			this.lab依頼主タイトル.Size = new System.Drawing.Size(264, 24);
			this.lab依頼主タイトル.TabIndex = 0;
			this.lab依頼主タイトル.Text = "ご依頼主検索２";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 518);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(794, 58);
			this.panel8.TabIndex = 2;
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(416, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(376, 50);
			this.texメッセージ.TabIndex = 1;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
			// 
			// btn閉じる
			// 
			this.btn閉じる.ForeColor = System.Drawing.Color.Red;
			this.btn閉じる.Location = new System.Drawing.Point(8, 6);
			this.btn閉じる.Name = "btn閉じる";
			this.btn閉じる.Size = new System.Drawing.Size(54, 48);
			this.btn閉じる.TabIndex = 0;
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
			this.panel6.Size = new System.Drawing.Size(794, 26);
			this.panel6.TabIndex = 15;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Location = new System.Drawing.Point(26, 56);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(438, 92);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(26, 154);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(744, 358);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// ご依頼主検索２
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 574);
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
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "ご依頼主検索２";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 ご依頼主検索２";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.ご依頼主検索２_Closed);
			this.Activated += new System.EventHandler(this.ご依頼主検索２_Activated);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT依頼主)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
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
			iアクティブＦＧ = 0;

			texお客様コード.Text = sKcode;
			tex依頼主コード.Text = sIcode;
			sKcode = "";
			sIcode = "";

			axGT依頼主.Cols = 7;
			axGT依頼主.Rows = 14;
			axGT依頼主.ColSep = "|";

			axGT依頼主.set_RowsText(0, "|お客様コード|お客様名|部門名|ご依頼主コード|ご依頼主名|住所|部門ＣＤ|");

			axGT依頼主.ColsWidth = "0|7.8|7.4|7.4|8.7|10.2|12.4|0|";
			axGT依頼主.ColsAlignHorz = "1|0|0|0|0|0|0|0|";

			axGT依頼主.set_CelForeColor(axGT依頼主.CaretRow,0,0x98FB98);  //BGR
			axGT依頼主.set_CelBackColor(axGT依頼主.CaretRow,0,0x006000);

			btn前頁.Enabled = false;
			btn次頁.Enabled = false;
			lab頁番号.Text = "";

			if(tex依頼主コード.Text.Trim().Length != 0 || texお客様コード.Text.Trim().Length != 0)
				btn検索_Click(sender,e);
		}

		private void 桁数表示()
		{
			tex依頼主名.Text = "ＯＯ商店５６７８９０";
			tex依頼主コード.Text = "084931XXXX";

			axGT依頼主.Clear();
			axGT依頼主.set_RowsText(2, "|1234567890|営業本部|サポートセンター　テスト用|0849318141 |ＯＯ商店５６７８９０|広島県福山市東桜町１－２|");
			axGT依頼主.set_RowsText(3, "|WWWWWWWWWW|会員名４５６７８９０１２３４５６７８９０|部門名４５６７８９０１２３４５６７８９０|IRAINUSICD12|ご依頼主名６７８９０１２３４５６７８９０|ご依頼主住所７８９０１２３４５６７８９０|");
			axGT依頼主.set_RowsText(4, "|MMMMMMMMMM|国国国国王国国国国王国国国国王国国国国王|国国国国王国国国国王国国国国王国国国国王|WWWWWWWWWWWW|国国国国王国国国国王国国国国王国国国国王|国国国国王国国国国王国国国国王国国国国王|");

			btn前頁.Enabled = true;
			btn次頁.Enabled = true;
			lab頁番号.Text = " 1 / 99"; // (293-1) / 13
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			sKcode = "";
			sKname = "";
			sIcode = "";
			sIname = "";
			sBcode = "";
			this.Close();
		}

		private void axGT依頼主_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			sKcode = axGT依頼主.get_CelText(axGT依頼主.CaretRow,1);
			sKname = axGT依頼主.get_CelText(axGT依頼主.CaretRow,2);
			sIcode = axGT依頼主.get_CelText(axGT依頼主.CaretRow,4);
			sIname = axGT依頼主.get_CelText(axGT依頼主.CaretRow,5);
			sBcode = axGT依頼主.get_CelText(axGT依頼主.CaretRow,7);
			if(sIcode != "")
				this.Close();

		}

		private void axGT依頼主_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT依頼主.set_CelForeColor(nOldRow,0,0);
			axGT依頼主.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT依頼主.set_CelForeColor(axGT依頼主.CaretRow,0,0x98FB98);  //BGR
			axGT依頼主.set_CelBackColor(axGT依頼主.CaretRow,0,0x006000);
			nOldRow = axGT依頼主.CaretRow;

		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			iアクティブＦＧ = 1;

			axGT依頼主.CaretRow  = 1;
			axGT依頼主_CurPlaceChanged(null,null);
			axGT依頼主.Clear();
			// 空白除去
			texお客様コード.Text   = texお客様コード.Text.Trim();
			tex依頼主名.Text     = tex依頼主名.Text.Trim();
			tex依頼主コード.Text   = tex依頼主コード.Text.Trim();

			if(texお客様コード.Text.Length == 0 &&
				tex依頼主名.Text.Length == 0 &&
				tex依頼主コード.Text.Length == 0)
			{
				MessageBox.Show("検索条件を入力してください。","ご依頼主検索",MessageBoxButtons.OK);
				texお客様コード.Focus();
				return;
			}

			if(!半角チェック(texお客様コード,"お客様コード")) return;
// ADD 2008.05.07 東都）高木 ご依頼主名の全角チェックの追加 START
			if(!全角チェック(tex依頼主名, "ご依頼主名")) return;
// ADD 2008.05.07 東都）高木 ご依頼主名の全角チェックの追加 END
			if(!半角チェック(tex依頼主コード,"ご依頼主コード")) return;

			i現在頁数 = 1;
			axGT依頼主.CaretRow = 1;
			axGT依頼主.set_CelForeColor(nOldRow,0,0);
			axGT依頼主.set_CelForeColor(axGT依頼主.CaretRow,0,0x98FB98);  //BGR
			axGT依頼主.set_CelBackColor(axGT依頼主.CaretRow,0,0x006000);
			nOldRow = axGT依頼主.CaretRow;

			s依頼主一覧 = new string[1];

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey  = new string[4];
				sKey[0] = texお客様コード.Text;
				sKey[1] = tex依頼主コード.Text;
				sKey[2] = tex依頼主名.Text;
// MOD 2009.05.11 東都）高木 未出荷対応 START
//				sKey[3] = gs店所コード.Trim();
				sKey[3] = s店所コード.Trim();
// MOD 2009.05.11 東都）高木 未出荷対応 END
				texメッセージ.Text = "検索中．．．";

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
				if (sKey[0].Substring(0,1) != "J")
				{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

					if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
					s依頼主一覧 = sv_maintenance.Get_Goirainusi2(gsaユーザ,sKey);

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
				}
				else
				{
					if(sv_oji == null) sv_oji = new is2oji.Service1();
					s依頼主一覧 = sv_oji.Get_Goirainusi2(gsaユーザ,sKey);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

			}
			catch (System.Net.WebException)
			{
				s依頼主一覧[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				s依頼主一覧[0] = "通信エラー：" + ex.Message;
			}
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			texメッセージ.Text = s依頼主一覧[0];
			if(s依頼主一覧[0].Length == 4)
			{
				texメッセージ.Text = "";
				i最大頁数 = (s依頼主一覧.Length - 2) / (axGT依頼主.Rows - 1) + 1;
				if (i現在頁数 > i最大頁数)
					i現在頁数 = i最大頁数;
				頁情報設定();
			}
			else
			{
				if(s依頼主一覧[0].Equals("該当データがありません"))
				{
					texメッセージ.Text = "";
					MessageBox.Show("該当データがありません","ご依頼主検索",MessageBoxButtons.OK);
				}
				else
				{
					axGT依頼主.Clear();
					i現在頁数 = 1;
					btn前頁.Enabled = false;
					btn次頁.Enabled = false;
					lab頁番号.Text = "";
					ビープ音();
				}
				texお客様コード.Focus();
			}
		}

		private void btn確定_Click(object sender, System.EventArgs e)
		{
			sKcode = axGT依頼主.get_CelText(axGT依頼主.CaretRow,1);
			sKname = axGT依頼主.get_CelText(axGT依頼主.CaretRow,2);
			sIcode = axGT依頼主.get_CelText(axGT依頼主.CaretRow,4);
			sIname = axGT依頼主.get_CelText(axGT依頼主.CaretRow,5);
			sBcode = axGT依頼主.get_CelText(axGT依頼主.CaretRow,7);
			if(sIcode != "")
				this.Close();

		}

		private void axGT依頼主_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 13)
			{
				btn確定_Click(sender, null);
			}
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT依頼主, true, true, true, true);
			}
		}

		private void tex依頼主コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btn検索_Click(sender, e);
			}
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();
			axGT依頼主.CaretRow = 1;
			axGT依頼主_CurPlaceChanged(null,null);
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();
			axGT依頼主.CaretRow = 1;
			axGT依頼主_CurPlaceChanged(null,null);
		}

		private void 頁情報設定()
		{
			axGT依頼主.Clear();

			i開始数 = (i現在頁数 - 1) * (axGT依頼主.Rows - 1) + 1;
			i終了数 = i現在頁数 * (axGT依頼主.Rows - 1);

			short s表示数 = (short)2;
			for(short sCnt = (short)i開始数; sCnt < s依頼主一覧.Length && sCnt <= i終了数 ; sCnt++)
			{
				axGT依頼主.set_RowsText(s表示数, s依頼主一覧[sCnt]);
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
			axGT依頼主.Focus();
		}

		private void ご依頼主検索２_Activated(object sender, System.EventArgs e)
		{

			if((tex依頼主コード.Text.Trim().Length != 0 || texお客様コード.Text.Trim().Length != 0)
				&& iアクティブＦＧ == 0)
				btn検索_Click(sender,e);
		}

		private void ご依頼主検索２_Closed(object sender, System.EventArgs e)
		{
			texお客様コード.Text = "";
			tex依頼主名.Text   = " ";
			tex依頼主コード.Text = "";
			texメッセージ.Text = "";
			axGT依頼主.Clear();
			axGT依頼主.CaretRow  = 1;
			axGT依頼主_CurPlaceChanged(null,null);
			texお客様コード.Focus();
		}

		private void btnお客様検索_Click(object sender, System.EventArgs e)
		{
			texお客様コード.Text = texお客様コード.Text.Trim();
			if(!半角チェック(texお客様コード, "お客様コード")) return;

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g会員検２ == null)	 g会員検２ = new 会員検索２();
			g会員検２.Left = this.Left + 404;
			g会員検２.Top = this.Top;
			g会員検２.s会員コード = "";
			g会員検２.s会員名 = "";
			g会員検２.s店所コード = gs店所コード.Trim();
			g会員検２.ShowDialog();
			g会員検２.s店所コード = "";
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if (g会員検２.s会員コード.Trim().Length != 0)
			{
				texお客様コード.Text = g会員検２.s会員コード;
			}
			else
			{
				texお客様コード.Focus();
			}
		}

	}
}
// ADD 2007.11.14 KCL) 森本 [ご依頼主検索]フォームをコピーし、名前を[ご依頼主検索２]に変更（global対応） END
