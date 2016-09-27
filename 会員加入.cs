using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using CrystalDecisions.CrystalReports.Engine;

namespace is2AdminClient
{
	/// <summary>
	/// [使用申し込みメンテナンス]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// MOD 2008.05.02 東都）高木 申込者郵便番号エラーメッセージの変更 
	// [申込者郵便番号]の必須チェック時のエラーメッセージの変更
	//--------------------------------------------------------------------------
	// MOD 2008.05.07 東都）高木 エラーチェック順の変更 
	// ×[お申込者カナ]→[お客様]
	// ×[設置場所カナ]→[ご法人名]
	// [設置場所カナ]→[ご法人名カナ]
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	// MOD 2011.03.08 東都）高木 王子運送対応（王子営業所対応） 
	// MOD 2011.06.21 東都）高木 王子運送対応 
	//--------------------------------------------------------------------------
	// MOD 2016.04.13 BEVAS）松本 社内伝票対応
	//--------------------------------------------------------------------------
	public class 会員加入 : 共通フォーム
	{
		private string s店所コード = "";
		private string s申込更新日時   = "00000000000000";
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
		private string s申込時店所コード = "";
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab日時;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Button btn申込情報実行;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lab会員名;
		private 共通テキストボックス texメッセージ;
		private 共通テキストボックス tex認証会員名;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label lab簡易ユーザー;
		private System.Windows.Forms.Label lab会員加入タイトル;
		private is2AdminClient.共通テキストボックス tex申込者名;
		private System.Windows.Forms.Label lab申込者;
		private is2AdminClient.共通テキストボックス tex申込者カナ;
		private System.Windows.Forms.Label lab申込者住所;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.共通テキストボックス tex申込者住所２;
		private is2AdminClient.共通テキストボックス tex申込者住所１;
		private System.Windows.Forms.Label lab申込管理NO;
		private System.Windows.Forms.Label lab申込者郵便;
		private System.Windows.Forms.Label lab申込者電話;
		private System.Windows.Forms.Label lab申込者ＦＡＸ;
		private System.Windows.Forms.ComboBox cb申込者県;
		private System.Windows.Forms.Button btn申込情報検索;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lab申込者カナ;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label lab設置場所カナ;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label lab設置場所;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label24;
		private is2AdminClient.共通テキストボックス tex部門名;
		private System.Windows.Forms.Label lab部門名;
		private is2AdminClient.共通テキストボックス tex部門コード;
		private System.Windows.Forms.Label lab部門コード;
		private System.Windows.Forms.DateTimePicker dtp使用開始日;
		private System.Windows.Forms.Label lab使用開始日;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label lab利用者名;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.Label lab台;
		private System.Windows.Forms.NumericUpDown numサーマル台数;
		private System.Windows.Forms.Label labサーマル;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.Label label47;
		private is2AdminClient.共通テキストボックス tex管理店所名;
		private System.Windows.Forms.Label lab管理店所;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label49;
		private is2AdminClient.共通テキストボックス tex受付ＮＯ;
		private System.Windows.Forms.Label lab申請中;
		private is2AdminClient.共通テキストボックス tex設置場所カナ;
		private is2AdminClient.共通テキストボックス tex申込者ＦＡＸ２;
		private is2AdminClient.共通テキストボックス tex申込者ＦＡＸ３;
		private is2AdminClient.共通テキストボックス tex申込者ＦＡＸ１;
		private is2AdminClient.共通テキストボックス tex申込者電話２;
		private is2AdminClient.共通テキストボックス tex申込者電話３;
		private is2AdminClient.共通テキストボックス tex申込者電話１;
		private is2AdminClient.共通テキストボックス tex設置場所使用料;
		private is2AdminClient.共通テキストボックス tex設置場所役職名;
		private is2AdminClient.共通テキストボックス tex設置場所担当者名;
		private is2AdminClient.共通テキストボックス tex設置場所ＦＡＸ２;
		private is2AdminClient.共通テキストボックス tex設置場所ＦＡＸ３;
		private is2AdminClient.共通テキストボックス tex設置場所ＦＡＸ１;
		private is2AdminClient.共通テキストボックス tex設置場所電話２;
		private is2AdminClient.共通テキストボックス tex設置場所電話３;
		private is2AdminClient.共通テキストボックス tex設置場所電話１;
		private System.Windows.Forms.ComboBox cb設置場所県;
		private is2AdminClient.共通テキストボックス tex設置場所名;
		private is2AdminClient.共通テキストボックス tex設置場所住所１;
		private is2AdminClient.共通テキストボックス tex設置場所住所２;
		private System.Windows.Forms.Button btn登録;
		private System.Windows.Forms.Button btn削除;
		private System.Windows.Forms.Button btn取消;
		private System.Windows.Forms.RadioButton rb登録中;
		private System.Windows.Forms.RadioButton rb承認済;
		private System.Windows.Forms.RadioButton rb留保中;
		private System.Windows.Forms.RadioButton rb申請中;
		private is2AdminClient.共通テキストボックス texユーザー名;
		private is2AdminClient.共通テキストボックス tex初期パスワード;
		private is2AdminClient.共通テキストボックス texお客様コード;
		private is2AdminClient.共通テキストボックス texユーザーコード;
		private is2AdminClient.共通テキストボックス texメモ;
		private System.Windows.Forms.Button btn申込者郵便;
		private System.Windows.Forms.Button btnお客様コード;
		private System.Windows.Forms.Button btn設置場所郵便;
		private is2AdminClient.共通テキストボックス tex認証利用者名;
		private System.Windows.Forms.Label lab認証利用者名;
		private System.Windows.Forms.CheckBox chb設置場所;
		private System.Windows.Forms.Panel pnl申込者;
		private System.Windows.Forms.Panel pnlシステム情報;
		private System.Windows.Forms.Panel pnl設置場所;
		private System.Windows.Forms.Panel pnl受付ＮＯ;
		private is2AdminClient.共通テキストボックス tex申込者郵便１;
		private is2AdminClient.共通テキストボックス tex申込者郵便２;
		private is2AdminClient.共通テキストボックス tex設置場所郵便１;
		private is2AdminClient.共通テキストボックス tex設置場所郵便２;
		private System.Windows.Forms.Label lab初期パスワード;
		private System.Windows.Forms.Label lab米_初期パスワード;
		private System.Windows.Forms.Label lab説明_初期パスワード;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label lab認証会員名;
		private System.Windows.Forms.Button btn支店情報登録;
		private System.Windows.Forms.Button btn契約書;
		private System.ComponentModel.IContainer components;

		public 会員加入()
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
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(会員加入));
			this.tex申込者名 = new is2AdminClient.共通テキストボックス();
			this.pnl申込者 = new System.Windows.Forms.Panel();
			this.label24 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.tex申込者ＦＡＸ２ = new is2AdminClient.共通テキストボックス();
			this.tex申込者ＦＡＸ３ = new is2AdminClient.共通テキストボックス();
			this.tex申込者ＦＡＸ１ = new is2AdminClient.共通テキストボックス();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tex申込者電話２ = new is2AdminClient.共通テキストボックス();
			this.tex申込者電話３ = new is2AdminClient.共通テキストボックス();
			this.tex申込者電話１ = new is2AdminClient.共通テキストボックス();
			this.cb申込者県 = new System.Windows.Forms.ComboBox();
			this.lab申込者ＦＡＸ = new System.Windows.Forms.Label();
			this.lab申込者電話 = new System.Windows.Forms.Label();
			this.lab申込者郵便 = new System.Windows.Forms.Label();
			this.tex申込者カナ = new is2AdminClient.共通テキストボックス();
			this.lab申込者カナ = new System.Windows.Forms.Label();
			this.lab申込者 = new System.Windows.Forms.Label();
			this.lab会員名 = new System.Windows.Forms.Label();
			this.lab申込者住所 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tex申込者郵便１ = new is2AdminClient.共通テキストボックス();
			this.tex申込者郵便２ = new is2AdminClient.共通テキストボックス();
			this.btn申込者郵便 = new System.Windows.Forms.Button();
			this.tex申込者住所１ = new is2AdminClient.共通テキストボックス();
			this.tex申込者住所２ = new is2AdminClient.共通テキストボックス();
			this.label3 = new System.Windows.Forms.Label();
			this.pnl受付ＮＯ = new System.Windows.Forms.Panel();
			this.btn申込情報検索 = new System.Windows.Forms.Button();
			this.btn申込情報実行 = new System.Windows.Forms.Button();
			this.lab申込管理NO = new System.Windows.Forms.Label();
			this.tex受付ＮＯ = new is2AdminClient.共通テキストボックス();
			this.lab申請中 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.lab認証会員名 = new System.Windows.Forms.Label();
			this.tex認証利用者名 = new is2AdminClient.共通テキストボックス();
			this.lab認証利用者名 = new System.Windows.Forms.Label();
			this.tex認証会員名 = new is2AdminClient.共通テキストボックス();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab日時 = new System.Windows.Forms.Label();
			this.lab会員加入タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btn契約書 = new System.Windows.Forms.Button();
			this.texメッセージ = new is2AdminClient.共通テキストボックス();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.btn登録 = new System.Windows.Forms.Button();
			this.btn削除 = new System.Windows.Forms.Button();
			this.btn取消 = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pnlシステム情報 = new System.Windows.Forms.Panel();
			this.rb承認済 = new System.Windows.Forms.RadioButton();
			this.lab使用開始日 = new System.Windows.Forms.Label();
			this.rb登録中 = new System.Windows.Forms.RadioButton();
			this.label48 = new System.Windows.Forms.Label();
			this.label47 = new System.Windows.Forms.Label();
			this.label46 = new System.Windows.Forms.Label();
			this.lab初期パスワード = new System.Windows.Forms.Label();
			this.lab米_初期パスワード = new System.Windows.Forms.Label();
			this.lab台 = new System.Windows.Forms.Label();
			this.numサーマル台数 = new System.Windows.Forms.NumericUpDown();
			this.labサーマル = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.lab説明_初期パスワード = new System.Windows.Forms.Label();
			this.label39 = new System.Windows.Forms.Label();
			this.label38 = new System.Windows.Forms.Label();
			this.label37 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.rb留保中 = new System.Windows.Forms.RadioButton();
			this.rb申請中 = new System.Windows.Forms.RadioButton();
			this.label32 = new System.Windows.Forms.Label();
			this.texユーザー名 = new is2AdminClient.共通テキストボックス();
			this.lab利用者名 = new System.Windows.Forms.Label();
			this.tex初期パスワード = new is2AdminClient.共通テキストボックス();
			this.dtp使用開始日 = new System.Windows.Forms.DateTimePicker();
			this.tex部門名 = new is2AdminClient.共通テキストボックス();
			this.lab部門名 = new System.Windows.Forms.Label();
			this.tex部門コード = new is2AdminClient.共通テキストボックス();
			this.lab部門コード = new System.Windows.Forms.Label();
			this.texお客様コード = new is2AdminClient.共通テキストボックス();
			this.label7 = new System.Windows.Forms.Label();
			this.lab簡易ユーザー = new System.Windows.Forms.Label();
			this.texユーザーコード = new is2AdminClient.共通テキストボックス();
			this.label8 = new System.Windows.Forms.Label();
			this.btnお客様コード = new System.Windows.Forms.Button();
			this.label28 = new System.Windows.Forms.Label();
			this.texメモ = new is2AdminClient.共通テキストボックス();
			this.label42 = new System.Windows.Forms.Label();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.pnl設置場所 = new System.Windows.Forms.Panel();
			this.label21 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label49 = new System.Windows.Forms.Label();
			this.tex設置場所使用料 = new is2AdminClient.共通テキストボックス();
			this.label34 = new System.Windows.Forms.Label();
			this.tex管理店所名 = new is2AdminClient.共通テキストボックス();
			this.lab管理店所 = new System.Windows.Forms.Label();
			this.tex設置場所役職名 = new is2AdminClient.共通テキストボックス();
			this.label30 = new System.Windows.Forms.Label();
			this.tex設置場所担当者名 = new is2AdminClient.共通テキストボックス();
			this.label29 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.chb設置場所 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.tex設置場所ＦＡＸ２ = new is2AdminClient.共通テキストボックス();
			this.tex設置場所ＦＡＸ３ = new is2AdminClient.共通テキストボックス();
			this.tex設置場所ＦＡＸ１ = new is2AdminClient.共通テキストボックス();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.tex設置場所電話２ = new is2AdminClient.共通テキストボックス();
			this.tex設置場所電話３ = new is2AdminClient.共通テキストボックス();
			this.tex設置場所電話１ = new is2AdminClient.共通テキストボックス();
			this.cb設置場所県 = new System.Windows.Forms.ComboBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.tex設置場所カナ = new is2AdminClient.共通テキストボックス();
			this.lab設置場所カナ = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.lab設置場所 = new System.Windows.Forms.Label();
			this.tex設置場所名 = new is2AdminClient.共通テキストボックス();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.tex設置場所郵便１ = new is2AdminClient.共通テキストボックス();
			this.tex設置場所郵便２ = new is2AdminClient.共通テキストボックス();
			this.btn設置場所郵便 = new System.Windows.Forms.Button();
			this.tex設置場所住所１ = new is2AdminClient.共通テキストボックス();
			this.tex設置場所住所２ = new is2AdminClient.共通テキストボックス();
			this.label31 = new System.Windows.Forms.Label();
			this.btn支店情報登録 = new System.Windows.Forms.Button();
			this.pnl申込者.SuspendLayout();
			this.pnl受付ＮＯ.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.pnlシステム情報.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numサーマル台数)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.pnl設置場所.SuspendLayout();
			this.SuspendLayout();
			// 
			// tex申込者名
			// 
			this.tex申込者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex申込者名.Location = new System.Drawing.Point(98, 4);
			this.tex申込者名.MaxLength = 20;
			this.tex申込者名.Name = "tex申込者名";
			this.tex申込者名.Size = new System.Drawing.Size(326, 23);
			this.tex申込者名.TabIndex = 0;
			this.tex申込者名.Text = "";
			// 
			// pnl申込者
			// 
			this.pnl申込者.BackColor = System.Drawing.Color.Honeydew;
			this.pnl申込者.Controls.Add(this.label24);
			this.pnl申込者.Controls.Add(this.label13);
			this.pnl申込者.Controls.Add(this.label14);
			this.pnl申込者.Controls.Add(this.label15);
			this.pnl申込者.Controls.Add(this.tex申込者ＦＡＸ２);
			this.pnl申込者.Controls.Add(this.tex申込者ＦＡＸ３);
			this.pnl申込者.Controls.Add(this.tex申込者ＦＡＸ１);
			this.pnl申込者.Controls.Add(this.label4);
			this.pnl申込者.Controls.Add(this.label9);
			this.pnl申込者.Controls.Add(this.label12);
			this.pnl申込者.Controls.Add(this.tex申込者電話２);
			this.pnl申込者.Controls.Add(this.tex申込者電話３);
			this.pnl申込者.Controls.Add(this.tex申込者電話１);
			this.pnl申込者.Controls.Add(this.cb申込者県);
			this.pnl申込者.Controls.Add(this.lab申込者ＦＡＸ);
			this.pnl申込者.Controls.Add(this.lab申込者電話);
			this.pnl申込者.Controls.Add(this.lab申込者郵便);
			this.pnl申込者.Controls.Add(this.tex申込者カナ);
			this.pnl申込者.Controls.Add(this.lab申込者カナ);
			this.pnl申込者.Controls.Add(this.lab申込者);
			this.pnl申込者.Controls.Add(this.tex申込者名);
			this.pnl申込者.Controls.Add(this.lab会員名);
			this.pnl申込者.Controls.Add(this.lab申込者住所);
			this.pnl申込者.Controls.Add(this.label1);
			this.pnl申込者.Controls.Add(this.tex申込者郵便１);
			this.pnl申込者.Controls.Add(this.tex申込者郵便２);
			this.pnl申込者.Controls.Add(this.btn申込者郵便);
			this.pnl申込者.Controls.Add(this.tex申込者住所１);
			this.pnl申込者.Controls.Add(this.tex申込者住所２);
			this.pnl申込者.Controls.Add(this.label3);
			this.pnl申込者.Location = new System.Drawing.Point(1, 6);
			this.pnl申込者.Name = "pnl申込者";
			this.pnl申込者.Size = new System.Drawing.Size(449, 176);
			this.pnl申込者.TabIndex = 0;
			// 
			// label24
			// 
			this.label24.BackColor = System.Drawing.Color.Honeydew;
			this.label24.ForeColor = System.Drawing.Color.Red;
			this.label24.Location = new System.Drawing.Point(44, 130);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(16, 14);
			this.label24.TabIndex = 97;
			this.label24.Text = "※";
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label13.ForeColor = System.Drawing.Color.LimeGreen;
			this.label13.Location = new System.Drawing.Point(88, 154);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(10, 14);
			this.label13.TabIndex = 94;
			this.label13.Text = "（";
			this.label13.Visible = false;
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label14.ForeColor = System.Drawing.Color.LimeGreen;
			this.label14.Location = new System.Drawing.Point(154, 154);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(12, 14);
			this.label14.TabIndex = 95;
			this.label14.Text = "）";
			this.label14.Visible = false;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label15.ForeColor = System.Drawing.Color.LimeGreen;
			this.label15.Location = new System.Drawing.Point(210, 154);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(12, 14);
			this.label15.TabIndex = 96;
			this.label15.Text = "－";
			this.label15.Visible = false;
			// 
			// tex申込者ＦＡＸ２
			// 
			this.tex申込者ＦＡＸ２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者ＦＡＸ２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex申込者ＦＡＸ２.Location = new System.Drawing.Point(170, 148);
			this.tex申込者ＦＡＸ２.MaxLength = 4;
			this.tex申込者ＦＡＸ２.Name = "tex申込者ＦＡＸ２";
			this.tex申込者ＦＡＸ２.Size = new System.Drawing.Size(40, 23);
			this.tex申込者ＦＡＸ２.TabIndex = 12;
			this.tex申込者ＦＡＸ２.Text = "";
			this.tex申込者ＦＡＸ２.Visible = false;
			// 
			// tex申込者ＦＡＸ３
			// 
			this.tex申込者ＦＡＸ３.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者ＦＡＸ３.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex申込者ＦＡＸ３.Location = new System.Drawing.Point(224, 148);
			this.tex申込者ＦＡＸ３.MaxLength = 4;
			this.tex申込者ＦＡＸ３.Name = "tex申込者ＦＡＸ３";
			this.tex申込者ＦＡＸ３.Size = new System.Drawing.Size(40, 23);
			this.tex申込者ＦＡＸ３.TabIndex = 13;
			this.tex申込者ＦＡＸ３.Text = "";
			this.tex申込者ＦＡＸ３.Visible = false;
			// 
			// tex申込者ＦＡＸ１
			// 
			this.tex申込者ＦＡＸ１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者ＦＡＸ１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex申込者ＦＡＸ１.Location = new System.Drawing.Point(98, 148);
			this.tex申込者ＦＡＸ１.MaxLength = 6;
			this.tex申込者ＦＡＸ１.Name = "tex申込者ＦＡＸ１";
			this.tex申込者ＦＡＸ１.Size = new System.Drawing.Size(56, 23);
			this.tex申込者ＦＡＸ１.TabIndex = 11;
			this.tex申込者ＦＡＸ１.Text = "";
			this.tex申込者ＦＡＸ１.Visible = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.LimeGreen;
			this.label4.Location = new System.Drawing.Point(88, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 14);
			this.label4.TabIndex = 88;
			this.label4.Text = "（";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label9.ForeColor = System.Drawing.Color.LimeGreen;
			this.label9.Location = new System.Drawing.Point(154, 130);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 14);
			this.label9.TabIndex = 89;
			this.label9.Text = "）";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label12.ForeColor = System.Drawing.Color.LimeGreen;
			this.label12.Location = new System.Drawing.Point(210, 130);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 14);
			this.label12.TabIndex = 90;
			this.label12.Text = "－";
			// 
			// tex申込者電話２
			// 
			this.tex申込者電話２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者電話２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex申込者電話２.Location = new System.Drawing.Point(170, 124);
			this.tex申込者電話２.MaxLength = 4;
			this.tex申込者電話２.Name = "tex申込者電話２";
			this.tex申込者電話２.Size = new System.Drawing.Size(40, 23);
			this.tex申込者電話２.TabIndex = 9;
			this.tex申込者電話２.Text = "";
			// 
			// tex申込者電話３
			// 
			this.tex申込者電話３.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者電話３.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex申込者電話３.Location = new System.Drawing.Point(224, 124);
			this.tex申込者電話３.MaxLength = 4;
			this.tex申込者電話３.Name = "tex申込者電話３";
			this.tex申込者電話３.Size = new System.Drawing.Size(40, 23);
			this.tex申込者電話３.TabIndex = 10;
			this.tex申込者電話３.Text = "";
			// 
			// tex申込者電話１
			// 
			this.tex申込者電話１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者電話１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex申込者電話１.Location = new System.Drawing.Point(98, 124);
			this.tex申込者電話１.MaxLength = 6;
			this.tex申込者電話１.Name = "tex申込者電話１";
			this.tex申込者電話１.Size = new System.Drawing.Size(56, 23);
			this.tex申込者電話１.TabIndex = 8;
			this.tex申込者電話１.Text = "";
			// 
			// cb申込者県
			// 
			this.cb申込者県.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cb申込者県.Location = new System.Drawing.Point(98, 76);
			this.cb申込者県.Name = "cb申込者県";
			this.cb申込者県.Size = new System.Drawing.Size(90, 24);
			this.cb申込者県.TabIndex = 5;
			// 
			// lab申込者ＦＡＸ
			// 
			this.lab申込者ＦＡＸ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab申込者ＦＡＸ.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab申込者ＦＡＸ.Location = new System.Drawing.Point(58, 154);
			this.lab申込者ＦＡＸ.Name = "lab申込者ＦＡＸ";
			this.lab申込者ＦＡＸ.Size = new System.Drawing.Size(30, 14);
			this.lab申込者ＦＡＸ.TabIndex = 83;
			this.lab申込者ＦＡＸ.Text = "ＦＡＸ";
			this.lab申込者ＦＡＸ.Visible = false;
			// 
			// lab申込者電話
			// 
			this.lab申込者電話.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab申込者電話.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab申込者電話.Location = new System.Drawing.Point(58, 130);
			this.lab申込者電話.Name = "lab申込者電話";
			this.lab申込者電話.Size = new System.Drawing.Size(30, 14);
			this.lab申込者電話.TabIndex = 82;
			this.lab申込者電話.Text = "ＴＥＬ";
			// 
			// lab申込者郵便
			// 
			this.lab申込者郵便.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab申込者郵便.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab申込者郵便.Location = new System.Drawing.Point(82, 58);
			this.lab申込者郵便.Name = "lab申込者郵便";
			this.lab申込者郵便.Size = new System.Drawing.Size(14, 14);
			this.lab申込者郵便.TabIndex = 81;
			this.lab申込者郵便.Text = "〒";
			// 
			// tex申込者カナ
			// 
			this.tex申込者カナ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者カナ.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex申込者カナ.Location = new System.Drawing.Point(98, 28);
			this.tex申込者カナ.MaxLength = 20;
			this.tex申込者カナ.Name = "tex申込者カナ";
			this.tex申込者カナ.Size = new System.Drawing.Size(326, 23);
			this.tex申込者カナ.TabIndex = 1;
			this.tex申込者カナ.Text = "";
			// 
			// lab申込者カナ
			// 
			this.lab申込者カナ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab申込者カナ.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab申込者カナ.Location = new System.Drawing.Point(58, 34);
			this.lab申込者カナ.Name = "lab申込者カナ";
			this.lab申込者カナ.Size = new System.Drawing.Size(40, 14);
			this.lab申込者カナ.TabIndex = 59;
			this.lab申込者カナ.Text = "フリガナ";
			// 
			// lab申込者
			// 
			this.lab申込者.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab申込者.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab申込者.ForeColor = System.Drawing.Color.Blue;
			this.lab申込者.Location = new System.Drawing.Point(0, 0);
			this.lab申込者.Name = "lab申込者";
			this.lab申込者.Size = new System.Drawing.Size(22, 176);
			this.lab申込者.TabIndex = 44;
			this.lab申込者.Text = "お申込者／お客様";
			this.lab申込者.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab会員名
			// 
			this.lab会員名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab会員名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab会員名.Location = new System.Drawing.Point(36, 10);
			this.lab会員名.Name = "lab会員名";
			this.lab会員名.Size = new System.Drawing.Size(64, 14);
			this.lab会員名.TabIndex = 9;
			this.lab会員名.Text = "お申込者名";
			// 
			// lab申込者住所
			// 
			this.lab申込者住所.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab申込者住所.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab申込者住所.Location = new System.Drawing.Point(58, 82);
			this.lab申込者住所.Name = "lab申込者住所";
			this.lab申込者住所.Size = new System.Drawing.Size(40, 14);
			this.lab申込者住所.TabIndex = 77;
			this.lab申込者住所.Text = "ご住所";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.Location = new System.Drawing.Point(134, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 14);
			this.label1.TabIndex = 80;
			this.label1.Text = "－";
			// 
			// tex申込者郵便１
			// 
			this.tex申込者郵便１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者郵便１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex申込者郵便１.Location = new System.Drawing.Point(98, 52);
			this.tex申込者郵便１.MaxLength = 3;
			this.tex申込者郵便１.Name = "tex申込者郵便１";
			this.tex申込者郵便１.Size = new System.Drawing.Size(34, 23);
			this.tex申込者郵便１.TabIndex = 2;
			this.tex申込者郵便１.Text = "";
			// 
			// tex申込者郵便２
			// 
			this.tex申込者郵便２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者郵便２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex申込者郵便２.Location = new System.Drawing.Point(154, 52);
			this.tex申込者郵便２.MaxLength = 4;
			this.tex申込者郵便２.Name = "tex申込者郵便２";
			this.tex申込者郵便２.Size = new System.Drawing.Size(42, 23);
			this.tex申込者郵便２.TabIndex = 3;
			this.tex申込者郵便２.Text = "";
			this.tex申込者郵便２.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex申込者郵便２_KeyDown);
			this.tex申込者郵便２.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex申込者郵便２_KeyPress);
			// 
			// btn申込者郵便
			// 
			this.btn申込者郵便.BackColor = System.Drawing.Color.SteelBlue;
			this.btn申込者郵便.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn申込者郵便.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn申込者郵便.ForeColor = System.Drawing.Color.White;
			this.btn申込者郵便.Location = new System.Drawing.Point(204, 52);
			this.btn申込者郵便.Name = "btn申込者郵便";
			this.btn申込者郵便.Size = new System.Drawing.Size(48, 22);
			this.btn申込者郵便.TabIndex = 4;
			this.btn申込者郵便.TabStop = false;
			this.btn申込者郵便.Text = "検索";
			this.btn申込者郵便.Click += new System.EventHandler(this.btn申込者郵便_Click);
			// 
			// tex申込者住所１
			// 
			this.tex申込者住所１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者住所１.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex申込者住所１.Location = new System.Drawing.Point(186, 76);
			this.tex申込者住所１.MaxLength = 16;
			this.tex申込者住所１.Name = "tex申込者住所１";
			this.tex申込者住所１.Size = new System.Drawing.Size(262, 23);
			this.tex申込者住所１.TabIndex = 6;
			this.tex申込者住所１.Text = "";
			// 
			// tex申込者住所２
			// 
			this.tex申込者住所２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex申込者住所２.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex申込者住所２.Location = new System.Drawing.Point(98, 100);
			this.tex申込者住所２.MaxLength = 20;
			this.tex申込者住所２.Name = "tex申込者住所２";
			this.tex申込者住所２.Size = new System.Drawing.Size(326, 23);
			this.tex申込者住所２.TabIndex = 7;
			this.tex申込者住所２.Text = "";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Honeydew;
			this.label3.ForeColor = System.Drawing.Color.Red;
			this.label3.Location = new System.Drawing.Point(24, 10);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 14);
			this.label3.TabIndex = 50;
			this.label3.Text = "※";
			// 
			// pnl受付ＮＯ
			// 
			this.pnl受付ＮＯ.BackColor = System.Drawing.Color.Honeydew;
			this.pnl受付ＮＯ.Controls.Add(this.btn申込情報検索);
			this.pnl受付ＮＯ.Controls.Add(this.btn申込情報実行);
			this.pnl受付ＮＯ.Controls.Add(this.lab申込管理NO);
			this.pnl受付ＮＯ.Controls.Add(this.tex受付ＮＯ);
			this.pnl受付ＮＯ.Controls.Add(this.lab申請中);
			this.pnl受付ＮＯ.Location = new System.Drawing.Point(1, 6);
			this.pnl受付ＮＯ.Name = "pnl受付ＮＯ";
			this.pnl受付ＮＯ.Size = new System.Drawing.Size(427, 32);
			this.pnl受付ＮＯ.TabIndex = 0;
			// 
			// btn申込情報検索
			// 
			this.btn申込情報検索.BackColor = System.Drawing.Color.Blue;
			this.btn申込情報検索.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn申込情報検索.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn申込情報検索.ForeColor = System.Drawing.Color.White;
			this.btn申込情報検索.Location = new System.Drawing.Point(148, 5);
			this.btn申込情報検索.Name = "btn申込情報検索";
			this.btn申込情報検索.Size = new System.Drawing.Size(46, 22);
			this.btn申込情報検索.TabIndex = 1;
			this.btn申込情報検索.TabStop = false;
			this.btn申込情報検索.Text = "選択";
			this.btn申込情報検索.Click += new System.EventHandler(this.btn申込情報検索_Click);
			// 
			// btn申込情報実行
			// 
			this.btn申込情報実行.BackColor = System.Drawing.Color.Blue;
			this.btn申込情報実行.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn申込情報実行.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn申込情報実行.ForeColor = System.Drawing.Color.White;
			this.btn申込情報実行.Location = new System.Drawing.Point(200, 5);
			this.btn申込情報実行.Name = "btn申込情報実行";
			this.btn申込情報実行.Size = new System.Drawing.Size(48, 22);
			this.btn申込情報実行.TabIndex = 2;
			this.btn申込情報実行.Text = "実行";
			this.btn申込情報実行.Click += new System.EventHandler(this.btn申込情報実行_Click);
			// 
			// lab申込管理NO
			// 
			this.lab申込管理NO.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab申込管理NO.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab申込管理NO.Location = new System.Drawing.Point(14, 8);
			this.lab申込管理NO.Name = "lab申込管理NO";
			this.lab申込管理NO.Size = new System.Drawing.Size(62, 16);
			this.lab申込管理NO.TabIndex = 6;
			this.lab申込管理NO.Text = "受付NO";
			// 
			// tex受付ＮＯ
			// 
			this.tex受付ＮＯ.BackColor = System.Drawing.SystemColors.Window;
			this.tex受付ＮＯ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex受付ＮＯ.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex受付ＮＯ.Location = new System.Drawing.Point(76, 4);
			this.tex受付ＮＯ.MaxLength = 7;
			this.tex受付ＮＯ.Name = "tex受付ＮＯ";
			this.tex受付ＮＯ.Size = new System.Drawing.Size(66, 23);
			this.tex受付ＮＯ.TabIndex = 0;
			this.tex受付ＮＯ.Text = "";
			this.tex受付ＮＯ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex受付ＮＯ_KeyDown);
			this.tex受付ＮＯ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex受付ＮＯ_KeyPress);
			// 
			// lab申請中
			// 
			this.lab申請中.Font = new System.Drawing.Font("MS UI Gothic", 12F);
			this.lab申請中.ForeColor = System.Drawing.Color.Black;
			this.lab申請中.Location = new System.Drawing.Point(256, 8);
			this.lab申請中.Name = "lab申請中";
			this.lab申請中.Size = new System.Drawing.Size(56, 18);
			this.lab申請中.TabIndex = 102;
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Controls.Add(this.lab認証会員名);
			this.panel6.Controls.Add(this.tex認証利用者名);
			this.panel6.Controls.Add(this.lab認証利用者名);
			this.panel6.Controls.Add(this.tex認証会員名);
			this.panel6.Location = new System.Drawing.Point(0, 26);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 12;
			// 
			// lab認証会員名
			// 
			this.lab認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab認証会員名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab認証会員名.Location = new System.Drawing.Point(14, 8);
			this.lab認証会員名.Name = "lab認証会員名";
			this.lab認証会員名.Size = new System.Drawing.Size(54, 14);
			this.lab認証会員名.TabIndex = 3;
			this.lab認証会員名.Text = "お客様名";
			// 
			// tex認証利用者名
			// 
			this.tex認証利用者名.BackColor = System.Drawing.Color.PaleGreen;
			this.tex認証利用者名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex認証利用者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex認証利用者名.ForeColor = System.Drawing.Color.Green;
			this.tex認証利用者名.Location = new System.Drawing.Point(470, 5);
			this.tex認証利用者名.Name = "tex認証利用者名";
			this.tex認証利用者名.ReadOnly = true;
			this.tex認証利用者名.Size = new System.Drawing.Size(322, 16);
			this.tex認証利用者名.TabIndex = 2;
			this.tex認証利用者名.TabStop = false;
			this.tex認証利用者名.Text = "国国国国国国国国国国王王王王王王王王王王";
			this.tex認証利用者名.Visible = false;
			// 
			// lab認証利用者名
			// 
			this.lab認証利用者名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab認証利用者名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab認証利用者名.Location = new System.Drawing.Point(418, 7);
			this.lab認証利用者名.Name = "lab認証利用者名";
			this.lab認証利用者名.Size = new System.Drawing.Size(54, 14);
			this.lab認証利用者名.TabIndex = 1;
			this.lab認証利用者名.Text = "ユーザー";
			this.lab認証利用者名.Visible = false;
			// 
			// tex認証会員名
			// 
			this.tex認証会員名.BackColor = System.Drawing.Color.PaleGreen;
			this.tex認証会員名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex認証会員名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex認証会員名.ForeColor = System.Drawing.Color.Green;
			this.tex認証会員名.Location = new System.Drawing.Point(72, 5);
			this.tex認証会員名.Name = "tex認証会員名";
			this.tex認証会員名.ReadOnly = true;
			this.tex認証会員名.Size = new System.Drawing.Size(330, 16);
			this.tex認証会員名.TabIndex = 0;
			this.tex認証会員名.TabStop = false;
			this.tex認証会員名.Text = "999 ○○支店";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab日時);
			this.panel7.Controls.Add(this.lab会員加入タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(794, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab日時
			// 
			this.lab日時.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab日時.ForeColor = System.Drawing.Color.White;
			this.lab日時.Location = new System.Drawing.Point(674, 8);
			this.lab日時.Name = "lab日時";
			this.lab日時.Size = new System.Drawing.Size(112, 14);
			this.lab日時.TabIndex = 1;
			this.lab日時.Text = "2005/xx/xx 12:00:00";
			// 
			// lab会員加入タイトル
			// 
			this.lab会員加入タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab会員加入タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab会員加入タイトル.ForeColor = System.Drawing.Color.White;
			this.lab会員加入タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab会員加入タイトル.Name = "lab会員加入タイトル";
			this.lab会員加入タイトル.Size = new System.Drawing.Size(264, 24);
			this.lab会員加入タイトル.TabIndex = 0;
			this.lab会員加入タイトル.Text = "使用申し込みメンテナンス";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btn契約書);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Controls.Add(this.btn登録);
			this.panel8.Controls.Add(this.btn削除);
			this.panel8.Controls.Add(this.btn取消);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(794, 58);
			this.panel8.TabIndex = 0;
			// 
			// btn契約書
			// 
			this.btn契約書.BackColor = System.Drawing.Color.PaleGreen;
			this.btn契約書.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn契約書.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn契約書.Location = new System.Drawing.Point(290, 6);
			this.btn契約書.Name = "btn契約書";
			this.btn契約書.Size = new System.Drawing.Size(54, 48);
			this.btn契約書.TabIndex = 3;
			this.btn契約書.Text = "印刷";
			this.btn契約書.Click += new System.EventHandler(this.btn契約書_Click);
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(414, 4);
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
			// btn登録
			// 
			this.btn登録.BackColor = System.Drawing.Color.PaleGreen;
			this.btn登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn登録.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn登録.Location = new System.Drawing.Point(104, 6);
			this.btn登録.Name = "btn登録";
			this.btn登録.Size = new System.Drawing.Size(54, 48);
			this.btn登録.TabIndex = 0;
			this.btn登録.Text = "登録";
			this.btn登録.Click += new System.EventHandler(this.btn登録_Click);
			// 
			// btn削除
			// 
			this.btn削除.BackColor = System.Drawing.Color.PaleGreen;
			this.btn削除.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn削除.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn削除.Location = new System.Drawing.Point(228, 6);
			this.btn削除.Name = "btn削除";
			this.btn削除.Size = new System.Drawing.Size(54, 48);
			this.btn削除.TabIndex = 2;
			this.btn削除.Text = "削除";
			this.btn削除.Click += new System.EventHandler(this.btn削除_Click);
			// 
			// btn取消
			// 
			this.btn取消.BackColor = System.Drawing.Color.PaleGreen;
			this.btn取消.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn取消.ForeColor = System.Drawing.SystemColors.WindowText;
			this.btn取消.Location = new System.Drawing.Point(166, 6);
			this.btn取消.Name = "btn取消";
			this.btn取消.Size = new System.Drawing.Size(54, 48);
			this.btn取消.TabIndex = 1;
			this.btn取消.Text = "取消";
			this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
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
			// pnlシステム情報
			// 
			this.pnlシステム情報.BackColor = System.Drawing.Color.Honeydew;
			this.pnlシステム情報.Controls.Add(this.rb承認済);
			this.pnlシステム情報.Controls.Add(this.lab使用開始日);
			this.pnlシステム情報.Controls.Add(this.rb登録中);
			this.pnlシステム情報.Controls.Add(this.label48);
			this.pnlシステム情報.Controls.Add(this.label47);
			this.pnlシステム情報.Controls.Add(this.label46);
			this.pnlシステム情報.Controls.Add(this.lab初期パスワード);
			this.pnlシステム情報.Controls.Add(this.lab米_初期パスワード);
			this.pnlシステム情報.Controls.Add(this.lab台);
			this.pnlシステム情報.Controls.Add(this.numサーマル台数);
			this.pnlシステム情報.Controls.Add(this.labサーマル);
			this.pnlシステム情報.Controls.Add(this.label41);
			this.pnlシステム情報.Controls.Add(this.lab説明_初期パスワード);
			this.pnlシステム情報.Controls.Add(this.label39);
			this.pnlシステム情報.Controls.Add(this.label38);
			this.pnlシステム情報.Controls.Add(this.label37);
			this.pnlシステム情報.Controls.Add(this.label36);
			this.pnlシステム情報.Controls.Add(this.label35);
			this.pnlシステム情報.Controls.Add(this.rb留保中);
			this.pnlシステム情報.Controls.Add(this.rb申請中);
			this.pnlシステム情報.Controls.Add(this.label32);
			this.pnlシステム情報.Controls.Add(this.texユーザー名);
			this.pnlシステム情報.Controls.Add(this.lab利用者名);
			this.pnlシステム情報.Controls.Add(this.tex初期パスワード);
			this.pnlシステム情報.Controls.Add(this.dtp使用開始日);
			this.pnlシステム情報.Controls.Add(this.tex部門名);
			this.pnlシステム情報.Controls.Add(this.lab部門名);
			this.pnlシステム情報.Controls.Add(this.tex部門コード);
			this.pnlシステム情報.Controls.Add(this.lab部門コード);
			this.pnlシステム情報.Controls.Add(this.texお客様コード);
			this.pnlシステム情報.Controls.Add(this.label7);
			this.pnlシステム情報.Controls.Add(this.lab簡易ユーザー);
			this.pnlシステム情報.Controls.Add(this.texユーザーコード);
			this.pnlシステム情報.Controls.Add(this.label8);
			this.pnlシステム情報.Controls.Add(this.btnお客様コード);
			this.pnlシステム情報.Controls.Add(this.label28);
			this.pnlシステム情報.Controls.Add(this.texメモ);
			this.pnlシステム情報.Controls.Add(this.label42);
			this.pnlシステム情報.Controls.Add(this.label43);
			this.pnlシステム情報.Controls.Add(this.label44);
			this.pnlシステム情報.Location = new System.Drawing.Point(1, 6);
			this.pnlシステム情報.Name = "pnlシステム情報";
			this.pnlシステム情報.Size = new System.Drawing.Size(327, 414);
			this.pnlシステム情報.TabIndex = 0;
			// 
			// rb承認済
			// 
			this.rb承認済.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb承認済.Location = new System.Drawing.Point(114, 324);
			this.rb承認済.Name = "rb承認済";
			this.rb承認済.Size = new System.Drawing.Size(64, 18);
			this.rb承認済.TabIndex = 12;
			this.rb承認済.Text = "承認済";
			// 
			// lab使用開始日
			// 
			this.lab使用開始日.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab使用開始日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab使用開始日.Location = new System.Drawing.Point(46, 54);
			this.lab使用開始日.Name = "lab使用開始日";
			this.lab使用開始日.Size = new System.Drawing.Size(66, 14);
			this.lab使用開始日.TabIndex = 86;
			this.lab使用開始日.Text = "使用開始日";
			// 
			// rb登録中
			// 
			this.rb登録中.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb登録中.Location = new System.Drawing.Point(114, 324);
			this.rb登録中.Name = "rb登録中";
			this.rb登録中.Size = new System.Drawing.Size(64, 18);
			this.rb登録中.TabIndex = 9;
			this.rb登録中.Text = "登録中";
			this.rb登録中.Visible = false;
			// 
			// label48
			// 
			this.label48.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label48.ForeColor = System.Drawing.Color.DarkGreen;
			this.label48.Location = new System.Drawing.Point(110, 220);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(176, 14);
			this.label48.TabIndex = 125;
			this.label48.Text = "（省略時：お客様コード 下4桁）";
			// 
			// label47
			// 
			this.label47.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label47.ForeColor = System.Drawing.Color.DarkGreen;
			this.label47.Location = new System.Drawing.Point(110, 70);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(176, 14);
			this.label47.TabIndex = 124;
			this.label47.Text = "（省略時：本日日付）";
			// 
			// label46
			// 
			this.label46.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label46.ForeColor = System.Drawing.Color.Red;
			this.label46.Location = new System.Drawing.Point(32, 54);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(18, 14);
			this.label46.TabIndex = 123;
			this.label46.Text = "※";
			// 
			// lab初期パスワード
			// 
			this.lab初期パスワード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab初期パスワード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab初期パスワード.Location = new System.Drawing.Point(36, 286);
			this.lab初期パスワード.Name = "lab初期パスワード";
			this.lab初期パスワード.Size = new System.Drawing.Size(78, 14);
			this.lab初期パスワード.TabIndex = 89;
			this.lab初期パスワード.Text = "初期パスワード";
			// 
			// lab米_初期パスワード
			// 
			this.lab米_初期パスワード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab米_初期パスワード.ForeColor = System.Drawing.Color.Red;
			this.lab米_初期パスワード.Location = new System.Drawing.Point(22, 286);
			this.lab米_初期パスワード.Name = "lab米_初期パスワード";
			this.lab米_初期パスワード.Size = new System.Drawing.Size(18, 14);
			this.lab米_初期パスワード.TabIndex = 122;
			this.lab米_初期パスワード.Text = "※";
			this.lab米_初期パスワード.Visible = false;
			// 
			// lab台
			// 
			this.lab台.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab台.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab台.Location = new System.Drawing.Point(156, 174);
			this.lab台.Name = "lab台";
			this.lab台.Size = new System.Drawing.Size(18, 14);
			this.lab台.TabIndex = 118;
			this.lab台.Text = "台";
			// 
			// numサーマル台数
			// 
			this.numサーマル台数.Location = new System.Drawing.Point(112, 170);
			this.numサーマル台数.Maximum = new System.Decimal(new int[] {
																	  99,
																	  0,
																	  0,
																	  0});
			this.numサーマル台数.Name = "numサーマル台数";
			this.numサーマル台数.Size = new System.Drawing.Size(42, 19);
			this.numサーマル台数.TabIndex = 4;
			this.numサーマル台数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numサーマル台数.Value = new System.Decimal(new int[] {
																	1,
																	0,
																	0,
																	0});
			// 
			// labサーマル
			// 
			this.labサーマル.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labサーマル.ForeColor = System.Drawing.Color.LimeGreen;
			this.labサーマル.Location = new System.Drawing.Point(68, 174);
			this.labサーマル.Name = "labサーマル";
			this.labサーマル.Size = new System.Drawing.Size(44, 14);
			this.labサーマル.TabIndex = 117;
			this.labサーマル.Text = "サーマル";
			// 
			// label41
			// 
			this.label41.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label41.ForeColor = System.Drawing.Color.OrangeRed;
			this.label41.Location = new System.Drawing.Point(110, 344);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(196, 14);
			this.label41.TabIndex = 115;
			this.label41.Text = "（承認済で保存後、全項目編集不可）";
			// 
			// lab説明_初期パスワード
			// 
			this.lab説明_初期パスワード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab説明_初期パスワード.ForeColor = System.Drawing.Color.DarkGreen;
			this.lab説明_初期パスワード.Location = new System.Drawing.Point(110, 304);
			this.lab説明_初期パスワード.Name = "lab説明_初期パスワード";
			this.lab説明_初期パスワード.Size = new System.Drawing.Size(176, 14);
			this.lab説明_初期パスワード.TabIndex = 114;
			this.lab説明_初期パスワード.Text = "（省略時：自動発行）";
			this.lab説明_初期パスワード.Visible = false;
			// 
			// label39
			// 
			this.label39.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label39.ForeColor = System.Drawing.Color.DarkGreen;
			this.label39.Location = new System.Drawing.Point(110, 262);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(176, 14);
			this.label39.TabIndex = 113;
			this.label39.Text = "（省略時：設置場所 ご法人名）";
			// 
			// label38
			// 
			this.label38.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label38.ForeColor = System.Drawing.Color.DarkGreen;
			this.label38.Location = new System.Drawing.Point(110, 154);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(176, 14);
			this.label38.TabIndex = 112;
			this.label38.Text = "（省略時：設置場所 ご法人名）";
			// 
			// label37
			// 
			this.label37.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label37.ForeColor = System.Drawing.Color.DarkGreen;
			this.label37.Location = new System.Drawing.Point(110, 112);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(176, 14);
			this.label37.TabIndex = 111;
			this.label37.Text = "（省略時：設置場所 ＴＥＬ下12桁）";
			// 
			// label36
			// 
			this.label36.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label36.ForeColor = System.Drawing.Color.DarkGreen;
			this.label36.Location = new System.Drawing.Point(110, 32);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(176, 14);
			this.label36.TabIndex = 110;
			this.label36.Text = "（省略時：お申込者 ＴＥＬ下10桁）";
			// 
			// label35
			// 
			this.label35.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label35.ForeColor = System.Drawing.Color.LimeGreen;
			this.label35.Location = new System.Drawing.Point(90, 368);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(22, 14);
			this.label35.TabIndex = 109;
			this.label35.Text = "メモ";
			// 
			// rb留保中
			// 
			this.rb留保中.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb留保中.Location = new System.Drawing.Point(180, 324);
			this.rb留保中.Name = "rb留保中";
			this.rb留保中.Size = new System.Drawing.Size(64, 18);
			this.rb留保中.TabIndex = 11;
			this.rb留保中.Text = "留保中";
			// 
			// rb申請中
			// 
			this.rb申請中.Checked = true;
			this.rb申請中.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.rb申請中.Location = new System.Drawing.Point(180, 324);
			this.rb申請中.Name = "rb申請中";
			this.rb申請中.Size = new System.Drawing.Size(64, 18);
			this.rb申請中.TabIndex = 10;
			this.rb申請中.TabStop = true;
			this.rb申請中.Text = "申請中";
			this.rb申請中.Visible = false;
			// 
			// label32
			// 
			this.label32.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label32.ForeColor = System.Drawing.Color.LimeGreen;
			this.label32.Location = new System.Drawing.Point(58, 326);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(54, 14);
			this.label32.TabIndex = 101;
			this.label32.Text = "承認状態";
			// 
			// texユーザー名
			// 
			this.texユーザー名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texユーザー名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.texユーザー名.Location = new System.Drawing.Point(112, 238);
			this.texユーザー名.MaxLength = 20;
			this.texユーザー名.Name = "texユーザー名";
			this.texユーザー名.Size = new System.Drawing.Size(244, 23);
			this.texユーザー名.TabIndex = 6;
			this.texユーザー名.Text = "";
			// 
			// lab利用者名
			// 
			this.lab利用者名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab利用者名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab利用者名.Location = new System.Drawing.Point(54, 244);
			this.lab利用者名.Name = "lab利用者名";
			this.lab利用者名.Size = new System.Drawing.Size(58, 14);
			this.lab利用者名.TabIndex = 100;
			this.lab利用者名.Text = "ユーザー名";
			// 
			// tex初期パスワード
			// 
			this.tex初期パスワード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex初期パスワード.Location = new System.Drawing.Point(114, 280);
			this.tex初期パスワード.MaxLength = 40;
			this.tex初期パスワード.Name = "tex初期パスワード";
			this.tex初期パスワード.ReadOnly = true;
			this.tex初期パスワード.Size = new System.Drawing.Size(94, 23);
			this.tex初期パスワード.TabIndex = 7;
			this.tex初期パスワード.TabStop = false;
			this.tex初期パスワード.Text = "";
			// 
			// dtp使用開始日
			// 
			this.dtp使用開始日.Location = new System.Drawing.Point(112, 50);
			this.dtp使用開始日.Name = "dtp使用開始日";
			this.dtp使用開始日.Size = new System.Drawing.Size(108, 19);
			this.dtp使用開始日.TabIndex = 1;
			// 
			// tex部門名
			// 
			this.tex部門名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex部門名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex部門名.Location = new System.Drawing.Point(112, 130);
			this.tex部門名.MaxLength = 20;
			this.tex部門名.Name = "tex部門名";
			this.tex部門名.Size = new System.Drawing.Size(326, 23);
			this.tex部門名.TabIndex = 3;
			this.tex部門名.Text = "";
			// 
			// lab部門名
			// 
			this.lab部門名.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab部門名.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab部門名.Location = new System.Drawing.Point(50, 134);
			this.lab部門名.Name = "lab部門名";
			this.lab部門名.Size = new System.Drawing.Size(62, 14);
			this.lab部門名.TabIndex = 84;
			this.lab部門名.Text = "セクション名";
			// 
			// tex部門コード
			// 
			this.tex部門コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex部門コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex部門コード.Location = new System.Drawing.Point(112, 88);
			this.tex部門コード.MaxLength = 12;
			this.tex部門コード.Name = "tex部門コード";
			this.tex部門コード.Size = new System.Drawing.Size(110, 23);
			this.tex部門コード.TabIndex = 2;
			this.tex部門コード.Text = "";
			// 
			// lab部門コード
			// 
			this.lab部門コード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab部門コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab部門コード.Location = new System.Drawing.Point(38, 94);
			this.lab部門コード.Name = "lab部門コード";
			this.lab部門コード.Size = new System.Drawing.Size(76, 14);
			this.lab部門コード.TabIndex = 82;
			this.lab部門コード.Text = "セクションコード";
			// 
			// texお客様コード
			// 
			this.texお客様コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texお客様コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.texお客様コード.Location = new System.Drawing.Point(112, 8);
			this.texお客様コード.MaxLength = 10;
			this.texお客様コード.Name = "texお客様コード";
			this.texお客様コード.Size = new System.Drawing.Size(94, 23);
			this.texお客様コード.TabIndex = 0;
			this.texお客様コード.Text = "";
			this.texお客様コード.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texお客様コード_KeyDown);
			this.texお客様コード.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texお客様コード_KeyPress);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label7.ForeColor = System.Drawing.Color.LimeGreen;
			this.label7.Location = new System.Drawing.Point(44, 12);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(68, 14);
			this.label7.TabIndex = 77;
			this.label7.Text = "お客様コード";
			// 
			// lab簡易ユーザー
			// 
			this.lab簡易ユーザー.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab簡易ユーザー.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab簡易ユーザー.Location = new System.Drawing.Point(38, 202);
			this.lab簡易ユーザー.Name = "lab簡易ユーザー";
			this.lab簡易ユーザー.Size = new System.Drawing.Size(74, 14);
			this.lab簡易ユーザー.TabIndex = 76;
			this.lab簡易ユーザー.Text = "ユーザーコード";
			// 
			// texユーザーコード
			// 
			this.texユーザーコード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texユーザーコード.Location = new System.Drawing.Point(112, 196);
			this.texユーザーコード.MaxLength = 6;
			this.texユーザーコード.Name = "texユーザーコード";
			this.texユーザーコード.Size = new System.Drawing.Size(54, 23);
			this.texユーザーコード.TabIndex = 5;
			this.texユーザーコード.Text = "";
			// 
			// label8
			// 
			this.label8.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label8.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Blue;
			this.label8.Location = new System.Drawing.Point(0, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(22, 414);
			this.label8.TabIndex = 0;
			this.label8.Text = "システム情報";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnお客様コード
			// 
			this.btnお客様コード.BackColor = System.Drawing.Color.SteelBlue;
			this.btnお客様コード.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnお客様コード.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnお客様コード.ForeColor = System.Drawing.Color.White;
			this.btnお客様コード.Location = new System.Drawing.Point(208, 8);
			this.btnお客様コード.Name = "btnお客様コード";
			this.btnお客様コード.Size = new System.Drawing.Size(44, 22);
			this.btnお客様コード.TabIndex = 98;
			this.btnお客様コード.TabStop = false;
			this.btnお客様コード.Text = "検索";
			this.btnお客様コード.Click += new System.EventHandler(this.btnお客様コード_Click);
			// 
			// label28
			// 
			this.label28.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label28.ForeColor = System.Drawing.Color.Red;
			this.label28.Location = new System.Drawing.Point(24, 202);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(18, 14);
			this.label28.TabIndex = 33;
			this.label28.Text = "※";
			// 
			// texメモ
			// 
			this.texメモ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメモ.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.texメモ.Location = new System.Drawing.Point(112, 362);
			this.texメモ.MaxLength = 10;
			this.texメモ.Name = "texメモ";
			this.texメモ.Size = new System.Drawing.Size(168, 23);
			this.texメモ.TabIndex = 13;
			this.texメモ.Text = "";
			// 
			// label42
			// 
			this.label42.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label42.ForeColor = System.Drawing.Color.Red;
			this.label42.Location = new System.Drawing.Point(30, 12);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(18, 14);
			this.label42.TabIndex = 119;
			this.label42.Text = "※";
			// 
			// label43
			// 
			this.label43.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label43.ForeColor = System.Drawing.Color.Red;
			this.label43.Location = new System.Drawing.Point(26, 94);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(18, 14);
			this.label43.TabIndex = 120;
			this.label43.Text = "※";
			// 
			// label44
			// 
			this.label44.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label44.ForeColor = System.Drawing.Color.Red;
			this.label44.Location = new System.Drawing.Point(36, 134);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(18, 14);
			this.label44.TabIndex = 121;
			this.label44.Text = "※";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pnl受付ＮＯ);
			this.groupBox1.Location = new System.Drawing.Point(26, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(430, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.pnl申込者);
			this.groupBox2.Location = new System.Drawing.Point(4, 86);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(452, 184);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.pnlシステム情報);
			this.groupBox3.Location = new System.Drawing.Point(460, 86);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(330, 422);
			this.groupBox3.TabIndex = 3;
			this.groupBox3.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(472, 58);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(184, 14);
			this.label5.TabIndex = 31;
			this.label5.Text = "印がある項目は必須入力項目です。";
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label11.ForeColor = System.Drawing.Color.Red;
			this.label11.Location = new System.Drawing.Point(458, 58);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(18, 14);
			this.label11.TabIndex = 30;
			this.label11.Text = "※";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.pnl設置場所);
			this.groupBox4.Location = new System.Drawing.Point(4, 272);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(452, 236);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			// 
			// pnl設置場所
			// 
			this.pnl設置場所.BackColor = System.Drawing.Color.Honeydew;
			this.pnl設置場所.Controls.Add(this.label21);
			this.pnl設置場所.Controls.Add(this.label33);
			this.pnl設置場所.Controls.Add(this.label49);
			this.pnl設置場所.Controls.Add(this.tex設置場所使用料);
			this.pnl設置場所.Controls.Add(this.label34);
			this.pnl設置場所.Controls.Add(this.tex管理店所名);
			this.pnl設置場所.Controls.Add(this.lab管理店所);
			this.pnl設置場所.Controls.Add(this.tex設置場所役職名);
			this.pnl設置場所.Controls.Add(this.label30);
			this.pnl設置場所.Controls.Add(this.tex設置場所担当者名);
			this.pnl設置場所.Controls.Add(this.label29);
			this.pnl設置場所.Controls.Add(this.label22);
			this.pnl設置場所.Controls.Add(this.chb設置場所);
			this.pnl設置場所.Controls.Add(this.label2);
			this.pnl設置場所.Controls.Add(this.label6);
			this.pnl設置場所.Controls.Add(this.label10);
			this.pnl設置場所.Controls.Add(this.tex設置場所ＦＡＸ２);
			this.pnl設置場所.Controls.Add(this.tex設置場所ＦＡＸ３);
			this.pnl設置場所.Controls.Add(this.tex設置場所ＦＡＸ１);
			this.pnl設置場所.Controls.Add(this.label16);
			this.pnl設置場所.Controls.Add(this.label17);
			this.pnl設置場所.Controls.Add(this.label18);
			this.pnl設置場所.Controls.Add(this.tex設置場所電話２);
			this.pnl設置場所.Controls.Add(this.tex設置場所電話３);
			this.pnl設置場所.Controls.Add(this.tex設置場所電話１);
			this.pnl設置場所.Controls.Add(this.cb設置場所県);
			this.pnl設置場所.Controls.Add(this.label19);
			this.pnl設置場所.Controls.Add(this.label20);
			this.pnl設置場所.Controls.Add(this.tex設置場所カナ);
			this.pnl設置場所.Controls.Add(this.lab設置場所カナ);
			this.pnl設置場所.Controls.Add(this.label23);
			this.pnl設置場所.Controls.Add(this.lab設置場所);
			this.pnl設置場所.Controls.Add(this.tex設置場所名);
			this.pnl設置場所.Controls.Add(this.label25);
			this.pnl設置場所.Controls.Add(this.label26);
			this.pnl設置場所.Controls.Add(this.label27);
			this.pnl設置場所.Controls.Add(this.tex設置場所郵便１);
			this.pnl設置場所.Controls.Add(this.tex設置場所郵便２);
			this.pnl設置場所.Controls.Add(this.btn設置場所郵便);
			this.pnl設置場所.Controls.Add(this.tex設置場所住所１);
			this.pnl設置場所.Controls.Add(this.tex設置場所住所２);
			this.pnl設置場所.Controls.Add(this.label31);
			this.pnl設置場所.Location = new System.Drawing.Point(1, 6);
			this.pnl設置場所.Name = "pnl設置場所";
			this.pnl設置場所.Size = new System.Drawing.Size(449, 228);
			this.pnl設置場所.TabIndex = 0;
			// 
			// label21
			// 
			this.label21.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label21.ForeColor = System.Drawing.Color.LimeGreen;
			this.label21.Location = new System.Drawing.Point(82, 74);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(14, 14);
			this.label21.TabIndex = 2;
			this.label21.Text = "〒";
			// 
			// label33
			// 
			this.label33.BackColor = System.Drawing.Color.Honeydew;
			this.label33.ForeColor = System.Drawing.Color.Red;
			this.label33.Location = new System.Drawing.Point(68, 74);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(16, 14);
			this.label33.TabIndex = 109;
			this.label33.Text = "※";
			// 
			// label49
			// 
			this.label49.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label49.ForeColor = System.Drawing.Color.LimeGreen;
			this.label49.Location = new System.Drawing.Point(152, 170);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(16, 14);
			this.label49.TabIndex = 108;
			this.label49.Text = "円";
			// 
			// tex設置場所使用料
			// 
			this.tex設置場所使用料.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所使用料.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所使用料.Location = new System.Drawing.Point(98, 164);
			this.tex設置場所使用料.MaxLength = 6;
			this.tex設置場所使用料.Name = "tex設置場所使用料";
			this.tex設置場所使用料.Size = new System.Drawing.Size(54, 23);
			this.tex設置場所使用料.TabIndex = 15;
			this.tex設置場所使用料.Text = "";
			this.tex設置場所使用料.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label34
			// 
			this.label34.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label34.ForeColor = System.Drawing.Color.LimeGreen;
			this.label34.Location = new System.Drawing.Point(58, 170);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(42, 14);
			this.label34.TabIndex = 106;
			this.label34.Text = "使用料";
			// 
			// tex管理店所名
			// 
			this.tex管理店所名.BackColor = System.Drawing.Color.Honeydew;
			this.tex管理店所名.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tex管理店所名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex管理店所名.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex管理店所名.Location = new System.Drawing.Point(302, 72);
			this.tex管理店所名.MaxLength = 6;
			this.tex管理店所名.Name = "tex管理店所名";
			this.tex管理店所名.ReadOnly = true;
			this.tex管理店所名.Size = new System.Drawing.Size(122, 16);
			this.tex管理店所名.TabIndex = 104;
			this.tex管理店所名.TabStop = false;
			this.tex管理店所名.Text = "";
			// 
			// lab管理店所
			// 
			this.lab管理店所.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab管理店所.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab管理店所.Location = new System.Drawing.Point(258, 74);
			this.lab管理店所.Name = "lab管理店所";
			this.lab管理店所.Size = new System.Drawing.Size(44, 14);
			this.lab管理店所.TabIndex = 105;
			this.lab管理店所.Text = "出荷店";
			// 
			// tex設置場所役職名
			// 
			this.tex設置場所役職名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所役職名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex設置場所役職名.Location = new System.Drawing.Point(276, 188);
			this.tex設置場所役職名.MaxLength = 10;
			this.tex設置場所役職名.Name = "tex設置場所役職名";
			this.tex設置場所役職名.Size = new System.Drawing.Size(168, 23);
			this.tex設置場所役職名.TabIndex = 17;
			this.tex設置場所役職名.Text = "";
			this.tex設置場所役職名.Visible = false;
			// 
			// label30
			// 
			this.label30.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label30.ForeColor = System.Drawing.Color.LimeGreen;
			this.label30.Location = new System.Drawing.Point(270, 174);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(42, 14);
			this.label30.TabIndex = 102;
			this.label30.Text = "役職名";
			this.label30.Visible = false;
			// 
			// tex設置場所担当者名
			// 
			this.tex設置場所担当者名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所担当者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex設置場所担当者名.Location = new System.Drawing.Point(98, 188);
			this.tex設置場所担当者名.MaxLength = 10;
			this.tex設置場所担当者名.Name = "tex設置場所担当者名";
			this.tex設置場所担当者名.Size = new System.Drawing.Size(168, 23);
			this.tex設置場所担当者名.TabIndex = 16;
			this.tex設置場所担当者名.Text = "";
			// 
			// label29
			// 
			this.label29.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label29.ForeColor = System.Drawing.Color.LimeGreen;
			this.label29.Location = new System.Drawing.Point(36, 194);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(64, 14);
			this.label29.TabIndex = 100;
			this.label29.Text = "ご担当者名";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.Honeydew;
			this.label22.ForeColor = System.Drawing.Color.Red;
			this.label22.Location = new System.Drawing.Point(44, 146);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(16, 14);
			this.label22.TabIndex = 98;
			this.label22.Text = "※";
			// 
			// chb設置場所
			// 
			this.chb設置場所.ForeColor = System.Drawing.Color.LimeGreen;
			this.chb設置場所.Location = new System.Drawing.Point(98, 4);
			this.chb設置場所.Name = "chb設置場所";
			this.chb設置場所.Size = new System.Drawing.Size(100, 16);
			this.chb設置場所.TabIndex = 0;
			this.chb設置場所.Text = "お申込者と同じ";
			this.chb設置場所.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chb設置場所.CheckedChanged += new System.EventHandler(this.chb設置場所_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(88, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(10, 14);
			this.label2.TabIndex = 94;
			this.label2.Text = "（";
			this.label2.Visible = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label6.ForeColor = System.Drawing.Color.LimeGreen;
			this.label6.Location = new System.Drawing.Point(154, 170);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(12, 14);
			this.label6.TabIndex = 95;
			this.label6.Text = "）";
			this.label6.Visible = false;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label10.ForeColor = System.Drawing.Color.LimeGreen;
			this.label10.Location = new System.Drawing.Point(210, 170);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(12, 14);
			this.label10.TabIndex = 96;
			this.label10.Text = "－";
			this.label10.Visible = false;
			// 
			// tex設置場所ＦＡＸ２
			// 
			this.tex設置場所ＦＡＸ２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所ＦＡＸ２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所ＦＡＸ２.Location = new System.Drawing.Point(170, 164);
			this.tex設置場所ＦＡＸ２.MaxLength = 4;
			this.tex設置場所ＦＡＸ２.Name = "tex設置場所ＦＡＸ２";
			this.tex設置場所ＦＡＸ２.Size = new System.Drawing.Size(40, 23);
			this.tex設置場所ＦＡＸ２.TabIndex = 13;
			this.tex設置場所ＦＡＸ２.Text = "";
			this.tex設置場所ＦＡＸ２.Visible = false;
			// 
			// tex設置場所ＦＡＸ３
			// 
			this.tex設置場所ＦＡＸ３.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所ＦＡＸ３.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所ＦＡＸ３.Location = new System.Drawing.Point(224, 164);
			this.tex設置場所ＦＡＸ３.MaxLength = 4;
			this.tex設置場所ＦＡＸ３.Name = "tex設置場所ＦＡＸ３";
			this.tex設置場所ＦＡＸ３.Size = new System.Drawing.Size(40, 23);
			this.tex設置場所ＦＡＸ３.TabIndex = 14;
			this.tex設置場所ＦＡＸ３.Text = "";
			this.tex設置場所ＦＡＸ３.Visible = false;
			// 
			// tex設置場所ＦＡＸ１
			// 
			this.tex設置場所ＦＡＸ１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所ＦＡＸ１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所ＦＡＸ１.Location = new System.Drawing.Point(98, 164);
			this.tex設置場所ＦＡＸ１.MaxLength = 6;
			this.tex設置場所ＦＡＸ１.Name = "tex設置場所ＦＡＸ１";
			this.tex設置場所ＦＡＸ１.Size = new System.Drawing.Size(56, 23);
			this.tex設置場所ＦＡＸ１.TabIndex = 12;
			this.tex設置場所ＦＡＸ１.Text = "";
			this.tex設置場所ＦＡＸ１.Visible = false;
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label16.ForeColor = System.Drawing.Color.LimeGreen;
			this.label16.Location = new System.Drawing.Point(88, 146);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(10, 14);
			this.label16.TabIndex = 88;
			this.label16.Text = "（";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label17.ForeColor = System.Drawing.Color.LimeGreen;
			this.label17.Location = new System.Drawing.Point(154, 146);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(12, 14);
			this.label17.TabIndex = 89;
			this.label17.Text = "）";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label18.ForeColor = System.Drawing.Color.LimeGreen;
			this.label18.Location = new System.Drawing.Point(210, 146);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(12, 14);
			this.label18.TabIndex = 90;
			this.label18.Text = "－";
			// 
			// tex設置場所電話２
			// 
			this.tex設置場所電話２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所電話２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所電話２.Location = new System.Drawing.Point(170, 140);
			this.tex設置場所電話２.MaxLength = 4;
			this.tex設置場所電話２.Name = "tex設置場所電話２";
			this.tex設置場所電話２.Size = new System.Drawing.Size(40, 23);
			this.tex設置場所電話２.TabIndex = 10;
			this.tex設置場所電話２.Text = "";
			// 
			// tex設置場所電話３
			// 
			this.tex設置場所電話３.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所電話３.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所電話３.Location = new System.Drawing.Point(224, 140);
			this.tex設置場所電話３.MaxLength = 4;
			this.tex設置場所電話３.Name = "tex設置場所電話３";
			this.tex設置場所電話３.Size = new System.Drawing.Size(40, 23);
			this.tex設置場所電話３.TabIndex = 11;
			this.tex設置場所電話３.Text = "";
			// 
			// tex設置場所電話１
			// 
			this.tex設置場所電話１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所電話１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所電話１.Location = new System.Drawing.Point(98, 140);
			this.tex設置場所電話１.MaxLength = 6;
			this.tex設置場所電話１.Name = "tex設置場所電話１";
			this.tex設置場所電話１.Size = new System.Drawing.Size(56, 23);
			this.tex設置場所電話１.TabIndex = 9;
			this.tex設置場所電話１.Text = "";
			// 
			// cb設置場所県
			// 
			this.cb設置場所県.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cb設置場所県.Location = new System.Drawing.Point(98, 92);
			this.cb設置場所県.Name = "cb設置場所県";
			this.cb設置場所県.Size = new System.Drawing.Size(90, 24);
			this.cb設置場所県.TabIndex = 6;
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label19.ForeColor = System.Drawing.Color.LimeGreen;
			this.label19.Location = new System.Drawing.Point(58, 170);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(30, 14);
			this.label19.TabIndex = 83;
			this.label19.Text = "ＦＡＸ";
			this.label19.Visible = false;
			// 
			// label20
			// 
			this.label20.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label20.ForeColor = System.Drawing.Color.LimeGreen;
			this.label20.Location = new System.Drawing.Point(58, 146);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(30, 14);
			this.label20.TabIndex = 82;
			this.label20.Text = "ＴＥＬ";
			// 
			// tex設置場所カナ
			// 
			this.tex設置場所カナ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所カナ.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex設置場所カナ.Location = new System.Drawing.Point(98, 44);
			this.tex設置場所カナ.MaxLength = 20;
			this.tex設置場所カナ.Name = "tex設置場所カナ";
			this.tex設置場所カナ.Size = new System.Drawing.Size(326, 23);
			this.tex設置場所カナ.TabIndex = 2;
			this.tex設置場所カナ.Text = "";
			// 
			// lab設置場所カナ
			// 
			this.lab設置場所カナ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab設置場所カナ.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab設置場所カナ.Location = new System.Drawing.Point(58, 50);
			this.lab設置場所カナ.Name = "lab設置場所カナ";
			this.lab設置場所カナ.Size = new System.Drawing.Size(40, 14);
			this.lab設置場所カナ.TabIndex = 59;
			this.lab設置場所カナ.Text = "フリガナ";
			// 
			// label23
			// 
			this.label23.BackColor = System.Drawing.Color.Honeydew;
			this.label23.ForeColor = System.Drawing.Color.Red;
			this.label23.Location = new System.Drawing.Point(32, 26);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(16, 14);
			this.label23.TabIndex = 50;
			this.label23.Text = "※";
			// 
			// lab設置場所
			// 
			this.lab設置場所.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab設置場所.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.lab設置場所.ForeColor = System.Drawing.Color.Blue;
			this.lab設置場所.Location = new System.Drawing.Point(0, 0);
			this.lab設置場所.Name = "lab設置場所";
			this.lab設置場所.Size = new System.Drawing.Size(22, 228);
			this.lab設置場所.TabIndex = 0;
			this.lab設置場所.Text = "設置場所／セクション";
			this.lab設置場所.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tex設置場所名
			// 
			this.tex設置場所名.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所名.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex設置場所名.Location = new System.Drawing.Point(98, 20);
			this.tex設置場所名.MaxLength = 20;
			this.tex設置場所名.Name = "tex設置場所名";
			this.tex設置場所名.Size = new System.Drawing.Size(326, 23);
			this.tex設置場所名.TabIndex = 1;
			this.tex設置場所名.Text = "";
			// 
			// label25
			// 
			this.label25.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label25.ForeColor = System.Drawing.Color.LimeGreen;
			this.label25.Location = new System.Drawing.Point(46, 26);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(52, 14);
			this.label25.TabIndex = 9;
			this.label25.Text = "ご法人名";
			// 
			// label26
			// 
			this.label26.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label26.ForeColor = System.Drawing.Color.LimeGreen;
			this.label26.Location = new System.Drawing.Point(58, 98);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(40, 14);
			this.label26.TabIndex = 77;
			this.label26.Text = "ご住所";
			// 
			// label27
			// 
			this.label27.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label27.Location = new System.Drawing.Point(134, 70);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(12, 14);
			this.label27.TabIndex = 80;
			this.label27.Text = "－";
			// 
			// tex設置場所郵便１
			// 
			this.tex設置場所郵便１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所郵便１.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所郵便１.Location = new System.Drawing.Point(98, 68);
			this.tex設置場所郵便１.MaxLength = 3;
			this.tex設置場所郵便１.Name = "tex設置場所郵便１";
			this.tex設置場所郵便１.Size = new System.Drawing.Size(34, 23);
			this.tex設置場所郵便１.TabIndex = 3;
			this.tex設置場所郵便１.Text = "";
			// 
			// tex設置場所郵便２
			// 
			this.tex設置場所郵便２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所郵便２.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex設置場所郵便２.Location = new System.Drawing.Point(154, 68);
			this.tex設置場所郵便２.MaxLength = 4;
			this.tex設置場所郵便２.Name = "tex設置場所郵便２";
			this.tex設置場所郵便２.Size = new System.Drawing.Size(42, 23);
			this.tex設置場所郵便２.TabIndex = 4;
			this.tex設置場所郵便２.Text = "";
			this.tex設置場所郵便２.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex設置場所郵便２_KeyDown);
			this.tex設置場所郵便２.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex設置場所郵便２_KeyPress);
			// 
			// btn設置場所郵便
			// 
			this.btn設置場所郵便.BackColor = System.Drawing.Color.SteelBlue;
			this.btn設置場所郵便.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn設置場所郵便.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn設置場所郵便.ForeColor = System.Drawing.Color.White;
			this.btn設置場所郵便.Location = new System.Drawing.Point(204, 68);
			this.btn設置場所郵便.Name = "btn設置場所郵便";
			this.btn設置場所郵便.Size = new System.Drawing.Size(48, 22);
			this.btn設置場所郵便.TabIndex = 5;
			this.btn設置場所郵便.TabStop = false;
			this.btn設置場所郵便.Text = "検索";
			this.btn設置場所郵便.Click += new System.EventHandler(this.btn設置場所郵便_Click);
			// 
			// tex設置場所住所１
			// 
			this.tex設置場所住所１.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所住所１.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex設置場所住所１.Location = new System.Drawing.Point(186, 92);
			this.tex設置場所住所１.MaxLength = 16;
			this.tex設置場所住所１.Name = "tex設置場所住所１";
			this.tex設置場所住所１.Size = new System.Drawing.Size(262, 23);
			this.tex設置場所住所１.TabIndex = 7;
			this.tex設置場所住所１.Text = "";
			// 
			// tex設置場所住所２
			// 
			this.tex設置場所住所２.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex設置場所住所２.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.tex設置場所住所２.Location = new System.Drawing.Point(98, 116);
			this.tex設置場所住所２.MaxLength = 20;
			this.tex設置場所住所２.Name = "tex設置場所住所２";
			this.tex設置場所住所２.Size = new System.Drawing.Size(326, 23);
			this.tex設置場所住所２.TabIndex = 8;
			this.tex設置場所住所２.Text = "";
			// 
			// label31
			// 
			this.label31.BackColor = System.Drawing.Color.Honeydew;
			this.label31.ForeColor = System.Drawing.Color.Red;
			this.label31.Location = new System.Drawing.Point(22, 194);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(16, 14);
			this.label31.TabIndex = 103;
			this.label31.Text = "※";
			// 
			// btn支店情報登録
			// 
			this.btn支店情報登録.BackColor = System.Drawing.Color.Blue;
			this.btn支店情報登録.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn支店情報登録.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn支店情報登録.ForeColor = System.Drawing.Color.White;
			this.btn支店情報登録.Location = new System.Drawing.Point(700, 60);
			this.btn支店情報登録.Name = "btn支店情報登録";
			this.btn支店情報登録.Size = new System.Drawing.Size(90, 22);
			this.btn支店情報登録.TabIndex = 103;
			this.btn支店情報登録.TabStop = false;
			this.btn支店情報登録.Text = "支店情報登録";
			this.btn支店情報登録.Click += new System.EventHandler(this.btn店所情報登録_Click);
			// 
			// 会員加入
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 573);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.btn支店情報登録);
			this.ForeColor = System.Drawing.Color.Black;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(802, 607);
			this.Name = "会員加入";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 使用申し込みメンテナンス";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
			this.Load += new System.EventHandler(this.会員加入_Load);
			this.Closed += new System.EventHandler(this.会員加入_Closed);
			this.Activated += new System.EventHandler(this.会員加入_Activated);
			this.pnl申込者.ResumeLayout(false);
			this.pnl受付ＮＯ.ResumeLayout(false);
			this.panel6.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.pnlシステム情報.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numサーマル台数)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.pnl設置場所.ResumeLayout(false);
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

		private void 会員加入_Load(object sender, System.EventArgs e)
		{
			tex認証会員名.Text = gs会員名;
			tex認証利用者名.Text = gs利用者名;

			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;

			// 県名の初期設定
			cb申込者県.Items.Clear();
			cb申込者県.Items.AddRange(sa県);
			cb設置場所県.Items.Clear();
			cb設置場所県.Items.AddRange(sa県);

// DEL 2006.11.10 東都）高木 画面の調整 START
//			tex初期パスワード.Visible = false;
// DEL 2006.11.10 東都）高木 画面の調整 END

			if( gs店所コード.Trim().Length != 0)
			{
				//営業所の場合
// ADD 2007.01.19 東都）高木 営業所での会員一覧表示の停止 START
				btnお客様コード.Visible = false;
// ADD 2007.01.19 東都）高木 営業所での会員一覧表示の停止 END
				//パスワードは非表示
				lab初期パスワード.Visible = false;
				lab米_初期パスワード.Visible = false;
				tex初期パスワード.Visible = false;
				lab説明_初期パスワード.Visible = false;
				//承認情報は編集不可
				rb登録中.Enabled = false;
				rb申請中.Enabled = false;
				rb留保中.Enabled = false;
				rb承認済.Enabled = false;
				texメモ.Enabled = false;
// ADD 2007.02.07 東都）高木 画面初期化の変更 START
			}else{
				//営業所の場合
				btnお客様コード.Visible = true;
				//パスワードは非表示
				lab初期パスワード.Visible = true;
				lab米_初期パスワード.Visible = true;
				tex初期パスワード.Visible = true;
				lab説明_初期パスワード.Visible = true;
				//承認情報は編集不可
				rb登録中.Enabled = true;
				rb申請中.Enabled = true;
				rb留保中.Enabled = true;
				rb承認済.Enabled = true;
				texメモ.Enabled = true;
// ADD 2007.02.07 東都）高木 画面初期化の変更 END
			}
			登録モード();
// MOD 2006.11.30 東都）高木 画面の調整 START
//			tex受付ＮＯ.Focus();
			tex申込者名.Text = " ";
			tex申込者名.Focus();
// MOD 2006.11.30 東都）高木 画面の調整 END
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
			if(gs店所コード.Trim().Length == 0){
				pnl申込者.Enabled       = false;
				pnl設置場所.Enabled     = false;
				tex受付ＮＯ.Focus();
			}
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END
		}

		private void 登録モード()
		{
			pnl受付ＮＯ.Enabled = true;
			pnl申込者.Enabled       = true;
			pnl設置場所.Enabled     = true;
			pnlシステム情報.Enabled = true;
			クリア();
			btn登録.Text = "登録";
			btn登録.Enabled = true;
			btn削除.Enabled = false;
// 2006.10.26 ADD　FJCS）桑田 印刷系のボタンも使えるようにする START
			btn契約書.Enabled = true;
// DEL 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
//			btn申込書.Enabled = true;
// DEL 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END
// 2006.10.26 ADD　FJCS）桑田 印刷系のボタンも使えるようにする END

			s申込更新日時 = "00000000000000";
		}

		private void 更新モード()
		{
			pnl受付ＮＯ.Enabled = false;
			pnl申込者.Enabled       = true;
			pnl設置場所.Enabled     = true;
			pnlシステム情報.Enabled = true;
			btn登録.Text = "更新";
			btn登録.Enabled = true;
			btn削除.Enabled = true;
// 2006.10.26 ADD　FJCS）桑田 印刷系のボタンも使えるようにする START
			btn契約書.Enabled = true;
// DEL 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
//			btn申込書.Enabled = true;
// DEL 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END
// 2006.10.26 ADD　FJCS）桑田 印刷系のボタンも使えるようにする END
		}

		private void tex受付ＮＯ_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn申込情報検索.Focus();
				申込情報一覧();
				e.Handled = true;
			}
		}

		private void btn申込情報検索_Click(object sender, System.EventArgs e)
		{
			申込情報一覧();
		}

		private void btn申込情報実行_Click(object sender, System.EventArgs e)
		{
			申込情報検索();
		}

		private void 申込情報一覧()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			//検索画面を右側に表示する
			if(g加入検索 == null) g加入検索 = new 加入検索();
			g加入検索.Left = this.Left + 404;
			g加入検索.Top = this.Top;

			// コードの初期表示
			g加入検索.s店所コード = gs店所コード.Trim();
			g加入検索.s受付ＮＯ = "";
			g加入検索.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g加入検索.s受付ＮＯ.Trim().Length > 0)
			{
				tex受付ＮＯ.Text = g加入検索.s受付ＮＯ.Trim();
				申込情報検索();
			}
			else
			{
				tex受付ＮＯ.Focus();
			}
		}

		private void 申込情報検索()
		{
			texメッセージ.Text = "";
			tex受付ＮＯ.Text = tex受付ＮＯ.Text.Trim();
// MOD 2007.01.19 東都）高木 文言の変更 START
			if(!必須チェック(tex受付ＮＯ, "受付ＮＯ")) return;
			if(!半角チェック(tex受付ＮＯ, "受付ＮＯ")) return;
// MOD 2007.01.19 東都）高木 文言の変更 END

			//左０詰
			tex受付ＮＯ.Text = tex受付ＮＯ.Text.PadLeft(7,'0');
			string s受付ＮＯ = tex受付ＮＯ.Text;

			texメッセージ.Text = "検索中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[2];
				sKey[0] = tex受付ＮＯ.Text;
				sKey[1] = gs店所コード.Trim();
				string[] sData = sv_maintenance.Sel_Mosikomi(gsaユーザ, sKey);

				if (sData[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";

					//各項目の設定

					//受付ＮＯ情報
					s店所コード = sData[1];
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					s申込時店所コード = sData[1];
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

					//申込者情報
					tex申込者カナ.Text = sData[2];
					tex申込者名.Text   = sData[3];
					string s申込者郵便 = sData[4];
					if(s申込者郵便.Length <= 3){
						tex申込者郵便１.Text = s申込者郵便;
					}else{
						tex申込者郵便１.Text = s申込者郵便.Substring(0,3);
						tex申込者郵便２.Text = s申込者郵便.Substring(3);
					}
					if(sData[5].Length > 0)
						cb申込者県.SelectedIndex = int.Parse(sData[5]);
					else
						cb申込者県.SelectedIndex = 0;

					tex申込者住所１.Text = sData[6];
					tex申込者住所２.Text = sData[7];
					tex申込者電話１.Text = sData[8];
					tex申込者電話２.Text = sData[9];
					tex申込者電話３.Text = sData[10];
					//sData[11] = tex申込者電話１.Text + tex申込者電話２.Text + tex申込者電話３.Text;
					tex申込者ＦＡＸ１.Text = sData[12];
					tex申込者ＦＡＸ２.Text = sData[13];
					tex申込者ＦＡＸ３.Text = sData[14];
					//設置場所情報
					if(sData[15] == "1")
						chb設置場所.Checked = true;
					else
						chb設置場所.Checked = false;
					設置場所入力制御ＡＬＬ();
					tex設置場所カナ.Text = sData[16];
					tex設置場所名.Text   = sData[17];
					string s設置場所郵便 = sData[18];
					if(s設置場所郵便.Length <= 3){
						tex設置場所郵便１.Text = s設置場所郵便;
					}else{
						tex設置場所郵便１.Text = s設置場所郵便.Substring(0,3);
						tex設置場所郵便２.Text = s設置場所郵便.Substring(3);
					}
					if(sData[19].Length > 0)
						cb設置場所県.SelectedIndex = int.Parse(sData[19]);
					else
						cb設置場所県.SelectedIndex = 0;

					tex設置場所住所１.Text = sData[20];
					tex設置場所住所２.Text = sData[21];
					tex設置場所電話１.Text = sData[22];
					tex設置場所電話２.Text = sData[23];
					tex設置場所電話３.Text = sData[24];
					tex設置場所ＦＡＸ１.Text = sData[25];
					tex設置場所ＦＡＸ２.Text = sData[26];
					tex設置場所ＦＡＸ３.Text = sData[27];
					tex設置場所担当者名.Text = sData[28];
					tex設置場所役職名.Text = sData[29];

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//郵便検索にお客様コードが必要なので編集場所を変更
					texお客様コード.Text = sData[31];
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

// 2006.08.23 ADD　東都）山本  検索時に出荷店コードを表示 START
					if(tex設置場所郵便１.Text.Length == 3 && tex設置場所郵便２.Text.Length == 4)
						郵便検索(tex設置場所郵便１, tex設置場所郵便２, 
							cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex管理店所名);
// 2006.08.23 ADD　東都）山本  検索時に出荷店コードを表示 END

					int i設置場所使用料 = int.Parse(sData[30]);
					if(i設置場所使用料 > 0)
						tex設置場所使用料.Text = i設置場所使用料.ToString("#,##0");
					else
						tex設置場所使用料.Text = "";
					//システム情報
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//郵便検索にお客様コードが必要なので編集場所を変更
//					texお客様コード.Text = sData[31];
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

					if(sData[32].Length == 8)
						dtp使用開始日.Value = new DateTime(int.Parse(sData[32].Substring(0, 4)),
															int.Parse(sData[32].Substring(4, 2)),
															int.Parse(sData[32].Substring(6, 2)));
					else
						dtp使用開始日.Value = DateTime.Now;
					tex部門コード.Text     = sData[33];
					tex部門名.Text         = sData[34];
					int iサーマル台数 = int.Parse(sData[35]);
					if(iサーマル台数 > 0)
						numサーマル台数.Value = iサーマル台数;
					else
						numサーマル台数.Value = 1;
					texユーザーコード.Text = sData[36];
					texユーザー名.Text     = sData[37];
					tex初期パスワード.Text = sData[38];
					//承認状態情報
					if(sData[39].Length == 0) rb登録中.Checked = true;
					else if(sData[39] == "1") rb申請中.Checked = true;
					else if(sData[39] == "2") rb留保中.Checked = true;
					else if(sData[39] == "3") rb承認済.Checked = true;
					else rb登録中.Checked = true;
					if(rb登録中.Checked)      lab申請中.Text = "登録中";
					else if(rb申請中.Checked) lab申請中.Text = "申請中";
					else if(rb留保中.Checked) lab申請中.Text = "留保中";
					else if(rb承認済.Checked) lab申請中.Text = "承認済";

					texメモ.Text  = sData[40];
					//更新情報
					s申込更新日時 = sData[41];

					更新モード();
// ADD 2007.01.30 東都）高木 印刷済（申請中）以降は、更新できなくする START
					if(sData[39].Length == 0)
						btn登録.Enabled = true;
					else
						btn登録.Enabled = false;
// ADD 2007.01.30 東都）高木 印刷済（申請中）以降は、更新できなくする END
// MOD 2006.11.30 東都）高木 画面の調整 START
//					tex申込者カナ.Focus();
					tex申込者名.Focus();
// MOD 2006.11.30 東都）高木 画面の調整 END
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
					if(gs店所コード.Trim().Length == 0){
						pnl申込者.Enabled   = false;
						pnl設置場所.Enabled = false;
						btn登録.Enabled     = true;
						tex受付ＮＯ.Focus();
					}
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END

					//承認済の場合、更新不可
					if(rb承認済.Checked)
					{
						pnl申込者.Enabled       = false;
						pnl設置場所.Enabled     = false;
						pnlシステム情報.Enabled = false;
						btn登録.Enabled = false;
						btn削除.Enabled = false;
// 2006.10.26 ADD　FJCS）桑田 印刷系のボタンも使えなくする START
						btn契約書.Enabled = false;
// DEL 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
//						btn申込書.Enabled = false;
// DEL 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END
// 2006.10.26 ADD　FJCS）桑田 印刷系のボタンも使えなくする END
						btn取消.Focus();
					}
				}
				else
				{
					texメッセージ.Text = sData[0];
					ビープ音();
					登録モード();
					tex受付ＮＯ.Text = s受付ＮＯ;
					tex受付ＮＯ.Focus();
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				登録モード();
				tex受付ＮＯ.Text = s受付ＮＯ;
				tex受付ＮＯ.Focus();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn登録_Click(object sender, System.EventArgs e)
		{

			if(登録_チェック() != true) return;
			try
			{
				string[] sData  = new string[43];
				//受付ＮＯ情報
				sData[0] = tex受付ＮＯ.Text.Trim();
				sData[1] = s店所コード;
				//申込者情報
				sData[2] = tex申込者カナ.Text;
				sData[3] = tex申込者名.Text;
				sData[4] = tex申込者郵便１.Text + tex申込者郵便２.Text;
				sData[5] = cb申込者県.SelectedIndex.ToString("00");
				sData[6] = tex申込者住所１.Text;
				sData[7] = tex申込者住所２.Text;
				sData[8] = tex申込者電話１.Text;
				sData[9] = tex申込者電話２.Text;
				sData[10] = tex申込者電話３.Text;
				sData[11] = tex申込者電話１.Text + tex申込者電話２.Text + tex申込者電話３.Text;
				sData[12] = tex申込者ＦＡＸ１.Text;
				sData[13] = tex申込者ＦＡＸ２.Text;
				sData[14] = tex申込者ＦＡＸ３.Text;
				//設置場所情報
				if(chb設置場所.Checked)
					sData[15] = "1";
				else
					sData[15] = " ";
//				設置場所入力制御ＡＬＬ();
				sData[16] = tex設置場所カナ.Text;
				sData[17] = tex設置場所名.Text;
				sData[18] = tex設置場所郵便１.Text + tex設置場所郵便２.Text;
				sData[19] = cb設置場所県.SelectedIndex.ToString("00");
				sData[20] = tex設置場所住所１.Text;
				sData[21] = tex設置場所住所２.Text;
				sData[22] = tex設置場所電話１.Text;
				sData[23] = tex設置場所電話２.Text;
				sData[24] = tex設置場所電話３.Text;
				sData[25] = tex設置場所ＦＡＸ１.Text;
				sData[26] = tex設置場所ＦＡＸ２.Text;
				sData[27] = tex設置場所ＦＡＸ３.Text;
				sData[28] = tex設置場所担当者名.Text;
				sData[29] = tex設置場所役職名.Text;
				sData[30] = tex設置場所使用料.Text.Replace(",","");
				//システム情報
				sData[31] = texお客様コード.Text;
				sData[32] = dtp使用開始日.Value.Year.ToString() 
								+ dtp使用開始日.Value.Month.ToString().PadLeft(2, '0') 
								+ dtp使用開始日.Value.Day.ToString().PadLeft(2, '0');
				sData[33] = tex部門コード.Text;
				sData[34] = tex部門名.Text;
				sData[35] = numサーマル台数.Value.ToString();
				sData[36] = texユーザーコード.Text;
				sData[37] = texユーザー名.Text;
				sData[38] = tex初期パスワード.Text;
				//承認状態情報
				if(rb登録中.Checked) sData[39] = " ";
				else if(rb申請中.Checked) sData[39] = "1";
				else if(rb留保中.Checked) sData[39] = "2";
				else if(rb承認済.Checked) sData[39] = "3";
				else sData[39] = " ";
				sData[40] = texメモ.Text;
				//更新情報
				sData[41] = s申込更新日時;
				sData[42] = gs利用者コード;

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};
				if (btn登録.Text.Equals("登録"))
				{

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if ((texお客様コード.Text == "") || (texお客様コード.Text.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

						sList = sv_maintenance.Ins_Mosikomi(gsaユーザ, sData);

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					}
					else
					{
						sList = sv_oji.Ins_Mosikomi(gsaユーザ, sData);
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						texメッセージ.Text = "";
						//s申込更新日時 = sList[1].Trim();
						//tex受付ＮＯ.Text = sList[2].Trim();
						登録モード();
// MOD 2006.11.30 東都）高木 画面の調整 START
//						tex受付ＮＯ.Focus();
						tex申込者名.Text = " ";
						tex申込者名.Focus();
// MOD 2006.11.30 東都）高木 画面の調整 END
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
						if(gs店所コード.Trim().Length == 0) tex受付ＮＯ.Focus();
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END
					}
					else
					{
						if(sList.Length >= 2 && sList[2] != null)
							tex受付ＮＯ.Text = sList[2].Trim();
						ビープ音();
					}
				}
				else
				{

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if ((texお客様コード.Text == "") || (texお客様コード.Text.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

						sList = sv_maintenance.Upd_Mosikomi(gsaユーザ, sData);

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					}
					else
					{
						sList = sv_oji.Upd_Mosikomi(gsaユーザ, sData);
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
					
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						texメッセージ.Text = "";
						//会員の更新
						s申込更新日時 = sList[1].Trim();
						登録モード();
// MOD 2006.11.30 東都）高木 画面の調整 START
//						tex受付ＮＯ.Focus();
						tex申込者名.Text = " ";
						tex申込者名.Focus();
// MOD 2006.11.30 東都）高木 画面の調整 END
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
						if(gs店所コード.Trim().Length == 0) tex受付ＮＯ.Focus();
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END
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
//				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private bool 登録_チェック()
		{
// DEL 2006.11.06 東都）高木 出荷店チェック位置変更 START
//			if(gs店所コード.Trim().Length != 0)
//			{
//				if (gs店所コード.Trim() != s店所コード.Trim())
//				{
//					MessageBox.Show("出荷店が正しくありません。（出荷店：" + s店所コード.Trim() + "）","入力チェック", MessageBoxButtons.OK);
//					tex設置場所郵便１.Focus();
//					return(false);
//				}
//			}
// DEL 2006.11.06 東都）高木 出荷店チェック位置変更 END

			//Ｔｒｉｍ
			tex申込者名.Text = tex申込者名.Text.Trim();
			tex申込者カナ.Text = tex申込者カナ.Text.Trim();
			tex申込者名.Text = tex申込者名.Text.Trim();
			tex申込者郵便１.Text = tex申込者郵便１.Text.Trim();
			tex申込者郵便２.Text = tex申込者郵便２.Text.Trim();
// ADD 2006.11.06 東都）高木 支店登録画面の追加 START
			cb申込者県.Text = cb申込者県.Text.Trim();
// ADD 2006.11.06 東都）高木 支店登録画面の追加 END
			tex申込者住所１.Text = tex申込者住所１.Text.Trim();
			tex申込者住所２.Text = tex申込者住所２.Text.Trim();
			tex申込者電話１.Text = tex申込者電話１.Text.Trim();
			tex申込者電話２.Text = tex申込者電話２.Text.Trim();
			tex申込者電話３.Text = tex申込者電話３.Text.Trim();
			tex申込者ＦＡＸ１.Text = tex申込者ＦＡＸ１.Text.Trim();
			tex申込者ＦＡＸ２.Text = tex申込者ＦＡＸ２.Text.Trim();
			tex申込者ＦＡＸ３.Text = tex申込者ＦＡＸ３.Text.Trim();

//			chb設置場所.Checked = false;
			設置場所入力制御ＡＬＬ();
			tex設置場所カナ.Text = tex設置場所カナ.Text.Trim();
			tex設置場所名.Text = tex設置場所名.Text.Trim();
			tex設置場所郵便１.Text = tex設置場所郵便１.Text.Trim();
			tex設置場所郵便２.Text = tex設置場所郵便２.Text.Trim();
			tex管理店所名.Text = tex管理店所名.Text.Trim();
// ADD 2006.11.06 東都）高木 支店登録画面の追加 START
			cb設置場所県.Text = cb設置場所県.Text.Trim();
// ADD 2006.11.06 東都）高木 支店登録画面の追加 END
			tex設置場所住所１.Text = tex設置場所住所１.Text.Trim();
			tex設置場所住所２.Text = tex設置場所住所２.Text.Trim();
			tex設置場所電話１.Text = tex設置場所電話１.Text.Trim();
			tex設置場所電話２.Text = tex設置場所電話２.Text.Trim();
			tex設置場所電話３.Text = tex設置場所電話３.Text.Trim();
			tex設置場所ＦＡＸ１.Text = tex設置場所ＦＡＸ１.Text.Trim();
			tex設置場所ＦＡＸ２.Text = tex設置場所ＦＡＸ２.Text.Trim();
			tex設置場所ＦＡＸ３.Text = tex設置場所ＦＡＸ３.Text.Trim();
			tex設置場所担当者名.Text = tex設置場所担当者名.Text.Trim();
			tex設置場所役職名.Text = tex設置場所役職名.Text.Trim();
			tex設置場所使用料.Text = tex設置場所使用料.Text.Trim();

			texお客様コード.Text = texお客様コード.Text.Trim();
//			dtp使用開始日.Value = DateTime.Now;
			tex部門コード.Text = tex部門コード.Text.Trim();
			tex部門名.Text = tex部門名.Text.Trim();
//			numサーマル台数.Value = 1;
			texユーザーコード.Text = texユーザーコード.Text.Trim();
			texユーザー名.Text = texユーザー名.Text.Trim();
			tex初期パスワード.Text = tex初期パスワード.Text.Trim();
//			rb申請中.Checked = true;
			texメモ.Text = texメモ.Text.Trim();
			
			//必須チェック
			if (!必須チェック(tex申込者名, "お申込者名")) return(false);
			if (!必須チェック(tex申込者電話１, "お申込者電話番号")) return(false);
			if (!必須チェック(tex申込者電話２, "お申込者電話番号")) return(false);
			if (!必須チェック(tex申込者電話３, "お申込者電話番号")) return(false);
			if (!必須チェック(tex設置場所名, "ご法人名")) return(false);
// MOD 2007.01.20 東都）高木 画面調整 START
//			if (!必須チェック(tex設置場所郵便１, "設置場所郵便番号")) return(false);
//			if (!必須チェック(tex設置場所郵便２, "設置場所郵便番号")) return(false);
			if(tex設置場所郵便１.Enabled){
				if (!必須チェック(tex設置場所郵便１, "設置場所郵便番号")) return(false);
				if (!必須チェック(tex設置場所郵便２, "設置場所郵便番号")) return(false);
			}else{
// MOD 2008.05.02 東都）高木 申込者郵便番号エラーメッセージの変更 START
//				if (!必須チェック(tex申込者郵便１, "設置場所郵便番号")) return(false);
//				if (!必須チェック(tex申込者郵便２, "設置場所郵便番号")) return(false);
				if (!必須チェック(tex申込者郵便１, "申込者郵便番号")) return(false);
				if (!必須チェック(tex申込者郵便２, "申込者郵便番号")) return(false);
// MOD 2008.05.02 東都）高木 申込者郵便番号エラーメッセージの変更 END
			}
// MOD 2007.01.20 東都）高木 画面調整 END
			if (!必須チェック(tex設置場所電話１, "設置場所電話番号")) return(false);
			if (!必須チェック(tex設置場所電話２, "設置場所電話番号")) return(false);
			if (!必須チェック(tex設置場所電話３, "設置場所電話番号")) return(false);
			if (!必須チェック(tex設置場所担当者名, "ご担当者名")) return(false);

			//型チェック
// MOD 2008.05.07 東都）高木 エラーチェック順の変更 START
//			if (!全角チェック(tex申込者カナ, "お申込者カナ")) return(false);
//			if (!全角チェック(tex申込者名, "お申込者名")) return(false);
			if (!全角チェック(tex申込者名, "お申込者名")) return(false);
			if (!全角チェック(tex申込者カナ, "お申込者カナ")) return(false);
// MOD 2008.05.07 東都）高木 エラーチェック順の変更 END
			if (!半角チェック(tex申込者郵便１, "お申込者郵便番号")) return(false);
			if (!半角チェック(tex申込者郵便２, "お申込者郵便番号")) return(false);
			if (!全角チェック(tex申込者住所１, "お申込者住所１")) return(false);
			if (!全角チェック(tex申込者住所２, "お申込者住所２")) return(false);
			if (!半角チェック(tex申込者電話１, "お申込者電話番号")) return(false);
			if (!半角チェック(tex申込者電話２, "お申込者電話番号")) return(false);
			if (!半角チェック(tex申込者電話３, "お申込者電話番号")) return(false);
			if (!半角チェック(tex申込者ＦＡＸ１, "お申込者ＦＡＸ番号")) return(false);
			if (!半角チェック(tex申込者ＦＡＸ２, "お申込者ＦＡＸ番号")) return(false);
			if (!半角チェック(tex申込者ＦＡＸ３, "お申込者ＦＡＸ番号")) return(false);

// MOD 2008.05.07 東都）高木 エラーチェック順の変更 START
//			if (!全角チェック(tex設置場所カナ, "設置場所カナ")) return(false);
//			if (!全角チェック(tex設置場所名, "ご法人名")) return(false);
			if (!全角チェック(tex設置場所名, "ご法人名")) return(false);
			if (!全角チェック(tex設置場所カナ, "ご法人名カナ")) return(false);
// MOD 2008.05.07 東都）高木 エラーチェック順の変更 END
			if (!半角チェック(tex設置場所郵便１, "設置場所郵便番号")) return(false);
			if (!半角チェック(tex設置場所郵便２, "設置場所郵便番号")) return(false);
			if (!全角チェック(tex設置場所住所１, "設置場所住所１")) return(false);
			if (!全角チェック(tex設置場所住所２, "設置場所住所２")) return(false);
			if (!半角チェック(tex設置場所電話１, "設置場所電話番号")) return(false);
			if (!半角チェック(tex設置場所電話２, "設置場所電話番号")) return(false);
			if (!半角チェック(tex設置場所電話３, "設置場所電話番号")) return(false);
			if (!半角チェック(tex設置場所ＦＡＸ１, "設置場所ＦＡＸ番号")) return(false);
			if (!半角チェック(tex設置場所ＦＡＸ２, "設置場所ＦＡＸ番号")) return(false);
			if (!半角チェック(tex設置場所ＦＡＸ３, "設置場所ＦＡＸ番号")) return(false);
			if (!全角チェック(tex設置場所担当者名, "ご担当者名")) return(false);
			if (!全角チェック(tex設置場所役職名, "役職名")) return(false);
			if (tex設置場所使用料.Text.Length == 0) tex設置場所使用料.Text = "0";
			if (!範囲チェック(tex設置場所使用料, "使用料", 0, 99999)) return(false);

			if (!半角チェック(texお客様コード, "お客様コード")) return(false);
			if (!半角チェック(tex部門コード, "セクションコード")) return(false);
			if (!全角チェック(tex部門名, "セクション名")) return(false);
			if (!範囲チェック(numサーマル台数, "サーマル台数")) return(false);
			if (!半角チェック(texユーザーコード, "ユーザーコード")) return(false);
			if (!全角チェック(texユーザー名, "ユーザー名")) return(false);
			if (!半角チェック(tex初期パスワード, "初期パスワード")) return(false);
			if (!全角チェック(texメモ, "メモ")) return(false);

			//マスタチェック
			if (!郵便検索(tex申込者郵便１, tex申込者郵便２, 
				cb申込者県, tex申込者住所１, tex申込者住所２, null))
			{
				MessageBox.Show("郵便番号(" + tex申込者郵便１.Text + tex申込者郵便２.Text + ")が存在しません",
					"入力チェック", MessageBoxButtons.OK);
				tex申込者郵便１.Focus();
				return(false);
			}
			if (!郵便検索(tex設置場所郵便１, tex設置場所郵便２, 
				cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex管理店所名))
			{
				MessageBox.Show("郵便番号(" + tex設置場所郵便１.Text + tex設置場所郵便２.Text + ")が存在しません",
					"入力チェック", MessageBoxButtons.OK);
				tex設置場所郵便１.Focus();
				return(false);
			}
// ADD 2006.11.06 東都）高木 出荷店チェック位置変更 START
			if(gs店所コード.Trim().Length != 0)
			{
				if (gs店所コード.Trim() != s店所コード.Trim())
				{
// MOD 2007.01.20 東都）高木 画面調整 START
//					MessageBox.Show("出荷店が正しくありません。（出荷店：" + s店所コード.Trim() + "）","入力チェック", MessageBoxButtons.OK);
//					tex設置場所郵便１.Focus();
					MessageBox.Show("出荷店（郵便番号）が正しくありません。（出荷店：" + s店所コード.Trim() + "）","入力チェック", MessageBoxButtons.OK);
					if(tex設置場所郵便１.Enabled)
						tex設置場所郵便１.Focus();
					else
						tex申込者郵便１.Focus();
// MOD 2007.01.20 東都）高木 画面調整 END
					return(false);
				}
			}
// ADD 2006.11.06 東都）高木 出荷店チェック位置変更 END

// ADD 2006.11.06 東都）高木 支店登録画面の追加 START
			if (cb申込者県.Text.Length > 0 || tex申込者住所１.Text.Length > 0 || tex申込者住所２.Text.Length > 0)
				if (!県名チェック(cb申込者県, "お申込者都道府県")) return false;
			if (cb設置場所県.Text.Length > 0 || tex設置場所住所１.Text.Length > 0 || tex設置場所住所２.Text.Length > 0)
				if (!県名チェック(cb設置場所県, "設置場所都道府県")) return false;
// ADD 2006.11.06 東都）高木 支店登録画面の追加 END

			//省略時の設定
			string s申込者電話 = tex申込者電話１.Text + tex申込者電話２.Text + tex申込者電話３.Text;
			string s設置場所電話 = tex設置場所電話１.Text + tex設置場所電話２.Text + tex設置場所電話３.Text;
			if(texお客様コード.Text.Length == 0)
			{
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
				if(gs店所コード.Trim().Length != 0)
				{
					try
					{
						String[] sKey = new string[1];
						sKey[0] = gs店所コード;
						string[] sList = sv_oji.Sel_Member(gsaユーザ, sKey);

						if (sList[0].Equals("正常終了"))
						{
							if ((sList[4] == "3") || (sList[4] == "4"))
							{
								if(s申込者電話.Length > 9)		
									s申込者電話 = s申込者電話.Substring(s申込者電話.Length - 9);
								s申込者電話 = "J" + s申込者電話;
							}
						}
					}
					catch (Exception ex)
					{
						texメッセージ.Text = ex.Message;
						ビープ音();
					}
				}else if(s申込時店所コード.Trim().Length != 0)
				{
					try
					{
						String[] sKey1 = new string[1];
						sKey1[0] = s申込時店所コード;
						string[] sList = sv_oji.Sel_Member(gsaユーザ, sKey1);
						string sお客様コード = "";
						sお客様コード = texお客様コード.Text;
						if (sList[0].Equals("正常終了"))
						{
							if ((sList[4] == "3") || (sList[4] == "4"))
							{
								if(s申込者電話.Length > 9)		
									s申込者電話 = s申込者電話.Substring(s申込者電話.Length - 9);
								s申込者電話 = "J" + s申込者電話;
							}
						}
					}
					catch (Exception ex)
					{
						texメッセージ.Text = ex.Message;
						ビープ音();
					}
				}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
				
				if(s申込者電話.Length <= 10)
					texお客様コード.Text = s申込者電話;
				else				
					texお客様コード.Text = s申込者電話.Substring(s申込者電話.Length - 10);
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
			}
			else
			{
				if(s申込時店所コード.Trim().Length != 0)
				{
					try
					{
						String[] sKey1 = new string[1];
						sKey1[0] = s申込時店所コード;
						string[] sList = sv_oji.Sel_Member(gsaユーザ, sKey1);
						string sお客様コード = "";
						sお客様コード = texお客様コード.Text;
						if (sList[0].Equals("正常終了"))
						{
							if ((sList[4] == "3") || (sList[4] == "4"))
							{
								if ((sお客様コード.Trim() == "") || (sお客様コード.Trim().Substring(0,1) != "J"))
								{
									MessageBox.Show("お客様コードが違います。「お客様コード先頭：Ｊ…王子運送」","入力チェック",MessageBoxButtons.OK);
									return false;
								}
							}
							else if ((sList[4] == "0") || (sList[4] == "2"))
							{
								if ((sお客様コード.Trim() == "") || (sお客様コード.Trim().Substring(0,1) == "J"))
								{
									MessageBox.Show("お客様コードが違います。「お客様コード先頭：Ｊ…王子運送」","入力チェック",MessageBoxButtons.OK);
									return false;
								}
							}
						}
					}
					catch (Exception ex)
					{
						texメッセージ.Text = ex.Message;
						ビープ音();
					}
// MOD 2011.03.08 東都）高木 王子運送対応（王子営業所対応） START
				}else{
					// 王子運送営業所の場合、王子運送用お客様コードしか登録できない
					if(gs管理者区分 == "4"){
						if(texお客様コード.Text.Trim().Substring(0,1) == "J"){
							MessageBox.Show("お客様コードが違います。「お客様コード先頭：Ｊ…王子運送」"
											, "入力チェック"
											, MessageBoxButtons.OK);
							return false;
						}
					}
// MOD 2011.03.08 東都）高木 王子運送対応（王子営業所対応） END
				}

// ADD 2010.12.14 ACT）垣原 王子運送対応 END
			}

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
			//マスタチェック（お客様コード設定により再チェック要）
			if (!郵便検索(tex申込者郵便１, tex申込者郵便２, 
				cb申込者県, tex申込者住所１, tex申込者住所２, null))
			{
				MessageBox.Show("郵便番号(" + tex申込者郵便１.Text + tex申込者郵便２.Text + ")が存在しません",
					"入力チェック", MessageBoxButtons.OK);
				tex申込者郵便１.Focus();
				return(false);
			}
			if (!郵便検索(tex設置場所郵便１, tex設置場所郵便２, 
				cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex管理店所名))
			{
				MessageBox.Show("郵便番号(" + tex設置場所郵便１.Text + tex設置場所郵便２.Text + ")が存在しません",
					"入力チェック", MessageBoxButtons.OK);
				tex設置場所郵便１.Focus();
				return(false);
			}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END


			if(tex部門コード.Text.Length == 0)
			{
				if(s設置場所電話.Length <= 12)
					tex部門コード.Text = s設置場所電話;
				else				
					tex部門コード.Text = s設置場所電話.Substring(s設置場所電話.Length - 12);
			}
			if(tex部門名.Text.Length == 0)
				tex部門名.Text = tex設置場所名.Text;
			if(texユーザーコード.Text.Length == 0)
			{
				if(s申込者電話.Length <= 4)
					texユーザーコード.Text = s申込者電話;
				else				
					texユーザーコード.Text = s申込者電話.Substring(s申込者電話.Length - 4);
			}
			if(texユーザー名.Text.Length == 0)
				texユーザー名.Text = tex設置場所名.Text;
			if(tex初期パスワード.Text.Length == 0)
			{
				tex初期パスワード.Text = パスワード発行();
			}

			if(!会員存在チェック()) return(false);
			if(!ユーザー存在チェック()) return(false);

// MOD 2016.04.13 BEVAS）松本 社内伝票対応 START
			if(gs管理者区分 != "1")
			{
				//管理者権限以外では、社内伝票会員の使用申し込みを許可しない
				if(texお客様コード.Text.Substring(0,2) == "FK")
				{
					MessageBox.Show("管理者以外の権限では、社内伝票会員の使用申し込みはできません。\n福山通運の営業本部へお問い合わせ下さい。"
						, "入力チェック"
						, MessageBoxButtons.OK);
					texお客様コード.Focus();
					return(false);
				}
				if(tex部門コード.Text.Substring(0,2) == "FK")
				{
					MessageBox.Show("管理者以外の権限では、社内伝票会員の使用申し込みはできません。\n福山通運の営業本部へお問い合わせ下さい。"
						, "入力チェック"
						, MessageBoxButtons.OK);
					tex部門コード.Focus();
					return(false);
				}
			}
// MOD 2016.04.13 BEVAS）松本 社内伝票対応 END

			texメッセージ.Text = btn登録.Text + "中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			return(true);
		}

		private void btn削除_Click(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";
			tex受付ＮＯ.Text = tex受付ＮＯ.Text.Trim();
// MOD 2007.01.19 東都）高木 文言の変更 START
			if(!必須チェック(tex受付ＮＯ, "受付ＮＯ")) return;
			if(!半角チェック(tex受付ＮＯ, "受付ＮＯ")) return;
// MOD 2007.01.19 東都）高木 文言の変更 END

			tex受付ＮＯ.Text = tex受付ＮＯ.Text.PadLeft(7,'0');

			texメッセージ.Text = "削除中．．．";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[4];
				sKey[0] = tex受付ＮＯ.Text.Trim();
				sKey[1] = s申込更新日時;
				sKey[2] = gs利用者コード;

				string[] sList = sv_maintenance.Del_Mosikomi(gsaユーザ, sKey);
				texメッセージ.Text = sList[0];
				if (sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = "";
					登録モード();
// MOD 2006.11.30 東都）高木 画面の調整 START
//					tex受付ＮＯ.Focus();
					tex申込者名.Text = " ";
					tex申込者名.Focus();
// MOD 2006.11.30 東都）高木 画面の調整 END
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
					if(gs店所コード.Trim().Length == 0) tex受付ＮＯ.Focus();
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END
				}
				else
				{
					ビープ音();
				}
				tex受付ＮＯ.Focus();
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
//				初期モード();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private bool 会員存在チェック()
		{
			bool Bret = false;
			try
			{
				string[] sKey  = new string[1]{""};
				sKey[0] = texお客様コード.Text.Trim();
				string[] sList = sv_maintenance.Sel_Member(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了"))
				{
					texお客様コード.Focus();
					texメッセージ.Text = "入力されたお客様コードは既に登録されています";
					ビープ音();
				}
				else
				{
					if (sList[0].Equals("該当データがありません"))
					{
						Bret = true;
						texメッセージ.Text = "";
					}
					else
					{
						texお客様コード.Focus();
						texメッセージ.Text = sList[0];
						ビープ音();
					}
				}
			}
			catch (Exception ex)
			{
				texお客様コード.Focus();
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			return Bret;
		}

		private bool ユーザー存在チェック()
		{
			bool Bret = false;
			try
			{
				string[] sKey  = new string[2];
				sKey[0] = texお客様コード.Text.Trim();
				sKey[1] = texユーザーコード.Text.Trim();
				string[] sList = sv_maintenance.Sel_User(gsaユーザ, sKey);

				if (sList[0].Equals("正常終了"))
				{
					texユーザーコード.Focus();
					texメッセージ.Text = "入力されたユーザーは既に登録されています";
					ビープ音();
				}
				else
				{
					if (sList[0].Equals("該当データがありません"))
					{
						Bret = true;
						texメッセージ.Text = "";
					}
					else
					{
						texユーザーコード.Focus();
						texメッセージ.Text = sList[0];
						ビープ音();
					}
				}
			}
			catch (Exception ex)
			{
				texユーザーコード.Focus();
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
			return Bret;
		}

		private void クリア()
		{
			tex受付ＮＯ.Text = " ";
			lab申請中.Text = "";

			tex申込者カナ.Text = "";
			tex申込者名.Text = "";
			tex申込者郵便１.Text = "";
			tex申込者郵便２.Text = "";
//			cb申込者県.Text = "";
			cb申込者県.SelectedIndex = 0;
			tex申込者住所１.Text = "";
			tex申込者住所２.Text = "";
			tex申込者電話１.Text = "";
			tex申込者電話２.Text = "";
			tex申込者電話３.Text = "";
			tex申込者ＦＡＸ１.Text = "";
			tex申込者ＦＡＸ２.Text = "";
			tex申込者ＦＡＸ３.Text = "";

			chb設置場所.Checked = false;
			tex設置場所カナ.Text = "";
			tex設置場所名.Text = "";
			tex設置場所郵便１.Text = "";
			tex設置場所郵便２.Text = "";
			tex管理店所名.Text = "";
//			cb設置場所県.Text = "";
			cb設置場所県.SelectedIndex = 0;
			tex設置場所住所１.Text = "";
			tex設置場所住所２.Text = "";
			tex設置場所電話１.Text = "";
			tex設置場所電話２.Text = "";
			tex設置場所電話３.Text = "";
			tex設置場所ＦＡＸ１.Text = "";
			tex設置場所ＦＡＸ２.Text = "";
			tex設置場所ＦＡＸ３.Text = "";
			tex設置場所担当者名.Text = "";
			tex設置場所役職名.Text = "";
			tex設置場所使用料.Text = "";

			texお客様コード.Text = "";
			dtp使用開始日.Value = DateTime.Now;
			tex部門コード.Text = "";
			tex部門名.Text = "";
			numサーマル台数.Value = 1;
// ADD 2006.11.06 東都）高木 支店登録画面の追加 START
			numサーマル台数.Text = "1";
// ADD 2006.11.06 東都）高木 支店登録画面の追加 END
			texユーザーコード.Text = "";
			texユーザー名.Text = "";
			tex初期パスワード.Text = "";
			rb登録中.Checked = true;
			texメモ.Text = "";
		}

		private void 桁数表示()
		{
			tex受付ＮＯ.Text = "数字7桁（連番）";
			lab申請中.Text = "申請中";

			tex申込者カナ.Text = "全角20";
			tex申込者名.Text = "全角20";
			tex申込者郵便１.Text = "123";
			tex申込者郵便２.Text = "4567";
			cb申込者県.Text = "全角4";
			tex申込者住所１.Text = "全角16";
			tex申込者住所２.Text = "全角20";
			tex申込者電話１.Text = "123456";
			tex申込者電話２.Text = "1234";
			tex申込者電話３.Text = "1234";
			tex申込者ＦＡＸ１.Text = "123456";
			tex申込者ＦＡＸ２.Text = "1234";
			tex申込者ＦＡＸ３.Text = "1234";

			chb設置場所.Checked = false;
			tex設置場所カナ.Text = "全角20";
			tex設置場所名.Text = "全角20";
			tex設置場所郵便１.Text = "123";
			tex設置場所郵便２.Text = "4567";
			tex管理店所名.Text = "○○支店";
			cb設置場所県.Text = "全角4";
			tex設置場所住所１.Text = "全角16";
			tex設置場所住所２.Text = "全角20";
			tex設置場所電話１.Text = "123456";
			tex設置場所電話２.Text = "1234";
			tex設置場所電話３.Text = "1234";
			tex設置場所ＦＡＸ１.Text = "123456";
			tex設置場所ＦＡＸ２.Text = "1234";
			tex設置場所ＦＡＸ３.Text = "1234";
			tex設置場所担当者名.Text = "全角10";
			tex設置場所役職名.Text = "全角10";
			tex設置場所使用料.Text = "12,345";

			texお客様コード.Text = "半角10";
			dtp使用開始日.Value = DateTime.Now;
			tex部門コード.Text = "半角12";
			tex部門名.Text = "全角20";
			numサーマル台数.Value = 1;
			texユーザーコード.Text = "半角6";
			texユーザー名.Text = "全角20";
			tex初期パスワード.Text = "半角10";
			rb登録中.Checked = true;
			texメモ.Text = "全角10";
		}

		private void btn取消_Click(object sender, System.EventArgs e)
		{
//			桁数表示();
			登録モード();
// MOD 2006.11.30 東都）高木 画面の調整 START
//			tex受付ＮＯ.Focus();
			tex申込者名.Text = " ";
			tex申込者名.Focus();
// MOD 2006.11.30 東都）高木 画面の調整 END
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
			if(gs店所コード.Trim().Length == 0) tex受付ＮＯ.Focus();
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END
		}

		private void tex申込者郵便２_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				if(tex申込者郵便１.Text.Length == 3 && tex申込者郵便２.Text.Length == 4)
					郵便検索(tex申込者郵便１, tex申込者郵便２, 
						cb申込者県, tex申込者住所１, tex申込者住所２, null);
				else{
					郵便一覧(tex申込者郵便１, tex申込者郵便２, 
						cb申込者県, tex申込者住所１, tex申込者住所２, null);
				}
			}
		}

		private void tex申込者郵便２_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn申込者郵便.Focus();
				郵便一覧(tex申込者郵便１, tex申込者郵便２, 
					cb申込者県, tex申込者住所１, tex申込者住所２, null);
				e.Handled = true;
			}
		}

		private void btn申込者郵便_Click(object sender, System.EventArgs e)
		{
			郵便一覧(tex申込者郵便１, tex申込者郵便２, 
				cb申込者県, tex申込者住所１, tex申込者住所２, null);
		}

		private void tex設置場所郵便２_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				if(tex設置場所郵便１.Text.Length == 3 && tex設置場所郵便２.Text.Length == 4)
					郵便検索(tex設置場所郵便１, tex設置場所郵便２, 
						cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex管理店所名);
				else{
					郵便一覧(tex設置場所郵便１, tex設置場所郵便２, 
						cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex管理店所名);
				}
			}
		}

		private void btn設置場所郵便_Click(object sender, System.EventArgs e)
		{
			郵便一覧(tex設置場所郵便１, tex設置場所郵便２, 
						cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex管理店所名);
		}

		private void tex設置場所郵便２_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn設置場所郵便.Focus();
				郵便一覧(tex設置場所郵便１, tex設置場所郵便２, 
					cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex管理店所名);
				e.Handled = true;
			}
		}

// DEL 2006.11.06 東都）高木 支店登録画面の追加 START
//		private void 県設定(string s住所, ComboBox cb県, TextBox tex住所１)
//		{
//			//都道府県ハッシュテーブルの作成
//			if(h県 == null)
//			{
//				h県 = new Hashtable();
//				for(int iCnt = 1; iCnt < sa県.Length; iCnt++)
//				{
//					h県.Add(sa県[iCnt], iCnt);
//				}
//			}
//
//			if(s住所.Length >= 3)
//			{
//				//都道府県ＣＤの取得
//				string s編集中     = "";
//				int    iIndex      = 0;
//				// 「神奈川県」、「和歌山県」、「鹿児島県」は４文字で分解し比較する
//				if((s住所[0] == '神' || s住所[0] == '和' || s住所[0] == '鹿')
//					&& s住所.Length >= 4 
//					&& s住所[3] == '県')
//				{
//					s編集中 = s住所.Substring(0,4);
//					iIndex  = 4;
//				}
//				else
//				{
//					s編集中 = s住所.Substring(0,3);
//					iIndex  = 3;
//				}
//				Object obj = h県[s編集中];
//				if(obj != null)
//				{
//					cb県.SelectedIndex = (int)obj;
//					s住所 = s住所.Remove(0,iIndex);
//					tex住所１.Text = s住所;
//				}
//			}
//		}
// DEL 2006.11.06 東都）高木 支店登録画面の追加 END

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
			g住所検索.sお客様ＣＤ = texお客様コード.Text.Trim();
			if (texお客様コード.Text.Trim() == "" )
			{
				//店コードより管理者区分を検索
				String[] sList;
				string[] sKey2  = new string[1];
				sKey2[0] = gs店所コード;
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
					郵便検索(tex設置場所郵便１, tex設置場所郵便２, 
						cb設置場所県, tex設置場所住所１, tex設置場所住所２, tex店所名);
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
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				sKey[0] = tex郵便番号１.Text + tex郵便番号２.Text;
//				string[] sList = sv_maintenance.Sel_Postcode1(gsaユーザ, sKey);
				String[] sList;
				string sお客様コード = "";
				sお客様コード = texお客様コード.Text;
				if (sお客様コード.Trim() == "") 
				{
					if(gs店所コード.Trim().Length != 0)
					{
						sKey[0] = gs店所コード;
						sList = sv_oji.Sel_Member(gsaユーザ, sKey);

						if (sList[0].Equals("正常終了"))
						{
							if ((sList[4] == "3") || (sList[4] == "4"))
							{
								sお客様コード = "J";
							}
						}
					}
				}

				sKey[0] = tex郵便番号１.Text + tex郵便番号２.Text;
				if ((sお客様コード == "") || (sお客様コード.Substring(0,1) != "J"))
				{
					sList = sv_maintenance.Sel_Postcode1(gsaユーザ, sKey);
				}
				else
				{
					sList = sv_oji.Sel_Postcode1(gsaユーザ, sKey);
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
					s店所コード = sList[4].Trim();
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

		private string パスワード発行()
		{
// MOD 2005.06.08 東都）小童谷 大文字なし START
//			const string s文字 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
//			const string s文字 = "0123456789abcdefghijklmnopqrstuvwxyz";
// MOD 2005.06.08 東都）小童谷 大文字なし END
			// lと1、0とoは除外する
			const string s文字 = "23456789abcdefghijkmnpqrstuvwxyz";
			string sパスワード = "";

			Random rdm = new Random();
			int i乱数 = rdm.Next(0,s文字.Length - 1);
			for(int iCnt = 0; iCnt < 6; iCnt++)
			{
				i乱数 = rdm.Next(0,s文字.Length);
				sパスワード += s文字[i乱数];
			}
			return sパスワード;
		}

		private void 会員加入_Closed(object sender, System.EventArgs e)
		{
			クリア();
			texメッセージ.Text = "";
			tex受付ＮＯ.Text = " ";
// MOD 2006.11.30 東都）高木 画面の調整 START
//			tex受付ＮＯ.Focus();
			tex申込者名.Text = " ";
			tex申込者名.Focus();
// MOD 2006.11.30 東都）高木 画面の調整 END
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
			if(gs店所コード.Trim().Length == 0) tex受付ＮＯ.Focus();
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END
		}

		private void btn自動発行_Click(object sender, System.EventArgs e)
		{
			// パスワードのクリア
			tex初期パスワード.Text = "";
			tex初期パスワード.Text = パスワード発行();
		}

		private void btnお客様コード_Click(object sender, System.EventArgs e)
		{
			会員情報一覧();
		}

		private void 会員情報一覧()
		{
			texお客様コード.Text = texお客様コード.Text.Trim();
//			if(!半角チェック(texお客様コード, "会員コード")) return;

			// 検索画面を右側に表示する
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g会員検索 == null)	 g会員検索 = new 会員検索();
			g会員検索.Left = this.Left;
			g会員検索.Top = this.Top;

			// コードの初期表示
			g会員検索.s会員コード = "";
			g会員検索.s会員名 = "";
//保留 MOD 2007.01.19 東都）高木 画面レイアウト変更もれ START
			g会員検索.ShowDialog();
//保留 他店の会員も選択および表示できるようにする？（顧客確認が必要）
//			g会員検索.s店所コード = gs店所コード.Trim();
//			g会員検索.ShowDialog();
//			g会員検索.s店所コード = "";
//保留 MOD 2007.01.19 東都）高木 画面レイアウト変更もれ END
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g会員検索.s会員コード.Trim().Length > 0)
			{
				texお客様コード.Text = g会員検索.s会員コード.Trim();
			}
			else
			{
				texお客様コード.Focus();
			}
		}

		private void 設置場所入力制御(CheckBox chbObj, Control texObj1, Control texObj2)
		{
			if (chbObj.Checked)
			{
				texObj1.Text = texObj2.Text.Trim();
				texObj1.Enabled = false;
			}
			else
			{
				//texObj1.Text = "";
				texObj1.Enabled = true;
			}
		}

		private void 設置場所入力制御ＡＬＬ()
		{
			設置場所入力制御(chb設置場所, tex設置場所カナ, tex申込者カナ);
			設置場所入力制御(chb設置場所, tex設置場所名, tex申込者名);
			設置場所入力制御(chb設置場所, tex設置場所郵便１, tex申込者郵便１);
			設置場所入力制御(chb設置場所, tex設置場所郵便２, tex申込者郵便２);
// ADD 2007.01.20 東都）高木 画面調整 START
			設置場所入力制御(chb設置場所, tex設置場所郵便２, tex申込者郵便２);
			if (chb設置場所.Checked)
			{
				btn設置場所郵便.Enabled = false;
				tex管理店所名.Text = "";
			}
			else
			{
				btn設置場所郵便.Enabled = true;
			}
// ADD 2007.01.20 東都）高木 画面調整 END
			設置場所入力制御(chb設置場所, cb設置場所県, cb申込者県);
			設置場所入力制御(chb設置場所, tex設置場所住所１, tex申込者住所１);
			設置場所入力制御(chb設置場所, tex設置場所住所２, tex申込者住所２);
			設置場所入力制御(chb設置場所, tex設置場所電話１, tex申込者電話１);
			設置場所入力制御(chb設置場所, tex設置場所電話２, tex申込者電話２);
			設置場所入力制御(chb設置場所, tex設置場所電話３, tex申込者電話３);
			設置場所入力制御(chb設置場所, tex設置場所ＦＡＸ１, tex申込者ＦＡＸ１);
			設置場所入力制御(chb設置場所, tex設置場所ＦＡＸ２, tex申込者ＦＡＸ２);
			設置場所入力制御(chb設置場所, tex設置場所ＦＡＸ３, tex申込者ＦＡＸ３);
		}

		private void chb設置場所_CheckedChanged(object sender, System.EventArgs e)
		{
			設置場所入力制御ＡＬＬ();
		}

		private void 会員加入_Activated(object sender, System.EventArgs e)
		{
// MOD 2006.11.30 東都）高木 画面の調整 START
//			tex受付ＮＯ.Focus();
			if(tex受付ＮＯ.Text.Trim().Length > 0) return;
			if(tex申込者名.Text.Trim().Length > 0) return;
			tex申込者名.Text = " ";
			tex申込者名.Focus();
// MOD 2006.11.30 東都）高木 画面の調整 END
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
			if(gs店所コード.Trim().Length == 0) tex受付ＮＯ.Focus();
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END
		}

		private void btn契約書_Click(object sender, System.EventArgs e)
		{
// MOD 2006.12.01 東都）高木 契約書印刷の調整 START
			rb申請中.Checked = true;
// MOD 2006.12.01 東都）高木 契約書印刷の調整 END

			if(登録更新処理() != true) return;

// ADD 2006.12.14 東都）小童谷 再検索 START
			申込情報検索();
// ADD 2006.12.14 東都）小童谷 再検索 END

// ADD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
			texメッセージ.Text = "契約書編集中...";
// ADD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			string[] sList;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = s店所コード;
				sList = sv_maintenance.Get_ShopInf(gsaユーザ, sKey);
				if (!sList[0].Equals("正常終了"))
				{
					texメッセージ.Text = sList[0];
					ビープ音();
					return;
				}
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				//				初期モード();
				return;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;

			// まずはデータセットのインスタンスを生成
			契約書データ ds = new 契約書データ();

			for( int i=0 ; i < 2;i++)
			{
				契約書データ.table契約書Row tr = (契約書データ.table契約書Row)ds.table契約書.NewRow();
				tr.BeginEdit();
// ADD 2006.11.09 東都）高木 契約書印刷の調整 START
				if(tex申込者郵便１.Text.Trim().Length == 0)
					tr.申込者郵便番号 = "　　　-" + tex申込者郵便２.Text.Trim();
				else
// ADD 2006.11.09 東都）高木 契約書印刷の調整 END
					tr.申込者郵便番号 = tex申込者郵便１.Text.Trim() + '-' + tex申込者郵便２.Text.Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 START
//				tr.申込者住所県 = cb申込者県.Text.Trim();
//				tr.申込者住所１ = tex申込者住所１.Text.Trim();
				tr.申込者住所県 = cb申込者県.Text.Trim() + ' ' + tex申込者住所１.Text.Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 END
				tr.申込者住所２ = tex申込者住所２.Text.Trim();
				tr.申込者名フリガナ = tex申込者カナ.Text.Trim();
				tr.申込者名     = tex申込者名.Text.Trim();
				if(tex申込者電話１.Text.Length == 0)
					tex申込者電話１.Text = "　　　　　";
				if(tex申込者電話２.Text.Length == 0)
					tex申込者電話２.Text = "　　　　　";
				if(tex申込者電話３.Text.Length == 0)
					tex申込者電話３.Text = "　　　　　";
				tr.申込者電話番号   = '(' + tex申込者電話１.Text + ')' + tex申込者電話２.Text + '-'  + tex申込者電話３.Text;
				if(tex申込者ＦＡＸ１.Text.Length == 0)
					tex申込者ＦＡＸ１.Text = "　　　　　";
				if(tex申込者ＦＡＸ２.Text.Length == 0)
					tex申込者ＦＡＸ２.Text = "　　　　　";
				if(tex申込者ＦＡＸ３.Text.Length == 0)
					tex申込者ＦＡＸ３.Text = "　　　　　";
				tr.申込者ＦＡＸ番号 = '(' + tex申込者ＦＡＸ１.Text + ')' + tex申込者ＦＡＸ２.Text + '-'  + tex申込者ＦＡＸ３.Text;
// MOD 2006.11.09 東都）高木 契約書印刷の調整 START
//				tr.受店所郵便番号 = sList[5].Trim();
				string s受店所郵便 = sList[5].Trim();
				if(s受店所郵便.Length >= 4){
					tr.受店所郵便番号 = s受店所郵便.Substring(0,3) + '-' + s受店所郵便.Substring(3);
				}else{
					tr.受店所郵便番号 = s受店所郵便;
				}
// MOD 2006.11.09 東都）高木 契約書印刷の調整 END
				if(sList[2].Trim().Length != 0)
				{
// MOD 2006.11.09 東都）高木 契約書印刷の調整 START
//					tr.受店所住所県   = sList[2].Trim();
//					tr.受店所住所１   = sList[3].Trim();
					tr.受店所住所県   = sList[2].Trim();
					int i受店所県 = int.Parse(sList[2].Trim());
					if(i受店所県 > 0 && i受店所県 < sa県.Length)
						tr.受店所住所県 = sa県[i受店所県];
					tr.受店所住所県 += ' ' + sList[3].Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 END
					tr.受店所住所２   = sList[4].Trim();
				}
				else
				{
					if(sList[3].Trim().Length != 0)
					{
						tr.受店所住所県   = sList[3].Trim();
						tr.受店所住所１   = sList[4].Trim();
						tr.受店所住所２   = "";
					}
					else
					{
						tr.受店所住所県   = sList[4].Trim();
						tr.受店所住所１   = "";
						tr.受店所住所２   = "";
					}
				}

				tr.受店所名       = sList[1].Trim();
				tr.受店所電話番号   = sList[6].Trim();
// ADD 2006.11.09 東都）高木 契約書印刷の調整 START
				string[] s受店所電話 = sList[6].Trim().Split('-');
				if(s受店所電話.Length == 3)
					tr.受店所電話番号 = '(' + s受店所電話[0] + ')' + s受店所電話[1] + '-' + s受店所電話[2];
// ADD 2006.11.09 東都）高木 契約書印刷の調整 END
				tr.受店所ＦＡＸ番号 = sList[7].Trim();
// ADD 2006.11.09 東都）高木 契約書印刷の調整 START
				string[] s受店所ＦＡＸ = sList[7].Trim().Split('-');
				if(s受店所ＦＡＸ.Length == 3)
					tr.受店所ＦＡＸ番号 = '(' + s受店所ＦＡＸ[0] + ')' + s受店所ＦＡＸ[1] + '-' + s受店所ＦＡＸ[2];
// ADD 2006.11.09 東都）高木 契約書印刷の調整 END
				tr.設置場所郵便番号 = tex設置場所郵便１.Text.Trim() + '-' + tex設置場所郵便２.Text.Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 START
//				tr.設置場所住所県 = cb申込者県.Text.Trim();
//				tr.設置場所住所１ = tex設置場所住所１.Text.Trim();
				tr.設置場所住所県 = cb設置場所県.Text.Trim() + ' ' + tex設置場所住所１.Text.Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 END
				tr.設置場所住所２ = tex設置場所住所２.Text.Trim();
				tr.設置場所法人名フリガナ = tex設置場所カナ.Text.Trim();
				tr.設置場所法人名 = tex設置場所名.Text.Trim();
// DEL 2006.12.13 東都）小童谷 削除 START
//				tr.設置場所担当者役職 = tex設置場所役職名.Text.Trim();
// DEL 2006.12.13 東都）小童谷 削除 END
				tr.設置場所担当者名 = tex設置場所担当者名.Text.Trim();
				if(tex設置場所電話１.Text.Length == 0)
					tex設置場所電話１.Text = "　　　　　";
				if(tex設置場所電話２.Text.Length == 0)
					tex設置場所電話２.Text = "　　　　　";
				if(tex設置場所電話３.Text.Length == 0)
					tex設置場所電話３.Text = "　　　　　";
				tr.設置場所電話番号 = '(' + tex設置場所電話１.Text + ')' + tex設置場所電話２.Text + '-'  + tex設置場所電話３.Text;
				if(tex設置場所ＦＡＸ１.Text.Length == 0)
					tex設置場所ＦＡＸ１.Text = "　　　　　";
				if(tex設置場所ＦＡＸ２.Text.Length == 0)
					tex設置場所ＦＡＸ２.Text = "　　　　　";
				if(tex設置場所ＦＡＸ３.Text.Length == 0)
					tex設置場所ＦＡＸ３.Text = "　　　　　";
				tr.設置場所ＦＡＸ番号= '(' + tex設置場所ＦＡＸ１.Text + ')' + tex設置場所ＦＡＸ２.Text + '-'  + tex設置場所ＦＡＸ３.Text;
				if(i == 0)
// MOD 2006.12.11 FJCS)桑田 見出し変更 START
// MOD 2006.11.29 FJCS)桑田 見出し変更 START
//					tr.頁見出し = "①福山通運（控）";
//					tr.頁見出し = "①福山通運申し込み店控え";
// MOD 2011.06.21 東都）高木 王子運送対応 START
//					tr.頁見出し = "①福山通運申し込み店（控）";
					if ((texお客様コード.Text == "") || (texお客様コード.Text.Substring(0,1) != "J")){
						tr.頁見出し = "①福山通運申し込み店（控）";
					}else{
						tr.頁見出し = "①王子運送申し込み店（控）";
					}
// MOD 2011.06.21 東都）高木 王子運送対応 END
// MOD 2006.11.29 FJCS)桑田 見出し変更 END
// MOD 2006.12.11 FJCS)桑田 見出し変更 END
				else
					tr.頁見出し = "②お客様（控）";
				tr.EndEdit();
				// 最後にデータセットに追加する
				ds.table契約書.Rows.Add(tr);
			}

// MOD 2011.06.21 東都）高木 王子運送対応 START
//			契約書レポート cr = new 契約書レポート();
			ReportClass cr = null;
			if ((texお客様コード.Text == "") || (texお客様コード.Text.Substring(0,1) != "J")){
				cr = new 契約書レポート();
			}else{
				cr = new 契約書レポート_王子運送();
			}
// MOD 2011.06.21 東都）高木 王子運送対応 END
			//CrystalReportにパラメータとデータセットを渡す
			cr.SetDataSource(ds);

// ADD 2006.12.06 東都）高木 用紙および余白設定の追加 START
			// 用紙および余白設定
			// （開発系では、left 288、top 288、right 288、bottom 279）
			cr.PrintOptions.PaperSize
				= CrystalDecisions.Shared.PaperSize.PaperA4;
			CrystalDecisions.Shared.PageMargins margins 
				= new CrystalDecisions.Shared.PageMargins(576,576,0,0);
			cr.PrintOptions.ApplyPageMargins(margins);
// ADD 2006.12.06 東都）高木 用紙および余白設定の追加 END

// ADD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
			texメッセージ.Text = "";
// ADD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END

			//プレビュー表示
// MOD 2007.02.06 東都）高木 プレビュー画面の高速化 START
//			プレビュー画面 画面 = new プレビュー画面();
//			画面.Left = this.Left;
//			画面.Top = this.Top;
//			画面.crv帳票.PrintReport();
//			画面.crv帳票.ReportSource = cr;
//			lab申請中.Text = "申請中";
//			rb申請中.Checked = true;
//			画面.ShowDialog();
			if(gプレビュ == null) gプレビュ = new プレビュー画面();
			gプレビュ.Left = this.Left;
			gプレビュ.Top = this.Top;
//			gプレビュ.crv帳票.PrintReport();
			gプレビュ.crv帳票.ReportSource = cr;
			lab申請中.Text = "申請中";
			rb申請中.Checked = true;
			gプレビュ.ShowDialog();
// MOD 2007.02.06 東都）高木 プレビュー画面の高速化 END

// ADD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
			申込書印刷();
// ADD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END
		}

// MOD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
//		private void btn申込書_Click(object sender, System.EventArgs e)
//		{
//// MOD 2006.12.01 東都）高木 契約書印刷の調整 START
//			rb申請中.Checked = true;
//// MOD 2006.12.01 東都）高木 契約書印刷の調整 END
//			if(登録更新処理() != true) return;
//
//// ADD 2006.12.14 東都）小童谷 再検索 START
//			申込情報検索();
//// ADD 2006.12.14 東都）小童谷 再検索 END
		private void 申込書印刷()
		{
// MOD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END
			texメッセージ.Text = "使用申込書編集中...";

			// まずはデータセットのインスタンスを生成
			契約書データ ds = new 契約書データ();

			契約書データ.table契約書Row tr = (契約書データ.table契約書Row)ds.table契約書.NewRow();
			tr.BeginEdit();
// ADD 2006.11.09 東都）高木 契約書印刷の調整 START
			if(tex申込者郵便１.Text.Trim().Length == 0)
				tr.申込者郵便番号 = "　　　-" + tex申込者郵便２.Text.Trim();
			else
// ADD 2006.11.09 東都）高木 契約書印刷の調整 END
				tr.申込者郵便番号 = tex申込者郵便１.Text.Trim() + '-' + tex申込者郵便２.Text.Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 START
//			tr.申込者住所県 = cb申込者県.Text.Trim();
//			tr.申込者住所１ = tex申込者住所１.Text.Trim();
			tr.申込者住所県 = cb申込者県.Text.Trim() + ' ' + tex申込者住所１.Text.Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 END
			tr.申込者住所２ = tex申込者住所２.Text.Trim();
			tr.申込者名フリガナ = tex申込者カナ.Text.Trim();
			tr.申込者名     = tex申込者名.Text.Trim();
			if(tex申込者電話１.Text.Length == 0)
				tex申込者電話１.Text = "　　　　　";
			if(tex申込者電話２.Text.Length == 0)
				tex申込者電話２.Text = "　　　　　";
			if(tex申込者電話３.Text.Length == 0)
				tex申込者電話３.Text = "　　　　　";
			tr.申込者電話番号   = '(' + tex申込者電話１.Text + ')' + tex申込者電話２.Text + '-'  + tex申込者電話３.Text;
			if(tex申込者ＦＡＸ１.Text.Length == 0)
				tex申込者ＦＡＸ１.Text = "　　　　　";
			if(tex申込者ＦＡＸ２.Text.Length == 0)
				tex申込者ＦＡＸ２.Text = "　　　　　";
			if(tex申込者ＦＡＸ３.Text.Length == 0)
				tex申込者ＦＡＸ３.Text = "　　　　　";
			tr.申込者ＦＡＸ番号 = '(' + tex申込者ＦＡＸ１.Text + ')' + tex申込者ＦＡＸ２.Text + '-'  + tex申込者ＦＡＸ３.Text;
			tr.設置場所郵便番号 = tex設置場所郵便１.Text.Trim() + '-' + tex設置場所郵便２.Text.Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 START
//			tr.設置場所住所県 = cb申込者県.Text.Trim();
//			tr.設置場所住所１ = tex設置場所住所１.Text.Trim();
			tr.設置場所住所県 = cb設置場所県.Text.Trim() + ' ' + tex設置場所住所１.Text.Trim();
// MOD 2006.11.09 東都）高木 契約書印刷の調整 END
			tr.設置場所住所２ = tex設置場所住所２.Text.Trim();
			tr.設置場所法人名フリガナ = tex設置場所カナ.Text.Trim();
			tr.設置場所法人名 = tex設置場所名.Text.Trim();
// DEL 2007.01.19 東都）高木 削除 START
//			tr.設置場所担当者役職 = tex設置場所役職名.Text.Trim();
// DEL 2007.01.19 東都）高木 削除 END
			tr.設置場所担当者名 = tex設置場所担当者名.Text.Trim();
			if(tex設置場所電話１.Text.Length == 0)
				tex設置場所電話１.Text = "　　　　　";
			if(tex設置場所電話２.Text.Length == 0)
				tex設置場所電話２.Text = "　　　　　";
			if(tex設置場所電話３.Text.Length == 0)
				tex設置場所電話３.Text = "　　　　　";
			tr.設置場所電話番号 = '(' + tex設置場所電話１.Text + ')' + tex設置場所電話２.Text + '-'  + tex設置場所電話３.Text;
			if(tex設置場所ＦＡＸ１.Text.Length == 0)
				tex設置場所ＦＡＸ１.Text = "　　　　　";
			if(tex設置場所ＦＡＸ２.Text.Length == 0)
				tex設置場所ＦＡＸ２.Text = "　　　　　";
			if(tex設置場所ＦＡＸ３.Text.Length == 0)
				tex設置場所ＦＡＸ３.Text = "　　　　　";
			tr.設置場所ＦＡＸ番号= '(' + tex設置場所ＦＡＸ１.Text + ')' + tex設置場所ＦＡＸ２.Text + '-'  + tex設置場所ＦＡＸ３.Text;
// ADD 2006.11.30 FJCS）桑田 申込管理番号の追加 START
			tr.申込管理番号 = tex受付ＮＯ.Text.Trim();
			tr.申込管理番号バーコード = 'a' + tex受付ＮＯ.Text.Trim() + 'a';
// ADD 2006.11.30 FJCS）桑田 申込管理番号の追加 END
			tr.EndEdit();
			// 最後にデータセットに追加する
			ds.table契約書.Rows.Add(tr);

// MOD 2011.06.21 東都）高木 王子運送対応 START
//			使用書レポート cr = new 使用書レポート();
			ReportClass cr = null;
			if ((texお客様コード.Text == "") || (texお客様コード.Text.Substring(0,1) != "J")){
				cr = new 使用書レポート();
			}else{
				cr = new 使用書レポート_王子運送();
			}
// MOD 2011.06.21 東都）高木 王子運送対応 END
			//CrystalReportにパラメータとデータセットを渡す
			cr.SetDataSource(ds);

// ADD 2006.12.06 東都）高木 用紙および余白設定の追加 START
			// 用紙および余白設定
			// （開発系では、left 288、top 288、right 288、bottom 279）
			cr.PrintOptions.PaperSize
				= CrystalDecisions.Shared.PaperSize.PaperA4;
			CrystalDecisions.Shared.PageMargins margins 
				= new CrystalDecisions.Shared.PageMargins(576,576,0,0);
			cr.PrintOptions.ApplyPageMargins(margins);
// ADD 2006.12.06 東都）高木 用紙および余白設定の追加 END

// ADD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
			texメッセージ.Text = "";
// ADD 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END

			//プレビュー表示
			プレビュー画面 画面 = new プレビュー画面();
			画面.Left = this.Left;
			画面.Top = this.Top;
			画面.crv帳票.PrintReport();
			画面.crv帳票.ReportSource = cr;
			lab申請中.Text = "申請中";
			rb申請中.Checked = true;
			画面.ShowDialog();
		}

		private bool 登録更新処理()
		{

			if(登録_チェック() != true) return(false);
			try
			{
				string[] sData  = new string[43];
				//受付ＮＯ情報
				sData[0] = tex受付ＮＯ.Text.Trim();
				sData[1] = s店所コード;
				//申込者情報
				sData[2] = tex申込者カナ.Text;
				sData[3] = tex申込者名.Text;
				sData[4] = tex申込者郵便１.Text + tex申込者郵便２.Text;
				sData[5] = cb申込者県.SelectedIndex.ToString("00");
				sData[6] = tex申込者住所１.Text;
				sData[7] = tex申込者住所２.Text;
				sData[8] = tex申込者電話１.Text;
				sData[9] = tex申込者電話２.Text;
				sData[10] = tex申込者電話３.Text;
				sData[11] = tex申込者電話１.Text + tex申込者電話２.Text + tex申込者電話３.Text;
				sData[12] = tex申込者ＦＡＸ１.Text;
				sData[13] = tex申込者ＦＡＸ２.Text;
				sData[14] = tex申込者ＦＡＸ３.Text;
				//設置場所情報
				if(chb設置場所.Checked)
					sData[15] = "1";
				else
					sData[15] = " ";
				//				設置場所入力制御ＡＬＬ();
				sData[16] = tex設置場所カナ.Text;
				sData[17] = tex設置場所名.Text;
				sData[18] = tex設置場所郵便１.Text + tex設置場所郵便２.Text;
				sData[19] = cb設置場所県.SelectedIndex.ToString("00");
				sData[20] = tex設置場所住所１.Text;
				sData[21] = tex設置場所住所２.Text;
				sData[22] = tex設置場所電話１.Text;
				sData[23] = tex設置場所電話２.Text;
				sData[24] = tex設置場所電話３.Text;
				sData[25] = tex設置場所ＦＡＸ１.Text;
				sData[26] = tex設置場所ＦＡＸ２.Text;
				sData[27] = tex設置場所ＦＡＸ３.Text;
				sData[28] = tex設置場所担当者名.Text;
				sData[29] = tex設置場所役職名.Text;
				sData[30] = tex設置場所使用料.Text.Replace(",","");
				//システム情報
				sData[31] = texお客様コード.Text;
				sData[32] = dtp使用開始日.Value.Year.ToString() 
					+ dtp使用開始日.Value.Month.ToString().PadLeft(2, '0') 
					+ dtp使用開始日.Value.Day.ToString().PadLeft(2, '0');
				sData[33] = tex部門コード.Text;
				sData[34] = tex部門名.Text;
				sData[35] = numサーマル台数.Value.ToString();
				sData[36] = texユーザーコード.Text;
				sData[37] = texユーザー名.Text;
				sData[38] = tex初期パスワード.Text;
				//承認状態情報
				if(rb登録中.Checked) sData[39] = " ";
				else if(rb申請中.Checked) sData[39] = "1";
				else if(rb留保中.Checked) sData[39] = "2";
				else if(rb承認済.Checked) sData[39] = "3";
				else sData[39] = " ";
				sData[40] = texメモ.Text;
				//更新情報
				sData[41] = s申込更新日時;
				sData[42] = gs利用者コード;

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};
				if (btn登録.Text.Equals("登録"))
				{
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					if ((texお客様コード.Text == "") || (texお客様コード.Text.Substring(0,1) != "J"))
					{
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

						sList = sv_maintenance.Ins_Mosikomi(gsaユーザ, sData);

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
					}
					else
					{
						sList = sv_oji.Ins_Mosikomi(gsaユーザ, sData);
					}
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
					
					texメッセージ.Text = sList[0];
					if (sList[0].Equals("正常終了"))
					{
						texメッセージ.Text = "";
						if(sList.Length >= 2 && sList[2] != null)
							tex受付ＮＯ.Text = sList[2].Trim();
					}
					else
					{
						if(sList.Length >= 2 && sList[2] != null)
							tex受付ＮＯ.Text = sList[2].Trim();
						ビープ音();
						return(false);
					}
				}
				else
				{
					sList = sv_maintenance.Upd_Mosikomi(gsaユーザ, sData);
					texメッセージ.Text = sList[0];
// ADD 2007.01.30 東都）高木 更新時に受注ＮＯを更新する START
					if(sList.Length > 2 && sList[2] != null)
						tex受付ＮＯ.Text = sList[2].Trim();
// ADD 2007.01.30 東都）高木 更新時に受注ＮＯを更新する END
					if (sList[0].Equals("正常終了"))
					{
						texメッセージ.Text = "";
						//会員の更新
						s申込更新日時 = sList[1].Trim();
					}
					else
					{
						ビープ音();
						return(false);
					}
				}

				pnl受付ＮＯ.Enabled = false;
				pnl申込者.Enabled       = true;
				pnl設置場所.Enabled     = true;
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 START
				if(gs店所コード.Trim().Length == 0){
					pnl申込者.Enabled       = false;
					pnl設置場所.Enabled     = false;
				}
// ADD 2007.01.30 東都）高木 管理者の場合のフォーカスの位置変更 END
				pnlシステム情報.Enabled = true;
				btn登録.Text = "更新";
				btn登録.Enabled = true;
				btn削除.Enabled = true;
// 2006.10.26 ADD　FJCS）桑田 印刷系のボタンも使えるようにする START
				btn契約書.Enabled = true;
// DEL 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 START
//				btn申込書.Enabled = true;
// DEL 2007.01.19 東都）高木 契約書・申込書印刷ボタンの統合 END
// 2006.10.26 ADD　FJCS）桑田 印刷系のボタンも使えるようにする END
			}
			catch (Exception ex)
			{
				texメッセージ.Text = ex.Message;
				ビープ音();
				return(false);
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return(true);
		}

		private void btn店所情報登録_Click(object sender, System.EventArgs e)
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (g店所情報 == null) g店所情報 = new 店所情報();
			// 画面を左側に表示する
			g店所情報.Left = this.Left;
			g店所情報.Top = this.Top;
			g店所情報.iアクティブＦＧ = 1;
			// コードの初期表示
			g店所情報.ShowDialog();

			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

// ADD 2007.01.20 東都）高木 画面調整 START
		private void tex受付ＮＯ_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texメッセージ.Text = "";
				tex受付ＮＯ.Text = tex受付ＮＯ.Text.Trim();
				if(tex受付ＮＯ.Text.Length == 7)
					申込情報検索();
				else
					申込情報一覧();
			}
		}

		private void texお客様コード_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(btnお客様コード.Visible){
				if(e.KeyCode == Keys.Enter)
				{
					texメッセージ.Text = "";
					texお客様コード.Text = texお客様コード.Text.Trim();
					if(texお客様コード.Text.Length == 0)
						会員情報一覧();
				}
			}
		}

		private void texお客様コード_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if(btnお客様コード.Visible){
				if (e.KeyChar.ToString().Equals("*"))
				{
					btnお客様コード.Focus();
					会員情報一覧();
					e.Handled = true;
				}
			}
		}
// ADD 2007.01.20 東都）高木 画面調整 END
	}
}
