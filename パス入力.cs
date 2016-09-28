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
	/// [パス入力]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応
	//--------------------------------------------------------------------------
	// // ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応
	//--------------------------------------------------------------------------
	public class パス入力 : 共通フォーム
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnキャンセル;
		private System.Windows.Forms.PictureBox picログオン;
		private is2AdminClient.共通テキストボックス texパスワード;
		private System.Windows.Forms.Button btnパス入力;
		private System.ComponentModel.IContainer components = null;

		public パス入力()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(パス入力));
			this.panel1 = new System.Windows.Forms.Panel();
			this.texパスワード = new is2AdminClient.共通テキストボックス();
			this.btnキャンセル = new System.Windows.Forms.Button();
			this.picログオン = new System.Windows.Forms.PictureBox();
			this.lab会員コード = new System.Windows.Forms.Label();
			this.labパスワード = new System.Windows.Forms.Label();
			this.lab利用者コード = new System.Windows.Forms.Label();
			this.btnパス入力 = new System.Windows.Forms.Button();
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
			this.panel1.Controls.Add(this.texパスワード);
			this.panel1.Controls.Add(this.btnキャンセル);
			this.panel1.Controls.Add(this.picログオン);
			this.panel1.Controls.Add(this.lab会員コード);
			this.panel1.Controls.Add(this.labパスワード);
			this.panel1.Controls.Add(this.lab利用者コード);
			this.panel1.Controls.Add(this.btnパス入力);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(364, 226);
			this.panel1.TabIndex = 0;
			// 
			// texパスワード
			// 
			this.texパスワード.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texパスワード.Location = new System.Drawing.Point(168, 98);
			this.texパスワード.MaxLength = 10;
			this.texパスワード.Name = "texパスワード";
			this.texパスワード.Size = new System.Drawing.Size(92, 22);
			this.texパスワード.TabIndex = 3;
			this.texパスワード.Text = "";
			this.texパスワード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texパスワード_KeyDown);
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
			this.lab会員コード.Size = new System.Drawing.Size(232, 14);
			this.lab会員コード.TabIndex = 0;
			this.lab会員コード.Text = "キャンセル時は通常店所でログインします。";
			// 
			// labパスワード
			// 
			this.labパスワード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labパスワード.ForeColor = System.Drawing.Color.Black;
			this.labパスワード.Location = new System.Drawing.Point(90, 102);
			this.labパスワード.Name = "labパスワード";
			this.labパスワード.Size = new System.Drawing.Size(76, 14);
			this.labパスワード.TabIndex = 48;
			this.labパスワード.Text = "パスワード：";
			// 
			// lab利用者コード
			// 
			this.lab利用者コード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab利用者コード.ForeColor = System.Drawing.Color.Black;
			this.lab利用者コード.Location = new System.Drawing.Point(86, 58);
			this.lab利用者コード.Name = "lab利用者コード";
			this.lab利用者コード.Size = new System.Drawing.Size(158, 14);
			this.lab利用者コード.TabIndex = 42;
			this.lab利用者コード.Text = "パスワードを入力してください。";
			// 
			// btnパス入力
			// 
			this.btnパス入力.ForeColor = System.Drawing.Color.Black;
			this.btnパス入力.Location = new System.Drawing.Point(62, 158);
			this.btnパス入力.Name = "btnパス入力";
			this.btnパス入力.Size = new System.Drawing.Size(100, 22);
			this.btnパス入力.TabIndex = 4;
			this.btnパス入力.Text = "ＯＫ";
			this.btnパス入力.Click += new System.EventHandler(this.btnパス入力_Click);
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
			// パス入力
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(354, 216);
			this.ControlBox = false;
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(362, 224);
			this.Name = "パス入力";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "is-2 パスワード入力";
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 END
            this.Load += new System.EventHandler(this.パス入力_Load);
			this.panel1.ResumeLayout(false);
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
		private void btnパス入力_Click(object sender, System.EventArgs e)
		{
			パス入力認証();
		}
		
		private void パス入力認証()
		{
			// ADD 2013.07.12 tdi）綱澤 東京テリトリ移管先ログイン対応 START
			texパスワード.Text = texパスワード.Text.Trim();
			//パスワードが未入力
			if(texパスワード.Text.Length == 0)
			{
				//未入力メッセージ表示する
				MessageBox.Show("入力エラー：パスワードが入力されていません。", "パスワード入力", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}

			//半角チェック処理
			if(!半角チェック(texパスワード, "パスワード")) return;

			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				//パスワードチェック処理
// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 START
//				if (texパスワード.Text.ToUpper() == "211TOKYO")
//				{
//					//認証ＯＫ
//					this.DialogResult = DialogResult.OK;
//					this.Close();
//				}
//				else
//				{
//					//認証エラー
//					MessageBox.Show("入力エラー：パスワードに誤りがあります。", "パスワード入力", 
//						MessageBoxButtons.OK, MessageBoxIcon.Error);
//					texパスワード.Focus();
//				}
				/* ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★
				 * (注) 今後本画面を使用する場合、
				 *      パスワードチェック処理は
				 *      else句の前に挿入して追加して下さい。
				 * ★☆★☆★☆★☆★☆★☆★☆★☆★☆★☆★ */
				bool b認証成功ＦＧ = false;
				if(gs店所コード == "517")
				{
					// 岡山南／岡山東ログインの場合
					if (texパスワード.Text.ToUpper() == "516MINAMI")
					{
						//認証ＯＫ
						b認証成功ＦＧ = true;
					}
				}
				else
				{
					// 東京テリトリ移管先ログインの場合
					if (texパスワード.Text.ToUpper() == "211TOKYO")
					{
						//認証ＯＫ
						b認証成功ＦＧ = true;
					}
				}

				if(b認証成功ＦＧ)
				{
					//認証ＯＫ
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
				else
				{
					//認証エラー
					MessageBox.Show("入力エラー：パスワードに誤りがあります。", "パスワード入力", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					texパスワード.Focus();
				}
// ADD 2015.11.19 BEVAS）松本 岡山南ログインおよび出荷実績表・ラベルイメージ印刷対応 END
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
			texパスワード.Focus();
		}


		private void btnキャンセル_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void パス入力_Load(object sender, System.EventArgs e)
		{
			picログオン.Image = Image.FromFile(gsアプリフォルダ + "\\img\\login.gif");
			texパスワード.PasswordChar = '*';
// ADD 2015.11.17 bevas）松本 岡山南ログイン対応（岡山東とのログイン振分処理） START
			// 岡山南・岡山東のログイン振分の場合、キャンセル時の挙動メッセージを変更する
			if(gs店所コード == "517")
			{
				lab会員コード.Text = "キャンセル時は岡山東支店でログインします。";
			}
// ADD 2015.11.17 bevas）松本 岡山南ログイン対応（岡山東とのログイン振分処理） END
			texパスワード.Focus();
		}

		private void texパスワード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texパスワード.Text = texパスワード.Text.Trim();
				if(texパスワード.Text.Length > 0)
					パス入力認証();
			}
		}
	}
}
