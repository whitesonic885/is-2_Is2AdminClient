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
	public class 荷送人検索 : 共通フォーム
	{
		public short nOldRow = 0;
		public string s会員コード;
		public string s部門コード;
		public string s荷送人コード;
		public string sカナ略称;

		private string[] s荷送人一覧;
		private int      i現在頁数;
		private int      i最大頁数;
		private int      i開始数;
		private int      i終了数;
		private int      iアクティブＦＧ = 0;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Button btn確定;
		private System.Windows.Forms.Button btn検索;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label lab荷送人タイトル;
		private 共通テキストボックス texカナ略称;
		private 共通テキストボックス tex荷送人コード;
		private System.Windows.Forms.Label labカナ略称;
		private System.Windows.Forms.Label lab荷送人コード;
		private AxGTABLE32V2Lib.AxGTable32 axGT荷送人;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 荷送人検索()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(荷送人検索));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab頁番号 = new System.Windows.Forms.Label();
            this.btn次頁 = new System.Windows.Forms.Button();
            this.btn前頁 = new System.Windows.Forms.Button();
            this.axGT荷送人 = new AxGTABLE32V2Lib.AxGTable32();
            this.btn確定 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.texカナ略称 = new is2AdminClient.共通テキストボックス();
            this.labカナ略称 = new System.Windows.Forms.Label();
            this.lab荷送人コード = new System.Windows.Forms.Label();
            this.tex荷送人コード = new is2AdminClient.共通テキストボックス();
            this.btn検索 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab荷送人タイトル = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texメッセージ = new is2AdminClient.共通テキストボックス();
            this.btn閉じる = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT荷送人)).BeginInit();
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
            this.panel1.Controls.Add(this.axGT荷送人);
            this.panel1.Controls.Add(this.btn確定);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(741, 380);
            this.panel1.TabIndex = 1;
            // 
            // lab頁番号
            // 
            this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab頁番号.ForeColor = System.Drawing.Color.Green;
            this.lab頁番号.Location = new System.Drawing.Point(600, 316);
            this.lab頁番号.Name = "lab頁番号";
            this.lab頁番号.Size = new System.Drawing.Size(48, 14);
            this.lab頁番号.TabIndex = 79;
            this.lab頁番号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn次頁
            // 
            this.btn次頁.BackColor = System.Drawing.Color.SteelBlue;
            this.btn次頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn次頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn次頁.ForeColor = System.Drawing.Color.White;
            this.btn次頁.Location = new System.Drawing.Point(648, 312);
            this.btn次頁.Name = "btn次頁";
            this.btn次頁.Size = new System.Drawing.Size(48, 22);
            this.btn次頁.TabIndex = 78;
            this.btn次頁.TabStop = false;
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
            this.btn前頁.Location = new System.Drawing.Point(552, 312);
            this.btn前頁.Name = "btn前頁";
            this.btn前頁.Size = new System.Drawing.Size(48, 22);
            this.btn前頁.TabIndex = 77;
            this.btn前頁.TabStop = false;
            this.btn前頁.Text = "前頁";
            this.btn前頁.UseVisualStyleBackColor = false;
            this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
            // 
            // axGT荷送人
            // 
            this.axGT荷送人.DataSource = null;
            this.axGT荷送人.Location = new System.Drawing.Point(20, 14);
            this.axGT荷送人.Name = "axGT荷送人";
            this.axGT荷送人.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT荷送人.OcxState")));
            this.axGT荷送人.Size = new System.Drawing.Size(696, 289);
            this.axGT荷送人.TabIndex = 4;
            this.axGT荷送人.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT荷送人_CurPlaceChanged);
            this.axGT荷送人.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT荷送人_CelDblClick);
            this.axGT荷送人.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT荷送人_KeyDownEvent);
            // 
            // btn確定
            // 
            this.btn確定.BackColor = System.Drawing.Color.Blue;
            this.btn確定.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn確定.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn確定.ForeColor = System.Drawing.Color.White;
            this.btn確定.Location = new System.Drawing.Point(650, 352);
            this.btn確定.Name = "btn確定";
            this.btn確定.Size = new System.Drawing.Size(64, 22);
            this.btn確定.TabIndex = 5;
            this.btn確定.Text = "確定";
            this.btn確定.UseVisualStyleBackColor = false;
            this.btn確定.Click += new System.EventHandler(this.btn確定_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.texカナ略称);
            this.panel5.Controls.Add(this.labカナ略称);
            this.panel5.Controls.Add(this.lab荷送人コード);
            this.panel5.Controls.Add(this.tex荷送人コード);
            this.panel5.Controls.Add(this.btn検索);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 60);
            this.panel5.TabIndex = 3;
            // 
            // texカナ略称
            // 
            this.texカナ略称.BackColor = System.Drawing.SystemColors.Window;
            this.texカナ略称.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texカナ略称.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.texカナ略称.Location = new System.Drawing.Point(54, 6);
            this.texカナ略称.MaxLength = 10;
            this.texカナ略称.Name = "texカナ略称";
            this.texカナ略称.Size = new System.Drawing.Size(120, 23);
            this.texカナ略称.TabIndex = 1;
            // 
            // labカナ略称
            // 
            this.labカナ略称.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labカナ略称.ForeColor = System.Drawing.Color.LimeGreen;
            this.labカナ略称.Location = new System.Drawing.Point(8, 10);
            this.labカナ略称.Name = "labカナ略称";
            this.labカナ略称.Size = new System.Drawing.Size(34, 16);
            this.labカナ略称.TabIndex = 46;
            this.labカナ略称.Text = "カナ";
            // 
            // lab荷送人コード
            // 
            this.lab荷送人コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab荷送人コード.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab荷送人コード.Location = new System.Drawing.Point(8, 34);
            this.lab荷送人コード.Name = "lab荷送人コード";
            this.lab荷送人コード.Size = new System.Drawing.Size(44, 16);
            this.lab荷送人コード.TabIndex = 6;
            this.lab荷送人コード.Text = "コード";
            // 
            // tex荷送人コード
            // 
            this.tex荷送人コード.BackColor = System.Drawing.SystemColors.Window;
            this.tex荷送人コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex荷送人コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex荷送人コード.Location = new System.Drawing.Point(54, 30);
            this.tex荷送人コード.MaxLength = 12;
            this.tex荷送人コード.Name = "tex荷送人コード";
            this.tex荷送人コード.Size = new System.Drawing.Size(166, 23);
            this.tex荷送人コード.TabIndex = 2;
            this.tex荷送人コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex荷送人コード_KeyDown);
            // 
            // btn検索
            // 
            this.btn検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn検索.ForeColor = System.Drawing.Color.White;
            this.btn検索.Location = new System.Drawing.Point(292, 32);
            this.btn検索.Name = "btn検索";
            this.btn検索.Size = new System.Drawing.Size(64, 22);
            this.btn検索.TabIndex = 3;
            this.btn検索.TabStop = false;
            this.btn検索.Text = "検索";
            this.btn検索.UseVisualStyleBackColor = false;
            this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab荷送人タイトル);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(794, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab荷送人タイトル
            // 
            this.lab荷送人タイトル.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab荷送人タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab荷送人タイトル.ForeColor = System.Drawing.Color.White;
            this.lab荷送人タイトル.Location = new System.Drawing.Point(12, 2);
            this.lab荷送人タイトル.Name = "lab荷送人タイトル";
            this.lab荷送人タイトル.Size = new System.Drawing.Size(264, 24);
            this.lab荷送人タイトル.TabIndex = 0;
            this.lab荷送人タイトル.Text = "荷送人検索";
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
            this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texメッセージ.ForeColor = System.Drawing.Color.Red;
            this.texメッセージ.Location = new System.Drawing.Point(416, 4);
            this.texメッセージ.Multiline = true;
            this.texメッセージ.Name = "texメッセージ";
            this.texメッセージ.ReadOnly = true;
            this.texメッセージ.Size = new System.Drawing.Size(376, 50);
            this.texメッセージ.TabIndex = 7;
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
            this.panel6.Size = new System.Drawing.Size(794, 26);
            this.panel6.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Location = new System.Drawing.Point(26, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(26, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 388);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // 荷送人検索
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(794, 575);
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
            this.Name = "荷送人検索";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 荷送人検索";
            this.Activated += new System.EventHandler(this.荷送人検索_Activated);
            this.Closed += new System.EventHandler(this.荷送人検索_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGT荷送人)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
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
		private void Form1_Load(object sender, System.EventArgs e)
		{
			iアクティブＦＧ = 0;
			tex荷送人コード.Text = s荷送人コード;
			axGT荷送人.Cols = 5;
			axGT荷送人.Rows = 15;
			axGT荷送人.ColSep = "|";
			axGT荷送人.CaretRow = 1;
			axGT荷送人.NoBeep = true;
			
			axGT荷送人.set_RowsText(0, "|名前|住所|コード|電話番号|カナ略称|");

			axGT荷送人.ColsWidth = "0|14.2|14.2|9.7|8.6|7|";
			axGT荷送人.ColsAlignHorz = "1|0|0|0|0|0|";

//			axGT荷送人.set_CelForeColor(axGT荷送人.CaretRow,0,111111);
			axGT荷送人.set_CelForeColor(axGT荷送人.CaretRow,0,0x98FB98);  //BGR
			axGT荷送人.set_CelBackColor(axGT荷送人.CaretRow,0,0x006000);
			
			btn前頁.Enabled = false;
			btn次頁.Enabled = false;
			lab頁番号.Text = "";
			i現在頁数 = 1;
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			s荷送人コード = "";
			this.Close();
		}

		private void axGT荷送人_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			s荷送人コード = axGT荷送人.get_CelText(axGT荷送人.CaretRow,3);
			if(s荷送人コード != "")
				this.Close();
		}

		private void axGT荷送人_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT荷送人.set_CelForeColor(nOldRow,0,0);
			axGT荷送人.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT荷送人.set_CelForeColor(axGT荷送人.CaretRow,0,111111);
			axGT荷送人.set_CelForeColor(axGT荷送人.CaretRow,0,0x98FB98);  //BGR
			axGT荷送人.set_CelBackColor(axGT荷送人.CaretRow,0,0x006000);
			nOldRow = axGT荷送人.CaretRow;

		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			荷送人一覧検索();
		}

		private void btn確定_Click(object sender, System.EventArgs e)
		{
			s荷送人コード = axGT荷送人.get_CelText(axGT荷送人.CaretRow,3);
			if(s荷送人コード != "")
				this.Close();
		}

		private void 荷送人一覧検索()
		{
			iアクティブＦＧ = 1;
			texカナ略称.Text   = texカナ略称.Text.Trim();
			tex荷送人コード.Text = tex荷送人コード.Text.Trim();
			if(!半角チェック(texカナ略称, "カナ")) return;
			if(!半角チェック(tex荷送人コード, "コード")) return;

			axGT荷送人.Clear();

			texメッセージ.Text = "検索中．．．";

			s荷送人一覧 = new string[1];
			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey  = new string[4];
				sKey[0] = s会員コード;
				sKey[1] = s部門コード;
				sKey[2] = tex荷送人コード.Text;
				sKey[3] = texカナ略称.Text;
				s荷送人一覧 = sv_maintenance.Get_Consignor(gsaユーザ, sKey);
			}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 START
			catch (System.Net.WebException)
			{
				s荷送人一覧[0] = gs通信エラー;
			}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 END
			catch (Exception ex)
			{
				s荷送人一覧[0] = "通信エラー：" + ex.Message;
			}
				
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;
			
			if (s荷送人一覧[0].Equals("正常終了"))
			{
				texメッセージ.Text = "";
// MOD 2005.05.12 東都）小童谷 一行目空白 START
//				i最大頁数 = (s荷送人一覧.Length - 2) / axGT荷送人.Rows + 1;
				i最大頁数 = (s荷送人一覧.Length - 2) / (axGT荷送人.Rows - 1) + 1;
// MOD 2005.05.12 東都）小童谷 一行目空白 END
				if (i現在頁数 > i最大頁数)
					i現在頁数 = i最大頁数;
				頁情報設定();

// ADD 2005.05.12 東都）小童谷 一行目選択 START
				axGT荷送人.CaretRow = 1;
				axGT荷送人_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END

				axGT荷送人.Focus();
			}
			else
			{
				if (s荷送人一覧[0].Equals("該当データがありません"))
				{
					texメッセージ.Text = "";
					MessageBox.Show("該当データがありません","荷送人検索",MessageBoxButtons.OK);
				}
				else
				{
					texメッセージ.Text = s荷送人一覧[0];
					i現在頁数 = 1;
					btn前頁.Enabled = false;
					btn次頁.Enabled = false;
					lab頁番号.Text = "";
					ビープ音();
				}
				texカナ略称.Focus();
			}
		}

		private void axGT荷送人_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 0x0d)
			{
				s荷送人コード = axGT荷送人.get_CelText(axGT荷送人.CaretRow,3);
				if(s荷送人コード != "")
					this.Close();
			}
			if (e.keyCode == 0x09)
			{
				this.SelectNextControl(axGT荷送人, true, true, true, true);
			}
		}

		private void tex荷送人コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				荷送人一覧検索();
			}		
		}


		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();
// ADD 2005.05.12 東都）小童谷 一行目選択 START
			axGT荷送人.CaretRow = 1;
			axGT荷送人_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();
// ADD 2005.05.12 東都）小童谷 一行目選択 START
			axGT荷送人.CaretRow = 1;
			axGT荷送人_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END
		}

		private void 頁情報設定()
		{
			axGT荷送人.Clear();

// MOD 2005.05.12 東都）小童谷 一行目空白 START
//			i開始数 = (i現在頁数 - 1) * axGT荷送人.Rows + 1;
			i開始数 = (i現在頁数 - 1) * (axGT荷送人.Rows - 1) + 1;
//			i終了数 = i現在頁数 * axGT荷送人.Rows;
			i終了数 = i現在頁数 * (axGT荷送人.Rows - 1);

//			short s表示数 = (short)1;
			short s表示数 = (short)2;
// MOD 2005.05.12 東都）小童谷 一行目空白 END
			for(short sCnt = (short)i開始数; sCnt < s荷送人一覧.Length && sCnt <= i終了数 ; sCnt++)
			{
				axGT荷送人.set_RowsText(s表示数, s荷送人一覧[sCnt]);
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
			axGT荷送人.Focus();
		}

		private void 荷送人検索_Activated(object sender, System.EventArgs e)
		{
			if(iアクティブＦＧ == 0)
				荷送人一覧検索();
		}

// ADD 2005.05.25 東都）小童谷 フォーカス移動 START
		private void 荷送人検索_Closed(object sender, System.EventArgs e)
		{
			texカナ略称.Text     = " ";
			tex荷送人コード.Text = "";
			axGT荷送人.CaretRow = 1;
			axGT荷送人_CurPlaceChanged(null,null);
			texカナ略称.Focus();
		}
// ADD 2005.05.25 東都）小童谷 フォーカス移動 END

	}
}
