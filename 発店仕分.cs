using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// 発店仕分 の概要の説明です。
	/// </summary>
	public class 発店仕分 : 共通フォーム
	{
		public short nOldRow = 0;
		private string[] s着店所一覧;
		private int      i現在頁数;
		private int      i最大頁数;
		private int      i開始数;
		private int      i終了数;
		private int      i現在頁数保持;
		private bool     bUpd;
// MOD 2007.01.26 東都）高木 コードチェックの追加 START
//		private bool     bCheck;
		private int      iCheck;
		private static string[] sチェックメッセージ = {""
			,"仕分けコードは半角文字で入力してください"
			,"仕分けコードは英数字で入力してください"
			,"仕分けコードは３文字の場合、１文字は英字で入力してください"
			,"仕分けコードは２～３文字で入力してください"
		};
// MOD 2007.01.26 東都）高木 コードチェックの追加 END
		
		private string[] sUpdData = new string[16];

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private System.Windows.Forms.Panel panel5;
		private 共通テキストボックス tex検索店所;
		private System.Windows.Forms.Label lab検索店所;
		private AxGTABLE32V2Lib.AxGTable32 axGT着店所;
		private System.Windows.Forms.Button btn取消;
		private System.Windows.Forms.Button btn登録;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private is2AdminClient.共通テキストボックス tex発店所名;
		public System.Windows.Forms.Label lab発店仕分けコード登録;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 発店仕分()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(発店仕分));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn登録 = new System.Windows.Forms.Button();
            this.axGT着店所 = new AxGTABLE32V2Lib.AxGTable32();
            this.btn取消 = new System.Windows.Forms.Button();
            this.lab頁番号 = new System.Windows.Forms.Label();
            this.btn次頁 = new System.Windows.Forms.Button();
            this.btn前頁 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab発店仕分けコード登録 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texメッセージ = new is2AdminClient.共通テキストボックス();
            this.btn閉じる = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tex検索店所 = new is2AdminClient.共通テキストボックス();
            this.lab検索店所 = new System.Windows.Forms.Label();
            this.tex発店所名 = new is2AdminClient.共通テキストボックス();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT着店所)).BeginInit();
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
            this.panel1.Controls.Add(this.btn登録);
            this.panel1.Controls.Add(this.axGT着店所);
            this.panel1.Controls.Add(this.btn取消);
            this.panel1.Controls.Add(this.lab頁番号);
            this.panel1.Controls.Add(this.btn次頁);
            this.panel1.Controls.Add(this.btn前頁);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 408);
            this.panel1.TabIndex = 1;
            // 
            // btn登録
            // 
            this.btn登録.BackColor = System.Drawing.Color.Blue;
            this.btn登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn登録.ForeColor = System.Drawing.Color.White;
            this.btn登録.Location = new System.Drawing.Point(264, 378);
            this.btn登録.Name = "btn登録";
            this.btn登録.Size = new System.Drawing.Size(48, 22);
            this.btn登録.TabIndex = 4;
            this.btn登録.Text = "登録";
            this.btn登録.UseVisualStyleBackColor = false;
            this.btn登録.Click += new System.EventHandler(this.btn登録_Click);
            // 
            // axGT着店所
            // 
            this.axGT着店所.DataSource = null;
            this.axGT着店所.Location = new System.Drawing.Point(76, 10);
            this.axGT着店所.Name = "axGT着店所";
            this.axGT着店所.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT着店所.OcxState")));
            this.axGT着店所.Size = new System.Drawing.Size(228, 325);
            this.axGT着店所.TabIndex = 0;
            this.axGT着店所.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT着店所_CurPlaceChanged);
            this.axGT着店所.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT着店所_CelDblClick);
            this.axGT着店所.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT着店所_KeyDownEvent);
            // 
            // btn取消
            // 
            this.btn取消.BackColor = System.Drawing.Color.Blue;
            this.btn取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn取消.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn取消.ForeColor = System.Drawing.Color.White;
            this.btn取消.Location = new System.Drawing.Point(318, 378);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(48, 22);
            this.btn取消.TabIndex = 6;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = false;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // lab頁番号
            // 
            this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab頁番号.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab頁番号.Location = new System.Drawing.Point(210, 346);
            this.lab頁番号.Name = "lab頁番号";
            this.lab頁番号.Size = new System.Drawing.Size(48, 14);
            this.lab頁番号.TabIndex = 64;
            this.lab頁番号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn次頁
            // 
            this.btn次頁.BackColor = System.Drawing.Color.SteelBlue;
            this.btn次頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn次頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn次頁.ForeColor = System.Drawing.Color.White;
            this.btn次頁.Location = new System.Drawing.Point(258, 342);
            this.btn次頁.Name = "btn次頁";
            this.btn次頁.Size = new System.Drawing.Size(48, 22);
            this.btn次頁.TabIndex = 63;
            this.btn次頁.Text = "次頁";
            this.btn次頁.UseVisualStyleBackColor = false;
            this.btn次頁.Click += new System.EventHandler(this.btn次頁_Click);
            // 
            // btn前頁
            // 
            this.btn前頁.BackColor = System.Drawing.Color.SteelBlue;
            this.btn前頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn前頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn前頁.ForeColor = System.Drawing.Color.White;
            this.btn前頁.Location = new System.Drawing.Point(162, 342);
            this.btn前頁.Name = "btn前頁";
            this.btn前頁.Size = new System.Drawing.Size(48, 22);
            this.btn前頁.TabIndex = 62;
            this.btn前頁.Text = "前頁";
            this.btn前頁.UseVisualStyleBackColor = false;
            this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab発店仕分けコード登録);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab発店仕分けコード登録
            // 
            this.lab発店仕分けコード登録.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab発店仕分けコード登録.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab発店仕分けコード登録.ForeColor = System.Drawing.Color.White;
            this.lab発店仕分けコード登録.Location = new System.Drawing.Point(12, 2);
            this.lab発店仕分けコード登録.Name = "lab発店仕分けコード登録";
            this.lab発店仕分けコード登録.Size = new System.Drawing.Size(264, 24);
            this.lab発店仕分けコード登録.TabIndex = 0;
            this.lab発店仕分けコード登録.Text = "発店仕分けコード登録";
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
            this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texメッセージ.ForeColor = System.Drawing.Color.Red;
            this.texメッセージ.Location = new System.Drawing.Point(70, 4);
            this.texメッセージ.Multiline = true;
            this.texメッセージ.Name = "texメッセージ";
            this.texメッセージ.ReadOnly = true;
            this.texメッセージ.Size = new System.Drawing.Size(312, 50);
            this.texメッセージ.TabIndex = 0;
            this.texメッセージ.TabStop = false;
            // 
            // btn閉じる
            // 
            this.btn閉じる.ForeColor = System.Drawing.Color.Red;
            this.btn閉じる.Location = new System.Drawing.Point(8, 6);
            this.btn閉じる.Name = "btn閉じる";
            this.btn閉じる.Size = new System.Drawing.Size(54, 48);
            this.btn閉じる.TabIndex = 6;
            this.btn閉じる.TabStop = false;
            this.btn閉じる.Text = "閉じる";
            this.btn閉じる.Click += new System.EventHandler(this.btn閉じる_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(0, 0);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 0;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(0, 0);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
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
            this.panel5.Controls.Add(this.tex検索店所);
            this.panel5.Controls.Add(this.lab検索店所);
            this.panel5.Controls.Add(this.tex発店所名);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 36);
            this.panel5.TabIndex = 0;
            // 
            // tex検索店所
            // 
            this.tex検索店所.BackColor = System.Drawing.SystemColors.Window;
            this.tex検索店所.Enabled = false;
            this.tex検索店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex検索店所.Location = new System.Drawing.Point(76, 6);
            this.tex検索店所.MaxLength = 4;
            this.tex検索店所.Name = "tex検索店所";
            this.tex検索店所.ReadOnly = true;
            this.tex検索店所.Size = new System.Drawing.Size(42, 23);
            this.tex検索店所.TabIndex = 0;
            this.tex検索店所.TabStop = false;
            // 
            // lab検索店所
            // 
            this.lab検索店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab検索店所.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab検索店所.Location = new System.Drawing.Point(18, 10);
            this.lab検索店所.Name = "lab検索店所";
            this.lab検索店所.Size = new System.Drawing.Size(58, 16);
            this.lab検索店所.TabIndex = 46;
            this.lab検索店所.Text = "発店所";
            // 
            // tex発店所名
            // 
            this.tex発店所名.BackColor = System.Drawing.Color.Honeydew;
            this.tex発店所名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex発店所名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex発店所名.Location = new System.Drawing.Point(120, 10);
            this.tex発店所名.Name = "tex発店所名";
            this.tex発店所名.ReadOnly = true;
            this.tex発店所名.Size = new System.Drawing.Size(150, 16);
            this.tex発店所名.TabIndex = 75;
            this.tex発店所名.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(7, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 44);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(7, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 416);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // 発店仕分
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
            this.Name = "発店仕分";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 発店仕分けコード登録";
            this.Closed += new System.EventHandler(this.発店仕分_Closed);
            this.Load += new System.EventHandler(this.発店仕分_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGT着店所)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 START
        protected void Onエンター移動(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            base.エンター移動(sender, e);
        }

        protected void Onエンターキャンセル(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            base.エンターキャンセル(sender, e);
        }
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 END

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>

		private void 発店仕分_Load(object sender, System.EventArgs e)
		{
			axGT着店所.Cols = 5;
			axGT着店所.Rows = 17;
			axGT着店所.ColSep = "|";
			axGT着店所.NoBeep = true;

			axGT着店所.set_RowsText(0, "|コード|着店所|仕分けコード|仕分けＣＤ|更新日時|");

			axGT着店所.ColsWidth = "0|3|9|5.5|0|0|";
			axGT着店所.ColsAlignHorz = "1|1|0|1|1|1|";

			axGT着店所.set_CelForeColor(axGT着店所.CaretRow,0,0x98FB98);  //BGR
			axGT着店所.set_CelBackColor(axGT着店所.CaretRow,0,0x006000);

			axGT着店所.CaretRow = 1;
			tex検索店所.Text = gs店所コード;

			発店所検索();
			着店所一覧検索();
			tex検索店所.Focus();
		}

		private void 着店所一覧検索()
		{
			axGT着店所.Clear();

			tex検索店所.Text   = tex検索店所.Text.Trim();
			if (tex検索店所.Text.Length == 0)
			{
				tex検索店所.Text = " ";
			}
			if(!半角チェック(tex検索店所,"発店所")) return;

			i現在頁数 = 1;
			axGT着店所.CaretRow = 1;
			axGT着店所.set_CelForeColor(nOldRow,0,0);
			axGT着店所.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT着店所.set_CelForeColor(axGT着店所.CaretRow,0,0x98FB98);  //BGR
			axGT着店所.set_CelBackColor(axGT着店所.CaretRow,0,0x006000);
			nOldRow = axGT着店所.CaretRow;
			
			s着店所一覧 = new string[1];
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex検索店所.Text;
				s着店所一覧 = sv_maintenance.Get_Tyakusiwake(gsaユーザ, sKey);
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(s着店所一覧[0].Equals("正常終了"))
			{
				texメッセージ.Text = "";
				i最大頁数 = (s着店所一覧.Length - 2) / (axGT着店所.Rows - 1) + 1;
				if (i現在頁数 > i最大頁数)
					i現在頁数 = i最大頁数;
				頁情報設定();
			}
			else
			{
				texメッセージ.Text = s着店所一覧[0];
				axGT着店所.Clear();
				i現在頁数 = 1;
				btn前頁.Enabled = false;
				btn次頁.Enabled = false;
				lab頁番号.Text = "";
				ビープ音();
			}
			tex検索店所.Text = tex検索店所.Text.Trim();
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void axGT着店所_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
		}

		private void axGT着店所_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT着店所.set_CelForeColor(nOldRow,0,0);
			axGT着店所.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT着店所.set_CelForeColor(axGT着店所.CaretRow,0,0x98FB98);  //BGR
			axGT着店所.set_CelBackColor(axGT着店所.CaretRow,0,0x006000);
			nOldRow = axGT着店所.CaretRow;
		}

		private void axGT着店所_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT着店所, true, true, true, true);
			}
		}

		private void btn登録_Click(object sender, System.EventArgs e)
		{
			仕分けＣＤチェック();
			if(bUpd)
			{
// MOD 2007.01.26 東都）高木 コードチェックの追加 START
//				if(!bCheck)
//				{
//					MessageBox.Show("仕分けコードは半角文字で入力してください",
//						"入力チェック",MessageBoxButtons.OK);
//					return;
//				}
				if(iCheck > 0)
				{
					MessageBox.Show(sチェックメッセージ[iCheck],
						"入力チェック",MessageBoxButtons.OK);
					return;
				}
// MOD 2007.01.26 東都）高木 コードチェックの追加 END
				if(発店仕分け更新())
				{
					着店所一覧検索();
				}
			}
		}

		private void btn取消_Click(object sender, System.EventArgs e)
		{
			着店所一覧検索();
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			仕分けＣＤチェック();
			if(bUpd)
			{
				DialogResult result = MessageBox.Show("変更されている仕分けコードを更新しますか？","更新",MessageBoxButtons.YesNo);
				if(result == DialogResult.Yes)
				{
// MOD 2007.01.26 東都）高木 コードチェックの追加 START
//					if(!bCheck)
//					{
//						MessageBox.Show("仕分けコードは半角文字で入力してください",
//							"入力チェック",MessageBoxButtons.OK);
//						return;
//					}
					if(iCheck > 0)
					{
						MessageBox.Show(sチェックメッセージ[iCheck],
							"入力チェック",MessageBoxButtons.OK);
						return;
					}
// MOD 2007.01.26 東都）高木 コードチェックの追加 END
					if(!発店仕分け更新())
					{
						return;
					}
					i現在頁数保持 = i現在頁数;
					着店所一覧検索();
					i現在頁数     = i現在頁数保持;
				}
			}
			i現在頁数--;
			頁情報設定();
			axGT着店所.CaretRow = 1;
			axGT着店所_CurPlaceChanged(null,null);
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			仕分けＣＤチェック();
			if(bUpd)
			{
				DialogResult result = MessageBox.Show("変更されている仕分けコードを更新しますか？","更新",MessageBoxButtons.YesNo);
				if(result == DialogResult.Yes)
				{
// MOD 2007.01.26 東都）高木 コードチェックの追加 START
//					if(!bCheck)
//					{
//						MessageBox.Show("仕分けコードは半角文字で入力してください",
//							"入力チェック",MessageBoxButtons.OK);
//						return;
//					}
					if(iCheck > 0)
					{
						MessageBox.Show(sチェックメッセージ[iCheck],
							"入力チェック",MessageBoxButtons.OK);
						return;
					}
// MOD 2007.01.26 東都）高木 コードチェックの追加 END
					if(!発店仕分け更新())
					{
						return;
					}
					i現在頁数保持 = i現在頁数;
					着店所一覧検索();
					i現在頁数     = i現在頁数保持;
				}
			}
			i現在頁数++;
			頁情報設定();
			axGT着店所.CaretRow = 1;
			axGT着店所_CurPlaceChanged(null,null);
		}
		
		private void 頁情報設定()
		{
			axGT着店所.Clear();

			i開始数 = (i現在頁数 - 1) * (axGT着店所.Rows - 1) + 1;
			i終了数 = i現在頁数 * (axGT着店所.Rows - 1);

			short s表示数 = (short)2;
			for(short sCnt = (short)i開始数; sCnt < s着店所一覧.Length && sCnt <= i終了数 ; sCnt++)
			{
				axGT着店所.set_RowsText(s表示数, s着店所一覧[sCnt]);
				axGT着店所.set_CelLocked(s表示数,3,false);
// MOD 2007.02.16 東都）高木 入力桁数をＭＡＸ３桁にする START
//				axGT着店所.set_CelMaxLength(s表示数,3,5);
				axGT着店所.set_CelMaxLength(s表示数,3,3);
// MOD 2007.02.16 東都）高木 入力桁数をＭＡＸ３桁にする END
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
		}

		private void 仕分けＣＤチェック()
		{
			bUpd = false;
// MOD 2007.01.26 東都）高木 コードチェックの追加 START
//			bCheck = true;
			iCheck = 0;
// MOD 2007.01.26 東都）高木 コードチェックの追加 END
			int iCnt = 0;
// ADD 2007.02.07 東都）高木 データクリア処理の追加 START
			sUpdData = new string[16];
// ADD 2007.02.07 東都）高木 データクリア処理の追加 END

			for(short sCnt = 2; sCnt < 18; sCnt++)
			{
				if(!axGT着店所.get_CelText(sCnt,1).Trim().Equals(""))
				{
					string sNcd = axGT着店所.get_CelText(sCnt,3).Trim();
					string sOcd = axGT着店所.get_CelText(sCnt,4).Trim();
					if(!sNcd.Equals(sOcd))
					{
						bUpd = true;
						if(!sNcd.Trim().Equals(""))
						{
							if(!半角入力チェック(sNcd))
							{
// MOD 2007.01.26 東都）高木 コードチェックの追加 START
//								bCheck = false;
								iCheck = 1;
								axGT着店所.CaretRow = sCnt;
								axGT着店所_CurPlaceChanged(null,null);
// MOD 2007.01.26 東都）高木 コードチェックの追加 END
								return;
							}
// ADD 2007.01.26 東都）高木 コードチェックの追加 START
							sNcd = sNcd.Trim();
							switch(sNcd.Length)
							{
								case 2:
									//２文字の場合は英数字、
									if(!char.IsLetterOrDigit(sNcd[0])
										|| !char.IsLetterOrDigit(sNcd[1]))
									{
										iCheck = 2;
										axGT着店所.CaretRow = sCnt;
										axGT着店所_CurPlaceChanged(null,null);
										return;
									}
									break;
								case 3:
									//３文字の場合は英数字で、英字は少なくとも１文字含まれること
									if(!char.IsLetterOrDigit(sNcd[0])
										|| !char.IsLetterOrDigit(sNcd[1])
										|| !char.IsLetterOrDigit(sNcd[2]))
									{
										iCheck = 2;
										axGT着店所.CaretRow = sCnt;
										axGT着店所_CurPlaceChanged(null,null);
										return;
									}
									if(!char.IsLetter(sNcd[0])
										&& !char.IsLetter(sNcd[1])
										&& !char.IsLetter(sNcd[2]))
									{
										iCheck = 3;
										axGT着店所.CaretRow = sCnt;
										axGT着店所_CurPlaceChanged(null,null);
										return;
									}
									break;
								default:
									iCheck = 4;
									axGT着店所.CaretRow = sCnt;
									axGT着店所_CurPlaceChanged(null,null);
									return;
							}
// ADD 2007.01.26 東都）高木 コードチェックの追加 END
						}
						else
						{
							sNcd = " ";
						}
						sUpdData[iCnt] = gs店所コード
									  + ","
									  + axGT着店所.get_CelText(sCnt,1).Trim()
									  + ","
									  + sNcd
									  + ","
									  + "発店仕分"
									  + ","
									  + gs利用者コード;
						iCnt++;
					}
				}
				else
				{
					sCnt = 20;
				}
			}
		}

		private bool 発店仕分け更新()
		{
			if(bUpd)
			{
				try
				{
					string[] sList = sv_maintenance.Ins_TyakuSiwake(gsaユーザ, sUpdData);
					texメッセージ.Text = sList[0];
					if (!sList[0].Equals("正常終了"))
					{
						ビープ音();
						return false;
					}
				}
				catch (Exception ex)
				{
					texメッセージ.Text = ex.Message;
					ビープ音();
					return false;
				}
			}
			return true;

		}

		private void 発店仕分_Closed(object sender, System.EventArgs e)
		{
			axGT着店所.CaretRow = 1;
			axGT着店所_CurPlaceChanged(null,null);
		}

		private void 発店所検索()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			
			try
			{
				string[] sKey  = new string[1];
				sKey[0] = gs店所コード.Trim();
				string[] sList = sv_maintenance.Sel_Hatuten(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex発店所名.Text = sList[1].Trim();
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		private bool 半角入力チェック(string sSiwake)
		{
			string sUnicode = sSiwake;
			byte[] bSjis = System.Text.Encoding.GetEncoding("shift-jis").GetBytes(sUnicode);
			if(bSjis.Length != sUnicode.Length)
			{
				return false;
			}

			return true;
		}
	}
}
