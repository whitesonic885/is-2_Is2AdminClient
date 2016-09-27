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
	public class 社内伝会員発店マスタ : 共通フォーム
	{
		public short nOldRow = 0;
		private string[] s社内伝会員一覧;
		private string   s更新日時 = "00000000000000";
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
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private 共通テキストボックス tex集約店コード;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn検索;
		private System.Windows.Forms.Label lab集約店;
		private System.Windows.Forms.Button btn取消;
		private System.Windows.Forms.Button btn登録;
		private System.Windows.Forms.Button btn集約店検索;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private 共通テキストボックス tex集約店名;
		private AxGTABLE32V2Lib.AxGTable32 axGT社内伝会員;
		private is2AdminClient.共通テキストボックス tex検索会員;
		public System.Windows.Forms.Label lab社内伝会員発店タイトル;
		private is2AdminClient.共通テキストボックス tex社内伝会員名;
		private System.Windows.Forms.Label lab検索会員;
		private System.Windows.Forms.Label lab社内伝会員コード;
		private is2AdminClient.共通テキストボックス tex社内伝会員コード;
		private System.Windows.Forms.Button btn会員検索;
		private System.Windows.Forms.Button btn削除;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 社内伝会員発店マスタ()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(社内伝会員発店マスタ));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn削除 = new System.Windows.Forms.Button();
			this.btn会員検索 = new System.Windows.Forms.Button();
			this.tex社内伝会員名 = new is2AdminClient.共通テキストボックス();
			this.tex集約店名 = new is2AdminClient.共通テキストボックス();
			this.btn取消 = new System.Windows.Forms.Button();
			this.btn登録 = new System.Windows.Forms.Button();
			this.btn集約店検索 = new System.Windows.Forms.Button();
			this.lab頁番号 = new System.Windows.Forms.Label();
			this.btn次頁 = new System.Windows.Forms.Button();
			this.btn前頁 = new System.Windows.Forms.Button();
			this.lab社内伝会員コード = new System.Windows.Forms.Label();
			this.tex社内伝会員コード = new is2AdminClient.共通テキストボックス();
			this.label1 = new System.Windows.Forms.Label();
			this.lab集約店 = new System.Windows.Forms.Label();
			this.tex集約店コード = new is2AdminClient.共通テキストボックス();
			this.axGT社内伝会員 = new AxGTABLE32V2Lib.AxGTable32();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab社内伝会員発店タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texメッセージ = new is2AdminClient.共通テキストボックス();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.tex検索会員 = new is2AdminClient.共通テキストボックス();
			this.lab検索会員 = new System.Windows.Forms.Label();
			this.btn検索 = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axGT社内伝会員)).BeginInit();
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
			this.panel1.Controls.Add(this.btn削除);
			this.panel1.Controls.Add(this.btn会員検索);
			this.panel1.Controls.Add(this.tex社内伝会員名);
			this.panel1.Controls.Add(this.tex集約店名);
			this.panel1.Controls.Add(this.btn取消);
			this.panel1.Controls.Add(this.btn登録);
			this.panel1.Controls.Add(this.btn集約店検索);
			this.panel1.Controls.Add(this.lab頁番号);
			this.panel1.Controls.Add(this.btn次頁);
			this.panel1.Controls.Add(this.btn前頁);
			this.panel1.Controls.Add(this.lab社内伝会員コード);
			this.panel1.Controls.Add(this.tex社内伝会員コード);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.lab集約店);
			this.panel1.Controls.Add(this.tex集約店コード);
			this.panel1.Controls.Add(this.axGT社内伝会員);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 408);
			this.panel1.TabIndex = 1;
			// 
			// btn削除
			// 
			this.btn削除.BackColor = System.Drawing.Color.Blue;
			this.btn削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn削除.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn削除.ForeColor = System.Drawing.Color.White;
			this.btn削除.Location = new System.Drawing.Point(264, 378);
			this.btn削除.Name = "btn削除";
			this.btn削除.Size = new System.Drawing.Size(48, 22);
			this.btn削除.TabIndex = 77;
			this.btn削除.Text = "削除";
			this.btn削除.Click += new System.EventHandler(this.btn削除_Click);
			// 
			// btn会員検索
			// 
			this.btn会員検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn会員検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn会員検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn会員検索.ForeColor = System.Drawing.Color.White;
			this.btn会員検索.Location = new System.Drawing.Point(290, 286);
			this.btn会員検索.Name = "btn会員検索";
			this.btn会員検索.Size = new System.Drawing.Size(48, 22);
			this.btn会員検索.TabIndex = 76;
			this.btn会員検索.TabStop = false;
			this.btn会員検索.Text = "検索";
			this.btn会員検索.Click += new System.EventHandler(this.btn会員検索_Click);
			// 
			// tex社内伝会員名
			// 
			this.tex社内伝会員名.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex社内伝会員名.BackColor = System.Drawing.Color.Honeydew;
			this.tex社内伝会員名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex社内伝会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex社内伝会員名.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex社内伝会員名.Location = new System.Drawing.Point(112, 318);
			this.tex社内伝会員名.MaxLength = 4;
			this.tex社内伝会員名.Name = "tex社内伝会員名";
			this.tex社内伝会員名.Size = new System.Drawing.Size(230, 16);
			this.tex社内伝会員名.TabIndex = 75;
			this.tex社内伝会員名.Text = "";
			// 
			// tex集約店名
			// 
			this.tex集約店名.BackColor = System.Drawing.Color.Honeydew;
			this.tex集約店名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex集約店名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex集約店名.Location = new System.Drawing.Point(210, 350);
			this.tex集約店名.Name = "tex集約店名";
			this.tex集約店名.ReadOnly = true;
			this.tex集約店名.Size = new System.Drawing.Size(74, 16);
			this.tex集約店名.TabIndex = 74;
			this.tex集約店名.TabStop = false;
			this.tex集約店名.Text = "";
			// 
			// btn取消
			// 
			this.btn取消.BackColor = System.Drawing.Color.Blue;
			this.btn取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn取消.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn取消.ForeColor = System.Drawing.Color.White;
			this.btn取消.Location = new System.Drawing.Point(318, 378);
			this.btn取消.Name = "btn取消";
			this.btn取消.Size = new System.Drawing.Size(48, 22);
			this.btn取消.TabIndex = 6;
			this.btn取消.Text = "取消";
			this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
			// 
			// btn登録
			// 
			this.btn登録.BackColor = System.Drawing.Color.Blue;
			this.btn登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn登録.ForeColor = System.Drawing.Color.White;
			this.btn登録.Location = new System.Drawing.Point(208, 378);
			this.btn登録.Name = "btn登録";
			this.btn登録.Size = new System.Drawing.Size(48, 22);
			this.btn登録.TabIndex = 4;
			this.btn登録.Text = "登録";
			this.btn登録.Click += new System.EventHandler(this.btn登録_Click);
			// 
			// btn集約店検索
			// 
			this.btn集約店検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn集約店検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn集約店検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn集約店検索.ForeColor = System.Drawing.Color.White;
			this.btn集約店検索.Location = new System.Drawing.Point(156, 346);
			this.btn集約店検索.Name = "btn集約店検索";
			this.btn集約店検索.Size = new System.Drawing.Size(48, 22);
			this.btn集約店検索.TabIndex = 66;
			this.btn集約店検索.TabStop = false;
			this.btn集約店検索.Text = "検索";
			this.btn集約店検索.Click += new System.EventHandler(this.btn集約店検索_Click);
			// 
			// lab頁番号
			// 
			this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab頁番号.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab頁番号.Location = new System.Drawing.Point(260, 256);
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
			this.btn次頁.Location = new System.Drawing.Point(308, 252);
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
			this.btn前頁.Location = new System.Drawing.Point(212, 252);
			this.btn前頁.Name = "btn前頁";
			this.btn前頁.Size = new System.Drawing.Size(48, 22);
			this.btn前頁.TabIndex = 62;
			this.btn前頁.Text = "前頁";
			this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
			// 
			// lab社内伝会員コード
			// 
			this.lab社内伝会員コード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab社内伝会員コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab社内伝会員コード.Location = new System.Drawing.Point(32, 292);
			this.lab社内伝会員コード.Name = "lab社内伝会員コード";
			this.lab社内伝会員コード.Size = new System.Drawing.Size(74, 14);
			this.lab社内伝会員コード.TabIndex = 61;
			this.lab社内伝会員コード.Text = "お客様コード";
			// 
			// tex社内伝会員コード
			// 
			this.tex社内伝会員コード.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex社内伝会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex社内伝会員コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex社内伝会員コード.Location = new System.Drawing.Point(110, 286);
			this.tex社内伝会員コード.MaxLength = 10;
			this.tex社内伝会員コード.Name = "tex社内伝会員コード";
			this.tex社内伝会員コード.Size = new System.Drawing.Size(172, 23);
			this.tex社内伝会員コード.TabIndex = 1;
			this.tex社内伝会員コード.Text = "";
			this.tex社内伝会員コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex社内伝会員コード_KeyDown);
			this.tex社内伝会員コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex社内伝会員コード_KeyPress);
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(42, 352);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(16, 14);
			this.label1.TabIndex = 57;
			this.label1.Text = "※";
			// 
			// lab集約店
			// 
			this.lab集約店.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab集約店.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab集約店.Location = new System.Drawing.Point(58, 352);
			this.lab集約店.Name = "lab集約店";
			this.lab集約店.Size = new System.Drawing.Size(48, 14);
			this.lab集約店.TabIndex = 56;
			this.lab集約店.Text = "発店所";
			// 
			// tex集約店コード
			// 
			this.tex集約店コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex集約店コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex集約店コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex集約店コード.Location = new System.Drawing.Point(110, 346);
			this.tex集約店コード.MaxLength = 4;
			this.tex集約店コード.Name = "tex集約店コード";
			this.tex集約店コード.Size = new System.Drawing.Size(42, 23);
			this.tex集約店コード.TabIndex = 2;
			this.tex集約店コード.Text = "";
			this.tex集約店コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex集約店コード_KeyDown);
			this.tex集約店コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex集約店コード_KeyPress);
			// 
			// axGT社内伝会員
			// 
			this.axGT社内伝会員.ContainingControl = this;
			this.axGT社内伝会員.DataSource = null;
			this.axGT社内伝会員.Location = new System.Drawing.Point(16, 10);
			this.axGT社内伝会員.Name = "axGT社内伝会員";
			this.axGT社内伝会員.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT社内伝会員.OcxState")));
			this.axGT社内伝会員.Size = new System.Drawing.Size(339, 235);
			this.axGT社内伝会員.TabIndex = 0;
			this.axGT社内伝会員.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT社内伝会員_KeyDownEvent);
			this.axGT社内伝会員.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT社内伝会員_CelDblClick);
			this.axGT社内伝会員.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT社内伝会員_CurPlaceChanged);
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab社内伝会員発店タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab社内伝会員発店タイトル
			// 
			this.lab社内伝会員発店タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab社内伝会員発店タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab社内伝会員発店タイトル.ForeColor = System.Drawing.Color.White;
			this.lab社内伝会員発店タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab社内伝会員発店タイトル.Name = "lab社内伝会員発店タイトル";
			this.lab社内伝会員発店タイトル.Size = new System.Drawing.Size(336, 24);
			this.lab社内伝会員発店タイトル.TabIndex = 0;
			this.lab社内伝会員発店タイトル.Text = "社内伝票会員発店情報メンテナンス";
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
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(70, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(312, 50);
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
			this.btn閉じる.TabIndex = 6;
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
			this.panel6.Size = new System.Drawing.Size(396, 26);
			this.panel6.TabIndex = 15;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Honeydew;
			this.panel5.Controls.Add(this.tex検索会員);
			this.panel5.Controls.Add(this.lab検索会員);
			this.panel5.Controls.Add(this.btn検索);
			this.panel5.Location = new System.Drawing.Point(1, 6);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(362, 36);
			this.panel5.TabIndex = 0;
			// 
			// tex検索会員
			// 
			this.tex検索会員.BackColor = System.Drawing.SystemColors.Window;
			this.tex検索会員.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex検索会員.Location = new System.Drawing.Point(110, 6);
			this.tex検索会員.MaxLength = 10;
			this.tex検索会員.Name = "tex検索会員";
			this.tex検索会員.Size = new System.Drawing.Size(160, 23);
			this.tex検索会員.TabIndex = 0;
			this.tex検索会員.Text = "";
			this.tex検索会員.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex検索会員_KeyDown);
			// 
			// lab検索会員
			// 
			this.lab検索会員.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab検索会員.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab検索会員.Location = new System.Drawing.Point(8, 10);
			this.lab検索会員.Name = "lab検索会員";
			this.lab検索会員.Size = new System.Drawing.Size(94, 16);
			this.lab検索会員.TabIndex = 46;
			this.lab検索会員.Text = "お客様コード";
			// 
			// btn検索
			// 
			this.btn検索.BackColor = System.Drawing.Color.SteelBlue;
			this.btn検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn検索.ForeColor = System.Drawing.Color.White;
			this.btn検索.Location = new System.Drawing.Point(292, 8);
			this.btn検索.Name = "btn検索";
			this.btn検索.Size = new System.Drawing.Size(64, 22);
			this.btn検索.TabIndex = 1;
			this.btn検索.TabStop = false;
			this.btn検索.Text = "検索";
			this.btn検索.Click += new System.EventHandler(this.btn検索_Click);
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
			// 社内伝会員発店マスタ
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(388, 582);
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
			this.Name = "社内伝会員発店マスタ";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 社内伝票会員発店情報メンテナンス";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.社内伝会員発店マスタ_Closed);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axGT社内伝会員)).EndInit();
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>

		private void Form1_Load(object sender, System.EventArgs e)
		{
			axGT社内伝会員.Cols = 3;
			axGT社内伝会員.Rows = 12;
			axGT社内伝会員.ColSep = "|";
			axGT社内伝会員.NoBeep = true;

			axGT社内伝会員.set_RowsText(0, "|お客様コード|お客様名|発店所|更新日付");

			axGT社内伝会員.ColsWidth = "0|7|14|5|0";
			axGT社内伝会員.ColsAlignHorz = "1|1|0|1|0|";

			axGT社内伝会員.set_CelForeColor(axGT社内伝会員.CaretRow,0,0x98FB98);  //BGR
			axGT社内伝会員.set_CelBackColor(axGT社内伝会員.CaretRow,0,0x006000);

			axGT社内伝会員.CaretRow = 1;
			tex検索会員.Text = " ";
			社内伝会員一覧検索();
			社内伝会員発店登録モード();
			tex検索会員.Focus();
		}

		private void 社内伝会員発店登録モード()
		{
			tex社内伝会員コード.Enabled = true;
			btn会員検索.Enabled = true;
			btn登録.Text = "登録";
			btn削除.Enabled = false;

			tex社内伝会員コード.Text = "";
			tex社内伝会員名.Text = "";
			tex集約店コード.Text = "";
			tex集約店名.Text = "";

			s更新日時 = "00000000000000";
		}

		private void 社内伝会員発店更新モード()
		{
			tex社内伝会員コード.Enabled = false;
			btn会員検索.Enabled = false;
			btn登録.Text = "更新";
			btn削除.Enabled = true;
		}

		private void 社内伝会員一覧検索()
		{
			axGT社内伝会員.Clear();

			tex検索会員.Text = tex検索会員.Text.Trim();
			if(tex検索会員.Text.Length == 0)
			{
				tex検索会員.Text = " ";
			}
			if(!半角チェック(tex検索会員, "お客様コード")) return;

			i現在頁数 = 1;
			axGT社内伝会員.CaretRow = 1;
			axGT社内伝会員.set_CelForeColor(nOldRow,0,0);
			axGT社内伝会員.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT社内伝会員.set_CelForeColor(axGT社内伝会員.CaretRow,0,0x98FB98);  //BGR
			axGT社内伝会員.set_CelBackColor(axGT社内伝会員.CaretRow,0,0x006000);
			nOldRow = axGT社内伝会員.CaretRow;
			
			s社内伝会員一覧 = new string[1];
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex検索会員.Text;
				s社内伝会員一覧 = sv_maintenance.Get_HouseSlipMember(gsaユーザ, sKey);
			}
			catch(Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(s社内伝会員一覧[0].Equals("正常終了"))
			{
				texメッセージ.Text = "";
				i最大頁数 = (s社内伝会員一覧.Length - 2) / (axGT社内伝会員.Rows - 1) + 1;
				if(i現在頁数 > i最大頁数)
				{
					i現在頁数 = i最大頁数;
				}
				頁情報設定();
			}
			else
			{
				texメッセージ.Text = s社内伝会員一覧[0];
				axGT社内伝会員.Clear();
				i現在頁数 = 1;
				btn前頁.Enabled = false;
				btn次頁.Enabled = false;
				lab頁番号.Text = "";
				ビープ音();
			}
			tex検索会員.Text = tex検索会員.Text.Trim();
		}

		private void 社内伝会員検索()
		{
			if(axGT社内伝会員.get_CelText(axGT社内伝会員.CaretRow,1).Equals(""))
			{
				return;
			}

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			
			try
			{
				string[] sKey  = new string[1];
				sKey[0] = axGT社内伝会員.get_CelText(axGT社内伝会員.CaretRow,1).Trim();
				string[] sList = sv_maintenance.Sel_HouseSlipMember(gsaユーザ, sKey);

				if(sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex社内伝会員コード.Text = sList[1].Trim();
					tex社内伝会員名.Text     = sList[2].Trim();
					tex集約店コード.Text = sList[3].Trim();
					tex集約店名.Text     = sList[4].Trim();					
		 		    s更新日時 = sList[5].Trim();
					社内伝会員発店更新モード();
					tex集約店コード.Focus();
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					axGT社内伝会員.Focus();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				社内伝会員発店登録モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void tex検索会員_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				社内伝会員一覧検索();
				tex集約店コード.Focus();
			}
		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			社内伝会員一覧検索();
			tex集約店コード.Focus();
		}

		private void axGT社内伝会員_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			社内伝会員検索();
		}

		private void axGT社内伝会員_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT社内伝会員.set_CelForeColor(nOldRow,0,0);
			axGT社内伝会員.set_CelBackColor(nOldRow,0,0xFFFFFF);
			axGT社内伝会員.set_CelForeColor(axGT社内伝会員.CaretRow,0,0x98FB98);  //BGR
			axGT社内伝会員.set_CelBackColor(axGT社内伝会員.CaretRow,0,0x006000);
			nOldRow = axGT社内伝会員.CaretRow;
		}

		private void axGT社内伝会員_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if(e.keyCode == 13)
			{
				社内伝会員検索();
			}

			if(e.keyCode == 9)
			{
				this.SelectNextControl(axGT社内伝会員, true, true, true, true);
			}
		}

		private void btn登録_Click(object sender, System.EventArgs e)
		{
			string s処理モード = btn登録.Text;
			if(登録チェック(s処理モード) != true)
			{
				return;
			}

			texメッセージ.Text = s処理モード + "中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = tex社内伝会員コード.Text;
				sKey[1] = tex集約店コード.Text;
				sKey[2] = s更新日時;
				sKey[3] = gs利用者コード;

				if(s処理モード.Equals("登録"))
				{
					string[] sList = sv_maintenance.Ins_HouseSlipMember(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if(sList[0].Equals("正常終了"))
					{
						//集約店の追加
						社内伝会員発店登録モード();
						社内伝会員一覧検索();
					}
					else
					{
						ビープ音();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_HouseSlipMember(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if(sList[0].Equals("正常終了"))
					{
						//集約店の更新
						社内伝会員発店登録モード();
						社内伝会員一覧検索();
					}
					else
					{
						ビープ音();
					}
				}
				tex集約店コード.Focus();
			}
			catch(Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				社内伝会員発店登録モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;		
		}

		private bool 登録チェック(string s処理モード)
		{
			//社内伝票会員チェック
			if(!社内伝票会員チェック())
			{
				tex社内伝会員コード.Focus();
				return false;
			}

			//発店所チェック
			if(!発店所チェック())
			{
				tex集約店コード.Focus();
				return false;
			}

			//登録時のみ、社内伝会員重複チェック
			if(s処理モード.Equals("登録"))
			{
				if(!社内伝票会員重複チェック())
				{
					MessageBox.Show("お客様コード(" + tex社内伝会員コード.Text + ")は既に登録されています", "入力チェック", MessageBoxButtons.OK);
					tex社内伝会員コード.Focus();
					return false;
				}
			}

			return true;
		}

		private bool 社内伝票会員チェック()
		{
			string s会員コード = tex社内伝会員コード.Text.Trim();

			//①空白チェック
			if(s会員コード.Length == 0)
			{
				MessageBox.Show("お客様コードを入力してください", "入力チェック", MessageBoxButtons.OK);
				return false;
			}

			//②半角チェック
			if(!半角チェック(tex社内伝会員コード, "お客様コード"))
			{
				return false;
			}

			//③形式チェック(会員コードの先頭2文字は『FK』でないと駄目)
			if(s会員コード.Substring(0,2) != "FK")
			{
				MessageBox.Show("お客様コードは『FK』から始めてください", "入力チェック", MessageBoxButtons.OK);
				return false;
			}

			//④ＣＭ０１会員マスタ存在チェック
			try
			{
				string[] sKey = new string[1];
				sKey[0] = s会員コード;
				string[] sList = sv_maintenance.Sel_Member(gsaユーザ, sKey);
				if(sList[0].Equals("正常終了"))
				{
					//ＣＭ０１会員マスタに存在
					texメッセージ.Text = "";
					tex社内伝会員名.Text = sList[2];
				}
				else
				{
					//それ以外の場合
					texメッセージ.Text = sList[0].Trim();
					MessageBox.Show("会員コード(" + s会員コード + ")が不正です", "入力チェック", MessageBoxButtons.OK);
					return false;
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				社内伝会員発店登録モード();
				return false;
			}
			return true;
		}

		private bool 発店所チェック()
		{
			string s店所コード = tex集約店コード.Text.Trim();

			//①空白チェック
			if(s店所コード.Length == 0)
			{
				MessageBox.Show("発店所コードを入力してください", "入力チェック", MessageBoxButtons.OK);
				return false;
			}

			//②半角チェック
			if(!半角チェック(tex集約店コード, "発店所コード"))
			{
				return false;
			}

			//③ＣＭ１０店所マスタ存在チェック
			try
			{
				string[] sKey = new string[1];
				sKey[0] = s店所コード;
				string[] sList = sv_maintenance.Sel_Shop(gsaユーザ, sKey);
				if(sList[0].Equals("正常終了"))
				{
					//ＣＭ１０店所マスタに存在
					texメッセージ.Text = "";
					tex集約店名.Text = sList[1];
				}
				else
				{
					//それ以外の場合
					texメッセージ.Text = sList[0].Trim();
					MessageBox.Show("発店所コード(" + s店所コード + ")が不正です", "入力チェック", MessageBoxButtons.OK);
					return false;
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				社内伝会員発店登録モード();
				return false;
			}
			return true;
		}

		private bool 社内伝票会員重複チェック()
		{
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex社内伝会員コード.Text.Trim();
				string[] sList = sv_maintenance.Sel_HouseSlipMember(gsaユーザ, sKey);
				if(sList[0].Equals("正常終了"))
				{
					//ＣＭ０５会員扱店Ｆマスタに存在（⇒データ重複）
					texメッセージ.Text = "";
					tex社内伝会員名.Text = sList[2];
					return false;
				}
				else if(sList[0].Equals("該当データがありません"))
				{
					//それ以外の場合
					texメッセージ.Text = "";
				}
				else
				{
					//それ以外の場合
					texメッセージ.Text = sList[0].Trim();
					return false;
				}
			}
			catch(Exception ex)
			{
				texメッセージ.Text = ex.Message;
				社内伝会員発店登録モード();
				return false;
			}
			return true;
		}

		private void btn削除_Click(object sender, System.EventArgs e)
		{
			tex社内伝会員コード.Text = tex社内伝会員コード.Text.Trim();

			//削除前の最終確認
			DialogResult result = MessageBox.Show("削除してもよろしいですか？", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.None);
			if(result == DialogResult.No)
			{
				return;
			}

			texメッセージ.Text = "削除中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[3];
				sKey[0] = tex社内伝会員コード.Text;
				sKey[1] = s更新日時;
				sKey[2] = gs利用者コード;

				string[] sList = sv_maintenance.Del_HouseSlipMember(gsaユーザ, sKey);
				texメッセージ.Text = sList[0];
				if(sList[0].Equals("正常終了"))
				{
					社内伝会員発店登録モード();
					社内伝会員一覧検索();
				}
				else
				{
					ビープ音();
				}
				tex社内伝会員コード.Focus();
			}
			catch(Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				社内伝会員発店登録モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn取消_Click(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";
			社内伝会員発店登録モード();
			tex社内伝会員コード.Focus();
		}

		private void btn会員検索_Click(object sender, System.EventArgs e)
		{
			会員一覧();
		}

		private void tex社内伝会員コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				tex社内伝会員コード.Text = tex社内伝会員コード.Text.Trim();
				if(tex社内伝会員コード.Text.Length == 0 || tex社内伝会員コード.Text.Length == 1)
				{
					tex社内伝会員コード.Focus();
				}
				else
				{
					int iRet = 会員検索();
					if(iRet == 0)
					{
						//会員情報未存在時
						tex社内伝会員コード.Focus();
					}
					else
					{
						//会員情報存在時
						tex集約店コード.Focus();
					}
				}
			}
		}

		private void tex社内伝会員コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar.ToString().Equals("*"))
			{
				btn会員検索.Focus();
				会員一覧();
				e.Handled = true;
			}
		}

		private void 会員一覧()
		{
			tex社内伝会員コード.Text = tex社内伝会員コード.Text.Trim();
			if(!半角チェック(tex社内伝会員コード, "お客様コード")) return;

			//検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			if (g会員検索 == null)	 g会員検索 = new 会員検索();
			g会員検索.Left = this.Left + 204;
			g会員検索.Top = this.Top;

			//コードの初期表示
			g会員検索.s会員コード = "";
			g会員検索.s会員名 = "";
			g会員検索.b運用中のお客様のみ = true;
			g会員検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g会員検索.s会員コード.Trim().Length > 0)
			{
				tex社内伝会員コード.Text = g会員検索.s会員コード.Trim();
				tex社内伝会員名.Text = g会員検索.s会員名.Trim();
			}
			else
			{
				tex社内伝会員コード.Focus();
			}
		}

		private int 会員検索()
		{
			tex社内伝会員コード.Text = tex社内伝会員コード.Text.Trim();
			if(!半角チェック(tex社内伝会員コード, "お客様コード")) return 0;
			if(tex社内伝会員コード.Text.ToUpper().Substring(0,2) != "FK")
			{
				texメッセージ.Text = "お客様コードは『FK』から始めてください";
				return 0;
			}

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			int iRet = 0;
			try
			{
				//ＣＭ０１会員マスタ存在チェック
				string[] sKey = new string[1];
				sKey[0] = tex社内伝会員コード.Text;
				string[] sList = sv_maintenance.Sel_Member(gsaユーザ, sKey);
				if(sList[0].Equals("正常終了"))
				{
					//ＣＭ０５会員扱店Ｆマスタ存在チェック
					string[] sList2 = sv_maintenance.Sel_HouseSlipMember(gsaユーザ, sKey);
					if(sList2[0].Equals("正常終了"))
					{
						texメッセージ.Text = "";
						tex社内伝会員コード.Text = sList2[1].Trim();
						tex社内伝会員名.Text = sList2[2].Trim();
						tex集約店コード.Text = sList2[3].Trim();
						tex集約店名.Text = sList2[4].Trim();					
						s更新日時 = sList2[5].Trim();
						社内伝会員発店更新モード();
						iRet = 1;
					}
					else if(sList2[0].Equals("該当データがありません"))
					{
						texメッセージ.Text = "";
						tex社内伝会員コード.Text = sList[1].Trim();
						tex社内伝会員名.Text = sList[2].Trim();
						s更新日時 = "00000000000000";
						btn登録.Text = "登録";
						btn削除.Enabled = false;
						iRet = 2;
					}
					else
					{
						texメッセージ.Text = sList2[0];
						社内伝会員発店登録モード();
						iRet = 0;
					}
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					iRet = 0;
				}
			}
			catch(Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				社内伝会員発店登録モード();
				iRet = 0;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return iRet;
		}

		private void btn集約店検索_Click(object sender, System.EventArgs e)
		{
			集約店所一覧();
		}

		private void tex集約店コード_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				tex集約店コード.Text = tex集約店コード.Text.Trim();
				if(tex集約店コード.Text.Length == 0)
				{
					tex集約店コード.Focus();
				}
				else
				{
					if(!集約店所検索())
					{
						tex集約店コード.Focus();
					}
				}
			}
		}

		private void tex集約店コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(e.KeyChar.ToString().Equals("*"))
			{
				btn集約店検索.Focus();
				集約店所一覧();
				e.Handled = true;
			}		
		}

		private void 集約店所一覧()
		{
			tex集約店コード.Text = tex集約店コード.Text.Trim();
			if(!半角チェック(tex集約店コード, "発店所コード")) return;

			//検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			if(g店所検索 == null)	 g店所検索 = new 店所検索();
			g店所検索.Left = this.Left + 204;
			g店所検索.Top = this.Top;

			//コードの初期表示
			g店所検索.s店所コード = "";
			g店所検索.s店所名 = "";
			g店所検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g店所検索.s店所コード.Trim().Length != 0)
			{
				tex集約店コード.Text = g店所検索.s店所コード.Trim();
				tex集約店名.Text = g店所検索.s店所名.Trim();
			}
			else
			{
				tex集約店コード.Focus();
			}
		}

		private bool 集約店所検索()
		{
			tex集約店コード.Text = tex集約店コード.Text.Trim();
			if(!半角チェック(tex集約店コード, "発店所コード")) return false;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex集約店コード.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsaユーザ, sKey);
				if(sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex集約店名.Text = sList[1];
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					ret =  false;
				}
			}
			catch(Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				社内伝会員発店登録モード();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();
			axGT社内伝会員.CaretRow = 1;
			axGT社内伝会員_CurPlaceChanged(null,null);
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();
			axGT社内伝会員.CaretRow = 1;
			axGT社内伝会員_CurPlaceChanged(null,null);
		}
		
		private void 頁情報設定()
		{
			axGT社内伝会員.Clear();

			i開始数 = (i現在頁数 - 1) * axGT社内伝会員.Rows + 1;
			i終了数 = i現在頁数 * axGT社内伝会員.Rows;

			short s表示数 = (short)1;
			for(short sCnt = (short)i開始数; sCnt < s社内伝会員一覧.Length && sCnt <= i終了数; sCnt++)
			{
				axGT社内伝会員.set_RowsText(s表示数, s社内伝会員一覧[sCnt]);
				s表示数++;
			}

			lab頁番号.Text = i現在頁数.ToString() + " / " + i最大頁数.ToString();

			if(i現在頁数 == 1)
			{
				btn前頁.Enabled = false;
			}
			else
			{
				btn前頁.Enabled = true;
			}

			if(i現在頁数 == i最大頁数)
			{
				btn次頁.Enabled = false;
			}
			else
			{
				btn次頁.Enabled = true;
			}
		}

		private void 社内伝会員発店マスタ_Closed(object sender, System.EventArgs e)
		{
			axGT社内伝会員.CaretRow = 1;
			axGT社内伝会員_CurPlaceChanged(null,null);
			tex検索会員.Focus();
		}
	}
}
