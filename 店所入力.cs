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
	/// [店所入力]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2007.01.20 東都）高木 画面調整 
	// DEL 2007.01.31 東都）高木 管理者-営業所画面切替変更 
	// MOD 2007.02.06 東都）高木 イメージロードエラー対応 
	//--------------------------------------------------------------------------
	public class 店所入力 : 共通フォーム
	{
// DEL 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
//		public bool b認証 = false;
// DEL 2007.01.31 東都）高木 管理者-営業所画面切替変更 END

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Label labパスワード;
		private System.Windows.Forms.Label lab会員コード;
		private System.Windows.Forms.Label lab利用者コード;
		private System.Windows.Forms.Button btn店所入力;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnキャンセル;
		private System.Windows.Forms.PictureBox picログオン;
		private 共通テキストボックス tex店所コード;
		private System.ComponentModel.IContainer components = null;

		public 店所入力()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(店所入力));
			this.panel1 = new System.Windows.Forms.Panel();
			this.tex店所コード = new is2AdminClient.共通テキストボックス();
			this.btnキャンセル = new System.Windows.Forms.Button();
			this.picログオン = new System.Windows.Forms.PictureBox();
			this.lab会員コード = new System.Windows.Forms.Label();
			this.labパスワード = new System.Windows.Forms.Label();
			this.lab利用者コード = new System.Windows.Forms.Label();
			this.btn店所入力 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.tex店所コード);
			this.panel1.Controls.Add(this.btnキャンセル);
			this.panel1.Controls.Add(this.picログオン);
			this.panel1.Controls.Add(this.lab会員コード);
			this.panel1.Controls.Add(this.labパスワード);
			this.panel1.Controls.Add(this.lab利用者コード);
			this.panel1.Controls.Add(this.btn店所入力);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(364, 226);
			this.panel1.TabIndex = 0;
			// 
			// tex店所コード
			// 
			this.tex店所コード.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex店所コード.Location = new System.Drawing.Point(168, 98);
			this.tex店所コード.MaxLength = 3;
			this.tex店所コード.Name = "tex店所コード";
			this.tex店所コード.Size = new System.Drawing.Size(36, 22);
			this.tex店所コード.TabIndex = 3;
			this.tex店所コード.Text = "";
			this.tex店所コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex店所コード_KeyDown);
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
			this.lab会員コード.Location = new System.Drawing.Point(86, 76);
			this.lab会員コード.Name = "lab会員コード";
			this.lab会員コード.Size = new System.Drawing.Size(206, 14);
			this.lab会員コード.TabIndex = 0;
			this.lab会員コード.Text = "空白の場合は管理者メニューになります。";
			// 
			// labパスワード
			// 
			this.labパスワード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labパスワード.ForeColor = System.Drawing.Color.Black;
			this.labパスワード.Location = new System.Drawing.Point(90, 102);
			this.labパスワード.Name = "labパスワード";
			this.labパスワード.Size = new System.Drawing.Size(76, 14);
			this.labパスワード.TabIndex = 48;
			this.labパスワード.Text = "店所コード：";
			// 
			// lab利用者コード
			// 
			this.lab利用者コード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab利用者コード.ForeColor = System.Drawing.Color.Black;
			this.lab利用者コード.Location = new System.Drawing.Point(86, 58);
			this.lab利用者コード.Name = "lab利用者コード";
			this.lab利用者コード.Size = new System.Drawing.Size(128, 14);
			this.lab利用者コード.TabIndex = 42;
			this.lab利用者コード.Text = "店所を入力してください。";
			// 
			// btn店所入力
			// 
			this.btn店所入力.ForeColor = System.Drawing.Color.Black;
			this.btn店所入力.Location = new System.Drawing.Point(62, 158);
			this.btn店所入力.Name = "btn店所入力";
			this.btn店所入力.Size = new System.Drawing.Size(100, 22);
			this.btn店所入力.TabIndex = 4;
			this.btn店所入力.Text = "ＯＫ";
			this.btn店所入力.Click += new System.EventHandler(this.btn店所入力_Click);
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
			// 店所入力
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
			this.Name = "店所入力";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "is-2 店所入力";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.店所入力_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		private void btn店所入力_Click(object sender, System.EventArgs e)
		{
			店所入力認証();
		}
		
		private void 店所入力認証()
		{
// DEL 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
//			if(tex店所コード.Text.Trim().Length != 0)
//			{
//				if(!必須チェック(tex店所コード, "店所コード")) return;
//				if(!数値チェック(tex店所コード, "店所コード")) return;
//				gs店所コード = tex店所コード.Text.Trim().PadLeft(3,'0');
//				if(gs店所コード.StartsWith("0") == true)
//				{
//					gs店所コード   = "";
//				}
//			}
//			else
//			{
//				gs店所コード   = "";
//			}
//
//			if(gs店所コード.Trim().Length != 0)
//			{
//				try
//				{
//					string[] sKeyT = new string[1];
//					sKeyT[0] = gs店所コード;
//					string[] sList = sv_maintenance.Sel_Shop(gsaユーザ, sKeyT);
//					if(!sList[0].Equals("正常終了"))
//					{
//						MessageBox.Show("認証エラー：店所が存在しません。", "店所入力", 
//							MessageBoxButtons.OK, MessageBoxIcon.Error);
//						// 会員コードにフォーカス
//						ビープ音();
//						tex店所コード.Focus();
//						b認証 = false;
//						this.Cursor = System.Windows.Forms.Cursors.Default;
//						return;
//					}
//					b認証 = true;
//				}
//				catch (Exception ex)
//				{
//					b認証 = false;
//					MessageBox.Show(ex.Message);
//				}
//			}
//			else
//			{
//				b認証 = true;
//			}
//			this.Cursor = System.Windows.Forms.Cursors.Default;
//
//			// 画面を閉じる
//			this.Close();
// DEL 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
// ADD 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
			tex店所コード.Text = tex店所コード.Text.Trim();
			//店所コードが未入力
			if(tex店所コード.Text.Length == 0)
			{
				gs店所コード   = "";
				// 画面を閉じる
				this.Close();
				return;
			}

			if(!半角チェック(tex店所コード, "店所コード")) return;
			if(!数値チェック(tex店所コード, "店所コード")) return;

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKeyT = new string[1];
				sKeyT[0] = tex店所コード.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsaユーザ, sKeyT);

				if(sList[0].Equals("正常終了"))
				{
					gs店所コード   = tex店所コード.Text;
					// 画面を閉じる
					this.Close();
					return;
				}
				MessageBox.Show("入力エラー：店所が存在しません。", "店所入力", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (System.Net.WebException)
			{
				MessageBox.Show(gs通信エラー);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			ビープ音();
			tex店所コード.Focus();
// ADD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
		}

		private void btnキャンセル_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void 店所入力_Load(object sender, System.EventArgs e)
		{
// MOD 2007.02.06 東都）高木 イメージロードエラー対応 START
//			picログオン.Image = Image.FromFile("img\\login.gif");
			picログオン.Image = Image.FromFile(gsアプリフォルダ + "\\img\\login.gif");
// MOD 2007.02.06 東都）高木 イメージロードエラー対応 START

// ADD 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
			lab会員コード.Text   = "店所コードを入力してください。";
			lab利用者コード.Text = "";
			tex店所コード.Focus();
// ADD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
		}

// ADD 2007.01.20 東都）高木 画面調整 START
		private void tex店所コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				tex店所コード.Text = tex店所コード.Text.Trim();
				if(tex店所コード.Text.Length == 3)
					店所入力認証();
			}
		}
// ADD 2007.01.20 東都）高木 画面調整 END
	}
}
