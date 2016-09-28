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

		private string   s更新日時 = "";
		
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
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn保存;
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.labメッセージ名 = new System.Windows.Forms.Label();
			this.texメッセージ名 = new is2AdminClient.共通テキストボックス();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labメッセージタイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn保存 = new System.Windows.Forms.Button();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.labメッセージ名);
			this.panel1.Controls.Add(this.texメッセージ名);
			this.panel1.Location = new System.Drawing.Point(4, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(510, 186);
			this.panel1.TabIndex = 0;
			// 
			// labメッセージ名
			// 
			this.labメッセージ名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labメッセージ名.ForeColor = System.Drawing.Color.LimeGreen;
			this.labメッセージ名.Location = new System.Drawing.Point(16, 14);
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
			this.texメッセージ名.Location = new System.Drawing.Point(78, 10);
			this.texメッセージ名.MaxLength = 250;
			this.texメッセージ名.Multiline = true;
			this.texメッセージ名.Name = "texメッセージ名";
			this.texメッセージ名.Size = new System.Drawing.Size(410, 168);
			this.texメッセージ名.TabIndex = 0;
			this.texメッセージ名.Text = @"国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王国国国国国王王王王王";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.labメッセージタイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(534, 26);
			this.panel7.TabIndex = 0;
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
			this.panel8.Controls.Add(this.btn保存);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 260);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(534, 58);
			this.panel8.TabIndex = 2;
			// 
			// btn保存
			// 
			this.btn保存.ForeColor = System.Drawing.Color.Blue;
			this.btn保存.Location = new System.Drawing.Point(76, 6);
			this.btn保存.Name = "btn保存";
			this.btn保存.Size = new System.Drawing.Size(54, 48);
			this.btn保存.TabIndex = 0;
			this.btn保存.Text = "保存";
			this.btn保存.Click += new System.EventHandler(this.btn保存_Click);
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(152, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(376, 50);
			this.texメッセージ.TabIndex = 2;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
			// 
			// btn閉じる
			// 
			this.btn閉じる.ForeColor = System.Drawing.Color.Red;
			this.btn閉じる.Location = new System.Drawing.Point(8, 6);
			this.btn閉じる.Name = "btn閉じる";
			this.btn閉じる.Size = new System.Drawing.Size(54, 48);
			this.btn閉じる.TabIndex = 1;
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
			this.panel6.Size = new System.Drawing.Size(534, 26);
			this.panel6.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.panel1);
			this.groupBox1.Location = new System.Drawing.Point(8, 58);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(518, 198);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// メッセージ登録
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(534, 318);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(540, 350);
			this.Name = "メッセージ登録";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 メッセージ登録";
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 END
            this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.メッセージ登録_Closed);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
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
			メッセージ一覧検索();
		}

		private void メッセージ一覧検索()
		{

			texメッセージ名.Text     = "";
			s更新日時        = "";

			string[] sRet = new string[1];
			// カーソルを砂時計にする
			Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				if(sv_maintenance == null)  sv_maintenance = new is2maintenance.Service1();
				sRet = sv_maintenance.Sel_Syskanri(gsaユーザ,"is2" );
			}
			catch (Exception ex)
			{
				sRet[0] = "通信エラー：" + ex.Message;
			}
			// カーソルをデフォルトに戻す
			Cursor = System.Windows.Forms.Cursors.Default;

			if(sRet[0].Length == 4) //正常終了
			{
				texメッセージ.Text   = "";
				texメッセージ名.Text = sRet[1];
				s更新日時            = sRet[2];
			}
			else
			{
				texメッセージ.Text = sRet[0];
				ビープ音();
			}
		}
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btn保存_Click(object sender, System.EventArgs e)
		{
			texメッセージ名.Text     = texメッセージ名.Text.Trim();

			if(!全角チェック(texメッセージ名,"メッセージ名")) return;

			try
			{
				texメッセージ.Text = "";
				// カーソルを砂時計にする
				Cursor = System.Windows.Forms.Cursors.AppStarting;

				String[] sList = sv_maintenance.Sel_Syskanri(gsaユーザ, "is2");

				// カーソルをデフォルトに戻す
				Cursor = System.Windows.Forms.Cursors.Default;

				// エラー時
				if(sList[0].Length != 4)
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					return;
				}

				// 更新日時がことなる場合
				if(s更新日時 != sList[2])
				{
					ビープ音();
					DialogResult rst;
					rst = MessageBox.Show("同一のコードが既に他の端末より登録されています。\n" 
										+ "メッセージを最新にしますか？",
										"更新",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Error);
					if(rst == DialogResult.Yes)
					{
						メッセージ一覧検索();
					}
					return;
				}

				if(texメッセージ名.Text.Trim().Length == 0)
					texメッセージ名.Text = "　";
				string[] sData = new string[5];
				sData[0]  = "is2";
				sData[1]  = texメッセージ名.Text ;
				sData[2]  = "メセ登録";
				sData[3]  = gs利用者コード;
				sData[4]  = s更新日時;

				// カーソルを砂時計にする
				Cursor = System.Windows.Forms.Cursors.AppStarting;
				texメッセージ.Text = "更新中．．．";
				String[] sIUList = sv_maintenance.Upd_Syskanri(gsaユーザ,sData);
				// カーソルをデフォルトに戻す
				Cursor = System.Windows.Forms.Cursors.Default;
				if(sIUList[0].Length == 4)
				{
					texメッセージ.Text = "";
					this.Close();
				}
				else
				{
					texメッセージ.Text = sIUList[0];
					ビープ音();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
		}

		private void メッセージ登録_Closed(object sender, System.EventArgs e)
		{
			texメッセージ名.Focus();
		}

	}
}
