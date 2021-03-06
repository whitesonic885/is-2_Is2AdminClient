using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [住所検索]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	public class 住所検索 : 共通フォーム
	{
		public short OldRow = 0;
		public string s郵便番号１ = "";
		public string s郵便番号２ = "";
		public string s管理店所   = "";
		public string s住所       = "";
		public string s住所ＣＤ   = "";
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
		public string sお客様ＣＤ   = "";
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
		private string s都道府県ＣＤ = "";
		private string s市区町村ＣＤ = "";

		private string[] s住所一覧;
		private int      i現在頁数;
		private int      i最大頁数;
		private int      i開始数;
		private int      i終了数;
		private int      iアクティブＦＧ = 0;

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lab郵便番号;
		private System.Windows.Forms.Label lab都道府県;
		private System.Windows.Forms.Label lab住所検索タイトル;
		private System.Windows.Forms.Button btn確定;
		private System.Windows.Forms.ComboBox cmb都道府県;
		private 共通テキストボックス tex郵便番号２;
		private 共通テキストボックス tex郵便番号１;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Button btn検索;
		private AxGTABLE32V2Lib.AxGTable32 axGT住所;
		private System.Windows.Forms.Label lab住所;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 住所検索()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(住所検索));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lab頁番号 = new System.Windows.Forms.Label();
            this.btn次頁 = new System.Windows.Forms.Button();
            this.btn前頁 = new System.Windows.Forms.Button();
            this.lab住所 = new System.Windows.Forms.Label();
            this.axGT住所 = new AxGTABLE32V2Lib.AxGTable32();
            this.btn確定 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cmb都道府県 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tex郵便番号２ = new is2AdminClient.共通テキストボックス();
            this.tex郵便番号１ = new is2AdminClient.共通テキストボックス();
            this.lab郵便番号 = new System.Windows.Forms.Label();
            this.lab都道府県 = new System.Windows.Forms.Label();
            this.btn検索 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab住所検索タイトル = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texメッセージ = new is2AdminClient.共通テキストボックス();
            this.btn閉じる = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT住所)).BeginInit();
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
            this.panel1.Controls.Add(this.lab住所);
            this.panel1.Controls.Add(this.axGT住所);
            this.panel1.Controls.Add(this.btn確定);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 380);
            this.panel1.TabIndex = 0;
            // 
            // lab頁番号
            // 
            this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab頁番号.ForeColor = System.Drawing.Color.Green;
            this.lab頁番号.Location = new System.Drawing.Point(236, 330);
            this.lab頁番号.Name = "lab頁番号";
            this.lab頁番号.Size = new System.Drawing.Size(48, 14);
            this.lab頁番号.TabIndex = 70;
            this.lab頁番号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn次頁
            // 
            this.btn次頁.BackColor = System.Drawing.Color.SteelBlue;
            this.btn次頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn次頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn次頁.ForeColor = System.Drawing.Color.White;
            this.btn次頁.Location = new System.Drawing.Point(284, 326);
            this.btn次頁.Name = "btn次頁";
            this.btn次頁.Size = new System.Drawing.Size(48, 22);
            this.btn次頁.TabIndex = 7;
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
            this.btn前頁.Location = new System.Drawing.Point(188, 326);
            this.btn前頁.Name = "btn前頁";
            this.btn前頁.Size = new System.Drawing.Size(48, 22);
            this.btn前頁.TabIndex = 6;
            this.btn前頁.Text = "前頁";
            this.btn前頁.UseVisualStyleBackColor = false;
            this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
            // 
            // lab住所
            // 
            this.lab住所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.lab住所.ForeColor = System.Drawing.Color.Green;
            this.lab住所.Location = new System.Drawing.Point(30, 6);
            this.lab住所.Name = "lab住所";
            this.lab住所.Size = new System.Drawing.Size(314, 20);
            this.lab住所.TabIndex = 4;
            // 
            // axGT住所
            // 
            this.axGT住所.DataSource = null;
            this.axGT住所.Location = new System.Drawing.Point(40, 32);
            this.axGT住所.Name = "axGT住所";
            this.axGT住所.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT住所.OcxState")));
            this.axGT住所.Size = new System.Drawing.Size(293, 290);
            this.axGT住所.TabIndex = 5;
            this.axGT住所.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT住所_CurPlaceChanged);
            this.axGT住所.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT住所_CelDblClick);
            this.axGT住所.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT住所_KeyDownEvent);
            // 
            // btn確定
            // 
            this.btn確定.BackColor = System.Drawing.Color.Blue;
            this.btn確定.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn確定.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn確定.ForeColor = System.Drawing.Color.White;
            this.btn確定.Location = new System.Drawing.Point(302, 354);
            this.btn確定.Name = "btn確定";
            this.btn確定.Size = new System.Drawing.Size(64, 22);
            this.btn確定.TabIndex = 8;
            this.btn確定.Text = "確定";
            this.btn確定.UseVisualStyleBackColor = false;
            this.btn確定.Click += new System.EventHandler(this.btn確定_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.cmb都道府県);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.tex郵便番号２);
            this.panel5.Controls.Add(this.tex郵便番号１);
            this.panel5.Controls.Add(this.lab郵便番号);
            this.panel5.Controls.Add(this.lab都道府県);
            this.panel5.Controls.Add(this.btn検索);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 60);
            this.panel5.TabIndex = 0;
            // 
            // cmb都道府県
            // 
            this.cmb都道府県.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb都道府県.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmb都道府県.Location = new System.Drawing.Point(88, 32);
            this.cmb都道府県.Name = "cmb都道府県";
            this.cmb都道府県.Size = new System.Drawing.Size(102, 24);
            this.cmb都道府県.TabIndex = 2;
            this.cmb都道府県.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmb都道府県_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(124, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "-";
            // 
            // tex郵便番号２
            // 
            this.tex郵便番号２.BackColor = System.Drawing.SystemColors.Window;
            this.tex郵便番号２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex郵便番号２.Location = new System.Drawing.Point(140, 6);
            this.tex郵便番号２.MaxLength = 4;
            this.tex郵便番号２.Name = "tex郵便番号２";
            this.tex郵便番号２.Size = new System.Drawing.Size(42, 23);
            this.tex郵便番号２.TabIndex = 1;
            this.tex郵便番号２.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex郵便番号２_KeyDown);
            // 
            // tex郵便番号１
            // 
            this.tex郵便番号１.BackColor = System.Drawing.SystemColors.Window;
            this.tex郵便番号１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex郵便番号１.Location = new System.Drawing.Point(88, 6);
            this.tex郵便番号１.MaxLength = 3;
            this.tex郵便番号１.Name = "tex郵便番号１";
            this.tex郵便番号１.Size = new System.Drawing.Size(34, 23);
            this.tex郵便番号１.TabIndex = 0;
            // 
            // lab郵便番号
            // 
            this.lab郵便番号.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab郵便番号.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab郵便番号.Location = new System.Drawing.Point(8, 10);
            this.lab郵便番号.Name = "lab郵便番号";
            this.lab郵便番号.Size = new System.Drawing.Size(76, 16);
            this.lab郵便番号.TabIndex = 46;
            this.lab郵便番号.Text = "郵便番号";
            // 
            // lab都道府県
            // 
            this.lab都道府県.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab都道府県.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab都道府県.Location = new System.Drawing.Point(8, 34);
            this.lab都道府県.Name = "lab都道府県";
            this.lab都道府県.Size = new System.Drawing.Size(76, 16);
            this.lab都道府県.TabIndex = 6;
            this.lab都道府県.Text = "都道府県";
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
            this.panel7.Controls.Add(this.lab住所検索タイトル);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab住所検索タイトル
            // 
            this.lab住所検索タイトル.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab住所検索タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab住所検索タイトル.ForeColor = System.Drawing.Color.White;
            this.lab住所検索タイトル.Location = new System.Drawing.Point(12, 2);
            this.lab住所検索タイトル.Name = "lab住所検索タイトル";
            this.lab住所検索タイトル.Size = new System.Drawing.Size(264, 24);
            this.lab住所検索タイトル.TabIndex = 0;
            this.lab住所検索タイトル.Text = "住所検索";
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
            this.texメッセージ.Location = new System.Drawing.Point(68, 4);
            this.texメッセージ.Multiline = true;
            this.texメッセージ.Name = "texメッセージ";
            this.texメッセージ.ReadOnly = true;
            this.texメッセージ.Size = new System.Drawing.Size(314, 50);
            this.texメッセージ.TabIndex = 0;
            this.texメッセージ.TabStop = false;
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
            // 住所検索
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
            this.Name = "住所検索";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 住所検索";
            this.Activated += new System.EventHandler(this.住所検索_Activated);
            this.Closed += new System.EventHandler(this.住所検索_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axGT住所)).EndInit();
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
			// 郵便番号の設定
			tex郵便番号１.Text = s郵便番号１;
			tex郵便番号２.Text = s郵便番号２;

			// 県名の初期設定
			cmb都道府県.Items.Clear();
			cmb都道府県.Items.AddRange(sa県);
			cmb都道府県.SelectedIndex = 0;

			axGT住所.Cols = 4;
			axGT住所.Rows = 15;
			axGT住所.ColSep = "|";
			axGT住所.CaretRow = 1;
			axGT住所.NoBeep = true;

			axGT住所.set_RowsText(0, "|郵便番号|住所|コード|店所");
			axGT住所.ColsWidth = "0|5.5|17|0|0|";
			axGT住所.ColsAlignHorz = "1|1|0|0|0|";
            
//			axGT住所.set_CelForeColor(axGT住所.CaretRow,0,111111);
			axGT住所.set_CelForeColor(axGT住所.CaretRow,0,0x98FB98);  //BGR
			axGT住所.set_CelBackColor(axGT住所.CaretRow,0,0x006000);

			btn前頁.Enabled = false;
			btn次頁.Enabled = false;
			lab頁番号.Text = "";
		}

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			s郵便番号１ = "";
			s郵便番号２ = "";
			this.Close();
		}

		private void axGT住所_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT住所.set_CelForeColor(OldRow,0,0);
			axGT住所.set_CelBackColor(OldRow,0,0xFFFFFF);
//			axGT住所.set_CelForeColor(axGT住所.CaretRow,0,111111);
			axGT住所.set_CelForeColor(axGT住所.CaretRow,0,0x98FB98);  //BGR
			axGT住所.set_CelBackColor(axGT住所.CaretRow,0,0x006000);
			OldRow = axGT住所.CaretRow;
		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			iアクティブＦＧ = 1;
			texメッセージ.Text = "";
			// 空白除去
			tex郵便番号１.Text = tex郵便番号１.Text.Trim();
			tex郵便番号２.Text = tex郵便番号２.Text.Trim();
			i現在頁数 = 1;

			if(tex郵便番号１.Text.Length == 3)
			{
				cmb都道府県.Text          = "";
				cmb都道府県.SelectedIndex = 0;
				s都道府県ＣＤ = "";
				s市区町村ＣＤ = "";
				lab住所.Text = "";
				axGT住所.Clear();

				s住所一覧 = new string[1];
				// カーソルを砂時計にする
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				try
				{
					texメッセージ.Text = "検索中．．．";
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if ((sお客様ＣＤ == "") || (sお客様ＣＤ.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
					s住所一覧 = sv_maintenance.Get_byPostcode(gsaユーザ, tex郵便番号１.Text + tex郵便番号２.Text);
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					}else{
						s住所一覧 = sv_oji.Get_byPostcodeM(gsaユーザ, tex郵便番号１.Text + tex郵便番号２.Text);
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

				
				}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 START
				catch (System.Net.WebException)
				{
					s住所一覧[0] = gs通信エラー;
				}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 END
				catch (Exception ex)
				{
					s住所一覧[0] = "通信エラー：" + ex.Message;
				}
				// カーソルをデフォルトに戻す
				Cursor = System.Windows.Forms.Cursors.Default;

				if (s住所一覧[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
// MOD 2005.05.12 東都）小童谷 一行目空白 START
//					i最大頁数 = (s住所一覧.Length - 2) / axGT住所.Rows + 1;
					i最大頁数 = (s住所一覧.Length - 2) / (axGT住所.Rows - 1) + 1;
// MOD 2005.05.12 東都）小童谷 一行目空白 END
					if (i現在頁数 > i最大頁数)
						i現在頁数 = i最大頁数;
					頁情報設定();

					axGT住所.Focus();
				}
				else
				{
					if (s住所一覧[0].Equals("該当データがありません"))
					{
						texメッセージ.Text = "";
						MessageBox.Show("該当データがありません","住所検索",MessageBoxButtons.OK);
					}
					else
					{
						texメッセージ.Text = s住所一覧[0];
						axGT住所.Clear();
						i現在頁数 = 1;
						btn前頁.Enabled = false;
						btn次頁.Enabled = false;
						lab頁番号.Text = "";
						ビープ音();
					}
					tex郵便番号１.Focus();
				}
			}
			else if(cmb都道府県.SelectedIndex > 0)
			{
				tex郵便番号１.Text = "";
				tex郵便番号２.Text = "";
				lab住所.Text = cmb都道府県.Text;
				s都道府県ＣＤ = cmb都道府県.SelectedIndex.ToString();
				s市区町村ＣＤ = "";
				if(s都道府県ＣＤ.Length == 1) s都道府県ＣＤ = "0" + s都道府県ＣＤ;
				axGT住所.Clear();

				s住所一覧 = new string[1];
				// カーソルを砂時計にする
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				try
				{
					texメッセージ.Text = "検索中．．．";
					s住所一覧 = sv_maintenance.Get_byKen(gsaユーザ, s都道府県ＣＤ);
				}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 START
				catch (System.Net.WebException)
				{
					s住所一覧[0] = gs通信エラー;
				}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 END
				catch (Exception ex)
				{
					s住所一覧[0] = "通信エラー：" + ex.Message;
				}
				// カーソルをデフォルトに戻す
				Cursor = System.Windows.Forms.Cursors.Default;

				if(s住所一覧[0].Length == 4)
				{
					texメッセージ.Text = "";
// MOD 2005.05.12 東都）小童谷 一行目空白 START
//					i最大頁数 = (s住所一覧.Length - 2) / axGT住所.Rows + 1;
					i最大頁数 = (s住所一覧.Length - 2) / (axGT住所.Rows - 1) + 1;
// MOD 2005.05.12 東都）小童谷 一行目空白 END
					if (i現在頁数 > i最大頁数)
						i現在頁数 = i最大頁数;
					頁情報設定();

// ADD 2005.05.12 東都）小童谷 一行目選択 START
					axGT住所.CaretRow = 1;
					axGT住所_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END

					axGT住所.Focus();
				}
				else
				{
					texメッセージ.Text = s住所一覧[0];
					axGT住所.Clear();
					i現在頁数 = 1;
					btn前頁.Enabled = false;
					btn次頁.Enabled = false;
					lab頁番号.Text = "";
					ビープ音();
					cmb都道府県.Focus();
				}
			}
			else if (axGT住所.Focused == true)
			{
			
				tex郵便番号１.Focus();
			}
		}

		private void tex郵便番号２_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btn検索_Click(sender, e);
				return;
			}
		}

		private void cmb都道府県_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				btn検索_Click(sender, e);
				return;
			}
		}

		private void btn確定_Click(object sender, System.EventArgs e)
		{
			if(axGT住所.CaretRow < 0) return;
			if(axGT住所.get_CelText(axGT住所.CaretRow,3).Length == 0) return;
			if(s市区町村ＣＤ.Length == 0 && s都道府県ＣＤ.Length > 0)
			{
				i現在頁数 = 1;

				texメッセージ.Text = "";
				lab住所.Text += axGT住所.get_CelText(axGT住所.CaretRow,2);
				s市区町村ＣＤ = axGT住所.get_CelText(axGT住所.CaretRow,3);

				s住所一覧 = new string[1];
				// カーソルを砂時計にする
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				try
				{
					texメッセージ.Text = "検索中．．．";
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if ((sお客様ＣＤ == "") || (sお客様ＣＤ.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
						s住所一覧 = sv_maintenance.Get_byKenShi(gsaユーザ, s都道府県ＣＤ,s市区町村ＣＤ);
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					}else{
						s住所一覧 = sv_oji.Get_byKenShiM(gsaユーザ, s都道府県ＣＤ,s市区町村ＣＤ);
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
				}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 START
				catch (System.Net.WebException)
				{
					s住所一覧[0] = gs通信エラー;
				}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 END
				catch (Exception ex)
				{
					s住所一覧[0] = "通信エラー：" + ex.Message;
				}
				// カーソルをデフォルトに戻す
				Cursor = System.Windows.Forms.Cursors.Default;

				if(s住所一覧[0].Length == 4)
				{
					texメッセージ.Text = "";
					axGT住所.Clear();
// MOD 2005.05.12 東都）小童谷 一行目空白 START
//					i最大頁数 = (s住所一覧.Length - 2) / axGT住所.Rows + 1;
					i最大頁数 = (s住所一覧.Length - 2) / (axGT住所.Rows - 1) + 1;
// MOD 2005.05.12 東都）小童谷 一行目空白 END
					if (i現在頁数 > i最大頁数)
						i現在頁数 = i最大頁数;
					頁情報設定();

// ADD 2005.05.12 東都）小童谷 一行目選択 START
					axGT住所.CaretRow = 1;
					axGT住所_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END

					axGT住所.Focus();
				}
				else
				{
					texメッセージ.Text = s住所一覧[0];
					ビープ音();
					axGT住所.Focus();
				}
			}
			else
			{
				lab住所.Text += axGT住所.get_CelText(axGT住所.CaretRow,2);
				s郵便番号１ = axGT住所.get_CelText(axGT住所.CaretRow,1);
				s郵便番号１ = s郵便番号１.Replace("-","");
				if(s郵便番号１.Length > 3)
				{
					s郵便番号２ = s郵便番号１.Substring(3);
					s郵便番号１ = s郵便番号１.Substring(0,3);
				}
				s住所       = lab住所.Text;
				s住所ＣＤ   = axGT住所.get_CelText(axGT住所.CaretRow,3);
				s管理店所   = axGT住所.get_CelText(axGT住所.CaretRow,4);
				//ダイアログを閉じる
				this.Close();
			}
		}

		private void axGT住所_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			btn確定_Click(sender, null);
		}

		private void axGT住所_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 13)
			{
				btn確定_Click(sender, null);
			}
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT住所, true, true, true, true);
			}
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();
// ADD 2005.05.12 東都）小童谷 一行目選択 START
			axGT住所.CaretRow = 1;
			axGT住所_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();
// ADD 2005.05.12 東都）小童谷 一行目選択 START
			axGT住所.CaretRow = 1;
			axGT住所_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END
		}

		private void 頁情報設定()
		{
			axGT住所.Clear();

// MOD 2005.05.12 東都）小童谷 一行目空白 START
//			i開始数 = (i現在頁数 - 1) * axGT住所.Rows + 1;
			i開始数 = (i現在頁数 - 1) * (axGT住所.Rows - 1) + 1;
//			i終了数 = i現在頁数 * axGT住所.Rows;
			i終了数 = i現在頁数 * (axGT住所.Rows - 1);

//			short s表示数 = (short)1;
			short s表示数 = (short)2;
// MOD 2005.05.12 東都）小童谷 一行目空白 START
			for(short sCnt = (short)i開始数; sCnt < s住所一覧.Length && sCnt <= i終了数 ; sCnt++)
			{
				axGT住所.set_RowsText(s表示数, s住所一覧[sCnt]);
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
			axGT住所.Focus();
		}

		private void 住所検索_Activated(object sender, System.EventArgs e)
		{
			if(tex郵便番号１.Text.Trim().Length == 3 && iアクティブＦＧ == 0)
				btn検索_Click(sender,e);
		}

// ADD 2005.05.25 東都）小童谷 フォーカス移動 START
		private void 住所検索_Closed(object sender, System.EventArgs e)
		{
			lab住所.Text = "";
			axGT住所.Clear();
			axGT住所.CaretRow = 1;
			axGT住所_CurPlaceChanged(null,null);
			tex郵便番号１.Focus();
		}
// ADD 2005.05.24 東都）小童谷 フォーカス移動 END

	}
}
