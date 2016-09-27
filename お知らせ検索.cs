// ADD 2007.12.05 KCL) 森本 お知らせ追加 START
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [お知らせ検索]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 東都）高木 表題、詳細内容の全角半角混在チェックの追加 
	//--------------------------------------------------------------------------
	// MOD 2008.05.15 ACT Vista対応（全角半角混在チェックの場所移動） 
	//--------------------------------------------------------------------------
	// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 
	//--------------------------------------------------------------------------
	public class お知らせ検索 : 共通フォーム
	{
		public short nOldRow = 0;

		public string s登録日;
		public string s表題;
		public string s詳細内容;
		public string sボタン名;
		public string sアドレス;
		public string s優先順;
		public string sシーケンスＮｏ;
		public decimal d更新日時;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
		public string s会員区分;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

		private string[] sお知らせ一覧;
		private int      i現在頁数;
		private int      i最大頁数;
		private int      i開始数;
		private int      i終了数;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btn確定;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn検索;
		private AxGTABLE32V2Lib.AxGTable32 axGTお知らせ;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private System.Windows.Forms.Label labお知らせ検索;
		private System.Windows.Forms.Label lab詳細内容;
		private System.Windows.Forms.Label lab登録日;
		private System.Windows.Forms.Label lab表題;
		private is2AdminClient.共通テキストボックス tex詳細内容;
		private is2AdminClient.共通テキストボックス tex登録日;
		private is2AdminClient.共通テキストボックス tex表題;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public お知らせ検索()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

			// スプレッドシートの初期化
			InitializeAxGTable32();
		}

		#region スプレッドシートの初期化
		private void InitializeAxGTable32() 
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(お知らせ検索));
			this.axGTお知らせ = new AxGTABLE32V2Lib.AxGTable32();
			// 
			// axGTお知らせ
			// 
			((System.ComponentModel.ISupportInitialize)(this.axGTお知らせ)).BeginInit();
			this.axGTお知らせ.ContainingControl = this;
			this.axGTお知らせ.DataSource = null;
			this.axGTお知らせ.Location = new System.Drawing.Point(8, 8);
			this.axGTお知らせ.Name = "axGTお知らせ";
			this.axGTお知らせ.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGTお知らせ.OcxState")));
			this.axGTお知らせ.Size = new System.Drawing.Size(357, 271);
			this.axGTお知らせ.TabIndex = 0;
			this.axGTお知らせ.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGTお知らせ_KeyDownEvent);
			this.axGTお知らせ.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGTお知らせ_CelDblClick);
			this.axGTお知らせ.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGTお知らせ_CurPlaceChanged);
			((System.ComponentModel.ISupportInitialize)(this.axGTお知らせ)).EndInit();

			this.panel1.SuspendLayout();
			this.panel1.Controls.Add(this.axGTお知らせ);
			this.panel1.ResumeLayout(false);
		}
		#endregion

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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lab頁番号 = new System.Windows.Forms.Label();
			this.btn次頁 = new System.Windows.Forms.Button();
			this.btn前頁 = new System.Windows.Forms.Button();
			this.btn確定 = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labお知らせ検索 = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texメッセージ = new is2AdminClient.共通テキストボックス();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.lab詳細内容 = new System.Windows.Forms.Label();
			this.tex詳細内容 = new is2AdminClient.共通テキストボックス();
			this.tex登録日 = new is2AdminClient.共通テキストボックス();
			this.lab登録日 = new System.Windows.Forms.Label();
			this.lab表題 = new System.Windows.Forms.Label();
			this.tex表題 = new is2AdminClient.共通テキストボックス();
			this.btn検索 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
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
			this.panel7.Controls.Add(this.labお知らせ検索);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// labお知らせ検索
			// 
			this.labお知らせ検索.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labお知らせ検索.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labお知らせ検索.ForeColor = System.Drawing.Color.White;
			this.labお知らせ検索.Location = new System.Drawing.Point(12, 2);
			this.labお知らせ検索.Name = "labお知らせ検索";
			this.labお知らせ検索.Size = new System.Drawing.Size(264, 24);
			this.labお知らせ検索.TabIndex = 0;
			this.labお知らせ検索.Text = "お知らせ検索";
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
			this.panel5.Controls.Add(this.lab詳細内容);
			this.panel5.Controls.Add(this.tex詳細内容);
			this.panel5.Controls.Add(this.tex登録日);
			this.panel5.Controls.Add(this.lab登録日);
			this.panel5.Controls.Add(this.lab表題);
			this.panel5.Controls.Add(this.tex表題);
			this.panel5.Controls.Add(this.btn検索);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(373, 90);
			this.panel5.TabIndex = 3;
			// 
			// lab詳細内容
			// 
			this.lab詳細内容.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab詳細内容.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab詳細内容.Location = new System.Drawing.Point(2, 64);
			this.lab詳細内容.Name = "lab詳細内容";
			this.lab詳細内容.Size = new System.Drawing.Size(72, 16);
			this.lab詳細内容.TabIndex = 49;
			this.lab詳細内容.Text = "詳細内容";
			// 
			// tex詳細内容
			// 
			this.tex詳細内容.BackColor = System.Drawing.SystemColors.Window;
			this.tex詳細内容.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex詳細内容.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex詳細内容.Location = new System.Drawing.Point(74, 60);
			this.tex詳細内容.MaxLength = 1000;
			this.tex詳細内容.Name = "tex詳細内容";
			this.tex詳細内容.Size = new System.Drawing.Size(230, 23);
			this.tex詳細内容.TabIndex = 3;
			this.tex詳細内容.Text = "";
			this.tex詳細内容.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex詳細内容_KeyDown);
			// 
			// tex登録日
			// 
			this.tex登録日.BackColor = System.Drawing.SystemColors.Window;
			this.tex登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex登録日.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex登録日.Location = new System.Drawing.Point(74, 8);
			this.tex登録日.MaxLength = 10;
			this.tex登録日.Name = "tex登録日";
			this.tex登録日.Size = new System.Drawing.Size(126, 23);
			this.tex登録日.TabIndex = 0;
			this.tex登録日.Text = "";
			// 
			// lab登録日
			// 
			this.lab登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab登録日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab登録日.Location = new System.Drawing.Point(2, 12);
			this.lab登録日.Name = "lab登録日";
			this.lab登録日.Size = new System.Drawing.Size(72, 16);
			this.lab登録日.TabIndex = 46;
			this.lab登録日.Text = "登録日";
			// 
			// lab表題
			// 
			this.lab表題.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab表題.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab表題.Location = new System.Drawing.Point(2, 38);
			this.lab表題.Name = "lab表題";
			this.lab表題.Size = new System.Drawing.Size(72, 16);
			this.lab表題.TabIndex = 6;
			this.lab表題.Text = "表　題";
			// 
			// tex表題
			// 
			this.tex表題.BackColor = System.Drawing.SystemColors.Window;
			this.tex表題.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex表題.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex表題.Location = new System.Drawing.Point(74, 34);
			this.tex表題.MaxLength = 30;
			this.tex表題.Name = "tex表題";
			this.tex表題.Size = new System.Drawing.Size(230, 23);
			this.tex表題.TabIndex = 2;
			this.tex表題.Text = "";
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
			// お知らせ検索
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
			this.Name = "お知らせ検索";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 お知らせ検索";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.お知らせ検索_Load);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void お知らせ検索_Load(object sender, System.EventArgs e)
		{
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			axGTお知らせ.Cols = 4;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			axGTお知らせ.Rows = 14;
			axGTお知らせ.ColSep = "|";
			axGTお知らせ.CaretRow = 1;
			axGTお知らせ.NoBeep = true;
			
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			axGTお知らせ.set_RowsText(0, "|登録日|お知らせ（表題）|||");
//
//			axGTお知らせ.ColsWidth = "0|6|19.9|0|0|";
//			axGTお知らせ.ColsAlignHorz = "1|0|0|0|0|";
			axGTお知らせ.Cols = 5;
			axGTお知らせ.set_RowsText(0, "|登録日|区分|お知らせ（表題）|||");

			axGTお知らせ.ColsWidth = "0|5|3.5|17.4|0|0|";
			axGTお知らせ.ColsAlignHorz = "1|0|1|0|0|0|";
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			axGTお知らせ.set_CelForeColor(axGTお知らせ.CaretRow,0,0x98FB98);  //BGR
			axGTお知らせ.set_CelBackColor(axGTお知らせ.CaretRow,0,0x006000);

			btn前頁.Enabled = false;
			btn次頁.Enabled = false;
			lab頁番号.Text = "";
			i現在頁数 = 1;

			axGTお知らせ.CaretRow = 1;
			axGTお知らせ_CurPlaceChanged(null,null);

			this.お知らせ一覧検索();

			tex登録日.Focus();
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			// 検索結果クリア
			this.項目クリア();

			// このフォームを閉じる
			this.Close();
		}

		private void axGTお知らせ_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			// お知らせデータを取得
			if (this.お知らせ内容取得()) 
			{
				// 取得に成功した場合
				// このフォームを閉じる
				this.Close();
			}
		}

		private void axGTお知らせ_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGTお知らせ.set_CelForeColor(nOldRow,0,0);
			axGTお知らせ.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGTお知らせ.set_CelForeColor(axGTお知らせ.CaretRow,0,0x98FB98);  //BGR
			axGTお知らせ.set_CelBackColor(axGTお知らせ.CaretRow,0,0x006000);
			nOldRow = axGTお知らせ.CaretRow;
		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			お知らせ一覧検索();
		}

		private void btn確定_Click(object sender, System.EventArgs e)
		{
			// お知らせデータを取得
			if (this.お知らせ内容取得()) 
			{
				// 取得に成功した場合
				// このフォームを閉じる
				this.Close();
			}
		}

		public void 項目クリア() 
		{
			// 内部データクリア
			s登録日			= string.Empty;
			s表題			= string.Empty;
			s詳細内容		= string.Empty;
			sボタン名		= string.Empty;
			sアドレス		= string.Empty;
			s優先順			= string.Empty;
			sシーケンスＮｏ	= string.Empty;
			d更新日時		= 0m;
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			s会員区分		= "0";
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// 表示クリア
			tex登録日.Text	= string.Empty;
			tex表題.Text		= string.Empty;
			tex詳細内容.Text	= string.Empty;
		}

		private bool お知らせ内容取得() 
		{
			bool bResult = false;

			// 選択されたデータを特定
			string [] sKey = new string [2];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			sKey[0] = axGTお知らせ.get_CelText(axGTお知らせ.CaretRow,3);		// 登録日
//			sKey[1] = axGTお知らせ.get_CelText(axGTお知らせ.CaretRow,4);		// シーケンスＮｏ
			sKey[0] = axGTお知らせ.get_CelText(axGTお知らせ.CaretRow,4);		// 登録日
			sKey[1] = axGTお知らせ.get_CelText(axGTお知らせ.CaretRow,5);		// シーケンスＮｏ
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// お知らせ取得
			texメッセージ.Text = "検索中．．．";
			string [] sRet;
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Sel_Oshirase(gsaユーザ, sKey);
			}
			catch (System.Net.WebException)
			{
				// 通信エラー発生
				sRet = new string [1];
				sRet[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				// その他のエラー発生
				sRet = new string [1];
				sRet[0] = "通信エラー：" + ex.Message;
			}
			
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			// 結果処理
			switch (sRet[0].Trim()) 
			{
				case "正常終了" :		// 取得成功

					// 戻り値設定
					s登録日			= sRet[1];
					s表題			= sRet[2];
					s詳細内容		= sRet[3].Replace("\n", "\r\n");
					sボタン名		= sRet[4];
					sアドレス		= sRet[5];
					s優先順			= sRet[6];
					sシーケンスＮｏ	= sRet[7];
					d更新日時		= Convert.ToDecimal(sRet[8]);
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
					if(sRet.Length > 9){
						s会員区分	= sRet[9];
					}
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
					texメッセージ.Text = string.Empty;

					bResult = true;

					break;

				default :				// 取得失敗

					// 戻り値クリア
					this.項目クリア();
					// エラーメッセージ表示
					ビープ音();
					texメッセージ.Text = sRet[0];

					bResult = false;

					break;
			}

			return bResult;
		}

		private void お知らせ一覧検索()
		{
// ADD 2008.05.15 ACT Vista対応（全角半角混在チェックの場所移動） START
			if (!全角半角混在チェック(tex表題, "表題")) return;
			if (!全角半角混在チェック(tex詳細内容, "詳細内容")) return;
// ADD 2008.05.15 ACT Vista対応（全角半角混在チェックの場所移動） END

			// 入力取得
			string sTourokubi	= tex登録日.Text.Trim();
			string sHyoudai		= tex表題.Text.Trim();
			string sSyousai		= tex詳細内容.Text.Trim();

			// 入力チェック
// DEL 2008.05.15 ACT Vista対応（全角半角混在チェックの場所移動） START
//// ADD 2008.05.07 東都）高木 表題、詳細内容の全角半角混在チェックの追加 START
//			if (!全角半角混在チェック(tex表題, "表題")) return;
//			if (!全角半角混在チェック(tex詳細内容, "詳細内容")) return;
//// ADD 2008.05.07 東都）高木 表題、詳細内容の全角半角混在チェックの追加 END
// DEL 2008.05.15 ACT Vista対応（全角半角混在チェックの場所移動） END
			// 型チェック
			if ((sTourokubi.Length != 0) && !日付チェック(tex登録日, "登録日")) return;
			if ((sHyoudai.Length != 0)   && !禁則文字チェック(tex表題, "表題")) return;
			if ((sSyousai.Length != 0)   && !禁則文字チェック(tex詳細内容, "詳細内容")) return;
			// バイト数チェック
			if (!バイト数チェック(tex表題, "表題", 60)) return;
			if (!バイト数チェック(tex詳細内容, "詳細内容", 2000)) return;

			// 空白除去
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			string [] sKey = new string [5];
			string [] sKey = new string [6];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			sKey[0] = (sTourokubi.Length != 0) 
				? DateTime.Parse(sTourokubi).ToString("yyyyMMdd") : string.Empty;	// 開始登録日
			sKey[1] = sKey[0];			// 終了登録日
			sKey[2] = sHyoudai;			// 表題
			sKey[3] = sSyousai;			// 詳細内容
			sKey[4] = string.Empty;		// 上位Ｎ件
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			sKey[5] = "お知らせ検索";	// 機能
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// 表クリア
			axGTお知らせ.Clear();

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;

			// お知らせ一覧の取得
			texメッセージ.Text = "検索中．．．";
			sお知らせ一覧 = new string [1];
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sお知らせ一覧 = sv_oshirase.Get_OshiraseTopN(gsaユーザ, sKey);
			}
			catch (System.Net.WebException)
			{
				// 通信エラー発生
				sお知らせ一覧[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				// その他のエラー発生
				sお知らせ一覧[0] = "通信エラー：" + ex.Message;
			}
			
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			// 結果処理
			switch (sお知らせ一覧[0].Trim()) 
			{
				case "正常終了" :

					texメッセージ.Text = string.Empty;
					i最大頁数 = (sお知らせ一覧.Length - 2) / (axGTお知らせ.Rows - 1) + 1;
					if (i現在頁数 > i最大頁数)
						i現在頁数 = i最大頁数;
					頁情報設定();

					// 一行目選択
					axGTお知らせ.CaretRow = 1;
					axGTお知らせ_CurPlaceChanged(null, null);

					axGTお知らせ.Focus();

					break;

				case "該当データがありません" :

					texメッセージ.Text = string.Empty;
					MessageBox.Show("該当データがありません", "お知らせ検索", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

					tex登録日.Focus();

					break;

				default :

					texメッセージ.Text = sお知らせ一覧[0];
					i現在頁数 = 1;
					btn前頁.Enabled = false;
					btn次頁.Enabled = false;
					lab頁番号.Text = string.Empty;
					ビープ音();

					tex登録日.Focus();

					break;
			}
		}

		private void axGTお知らせ_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				// お知らせデータを取得
				if (this.お知らせ内容取得()) 
				{
					// 取得に成功した場合
					// このフォームを閉じる
					this.Close();
				}
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGTお知らせ, true, true, true, true);
			}
		}

		private void tex詳細内容_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				お知らせ一覧検索();
			}
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();

			axGTお知らせ.CaretRow = 1;
			axGTお知らせ_CurPlaceChanged(null,null);
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();

			axGTお知らせ.CaretRow = 1;
			axGTお知らせ_CurPlaceChanged(null,null);
		}

		private void 頁情報設定()
		{
			axGTお知らせ.Clear();

			i開始数 = (i現在頁数 - 1) * (axGTお知らせ.Rows - 1) + 1;
			i終了数 = i現在頁数 * (axGTお知らせ.Rows - 1);

			short s表示数 = (short) 2;
			for(short sCnt = (short) i開始数; sCnt < sお知らせ一覧.Length && sCnt <= i終了数; sCnt++)
			{
				axGTお知らせ.set_RowsText(s表示数, sお知らせ一覧[sCnt]);
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
			axGTお知らせ.Focus();
		}
	}
}
// ADD 2007.12.05 KCL) 森本 お知らせ追加 END
