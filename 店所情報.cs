using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [契約店所情報メンテナンス]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 東都）高木 契約店所住所の全角半角混在チェックの追加 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	// ADD 2014.09.10 BEVAS）前田 支店止め機能追加対応 
	//--------------------------------------------------------------------------
	// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 
	//--------------------------------------------------------------------------
	public class 店所情報 : 共通フォーム//System.Windows.Forms.Form
	{
		public  int    iアクティブＦＧ = 0;
		private string s更新日時   = "00000000000000";
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 START
		private bool b支店止めＦＧ１ = false;
		private bool b支店止めＦＧ２ = false;
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 END

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label lab会員名;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private is2AdminClient.共通テキストボックス tex契約店所名;
		private System.Windows.Forms.Label lab契約店所住所;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.共通テキストボックス tex契約店所住所２;
		private is2AdminClient.共通テキストボックス tex契約店所住所１;
		private System.Windows.Forms.Label lab契約店所郵便;
		private System.Windows.Forms.Label lab契約店所電話;
		private System.Windows.Forms.ComboBox cb契約店所県;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private is2AdminClient.共通テキストボックス tex契約店所電話２;
		private is2AdminClient.共通テキストボックス tex契約店所電話３;
		private is2AdminClient.共通テキストボックス tex契約店所電話１;
		private System.Windows.Forms.Button btn契約店所郵便;
		private System.Windows.Forms.Panel pnl契約店所;
		private is2AdminClient.共通テキストボックス tex契約店所郵便１;
		private is2AdminClient.共通テキストボックス tex契約店所郵便２;
		private System.Windows.Forms.Button btn取消;
		private System.Windows.Forms.Button btn登録;
		private System.Windows.Forms.Label lab契約店所情報;
		private System.Windows.Forms.Label lab契約店所情報タイトル;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl店所コード;
		private System.Windows.Forms.Button btn店所情報実行;
		private System.Windows.Forms.Button btn店所情報検索;
		private is2AdminClient.共通テキストボックス tex店所コード;
		private System.Windows.Forms.Label lab店所コード;
		private System.Windows.Forms.Label lab地区１;
		private is2AdminClient.共通テキストボックス tex地区１;
		private is2AdminClient.共通テキストボックス tex地区２;
		private System.Windows.Forms.Label lab地区２;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox福通;
		private System.Windows.Forms.RadioButton rbtn福通対応;
		private System.Windows.Forms.RadioButton rbtn福通非対応;
		private System.Windows.Forms.GroupBox groupBox王子;
		private System.Windows.Forms.RadioButton rbtn王子対応;
		private System.Windows.Forms.RadioButton rbtn王子非対応;
		private System.ComponentModel.IContainer components = null;

		public 店所情報()
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
			this.tex契約店所名 = new is2AdminClient.共通テキストボックス();
			this.pnl契約店所 = new System.Windows.Forms.Panel();
			this.groupBox王子 = new System.Windows.Forms.GroupBox();
			this.rbtn王子非対応 = new System.Windows.Forms.RadioButton();
			this.rbtn王子対応 = new System.Windows.Forms.RadioButton();
			this.groupBox福通 = new System.Windows.Forms.GroupBox();
			this.rbtn福通非対応 = new System.Windows.Forms.RadioButton();
			this.rbtn福通対応 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.tex地区２ = new is2AdminClient.共通テキストボックス();
			this.lab地区２ = new System.Windows.Forms.Label();
			this.tex地区１ = new is2AdminClient.共通テキストボックス();
			this.lab地区１ = new System.Windows.Forms.Label();
			this.btn取消 = new System.Windows.Forms.Button();
			this.btn登録 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tex契約店所電話２ = new is2AdminClient.共通テキストボックス();
			this.tex契約店所電話３ = new is2AdminClient.共通テキストボックス();
			this.tex契約店所電話１ = new is2AdminClient.共通テキストボックス();
			this.cb契約店所県 = new System.Windows.Forms.ComboBox();
			this.lab契約店所電話 = new System.Windows.Forms.Label();
			this.lab契約店所郵便 = new System.Windows.Forms.Label();
			this.lab契約店所情報 = new System.Windows.Forms.Label();
			this.lab会員名 = new System.Windows.Forms.Label();
			this.lab契約店所住所 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tex契約店所郵便１ = new is2AdminClient.共通テキストボックス();
			this.tex契約店所郵便２ = new is2AdminClient.共通テキストボックス();
			this.btn契約店所郵便 = new System.Windows.Forms.Button();
			this.tex契約店所住所１ = new is2AdminClient.共通テキストボックス();
			this.tex契約店所住所２ = new is2AdminClient.共通テキストボックス();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab契約店所情報タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texメッセージ = new is2AdminClient.共通テキストボックス();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pnl店所コード = new System.Windows.Forms.Panel();
			this.btn店所情報検索 = new System.Windows.Forms.Button();
			this.btn店所情報実行 = new System.Windows.Forms.Button();
			this.lab店所コード = new System.Windows.Forms.Label();
			this.tex店所コード = new is2AdminClient.共通テキストボックス();
			this.pnl契約店所.SuspendLayout();
			this.groupBox王子.SuspendLayout();
			this.groupBox福通.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnl店所コード.SuspendLayout();
			this.SuspendLayout();
			// 
			// tex契約店所名
			// 
			this.tex契約店所名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex契約店所名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex契約店所名.Location = new System.Drawing.Point(98, 6);
			this.tex契約店所名.MaxLength = 20;
			this.tex契約店所名.Name = "tex契約店所名";
			this.tex契約店所名.Size = new System.Drawing.Size(326, 23);
			this.tex契約店所名.TabIndex = 0;
			this.tex契約店所名.Text = "";
			// 
			// pnl契約店所
			// 
			this.pnl契約店所.BackColor = System.Drawing.Color.Honeydew;
			this.pnl契約店所.Controls.Add(this.groupBox王子);
			this.pnl契約店所.Controls.Add(this.groupBox福通);
			this.pnl契約店所.Controls.Add(this.label2);
			this.pnl契約店所.Controls.Add(this.tex地区２);
			this.pnl契約店所.Controls.Add(this.lab地区２);
			this.pnl契約店所.Controls.Add(this.tex地区１);
			this.pnl契約店所.Controls.Add(this.lab地区１);
			this.pnl契約店所.Controls.Add(this.btn取消);
			this.pnl契約店所.Controls.Add(this.btn登録);
			this.pnl契約店所.Controls.Add(this.label4);
			this.pnl契約店所.Controls.Add(this.label9);
			this.pnl契約店所.Controls.Add(this.label12);
			this.pnl契約店所.Controls.Add(this.tex契約店所電話２);
			this.pnl契約店所.Controls.Add(this.tex契約店所電話３);
			this.pnl契約店所.Controls.Add(this.tex契約店所電話１);
			this.pnl契約店所.Controls.Add(this.cb契約店所県);
			this.pnl契約店所.Controls.Add(this.lab契約店所電話);
			this.pnl契約店所.Controls.Add(this.lab契約店所郵便);
			this.pnl契約店所.Controls.Add(this.lab契約店所情報);
			this.pnl契約店所.Controls.Add(this.tex契約店所名);
			this.pnl契約店所.Controls.Add(this.lab会員名);
			this.pnl契約店所.Controls.Add(this.lab契約店所住所);
			this.pnl契約店所.Controls.Add(this.label1);
			this.pnl契約店所.Controls.Add(this.tex契約店所郵便１);
			this.pnl契約店所.Controls.Add(this.tex契約店所郵便２);
			this.pnl契約店所.Controls.Add(this.btn契約店所郵便);
			this.pnl契約店所.Controls.Add(this.tex契約店所住所１);
			this.pnl契約店所.Controls.Add(this.tex契約店所住所２);
			this.pnl契約店所.Location = new System.Drawing.Point(1, 6);
			this.pnl契約店所.Name = "pnl契約店所";
			this.pnl契約店所.Size = new System.Drawing.Size(449, 308);
			this.pnl契約店所.TabIndex = 0;
			// 
			// groupBox王子
			// 
			this.groupBox王子.Controls.Add(this.rbtn王子非対応);
			this.groupBox王子.Controls.Add(this.rbtn王子対応);
			this.groupBox王子.Enabled = false;
			this.groupBox王子.ForeColor = System.Drawing.Color.LimeGreen;
			this.groupBox王子.Location = new System.Drawing.Point(102, 222);
			this.groupBox王子.Name = "groupBox王子";
			this.groupBox王子.Size = new System.Drawing.Size(334, 40);
			this.groupBox王子.TabIndex = 105;
			this.groupBox王子.TabStop = false;
			this.groupBox王子.Text = "王子運送";
			// 
			// rbtn王子非対応
			// 
			this.rbtn王子非対応.Enabled = false;
			this.rbtn王子非対応.Location = new System.Drawing.Point(170, 12);
			this.rbtn王子非対応.Name = "rbtn王子非対応";
			this.rbtn王子非対応.TabIndex = 1;
			this.rbtn王子非対応.Text = "非対応";
			// 
			// rbtn王子対応
			// 
			this.rbtn王子対応.Enabled = false;
			this.rbtn王子対応.Location = new System.Drawing.Point(26, 14);
			this.rbtn王子対応.Name = "rbtn王子対応";
			this.rbtn王子対応.TabIndex = 0;
			this.rbtn王子対応.Text = "対応";
			// 
			// groupBox福通
			// 
			this.groupBox福通.Controls.Add(this.rbtn福通非対応);
			this.groupBox福通.Controls.Add(this.rbtn福通対応);
			this.groupBox福通.ForeColor = System.Drawing.Color.LimeGreen;
			this.groupBox福通.Location = new System.Drawing.Point(102, 176);
			this.groupBox福通.Name = "groupBox福通";
			this.groupBox福通.Size = new System.Drawing.Size(334, 44);
			this.groupBox福通.TabIndex = 104;
			this.groupBox福通.TabStop = false;
			this.groupBox福通.Text = "福山通運";
			// 
			// rbtn福通非対応
			// 
			this.rbtn福通非対応.Location = new System.Drawing.Point(170, 14);
			this.rbtn福通非対応.Name = "rbtn福通非対応";
			this.rbtn福通非対応.TabIndex = 1;
			this.rbtn福通非対応.Text = "非対応";
			// 
			// rbtn福通対応
			// 
			this.rbtn福通対応.Location = new System.Drawing.Point(26, 16);
			this.rbtn福通対応.Name = "rbtn福通対応";
			this.rbtn福通対応.TabIndex = 0;
			this.rbtn福通対応.Text = "対応";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(44, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 18);
			this.label2.TabIndex = 103;
			this.label2.Text = "支店止め";
			// 
			// tex地区２
			// 
			this.tex地区２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex地区２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex地区２.Location = new System.Drawing.Point(98, 150);
			this.tex地区２.MaxLength = 3;
			this.tex地区２.Name = "tex地区２";
			this.tex地区２.Size = new System.Drawing.Size(40, 23);
			this.tex地区２.TabIndex = 14;
			this.tex地区２.Text = "";
			// 
			// lab地区２
			// 
			this.lab地区２.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab地区２.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab地区２.Location = new System.Drawing.Point(60, 156);
			this.lab地区２.Name = "lab地区２";
			this.lab地区２.Size = new System.Drawing.Size(38, 14);
			this.lab地区２.TabIndex = 102;
			this.lab地区２.Text = "地区２";
			// 
			// tex地区１
			// 
			this.tex地区１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex地区１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex地区１.Location = new System.Drawing.Point(98, 126);
			this.tex地区１.MaxLength = 3;
			this.tex地区１.Name = "tex地区１";
			this.tex地区１.Size = new System.Drawing.Size(40, 23);
			this.tex地区１.TabIndex = 13;
			this.tex地区１.Text = "";
			// 
			// lab地区１
			// 
			this.lab地区１.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab地区１.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab地区１.Location = new System.Drawing.Point(60, 132);
			this.lab地区１.Name = "lab地区１";
			this.lab地区１.Size = new System.Drawing.Size(38, 14);
			this.lab地区１.TabIndex = 100;
			this.lab地区１.Text = "地区１";
			// 
			// btn取消
			// 
			this.btn取消.BackColor = System.Drawing.Color.Blue;
			this.btn取消.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn取消.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn取消.ForeColor = System.Drawing.Color.White;
			this.btn取消.Location = new System.Drawing.Point(388, 278);
			this.btn取消.Name = "btn取消";
			this.btn取消.Size = new System.Drawing.Size(48, 22);
			this.btn取消.TabIndex = 16;
			this.btn取消.Text = "取消";
			this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
			// 
			// btn登録
			// 
			this.btn登録.BackColor = System.Drawing.Color.Blue;
			this.btn登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn登録.ForeColor = System.Drawing.Color.White;
			this.btn登録.Location = new System.Drawing.Point(334, 278);
			this.btn登録.Name = "btn登録";
			this.btn登録.Size = new System.Drawing.Size(48, 22);
			this.btn登録.TabIndex = 15;
			this.btn登録.Text = "登録";
			this.btn登録.Click += new System.EventHandler(this.btn登録_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.LimeGreen;
			this.label4.Location = new System.Drawing.Point(88, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 14);
			this.label4.TabIndex = 88;
			this.label4.Text = "（";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label9.ForeColor = System.Drawing.Color.LimeGreen;
			this.label9.Location = new System.Drawing.Point(154, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 14);
			this.label9.TabIndex = 89;
			this.label9.Text = "）";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label12.ForeColor = System.Drawing.Color.LimeGreen;
			this.label12.Location = new System.Drawing.Point(210, 108);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 14);
			this.label12.TabIndex = 90;
			this.label12.Text = "−";
			// 
			// tex契約店所電話２
			// 
			this.tex契約店所電話２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex契約店所電話２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex契約店所電話２.Location = new System.Drawing.Point(170, 102);
			this.tex契約店所電話２.MaxLength = 4;
			this.tex契約店所電話２.Name = "tex契約店所電話２";
			this.tex契約店所電話２.Size = new System.Drawing.Size(40, 23);
			this.tex契約店所電話２.TabIndex = 8;
			this.tex契約店所電話２.Text = "";
			// 
			// tex契約店所電話３
			// 
			this.tex契約店所電話３.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex契約店所電話３.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex契約店所電話３.Location = new System.Drawing.Point(224, 102);
			this.tex契約店所電話３.MaxLength = 4;
			this.tex契約店所電話３.Name = "tex契約店所電話３";
			this.tex契約店所電話３.Size = new System.Drawing.Size(40, 23);
			this.tex契約店所電話３.TabIndex = 9;
			this.tex契約店所電話３.Text = "";
			// 
			// tex契約店所電話１
			// 
			this.tex契約店所電話１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex契約店所電話１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex契約店所電話１.Location = new System.Drawing.Point(98, 102);
			this.tex契約店所電話１.MaxLength = 6;
			this.tex契約店所電話１.Name = "tex契約店所電話１";
			this.tex契約店所電話１.Size = new System.Drawing.Size(56, 23);
			this.tex契約店所電話１.TabIndex = 7;
			this.tex契約店所電話１.Text = "";
			// 
			// cb契約店所県
			// 
			this.cb契約店所県.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cb契約店所県.Location = new System.Drawing.Point(98, 54);
			this.cb契約店所県.Name = "cb契約店所県";
			this.cb契約店所県.Size = new System.Drawing.Size(88, 24);
			this.cb契約店所県.TabIndex = 4;
			// 
			// lab契約店所電話
			// 
			this.lab契約店所電話.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab契約店所電話.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab契約店所電話.Location = new System.Drawing.Point(58, 108);
			this.lab契約店所電話.Name = "lab契約店所電話";
			this.lab契約店所電話.Size = new System.Drawing.Size(30, 14);
			this.lab契約店所電話.TabIndex = 82;
			this.lab契約店所電話.Text = "ＴＥＬ";
			// 
			// lab契約店所郵便
			// 
			this.lab契約店所郵便.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab契約店所郵便.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab契約店所郵便.Location = new System.Drawing.Point(82, 36);
			this.lab契約店所郵便.Name = "lab契約店所郵便";
			this.lab契約店所郵便.Size = new System.Drawing.Size(14, 14);
			this.lab契約店所郵便.TabIndex = 81;
			this.lab契約店所郵便.Text = "〒";
			// 
			// lab契約店所情報
			// 
			this.lab契約店所情報.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab契約店所情報.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab契約店所情報.ForeColor = System.Drawing.Color.Blue;
			this.lab契約店所情報.Location = new System.Drawing.Point(0, 0);
			this.lab契約店所情報.Name = "lab契約店所情報";
			this.lab契約店所情報.Size = new System.Drawing.Size(22, 306);
			this.lab契約店所情報.TabIndex = 44;
			this.lab契約店所情報.Text = "契約店所情報";
			this.lab契約店所情報.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab会員名
			// 
			this.lab会員名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab会員名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab会員名.Location = new System.Drawing.Point(56, 12);
			this.lab会員名.Name = "lab会員名";
			this.lab会員名.Size = new System.Drawing.Size(42, 14);
			this.lab会員名.TabIndex = 9;
			this.lab会員名.Text = "店所名";
			// 
			// lab契約店所住所
			// 
			this.lab契約店所住所.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab契約店所住所.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab契約店所住所.Location = new System.Drawing.Point(44, 60);
			this.lab契約店所住所.Name = "lab契約店所住所";
			this.lab契約店所住所.Size = new System.Drawing.Size(54, 14);
			this.lab契約店所住所.TabIndex = 77;
			this.lab契約店所住所.Text = "店所住所";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.Location = new System.Drawing.Point(134, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 14);
			this.label1.TabIndex = 80;
			this.label1.Text = "−";
			// 
			// tex契約店所郵便１
			// 
			this.tex契約店所郵便１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex契約店所郵便１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex契約店所郵便１.Location = new System.Drawing.Point(98, 30);
			this.tex契約店所郵便１.MaxLength = 3;
			this.tex契約店所郵便１.Name = "tex契約店所郵便１";
			this.tex契約店所郵便１.Size = new System.Drawing.Size(34, 23);
			this.tex契約店所郵便１.TabIndex = 1;
			this.tex契約店所郵便１.Text = "";
			// 
			// tex契約店所郵便２
			// 
			this.tex契約店所郵便２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex契約店所郵便２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex契約店所郵便２.Location = new System.Drawing.Point(154, 30);
			this.tex契約店所郵便２.MaxLength = 4;
			this.tex契約店所郵便２.Name = "tex契約店所郵便２";
			this.tex契約店所郵便２.Size = new System.Drawing.Size(42, 23);
			this.tex契約店所郵便２.TabIndex = 2;
			this.tex契約店所郵便２.Text = "";
			this.tex契約店所郵便２.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex契約店所郵便２_KeyDown);
			this.tex契約店所郵便２.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex契約店所郵便２_KeyPress);
			// 
			// btn契約店所郵便
			// 
			this.btn契約店所郵便.BackColor = System.Drawing.Color.SteelBlue;
			this.btn契約店所郵便.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn契約店所郵便.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn契約店所郵便.ForeColor = System.Drawing.Color.White;
			this.btn契約店所郵便.Location = new System.Drawing.Point(204, 30);
			this.btn契約店所郵便.Name = "btn契約店所郵便";
			this.btn契約店所郵便.Size = new System.Drawing.Size(48, 22);
			this.btn契約店所郵便.TabIndex = 3;
			this.btn契約店所郵便.TabStop = false;
			this.btn契約店所郵便.Text = "検索";
			this.btn契約店所郵便.Click += new System.EventHandler(this.btn契約店所郵便_Click);
			// 
			// tex契約店所住所１
			// 
			this.tex契約店所住所１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex契約店所住所１.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex契約店所住所１.Location = new System.Drawing.Point(186, 54);
			this.tex契約店所住所１.MaxLength = 16;
			this.tex契約店所住所１.Name = "tex契約店所住所１";
			this.tex契約店所住所１.Size = new System.Drawing.Size(262, 23);
			this.tex契約店所住所１.TabIndex = 5;
			this.tex契約店所住所１.Text = "";
			// 
			// tex契約店所住所２
			// 
			this.tex契約店所住所２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex契約店所住所２.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex契約店所住所２.Location = new System.Drawing.Point(98, 78);
			this.tex契約店所住所２.MaxLength = 20;
			this.tex契約店所住所２.Name = "tex契約店所住所２";
			this.tex契約店所住所２.Size = new System.Drawing.Size(326, 23);
			this.tex契約店所住所２.TabIndex = 6;
			this.tex契約店所住所２.Text = "";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(462, 26);
			this.panel6.TabIndex = 12;
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab契約店所情報タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(462, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab契約店所情報タイトル
			// 
			this.lab契約店所情報タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab契約店所情報タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab契約店所情報タイトル.ForeColor = System.Drawing.Color.White;
			this.lab契約店所情報タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab契約店所情報タイトル.Name = "lab契約店所情報タイトル";
			this.lab契約店所情報タイトル.Size = new System.Drawing.Size(264, 24);
			this.lab契約店所情報タイトル.TabIndex = 0;
			this.lab契約店所情報タイトル.Text = "契約店所情報";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(462, 58);
			this.panel8.TabIndex = 0;
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(76, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(376, 50);
			this.texメッセージ.TabIndex = 30;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
			// 
			// btn閉じる
			// 
			this.btn閉じる.ForeColor = System.Drawing.Color.Red;
			this.btn閉じる.Location = new System.Drawing.Point(8, 6);
			this.btn閉じる.Name = "btn閉じる";
			this.btn閉じる.Size = new System.Drawing.Size(54, 48);
			this.btn閉じる.TabIndex = 5;
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pnl契約店所);
			this.groupBox2.Location = new System.Drawing.Point(4, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(452, 316);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(22, 408);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 14);
			this.label5.TabIndex = 31;
			this.label5.Text = "全て必須入力項目です。";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
			this.groupBox1.Controls.Add(this.pnl店所コード);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(26, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(430, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// pnl店所コード
			// 
			this.pnl店所コード.BackColor = System.Drawing.Color.Honeydew;
			this.pnl店所コード.Controls.Add(this.btn店所情報検索);
			this.pnl店所コード.Controls.Add(this.btn店所情報実行);
			this.pnl店所コード.Controls.Add(this.lab店所コード);
			this.pnl店所コード.Controls.Add(this.tex店所コード);
			this.pnl店所コード.ForeColor = System.Drawing.Color.Black;
			this.pnl店所コード.Location = new System.Drawing.Point(1, 6);
			this.pnl店所コード.Name = "pnl店所コード";
			this.pnl店所コード.Size = new System.Drawing.Size(427, 32);
			this.pnl店所コード.TabIndex = 0;
			// 
			// btn店所情報検索
			// 
			this.btn店所情報検索.BackColor = System.Drawing.Color.Blue;
			this.btn店所情報検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn店所情報検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn店所情報検索.ForeColor = System.Drawing.Color.White;
			this.btn店所情報検索.Location = new System.Drawing.Point(124, 6);
			this.btn店所情報検索.Name = "btn店所情報検索";
			this.btn店所情報検索.Size = new System.Drawing.Size(46, 22);
			this.btn店所情報検索.TabIndex = 1;
			this.btn店所情報検索.TabStop = false;
			this.btn店所情報検索.Text = "検索";
			this.btn店所情報検索.Click += new System.EventHandler(this.btn店所情報検索_Click);
			// 
			// btn店所情報実行
			// 
			this.btn店所情報実行.BackColor = System.Drawing.Color.Blue;
			this.btn店所情報実行.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn店所情報実行.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn店所情報実行.ForeColor = System.Drawing.Color.White;
			this.btn店所情報実行.Location = new System.Drawing.Point(176, 6);
			this.btn店所情報実行.Name = "btn店所情報実行";
			this.btn店所情報実行.Size = new System.Drawing.Size(48, 22);
			this.btn店所情報実行.TabIndex = 2;
			this.btn店所情報実行.Text = "実行";
			this.btn店所情報実行.Click += new System.EventHandler(this.btn店所情報実行_Click);
			// 
			// lab店所コード
			// 
			this.lab店所コード.BackColor = System.Drawing.Color.Honeydew;
			this.lab店所コード.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab店所コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab店所コード.Location = new System.Drawing.Point(4, 8);
			this.lab店所コード.Name = "lab店所コード";
			this.lab店所コード.Size = new System.Drawing.Size(72, 16);
			this.lab店所コード.TabIndex = 6;
			this.lab店所コード.Text = "店所コード";
			// 
			// tex店所コード
			// 
			this.tex店所コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex店所コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex店所コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex店所コード.Location = new System.Drawing.Point(76, 4);
			this.tex店所コード.MaxLength = 4;
			this.tex店所コード.Name = "tex店所コード";
			this.tex店所コード.Size = new System.Drawing.Size(42, 23);
			this.tex店所コード.TabIndex = 0;
			this.tex店所コード.Text = "";
			this.tex店所コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex店所コード_KeyDown);
			this.tex店所コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex店所コード_KeyPress);
			// 
			// 店所情報
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(460, 582);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(466, 607);
			this.Name = "店所情報";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 契約店所情報メンテナンス";
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 END
            this.Load += new System.EventHandler(this.店所情報_Load);
			this.Closed += new System.EventHandler(this.店所情報_Closed);
			this.Activated += new System.EventHandler(this.店所情報_Activated);
			this.pnl契約店所.ResumeLayout(false);
			this.groupBox王子.ResumeLayout(false);
			this.groupBox福通.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.pnl店所コード.ResumeLayout(false);
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
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void 店所情報_Load(object sender, System.EventArgs e)
		{
			// 県名の初期設定
			cb契約店所県.Items.Clear();
			cb契約店所県.Items.AddRange(sa県);

			クリア();
			更新モード();

// ADD 2014.09.10 BEVAS)前田 支店止め追加対応 START
			// 管理者権限でのみ、切替を許可する
			if(gs管理者区分 == "1")
			{
				// 管理者のみ
				if(gs会員コード == "oji")
				{
					// 王子運送の管理者の場合、
					// 王子側の支店止め対応のみを変更許可
					this.groupBox福通.Enabled = false;
					this.groupBox王子.Enabled = true;
					rbtn福通対応.Enabled = false;
					rbtn福通非対応.Enabled = false;
					rbtn王子対応.Enabled = true;
					rbtn王子非対応.Enabled = true;	
				}
				else if(gs会員コード == "honbu")
				{
					// 福山通運の管理者の場合、
					// 福通側・王子側の両方の支店止め対応を変更許可
					this.groupBox福通.Enabled = true;
					this.groupBox王子.Enabled = true;
					rbtn福通対応.Enabled = true;
					rbtn福通非対応.Enabled = true;
					rbtn王子対応.Enabled = true;
					rbtn王子非対応.Enabled = true;	
				}
			}
			else
			{
				// それ以外のログインユーザー（支店関係者、ユーザー）の場合、
				// 福通側・王子側の両方の支店止め対応を変更不許可
				this.groupBox福通.Enabled = false;
				this.groupBox王子.Enabled = false;
				rbtn福通対応.Enabled = false;
				rbtn福通非対応.Enabled = false;
				rbtn王子対応.Enabled = false;
				rbtn王子非対応.Enabled = false;	
			}
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 START
			b支店止めＦＧ１ = false;
			b支店止めＦＧ２ = false;
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 END
// ADD 2014.09.10 BEVAS)前田 支店止め追加対応 END

			tex契約店所名.Focus();
		}

		private void 更新モード()
		{
			if(gs店所コード.Trim().Length == 0)
			{
				//管理店所の場合
				btn店所情報実行.Visible = true;
				btn店所情報検索.Visible = true;
				lab地区１.Visible = true;
				tex地区１.Visible = true;
				lab地区２.Visible = true;
				tex地区２.Visible = true;
				btn取消.Visible = true;
			}
			else
			{
				//店所の場合
				btn店所情報実行.Visible = false;
				btn店所情報検索.Visible = false;
				lab地区１.Visible = false;
				tex地区１.Visible = false;
				lab地区２.Visible = false;
				tex地区２.Visible = false;
				btn取消.Visible = false;
			}

			pnl店所コード.Enabled = false;
			pnl契約店所.Enabled   = true;
			btn登録.Text = "更新";
			btn登録.Enabled = true;
		}

		private void tex店所コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
// MOD 2007.01.20 東都）高木 画面調整 START
//				店所情報検索();
				tex店所コード.Text = tex店所コード.Text.Trim();
				if(tex店所コード.Text.Length == 3)
					店所情報検索();
				else
					店所情報一覧();
// MOD 2007.01.20 東都）高木 画面調整 END
			}
		}

		private void tex店所コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn店所情報検索.Focus();
				店所情報一覧();
				e.Handled = true;
			}
		}

		private void btn店所情報検索_Click(object sender, System.EventArgs e)
		{
			店所情報一覧();
		}

		private void btn店所情報実行_Click(object sender, System.EventArgs e)
		{
			店所情報検索();
		}

		private void 店所情報一覧()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			//検索画面を表示する
			if(g店所検索 == null) g店所検索 = new 店所検索();
			g店所検索.Left = this.Left + 404;
//			g店所検索.Left = this.Left;
			g店所検索.Top = this.Top;

			// コードの初期表示
//			g店所検索.s店所コード = s店所コード.Trim();
// ADD 2007.01.20 東都）高木 初期表示のクリア START
			g店所検索.s店所コード = "";
			g店所検索.s店所名 = "";
// ADD 2007.01.20 東都）高木 初期表示のクリア END
			g店所検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g店所検索.s店所コード.Trim().Length > 0)
			{
				tex店所コード.Text = g店所検索.s店所コード.Trim();
				店所情報検索();
			}
			else
			{
				tex店所コード.Focus();
			}
		}

		private void 店所情報検索()
		{
			texメッセージ.Text = "";
			tex店所コード.Text = tex店所コード.Text.Trim();
			if(!必須チェック(tex店所コード, "店所コード")) return;
			if(!半角チェック(tex店所コード, "店所コード")) return;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[1];
				sKey[0] = tex店所コード.Text;
				string[] sData = sv_maintenance.Get_ShopInf(gsaユーザ, sKey);
// ADD 2014.09.10 BEVAS)前田 支店止め追加対応 START
				string[] sDeliData = sv_maintenance.Sel_GeneralDelivery(gsaユーザ, sKey);
// ADD 2014.09.10 BEVAS)前田 支店止め追加対応 END

// ADD 2014.09.10 BEVAS)前田 支店止め追加対応 START
				if (sData[0].Equals("正常終了"))
				{
// ADD 2014.09.10 BEVAS)前田 支店止め追加対応 END
					texメッセージ.Text = "";

					//各項目の設定

					//店所情報
					iアクティブＦＧ = 0;

					//契約店所情報
					tex契約店所名.Text   = sData[1];
					if(sData[2].Length > 0)
						cb契約店所県.SelectedIndex = int.Parse(sData[2]);
					else
						cb契約店所県.SelectedIndex = 0;
					tex契約店所住所１.Text = sData[3];
					tex契約店所住所２.Text = sData[4];

					string s契約店所郵便 = sData[5];
					if(s契約店所郵便.Length <= 3){
						tex契約店所郵便１.Text = s契約店所郵便;
					}else{
						tex契約店所郵便１.Text = s契約店所郵便.Substring(0,3);
						tex契約店所郵便２.Text = s契約店所郵便.Substring(3);
					}

					string[] 契約店所電話  = sData[6].Trim().Split('-');
					if(契約店所電話.Length > 0) tex契約店所電話１.Text = 契約店所電話[0];
					if(契約店所電話.Length > 1) tex契約店所電話２.Text = 契約店所電話[1];
					if(契約店所電話.Length > 2) tex契約店所電話３.Text = 契約店所電話[2];

// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 START
//					string[] 契約店所ＦＡＸ  = sData[7].Trim().Split('-');
//					if(契約店所ＦＡＸ.Length > 0) tex契約店所ＦＡＸ１.Text = 契約店所ＦＡＸ[0];
//					if(契約店所ＦＡＸ.Length > 1) tex契約店所ＦＡＸ２.Text = 契約店所ＦＡＸ[1];
//					if(契約店所ＦＡＸ.Length > 2) tex契約店所ＦＡＸ３.Text = 契約店所ＦＡＸ[2];
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 END

					tex地区１.Text = sData[8];
					tex地区２.Text = sData[9];

					//更新情報
					s更新日時 = sData[10];

					更新モード();
					tex契約店所名.Focus();
				}
				else
				{
					texメッセージ.Text = sData[0];
					ビープ音();
					if(gs店所コード.Trim().Length == 0){
						pnl店所コード.Enabled = true;
						tex店所コード.Focus();
					}
				}
// ADD 2014.09.10 BEVAS)前田 支店止め追加対応 START
				if (sDeliData[0].Equals("正常終了"))
				{
					if ((sDeliData[3].Trim()).Length > 6) 
					{
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 START
						//福通側
						if(sDeliData[1].Equals("1"))
						{
							b支店止めＦＧ１ = true;
						}
						//王子側
						if(sDeliData[2].Equals("1"))
						{
							b支店止めＦＧ２ = true;
						}
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 END
						// 管理者権限でのみ、切替を許可する
						if(gs管理者区分 == "1")
						{
							// 管理者のみ
							if(gs会員コード == "oji")
							{
								// 王子運送の管理者の場合、
								// 王子側の支店止め対応のみを変更許可
								this.groupBox福通.Enabled = false;
								this.groupBox王子.Enabled = true;
								rbtn福通対応.Enabled = false;
								rbtn福通非対応.Enabled = false;
								rbtn王子対応.Enabled = true;
								rbtn王子非対応.Enabled = true;	
							}
							else if(gs会員コード == "honbu")
							{
								// 福山通運の管理者の場合、
								// 福通側・王子側の両方の支店止め対応を変更許可
								this.groupBox福通.Enabled = true;
								this.groupBox王子.Enabled = true;
								rbtn福通対応.Enabled = true;
								rbtn福通非対応.Enabled = true;
								rbtn王子対応.Enabled = true;
								rbtn王子非対応.Enabled = true;	
							}
						}
						else
						{
							// それ以外のログインユーザー（支店関係者、ユーザー）の場合、
							// 福通側・王子側の両方の支店止め対応を変更不許可
							this.groupBox福通.Enabled = false;
							this.groupBox王子.Enabled = false;
							rbtn福通対応.Enabled = false;
							rbtn福通非対応.Enabled = false;
							rbtn王子対応.Enabled = false;
							rbtn王子非対応.Enabled = false;	
						}

						// ラジオボタンのチェック表示（福山通運用）
						if (sDeliData[1].Equals("1"))
						{
							rbtn福通対応.Checked = true;
							rbtn福通非対応.Checked = false;
						} 
						else 
						{
							rbtn福通対応.Checked = false;
							rbtn福通非対応.Checked = true;
						}

						// ラジオボタンのチェック表示（王子運送用）
						if (sDeliData[2].Equals("1"))
						{
							rbtn王子対応.Checked = true;
							rbtn王子非対応.Checked = false;
						}
						else
						{
							rbtn王子対応.Checked = false;
							rbtn王子非対応.Checked = true;
						}
					}
					else 
					{
						// 郵便番号がないため、支店止め無効
						this.groupBox福通.Enabled = false;
						this.groupBox王子.Enabled = false;
						rbtn福通対応.Enabled = false;
						rbtn福通非対応.Enabled = false;
						rbtn王子対応.Enabled = false;
						rbtn王子非対応.Enabled = false;		
					}
				} 
				else 
				{
					// 支店止め無効
					this.groupBox福通.Enabled = false;
					this.groupBox王子.Enabled = false;
					rbtn福通対応.Enabled = false;
					rbtn福通非対応.Enabled = false;
					rbtn王子対応.Enabled = false;
					rbtn王子非対応.Enabled = false;		
				}
// ADD 2014.09.10 BEVAS)前田 支店止め追加対応 END

			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				if(gs店所コード.Trim().Length == 0){
					pnl店所コード.Enabled = true;
					tex店所コード.Focus();
				}
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn登録_Click(object sender, System.EventArgs e)
		{

			if(登録_チェック() != true) return;
			try
			{
// MOD 2014.09.12 BEVAS) 前田 支店止め機能追加 START
				// 支店止めＦＧ１，２を追加
				//string[] sData  = new string[12];
				string[] sData  = new string[14];
// MOD 2014.09.12 BEVAS) 前田 支店止め機能追加 END

				//店所コード
				sData[0] = tex店所コード.Text;
				//契約店所情報
				sData[1] = tex契約店所名.Text;
				sData[2] = cb契約店所県.SelectedIndex.ToString("00");
				sData[3] = tex契約店所住所１.Text;
				sData[4] = tex契約店所住所２.Text;

				sData[5] = tex契約店所郵便１.Text + tex契約店所郵便２.Text;
				sData[6] = tex契約店所電話１.Text;
				if(tex契約店所電話２.Text.Length > 0) sData[6] += "-" + tex契約店所電話２.Text;
				if(tex契約店所電話３.Text.Length > 0) sData[6] += "-" + tex契約店所電話３.Text;

// MOD 2006.12.11 東都）小童谷　ＦＡＸ削除 START
//				sData[7] = tex契約店所ＦＡＸ１.Text;
//				if(tex契約店所ＦＡＸ２.Text.Length > 0) sData[7] += "-" + tex契約店所ＦＡＸ２.Text;
//				if(tex契約店所ＦＡＸ３.Text.Length > 0) sData[7] += "-" + tex契約店所ＦＡＸ３.Text;
				sData[7] = " ";
// MOD 2006.12.11 東都）小童谷　ＦＡＸ削除 END

				sData[8] = tex地区１.Text;
				sData[9] = tex地区２.Text;

				//更新情報
				sData[10] = s更新日時;
				sData[11] = gs利用者コード;

// ADD 2014.09.12 BEVAS) 前田 支店止め機能追加 START
				if (rbtn福通対応.Enabled) 
				{
					if (rbtn福通対応.Checked == true) 
					{
						sData[12] = "1";
					} 
					else 
					{
						sData[12] = "0";
					}
				} 
//				else 
//				{
//					sData[12] = "0";
//				}
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 START
				else
				{
					//保持していた値により設定
					if(b支店止めＦＧ１)
					{
						sData[12] = "1";
					}
					else
					{
						sData[12] = "0";
					}
				}
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 END
				if (rbtn王子対応.Enabled) 
				{
					if (rbtn王子対応.Checked == true) 
					{
						sData[13] = "1";
					} 
					else 
					{
						sData[13] = "0";
					}
				} 
//				else 
//				{
//					sData[13] = "0";
//				}
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 START
				else
				{
					//保持していた値により設定
					if(b支店止めＦＧ２)
					{
						sData[13] = "1";
					}
					else
					{
						sData[13] = "0";
					}
				}
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 END
// ADD 2014.09.12 BEVAS) 前田 支店止め機能追加 END

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};
				if (btn登録.Text.Equals("登録"))
				{
					;
				}
				else
				{
					sList = sv_maintenance.Upd_ShopInf(gsaユーザ, sData);
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						texメッセージ.Text = "";
						//会員の更新
						s更新日時 = sList[1].Trim();
						tex契約店所名.Focus();
// ADD 2006.11.10 東都）高木　更新後の画面遷移などの変更 START
						if(gs店所コード.Trim().Length == 0){
							//[btn取消_Click]と同じ動作
							クリア();
							pnl店所コード.Enabled = true;
// ADD 2007.01.26 東都）高木 画面調整 START
							pnl契約店所.Enabled = false;
// ADD 2007.01.26 東都）高木 画面調整 END
							tex店所コード.Text = " ";
							tex店所コード.Focus();
						}else{
							this.Close();
						}
// ADD 2006.11.10 東都）高木　更新後の画面遷移などの変更 END
					}
					else
					{
						ビープ音();
					}
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				tex契約店所名.Focus();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private bool 登録_チェック()
		{
			if(gs店所コード.Trim().Length != 0)
			{
				if (gs店所コード.Trim() != tex店所コード.Text.Trim())
				{
					MessageBox.Show("店所コードが正しくありません。（" + tex店所コード.Text.Trim() + "）","入力チェック", MessageBoxButtons.OK);
					tex店所コード.Focus();
					return false;
				}
			}

			//Ｔｒｉｍ
			tex契約店所名.Text = tex契約店所名.Text.Trim();
			tex契約店所郵便１.Text = tex契約店所郵便１.Text.Trim();
			tex契約店所郵便２.Text = tex契約店所郵便２.Text.Trim();
			cb契約店所県.Text = cb契約店所県.Text.Trim();
			tex契約店所住所１.Text = tex契約店所住所１.Text.Trim();
			tex契約店所住所２.Text = tex契約店所住所２.Text.Trim();
			tex契約店所電話１.Text = tex契約店所電話１.Text.Trim();
			tex契約店所電話２.Text = tex契約店所電話２.Text.Trim();
			tex契約店所電話３.Text = tex契約店所電話３.Text.Trim();
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 START
//			tex契約店所ＦＡＸ１.Text = tex契約店所ＦＡＸ１.Text.Trim();
//			tex契約店所ＦＡＸ２.Text = tex契約店所ＦＡＸ２.Text.Trim();
//			tex契約店所ＦＡＸ３.Text = tex契約店所ＦＡＸ３.Text.Trim();
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 END
			tex地区１.Text = tex地区１.Text.Trim();
			tex地区２.Text = tex地区２.Text.Trim();

			//必須チェック
// MOD 2014.09.24 BEVAS)前田 契約書項目の入力チェックの緩和 START
			bool エラーチェックFG = true;
			//if (!必須チェック(tex契約店所名, "店所名")) return false;
			if (tex契約店所名.Text.Length == 0) エラーチェックFG = false;
			//if (!必須チェック(tex契約店所郵便１, "郵便番号")) return false;
			if (tex契約店所郵便１.Text.Length == 0) エラーチェックFG = false;
			//if (!必須チェック(tex契約店所郵便２, "郵便番号")) return false;
			if (tex契約店所郵便２.Text.Length == 0) エラーチェックFG = false;

			//if (!必須チェック(cb契約店所県, "都道府県")) return false;
			if (cb契約店所県.Text.Length == 0) エラーチェックFG = false;

			//if (!必須チェック(tex契約店所住所１, "住所１")) return false;
			if (tex契約店所住所１.Text.Length == 0) エラーチェックFG = false;

			//if (!必須チェック(tex契約店所電話１, "電話番号")) return false;
			if (tex契約店所電話１.Text.Length == 0) エラーチェックFG = false;
			//if (!必須チェック(tex契約店所電話２, "電話番号")) return false;
			if (tex契約店所電話２.Text.Length == 0) エラーチェックFG = false;
			//if (!必須チェック(tex契約店所電話３, "電話番号")) return false;
			if (tex契約店所電話３.Text.Length == 0) エラーチェックFG = false;

			if (!エラーチェックFG) 
			{
				if (MessageBox.Show("未入力項目がございますが更新を継続してもよろしいでしょうか。","入力確認",MessageBoxButtons.YesNo) == DialogResult.No) 
				{
					// No の場合は処理を中断して終了する
					return false;
				}
			}
// MOD 2014.09.24 BEVAS)前田 契約書項目の入力チェック緩和 END
		
			// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 START
//			if (!必須チェック(tex契約店所ＦＡＸ１, "ＦＡＸ番号")) return false;
//			if (!必須チェック(tex契約店所ＦＡＸ２, "ＦＡＸ番号")) return false;
//			if (!必須チェック(tex契約店所ＦＡＸ３, "ＦＡＸ番号")) return false;
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 END

			//型チェック
			if (!全角チェック(tex契約店所名, "店所名")) return false;
			if (!半角チェック(tex契約店所郵便１, "郵便番号")) return false;
			if (!半角チェック(tex契約店所郵便２, "郵便番号")) return false;
//			if (!全角チェック(tex契約店所住所１, "店所住所１")) return false;
//			if (!全角チェック(tex契約店所住所２, "店所住所２")) return false;
// ADD 2008.05.07 東都）高木 契約店所住所の全角半角混在チェックの追加 START
			if(!全角半角混在チェック(tex契約店所住所１, "店所住所１")) return false;
			if(!全角半角混在チェック(tex契約店所住所２, "店所住所２")) return false;
// ADD 2008.05.07 東都）高木 契約店所住所の全角半角混在チェックの追加 END
			if (!半角チェック(tex契約店所電話１, "電話番号")) return false;
			if (!半角チェック(tex契約店所電話２, "電話番号")) return false;
			if (!半角チェック(tex契約店所電話３, "電話番号")) return false;
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 START
//			if (!半角チェック(tex契約店所ＦＡＸ１, "ＦＡＸ番号")) return false;
//			if (!半角チェック(tex契約店所ＦＡＸ２, "ＦＡＸ番号")) return false;
//			if (!半角チェック(tex契約店所ＦＡＸ３, "ＦＡＸ番号")) return false;
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 END
			if (!半角チェック(tex地区１, "地区１")) return false;
			if (!半角チェック(tex地区２, "地区２")) return false;

// ADD 2006.11.17 東都）高木　電話番号の桁数チェックの追加 START
			if(tex契約店所電話１.Text.Length + tex契約店所電話２.Text.Length + tex契約店所電話３.Text.Length > 11)
			{
				MessageBox.Show("電話番号を11桁以内で入力してください",
					"入力チェック",MessageBoxButtons.OK);
				tex契約店所電話１.Focus();
				return false;
			}
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 START
//			if(tex契約店所ＦＡＸ１.Text.Length + tex契約店所ＦＡＸ２.Text.Length + tex契約店所ＦＡＸ３.Text.Length > 11)
//			{
//				MessageBox.Show("ＦＡＸ番号を11桁以内で入力してください",
//					"入力チェック",MessageBoxButtons.OK);
//				tex契約店所ＦＡＸ１.Focus();
//				return false;
//			}
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 END
// ADD 2006.11.17 東都）高木　電話番号の桁数チェックの追加 END

// MOD 2014.09.24 BEVAS) 前田 郵便番号未入力時のチェックを回避 START
			if ((tex契約店所郵便１.Text.Length > 0) || (tex契約店所郵便２.Text.Length > 0)) 
			{
				//マスタチェック
				if (!郵便検索(tex契約店所郵便１, tex契約店所郵便２, 
					cb契約店所県, tex契約店所住所１, tex契約店所住所２, null))
				{
					MessageBox.Show("郵便番号(" + tex契約店所郵便１.Text + tex契約店所郵便２.Text + ")が存在しません",
						"入力チェック", MessageBoxButtons.OK);
					tex契約店所郵便１.Focus();
					return false;
				}
				if (!県名チェック(cb契約店所県, "都道府県")) return false;
			}
// MOD 2014.09.24 BEVAS) 前田 郵便番号未入力時のチェックを回避 END

			texメッセージ.Text = btn登録.Text + "中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			return(true);
		}

		private void クリア()
		{
			tex契約店所名.Text = "";
			tex契約店所郵便１.Text = "";
			tex契約店所郵便２.Text = "";
			cb契約店所県.SelectedIndex = 0;
			tex契約店所住所１.Text = "";
			tex契約店所住所２.Text = "";
			tex契約店所電話１.Text = "";
			tex契約店所電話２.Text = "";
			tex契約店所電話３.Text = "";
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 START
//			tex契約店所ＦＡＸ１.Text = "";
//			tex契約店所ＦＡＸ２.Text = "";
//			tex契約店所ＦＡＸ３.Text = "";
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 END

			tex地区１.Text = "";
			tex地区２.Text = "";

// ADD 2014.09.10 BEVAS）前田 支店止め機能追加対応 START
			// 支店止め対応ラジオボタンを初期化
			rbtn福通非対応.Checked = true;
			rbtn王子非対応.Checked = true;
// ADD 2014.09.10 BEVAS）前田 支店止め機能追加対応 END
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 START
			b支店止めＦＧ１ = false;
			b支店止めＦＧ２ = false;
// MOD 2016.03.31 BEVAS）松本 支店止めＦＧ項目追加に伴う例外発生バグの修正 END
		}

		private void 桁数表示()
		{
			tex店所コード.Text = "1234";

			tex契約店所名.Text = "全角20";
			tex契約店所郵便１.Text = "123";
			tex契約店所郵便２.Text = "4567";
			cb契約店所県.Text = "全角4";
			tex契約店所住所１.Text = "全角16";
			tex契約店所住所２.Text = "全角20";
			tex契約店所電話１.Text = "123456";
			tex契約店所電話２.Text = "1234";
			tex契約店所電話３.Text = "1234";
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 START
//			tex契約店所ＦＡＸ１.Text = "123456";
//			tex契約店所ＦＡＸ２.Text = "1234";
//			tex契約店所ＦＡＸ３.Text = "1234";
// DEL 2006.12.11 東都）小童谷　ＦＡＸ削除 END

			tex地区１.Text = "1234";
			tex地区２.Text = "1234";
		}

		private void btn取消_Click(object sender, System.EventArgs e)
		{
//			桁数表示();
			クリア();
			texメッセージ.Text = "";
			pnl店所コード.Enabled = true;
// ADD 2007.01.26 東都）高木 画面調整 START
			pnl契約店所.Enabled = false;
// ADD 2007.01.26 東都）高木 画面調整 END
			tex店所コード.Text = " ";
			tex店所コード.Focus();
		}

		private void tex契約店所郵便２_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				if(tex契約店所郵便１.Text.Length == 3 && tex契約店所郵便２.Text.Length == 4)
					郵便検索(tex契約店所郵便１, tex契約店所郵便２, 
						cb契約店所県, tex契約店所住所１, tex契約店所住所２, null);
				else{
					郵便一覧(tex契約店所郵便１, tex契約店所郵便２, 
						cb契約店所県, tex契約店所住所１, tex契約店所住所２, null);
				}
			}
		}

		private void tex契約店所郵便２_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn契約店所郵便.Focus();
				郵便一覧(tex契約店所郵便１, tex契約店所郵便２, 
					cb契約店所県, tex契約店所住所１, tex契約店所住所２, null);
				e.Handled = true;
			}
		}

		private void btn契約店所郵便_Click(object sender, System.EventArgs e)
		{
			郵便一覧(tex契約店所郵便１, tex契約店所郵便２, 
				cb契約店所県, tex契約店所住所１, tex契約店所住所２, null);
		}

		private bool 必須チェック(ComboBox cb県, string name)
		{
			if(cb県.Text.Length > 0) return true;
			MessageBox.Show("必須項目(" + name + ")が入力されていません",
				"入力チェック",MessageBoxButtons.OK);
			cb県.Focus();
			return false;
		}

		private void 郵便一覧(TextBox tex郵便番号１, TextBox tex郵便番号２, 
			ComboBox cb県, TextBox tex住所１, TextBox tex住所２, TextBox tex店所名)
		{
			tex郵便番号１.Text = tex郵便番号１.Text.Trim();
			tex郵便番号２.Text = tex郵便番号２.Text.Trim();
//			if(!半角チェック(tex郵便番号１, "郵便番号１")) return;
//			if(!半角チェック(tex郵便番号２, "郵便番号２")) return;

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g住所検索 == null) g住所検索 = new 住所検索();
			// 検索画面を右側に表示する
			g住所検索.Left = this.Left + 404;
			g住所検索.Top = this.Top;
			// コードの初期表示
			g住所検索.s郵便番号１ = "";
			g住所検索.s郵便番号２ = "";
			g住所検索.s管理店所   = "";
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
			//店コードより管理者区分を検索
			String[] sList;
			string[] sKey2  = new string[1];
			sKey2[0] = tex店所コード.Text;
			sList = sv_oji.Sel_Member(gsaユーザ, sKey2);
			g住所検索.sお客様ＣＤ = "";
			if (sList[0].Equals("正常終了"))
			{
				if ((sList[4].Equals("3"))||(sList[4].Equals("4")))
				{
					//王子運送会員
					g住所検索.sお客様ＣＤ = "J";
				}
			}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
			g住所検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if (g住所検索.s郵便番号１.Trim().Length != 0)
			{
				tex郵便番号１.Text = g住所検索.s郵便番号１.Trim();
				tex郵便番号２.Text = g住所検索.s郵便番号２.Trim();
				if(tex店所名 != null) 
				{
//					tex店所名.Text = g住所検索.s管理店所.Trim();
//					郵便検索(tex設置場所郵便１, tex設置場所郵便２, 
//						cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex店所名);
				}
				//cb県.SelectedIndex = int.Parse(g住所検索.s都道府県ＣＤ.Trim());
//				tex住所１.Text = g住所検索.s住所.Trim();
				県設定(g住所検索.s住所.Trim(), cb県, tex住所１);
				tex住所２.Text = "";
				tex住所２.Focus();
			}
			else
			{
				tex郵便番号１.Focus();
			}
		}

		private bool 郵便検索(TextBox tex郵便番号１, TextBox tex郵便番号２, 
			ComboBox cb県, TextBox tex住所１, TextBox tex住所２, TextBox tex店所名)
		{
			tex郵便番号１.Text = tex郵便番号１.Text.Trim();
			tex郵便番号２.Text = tex郵便番号２.Text.Trim();
			//if (!必須チェック(tex郵便番号１, "郵便番号１")) return false;
			//if (!半角チェック(tex郵便番号１, "郵便番号１")) return false;
			//if (!必須チェック(tex郵便番号２, "郵便番号２")) return false;
			//if (!半角チェック(tex郵便番号２, "郵便番号２")) return false;
			if (tex郵便番号１.Text.Length == 0) return true;
			if (tex郵便番号２.Text.Length == 0) return true;

			texメッセージ.Text = "郵便番号検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex郵便番号１.Text + tex郵便番号２.Text;
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				string[] sList = sv_maintenance.Sel_Postcode1(gsaユーザ, sKey);
				//店コードより管理者区分を検索
				String[] sList;
				string[] sKey2  = new string[1];
				sKey2[0] = tex店所コード.Text;
				sList = sv_oji.Sel_Member(gsaユーザ, sKey2);
				if (sList[0].Equals("正常終了"))
				{
					if ((sList[4].Equals("3"))||(sList[4].Equals("4")))
					{
						//王子運送会員
						sList = sv_oji.Sel_Postcode1(gsaユーザ, sKey);
					}
					else
					{
						//福通会員
						sList = sv_maintenance.Sel_Postcode1(gsaユーザ, sKey);
					}
				}
				else
				{
					sList = sv_maintenance.Sel_Postcode1(gsaユーザ, sKey);
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					if(tex店所名 != null) tex店所名.Text = sList[3].Trim();
					if(tex住所１.Text.Trim().Length == 0 && tex住所２.Text.Trim().Length == 0)
					{
//						tex住所１.Text = sList[2].Trim();
						県設定(sList[2].Trim(), cb県, tex住所１);
						tex住所２.Focus();
					}
					else
						tex住所１.Focus();
//					s店所コード = sList[4].Trim();
				}
				else
				{
					texメッセージ.Text = sList[0];
					if(tex店所名 != null) tex店所名.Text = "";
					ビープ音();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
//				初期モード();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

		private void 店所情報_Closed(object sender, System.EventArgs e)
		{
			iアクティブＦＧ = 0;
			s更新日時 = "";
			クリア();
			texメッセージ.Text = "";
			pnl店所コード.Enabled = true;
// ADD 2007.01.26 東都）高木 画面調整 START
			pnl契約店所.Enabled = false;
// ADD 2007.01.26 東都）高木 画面調整 END
			tex店所コード.Text = " ";
			tex店所コード.Focus();
		}

		private void 店所情報_Activated(object sender, System.EventArgs e)
		{
			if(iアクティブＦＧ == 1){
				if(gs店所コード.Trim().Length > 0)
				{
					tex店所コード.Text = gs店所コード;
					pnl店所コード.Enabled = false;
					店所情報検索();
				}else{
					pnl店所コード.Enabled = true;
					tex店所コード.Text = " ";
					tex店所コード.Focus();
// ADD 2007.01.26 東都）高木 画面調整 START
					pnl契約店所.Enabled = false;
// ADD 2007.01.26 東都）高木 画面調整 END
				}
			}
		}


	}
}
