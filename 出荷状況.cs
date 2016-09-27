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
	public class 出荷状況 : 共通フォーム
	{
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label lab出荷状況タイトル;
		private System.Windows.Forms.DateTimePicker dt開始日付;
		private System.Windows.Forms.DateTimePicker dt終了日付;
		private System.Windows.Forms.Button btnＣＳＶ出力;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Button btn印刷;
		private is2AdminClient.共通テキストボックス tex開始店所コード;
		private is2AdminClient.共通テキストボックス tex終了店所コード;
		private System.Windows.Forms.Label lab店所;
		private System.Windows.Forms.Label lab地区コード;
		private is2AdminClient.共通テキストボックス tex開始地区コード;
		private is2AdminClient.共通テキストボックス tex終了地区コード;
		private System.Windows.Forms.Label lab出荷日;
		private System.Windows.Forms.Label lab店所線;
		private System.Windows.Forms.Label lab地区線;
		private System.Windows.Forms.Label lab出荷日線;
		private System.Windows.Forms.Label label1;
		private System.ComponentModel.IContainer components = null;

		public 出荷状況()
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
			this.lab出荷日 = new System.Windows.Forms.Label();
			this.lab店所線 = new System.Windows.Forms.Label();
			this.tex開始店所コード = new is2AdminClient.共通テキストボックス();
			this.tex終了店所コード = new is2AdminClient.共通テキストボックス();
			this.lab店所 = new System.Windows.Forms.Label();
			this.lab地区線 = new System.Windows.Forms.Label();
			this.lab地区コード = new System.Windows.Forms.Label();
			this.tex開始地区コード = new is2AdminClient.共通テキストボックス();
			this.tex終了地区コード = new is2AdminClient.共通テキストボックス();
			this.lab出荷日線 = new System.Windows.Forms.Label();
			this.dt開始日付 = new System.Windows.Forms.DateTimePicker();
			this.dt終了日付 = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab出荷状況タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnＣＳＶ出力 = new System.Windows.Forms.Button();
			this.btn印刷 = new System.Windows.Forms.Button();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.lab出荷日);
			this.panel1.Controls.Add(this.lab店所線);
			this.panel1.Controls.Add(this.tex開始店所コード);
			this.panel1.Controls.Add(this.tex終了店所コード);
			this.panel1.Controls.Add(this.lab店所);
			this.panel1.Controls.Add(this.lab地区線);
			this.panel1.Controls.Add(this.lab地区コード);
			this.panel1.Controls.Add(this.tex開始地区コード);
			this.panel1.Controls.Add(this.tex終了地区コード);
			this.panel1.Controls.Add(this.lab出荷日線);
			this.panel1.Controls.Add(this.dt開始日付);
			this.panel1.Controls.Add(this.dt終了日付);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(0, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(370, 176);
			this.panel1.TabIndex = 1;
			// 
			// lab出荷日
			// 
			this.lab出荷日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab出荷日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab出荷日.Location = new System.Drawing.Point(36, 102);
			this.lab出荷日.Name = "lab出荷日";
			this.lab出荷日.Size = new System.Drawing.Size(76, 18);
			this.lab出荷日.TabIndex = 79;
			this.lab出荷日.Text = "出荷日";
			// 
			// lab店所線
			// 
			this.lab店所線.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab店所線.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab店所線.Location = new System.Drawing.Point(152, 64);
			this.lab店所線.Name = "lab店所線";
			this.lab店所線.Size = new System.Drawing.Size(22, 16);
			this.lab店所線.TabIndex = 78;
			this.lab店所線.Text = "～";
			// 
			// tex開始店所コード
			// 
			this.tex開始店所コード.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex開始店所コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex開始店所コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex開始店所コード.Location = new System.Drawing.Point(118, 60);
			this.tex開始店所コード.MaxLength = 3;
			this.tex開始店所コード.Name = "tex開始店所コード";
			this.tex開始店所コード.Size = new System.Drawing.Size(34, 23);
			this.tex開始店所コード.TabIndex = 3;
			this.tex開始店所コード.Text = "123";
			// 
			// tex終了店所コード
			// 
			this.tex終了店所コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex終了店所コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex終了店所コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex終了店所コード.Location = new System.Drawing.Point(174, 60);
			this.tex終了店所コード.MaxLength = 3;
			this.tex終了店所コード.Name = "tex終了店所コード";
			this.tex終了店所コード.Size = new System.Drawing.Size(34, 23);
			this.tex終了店所コード.TabIndex = 4;
			this.tex終了店所コード.Text = "123";
			// 
			// lab店所
			// 
			this.lab店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab店所.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab店所.Location = new System.Drawing.Point(36, 64);
			this.lab店所.Name = "lab店所";
			this.lab店所.Size = new System.Drawing.Size(76, 18);
			this.lab店所.TabIndex = 77;
			this.lab店所.Text = "店所コード";
			// 
			// lab地区線
			// 
			this.lab地区線.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab地区線.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab地区線.Location = new System.Drawing.Point(152, 26);
			this.lab地区線.Name = "lab地区線";
			this.lab地区線.Size = new System.Drawing.Size(22, 16);
			this.lab地区線.TabIndex = 1;
			this.lab地区線.Text = "～";
			// 
			// lab地区コード
			// 
			this.lab地区コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab地区コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab地区コード.Location = new System.Drawing.Point(36, 26);
			this.lab地区コード.Name = "lab地区コード";
			this.lab地区コード.Size = new System.Drawing.Size(76, 18);
			this.lab地区コード.TabIndex = 76;
			this.lab地区コード.Text = "地区コード";
			// 
			// tex開始地区コード
			// 
			this.tex開始地区コード.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex開始地区コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex開始地区コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex開始地区コード.Location = new System.Drawing.Point(118, 22);
			this.tex開始地区コード.MaxLength = 3;
			this.tex開始地区コード.Name = "tex開始地区コード";
			this.tex開始地区コード.Size = new System.Drawing.Size(34, 23);
			this.tex開始地区コード.TabIndex = 0;
			this.tex開始地区コード.Text = "123";
			// 
			// tex終了地区コード
			// 
			this.tex終了地区コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex終了地区コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex終了地区コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex終了地区コード.Location = new System.Drawing.Point(174, 22);
			this.tex終了地区コード.MaxLength = 3;
			this.tex終了地区コード.Name = "tex終了地区コード";
			this.tex終了地区コード.Size = new System.Drawing.Size(34, 23);
			this.tex終了地区コード.TabIndex = 2;
			this.tex終了地区コード.Text = "123";
			// 
			// lab出荷日線
			// 
			this.lab出荷日線.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab出荷日線.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab出荷日線.Location = new System.Drawing.Point(188, 138);
			this.lab出荷日線.Name = "lab出荷日線";
			this.lab出荷日線.Size = new System.Drawing.Size(24, 16);
			this.lab出荷日線.TabIndex = 48;
			this.lab出荷日線.Text = "～";
			// 
			// dt開始日付
			// 
			this.dt開始日付.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt開始日付.Location = new System.Drawing.Point(44, 134);
			this.dt開始日付.Name = "dt開始日付";
			this.dt開始日付.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt開始日付.Size = new System.Drawing.Size(144, 23);
			this.dt開始日付.TabIndex = 6;
			// 
			// dt終了日付
			// 
			this.dt終了日付.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dt終了日付.Location = new System.Drawing.Point(212, 134);
			this.dt終了日付.Name = "dt終了日付";
			this.dt終了日付.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dt終了日付.Size = new System.Drawing.Size(144, 23);
			this.dt終了日付.TabIndex = 7;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(22, 404);
			this.label1.TabIndex = 44;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 12;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab出荷状況タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab出荷状況タイトル
			// 
			this.lab出荷状況タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab出荷状況タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab出荷状況タイトル.ForeColor = System.Drawing.Color.White;
			this.lab出荷状況タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab出荷状況タイトル.Name = "lab出荷状況タイトル";
			this.lab出荷状況タイトル.Size = new System.Drawing.Size(264, 24);
			this.lab出荷状況タイトル.TabIndex = 0;
			this.lab出荷状況タイトル.Text = "出荷状況一覧表出力";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btnＣＳＶ出力);
			this.panel8.Controls.Add(this.btn印刷);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 286);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btnＣＳＶ出力
			// 
			this.btnＣＳＶ出力.ForeColor = System.Drawing.Color.Blue;
			this.btnＣＳＶ出力.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnＣＳＶ出力.Location = new System.Drawing.Point(134, 6);
			this.btnＣＳＶ出力.Name = "btnＣＳＶ出力";
			this.btnＣＳＶ出力.Size = new System.Drawing.Size(54, 48);
			this.btnＣＳＶ出力.TabIndex = 2;
			this.btnＣＳＶ出力.Text = "ＣＳＶ　出力";
			this.btnＣＳＶ出力.Click += new System.EventHandler(this.btnＣＳＶ出力_Click);
			// 
			// btn印刷
			// 
			this.btn印刷.ForeColor = System.Drawing.Color.Blue;
			this.btn印刷.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btn印刷.Location = new System.Drawing.Point(70, 6);
			this.btn印刷.Name = "btn印刷";
			this.btn印刷.Size = new System.Drawing.Size(54, 48);
			this.btn印刷.TabIndex = 1;
			this.btn印刷.Text = "印刷";
			this.btn印刷.Click += new System.EventHandler(this.btn印刷_Click);
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(192, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(194, 50);
			this.texメッセージ.TabIndex = 1;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
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
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.panel1);
			this.groupBox3.Location = new System.Drawing.Point(10, 78);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(372, 184);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			// 
			// 出荷状況
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(388, 342);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(394, 374);
			this.Name = "出荷状況";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 出荷状況一覧表出力";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.出荷状況_Load);
			this.Closed += new System.EventHandler(this.出荷状況_Closed);
			this.Activated += new System.EventHandler(this.出荷状況_Activated);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void 項目クリア()
		{
			tex開始地区コード.Text = "";
			tex終了地区コード.Text = "";
			tex開始店所コード.Text = "";
			tex終了店所コード.Text = "";
// ADD 2007.02.01 東都）高木 営業所-出荷状況一覧対応 START
			if(gs店所コード.Trim().Length != 0)
			{
				lab地区コード.Visible     = false;
				tex開始地区コード.Visible = false;
				lab地区線.Visible         = false;
				tex終了地区コード.Visible = false;

				tex開始店所コード.Text    = gs店所コード.Trim();
				tex開始店所コード.Enabled = false;
				lab店所線.Visible         = false;
				tex終了店所コード.Visible = false;
			}else{
				lab地区コード.Visible     = true;
				tex開始地区コード.Visible = true;
				lab地区線.Visible         = true;
				tex終了地区コード.Visible = true;

				tex開始店所コード.Text    = "";
				tex開始店所コード.Enabled = true;
				lab店所線.Visible         = true;
				tex終了店所コード.Visible = true;
			}
// ADD 2007.02.01 東都）高木 営業所-出荷状況一覧対応 END
// MOD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 START
//			dt開始日付.Value = new DateTime(System.DateTime.Now.Year, 
//											System.DateTime.Now.Month, 1);
//			dt終了日付.Value = System.DateTime.Now;
			dt終了日付.Value = System.DateTime.Now.AddDays(-1); // デフォルトを前日にする
// MOD 2007.01.25 東都）高木 負荷軽減（FJCS)石本殿より） START
//			dt開始日付.Value = new DateTime(dt終了日付.Value.Year, 
//											dt終了日付.Value.Month, 1);
			dt開始日付.Value = dt終了日付.Value;
// MOD 2007.01.25 東都）高木 負荷軽減（FJCS)石本殿より） END
// MOD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 END
//前月１日～末日
//			int iYear  = System.DateTime.Now.Year;
//			int iMonth = System.DateTime.Now.Month;
//			if(iMonth == 1)
//			{
//				iYear--;
//				iMonth = 12;
//			}
//			else
//			{
//				iMonth--;
//			}
//			dt開始日付.Value = new DateTime(iYear, iMonth, 1);
//			dt終了日付.Value = dt開始日付.Value.AddMonths(1).AddDays(-1);
			texメッセージ.Text = "";
		}

		private void 出荷状況_Load(object sender, System.EventArgs e)
		{
			項目クリア();
// ADD 2007.02.16 東都）高木 初期フォーカスの変更 START
			if(gs店所コード.Trim().Length == 0)
			{
				tex開始地区コード.Text = " ";
				tex開始地区コード.Focus();
			}
			else
			{
				dt開始日付.Focus();
			}
// ADD 2007.02.16 東都）高木 初期フォーカスの変更 END
		}

		private void 出荷状況_Closed(object sender, System.EventArgs e)
		{
			項目クリア();
// MOD 2007.02.16 東都）高木 初期フォーカスの変更 START
//			dt開始日付.Focus();
			tex開始地区コード.Text = " ";
			tex開始地区コード.Focus();
// MOD 2007.02.16 東都）高木 初期フォーカスの変更 END
		}

		private void btnＣＳＶ出力_Click(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";
			if (dt開始日付.Value > dt終了日付.Value)
			{
				MessageBox.Show("日付の範囲が正しく入力されていません","入力チェック",MessageBoxButtons.OK );
				dt開始日付.Focus();
				return;
			}
// ADD 2007.02.01 東都）高木 出荷状況一覧表の変更 START
			string sSdayh = YYYYMMDD変換(dt開始日付.Value.AddMonths(3));
			string sEdayh = YYYYMMDD変換(dt終了日付.Value);
			if (int.Parse(sSdayh) < int.Parse(sEdayh))
			{
				MessageBox.Show("日付の範囲は、３ヶ月以内で指定してください","入力チェック",MessageBoxButtons.OK );
				dt開始日付.Focus();
				return;
			}
// ADD 2007.02.01 東都）高木 出荷状況一覧表の変更 START

			string s開始日付 = YYYYMMDD変換(dt開始日付.Value);
			string s終了日付 = YYYYMMDD変換(dt終了日付.Value);

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sList = new string[2]{"",""};
				string[] sData = new string[6]{
												  tex開始地区コード.Text.Trim(),
												  tex終了地区コード.Text.Trim(),
												  tex開始店所コード.Text.Trim(),
												  tex終了店所コード.Text.Trim(),
												  s開始日付,
												  s終了日付
											  };

				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
//				sList = sv_maintenance.Get_syuuka_csv(gsaユーザ, sData);
// MOD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 START
//				sList = sv_maintenance.Get_syuuka_Inf(gsaユーザ, sData);
				sList = sv_maintenance.Get_syuuka_Inf2(gsaユーザ, sData);
// MOD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 END
				this.Cursor = System.Windows.Forms.Cursors.Default;

				if(sList[0].Length == 4)
				{
// MOD 2007.02.01 東都）高木 出荷状況一覧表の変更 START
//					sList[0] = "\"地区ＣＤ\",\"店所ＣＤ\",\"店所名\","
//						+ "\"荷主名\",\"荷主ＣＤ\",\"出荷日\","
//						+ "\"件数\",\"個数\",\"重量(Kg)\","
//						+ "\"運賃\",\"中継費\",\"保険料\""
//						;
					sList[0] = "\"地区１ＣＤ\",\"地区２ＣＤ\",\"店所ＣＤ\","
						+ "\"店所名\",\"お客様ＣＤ\",\"お客様名\","
						+ "\"セクションＣＤ\",\"セクション名\","
						+ "\"件数\",\"個数\",\"重量(Kg)\","
						+ "\"運賃\",\"中継費\",\"保険料\""
						;
// MOD 2007.02.01 東都）高木 出荷状況一覧表の変更 END

					// デフォルトのフォルダをデスクトップフォルダにする
					saveFileDialog1.InitialDirectory
						= Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
					saveFileDialog1.Filter = "ＣＳＶファイル (*.csv)|*.csv";
					byte[] bSJIS;
					if(saveFileDialog1.ShowDialog(this) == DialogResult.OK)
					{
						System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
						for(int iCnt = 0; iCnt < sList.Length; iCnt++)
						{
							bSJIS = toSJIS(sList[iCnt]);
							fs.Write(bSJIS, 0 , bSJIS.Length);
						}
						fs.Close();
						texメッセージ.Text = "";
					}
				}
				else
				{
					if(sList[0].Equals("該当データがありません"))
					{
						texメッセージ.Text = "";
						ビープ音();
// MOD 2007.02.15 東都）高木 メッセージタイトル修正 START
//						MessageBox.Show("該当データがありません","稼働率情報出力",MessageBoxButtons.OK);
						MessageBox.Show("該当データがありません","出荷状況情報出力",MessageBoxButtons.OK);
// MOD 2007.02.15 東都）高木 メッセージタイトル修正 END
					}
					else
					{
						ビープ音();
						texメッセージ.Text = sList[0];
					}
				}
			}
			catch (System.Net.WebException)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = gs通信エラー;
			}
			catch(Exception ex)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = ex.Message;
			}
		}

		private void btn印刷_Click(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";
			if (dt開始日付.Value > dt終了日付.Value)
			{
				MessageBox.Show("日付の範囲が正しく入力されていません","入力チェック",MessageBoxButtons.OK );
				dt開始日付.Focus();
				return;
			}
// ADD 2007.02.01 東都）高木 出荷状況一覧表の変更 START
			string sSdayh = YYYYMMDD変換(dt開始日付.Value.AddMonths(3));
			string sEdayh = YYYYMMDD変換(dt終了日付.Value);
			if (int.Parse(sSdayh) < int.Parse(sEdayh))
			{
				MessageBox.Show("日付の範囲は、３ヶ月以内で指定してください","入力チェック",MessageBoxButtons.OK );
				dt開始日付.Focus();
				return;
			}
// ADD 2007.02.01 東都）高木 出荷状況一覧表の変更 START

			string s開始日付 = YYYYMMDD変換(dt開始日付.Value);
			string s終了日付 = YYYYMMDD変換(dt終了日付.Value);

			texメッセージ.Text = "出荷状況情報一覧印刷中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sList = new string[2]{"",""};
				string[] sData = new string[6]{
												  tex開始地区コード.Text.Trim(),
												  tex終了地区コード.Text.Trim(),
												  tex開始店所コード.Text.Trim(),
												  tex終了店所コード.Text.Trim(),
												  s開始日付,
												  s終了日付
											  };

				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
//				sList = sv_maintenance.Get_syuuka_csv(gsaユーザ, sData);
// MOD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 START
//				IEnumerator iEnum = sv_maintenance.Get_syuuka_Prn(gsaユーザ, sData).GetEnumerator();;
				IEnumerator iEnum = sv_maintenance.Get_syuuka_Prn2(gsaユーザ, sData).GetEnumerator();;
// MOD 2006.10.20 東都）高木 一覧表作成の一部バッチ化 END

				iEnum.MoveNext();
				this.Cursor = System.Windows.Forms.Cursors.Default;
				sList = (string[])iEnum.Current;
				if (sList[0].Equals("正常終了"))
				{

					// まずはデータセットのインスタンスを生成
					出荷状況データ ds = new 出荷状況データ();

// ADD 2007.02.01 東都）高木 出荷状況一覧表の変更 START
					string sタイトル開始日 = s開始日付.Substring(0,4) 
											+ "/" + s開始日付.Substring(4,2)
											+ "/" + s開始日付.Substring(6,2);
					string sタイトル終了日 = s終了日付.Substring(0,4) 
						+ "/" + s終了日付.Substring(4,2)
						+ "/" + s終了日付.Substring(6,2);
// ADD 2007.02.01 東都）高木 出荷状況一覧表の変更 END

					//データセットに値をセット
					while (iEnum.MoveNext())
					{
						string[] sbList = new string[17];
						sbList = (string[])iEnum.Current;

						出荷状況データ.table出荷状況Row tr = (出荷状況データ.table出荷状況Row)ds.table出荷状況.NewRow();
						tr.BeginEdit();

// ADD 2007.02.01 東都）高木 出荷状況一覧表の変更 START
//						tr.店所CD = sbList[1].Trim();
//						tr.店所名 = sbList[2].Trim();
//						tr.荷主名 = sbList[3].Trim();
//						tr.荷主CD = sbList[4].Trim();
//						tr.出荷日 = sbList[5].Trim();
//						tr.件数   = sbList[6].Trim();
//						tr.個数   = sbList[7].Trim();
//						tr.重量   = sbList[8].Trim();
//						tr.運賃   = sbList[9].Trim();
//						tr.中継   = sbList[10].Trim();
//						tr.保険   = sbList[11].Trim();
						tr.地区１ＣＤ = sbList[0].Trim();
						tr.地区２ＣＤ = sbList[1].Trim();
						tr.店所ＣＤ   = sbList[2].Trim();
						tr.店所名     = sbList[3].Trim();
						tr.開始日     = sタイトル開始日;
						tr.終了日     = sタイトル終了日;
						tr.会員ＣＤ   = sbList[4].Trim();
						tr.会員名     = sbList[5].Trim();
						tr.部門ＣＤ   = sbList[6].Trim();
						tr.部門名     = sbList[7].Trim();
						tr.件数       = decimal.Parse(sbList[8].Trim());
						tr.個数       = decimal.Parse(sbList[9].Trim());
						tr.重量       = decimal.Parse(sbList[10].Trim());
						tr.運賃       = decimal.Parse(sbList[11].Trim());
						tr.中継       = decimal.Parse(sbList[12].Trim());
						tr.保険       = decimal.Parse(sbList[13].Trim());
// ADD 2007.02.01 東都）高木 出荷状況一覧表の変更 END

						tr.EndEdit();
						// 最後にデータセットに追加する
						ds.table出荷状況.Rows.Add(tr);
					}
					出荷状況一覧レポート cr = new 出荷状況一覧レポート();
					//CrystalReportにパラメータとデータセットを渡す
					cr.SetDataSource(ds);

					//プレビュー表示
// MOD 2007.02.06 東都）高木 プレビュー画面の高速化 START
//					プレビュー画面 画面 = new プレビュー画面();
//					画面.Left = this.Left;
//					画面.Top = this.Top;
//					画面.crv帳票.PrintReport();
//					画面.crv帳票.ReportSource = cr;
//					画面.ShowDialog();
					if(gプレビュ == null) gプレビュ = new プレビュー画面();
					gプレビュ.Left = this.Left;
					gプレビュ.Top = this.Top;
//					gプレビュ.crv帳票.PrintReport();
					gプレビュ.crv帳票.ReportSource = cr;
					gプレビュ.ShowDialog();
// MOD 2007.02.06 東都）高木 プレビュー画面の高速化 END

				}
				else
				{
					if(sList[0].Equals("該当データがありません"))
					{
						texメッセージ.Text = "";
						ビープ音();
						MessageBox.Show("該当データがありません","出荷状況一覧出力",MessageBoxButtons.OK);
					}
					else
					{
						ビープ音();
						texメッセージ.Text = sList[0];
					}
				}
			}
			catch (System.Net.WebException)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = gs通信エラー;
			}
			catch(Exception ex)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = ex.Message;
			}
			texメッセージ.Text = "";
		}

// ADD 2007.02.16 東都）高木 初期フォーカスの変更 START
		private void 出荷状況_Activated(object sender, System.EventArgs e)
		{
			if(tex開始地区コード.Visible == false)
				dt開始日付.Focus();
		}
// ADD 2007.02.16 東都）高木 初期フォーカスの変更 END
	}
}
