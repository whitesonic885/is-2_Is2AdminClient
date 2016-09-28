using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [記事登録]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 
	// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 
	//--------------------------------------------------------------------------
	// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 
	//--------------------------------------------------------------------------
	public class 記事登録 : 共通フォーム
	{

		private short    nOldRow    = 0;
		private string   s更新日時 = "";
		private string   s記事会員;
		private string   s記事部門;
		private string[] s記事一覧;
		private string[] s輸送商品親一覧;
		private int      i現在頁数;
		private int      i最大頁数;
		private int      i開始数;
		private int      i終了数;
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label lab記事タイトル;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private AxGTABLE32V2Lib.AxGTable32 axGT記事;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab記事名;
		private 共通テキストボックス tex記事名;
		private System.Windows.Forms.Label label4;
		private 共通テキストボックス tex記事コード;
		private System.Windows.Forms.Button btn削除;
		private System.Windows.Forms.Button btn更新;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmb記事種別;
		private System.Windows.Forms.ComboBox cmb輸送商品親;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 記事登録()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(記事登録));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb輸送商品親 = new System.Windows.Forms.ComboBox();
            this.cmb記事種別 = new System.Windows.Forms.ComboBox();
            this.lab頁番号 = new System.Windows.Forms.Label();
            this.btn次頁 = new System.Windows.Forms.Button();
            this.btn前頁 = new System.Windows.Forms.Button();
            this.btn更新 = new System.Windows.Forms.Button();
            this.btn削除 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tex記事コード = new is2AdminClient.共通テキストボックス();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab記事名 = new System.Windows.Forms.Label();
            this.tex記事名 = new is2AdminClient.共通テキストボックス();
            this.axGT記事 = new AxGTABLE32V2Lib.AxGTable32();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab記事タイトル = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texメッセージ = new System.Windows.Forms.TextBox();
            this.btn閉じる = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT記事)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.cmb輸送商品親);
            this.panel1.Controls.Add(this.cmb記事種別);
            this.panel1.Controls.Add(this.lab頁番号);
            this.panel1.Controls.Add(this.btn次頁);
            this.panel1.Controls.Add(this.btn前頁);
            this.panel1.Controls.Add(this.btn更新);
            this.panel1.Controls.Add(this.btn削除);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tex記事コード);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lab記事名);
            this.panel1.Controls.Add(this.tex記事名);
            this.panel1.Controls.Add(this.axGT記事);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 440);
            this.panel1.TabIndex = 0;
            // 
            // cmb輸送商品親
            // 
            this.cmb輸送商品親.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb輸送商品親.Location = new System.Drawing.Point(220, 10);
            this.cmb輸送商品親.Name = "cmb輸送商品親";
            this.cmb輸送商品親.Size = new System.Drawing.Size(138, 20);
            this.cmb輸送商品親.TabIndex = 2;
            this.cmb輸送商品親.SelectionChangeCommitted += new System.EventHandler(this.cmb輸送商品親_SelectionChangeCommitted);
            // 
            // cmb記事種別
            // 
            this.cmb記事種別.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb記事種別.Items.AddRange(new object[] {
            "輸送商品",
            "輸送商品　備考",
            "王子運送 輸送商品",
            "王子運送 輸送商品 備考",
            "初期提供の品名記事"});
            this.cmb記事種別.Location = new System.Drawing.Point(64, 10);
            this.cmb記事種別.Name = "cmb記事種別";
            this.cmb記事種別.Size = new System.Drawing.Size(154, 20);
            this.cmb記事種別.TabIndex = 1;
            this.cmb記事種別.SelectionChangeCommitted += new System.EventHandler(this.cmb記事種別_SelectionChangeCommitted);
            // 
            // lab頁番号
            // 
            this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab頁番号.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab頁番号.Location = new System.Drawing.Point(250, 322);
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
            this.btn次頁.Location = new System.Drawing.Point(298, 318);
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
            this.btn前頁.Location = new System.Drawing.Point(202, 318);
            this.btn前頁.Name = "btn前頁";
            this.btn前頁.Size = new System.Drawing.Size(48, 22);
            this.btn前頁.TabIndex = 62;
            this.btn前頁.Text = "前頁";
            this.btn前頁.UseVisualStyleBackColor = false;
            this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
            // 
            // btn更新
            // 
            this.btn更新.BackColor = System.Drawing.Color.SteelBlue;
            this.btn更新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn更新.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn更新.ForeColor = System.Drawing.Color.White;
            this.btn更新.Location = new System.Drawing.Point(210, 410);
            this.btn更新.Name = "btn更新";
            this.btn更新.Size = new System.Drawing.Size(64, 22);
            this.btn更新.TabIndex = 6;
            this.btn更新.Text = "保存";
            this.btn更新.UseVisualStyleBackColor = false;
            this.btn更新.Click += new System.EventHandler(this.btn更新_Click);
            // 
            // btn削除
            // 
            this.btn削除.BackColor = System.Drawing.Color.SteelBlue;
            this.btn削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn削除.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn削除.ForeColor = System.Drawing.Color.White;
            this.btn削除.Location = new System.Drawing.Point(282, 410);
            this.btn削除.Name = "btn削除";
            this.btn削除.Size = new System.Drawing.Size(64, 22);
            this.btn削除.TabIndex = 7;
            this.btn削除.Text = "削除";
            this.btn削除.UseVisualStyleBackColor = false;
            this.btn削除.Click += new System.EventHandler(this.btn削除_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(82, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 14);
            this.label4.TabIndex = 61;
            this.label4.Text = "記事コード";
            // 
            // tex記事コード
            // 
            this.tex記事コード.BackColor = System.Drawing.SystemColors.Window;
            this.tex記事コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex記事コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex記事コード.Location = new System.Drawing.Point(144, 348);
            this.tex記事コード.MaxLength = 4;
            this.tex記事コード.Name = "tex記事コード";
            this.tex記事コード.Size = new System.Drawing.Size(42, 23);
            this.tex記事コード.TabIndex = 4;
            this.tex記事コード.Text = "1234";
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(68, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 59;
            this.label2.Text = "※";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(68, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 14);
            this.label1.TabIndex = 57;
            this.label1.Text = "※";
            // 
            // lab記事名
            // 
            this.lab記事名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab記事名.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab記事名.Location = new System.Drawing.Point(82, 382);
            this.lab記事名.Name = "lab記事名";
            this.lab記事名.Size = new System.Drawing.Size(58, 14);
            this.lab記事名.TabIndex = 56;
            this.lab記事名.Text = "記事名";
            // 
            // tex記事名
            // 
            this.tex記事名.BackColor = System.Drawing.SystemColors.Window;
            this.tex記事名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex記事名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.tex記事名.Location = new System.Drawing.Point(144, 378);
            this.tex記事名.MaxLength = 15;
            this.tex記事名.Name = "tex記事名";
            this.tex記事名.Size = new System.Drawing.Size(206, 23);
            this.tex記事名.TabIndex = 5;
            // 
            // axGT記事
            // 
            this.axGT記事.DataSource = null;
            this.axGT記事.Location = new System.Drawing.Point(80, 38);
            this.axGT記事.Name = "axGT記事";
            this.axGT記事.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT記事.OcxState")));
            this.axGT記事.Size = new System.Drawing.Size(194, 272);
            this.axGT記事.TabIndex = 3;
            this.axGT記事.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT記事_CurPlaceChanged);
            this.axGT記事.CelClick += new AxGTABLE32V2Lib._DGTable32Events_CelClickEventHandler(this.axGT記事_CelClick);
            this.axGT記事.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT記事_KeyDownEvent);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab記事タイトル);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab記事タイトル
            // 
            this.lab記事タイトル.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab記事タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab記事タイトル.ForeColor = System.Drawing.Color.White;
            this.lab記事タイトル.Location = new System.Drawing.Point(12, 2);
            this.lab記事タイトル.Name = "lab記事タイトル";
            this.lab記事タイトル.Size = new System.Drawing.Size(264, 24);
            this.lab記事タイトル.TabIndex = 0;
            this.lab記事タイトル.Text = "記事登録";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.PaleGreen;
            this.panel8.Controls.Add(this.texメッセージ);
            this.panel8.Controls.Add(this.btn閉じる);
            this.panel8.Location = new System.Drawing.Point(0, 516);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(388, 58);
            this.panel8.TabIndex = 1;
            // 
            // texメッセージ
            // 
            this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
            this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.texメッセージ.ForeColor = System.Drawing.Color.Red;
            this.texメッセージ.Location = new System.Drawing.Point(126, 4);
            this.texメッセージ.Multiline = true;
            this.texメッセージ.Name = "texメッセージ";
            this.texメッセージ.ReadOnly = true;
            this.texメッセージ.Size = new System.Drawing.Size(256, 50);
            this.texメッセージ.TabIndex = 0;
            this.texメッセージ.TabStop = false;
            // 
            // btn閉じる
            // 
            this.btn閉じる.ForeColor = System.Drawing.Color.Red;
            this.btn閉じる.Location = new System.Drawing.Point(8, 6);
            this.btn閉じる.Name = "btn閉じる";
            this.btn閉じる.Size = new System.Drawing.Size(54, 48);
            this.btn閉じる.TabIndex = 8;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(8, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 448);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // 記事登録
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(390, 575);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(396, 607);
            this.Name = "記事登録";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 記事登録";
            this.Closed += new System.EventHandler(this.記事登録_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT記事)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
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
			axGT記事.Cols = 3;
			axGT記事.Rows = 14;
			axGT記事.ColSep = "|";

			axGT記事.set_RowsText(0, "|コード|記事|");

			axGT記事.ColsWidth = "0|4|10.9|0|";
			axGT記事.ColsAlignHorz = "1|1|0|0|";
            
//			axGT記事.set_CelForeColor(axGT記事.CaretRow,0,111111);
			axGT記事.set_CelForeColor(axGT記事.CaretRow,0,0x98FB98);  //BGR
			axGT記事.set_CelBackColor(axGT記事.CaretRow,0,0x006000);

			axGT記事.CaretRow = 1;
			cmb記事種別.SelectedIndex = 0;
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
			s記事会員 = "yusoshohin";
//			s記事部門 = "yusoshiji";
			s記事部門 = "0000";
			cmb輸送商品親.Visible = false;
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
			i現在頁数 = 1;
			記事一覧検索();
		}

		private void 記事一覧検索()
		{
			tex記事コード.Text = "";
			tex記事名.Text     = "";
			s更新日時        = "";
			
			s記事一覧 = new string[1];
			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
//				s記事一覧 = sv_maintenance.Get_Kiji(gsaユーザ,"default",s記事部門);
				s記事一覧 = sv_maintenance.Get_Kiji(gsaユーザ,s記事会員,s記事部門);
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
			}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 START
			catch (System.Net.WebException)
			{
				s記事一覧[0] = gs通信エラー;
			}
// ADD 2005.05.25 東都）小童谷 通信エラーのメッセージ修正 END
			catch (Exception ex)
			{
				s記事一覧[0] = "通信エラー：" + ex.Message;
			}
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			texメッセージ.Text = s記事一覧[0];
			if(s記事一覧[0].Length == 4) //正常終了
			{
				texメッセージ.Text = "";
				i最大頁数 = (s記事一覧.Length - 2) / axGT記事.Rows + 1;
				if (i現在頁数 > i最大頁数)
					i現在頁数 = i最大頁数;
				頁情報設定();
			}
			else
			{
				axGT記事.Clear();
				i現在頁数 = 1;
				btn前頁.Enabled = false;
				btn次頁.Enabled = false;
				lab頁番号.Text = "";
				ビープ音();
			}
		}

// ADD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
		private void 輸送商品親検索()
		{
			string[] sList = new string[1];
			cmb輸送商品親.Items.Clear();

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 START
//				sList = sv_maintenance.Get_Kiji(gsaユーザ,"yusoshohin","0000");
				sList = sv_maintenance.Get_Kiji(gsaユーザ,s記事会員,"0000");
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 END
			}
			catch (System.Net.WebException)
			{
				sList[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				sList[0] = "通信エラー：" + ex.Message;
			}
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			texメッセージ.Text = sList[0];
			if(sList[0].Length == 4) //正常終了
			{
				if (sList.Length > 1)
				{
					s輸送商品親一覧 = new string[sList.Length - 1];
					for (int iCnt = 1; iCnt < sList.Length; iCnt++)
					{
						string[] s輸送商品親 = sList[iCnt].Split('|');
						if (s輸送商品親.Length > 2)
						{
							s輸送商品親一覧[iCnt-1] = s輸送商品親[1];
							cmb輸送商品親.Items.Insert(iCnt - 1,s輸送商品親[2]);
						}
					}
				}
				else
				{
					s輸送商品親一覧 = null;
				}
			}
			else
			{
				s輸送商品親一覧 = null;
			}
			texメッセージ.Text = "";
		}
// ADD 2005.05.27 東都）伊賀 輸送商品仕様変更 END

		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void axGT記事_CelClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelClickEvent e)
		{
			tex記事コード.Text = axGT記事.get_CelText(axGT記事.CaretRow,1).Trim();
			tex記事名.Text     = axGT記事.get_CelText(axGT記事.CaretRow,2).TrimEnd();
			s更新日時        = axGT記事.get_CelText(axGT記事.CaretRow,3).Trim();
		}

		private void axGT記事_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT記事.set_CelForeColor(nOldRow,0,0);
			axGT記事.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT記事.set_CelForeColor(axGT記事.CaretRow,0,111111);
			axGT記事.set_CelForeColor(axGT記事.CaretRow,0,0x98FB98);  //BGR
			axGT記事.set_CelBackColor(axGT記事.CaretRow,0,0x006000);
			nOldRow = axGT記事.CaretRow;
			tex記事コード.Text = axGT記事.get_CelText(axGT記事.CaretRow,1).Trim();
			tex記事名.Text     = axGT記事.get_CelText(axGT記事.CaretRow,2).TrimEnd();
			s更新日時          = axGT記事.get_CelText(axGT記事.CaretRow,3).Trim();
		}

		private void axGT記事_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT記事, true, true, true, true);
			}
		}

		private void btn更新_Click(object sender, System.EventArgs e)
		{
			tex記事コード.Text = tex記事コード.Text.Trim();
			tex記事名.Text     = tex記事名.Text.TrimEnd();

			if(!必須チェック(tex記事コード,"記事コード")) return;
			if(!必須チェック(tex記事名,"記事名")) return;

			if(!半角チェック(tex記事コード,"記事コード")) return;
			if(!全角チェック(tex記事名,"記事名")) return;

// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 START
//			if(cmb記事種別.SelectedIndex > 2)
			if(cmb記事種別.SelectedIndex >= cmb記事種別.Items.Count)
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 END
			{
				MessageBox.Show("記事種別を選択してください",
					"入力チェック",MessageBoxButtons.OK);
				cmb記事種別.Focus();
				return;
			}

			try
			{
				texメッセージ.Text = "";
				// カーソルを砂時計にする
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
//				String[] sList = sv_maintenance.Sel_Kiji(gsaユーザ,"default",s記事部門,tex記事コード.Text);
				String[] sList = sv_maintenance.Sel_Kiji(gsaユーザ,s記事会員,s記事部門,tex記事コード.Text);
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
				// カーソルをデフォルトに戻す
				Cursor = System.Windows.Forms.Cursors.Default;

				// エラー時
				if(sList[0].Length != 2)
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					return;
				}

				string s更新ＦＧ = sList[3];

				// 更新日時がことなる場合
				if(s更新ＦＧ == "U" && s更新日時 != sList[2])
				{
					ビープ音();
					DialogResult rst;
					rst = MessageBox.Show("同一のコードが既に他の端末より登録されています。\n" 
										+ "記事一覧を最新にしますか？",
										"更新",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Error);
					if(rst == DialogResult.Yes)
					{
						記事一覧検索();
					}
					return;
				}

				String[] sIUList;
				string[] sData = new string[7];
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
//				sData[0]  = "default";
				sData[0]  = s記事会員;
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
				sData[1]  = s記事部門;
				sData[2]  = tex記事コード.Text;
				sData[3]  = tex記事名.Text;
				sData[4]  = "記事登録";
				sData[5]  = gs利用者コード;
				sData[6]  = s更新日時;

				DialogResult result;
				if(s更新ＦＧ == "I")
				{
					result = MessageBox.Show("新規登録しますか？","登録",MessageBoxButtons.YesNo);
					if(result == DialogResult.Yes)
					{
						texメッセージ.Text = "登録中．．．";
						// カーソルを砂時計にする
						Cursor = System.Windows.Forms.Cursors.AppStarting;
						sIUList = sv_maintenance.Ins_Kiji(gsaユーザ,sData);
						if(sIUList[0].Length == 4)
						{
							記事一覧検索();
						}
						else
						{
							texメッセージ.Text = sIUList[0];
							ビープ音();
						}
						// カーソルをデフォルトに戻す
						Cursor = System.Windows.Forms.Cursors.Default;
					}
				}
				else
				{
					result = MessageBox.Show("既に存在するデータに上書きしますか？","更新",MessageBoxButtons.YesNo);
					if(result == DialogResult.Yes)
					{
						// カーソルを砂時計にする
						Cursor = System.Windows.Forms.Cursors.AppStarting;
						texメッセージ.Text = "更新中．．．";
						sIUList = sv_maintenance.Upd_Kiji(gsaユーザ,sData);
						if(sIUList[0].Length == 4)
						{
							記事一覧検索();
						}
						else
						{
							texメッセージ.Text = sIUList[0];
							ビープ音();
						}
						// カーソルをデフォルトに戻す
						Cursor = System.Windows.Forms.Cursors.Default;
					}
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
		}

		private void btn削除_Click(object sender, System.EventArgs e)
		{
			// 空白除去
			tex記事コード.Text = tex記事コード.Text.Trim();

			if(!必須チェック(tex記事コード,"記事コード")) return;
			if(!半角チェック(tex記事コード,"記事コード")) return;
			
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 START
//			if(cmb記事種別.SelectedIndex > 2)
			if(cmb記事種別.SelectedIndex >= cmb記事種別.Items.Count)
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 END
			{
				MessageBox.Show("記事種別を選択してください",
					"入力チェック",MessageBoxButtons.OK);
				cmb記事種別.Focus();
				return;
			}

			try
			{
				texメッセージ.Text = "";
				// カーソルを砂時計にする
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
//				String[] sList = sv_maintenance.Sel_Kiji(gsaユーザ,"default",s記事部門,tex記事コード.Text);
				String[] sList = sv_maintenance.Sel_Kiji(gsaユーザ,s記事会員,s記事部門,tex記事コード.Text);
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
				// カーソルをデフォルトに戻す
				Cursor = System.Windows.Forms.Cursors.Default;

				string s更新ＦＧ = sList[3];

				String[] sDList;
				string[] sData = new string[5];

				DialogResult result;
				if(s更新ＦＧ == "I")
					MessageBox.Show("コード(" + tex記事コード.Text + ")のデータは存在しません","削除",MessageBoxButtons.OK);
				else
				{
					result = MessageBox.Show("コード(" + tex記事コード.Text + ")のデータを削除しますか？","削除",MessageBoxButtons.YesNo);
					if(result == DialogResult.Yes)
					{
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
//						sData[0] = "default";
						sData[0] = s記事会員;
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
						sData[1] = s記事部門;
						sData[2] = tex記事コード.Text;
						sData[3] = "記事登録";
						sData[4] = gs利用者コード;

						// カーソルを砂時計にする
						Cursor = System.Windows.Forms.Cursors.AppStarting;
						texメッセージ.Text = "削除中．．．";
						sDList = sv_maintenance.Del_Kiji(gsaユーザ,sData);

						if(sDList[0].Length == 4)
						{
							記事一覧検索();
						}
						else
						{
							texメッセージ.Text = sDList[0];
							ビープ音();
						}
						// カーソルをデフォルトに戻す
						Cursor = System.Windows.Forms.Cursors.Default;
					}
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();
		}
		
		private void 頁情報設定()
		{
			axGT記事.Clear();

			i開始数 = (i現在頁数 - 1) * axGT記事.Rows + 1;
			i終了数 = i現在頁数 * axGT記事.Rows;

			short s表示数 = (short)1;
			for(short sCnt = (short)i開始数; sCnt < s記事一覧.Length && sCnt <= i終了数 ; sCnt++)
			{
				axGT記事.set_RowsText(s表示数, s記事一覧[sCnt]);
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
			tex記事コード.Text = axGT記事.get_CelText(axGT記事.CaretRow,1).Trim();
			tex記事名.Text     = axGT記事.get_CelText(axGT記事.CaretRow,2).TrimEnd();
			s更新日時          = axGT記事.get_CelText(axGT記事.CaretRow,3).Trim();
		}

		private void cmb記事種別_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			//輸送商品親
			if (cmb記事種別.SelectedIndex == 0)
			{
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
				s記事会員 = "yusoshohin";
//				s記事部門 = "yusoshiji";
				s記事部門 = "0000";
				cmb輸送商品親.Visible = false;
// MOD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
				i現在頁数 = 1;
				記事一覧検索();
			}
// ADD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
			//輸送商品子
			else if (cmb記事種別.SelectedIndex == 1)
			{
				s記事会員 = "yusoshohin";
				輸送商品親検索();
				if (s輸送商品親一覧 != null)
				{
					cmb輸送商品親.Visible = true;
					cmb輸送商品親.SelectedIndex = 0;
					s記事部門 = s輸送商品親一覧[0];
				}
				else
				{
					cmb輸送商品親.Visible = false;
					s記事部門 = "";
				}
				記事一覧検索();
			}
// ADD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 START
			//王子運送 輸送商品親
			if (cmb記事種別.SelectedIndex == 2)
			{
				s記事会員 = "Jyusoshohin";
				s記事部門 = "0000";
				cmb輸送商品親.Visible = false;
				i現在頁数 = 1;
				記事一覧検索();
			}
			//王子運送 輸送商品子
			else if (cmb記事種別.SelectedIndex == 3)
			{
				s記事会員 = "Jyusoshohin";
				輸送商品親検索();
				if (s輸送商品親一覧 != null)
				{
					cmb輸送商品親.Visible = true;
					cmb輸送商品親.SelectedIndex = 0;
					s記事部門 = s輸送商品親一覧[0];
				}
				else
				{
					cmb輸送商品親.Visible = false;
					s記事部門 = "";
				}
				記事一覧検索();
			}
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 END
			//初期設定の品名記事
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 START
//			else if (cmb記事種別.SelectedIndex == 2)
			else if (cmb記事種別.SelectedIndex == 4)
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 END
			{
// ADD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
				s記事会員 = "default";
// ADD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
				s記事部門 = "0000";
				cmb輸送商品親.Visible = false;
				i現在頁数 = 1;
				記事一覧検索();
			}
			else
			{
				// ADD 2005.05.27 東都）伊賀 輸送商品仕様変更 START
				s記事会員 = "";
				// ADD 2005.05.27 東都）伊賀 輸送商品仕様変更 END
				s記事部門 = "";
			}
		}

		private void cmb輸送商品親_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			if (cmb輸送商品親.SelectedIndex < s輸送商品親一覧.Length)
			{
				s記事会員 = "yusoshohin";
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 START
				//王子運送 輸送商品親
				if(cmb記事種別.SelectedIndex == 2 
				|| cmb記事種別.SelectedIndex == 3){
					s記事会員 = "Jyusoshohin";
				}
// MOD 2011.06.07 東都）高木 王子運送様輸送商品対応 END
				s記事部門 = s輸送商品親一覧[cmb輸送商品親.SelectedIndex];
				記事一覧検索();
			}
		}

		private void 記事登録_Closed(object sender, System.EventArgs e)
		{
			axGT記事.CaretRow = 1;
			axGT記事_CurPlaceChanged(null,null);
			cmb記事種別.Focus();
		}
	}
}
