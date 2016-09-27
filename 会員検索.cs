using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [お客様検索]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 東都）高木 お客様名の全角チェックの追加 
	//--------------------------------------------------------------------------
	// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	public class 会員検索 : 共通フォーム
	{
		public short nOldRow = 0;
		public string s会員コード;
		public string s会員名;
// ADD 2007.01.18 東都）高木 画面レイアウト変更 START
		public string s店所コード = "";
// ADD 2007.01.18 東都）高木 画面レイアウト変更 END
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
		public bool b運用中のお客様のみ = false;
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END

		private string[] s会員一覧;
		private int      i現在頁数;
		private int      i最大頁数;
		private int      i開始数;
		private int      i終了数;
		private int      iアクティブＦＧ = 0;
// ADD 2006.12.18 東都）小童谷 明細の余白を除去 START
		private int      i頁最大行数 = 100;
// ADD 2006.12.18 東都）小童谷 明細の余白を除去 END

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btn確定;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label lab会員タイトル;
		private System.Windows.Forms.Panel panel5;
		private 共通テキストボックス tex会員コード;
		private System.Windows.Forms.Label lab会員コード;
		private System.Windows.Forms.Label lab会員名;
		private 共通テキストボックス tex会員名;
		private System.Windows.Forms.Button btn検索;
		private AxGTABLE32V2Lib.AxGTable32 axGT会員;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private System.Windows.Forms.Label lab使用停止中;
		private System.Windows.Forms.Label lab使用停止中色;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 会員検索()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(会員検索));
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab使用停止中色 = new System.Windows.Forms.Label();
			this.lab使用停止中 = new System.Windows.Forms.Label();
			this.lab頁番号 = new System.Windows.Forms.Label();
			this.btn次頁 = new System.Windows.Forms.Button();
			this.btn前頁 = new System.Windows.Forms.Button();
			this.axGT会員 = new AxGTABLE32V2Lib.AxGTable32();
			this.btn確定 = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab会員タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texメッセージ = new is2AdminClient.共通テキストボックス();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.tex会員コード = new is2AdminClient.共通テキストボックス();
			this.lab会員コード = new System.Windows.Forms.Label();
			this.lab会員名 = new System.Windows.Forms.Label();
			this.tex会員名 = new is2AdminClient.共通テキストボックス();
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
			this.panel1.Controls.Add(this.lab使用停止中色);
			this.panel1.Controls.Add(this.lab使用停止中);
			this.panel1.Controls.Add(this.lab頁番号);
			this.panel1.Controls.Add(this.btn次頁);
			this.panel1.Controls.Add(this.btn前頁);
			this.panel1.Controls.Add(this.axGT会員);
			this.panel1.Controls.Add(this.btn確定);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 380);
			this.panel1.TabIndex = 0;
			// 
			// lab使用停止中色
			// 
			this.lab使用停止中色.BackColor = System.Drawing.Color.Silver;
			this.lab使用停止中色.Location = new System.Drawing.Point(6, 350);
			this.lab使用停止中色.Name = "lab使用停止中色";
			this.lab使用停止中色.Size = new System.Drawing.Size(28, 22);
			this.lab使用停止中色.TabIndex = 78;
			this.lab使用停止中色.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lab使用停止中
			// 
			this.lab使用停止中.Location = new System.Drawing.Point(36, 350);
			this.lab使用停止中.Name = "lab使用停止中";
			this.lab使用停止中.Size = new System.Drawing.Size(76, 22);
			this.lab使用停止中.TabIndex = 77;
			this.lab使用停止中.Text = "：使用停止中";
			this.lab使用停止中.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lab頁番号
			// 
			this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab頁番号.ForeColor = System.Drawing.Color.Green;
			this.lab頁番号.Location = new System.Drawing.Point(222, 316);
			this.lab頁番号.Name = "lab頁番号";
			this.lab頁番号.Size = new System.Drawing.Size(56, 14);
			this.lab頁番号.TabIndex = 76;
			this.lab頁番号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn次頁
			// 
			this.btn次頁.BackColor = System.Drawing.Color.SteelBlue;
			this.btn次頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn次頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn次頁.ForeColor = System.Drawing.Color.White;
			this.btn次頁.Location = new System.Drawing.Point(280, 312);
			this.btn次頁.Name = "btn次頁";
			this.btn次頁.Size = new System.Drawing.Size(48, 22);
			this.btn次頁.TabIndex = 75;
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
			this.btn前頁.Location = new System.Drawing.Point(172, 312);
			this.btn前頁.Name = "btn前頁";
			this.btn前頁.Size = new System.Drawing.Size(48, 22);
			this.btn前頁.TabIndex = 74;
			this.btn前頁.TabStop = false;
			this.btn前頁.Text = "前頁";
			this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
			// 
			// axGT会員
			// 
			this.axGT会員.ContainingControl = this;
			this.axGT会員.DataSource = null;
			this.axGT会員.Location = new System.Drawing.Point(6, 16);
			this.axGT会員.Name = "axGT会員";
			this.axGT会員.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT会員.OcxState")));
			this.axGT会員.Size = new System.Drawing.Size(364, 289);
			this.axGT会員.TabIndex = 3;
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
			this.btn確定.Location = new System.Drawing.Point(302, 350);
			this.btn確定.Name = "btn確定";
			this.btn確定.Size = new System.Drawing.Size(64, 22);
			this.btn確定.TabIndex = 4;
			this.btn確定.Text = "確定";
			this.btn確定.Click += new System.EventHandler(this.btn確定_Click);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab会員タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab会員タイトル
			// 
			this.lab会員タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab会員タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab会員タイトル.ForeColor = System.Drawing.Color.White;
			this.lab会員タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab会員タイトル.Name = "lab会員タイトル";
			this.lab会員タイトル.Size = new System.Drawing.Size(264, 24);
			this.lab会員タイトル.TabIndex = 0;
			this.lab会員タイトル.Text = "お客様検索";
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
			this.panel5.Controls.Add(this.tex会員コード);
			this.panel5.Controls.Add(this.lab会員コード);
			this.panel5.Controls.Add(this.lab会員名);
			this.panel5.Controls.Add(this.tex会員名);
			this.panel5.Controls.Add(this.btn検索);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(373, 60);
			this.panel5.TabIndex = 3;
			// 
			// tex会員コード
			// 
			this.tex会員コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex会員コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex会員コード.Location = new System.Drawing.Point(74, 6);
			this.tex会員コード.MaxLength = 10;
			this.tex会員コード.Name = "tex会員コード";
			this.tex会員コード.Size = new System.Drawing.Size(140, 23);
			this.tex会員コード.TabIndex = 0;
			this.tex会員コード.Text = "";
			// 
			// lab会員コード
			// 
			this.lab会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab会員コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab会員コード.Location = new System.Drawing.Point(4, 10);
			this.lab会員コード.Name = "lab会員コード";
			this.lab会員コード.Size = new System.Drawing.Size(58, 16);
			this.lab会員コード.TabIndex = 46;
			this.lab会員コード.Text = "コード";
			// 
			// lab会員名
			// 
			this.lab会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab会員名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab会員名.Location = new System.Drawing.Point(4, 34);
			this.lab会員名.Name = "lab会員名";
			this.lab会員名.Size = new System.Drawing.Size(70, 16);
			this.lab会員名.TabIndex = 6;
			this.lab会員名.Text = "お客様名";
			// 
			// tex会員名
			// 
			this.tex会員名.BackColor = System.Drawing.SystemColors.Window;
			this.tex会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex会員名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex会員名.Location = new System.Drawing.Point(74, 30);
			this.tex会員名.MaxLength = 20;
			this.tex会員名.Name = "tex会員名";
			this.tex会員名.Size = new System.Drawing.Size(228, 23);
			this.tex会員名.TabIndex = 1;
			this.tex会員名.Text = "";
			this.tex会員名.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex会員名_KeyDown);
			// 
			// btn検索
			// 
			this.btn検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn検索.ForeColor = System.Drawing.Color.White;
			this.btn検索.Location = new System.Drawing.Point(306, 32);
			this.btn検索.Name = "btn検索";
			this.btn検索.Size = new System.Drawing.Size(64, 22);
			this.btn検索.TabIndex = 2;
			this.btn検索.TabStop = false;
			this.btn検索.Text = "検索";
			this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel5);
			this.groupBox1.Location = new System.Drawing.Point(7, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(377, 68);
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
			// 会員検索
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
			this.Name = "会員検索";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 お客様検索";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Activated += new System.EventHandler(this.会員検索_Activated);
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
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
			if(b運用中のお客様のみ){
				lab使用停止中色.Visible = false;
				lab使用停止中.Visible = false;
			}else{
				lab使用停止中色.Visible = true;
				lab使用停止中.Visible = true;
			}
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
			iアクティブＦＧ = 0;
			tex会員コード.Text = s会員コード;
			tex会員名.Text = s会員名;
			
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
//			axGT会員.Cols = 2;
			axGT会員.Cols = 4;
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
// MOD 2006.12.18 東都）小童谷 明細の余白を除去 START
// 2006.07.14 東都）山本 スクロール１００件対応 START
////			axGT会員.Rows = 15;
//			axGT会員.Rows = 100;
// 2006.07.14 東都）山本 スクロール１００件対応 END
			axGT会員.Rows = 15;
// MOD 2006.12.18 東都）小童谷 明細の余白を除去 END
			axGT会員.ColSep = "|";
			axGT会員.CaretRow = 1;
			axGT会員.NoBeep = true;
			
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
//			axGT会員.set_RowsText(0, "|コード|お客様名|");
//
//// 2006.07.14 東都）山本 スクロール１００件対応 START
////			axGT会員.ColsWidth = "0|8|19.4|";
//			axGT会員.ColsWidth = "0|7|19.4|";
//// 2006.07.14 東都）山本 スクロール１００件対応 END
//			axGT会員.ColsAlignHorz = "1|1|0|";
			axGT会員.set_RowsText(0, "|コード|お客様名|||");
			axGT会員.ColsWidth = "0|7|19.4|0|0|";
			axGT会員.ColsAlignHorz = "1|1|0|0|0|";
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
//			axGT会員.set_CelForeColor(axGT会員.CaretRow,0,111111);
			axGT会員.set_CelForeColor(axGT会員.CaretRow,0,0x98FB98);  //BGR
			axGT会員.set_CelBackColor(axGT会員.CaretRow,0,0x006000);

			btn前頁.Enabled = false;
			btn次頁.Enabled = false;
			lab頁番号.Text = "";
			i現在頁数 = 1;

			axGT会員.CaretRow = 1;
			axGT会員_CurPlaceChanged(null,null);
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			s会員コード = "";
			s会員名     = "";
			this.Close();
		}

		private void axGT会員_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			s会員コード = axGT会員.get_CelText(axGT会員.CaretRow,1);
			s会員名     = axGT会員.get_CelText(axGT会員.CaretRow,2);
			if(!s会員コード.Equals(""))
				this.Close();
		}

		private void axGT会員_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT会員.set_CelForeColor(nOldRow,0,0);
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
//			axGT会員.set_CelBackColor(nOldRow,0,0xFFFFFF);
			if(axGT会員.get_CelText(nOldRow, 3).CompareTo(axGT会員.get_CelText(nOldRow, 4)) < 0){
				axGT会員.set_CelBackColor(nOldRow,0,0xC0C0C0);
			}else{
				axGT会員.set_CelBackColor(nOldRow,0,0xFFFFFF);
			}
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
//			axGT会員.set_CelForeColor(axGT会員.CaretRow,0,111111);
			axGT会員.set_CelForeColor(axGT会員.CaretRow,0,0x98FB98);  //BGR
			axGT会員.set_CelBackColor(axGT会員.CaretRow,0,0x006000);
			nOldRow = axGT会員.CaretRow;

		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			会員一覧検索();
		}

		private void btn確定_Click(object sender, System.EventArgs e)
		{
			s会員コード = axGT会員.get_CelText(axGT会員.CaretRow,1);
			s会員名     = axGT会員.get_CelText(axGT会員.CaretRow,2);
			if(!s会員コード.Equals(""))
				this.Close();
		}

		private void 会員一覧検索()
		{
			iアクティブＦＧ = 1;
			tex会員コード.Text = tex会員コード.Text.Trim();
			tex会員名.Text = tex会員名.Text.Trim();
			if(!半角チェック(tex会員コード, "コード")) return;
// ADD 2008.05.07 東都）高木 お客様名の全角チェックの追加 START
			if(!全角チェック(tex会員名, "お客様名")) return;
// ADD 2008.05.07 東都）高木 お客様名の全角チェックの追加 END

			axGT会員.Clear();

			texメッセージ.Text = "検索中．．．";

			s会員一覧 = new string[1];
			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
//				string[] sKey  = new string[3];
				string[] sKey  = new string[4];
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
				sKey[0] = tex会員コード.Text;
				sKey[1] = tex会員名.Text;
// ADD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 START
// MOD 2007.01.18 東都）高木 画面レイアウト変更 START
//				sKey[2] = gs店所コード.Trim();
//				if(gs店所コード.Trim().Length != 0)
				sKey[2] = s店所コード.Trim();
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
				sKey[3] = (b運用中のお客様のみ ? "1" : "");
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
				if(s店所コード.Trim().Length != 0)
// MOD 2007.01.18 東都）高木 画面レイアウト変更 END
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if (sKey[0] == "" )
					{
						//会員コードが空白の場合は店コードより管理者区分を検索
						string[] sKey2  = new string[1];
						sKey2[0] = sKey[2];
						string[] sList = sv_oji.Sel_Member(gsaユーザ, sKey2);
						if (sList[0].Equals("正常終了"))
						{
							if ((sList[4].Equals("3"))||(sList[4].Equals("4")))
							{
								//王子運送会員
								s会員一覧 = sv_oji.Get_MemberTn(gsaユーザ, sKey);
							}
							else
							{
								//福通会員
								s会員一覧 = sv_maintenance.Get_MemberTn(gsaユーザ, sKey);
							}
						}
						else
						{
							s会員一覧 = sv_maintenance.Get_MemberTn(gsaユーザ, sKey);
						}
					}
					else if (sKey[0].Substring(0,1) != "J")
					{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

					s会員一覧 = sv_maintenance.Get_MemberTn(gsaユーザ, sKey);

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					}
					else
					{
						s会員一覧 = sv_oji.Get_MemberTn(gsaユーザ, sKey);
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

				else
// ADD 2006.11.08 東都）山本 店所ログイン時の請求先登録する場合の店所コードチェック追加 END
					s会員一覧 = sv_maintenance.Get_Member(gsaユーザ, sKey);
			}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 START
			catch (System.Net.WebException)
			{
				s会員一覧[0] = gs通信エラー;
			}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 END
			catch (Exception ex)
			{
				s会員一覧[0] = "通信エラー：" + ex.Message;
			}
			
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			if (s会員一覧[0].Equals("正常終了"))
			{
				texメッセージ.Text = "";
// MOD 2006.12.18 東都）小童谷 明細の余白を除去 START
// MOD 2005.05.12 東都）小童谷 一行目空白 START
//				i最大頁数 = (s会員一覧.Length - 2) / axGT会員.Rows + 1;
				i最大頁数 = (s会員一覧.Length - 2) / (axGT会員.Rows - 1) + 1;
// MOD 2005.05.12 東都）小童谷 一行目空白 END
				i最大頁数 = (s会員一覧.Length - 2) / (i頁最大行数 - 1) + 1;
// MOD 2006.12.18 東都）小童谷 明細の余白を除去 END
				if (i現在頁数 > i最大頁数)
					i現在頁数 = i最大頁数;
				頁情報設定();

// ADD 2005.05.12 東都）小童谷 一行目選択 START
				axGT会員.CaretRow = 1;
				axGT会員_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END

				axGT会員.Focus();
			}
			else
			{
				if (s会員一覧[0].Equals("該当データがありません"))
				{
					texメッセージ.Text = "";
					MessageBox.Show("該当データがありません","お客様検索",MessageBoxButtons.OK);
				}
				else
				{
					texメッセージ.Text = s会員一覧[0];
					i現在頁数 = 1;
					btn前頁.Enabled = false;
					btn次頁.Enabled = false;
					lab頁番号.Text = "";
					ビープ音();
				}
				tex会員コード.Focus();
			}
		}

		private void axGT会員_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				s会員コード = axGT会員.get_CelText(axGT会員.CaretRow,1);
				s会員名     = axGT会員.get_CelText(axGT会員.CaretRow,2);
				if(!s会員コード.Equals(""))
					this.Close();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT会員, true, true, true, true);
			}
		}

		private void tex会員名_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				会員一覧検索();
			}
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();
// ADD 2005.05.12 東都）小童谷 一行目選択 START
			axGT会員.CaretRow = 1;
			axGT会員_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();
// ADD 2005.05.12 東都）小童谷 一行目選択 START
			axGT会員.CaretRow = 1;
			axGT会員_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END
		}

		private void 頁情報設定()
		{
			axGT会員.Clear();
// ADD 2006.12.18 東都）小童谷 明細の余白を除去 START
			axGT会員.Rows = 15;
// ADD 2006.12.18 東都）小童谷 明細の余白を除去 END

// MOD 2005.05.12 東都）小童谷 一行目空白 START
// MOD 2006.12.18 東都）小童谷 明細の余白を除去 START
////			i開始数 = (i現在頁数 - 1) * axGT会員.Rows + 1;
//			i開始数 = (i現在頁数 - 1) * (axGT会員.Rows - 1) + 1;
////			i終了数 = i現在頁数 * axGT会員.Rows;
//			i終了数 = i現在頁数 * (axGT会員.Rows - 1);
			i開始数 = (i現在頁数 - 1) * (i頁最大行数 - 1) + 1;
			i終了数 = i現在頁数 * (i頁最大行数 - 1);
// ADD 2006.12.18 東都）小童谷 明細の余白を除去 END

//			short s表示数 = (short)1;
			short s表示数 = (short)2;
// MOD 2005.05.12 東都）小童谷 一行目空白 END
			for(short sCnt = (short)i開始数; sCnt < s会員一覧.Length && sCnt <= i終了数 ; sCnt++)
			{
// ADD 2006.12.14 東都）小童谷 明細の余白を除去 START
				if(s表示数 > 15)
					axGT会員.Rows++;
// ADD 2006.12.14 東都）小童谷 明細の余白を除去 END

				axGT会員.set_RowsText(s表示数, s会員一覧[sCnt]);
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 START
				if(axGT会員.get_CelText(s表示数, 3).CompareTo(axGT会員.get_CelText(s表示数, 4)) < 0){
					axGT会員.set_CelBackColor(s表示数,0,0xC0C0C0);
				}else{
					axGT会員.set_CelBackColor(s表示数,0,0xFFFFFF);
				}
// MOD 2010.04.27 東都）高木 運用中のお客様のみ対象機能の追加 END
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

		private void 会員検索_Activated(object sender, System.EventArgs e)
		{
			if(iアクティブＦＧ == 0)
				会員一覧検索();		
		}
	}
}
