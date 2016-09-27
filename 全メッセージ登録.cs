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
	public class メッセージ登録 : 共通フォーム
	{
		public string s部門コード;

		private short    nOldRow    = 0;
		private string   sメッセージコード = "";
		private string   s更新日時 = "";
		private string[] sメッセージ一覧;
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
		private System.Windows.Forms.Label labメッセージタイトル;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label labメッセージ名;
		private 共通テキストボックス texメッセージ名;
		private System.Windows.Forms.Button btn更新;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cmbメッセージ種別;
		private AxGTABLE32V2Lib.AxGTable32 axGTメッセージ;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public メッセージ登録()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(メッセージ登録));
			this.panel1 = new System.Windows.Forms.Panel();
			this.axGTメッセージ = new AxGTABLE32V2Lib.AxGTable32();
			this.cmbメッセージ種別 = new System.Windows.Forms.ComboBox();
			this.lab頁番号 = new System.Windows.Forms.Label();
			this.btn次頁 = new System.Windows.Forms.Button();
			this.btn前頁 = new System.Windows.Forms.Button();
			this.btn更新 = new System.Windows.Forms.Button();
			this.labメッセージ名 = new System.Windows.Forms.Label();
			this.texメッセージ名 = new is2AdminClient.共通テキストボックス();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labメッセージタイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGTメッセージ)).BeginInit();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.axGTメッセージ);
			this.panel1.Controls.Add(this.cmbメッセージ種別);
			this.panel1.Controls.Add(this.lab頁番号);
			this.panel1.Controls.Add(this.btn次頁);
			this.panel1.Controls.Add(this.btn前頁);
			this.panel1.Controls.Add(this.btn更新);
			this.panel1.Controls.Add(this.labメッセージ名);
			this.panel1.Controls.Add(this.texメッセージ名);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(767, 440);
			this.panel1.TabIndex = 0;
			// 
			// axGTメッセージ
			// 
			this.axGTメッセージ.ContainingControl = this;
			this.axGTメッセージ.DataSource = null;
			this.axGTメッセージ.Location = new System.Drawing.Point(42, 38);
			this.axGTメッセージ.Name = "axGTメッセージ";
			this.axGTメッセージ.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGTメッセージ.OcxState")));
			this.axGTメッセージ.Size = new System.Drawing.Size(664, 272);
			this.axGTメッセージ.TabIndex = 65;
			this.axGTメッセージ.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGTメッセージ_KeyDownEvent);
			this.axGTメッセージ.CelClick += new AxGTABLE32V2Lib._DGTable32Events_CelClickEventHandler(this.axGTメッセージ_CelClick);
			this.axGTメッセージ.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGTメッセージ_CurPlaceChanged);
			// 
			// cmbメッセージ種別
			// 
			this.cmbメッセージ種別.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbメッセージ種別.Items.AddRange(new object[] {
															"システムメッセージ",
															"店所メッセージ",
															"会員メッセージ"});
			this.cmbメッセージ種別.Location = new System.Drawing.Point(42, 10);
			this.cmbメッセージ種別.Name = "cmbメッセージ種別";
			this.cmbメッセージ種別.Size = new System.Drawing.Size(138, 20);
			this.cmbメッセージ種別.TabIndex = 1;
			this.cmbメッセージ種別.SelectionChangeCommitted += new System.EventHandler(this.cmbメッセージ種別_SelectionChangeCommitted);
			// 
			// lab頁番号
			// 
			this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab頁番号.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab頁番号.Location = new System.Drawing.Point(608, 322);
			this.lab頁番号.Name = "lab頁番号";
			this.lab頁番号.Size = new System.Drawing.Size(48, 14);
			this.lab頁番号.TabIndex = 64;
			this.lab頁番号.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btn次頁
			// 
			this.btn次頁.BackColor = System.Drawing.Color.SteelBlue;
			this.btn次頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn次頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn次頁.ForeColor = System.Drawing.Color.White;
			this.btn次頁.Location = new System.Drawing.Point(656, 318);
			this.btn次頁.Name = "btn次頁";
			this.btn次頁.Size = new System.Drawing.Size(48, 22);
			this.btn次頁.TabIndex = 63;
			this.btn次頁.Text = "次頁";
			this.btn次頁.Click += new System.EventHandler(this.btn次頁_Click);
			// 
			// btn前頁
			// 
			this.btn前頁.BackColor = System.Drawing.Color.SteelBlue;
			this.btn前頁.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn前頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn前頁.ForeColor = System.Drawing.Color.White;
			this.btn前頁.Location = new System.Drawing.Point(560, 318);
			this.btn前頁.Name = "btn前頁";
			this.btn前頁.Size = new System.Drawing.Size(48, 22);
			this.btn前頁.TabIndex = 62;
			this.btn前頁.Text = "前頁";
			this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
			// 
			// btn更新
			// 
			this.btn更新.BackColor = System.Drawing.Color.SteelBlue;
			this.btn更新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn更新.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn更新.ForeColor = System.Drawing.Color.White;
			this.btn更新.Location = new System.Drawing.Point(646, 410);
			this.btn更新.Name = "btn更新";
			this.btn更新.Size = new System.Drawing.Size(64, 22);
			this.btn更新.TabIndex = 5;
			this.btn更新.Text = "保存";
			this.btn更新.Click += new System.EventHandler(this.btn更新_Click);
			// 
			// labメッセージ名
			// 
			this.labメッセージ名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labメッセージ名.ForeColor = System.Drawing.Color.LimeGreen;
			this.labメッセージ名.Location = new System.Drawing.Point(44, 382);
			this.labメッセージ名.Name = "labメッセージ名";
			this.labメッセージ名.Size = new System.Drawing.Size(58, 14);
			this.labメッセージ名.TabIndex = 56;
			this.labメッセージ名.Text = "メッセージ名";
			// 
			// texメッセージ名
			// 
			this.texメッセージ名.BackColor = System.Drawing.SystemColors.Window;
			this.texメッセージ名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.texメッセージ名.Location = new System.Drawing.Point(106, 378);
			this.texメッセージ名.MaxLength = 15;
			this.texメッセージ名.Name = "texメッセージ名";
			this.texメッセージ名.Size = new System.Drawing.Size(630, 23);
			this.texメッセージ名.TabIndex = 4;
			this.texメッセージ名.Text = "あいうえおかきくけ１あいうえおかきくけ２あいうえおかきくけ３あいうえおかきくけ４あいうえおかきくけ５";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.labメッセージタイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(794, 26);
			this.panel7.TabIndex = 13;
			// 
			// labメッセージタイトル
			// 
			this.labメッセージタイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labメッセージタイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labメッセージタイトル.ForeColor = System.Drawing.Color.White;
			this.labメッセージタイトル.Location = new System.Drawing.Point(12, 2);
			this.labメッセージタイトル.Name = "labメッセージタイトル";
			this.labメッセージタイトル.Size = new System.Drawing.Size(264, 24);
			this.labメッセージタイトル.TabIndex = 0;
			this.labメッセージタイトル.Text = "メッセージ登録";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 1;
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(536, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(256, 50);
			this.texメッセージ.TabIndex = 0;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
			// 
			// btn閉じる
			// 
			this.btn閉じる.ForeColor = System.Drawing.Color.Red;
			this.btn閉じる.Location = new System.Drawing.Point(8, 6);
			this.btn閉じる.Name = "btn閉じる";
			this.btn閉じる.Size = new System.Drawing.Size(54, 48);
			this.btn閉じる.TabIndex = 7;
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
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(8, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(774, 448);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// メッセージ登録
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 574);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "メッセージ登録";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 メッセージ登録";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGTメッセージ)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>

		private void Form1_Load(object sender, System.EventArgs e)
		{
			axGTメッセージ.Cols = 4;
			axGTメッセージ.Rows = 14;
			axGTメッセージ.ColSep = "|";

			axGTメッセージ.set_RowsText(0, "|店所コード|店所名|店所メッセージ|");

			axGTメッセージ.ColsWidth = "0|7|8|36|0|";
			axGTメッセージ.ColsAlignHorz = "1|1|0|0|0|";
            
//			axGTメッセージ.set_CelForeColor(axGTメッセージ.CaretRow,0,111111);
			axGTメッセージ.set_CelForeColor(axGTメッセージ.CaretRow,0,0x98FB98);  //BGR
			axGTメッセージ.set_CelBackColor(axGTメッセージ.CaretRow,0,0x006000);

			axGTメッセージ.CaretRow = 1;
			cmbメッセージ種別.SelectedIndex = 0;
			s部門コード = "yusoshiji";
			i現在頁数 = 1;
			メッセージ一覧検索();
		}

		private void メッセージ一覧検索()
		{

			sメッセージコード = "";
			texメッセージ名.Text     = "";
			s更新日時        = "";

			sメッセージ一覧 = new string[1];
			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{

				if (cmbメッセージ種別.SelectedIndex == 0)
				{
					texメッセージ名.MaxLength      = 500;
					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
					sメッセージ一覧 = sv_maintenance.Get_Kiji(gsaユーザ,"default","yusoshiji");
				}
				else if (cmbメッセージ種別.SelectedIndex == 1)
				{
					texメッセージ名.MaxLength      = 100;
					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
					sメッセージ一覧 = sv_maintenance.Get_Kiji(gsaユーザ,"default","yusoshiji");
				}
				else
				{
					texメッセージ名.MaxLength      = 100;
					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
					sメッセージ一覧 = sv_maintenance.Get_Kiji(gsaユーザ,"default","yusoshiji");
				}
			
			}
			catch (Exception ex)
			{
				sメッセージ一覧[0] = "通信エラー：" + ex.Message;
			}
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			texメッセージ.Text = sメッセージ一覧[0];
			if(sメッセージ一覧[0].Length == 4) //正常終了
			{
				texメッセージ.Text = "";
				i最大頁数 = (sメッセージ一覧.Length - 2) / axGTメッセージ.Rows + 1;
				if (i現在頁数 > i最大頁数) i現在頁数 = i最大頁数;
				頁情報設定();
			}
			else
			{
				axGTメッセージ.Clear();
				i現在頁数 = 1;
				btn前頁.Enabled = false;
				btn次頁.Enabled = false;
				lab頁番号.Text = "";
				ビープ音();
			}
		}
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void axGTメッセージ_CelClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelClickEvent e)
		{
			sメッセージコード = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,1).Trim();
			texメッセージ名.Text     = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,3).Trim();
			s更新日時        = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,4).Trim();
		}

		private void axGTメッセージ_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGTメッセージ.set_CelForeColor(nOldRow,0,0);
			axGTメッセージ.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGTメッセージ.set_CelForeColor(axGTメッセージ.CaretRow,0,111111);
			axGTメッセージ.set_CelForeColor(axGTメッセージ.CaretRow,0,0x98FB98);  //BGR
			axGTメッセージ.set_CelBackColor(axGTメッセージ.CaretRow,0,0x006000);
			nOldRow = axGTメッセージ.CaretRow;
			sメッセージコード = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,1).Trim();
			texメッセージ名.Text     = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,3).Trim();
			s更新日時        = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,4).Trim();
		}

		private void axGTメッセージ_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGTメッセージ, true, true, true, true);
			}
		}

		private void btn更新_Click(object sender, System.EventArgs e)
		{
			texメッセージ名.Text     = texメッセージ名.Text.Trim();

//			if(!全角チェック(texメッセージ名,"メッセージ名")) return;

			try
			{
				texメッセージ.Text = "";
				// カーソルを砂時計にする
				Cursor = System.Windows.Forms.Cursors.AppStarting;

				String[] sList = {""};

//				if(cmbメッセージ種別.SelectedIndex == 0)
//				{
//					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
//					String[] sList = sv_maintenance.Sel_Kiji(gsaユーザ,"default",s部門コード,"");
//				}
//				else if (cmbメッセージ種別.SelectedIndex == 1)
//				{
//					if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
//					String[] sList = sv_maintenance.Sel_Kiji(gsaユーザ,"default",s部門コード,"");
//				}
//				else
//				{
//					 if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
//					 String[] sList = sv_maintenance.Sel_Kiji(gsaユーザ,"default",s部門コード,"");
//				}

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
										+ "メッセージ一覧を最新にしますか？",
										"更新",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Error);
					if(rst == DialogResult.Yes)
					{
						メッセージ一覧検索();
					}
					return;
				}

				String[] sIUList;
				string[] sData = new string[7];
				sData[0]  = "default";
				sData[1]  = s部門コード;
				sData[2]  = sメッセージコード;
				sData[3]  = texメッセージ名.Text;
				sData[4]  = "メッセージ登録";
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
							メッセージ一覧検索();
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
							メッセージ一覧検索();
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
			axGTメッセージ.Clear();

			i開始数 = (i現在頁数 - 1) * axGTメッセージ.Rows + 1;
			i終了数 = i現在頁数 * axGTメッセージ.Rows;

			short s表示数 = (short)1;
//			for(short sCnt = (short)i開始数; sCnt < sメッセージ一覧.Length && sCnt <= i終了数 ; sCnt++)
//			{
//				axGTメッセージ.set_RowsText(s表示数, sメッセージ一覧[sCnt]);
//				s表示数++;
//			}

//仮データ
//			axGTメッセージ.set_RowsText(s表示数, "|123456789012|あいうえおかきくけこ|あいうえおかきくけ１さしすせそたちつて２なにぬねのあいうえ３かきくけこさしすせ４たちつてとなにぬね５|");
//			s表示数++;
//			axGTメッセージ.set_RowsText(s表示数, "|is2|システム会社名|あいうえおかきくけ１さしすせそたちつて２なにぬねのあいうえ３かきくけこさしすせ４たちつてとなにぬね５あいうえおかきくけ１さしすせそたちつて２なにぬねのあいうえ３かきくけこさしすせ４たちつてとなにぬね５|");
//			s表示数++;
//			axGTメッセージ.set_RowsText(s表示数, "|264|深谷|あいうえおかきくけ１さしすせそたちつて２なにぬねのあいうえ３かきくけこさしすせ４たちつてとなにぬね５|");
//			s表示数++;
//			axGTメッセージ.set_RowsText(s表示数, "|0862312511|東都会員|あいうえおかきくけ１さしすせそたちつて２なにぬねのあいうえ３かきくけこさしすせ４たちつてとなにぬね５|");

			axGTメッセージ.set_RowsText(s表示数, "|264|深谷|深谷支店用のメッセージです|");
			s表示数++;
			axGTメッセージ.set_RowsText(s表示数, "|265|川越|無事故・無違反でお願いします|");
			s表示数++;
			axGTメッセージ.set_RowsText(s表示数, "|266|入間||");
			s表示数++;
			axGTメッセージ.set_RowsText(s表示数, "|268|浦和|ＭＡＸ桁表示用です１あいうえおかきくけ２あいうえおかきくけ３あいうえおかきくけ４あいうえおかきくけ５|");
			s表示数++;
			
			
			lab頁番号.Text = i現在頁数.ToString() + " / " + i最大頁数.ToString();
			if (i現在頁数 == 1)
				btn前頁.Enabled = false;
			else
				btn前頁.Enabled = true;
			if (i現在頁数 == i最大頁数)
				btn次頁.Enabled = false;
			else
				btn次頁.Enabled = true;
			sメッセージコード = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,1).Trim();
			texメッセージ名.Text     = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,3).Trim();
			s更新日時          = axGTメッセージ.get_CelText(axGTメッセージ.CaretRow,4).Trim();
		}

		private void cmbメッセージ種別_SelectionChangeCommitted(object sender, System.EventArgs e)
		{
			i現在頁数 = 1;
			メッセージ一覧検索();
		}

	}
}
