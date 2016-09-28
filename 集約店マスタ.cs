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
	public class 集約店マスタ : 共通フォーム
	{
		public short nOldRow = 0;
		private string[] s集約店一覧;
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lab頁番号;
		private System.Windows.Forms.Button btn次頁;
		private System.Windows.Forms.Button btn前頁;
		private 共通テキストボックス tex集荷店コード;
		private 共通テキストボックス tex集約店コード;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn検索;
		private System.Windows.Forms.Label lab集荷店;
		private System.Windows.Forms.Label lab集約店;
		private 共通テキストボックス tex検索店所;
		private System.Windows.Forms.Label lab検索店所;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtp使用開始日;
		private AxGTABLE32V2Lib.AxGTable32 axGT集約店;
		public System.Windows.Forms.Label lab集約店タイトル;
		private System.Windows.Forms.Button btn取消;
		private System.Windows.Forms.Button btn削除;
		private System.Windows.Forms.Button btn登録;
		private System.Windows.Forms.Button btn集約店検索;
		private System.Windows.Forms.Button btn集荷店検索;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private 共通テキストボックス tex集荷店名;
		private 共通テキストボックス tex集約店名;
		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 集約店マスタ()
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(集約店マスタ));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tex集約店名 = new is2AdminClient.共通テキストボックス();
            this.tex集荷店名 = new is2AdminClient.共通テキストボックス();
            this.btn取消 = new System.Windows.Forms.Button();
            this.btn削除 = new System.Windows.Forms.Button();
            this.btn登録 = new System.Windows.Forms.Button();
            this.dtp使用開始日 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn集約店検索 = new System.Windows.Forms.Button();
            this.btn集荷店検索 = new System.Windows.Forms.Button();
            this.lab頁番号 = new System.Windows.Forms.Label();
            this.btn次頁 = new System.Windows.Forms.Button();
            this.btn前頁 = new System.Windows.Forms.Button();
            this.lab集荷店 = new System.Windows.Forms.Label();
            this.tex集荷店コード = new is2AdminClient.共通テキストボックス();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lab集約店 = new System.Windows.Forms.Label();
            this.tex集約店コード = new is2AdminClient.共通テキストボックス();
            this.axGT集約店 = new AxGTABLE32V2Lib.AxGTable32();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lab集約店タイトル = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texメッセージ = new is2AdminClient.共通テキストボックス();
            this.btn閉じる = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tex検索店所 = new is2AdminClient.共通テキストボックス();
            this.lab検索店所 = new System.Windows.Forms.Label();
            this.btn検索 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT集約店)).BeginInit();
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
            this.panel1.Controls.Add(this.tex集約店名);
            this.panel1.Controls.Add(this.tex集荷店名);
            this.panel1.Controls.Add(this.btn取消);
            this.panel1.Controls.Add(this.btn削除);
            this.panel1.Controls.Add(this.btn登録);
            this.panel1.Controls.Add(this.dtp使用開始日);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn集約店検索);
            this.panel1.Controls.Add(this.btn集荷店検索);
            this.panel1.Controls.Add(this.lab頁番号);
            this.panel1.Controls.Add(this.btn次頁);
            this.panel1.Controls.Add(this.btn前頁);
            this.panel1.Controls.Add(this.lab集荷店);
            this.panel1.Controls.Add(this.tex集荷店コード);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lab集約店);
            this.panel1.Controls.Add(this.tex集約店コード);
            this.panel1.Controls.Add(this.axGT集約店);
            this.panel1.Location = new System.Drawing.Point(1, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(374, 408);
            this.panel1.TabIndex = 1;
            // 
            // tex集約店名
            // 
            this.tex集約店名.BackColor = System.Drawing.Color.Honeydew;
            this.tex集約店名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex集約店名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex集約店名.Location = new System.Drawing.Point(244, 314);
            this.tex集約店名.Name = "tex集約店名";
            this.tex集約店名.ReadOnly = true;
            this.tex集約店名.Size = new System.Drawing.Size(74, 16);
            this.tex集約店名.TabIndex = 74;
            this.tex集約店名.TabStop = false;
            // 
            // tex集荷店名
            // 
            this.tex集荷店名.BackColor = System.Drawing.Color.Honeydew;
            this.tex集荷店名.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tex集荷店名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex集荷店名.Location = new System.Drawing.Point(244, 284);
            this.tex集荷店名.Name = "tex集荷店名";
            this.tex集荷店名.ReadOnly = true;
            this.tex集荷店名.Size = new System.Drawing.Size(74, 16);
            this.tex集荷店名.TabIndex = 73;
            this.tex集荷店名.TabStop = false;
            // 
            // btn取消
            // 
            this.btn取消.BackColor = System.Drawing.Color.Blue;
            this.btn取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn取消.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn取消.ForeColor = System.Drawing.Color.White;
            this.btn取消.Location = new System.Drawing.Point(318, 378);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(48, 22);
            this.btn取消.TabIndex = 6;
            this.btn取消.Text = "取消";
            this.btn取消.UseVisualStyleBackColor = false;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // btn削除
            // 
            this.btn削除.BackColor = System.Drawing.Color.Blue;
            this.btn削除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn削除.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn削除.ForeColor = System.Drawing.Color.White;
            this.btn削除.Location = new System.Drawing.Point(264, 378);
            this.btn削除.Name = "btn削除";
            this.btn削除.Size = new System.Drawing.Size(48, 22);
            this.btn削除.TabIndex = 5;
            this.btn削除.Text = "削除";
            this.btn削除.UseVisualStyleBackColor = false;
            this.btn削除.Click += new System.EventHandler(this.btn削除_Click);
            // 
            // btn登録
            // 
            this.btn登録.BackColor = System.Drawing.Color.Blue;
            this.btn登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn登録.ForeColor = System.Drawing.Color.White;
            this.btn登録.Location = new System.Drawing.Point(210, 378);
            this.btn登録.Name = "btn登録";
            this.btn登録.Size = new System.Drawing.Size(48, 22);
            this.btn登録.TabIndex = 4;
            this.btn登録.Text = "登録";
            this.btn登録.UseVisualStyleBackColor = false;
            this.btn登録.Click += new System.EventHandler(this.btn登録_Click);
            // 
            // dtp使用開始日
            // 
            this.dtp使用開始日.Location = new System.Drawing.Point(144, 342);
            this.dtp使用開始日.Name = "dtp使用開始日";
            this.dtp使用開始日.Size = new System.Drawing.Size(108, 19);
            this.dtp使用開始日.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(62, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 68;
            this.label3.Text = "※";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.LimeGreen;
            this.label4.Location = new System.Drawing.Point(76, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 14);
            this.label4.TabIndex = 67;
            this.label4.Text = "使用開始日";
            // 
            // btn集約店検索
            // 
            this.btn集約店検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn集約店検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn集約店検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn集約店検索.ForeColor = System.Drawing.Color.White;
            this.btn集約店検索.Location = new System.Drawing.Point(190, 310);
            this.btn集約店検索.Name = "btn集約店検索";
            this.btn集約店検索.Size = new System.Drawing.Size(48, 22);
            this.btn集約店検索.TabIndex = 66;
            this.btn集約店検索.TabStop = false;
            this.btn集約店検索.Text = "検索";
            this.btn集約店検索.UseVisualStyleBackColor = false;
            this.btn集約店検索.Click += new System.EventHandler(this.btn集約店検索_Click);
            // 
            // btn集荷店検索
            // 
            this.btn集荷店検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn集荷店検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn集荷店検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn集荷店検索.ForeColor = System.Drawing.Color.White;
            this.btn集荷店検索.Location = new System.Drawing.Point(190, 280);
            this.btn集荷店検索.Name = "btn集荷店検索";
            this.btn集荷店検索.Size = new System.Drawing.Size(48, 22);
            this.btn集荷店検索.TabIndex = 65;
            this.btn集荷店検索.TabStop = false;
            this.btn集荷店検索.Text = "検索";
            this.btn集荷店検索.UseVisualStyleBackColor = false;
            this.btn集荷店検索.Click += new System.EventHandler(this.btn集荷店検索_Click);
            // 
            // lab頁番号
            // 
            this.lab頁番号.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
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
            this.btn次頁.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn次頁.ForeColor = System.Drawing.Color.White;
            this.btn次頁.Location = new System.Drawing.Point(308, 252);
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
            this.btn前頁.Location = new System.Drawing.Point(212, 252);
            this.btn前頁.Name = "btn前頁";
            this.btn前頁.Size = new System.Drawing.Size(48, 22);
            this.btn前頁.TabIndex = 62;
            this.btn前頁.Text = "前頁";
            this.btn前頁.UseVisualStyleBackColor = false;
            this.btn前頁.Click += new System.EventHandler(this.btn前頁_Click);
            // 
            // lab集荷店
            // 
            this.lab集荷店.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab集荷店.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab集荷店.Location = new System.Drawing.Point(76, 286);
            this.lab集荷店.Name = "lab集荷店";
            this.lab集荷店.Size = new System.Drawing.Size(66, 14);
            this.lab集荷店.TabIndex = 61;
            this.lab集荷店.Text = "集荷店";
            // 
            // tex集荷店コード
            // 
            this.tex集荷店コード.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tex集荷店コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex集荷店コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex集荷店コード.Location = new System.Drawing.Point(144, 280);
            this.tex集荷店コード.MaxLength = 4;
            this.tex集荷店コード.Name = "tex集荷店コード";
            this.tex集荷店コード.Size = new System.Drawing.Size(42, 23);
            this.tex集荷店コード.TabIndex = 1;
            this.tex集荷店コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex集荷店コード_KeyDown);
            this.tex集荷店コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex集荷店コード_KeyPress);
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(62, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 14);
            this.label2.TabIndex = 59;
            this.label2.Text = "※";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(62, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 14);
            this.label1.TabIndex = 57;
            this.label1.Text = "※";
            // 
            // lab集約店
            // 
            this.lab集約店.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab集約店.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab集約店.Location = new System.Drawing.Point(76, 316);
            this.lab集約店.Name = "lab集約店";
            this.lab集約店.Size = new System.Drawing.Size(66, 14);
            this.lab集約店.TabIndex = 56;
            this.lab集約店.Text = "集約店";
            // 
            // tex集約店コード
            // 
            this.tex集約店コード.BackColor = System.Drawing.SystemColors.Window;
            this.tex集約店コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex集約店コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tex集約店コード.Location = new System.Drawing.Point(144, 310);
            this.tex集約店コード.MaxLength = 4;
            this.tex集約店コード.Name = "tex集約店コード";
            this.tex集約店コード.Size = new System.Drawing.Size(42, 23);
            this.tex集約店コード.TabIndex = 2;
            this.tex集約店コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex集約店コード_KeyDown);
            this.tex集約店コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex集約店コード_KeyPress);
            // 
            // axGT集約店
            // 
            this.axGT集約店.DataSource = null;
            this.axGT集約店.Location = new System.Drawing.Point(16, 10);
            this.axGT集約店.Name = "axGT集約店";
            this.axGT集約店.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axGT集約店.OcxState")));
            this.axGT集約店.Size = new System.Drawing.Size(339, 235);
            this.axGT集約店.TabIndex = 0;
            this.axGT集約店.CurPlaceChanged += new AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEventHandler(this.axGT集約店_CurPlaceChanged);
            this.axGT集約店.CelDblClick += new AxGTABLE32V2Lib._DGTable32Events_CelDblClickEventHandler(this.axGT集約店_CelDblClick);
            this.axGT集約店.KeyDownEvent += new AxGTABLE32V2Lib._DGTable32Events_KeyDownEventHandler(this.axGT集約店_KeyDownEvent);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.panel7.Controls.Add(this.lab集約店タイトル);
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(396, 26);
            this.panel7.TabIndex = 13;
            // 
            // lab集約店タイトル
            // 
            this.lab集約店タイトル.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(241)))), ((int)(((byte)(83)))));
            this.lab集約店タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab集約店タイトル.ForeColor = System.Drawing.Color.White;
            this.lab集約店タイトル.Location = new System.Drawing.Point(12, 2);
            this.lab集約店タイトル.Name = "lab集約店タイトル";
            this.lab集約店タイトル.Size = new System.Drawing.Size(264, 24);
            this.lab集約店タイトル.TabIndex = 0;
            this.lab集約店タイトル.Text = "集約店情報メンテナンス";
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
            this.texメッセージ.Location = new System.Drawing.Point(70, 4);
            this.texメッセージ.Multiline = true;
            this.texメッセージ.Name = "texメッセージ";
            this.texメッセージ.ReadOnly = true;
            this.texメッセージ.Size = new System.Drawing.Size(312, 50);
            this.texメッセージ.TabIndex = 0;
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
            this.panel6.Size = new System.Drawing.Size(396, 26);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Honeydew;
            this.panel5.Controls.Add(this.tex検索店所);
            this.panel5.Controls.Add(this.lab検索店所);
            this.panel5.Controls.Add(this.btn検索);
            this.panel5.Location = new System.Drawing.Point(1, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(362, 36);
            this.panel5.TabIndex = 0;
            // 
            // tex検索店所
            // 
            this.tex検索店所.BackColor = System.Drawing.SystemColors.Window;
            this.tex検索店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tex検索店所.Location = new System.Drawing.Point(88, 6);
            this.tex検索店所.MaxLength = 4;
            this.tex検索店所.Name = "tex検索店所";
            this.tex検索店所.Size = new System.Drawing.Size(42, 23);
            this.tex検索店所.TabIndex = 0;
            this.tex検索店所.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex検索店所_KeyDown);
            // 
            // lab検索店所
            // 
            this.lab検索店所.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lab検索店所.ForeColor = System.Drawing.Color.LimeGreen;
            this.lab検索店所.Location = new System.Drawing.Point(8, 10);
            this.lab検索店所.Name = "lab検索店所";
            this.lab検索店所.Size = new System.Drawing.Size(76, 16);
            this.lab検索店所.TabIndex = 46;
            this.lab検索店所.Text = "集荷店";
            // 
            // btn検索
            // 
            this.btn検索.BackColor = System.Drawing.Color.SteelBlue;
            this.btn検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn検索.ForeColor = System.Drawing.Color.White;
            this.btn検索.Location = new System.Drawing.Point(292, 8);
            this.btn検索.Name = "btn検索";
            this.btn検索.Size = new System.Drawing.Size(64, 22);
            this.btn検索.TabIndex = 1;
            this.btn検索.TabStop = false;
            this.btn検索.Text = "検索";
            this.btn検索.UseVisualStyleBackColor = false;
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
            // 集約店マスタ
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
            this.Name = "集約店マスタ";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "is-2 集約店情報メンテナンス";
            this.Closed += new System.EventHandler(this.集約店マスタ_Closed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axGT集約店)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
			axGT集約店.Cols = 6;
			axGT集約店.Rows = 12;
			axGT集約店.ColSep = "|";
			axGT集約店.NoBeep = true;

			axGT集約店.set_RowsText(0, "|コード|集荷店||コード|集約店|使用開始日");

			axGT集約店.ColsWidth = "0|4|5|2|4|5|6";
			axGT集約店.ColsAlignHorz = "1|1|0|1|1|0|1|";

//			axGT集約店.set_CelForeColor(axGT集約店.CaretRow,0,111111);
			axGT集約店.set_CelForeColor(axGT集約店.CaretRow,0,0x98FB98);  //BGR
			axGT集約店.set_CelBackColor(axGT集約店.CaretRow,0,0x006000);

			axGT集約店.CaretRow = 1;
			tex検索店所.Text = " ";
			集約店一覧検索();
			集約店登録モード();
			tex検索店所.Focus();
		}

		private void 集約店登録モード()
		{
			tex集荷店コード.Enabled = true;
			btn集荷店検索.Enabled = true;
			btn登録.Text = "登録";
			btn削除.Enabled = false;

			tex集荷店コード.Text = "";
			tex集荷店名.Text = "";
			tex集約店コード.Text = "";
			tex集約店名.Text = "";
			dtp使用開始日.Value = System.DateTime.Now;

			s更新日時 = "00000000000000";
		}

		private void 集約店更新モード()
		{
			tex集荷店コード.Enabled = false;
			btn集荷店検索.Enabled = false;
			btn登録.Text = "更新";
			btn削除.Enabled = true;
		}

		private void 集約店一覧検索()
		{
			axGT集約店.Clear();

			tex検索店所.Text   = tex検索店所.Text.Trim();
			if (tex検索店所.Text.Length == 0)
			{
				tex検索店所.Text = " ";
			}
			if(!半角チェック(tex検索店所,"集荷店")) return;

			i現在頁数 = 1;
			axGT集約店.CaretRow = 1;
			axGT集約店.set_CelForeColor(nOldRow,0,0);
			axGT集約店.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT集約店.set_CelForeColor(axGT集約店.CaretRow,0,111111);
			axGT集約店.set_CelForeColor(axGT集約店.CaretRow,0,0x98FB98);  //BGR
			axGT集約店.set_CelBackColor(axGT集約店.CaretRow,0,0x006000);
			nOldRow = axGT集約店.CaretRow;
			
			s集約店一覧 = new string[1];
			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex検索店所.Text;
				s集約店一覧 = sv_maintenance.Get_ConnectShop(gsaユーザ, sKey);
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(s集約店一覧[0].Equals("正常終了"))
			{
				texメッセージ.Text = "";
// MOD 2005.05.12 東都）小童谷 一行目空白 START
//				i最大頁数 = (s集約店一覧.Length - 2) / axGT集約店.Rows + 1;
				i最大頁数 = (s集約店一覧.Length - 2) / (axGT集約店.Rows - 1) + 1;
// MOD 2005.05.12 東都）小童谷 一行目空白 END
				if (i現在頁数 > i最大頁数)
					i現在頁数 = i最大頁数;
				頁情報設定();
			}
			else
			{
				texメッセージ.Text = s集約店一覧[0];
				axGT集約店.Clear();
				i現在頁数 = 1;
				btn前頁.Enabled = false;
				btn次頁.Enabled = false;
				lab頁番号.Text = "";
				ビープ音();
			}
			tex検索店所.Text = tex検索店所.Text.Trim();
		}

		private void 集約店検索()
		{
			if (axGT集約店.get_CelText(axGT集約店.CaretRow,1).Equals("")) return;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			
			try
			{
				string[] sKey  = new string[1];
				sKey[0] = axGT集約店.get_CelText(axGT集約店.CaretRow,1).Trim();
				string[] sList = sv_maintenance.Sel_ConnectShop(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex集荷店コード.Text = sList[1].Trim();
					tex集荷店名.Text     = sList[2].Trim();
					tex集約店コード.Text = sList[3].Trim();
					tex集約店名.Text     = sList[4].Trim();					
					try
					{
//						System.DateTime dt日付 = System.DateTime.Parse(sList[5].Substring(0, 4) + "/" + sList[5].Substring(4, 2) + "/" + sList[5].Substring(6, 2));
						System.DateTime dt日付 = new DateTime(int.Parse(sList[5].Substring(0, 4)),int.Parse(sList[5].Substring(4, 2)),int.Parse(sList[5].Substring(6, 2)));
						dtp使用開始日.Value = dt日付;
					}
					catch
					{
						dtp使用開始日.Value = System.DateTime.Now;
					}
		 		    s更新日時            = sList[6].Trim();
					集約店更新モード();
					tex集約店コード.Focus();
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					axGT集約店.Focus();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				集約店登録モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}
		
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void tex検索店所_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				集約店一覧検索();
				tex集荷店コード.Focus();
			}
		}

		private void btn検索_Click(object sender, System.EventArgs e)
		{
			集約店一覧検索();
			tex集荷店コード.Focus();
		}

		private void axGT集約店_CelDblClick(object sender, AxGTABLE32V2Lib._DGTable32Events_CelDblClickEvent e)
		{
			集約店検索();
		}

		private void axGT集約店_CurPlaceChanged(object sender, AxGTABLE32V2Lib._DGTable32Events_CurPlaceChangedEvent e)
		{
			axGT集約店.set_CelForeColor(nOldRow,0,0);
			axGT集約店.set_CelBackColor(nOldRow,0,0xFFFFFF);
//			axGT集約店.set_CelForeColor(axGT集約店.CaretRow,0,111111);
			axGT集約店.set_CelForeColor(axGT集約店.CaretRow,0,0x98FB98);  //BGR
			axGT集約店.set_CelBackColor(axGT集約店.CaretRow,0,0x006000);
			nOldRow = axGT集約店.CaretRow;
		}

		private void axGT集約店_KeyDownEvent(object sender, AxGTABLE32V2Lib._DGTable32Events_KeyDownEvent e)
		{
			if (e.keyCode == 13)
			{
				集約店検索();
			}
			if (e.keyCode == 9)
			{
				this.SelectNextControl(axGT集約店, true, true, true, true);
			}
		}

		private void btn登録_Click(object sender, System.EventArgs e)
		{
			//集荷店チェック
			if (!集荷店所検索())
			{
				MessageBox.Show("集荷店(" + tex集荷店コード.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
				tex集荷店コード.Focus();
				return;
			}
			//集約店チェック
			if (!集約店所検索())
			{
				MessageBox.Show("集約店(" + tex集約店コード.Text + ")が存在しません" ,"入力チェック",MessageBoxButtons.OK);
				tex集約店コード.Focus();
				return;
			}

			texメッセージ.Text = btn登録.Text + "中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[8];
				sKey[0] = tex集荷店コード.Text;
				sKey[1] = tex集約店コード.Text;
				sKey[2] = dtp使用開始日.Value.Year.ToString() + dtp使用開始日.Value.Month.ToString().PadLeft(2, '0') + dtp使用開始日.Value.Day.ToString().PadLeft(2, '0');
				sKey[3] = s更新日時;
				sKey[4] = gs利用者コード;

				if (btn登録.Text.Equals("登録"))
				{
					string[] sList = sv_maintenance.Ins_ConnectShop(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						//集約店の追加
						集約店登録モード();
						集約店一覧検索();
					}
					else
					{
						ビープ音();
					}
				}
				else
				{
					string[] sList = sv_maintenance.Upd_ConnectShop(gsaユーザ, sKey);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						//集約店の更新
						集約店登録モード();
						集約店一覧検索();
					}
					else
					{
						ビープ音();
					}
				}
				tex集荷店コード.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				集約店登録モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;		
		}

		private void btn削除_Click(object sender, System.EventArgs e)
		{
			tex集荷店コード.Text = tex集荷店コード.Text.Trim();
			
			texメッセージ.Text = "削除中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[3];
				sKey[0] = tex集荷店コード.Text;
				sKey[1] = s更新日時;
				sKey[2] = gs利用者コード;

				string[] sList = sv_maintenance.Del_ConnectShop(gsaユーザ, sKey);
				texメッセージ.Text = sList[0];
				if (sList[0].Equals("正常終了"))
				{
					//利用者の削除
					集約店登録モード();
					集約店一覧検索();
				}
				else
				{
					ビープ音();
				}
				tex集約店コード.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				集約店登録モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn取消_Click(object sender, System.EventArgs e)
		{
			集約店登録モード();
		}

		private void btn集荷店検索_Click(object sender, System.EventArgs e)
		{
			集荷店所一覧();
		}

		private void tex集荷店コード_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				if(tex集荷店コード.Text.Length < 3)
					集荷店所一覧();
				else
					集荷店所検索();
			}
		}

		private void tex集荷店コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn集荷店検索.Focus();
				集荷店所一覧();
				e.Handled = true;
			}		
		}

		private void 集荷店所一覧()
		{
			tex集荷店コード.Text = tex集荷店コード.Text.Trim();
			if(!半角チェック(tex集荷店コード, "集荷店コード")) return;

			// 検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			店所検索 画面 = new 店所検索();
//			画面.Left = this.Left - 202;
//			画面.Top = this.Top;

			// コードの初期表示
//			画面.s店所コード = tex集荷店コード.Text;
//			画面.s店所名 = "";
//			画面.ShowDialog();
			if (g店所検索 == null)	 g店所検索 = new 店所検索();
			g店所検索.Left = this.Left - 202;
			g店所検索.Top = this.Top;
			// コードの初期表示
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし START
//			g店所検索.s店所コード = tex集荷店コード.Text;
			g店所検索.s店所コード = "";
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし END
			g店所検索.s店所名 = "";
			g店所検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (画面.s店所コード.Trim().Length != 0)
			if (g店所検索.s店所コード.Trim().Length != 0)
			{
//				tex集荷店コード.Text = 画面.s店所コード.Trim();
//				tex集荷店名.Text = 画面.s店所名.Trim();
				tex集荷店コード.Text = g店所検索.s店所コード.Trim();
				tex集荷店名.Text = g店所検索.s店所名.Trim();
				tex集約店コード.Focus();
// MOD 2005.05.25 東都）小童谷 画面高速化 END
			}
			else
			{
				tex集荷店コード.Focus();
			}
		}

		private bool 集荷店所検索()
		{
			tex集荷店コード.Text = tex集荷店コード.Text.Trim();
			if(!半角チェック(tex集荷店コード, "集荷店コード")) return false;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex集荷店コード.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsaユーザ, sKey);
				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					tex集荷店名.Text = sList[1];
				}
				else
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				集約店登録モード();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
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
				if(tex集約店コード.Text.Length < 3)
					集約店所一覧();
				else
					集約店所検索();
			}
		}

		private void tex集約店コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn集約店検索.Focus();
				集約店所一覧();
				e.Handled = true;
			}		
		}

		private void 集約店所一覧()
		{
			tex集約店コード.Text = tex集約店コード.Text.Trim();
			if(!半角チェック(tex集約店コード, "集約店コード")) return;

			// 検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			店所検索 画面 = new 店所検索();
//			画面.Left = this.Left - 202;
//			画面.Top = this.Top;

			// コードの初期表示
//			画面.s店所コード = tex集約店コード.Text;
//			画面.s店所名 = "";
//			画面.ShowDialog();
			if (g店所検索 == null)	 g店所検索 = new 店所検索();
			g店所検索.Left = this.Left - 202;
			g店所検索.Top = this.Top;
			// コードの初期表示
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし START
//			g店所検索.s店所コード = tex集約店コード.Text;
			g店所検索.s店所コード = "";
// MOD 2005.06.02 東都）小童谷 値の引継ぎなし END
			g店所検索.s店所名 = "";
			g店所検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

//			if (画面.s店所コード.Trim().Length != 0)
			if (g店所検索.s店所コード.Trim().Length != 0)
			{
//				tex集約店コード.Text = 画面.s店所コード.Trim();
//				tex集約店名.Text = 画面.s店所名.Trim();
				tex集約店コード.Text = g店所検索.s店所コード.Trim();
				tex集約店名.Text = g店所検索.s店所名.Trim();
				dtp使用開始日.Focus();
// MOD 2005.05.25 東都）小童谷 画面高速化 END
			}
			else
			{
				tex集約店コード.Focus();
			}
		}

		private bool 集約店所検索()
		{
			tex集約店コード.Text = tex集約店コード.Text.Trim();
			if(!半角チェック(tex集約店コード, "集約店コード")) return false;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex集約店コード.Text;
				string[] sList = sv_maintenance.Sel_Shop(gsaユーザ, sKey);
				if (sList[0].Equals("正常終了"))
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
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				集約店登録モード();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

		private void btn前頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数--;
			頁情報設定();
// ADD 2005.05.12 東都）小童谷 一行目選択 START
			axGT集約店.CaretRow = 1;
			axGT集約店_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END
		}

		private void btn次頁_Click(object sender, System.EventArgs e)
		{
			i現在頁数++;
			頁情報設定();
// ADD 2005.05.12 東都）小童谷 一行目選択 START
			axGT集約店.CaretRow = 1;
			axGT集約店_CurPlaceChanged(null,null);
// ADD 2005.05.12 東都）小童谷 一行目選択 END
		}
		
		private void 頁情報設定()
		{
			axGT集約店.Clear();

// MOD 2005.05.12 東都）小童谷 一行目空白 START
//			i開始数 = (i現在頁数 - 1) * axGT集約店.Rows + 1;
			i開始数 = (i現在頁数 - 1) * (axGT集約店.Rows - 1) + 1;
//			i終了数 = i現在頁数 * axGT集約店.Rows;
			i終了数 = i現在頁数 * (axGT集約店.Rows - 1);

//			short s表示数 = (short)1;
			short s表示数 = (short)2;
// MOD 2005.05.12 東都）小童谷 一行目空白 START
			for(short sCnt = (short)i開始数; sCnt < s集約店一覧.Length && sCnt <= i終了数 ; sCnt++)
			{
				axGT集約店.set_RowsText(s表示数, s集約店一覧[sCnt]);
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
		}

		private void 集約店マスタ_Closed(object sender, System.EventArgs e)
		{
			axGT集約店.CaretRow = 1;
			axGT集約店_CurPlaceChanged(null,null);
			tex検索店所.Focus();
		}

	}
}
