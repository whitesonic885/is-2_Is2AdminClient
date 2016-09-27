using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace is2AdminClient
{
	/// <summary>
	/// [ログイン]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// DEL 2005.05.27 東都）高木 セッション制御の廃止 
	//--------------------------------------------------------------------------
	// MOD 2006.10.03 東都）山本 店所メニュー判定処理追加 
	// ADD 2006.12.06 東都）小童谷 IPアドレス 
	// ADD 2006.12.06 東都）小童谷 店所取得方法変更 
	// ADD 2006.12.06 東都）小童谷 ＩＰアドレスチェック 
	// ADD 2006.12.07 東都）小童谷 店所存在チェック 
	//--------------------------------------------------------------------------
	// MOD 2007.01.30 東都）高木 特殊権限ユーザの追加 
	// ADD 2007.02.03 東都）高木 初期フォーカスの設定 
	// DEL 2007.02.06 東都）高木 営業所会員対応 
	// MOD 2007.06.12 東都）高木 宇都宮などの対応 
	// ADD 2007.07.02 東都）高木 和田山営業所対応 
	// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 
	// ADD 2007.10.26 東都）高木 バージョン情報の表示 
	//--------------------------------------------------------------------------
	// ADD 2008.03.21 東都）グローバル対応 
	//--------------------------------------------------------------------------
	// ADD 2010.04.02 東都）高木 いばらぎ筑西営業所対応 
	// ADD 2010.05.11 東都）高木 東京浦安流通センター対応 
	// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 
	// ADD 2010.07.01 東都）高木 成田流通センター対応 
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	// MOD 2011.01.14 東都）高木 王子運送対応 
	// MOD 2011.07.12 東都）高木 王子運送講習会対応 
	// ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応
	// ADD 2014.07.31 BEVAS) 前田 坂戸営業所ログイン対応
	// ADD 2014.08.08 BEVAS) 前田 東京空港貨物ログイン対応
	// ADD 2015.03.26 BEVAS) 前田 さいたま川口ログイン対応
	//--------------------------------------------------------------------------
	// ADD 2015.09.28 bevas）松本 伊賀上野、福山神辺ログイン対応
	//--------------------------------------------------------------------------
	// ADD 2015.10.08 bevas）松本 広島流通センターログイン対応
	//--------------------------------------------------------------------------
	// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応
	//--------------------------------------------------------------------------
	// ADD 2016.02.12 BEVAS）松本 福岡流通センターログイン対応(STEP1)
	//　　　　　　　　　　　　　　　　【IP体系変更に伴う対応】
	//--------------------------------------------------------------------------
	// ADD 2016.02.18 BEVAS）松本 福岡流通センターログイン対応(STEP2)
	//　　　　　　　　　　　　　　　　【店所コード変更に伴う対応】
	//--------------------------------------------------------------------------
	public class ログイン : 共通フォーム
	{
		public bool b認証 = false;
		// ADD 2006.12.06 東都）小童谷 IPアドレス START
		private string[] sValue;
		// ADD 2006.12.06 東都）小童谷 IPアドレス END

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label labパスワード;
		private 共通テキストボックス texパスワード;
		private 共通テキストボックス tex利用者コード;
		private System.Windows.Forms.Label lab会員コード;
		private 共通テキストボックス tex会員コード;
		private System.Windows.Forms.Label lab利用者コード;
		private System.Windows.Forms.Button btnログイン;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnキャンセル;
		private System.Windows.Forms.PictureBox picログオン;
		private System.Windows.Forms.Label labバージョン;

		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		public ログイン()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ログイン));
			this.tex利用者コード = new is2AdminClient.共通テキストボックス();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labバージョン = new System.Windows.Forms.Label();
			this.btnキャンセル = new System.Windows.Forms.Button();
			this.picログオン = new System.Windows.Forms.PictureBox();
			this.lab会員コード = new System.Windows.Forms.Label();
			this.tex会員コード = new is2AdminClient.共通テキストボックス();
			this.labパスワード = new System.Windows.Forms.Label();
			this.texパスワード = new is2AdminClient.共通テキストボックス();
			this.lab利用者コード = new System.Windows.Forms.Label();
			this.btnログイン = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tex利用者コード
			// 
			this.tex利用者コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex利用者コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex利用者コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex利用者コード.Location = new System.Drawing.Point(132, 90);
			this.tex利用者コード.MaxLength = 6;
			this.tex利用者コード.Name = "tex利用者コード";
			this.tex利用者コード.Size = new System.Drawing.Size(82, 23);
			this.tex利用者コード.TabIndex = 1;
			this.tex利用者コード.Text = "";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.labバージョン);
			this.panel1.Controls.Add(this.btnキャンセル);
			this.panel1.Controls.Add(this.picログオン);
			this.panel1.Controls.Add(this.lab会員コード);
			this.panel1.Controls.Add(this.tex会員コード);
			this.panel1.Controls.Add(this.labパスワード);
			this.panel1.Controls.Add(this.texパスワード);
			this.panel1.Controls.Add(this.lab利用者コード);
			this.panel1.Controls.Add(this.tex利用者コード);
			this.panel1.Controls.Add(this.btnログイン);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(364, 226);
			this.panel1.TabIndex = 0;
			// 
			// labバージョン
			// 
			this.labバージョン.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(192)), ((System.Byte)(191)), ((System.Byte)(190)));
			this.labバージョン.ForeColor = System.Drawing.Color.Black;
			this.labバージョン.Location = new System.Drawing.Point(300, 4);
			this.labバージョン.Name = "labバージョン";
			this.labバージョン.Size = new System.Drawing.Size(46, 12);
			this.labバージョン.TabIndex = 53;
			this.labバージョン.Text = "Ver.1.5";
			// 
			// btnキャンセル
			// 
			this.btnキャンセル.Location = new System.Drawing.Point(214, 158);
			this.btnキャンセル.Name = "btnキャンセル";
			this.btnキャンセル.Size = new System.Drawing.Size(100, 22);
			this.btnキャンセル.TabIndex = 5;
			this.btnキャンセル.Text = "キャンセル";
			this.btnキャンセル.Click += new System.EventHandler(this.btnキャンセル_Click);
			// 
			// picログオン
			// 
			this.picログオン.Image = ((System.Drawing.Image)(resources.GetObject("picログオン.Image")));
			this.picログオン.Location = new System.Drawing.Point(-2, -18);
			this.picログオン.Name = "picログオン";
			this.picログオン.Size = new System.Drawing.Size(366, 66);
			this.picログオン.TabIndex = 49;
			this.picログオン.TabStop = false;
			// 
			// lab会員コード
			// 
			this.lab会員コード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab会員コード.ForeColor = System.Drawing.Color.Black;
			this.lab会員コード.Location = new System.Drawing.Point(50, 66);
			this.lab会員コード.Name = "lab会員コード";
			this.lab会員コード.Size = new System.Drawing.Size(76, 14);
			this.lab会員コード.TabIndex = 0;
			this.lab会員コード.Text = "お客様コード：";
			// 
			// tex会員コード
			// 
			this.tex会員コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex会員コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex会員コード.Location = new System.Drawing.Point(132, 60);
			this.tex会員コード.MaxLength = 10;
			this.tex会員コード.Name = "tex会員コード";
			this.tex会員コード.Size = new System.Drawing.Size(130, 23);
			this.tex会員コード.TabIndex = 0;
			this.tex会員コード.Text = "";
			// 
			// labパスワード
			// 
			this.labパスワード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labパスワード.ForeColor = System.Drawing.Color.Black;
			this.labパスワード.Location = new System.Drawing.Point(50, 126);
			this.labパスワード.Name = "labパスワード";
			this.labパスワード.Size = new System.Drawing.Size(76, 14);
			this.labパスワード.TabIndex = 48;
			this.labパスワード.Text = "パスワード：";
			// 
			// texパスワード
			// 
			this.texパスワード.BackColor = System.Drawing.SystemColors.Window;
			this.texパスワード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texパスワード.Location = new System.Drawing.Point(132, 120);
			this.texパスワード.MaxLength = 20;
			this.texパスワード.Name = "texパスワード";
			this.texパスワード.PasswordChar = '*';
			this.texパスワード.Size = new System.Drawing.Size(170, 23);
			this.texパスワード.TabIndex = 2;
			this.texパスワード.Text = "";
			this.texパスワード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texパスワード_KeyDown);
			// 
			// lab利用者コード
			// 
			this.lab利用者コード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab利用者コード.ForeColor = System.Drawing.Color.Black;
			this.lab利用者コード.Location = new System.Drawing.Point(50, 96);
			this.lab利用者コード.Name = "lab利用者コード";
			this.lab利用者コード.Size = new System.Drawing.Size(76, 14);
			this.lab利用者コード.TabIndex = 42;
			this.lab利用者コード.Text = "ユーザー：";
			// 
			// btnログイン
			// 
			this.btnログイン.ForeColor = System.Drawing.Color.Black;
			this.btnログイン.Location = new System.Drawing.Point(62, 158);
			this.btnログイン.Name = "btnログイン";
			this.btnログイン.Size = new System.Drawing.Size(100, 22);
			this.btnログイン.TabIndex = 4;
			this.btnログイン.Text = "ＯＫ";
			this.btnログイン.Click += new System.EventHandler(this.btnログイン_Click);
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(-2, -6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(364, 234);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			// 
			// ログイン
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(354, 190);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(362, 224);
			this.Name = "ログイン";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "is-2管理 へログイン";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.ログイン_Load);
			this.Activated += new System.EventHandler(this.ログイン_Activated);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		private void btnログイン_Click(object sender, System.EventArgs e)
		{
			ログイン認証();
		}
		
		private void ログイン認証()
		{
			// 空白除去
			tex会員コード.Text   = tex会員コード.Text.Trim();
			tex利用者コード.Text = tex利用者コード.Text.Trim();
			texパスワード.Text   = texパスワード.Text.Trim();

			// 項目チェック
			if(!必須チェック(tex会員コード, "会員コード")) return;
			if(!必須チェック(tex利用者コード, "ユーザー")) return;
			if(!必須チェック(texパスワード, "パスワード")) return;
			if(!半角チェック(tex会員コード, "会員コード")) return;
			if(!半角チェック(tex利用者コード, "ユーザー")) return;
			if(!半角チェック(texパスワード, "パスワード")) return;

			// DEL 2007.02.06 東都）高木 営業所会員対応 START
			//// ADD 2006.12.06 東都）小童谷 店所取得方法変更 START
			//// MOD 2007.01.30 東都）高木 特殊権限ユーザの追加 START
			////			if(tex会員コード.Text != "honbu")
			//			if(tex会員コード.Text != "honbu"
			//			&& tex会員コード.Text != "kikaku")
			//// MOD 2007.01.30 東都）高木 特殊権限ユーザの追加 END
			//			{
			//				string sTensyo;
			//				string sIp = sValue[1].Trim().PadLeft(3,'0');
			//				if(sIp == "016") sTensyo = "0";
			//				else if(sIp == "017") sTensyo = "1";
			//				else if(sIp == "018") sTensyo = "2";
			//				else if(sIp == "019") sTensyo = "3";
			//				else if(sIp == "020") sTensyo = "4";
			//				else if(sIp == "021") sTensyo = "5";
			//				else if(sIp == "022") sTensyo = "6";
			//				else if(sIp == "023") sTensyo = "7";
			//				else if(sIp == "024") sTensyo = "8";
			//				else if(sIp == "025") sTensyo = "9";
			//				else 
			//				{
			//					MessageBox.Show("認証エラー：端末が不正です。", "ログイン",
			//						MessageBoxButtons.OK, MessageBoxIcon.Error);
			//					return;
			//				}
			//				gs店所コード = sTensyo + sValue[2].Trim().PadLeft(3,'0').Substring(1,2);
			//
			//				if(gs店所コード.StartsWith("0") == true)
			//				{
			//					gs店所コード   = "";
			//				}
			//			}
			//
			//// ADD 2006.12.06 東都）小童谷 店所取得方法変更 END
			// DEL 2007.02.06 東都）高木 営業所会員対応 END

			// データ作成
			String[] sKey = new string[3];
			sKey[0] = tex会員コード.Text;
			sKey[1] = tex利用者コード.Text;
			sKey[2] = texパスワード.Text;

			//			texメッセージ.Text = "認証中";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			// ADD 2008.03.21 東都）グローバル対応 START
			string sセクション店所 = "";
			// ADD 2008.03.21 東都）グローバル対応 END

			// ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応 START
			string sテリトリ店ＦＧ = "";
			// ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応 END

			try
			{
				// 引数：会員コード、利用者コード、パスワード
				if (sv_maintenance == null)
				{
					sv_maintenance = new is2maintenance.Service1();
					// DEL 2005.05.27 東都）高木 セッション制御の廃止 START
					//					sv_maintenance.CookieContainer = cContainer;
					// DEL 2005.05.27 東都）高木 セッション制御の廃止 END
				}
				// MOD 2011.01.14 東都）高木 王子運送対応 START
				if(sv_oji == null) sv_oji = new is2oji.Service1();
				// MOD 2011.01.14 東都）高木 王子運送対応 END
				gsaユーザ[0]   = "";
				gsaユーザ[1]   = "";
				gsaユーザ[2]   = "";
				// ADD 2010.12.14 ACT）垣原 王子運送対応 START
				//				String[] sRet = sv_maintenance.Set_login(gsaユーザ, sKey);
				String[] sRet;
				if (sKey[0].Substring(0,1) != "J")
				{
					sRet = sv_maintenance.Set_login(gsaユーザ, sKey);

				}
				else
				{
					// MOD 2011.01.14 東都）高木 王子運送対応 START
					//					if (sv_oji == null) sv_oji = new is2oji.Service1();
					// MOD 2011.01.14 東都）高木 王子運送対応 END
					sRet = sv_oji.Set_login(gsaユーザ, sKey);
				}
				// ADD 2010.12.14 ACT）垣原 王子運送対応 END

				// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 START
				if(sRet[0].Length != 4)
				{
					MessageBox.Show(sRet[0]
						, "ログイン"
						, MessageBoxButtons.OK, MessageBoxIcon.Error);
					ビープ音();
					tex会員コード.Focus();
					this.Cursor = System.Windows.Forms.Cursors.Default;
					b認証 = false;
					return;
				}
				// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 END

				if(sRet[1] == null)
				{
					//					texメッセージ.Text = "認証エラー：再度入力してください。";
					MessageBox.Show("認証エラー：再度入力してください。", "ログイン", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					// 会員コードにフォーカス
					ビープ音();
					tex会員コード.Focus();
					this.Cursor = System.Windows.Forms.Cursors.Default;
					return;
				}
				else
				{
					gs会員コード   = sRet[1];
					gs会員名       = sRet[2];
					gs利用者コード = sRet[3];
					gs利用者名     = sRet[4];
					// DEL 2006.12.06 東都）小童谷 店所取得方法変更 START
					// MOD 2006.10.03 東都）山本 店所メニュー判定処理追加 START
					//					if(sRet[5].StartsWith("0") != true)
					//						gs店所コード   = sRet[5].Trim();
					// MOD 2006.10.03 東都）山本 店所メニュー判定処理追加 END
					// DEL 2006.12.06 東都）小童谷 店所取得方法変更 END
					// ADD 2007.02.06 東都）高木 営業所会員対応 START
					gs管理者区分   = sRet[5];
					// ADD 2007.02.06 東都）高木 営業所会員対応 END
					// ADD 2008.03.21 東都）グローバル対応 START
					if(sRet.Length > 6) sセクション店所 = sRet[6];
					// ADD 2008.03.21 東都）グローバル対応 END
					//sv_maintenance.SetSession(gs会員コード, gs利用者コード);
					gsaユーザ[0]   = gs会員コード;
					gsaユーザ[1]   = gs利用者コード;
					gsaユーザ[2]   = "";
					b認証 = true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);

				this.Cursor = System.Windows.Forms.Cursors.Default;
				// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 START
				b認証 = false;
				// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 END
				// 画面を閉じる
				this.Close();
			}

			// ADD 2007.02.06 東都）高木 営業所会員対応 START
			gs店所コード = "";
			// 営業所会員の場合、ＩＰで店所ＣＤを設定
			// ADD 2010.12.14 ACT）垣原 王子運送対応 START
			// 王子営業所会員の場合、店所ＣＤを入力
			//			if(gs管理者区分 == "2")
			if((gs管理者区分 == "2") || (gs管理者区分 == "4"))
				// ADD 2010.12.14 ACT）垣原 王子運送対応 END
			{
				// MOD 2007.06.12 東都）高木 宇都宮などの対応 START
				//				string sTensyo;
				//				string sIp = sValue[1].Trim().PadLeft(3,'0');
				//				if(sIp == "016") sTensyo = "0";
				//				else if(sIp == "017") sTensyo = "1";
				//				else if(sIp == "018") sTensyo = "2";
				//				else if(sIp == "019") sTensyo = "3";
				//				else if(sIp == "020") sTensyo = "4";
				//				else if(sIp == "021") sTensyo = "5";
				//				else if(sIp == "022") sTensyo = "6";
				//				else if(sIp == "023") sTensyo = "7";
				//				else if(sIp == "024") sTensyo = "8";
				//				else if(sIp == "025") sTensyo = "9";
				//				else 
				//				{
				//					MessageBox.Show("認証エラー：端末が不正です。", "ログイン",
				//						MessageBoxButtons.OK, MessageBoxIcon.Error);
				//					// 会員コードにフォーカス
				//					ビープ音();
				//					tex会員コード.Focus();
				//					b認証 = false;
				//					this.Cursor = System.Windows.Forms.Cursors.Default;
				//					return;
				//				}
				//
				//				gs店所コード = sTensyo + sValue[2].Trim().PadLeft(3,'0').Substring(1,2);
				// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 START

				bool b端末ＩＰエラー = false;
				try
				{
//#if DEBUG
////					//ログイン対応確認
////					gsＩＰアドレス = "172.21.17.200";  // 岡山南、岡山東ログイン振分確認用（岡山東支店のIPアドレス体系）
////					gsＩＰアドレス = "172.21.17.194";  // 岡山南営業所のログインIPアドレス（※IPアドレス体系は、岡山東支店のもの）
////					gsＩＰアドレス = "172.18.17.200";  // テリトリ店移管店所確認用（品川支店のIPアドレス体系）
////					gsＩＰアドレス = "172.23.2.200";   // 福岡中央支店ログイン確認用IP（※体系は、福岡流通センターのもの）
////					gsＩＰアドレス = "172.23.102.200"; // 福岡流通センターログイン確認用IP（新体系）
//#endif
					sValue = gsＩＰアドレス.Split('.');

					if(sValue == null)
					{
						b端末ＩＰエラー = true;
					}
					else if(sValue.Length != 4)
					{
						b端末ＩＰエラー = true;
						// ADD 2010.12.14 ACT）垣原 王子運送対応 START
						//					}else if(sValue[0] != "172"){
					}
					else if((sValue[0] != "172") && (sValue[0] != "10"))
					{
						// ADD 2010.12.14 ACT）垣原 王子運送対応 END
						b端末ＩＰエラー = true;
					}
					//保留　複数のＩＰがある場合
				}
				catch(Exception)
				{
					b端末ＩＰエラー = true;
				}
				if(b端末ＩＰエラー)
				{
					MessageBox.Show("認証エラー：端末が不正です。", "ログイン",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					// 会員コードにフォーカス
					ビープ音();
					tex会員コード.Focus();
					b認証 = false;
					this.Cursor = System.Windows.Forms.Cursors.Default;
					return;
				}
				// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 END

				// ADD 2010.12.14 ACT）垣原 王子運送対応 START
				// 王子営業所会員の場合、店所ＣＤを入力
				// MOD 2011.07.12 東都）高木 王子運送講習会対応 START
				//				if((sValue[0] == "10"))
				if(gs管理者区分 == "4") // 王子営業所会員
					// MOD 2011.07.12 東都）高木 王子運送講習会対応 END
				{
					if(gs店所コード.Trim().Length == 0)
					{
						// 店所入力画面を表示
						if(g店所入力 == null) g店所入力 = new 店所入力();
						g店所入力.ShowDialog();
						try
						{
							sKey[0] = gs店所コード;
							string[] sList = sv_oji.Sel_Member(gsaユーザ, sKey);

							if (sList[0].Equals("正常終了"))
							{
								if ((sList[4] != "3") && (sList[4] != "4"))
								{
									MessageBox.Show("認証エラー：店所コードが不正です。", "ログイン",
										MessageBoxButtons.OK, MessageBoxIcon.Error);
									// 会員コードにフォーカス
									ビープ音();
									tex会員コード.Focus();
									b認証 = false;
									this.Cursor = System.Windows.Forms.Cursors.Default;
									return;
								}
							}
							else
							{
								MessageBox.Show("認証エラー：店所が存在しません。", "ログイン", 
									MessageBoxButtons.OK, MessageBoxIcon.Error);
								// 会員コードにフォーカス
								ビープ音();
								tex会員コード.Focus();
								b認証 = false;
								this.Cursor = System.Windows.Forms.Cursors.Default;
								return;
							}
						}
						catch (Exception ex)
						{
							b認証 = false;
							MessageBox.Show(ex.Message);
							return;
						}
					}
					else
					{
						gs店所コード = "";
					}
				}
				else
				{
					// ADD 2010.12.14 ACT）垣原 王子運送対応 END
					int iIp1 = int.Parse(sValue[1].Trim());
					if(iIp1 < 16 || iIp1 > 25)
					{
						MessageBox.Show("認証エラー：端末が不正です。", "ログイン",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						// 会員コードにフォーカス
						ビープ音();
						tex会員コード.Focus();
						b認証 = false;
						this.Cursor = System.Windows.Forms.Cursors.Default;
						return;
					}
					int iIp2 = int.Parse(sValue[2].Trim());
					string sTensyo2 = sValue[2].Trim().PadLeft(3,'0').Substring(1,2);

					switch(iIp1)
					{
						case 16:
							gs店所コード = "0" + sTensyo2;
							break;
						case 17:
						switch(iIp2)
						{
							case 141:
								gs店所コード = "241";		//宇都宮物流
								break;
							default:
								gs店所コード = "1" + sTensyo2;
								break;
						}
							break;
						case 18:
						switch(iIp2)
						{
							case 191:
								gs店所コード = "191";		//航空貨物
								break;
							case 137:
								gs店所コード = "337";		//韮崎
								break;
							case 136:
								gs店所コード = "336";		//都留
								break;
							case 192:
								gs店所コード = "192";		//羽田空港（東京空港）
								break;
							case 132:
								gs店所コード = "332";		//甲府
								break;
							case 31:
								gs店所コード = "235";		//東久留米
								break;
								// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 START
							case 60:
								gs店所コード = "255";		//いばらぎ坂東
								break;
								// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 END
								// ADD 2010.04.02 東都）高木 いばらぎ筑西営業所対応 START
							case 112:
								gs店所コード = "250";		//いばらぎ筑西
								break;
								// ADD 2010.04.02 東都）高木 いばらぎ筑西営業所対応 END
								// ADD 2010.05.11 東都）高木 東京浦安流通センター対応 START
							case  38:
								gs店所コード = "270";		//東京浦安流通センター
								break;
								// ADD 2010.05.11 東都）高木 東京浦安流通センター対応 END
								// ADD 2010.07.01 東都）高木 成田流通センター対応 START
							case  99:
								gs店所コード = "193";		//成田流通センター
								break;
								// ADD 2010.07.01 東都）高木 成田流通センター対応 END
							    // ADD 2014.07.31 BEVAS) 前田　坂戸営業所対応 START
							case 108:
								gs店所コード = "354";		//坂戸営業所
								break;
								// ADD 2014.07.31 BEVAS) 前田　坂戸営業所対応 END
								// ADD 2014.08.08 BEVAS) 前田 東京空港貨物ログイン対応 START
							case 103:
								gs店所コード = "192";		//東京空港貨物
								break;
								// ADD 2014.08.08 BEVAS) 前田 東京空港貨物ログイン対応 END
								// ADD 2015.03.26 BEVAS) 前田 さいたま川口ログイン対応 START
							case 28:
								gs店所コード = "225";		//さいたま川口
								break;
								// ADD 2015.03.26 BEVAS) 前田 さいたま川口ログイン対応 END
							default:
								gs店所コード = "2" + sTensyo2;
								break;
						}
							break;
						case 19:
							gs店所コード = "3" + sTensyo2;
							break;
						case 20:
						switch(iIp2)
						{
							case 185:
								gs店所コード = "385";		//金沢
								break;
							case 197:
								gs店所コード = "397";		//福井
								break;
							case 186:
								gs店所コード = "386";		//金沢東
								break;
// ADD 2015.09.28 bevas）松本 伊賀上野、福山神辺ログイン対応 START
							case 13:
								gs店所コード = "414";		//伊賀上野
								break;
// ADD 2015.09.28 bevas）松本 伊賀上野、福山神辺ログイン対応 END
							default:
								gs店所コード = "4" + sTensyo2;
								break;
						}
							break;
						case 21:
						switch(iIp2)
						{
							case 102:
								gs店所コード = "402";		//豊岡
								break;
								// ADD 2007.07.02 東都）高木 和田山営業所対応 START
							case 103:
								gs店所コード = "403";		//和田山
								break;
								// ADD 2007.07.02 東都）高木 和田山営業所対応 END
// ADD 2015.09.28 bevas）松本 伊賀上野、福山神辺ログイン対応 START
							case 29:
								gs店所コード = "506";		//福山神辺
								break;
// ADD 2015.09.28 bevas）松本 伊賀上野、福山神辺ログイン対応 END
// ADD 2015.10.08 bevas）松本 広島流通センターログイン対応 START
							case 40:
								gs店所コード = "588";		//広島流通センター
								break;
// ADD 2015.10.08 bevas）松本 広島流通センターログイン対応 END
							default:
								gs店所コード = "5" + sTensyo2;
								break;
						}
							break;
						case 22:
							gs店所コード = "6" + sTensyo2;
							break;
						case 23:
						switch(iIp2)
						{
							case 168:
								gs店所コード = "568";		//下関
								break;
// ADD 2016.02.12 BEVAS）松本 福岡流通センターログイン対応(STEP1) START
							// 2/20～2/29までの対応　※3/1からは店所コードが変更[702 -> 748]
							case 102:
// ADD 2016.02.18 BEVAS）松本 福岡流通センターログイン対応(STEP2) START
								//3/1から、福岡流通センターの店所コードが変更
								//　[(旧)702 -> (新)748]
								//※※福岡中央支店は現行の福岡流通センターのIPアドレス(172.23.2.XXX)と店所コード(702)を
								//　　引き継ぐ為、対応不要
//								gs店所コード = "702";		//福岡流通(新IP)
								gs店所コード = "748";		//福岡流通
// ADD 2016.02.18 BEVAS）松本 福岡流通センターログイン対応(STEP2) END
								break;
// ADD 2016.02.12 BEVAS）松本 福岡流通センターログイン対応(STEP1) END
							default:
								gs店所コード = "7" + sTensyo2;
								break;
						}
							break;
						case 24:
							gs店所コード = "8" + sTensyo2;
							break;
						case 25:
							gs店所コード = "9" + sTensyo2;
							break;
					}
					// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 START

					// ADD 2010.12.14 ACT）垣原 王子運送対応 START
				}

// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 START
				// 岡山南営業所(516)／岡山東支店(517) からのログインの場合
				if(gs店所コード == "517")
				{
					// 確認メッセージ表示
					DialogResult dr選択 = MessageBox.Show(
							"岡山南営業所としてログインしますか？",
							"ログイン確認",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Information
						);
					if(dr選択 == DialogResult.Yes)
					{
						/*************************************************************************
						 ** DialogResult = "OK"であれば"516"でログインする。                     **
						 ** パスは[パス入力.cs]の<btnパス入力_Click>イベントへ記述  "516minami"   **
						 *************************************************************************/
						if(gパス入力 == null)
						{
							gパス入力 = new パス入力();
						}
						gパス入力.ShowDialog();
						if(gパス入力.DialogResult == DialogResult.OK)
						{
							// 岡山南営業所(516)でログイン
							gs店所コード = "516";
						}
					}
				}
// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 END

				// ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応 START
				// 東京テリトリ対応終了時は2013.7.12の更新を全てコメントアウト

				switch(gs店所コード)
				{
					case "213":
						//羽田
						sテリトリ店ＦＧ = "1";
						break;
					case "217":
						//品川
						sテリトリ店ＦＧ = "1";
						break;
					case "218":
						//深川
						sテリトリ店ＦＧ = "1";
						break;
					case "248":
						//川口
						sテリトリ店ＦＧ = "1";
						break;
					case "279":
						//市川
						sテリトリ店ＦＧ = "1";
						break;
					case "308":
						//絹川屋
						sテリトリ店ＦＧ = "1";
						break;
					case "679":
						//王子足立
						sテリトリ店ＦＧ = "1";
						break;
					case "688":
						//王子葛西
						sテリトリ店ＦＧ = "1";
						break;
					case "690":
						//王子京浜
						sテリトリ店ＦＧ = "1";
						break;
					default:
						//処理なし
						sテリトリ店ＦＧ = "";
						break;
				}

				//テリトリ店移管先のログインだった場合、メッセ―ジを表示する。
				if (sテリトリ店ＦＧ == "1")
				{
					//確認メッセージ表示
					DialogResult d選択 = MessageBox.Show("東京支店としてログインしますか？",
						"ログイン確認",
						MessageBoxButtons.YesNo,
						MessageBoxIcon.Information
						);
					if (d選択 == DialogResult.Yes)
					{

						//DialogResult = "OK"であれば"211"でログインする。
						//パスはパス入力.cs のbtnパス入力_Clickイベントへ記述"211tokyo"
						if(gパス入力 == null) gパス入力 = new パス入力();
						gパス入力.ShowDialog();

						if (gパス入力.DialogResult == DialogResult.OK)
						{

							//東京支店としてログインする。
							gs店所コード = "211";
						}
					}
					else
					{
						//通常店所でログイン
						;
					}
				}
				else
				{
					//処理なし
				}
				// ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応 END

				// ADD 2010.12.14 ACT）垣原 王子運送対応 END
			}
			else if(gs管理者区分 == "1")
			{ // 管理者
				;
			}
			else
			{
				b認証 = false;
				return;

				// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 END
				// MOD 2007.06.12 東都）高木 宇都宮などの対応 END

				//				// 店所ＣＤの頭が０の場合は管理に設定
				//				if(gs店所コード.StartsWith("0") == true)
				//				{
				//					gs店所コード   = "";
				//				}
			}
			// ADD 2007.02.06 東都）高木 営業所会員対応 END

			// ADD 2006.12.07 東都）小童谷 店所存在チェック START
			if(gs店所コード.Trim().Length != 0)
			{
				try
				{
					string[] sKeyT = new string[1];
					sKeyT[0] = gs店所コード;
					string[] sList = sv_maintenance.Sel_Shop(gsaユーザ, sKeyT);
					if(!sList[0].Equals("正常終了"))
					{
						MessageBox.Show("認証エラー：店所が存在しません。", "ログイン", 
							MessageBoxButtons.OK, MessageBoxIcon.Error);
						// 会員コードにフォーカス
						ビープ音();
						tex会員コード.Focus();
						b認証 = false;
						this.Cursor = System.Windows.Forms.Cursors.Default;
						return;
					}
				}
				catch (Exception ex)
				{
					b認証 = false;
					MessageBox.Show(ex.Message);
				}
			}
			// ADD 2008.03.21 東都）グローバル対応 START
			if(sセクション店所.Equals("047"))
			{
				gs店所コード = sセクション店所;
			}
			// ADD 2008.03.21 東都）グローバル対応 END
			this.Cursor = System.Windows.Forms.Cursors.Default;

			// 画面を閉じる
			this.Close();
			// ADD 2006.12.07 東都）小童谷 店所存在チェック END
		}

		private void texパスワード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
				ログイン認証();
		}

		private void btnキャンセル_Click(object sender, System.EventArgs e)
		{
			// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 START
			b認証 = false;
			// MOD 2010.06.25 東都）高木 ログイン障害時の対応強化 END
			this.Close();
		}

		private void ログイン_Load(object sender, System.EventArgs e)
		{
			picログオン.Image = Image.FromFile("img\\login.gif");
			// ADD 2007.10.26 東都）高木 バージョン情報の表示 START
			if(gsaユーザ[3].Length == 0)
			{
				int iPos = 0;
				//１個目のピリオド
				iPos = Application.ProductVersion.IndexOf('.');
				if(iPos >= 0)
				{
					//２個目のピリオド
					iPos = Application.ProductVersion.IndexOf('.',iPos+1);
					if(iPos >= 0)
					{
						gsaユーザ[3] = Application.ProductVersion.Substring(0,iPos);
					}
				}
			}
			if(gsaユーザ[3].Length > 0) labバージョン.Text = "Ver." + gsaユーザ[3];
			// ADD 2007.10.26 東都）高木 バージョン情報の表示 END
			// ADD 2006.12.06 東都）小童谷 ＩＰアドレスチェック START
			sValue = gsＩＰアドレス.Split('.');
			// ADD 2006.12.06 東都）小童谷 ＩＰアドレスチェック END
			// ADD 2007.02.03 東都）高木 初期フォーカスの設定 START
			tex会員コード.Focus();
			// ADD 2007.02.03 東都）高木 初期フォーカスの設定 END
		}

		// ADD 2007.02.03 東都）高木 初期フォーカスの設定 START
		private void ログイン_Activated(object sender, System.EventArgs e)
		{
			tex会員コード.Focus();
		}
		// ADD 2007.02.03 東都）高木 初期フォーカスの設定 END
	}
}
