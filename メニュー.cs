using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Xml;

namespace is2AdminClient
{
	/// <summary>
	/// [Home]（メニュー）
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// DEL 2008.05.07 東都）高木 ご依頼主検索削除 
	// DEL 2008.05.08 東都）高木 セクション検索削除 
	// ADD 2008.04.11 ACT Vista対応 
	//保留 ADD 2008.01.06 東都）高木 メニュー０２拡張対応 
	//--------------------------------------------------------------------------
	// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 
	// MOD 2009.05.11 東都）高木 未出荷対応 
	// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 
	// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 
	// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 
	//--------------------------------------------------------------------------
	// ADD 2010.06.05 KCL) 森本 BLUEDI管理画面呼出機能の追加 
	//保留 MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 
	// MOD 2010.09.30 東都）高木 埼玉福山通運対応 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	// MOD 2011.01.14 東都）高木 王子運送対応 
	// MOD 2011.05.25 東都）高木 仙台支店対応 
	// MOD 2011.06.30 東都）高木 仙台中央支店対応 
	//--------------------------------------------------------------------------
	// //MOD 2015.02.26 BEVAS) 前田 パナハンディ対応
	//--------------------------------------------------------------------------
	// MOD 2016.01.22 BEVAS) 松本 お知らせボタンの色切替え改修
	//                            （表題の先頭に「【重要】」が付くものはボタンの色を変える）
	//--------------------------------------------------------------------------
	// MOD 2016.06.10 BEVAS) 松本 WiFi設定した端末でIPアドレスが正常に取得できない不具合対応
	//--------------------------------------------------------------------------
	public class メニュー : 共通フォーム
	{
		private static System.Threading.Mutex mutex;
// MOD 2005.05.27 東都）高木 スレッド位置の移動 START
//		private Image[]   imageCmd  = null;
//// ADD 2005.05.25 東都）小童谷 スレッド化 START
//		private Thread trd = null;
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
//		private static Image[] imageCmd = null;
		private static Image[] imageCmd_a = null;
		private static Image[] imageCmd_b = null;
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
		private static Thread trd = null;
//// ADD 2005.05.25 東都）小童谷 スレッド化 END
// MOD 2005.05.27 東都）高木 スレッド位置の移動 END
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
//// ADD 2006.07.11 東都）高木 画面変更 START
//		private static Image img会員承認a = null;
//		private static Image img会員承認b = null;
//		private static Image img稼働率情a = null;
//		private static Image img稼働率情b = null;
//		private static Image img出荷状況a = null;
//		private static Image img出荷状況b = null;
//// ADD 2006.07.11 東都）高木 画面変更 END
		private static Image img使用承認a = null;
		private static Image img使用承認b = null;
		private static Image imgお客様情a = null;
		private static Image imgお客様情b = null;
		private static Image img稼働率情a = null;
		private static Image img稼働率情b = null;
		private static Image img出荷状況a = null;
		private static Image img出荷状況b = null;
		private static Image imgメッセジa = null;
		private static Image imgメッセジb = null;
		private static Image img使用登録a = null;
		private static Image img使用登録b = null;
		private static Image img請求先登a = null;
		private static Image img請求先登b = null;
		private static Image img集約店登a = null;
		private static Image img集約店登b = null;
		private static Image img輸送商品a = null;
		private static Image img輸送商品b = null;

		private static Image img使用申込a = null;
		private static Image img使用申込b = null;
//		private static Image img請求先登a = null;
//		private static Image img請求先登b = null;
		private static Image img出荷照会a = null;
		private static Image img出荷照会b = null;
		private static Image img発店仕分a = null;
		private static Image img発店仕分b = null;
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
// ADD 2007.12.04 KCL) 森本 お知らせ追加 START
		private static Image imgお知らせa = null;
		private static Image imgお知らせb = null;
// ADD 2007.12.04 KCL) 森本 お知らせ追加 END
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
		private static Image imgお知表示a = null;
		private static Image imgお知表示b = null;
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
		private static Image imgマニュアa = null;
		private static Image imgマニュアb = null;
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
// MOD 2007.11.29 東都）高木 ログイン時のフォーカス障害対応 START
		private static ログイン Fログイン = null;
// MOD 2007.11.29 東都）高木 ログイン時のフォーカス障害対応 END

		private お知らせ表題ボタン [] btnList = new お知らせ表題ボタン [5];
		private string [][] sお知らせ一覧 = null;
		// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
		private static string sマニュアルＵＲＬ = null;
		// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
		
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label lab日時;
		private System.Windows.Forms.Button btn終了;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.PictureBox pic０７;
		private System.Windows.Forms.PictureBox pic０６;
		private System.Windows.Forms.PictureBox pic０８;
		private System.Windows.Forms.PictureBox pic０２;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pic０９;
		private System.Windows.Forms.PictureBox pic０５;
		private System.Windows.Forms.PictureBox picホーム;
		private System.Windows.Forms.PictureBox pic０１;
		private System.Windows.Forms.PictureBox pic０３;
		private System.Windows.Forms.PictureBox pic０４;
		private System.Windows.Forms.Label labバージョン;
		private System.Windows.Forms.Button btn切替;
		private System.Windows.Forms.Button btn旧店所;
		private System.Windows.Forms.PictureBox pic１０;
		private System.Windows.Forms.Button btn稼働日登録;
		private System.Windows.Forms.Panel panメニュー６;
		private is2AdminClient.お知らせ表題ボタン btnお知らせ１;
		private is2AdminClient.お知らせ表題ボタン btnお知らせ２;
		private is2AdminClient.お知らせ表題ボタン btnお知らせ３;
		private is2AdminClient.お知らせ表題ボタン btnお知らせ４;
		private is2AdminClient.お知らせ表題ボタン btnお知らせ５;
		private System.Windows.Forms.Button btnBLUEDI管理;
		private System.ComponentModel.IContainer components;

		public メニュー()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();

// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
			// 初期設定
			this.お知らせ初期設定();
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
		}

		/// <summary>
		/// 使用されているリソースに後処理を実行します。
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(メニュー));
			this.panel7 = new System.Windows.Forms.Panel();
			this.picホーム = new System.Windows.Forms.PictureBox();
			this.lab日時 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnBLUEDI管理 = new System.Windows.Forms.Button();
			this.btn稼働日登録 = new System.Windows.Forms.Button();
			this.btn旧店所 = new System.Windows.Forms.Button();
			this.btn切替 = new System.Windows.Forms.Button();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn終了 = new System.Windows.Forms.Button();
			this.pic０２ = new System.Windows.Forms.PictureBox();
			this.pic０８ = new System.Windows.Forms.PictureBox();
			this.pic０７ = new System.Windows.Forms.PictureBox();
			this.pic０６ = new System.Windows.Forms.PictureBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.labバージョン = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pic１０ = new System.Windows.Forms.PictureBox();
			this.pic０４ = new System.Windows.Forms.PictureBox();
			this.pic０３ = new System.Windows.Forms.PictureBox();
			this.pic０１ = new System.Windows.Forms.PictureBox();
			this.pic０５ = new System.Windows.Forms.PictureBox();
			this.pic０９ = new System.Windows.Forms.PictureBox();
			this.panメニュー６ = new System.Windows.Forms.Panel();
			this.btnお知らせ１ = new is2AdminClient.お知らせ表題ボタン();
			this.btnお知らせ５ = new is2AdminClient.お知らせ表題ボタン();
			this.btnお知らせ４ = new is2AdminClient.お知らせ表題ボタン();
			this.btnお知らせ３ = new is2AdminClient.お知らせ表題ボタン();
			this.btnお知らせ２ = new is2AdminClient.お知らせ表題ボタン();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panメニュー６.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.picホーム);
			this.panel7.Controls.Add(this.lab日時);
			this.panel7.Controls.Add(this.label29);
			this.panel7.Location = new System.Drawing.Point(0, -2);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(792, 26);
			this.panel7.TabIndex = 15;
			// 
			// picホーム
			// 
			this.picホーム.Image = ((System.Drawing.Image)(resources.GetObject("picホーム.Image")));
			this.picホーム.Location = new System.Drawing.Point(8, 4);
			this.picホーム.Name = "picホーム";
			this.picホーム.Size = new System.Drawing.Size(22, 22);
			this.picホーム.TabIndex = 3;
			this.picホーム.TabStop = false;
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
			// label29
			// 
			this.label29.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label29.Font = new System.Drawing.Font("MS UI Gothic", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label29.ForeColor = System.Drawing.Color.White;
			this.label29.Location = new System.Drawing.Point(32, 6);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(264, 24);
			this.label29.TabIndex = 0;
			this.label29.Text = "Home";
			// 
			// panel6
			// 
			this.panel6.BackColor = System.Drawing.Color.PaleGreen;
			this.panel6.Location = new System.Drawing.Point(-2, 24);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(810, 26);
			this.panel6.TabIndex = 14;
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btnBLUEDI管理);
			this.panel8.Controls.Add(this.btn稼働日登録);
			this.panel8.Controls.Add(this.btn旧店所);
			this.panel8.Controls.Add(this.btn切替);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn終了);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// btnBLUEDI管理
			// 
			this.btnBLUEDI管理.ForeColor = System.Drawing.Color.Blue;
			this.btnBLUEDI管理.Location = new System.Drawing.Point(352, 6);
			this.btnBLUEDI管理.Name = "btnBLUEDI管理";
			this.btnBLUEDI管理.Size = new System.Drawing.Size(54, 48);
			this.btnBLUEDI管理.TabIndex = 5;
			this.btnBLUEDI管理.Text = "BLUEDI 管理";
			this.btnBLUEDI管理.Click += new System.EventHandler(this.btnBLUEDI管理_Click);
			// 
			// btn稼働日登録
			// 
			this.btn稼働日登録.ForeColor = System.Drawing.Color.Blue;
			this.btn稼働日登録.Location = new System.Drawing.Point(208, 6);
			this.btn稼働日登録.Name = "btn稼働日登録";
			this.btn稼働日登録.Size = new System.Drawing.Size(54, 48);
			this.btn稼働日登録.TabIndex = 4;
			this.btn稼働日登録.Text = "稼働日 登録";
			this.btn稼働日登録.Visible = false;
			this.btn稼働日登録.Click += new System.EventHandler(this.btn稼働日登録_Click);
			// 
			// btn旧店所
			// 
			this.btn旧店所.ForeColor = System.Drawing.Color.Blue;
			this.btn旧店所.Location = new System.Drawing.Point(138, 6);
			this.btn旧店所.Name = "btn旧店所";
			this.btn旧店所.Size = new System.Drawing.Size(62, 48);
			this.btn旧店所.TabIndex = 3;
			this.btn旧店所.Text = "国国国国";
			this.btn旧店所.Visible = false;
			this.btn旧店所.Click += new System.EventHandler(this.btn旧店所_Click);
			// 
			// btn切替
			// 
			this.btn切替.ForeColor = System.Drawing.Color.Blue;
			this.btn切替.Location = new System.Drawing.Point(76, 6);
			this.btn切替.Name = "btn切替";
			this.btn切替.Size = new System.Drawing.Size(54, 48);
			this.btn切替.TabIndex = 2;
			this.btn切替.Text = "切替";
			this.btn切替.Click += new System.EventHandler(this.btn切替_Click);
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
			this.texメッセージ.TabIndex = 1;
			this.texメッセージ.TabStop = false;
			this.texメッセージ.Text = "";
			// 
			// btn終了
			// 
			this.btn終了.ForeColor = System.Drawing.Color.Red;
			this.btn終了.Location = new System.Drawing.Point(8, 6);
			this.btn終了.Name = "btn終了";
			this.btn終了.Size = new System.Drawing.Size(54, 48);
			this.btn終了.TabIndex = 0;
			this.btn終了.TabStop = false;
			this.btn終了.Text = "終了";
			this.btn終了.Click += new System.EventHandler(this.btn終了_Click);
			// 
			// pic０２
			// 
			this.pic０２.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０２.Location = new System.Drawing.Point(22, 90);
			this.pic０２.Name = "pic０２";
			this.pic０２.Size = new System.Drawing.Size(352, 42);
			this.pic０２.TabIndex = 12;
			this.pic０２.TabStop = false;
			this.pic０２.Click += new System.EventHandler(this.pic０２_Click);
			this.pic０２.MouseEnter += new System.EventHandler(this.pic０２_MouseEnter);
			this.pic０２.MouseLeave += new System.EventHandler(this.pic０２_MouseLeave);
			// 
			// pic０８
			// 
			this.pic０８.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０８.Location = new System.Drawing.Point(402, 160);
			this.pic０８.Name = "pic０８";
			this.pic０８.Size = new System.Drawing.Size(352, 42);
			this.pic０８.TabIndex = 12;
			this.pic０８.TabStop = false;
			this.pic０８.Click += new System.EventHandler(this.pic０８_Click);
			this.pic０８.MouseEnter += new System.EventHandler(this.pic０８_MouseEnter);
			this.pic０８.MouseLeave += new System.EventHandler(this.pic０８_MouseLeave);
			// 
			// pic０７
			// 
			this.pic０７.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０７.Location = new System.Drawing.Point(402, 90);
			this.pic０７.Name = "pic０７";
			this.pic０７.Size = new System.Drawing.Size(352, 42);
			this.pic０７.TabIndex = 11;
			this.pic０７.TabStop = false;
			this.pic０７.Click += new System.EventHandler(this.pic０７_Click);
			this.pic０７.MouseEnter += new System.EventHandler(this.pic０７_MouseEnter);
			this.pic０７.MouseLeave += new System.EventHandler(this.pic０７_MouseLeave);
			// 
			// pic０６
			// 
			this.pic０６.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０６.Location = new System.Drawing.Point(402, 20);
			this.pic０６.Name = "pic０６";
			this.pic０６.Size = new System.Drawing.Size(352, 42);
			this.pic０６.TabIndex = 10;
			this.pic０６.TabStop = false;
			this.pic０６.Click += new System.EventHandler(this.pic０６_Click);
			this.pic０６.MouseEnter += new System.EventHandler(this.pic０６_MouseEnter);
			this.pic０６.MouseLeave += new System.EventHandler(this.pic０６_MouseLeave);
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(782, 65);
			this.pictureBox1.TabIndex = 16;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.labバージョン);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Controls.Add(this.panメニュー６);
			this.panel1.Location = new System.Drawing.Point(0, 62);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(784, 448);
			this.panel1.TabIndex = 17;
			// 
			// labバージョン
			// 
			this.labバージョン.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(102)), ((System.Byte)(101)), ((System.Byte)(255)));
			this.labバージョン.ForeColor = System.Drawing.Color.White;
			this.labバージョン.Location = new System.Drawing.Point(704, 6);
			this.labバージョン.Name = "labバージョン";
			this.labバージョン.Size = new System.Drawing.Size(60, 12);
			this.labバージョン.TabIndex = 39;
			this.labバージョン.Text = "Ver.1.6";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.pic１０);
			this.panel2.Controls.Add(this.pic０４);
			this.panel2.Controls.Add(this.pic０３);
			this.panel2.Controls.Add(this.pic０１);
			this.panel2.Controls.Add(this.pic０５);
			this.panel2.Controls.Add(this.pic０９);
			this.panel2.Controls.Add(this.pic０６);
			this.panel2.Controls.Add(this.pic０７);
			this.panel2.Controls.Add(this.pic０８);
			this.panel2.Controls.Add(this.pic０２);
			this.panel2.Location = new System.Drawing.Point(4, 68);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 376);
			this.panel2.TabIndex = 17;
			// 
			// pic１０
			// 
			this.pic１０.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic１０.Location = new System.Drawing.Point(402, 300);
			this.pic１０.Name = "pic１０";
			this.pic１０.Size = new System.Drawing.Size(352, 42);
			this.pic１０.TabIndex = 19;
			this.pic１０.TabStop = false;
			this.pic１０.Click += new System.EventHandler(this.pic１０_Click);
			this.pic１０.MouseEnter += new System.EventHandler(this.pic１０_MouseEnter);
			this.pic１０.MouseLeave += new System.EventHandler(this.pic１０_MouseLeave);
			// 
			// pic０４
			// 
			this.pic０４.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０４.Location = new System.Drawing.Point(22, 230);
			this.pic０４.Name = "pic０４";
			this.pic０４.Size = new System.Drawing.Size(352, 42);
			this.pic０４.TabIndex = 18;
			this.pic０４.TabStop = false;
			this.pic０４.Click += new System.EventHandler(this.pic０４_Click);
			this.pic０４.MouseEnter += new System.EventHandler(this.pic０４_MouseEnter);
			this.pic０４.MouseLeave += new System.EventHandler(this.pic０４_MouseLeave);
			// 
			// pic０３
			// 
			this.pic０３.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０３.Location = new System.Drawing.Point(22, 160);
			this.pic０３.Name = "pic０３";
			this.pic０３.Size = new System.Drawing.Size(352, 42);
			this.pic０３.TabIndex = 17;
			this.pic０３.TabStop = false;
			this.pic０３.Click += new System.EventHandler(this.pic０３_Click);
			this.pic０３.MouseEnter += new System.EventHandler(this.pic０３_MouseEnter);
			this.pic０３.MouseLeave += new System.EventHandler(this.pic０３_MouseLeave);
			// 
			// pic０１
			// 
			this.pic０１.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０１.Location = new System.Drawing.Point(22, 20);
			this.pic０１.Name = "pic０１";
			this.pic０１.Size = new System.Drawing.Size(352, 42);
			this.pic０１.TabIndex = 16;
			this.pic０１.TabStop = false;
			this.pic０１.Click += new System.EventHandler(this.pic０１_Click);
			this.pic０１.MouseEnter += new System.EventHandler(this.pic０１_MouseEnter);
			this.pic０１.MouseLeave += new System.EventHandler(this.pic０１_MouseLeave);
			// 
			// pic０５
			// 
			this.pic０５.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０５.Location = new System.Drawing.Point(22, 300);
			this.pic０５.Name = "pic０５";
			this.pic０５.Size = new System.Drawing.Size(352, 42);
			this.pic０５.TabIndex = 14;
			this.pic０５.TabStop = false;
			this.pic０５.Click += new System.EventHandler(this.pic０５_Click);
			this.pic０５.MouseEnter += new System.EventHandler(this.pic０５_MouseEnter);
			this.pic０５.MouseLeave += new System.EventHandler(this.pic０５_MouseLeave);
			// 
			// pic０９
			// 
			this.pic０９.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pic０９.Location = new System.Drawing.Point(402, 230);
			this.pic０９.Name = "pic０９";
			this.pic０９.Size = new System.Drawing.Size(352, 42);
			this.pic０９.TabIndex = 13;
			this.pic０９.TabStop = false;
			this.pic０９.Click += new System.EventHandler(this.pic０９_Click);
			this.pic０９.MouseEnter += new System.EventHandler(this.pic０９_MouseEnter);
			this.pic０９.MouseLeave += new System.EventHandler(this.pic０９_MouseLeave);
			// 
			// panメニュー６
			// 
			this.panメニュー６.Controls.Add(this.btnお知らせ１);
			this.panメニュー６.Controls.Add(this.btnお知らせ５);
			this.panメニュー６.Controls.Add(this.btnお知らせ４);
			this.panメニュー６.Controls.Add(this.btnお知らせ３);
			this.panメニュー６.Controls.Add(this.btnお知らせ２);
			this.panメニュー６.Location = new System.Drawing.Point(4, 68);
			this.panメニュー６.Name = "panメニュー６";
			this.panメニュー６.Size = new System.Drawing.Size(776, 376);
			this.panメニュー６.TabIndex = 34;
			// 
			// btnお知らせ１
			// 
			this.btnお知らせ１.Location = new System.Drawing.Point(22, 20);
			this.btnお知らせ１.Name = "btnお知らせ１";
			this.btnお知らせ１.Size = new System.Drawing.Size(482, 42);
			this.btnお知らせ１.TabIndex = 26;
			this.btnお知らせ１.Visible = false;
			this.btnお知らせ１.ButtonClicked += new System.EventHandler(this.picお知らせ１_Click);
			// 
			// btnお知らせ５
			// 
			this.btnお知らせ５.Location = new System.Drawing.Point(22, 300);
			this.btnお知らせ５.Name = "btnお知らせ５";
			this.btnお知らせ５.Size = new System.Drawing.Size(482, 42);
			this.btnお知らせ５.TabIndex = 29;
			this.btnお知らせ５.Visible = false;
			this.btnお知らせ５.ButtonClicked += new System.EventHandler(this.picお知らせ５_Click);
			// 
			// btnお知らせ４
			// 
			this.btnお知らせ４.Location = new System.Drawing.Point(22, 230);
			this.btnお知らせ４.Name = "btnお知らせ４";
			this.btnお知らせ４.Size = new System.Drawing.Size(482, 42);
			this.btnお知らせ４.TabIndex = 28;
			this.btnお知らせ４.Visible = false;
			this.btnお知らせ４.ButtonClicked += new System.EventHandler(this.picお知らせ４_Click);
			// 
			// btnお知らせ３
			// 
			this.btnお知らせ３.Location = new System.Drawing.Point(22, 160);
			this.btnお知らせ３.Name = "btnお知らせ３";
			this.btnお知らせ３.Size = new System.Drawing.Size(482, 42);
			this.btnお知らせ３.TabIndex = 27;
			this.btnお知らせ３.Visible = false;
			this.btnお知らせ３.ButtonClicked += new System.EventHandler(this.picお知らせ３_Click);
			// 
			// btnお知らせ２
			// 
			this.btnお知らせ２.Location = new System.Drawing.Point(22, 90);
			this.btnお知らせ２.Name = "btnお知らせ２";
			this.btnお知らせ２.Size = new System.Drawing.Size(482, 42);
			this.btnお知らせ２.TabIndex = 26;
			this.btnお知らせ２.Visible = false;
			this.btnお知らせ２.ButtonClicked += new System.EventHandler(this.picお知らせ２_Click);
			// 
			// メニュー
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(792, 574);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "メニュー";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "is-2 Home";
			this.Load += new System.EventHandler(this.Form3_Load);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panメニュー６.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		[STAThread]
		static void Main() 
		{
			// アプリケーションの二重起動防止
			mutex = new System.Threading.Mutex(false, "is2AdminClient");
			if( mutex.WaitOne(0, false) == false) return;

// ADD 2006.12.06 東都）小童谷 ＩＰアドレス取得 START
			try
			{
				string sMName = System.Environment.MachineName;
				// ＩＰアドレス
				System.Net.IPHostEntry iph = System.Net.Dns.GetHostByName(sMName);
#if DEBUG
				iph.AddressList = new System.Net.IPAddress[3];
				try
				{
					iph.AddressList[0] = System.Net.IPAddress.Parse("172.21.25.14");
					iph.AddressList[1] = System.Net.IPAddress.Parse("10.21.25.14");
					iph.AddressList[2] = System.Net.IPAddress.Parse("11.21.25.14");
				}
				catch(Exception ){}
#endif
// MOD 2015.BEVAS)前田 パナハンディ導入時に複数IPが割り当てられている場合にIP検索 START
				//gsＩＰアドレス = iph.AddressList[0].ToString();
				foreach (System.Net.IPAddress aIP in iph.AddressList) 
				{
// MOD 2016.06.10 BEVAS) 松本 WiFi設定した端末でIPアドレスが正常に取得できない不具合対応 START
//					string ipa = aIP.ToString().Substring(0,3);
//					if (ipa.Equals("172") || ipa.Equals("10")) 
					if(aIP == null ||
						aIP.ToString().Substring(0,4) == "172." ||
						aIP.ToString().Substring(0,3) == "10.")
// MOD 2016.06.10 BEVAS) 松本 WiFi設定した端末でIPアドレスが正常に取得できない不具合対応 END
					{
	 					gsＩＰアドレス = aIP.ToString();
					}
				}
				if (gsＩＰアドレス.Equals("")) 
				{
					gsＩＰアドレス = iph.AddressList[0].ToString();
				}
// MOD 2015.BEVAS)前田 パナハンディ導入時に複数IPが割り当てられている場合にIP検索 END
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
// 本番用はコメントに！！
//gsＩＰアドレス = "10.44.1.200";
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
			}
			catch(Exception)
			{
				MessageBox.Show("認証エラー：ＩＰアドレスの取得に失敗しました。", "ログイン", 
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				// ミューテックスの破棄
				mutex.Close();
				Application.Exit();
				return;
			}
// ADD 2006.12.06 東都）小童谷 ＩＰアドレス取得 END

// ADD 2007.02.06 東都）高木 イメージロードエラー対応 START
			// カレントディレクトリの取得
			gsアプリフォルダ = System.IO.Directory.GetCurrentDirectory();
// ADD 2007.02.06 東都）高木 イメージロードエラー対応 END

			try
			{
// MOD 2005.05.27 東都）高木 スレッド位置の変更 START
//				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
//				sv_maintenance.CookieContainer = cContainer;
				trd = new Thread(new ThreadStart(ThreadTask));
				trd.IsBackground = true;
				trd.Start();
// MOD 2005.05.27 東都）高木 スレッド位置の変更 END

// ADD 2008.04.11 ACT Vista対応 START
				try
				{
					漢字変換ハッシュ設定();
				}
				catch(Exception ex)
				{
					ビープ音();
					MessageBox.Show(ex.Message, 
						"漢字変換取得", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					// ミューテックスの破棄
					mutex.Close();
					Application.Exit();
					return;
				}		
// ADD 2008.04.11 ACT Vista対応 END

// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
			try{
				FileInfo finfo = new FileInfo("is2AdminClient.exe.config");
				if(finfo.Exists){
					XmlDocument xmldoc = new XmlDocument();
					xmldoc.Load(finfo.FullName);
					foreach(XmlNode node in xmldoc["configuration"]["appSettings"]){
							if(node.Attributes.GetNamedItem("key").Value.Equals("HelpURL")){
							sマニュアルＵＲＬ = node.Attributes.GetNamedItem("value").Value;
						}
					}
					xmldoc = null;
				}
				finfo = null;
			}catch(Exception){
				;
			}
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END

				// ログイン画面を表示
// MOD 2007.11.29 東都）高木 ログイン時のフォーカス障害対応 START
//				ログイン 画面 = new ログイン();
//				画面.ShowDialog();
//			
//				// 認証に失敗した場合：アプリ終了
//				if(!画面.b認証)
//				{
//					// ミューテックスの破棄
//					mutex.Close();
//					Application.Exit();
//					return;
//				}
				Fログイン = new ログイン();
				Fログイン.WindowState = FormWindowState.Normal;
				Fログイン.ShowDialog();
			
				// 認証に失敗した場合：アプリ終了
				if(!Fログイン.b認証)
				{
					// ミューテックスの破棄
					mutex.Close();
					Application.Exit();
					return;
				}
				Fログイン = null;
// MOD 2007.11.29 東都）高木 ログイン時のフォーカス障害対応 END
// DEL 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
//				//会員コードが"honbu"の場合：店所入力画面を表示
//// MOD 2007.01.30 東都）高木 特殊権限ユーザの追加 START
////				if(gs会員コード == "honbu")
//				if(gs会員コード == "honbu"
//				|| gs会員コード == "kikaku")
//// MOD 2007.01.30 東都）高木 特殊権限ユーザの追加 END
//				{
//					// ログイン画面を表示
//					店所入力 店所 = new 店所入力();
//					店所.ShowDialog();
//			
//					// 認証に失敗した場合：アプリ終了
//					if(!店所.b認証)
//					{
//						// ミューテックスの破棄
//						mutex.Close();
//						Application.Exit();
//						return;
//					}
//				}
// DEL 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
			}
			catch (Exception)
			{
				// ミューテックスの破棄
				mutex.Close();
				Application.Exit();
				return;
			}

// ADD 2005.05.27 東都）高木 画面遷移を速くする START
			// スレッドでは実行できないので、ここで実施
			if(g会員マス == null) g会員マス = new 会員マスタ();
			if(g会員検索 == null) g会員検索 = new 会員検索();
			if(g記事登録 == null) g記事登録 = new 記事登録();
			if(g集約店マ == null) g集約店マ = new 集約店マスタ();
			if(g住所検索 == null) g住所検索 = new 住所検索();
			if(g請求先マ == null) g請求先マ = new 請求先マスタ();
			if(g店所検索 == null) g店所検索 = new 店所検索();
// DEL 2008.05.08 東都）高木 セクション検索削除 START
//			if(g部門検索 == null) g部門検索 = new 部門検索();
// DEL 2008.05.08 東都）高木 セクション検索削除 END
// ADD 2005.05.27 東都）高木 画面遷移を速くする END
// ADD 2006.07.11 東都）高木 画面変更 START
			if(g加入検索 == null) g加入検索 = new 加入検索();
// ADD 2006.07.11 東都）高木 画面変更 END
// ADD 2006.12.12 東都）高木 画面追加 START
			if(g出荷照会 == null) g出荷照会 = new 出荷照会();
// DEL 2008.05.07 東都）高木 ご依頼主検索削除 START
//			if(g依頼検索 == null) g依頼検索 = new ご依頼主検索();
// DEL 2008.05.07 東都）高木 ご依頼主検索削除 END
// MOD 2007.01.18 東都）高木 画面名の変更 START
//			if(g着店仕分 == null) g着店仕分 = new 着店仕分();
			if(g発店仕分 == null) g発店仕分 = new 発店仕分();
// MOD 2007.01.18 東都）高木 画面名の変更 END
// ADD 2006.12.12 東都）高木 画面追加 END
// ADD 2007.11.16 KCL) 森本 画面追加 START
			if (g会員検２ == null) g会員検２ = new 会員検索２();
			if (g依頼検２ == null) g依頼検２ = new ご依頼主検索２();
// ADD 2007.11.16 KCL) 森本 画面追加 END
// ADD 2007.12.05 KCL) 森本 お知らせ追加 START
			if (gお知登録 == null) gお知登録 = new お知らせ登録();
			if (gお知検索 == null) gお知検索 = new お知らせ検索();
// ADD 2007.12.05 KCL) 森本 お知らせ追加 END
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
			if (gお知表示 == null) gお知表示 = new お知らせ表示();
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
			if (gマニュア == null) gマニュア = new マニュアルダウンロード();
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
// ADD 2006.12.12 東都）高木 画面追加 START
			if(状態情報取得() == false)
			{
				// ミューテックスの破棄
				mutex.Close();
				Application.Exit();
				return;
			}
// ADD 2006.12.12 東都）高木 画面追加 END

			Application.Run(new メニュー());
		}

		private static bool 状態情報取得()
		{
			// 既に取得していた場合には終了
			if(gsa状態ＣＤ.Length > 1 && gsa状態ＣＤ[0].Length > 0) return true;

			try
			{	
				// 状態リストを取得
				if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
				string[] sRet = sv_maintenance.Get_jyotai(gsaユーザ);
				if( sRet[0].Length == 4 ){
					int i状態数 = int.Parse(sRet[1]);
					if(i状態数 > 0)
					{
// MOD 2009.05.11 東都）高木 未出荷対応 START
//						gsa状態ＣＤ = new string[1 + i状態数];
//						gsa状態名　 = new string[1 + i状態数];
						gsa状態ＣＤ = new string[2 + i状態数];
						gsa状態名　 = new string[2 + i状態数];
// MOD 2009.05.11 東都）高木 未出荷対応 END
						gsa状態ＣＤ[0] = "00";
						gsa状態名[0]   = "全て";
						int iPos = 2;
						for(int iCnt = 1; iCnt <= i状態数 && iPos < sRet.Length; iCnt++)
						{
							gsa状態ＣＤ[iCnt] = sRet[iPos++];
							gsa状態名[iCnt]   = sRet[iPos++];
						}
// MOD 2009.05.11 東都）高木 未出荷対応 START
						gsa状態ＣＤ[i状態数 + 1] = "90";
						gsa状態名[i状態数 + 1]   = "未出荷";
// MOD 2009.05.11 東都）高木 未出荷対応 END
					}
				}
			}
// MOD 2005.06.30 東都）高木 通信エラーのメッセージ修正 START
//			catch (Exception)
//			{
//				return false;
//			}
			catch (System.Net.WebException)
			{
				ビープ音();
				MessageBox.Show(gs通信エラー, 
								"通信エラー", 
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			catch (Exception ex)
			{
				ビープ音();
				MessageBox.Show(ex.Message, 
								"通信エラー", 
								MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
// MOD 2005.06.30 東都）高木 通信エラーのメッセージ修正 END

			return true;
		}
// ADD 2005.05.27 東都）高木 起動時間を短くする END

		private void Form3_Load(object sender, System.EventArgs e)
		{
// ADD 2007.10.26 東都）高木 バージョン情報の表示 START
			if(gsaユーザ[3].Length > 0) labバージョン.Text = "Ver." + gsaユーザ[3];
// ADD 2007.10.26 東都）高木 バージョン情報の表示 END
			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;

			コマンドイメージの初期化();

			// ボタンイメージの初期化
			picホーム.Image          = Image.FromFile("img\\home.gif");
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
//			pictureBox1.Image        = imageCmd[10];
			pictureBox1.Image        = Image.FromFile("img\\upperbar.gif");
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
//// MOD 2006.10.04 東都）山本 店所メニューの切替対応 START
//			if(gs店所コード.Trim().Length == 0)
//			{
//				pic０６.Image      = imageCmd[0];
//				pic０７.Image    = imageCmd[2];
//				pic０８.Image    = imageCmd[4];
//				pic０２.Image    = imageCmd[6];
//				pic０９.Image        = imageCmd[8];
//// DEL 2006.07.11 東都）高木 画面変更 START
////			pictureBox2.Image        = imageCmd[11];
//// DEL 2006.07.11 東都）高木 画面変更 END
////			pictureBox3.Image        = imageCmd[12];
//				pic０５.Image  = imageCmd[13];
//// ADD 2006.07.11 東都）高木 画面変更 START
//				pic０１.Image        = img会員承認a;
//				pic０３.Image        = img稼働率情a;
//				pic０４.Image        = img出荷状況a;
//// ADD 2006.07.11 東都）高木 画面変更 END
//			}
//			else
//			{
//				pic０１.Image        = img会員承認a;
//				pic０２.Image    = imageCmd[6];
//				pic０３.Image        = img稼働率情a;
//				pic０４.Image        = img出荷状況a;
//				pic０５.Image  = imageCmd[13];
//
//				pic０６.Visible = false;
//				pic０７.Visible = false;
//				pic０８.Visible = false;
//				pic０９.Visible = false;
//			
//			}
//// MOD 2006.10.04 東都）山本 店所メニューの切替対応 END
			メニューボタン設定();
// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 START
//			if(gs店所コード.Trim().Length == 0){
			// 管理者会員の場合
			if(gs管理者区分 == "1"){
// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 END
				btn切替.Visible = true;
			}else{
				btn切替.Visible = false;
			}
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
// DEL 2005.05.27 東都）高木 スレッド位置の移動 START
//// ADD 2005.05.25 東都）小童谷 スレッド化 START
//			trd = new Thread(new ThreadStart(ThreadTask));
//			trd.IsBackground = true;
//			trd.Start();
//// ADD 2005.05.25 東都）小童谷 スレッド化 END
// DEL 2005.05.27 東都）高木 スレッド位置の移動 END
// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 START
			//お知らせパネルの非表示
			panメニュー６.Visible = false;
// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 END
		}

		private void btn終了_Click(object sender, System.EventArgs e)
		{
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
			if(panメニュー６.Visible){
				panel2.Visible = true;
				panメニュー６.Visible = false;
				btn終了.Text = "終了";
// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 START
//				if(gs店所コード.Trim().Length != 0){
				// 管理者会員の場合
				if(gs管理者区分 == "1"){
// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 END
					btn切替.Visible = true;
				}
				return;
			}
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
// ADD 2007.03.14 FJCS）桑田　終了メッセージ表示 START
			DialogResult result = MessageBox.Show("終了しますか？", "終了", 
				MessageBoxButtons.YesNo);
			if (result == DialogResult.Yes)
			{
// ADD 2007.03.14 FJCS）桑田　終了メッセージ表示 END
				// ミューテックスの破棄
				mutex.Close();
				Application.Exit();
// ADD 2007.03.14 FJCS）桑田　終了メッセージ表示 START
			}
			else
			{
				return;
			}
// ADD 2007.03.14 FJCS）桑田　終了メッセージ表示 END
		}

		private void timer1_Tick(object sender, System.EventArgs e)
		{
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}

		private void pic０６_Click(object sender, System.EventArgs e)
		{
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
			if(gs店所コード.Trim().Length != 0)
			{
				panel2.Visible = false;
				btn終了.Text = "閉じる";
				btn切替.Visible = false;
				// お知らせの設定
				お知らせの取得と表示();
				panメニュー６.Visible = true;
				return;
			}
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
			if (g会員マス == null)	 g会員マス = new 会員マスタ();
			g会員マス.Left = this.Left;
			g会員マス.Top = this.Top;
			this.Visible = false;
			g会員マス.ShowDialog(this);
			this.Visible = true;
		}

		private void pic０７_Click(object sender, System.EventArgs e)
		{
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
			if(gs店所コード.Trim().Length != 0)
			{
				if(gマニュア == null) gマニュア = new マニュアルダウンロード();
				gマニュア.Left = this.Left + (this.Width  - gマニュア.Width)  / 2;
				gマニュア.Top  = this.Top  + (this.Height - gマニュア.Height) / 2;
				gマニュア.sマニュアルＵＲＬ = sマニュアルＵＲＬ;
				gマニュア.ShowDialog(this);
				
				return;
			}
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			請求先マスタ 画面 = new 請求先マスタ();
//			画面.Left = this.Left;
//			画面.Top = this.Top;
			if (g請求先マ == null)	 g請求先マ = new 請求先マスタ();
			g請求先マ.Left = this.Left;
			g請求先マ.Top = this.Top;
// MOD 2005.05.09 東都）高木 画面遷移の変更 START
//			画面.ShowDialog();  /////
			this.Visible = false;
//			画面.ShowDialog(this);
			g請求先マ.ShowDialog(this);
			this.Visible = true;
// MOD 2005.05.09 東都）高木 画面遷移の変更 END
// MOD 2005.05.25 東都）小童谷 画面高速化 END
		}

		private void pic０８_Click(object sender, System.EventArgs e)
		{
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			集約店マスタ 画面 = new 集約店マスタ();
// MOD 2005.05.09 東都）高木 画面遷移の変更 START ////
//			画面.Left = this.Left + 202; ////
//			画面.Top = this.Top; ////
//			画面.ShowDialog(); ////
//			画面.Left = this.Left + (this.Width  - 画面.Width)  / 2;
//			画面.Top = this.Top;
//			画面.ShowDialog(this);
			if (g集約店マ == null)	 g集約店マ = new 集約店マスタ();
			g集約店マ.Left = this.Left + (this.Width  - g集約店マ.Width)  / 2;
			g集約店マ.Top = this.Top;
			g集約店マ.ShowDialog(this);
// MOD 2005.05.09 東都）高木 画面遷移の変更 END
// MOD 2005.05.25 東都）小童谷 画面高速化 END
		}

		private void pic０２_Click(object sender, System.EventArgs e)
		{
// MOD 2006.10.04 東都）山本 店所メニューの切替対応 START
			if(gs店所コード.Trim().Length == 0)
			{
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			会員情報ＣＳＶ出力 画面 = new 会員情報ＣＳＶ出力();
// MOD 2005.05.09 東都）高木 画面遷移の変更 START
//			画面.Left = this.Left + 202; ////
//			画面.Top = this.Top; ////
//			画面.ShowDialog(); ////
//			画面.Left = this.Left + (this.Width  - 画面.Width)  / 2;
//			画面.Top  = this.Top  + (this.Height - 画面.Height) / 2;
//			画面.ShowDialog(this);
				if (g会員出力 == null)	 g会員出力 = new 会員情報ＣＳＶ出力();
				g会員出力.Left = this.Left + (this.Width  - g会員出力.Width)  / 2;
				g会員出力.Top  = this.Top  + (this.Height - g会員出力.Height) / 2;
				g会員出力.ShowDialog(this);
//// MOD 2005.05.09 東都）高木 画面遷移の変更 END
// MOD 2005.05.25 東都）小童谷 画面高速化 END
			}
			else
			{
				if (g請求先マ == null)	 g請求先マ = new 請求先マスタ();
				g請求先マ.Left = this.Left;
				g請求先マ.Top = this.Top;
				this.Visible = false;
				g請求先マ.ShowDialog(this);
				this.Visible = true;
			}
// MOD 2006.10.04 東都）山本 店所メニューの切替対応 END
		}

// ADD 2005.05.16 東都）伊賀 記事登録の追加 START
		private void pic０９_Click(object sender, System.EventArgs e)
		{
// MOD 2005.05.25 東都）小童谷 画面高速化 START
//			記事登録 画面 = new 記事登録();
//			画面.Left = this.Left + (this.Width - 画面.Width) / 2;
//			画面.Top  = this.Top;
//			画面.ShowDialog();
			if (g記事登録 == null)	 g記事登録 = new 記事登録();
			g記事登録.Left = this.Left + (this.Width - g記事登録.Width) / 2;
			g記事登録.Top  = this.Top;
			g記事登録.ShowDialog();
// MOD 2005.05.25 東都）小童谷 画面高速化 END
		}
// ADD 2005.05.16 東都）伊賀 記事登録の追加 END

// ADD 2005.05.24 東都）小童谷 メッセージ登録の追加 START
		private void pic０５_Click(object sender, System.EventArgs e)
		{
// MOD 2006.10.04 東都）山本 店所メニューの切替対応 START
			if(gs店所コード.Trim().Length == 0)
			{
				// MOD 2005.05.27 東都）高木 メッセージ登録画面の追加 START
				//			メッセージ登録 画面 = new メッセージ登録();
				//			画面.Left = this.Left;
				//			画面.Top  = this.Top;
				//			画面.ShowDialog();
				if(gメセ登録 == null) gメセ登録 = new メッセージ登録();
				gメセ登録.Left = this.Left + (this.Width  - gメセ登録.Width)  / 2;
				gメセ登録.Top  = this.Top  + (this.Height - gメセ登録.Height) / 2;
				gメセ登録.ShowDialog();
				// MOD 2005.05.27 東都）高木 メッセージ登録画面の追加 END
			}
			else
			{
// ADD 2007.02.01 東都）高木 営業所-出荷状況一覧対応 START
// MOD 2007.02.19 FJCS）桑田 メニュー順の変更 START
//				if(g出荷状況 == null) g出荷状況 = new 出荷状況();
//				g出荷状況.Left = this.Left + (this.Width  - g出荷状況.Width)  / 2;
//				g出荷状況.Top  = this.Top  + (this.Height - g出荷状況.Height) / 2;
//				g出荷状況.ShowDialog(this);
				if(g発店仕分 == null) g発店仕分 = new 発店仕分();
				g発店仕分.Left = this.Left + (this.Width  - g発店仕分.Width)  / 2;
				g発店仕分.Top  = this.Top  + (this.Height - g発店仕分.Height) / 2;
				g発店仕分.ShowDialog();
// MOD 2007.02.19 FJCS）桑田 メニュー順の変更 END
// ADD 2007.02.01 東都）高木 営業所-出荷状況一覧対応 END
			}
		}
// ADD 2005.05.24 東都）小童谷 メッセージ登録の追加 END

		private void pic０６_MouseEnter(object sender, System.EventArgs e)
		{
			pic０６.Image = imageCmd_b[6];
		}

		private void pic０６_MouseLeave(object sender, System.EventArgs e)
		{
			pic０６.Image = imageCmd_a[6];
		}

		private void pic０７_MouseEnter(object sender, System.EventArgs e)
		{
			pic０７.Image = imageCmd_b[7];
		}

		private void pic０７_MouseLeave(object sender, System.EventArgs e)
		{
			pic０７.Image = imageCmd_a[7];
		}

		private void pic０８_MouseEnter(object sender, System.EventArgs e)
		{
			pic０８.Image = imageCmd_b[8];
		}

		private void pic０８_MouseLeave(object sender, System.EventArgs e)
		{
			pic０８.Image = imageCmd_a[8];
		}

		private void pic０２_MouseEnter(object sender, System.EventArgs e)
		{
			pic０２.Image = imageCmd_b[2];
		}

		private void pic０２_MouseLeave(object sender, System.EventArgs e)
		{
			pic０２.Image = imageCmd_a[2];
		}

		private void pic０９_MouseEnter(object sender, System.EventArgs e)
		{
			pic０９.Image = imageCmd_b[9];
		}

		private void pic０９_MouseLeave(object sender, System.EventArgs e)
		{
			pic０９.Image = imageCmd_a[9];
		}

// ADD 2005.05.24 東都）小童谷 メッセージ登録の追加 START
		private void pic０５_MouseEnter(object sender, System.EventArgs e)
		{
			pic０５.Image = imageCmd_b[5];
		}

		private void pic０５_MouseLeave(object sender, System.EventArgs e)
		{
			pic０５.Image = imageCmd_a[5];
		}
// ADD 2005.05.24 東都）小童谷 メッセージ登録の追加 END

// MOD 2005.05.27 東都）高木 スレッド位置の移動 START
//		private void コマンドイメージの初期化()
		private static void コマンドイメージの初期化()
// MOD 2005.05.27 東都）高木 スレッド位置の移動 END
		{
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
//			if(imageCmd != null) return;
//
//			imageCmd = new Image[15];
//// MOD 2006.10.04 東都）山本 店所メニューの切替対応 START
//			if(gs店所コード.Trim().Length == 0)
//			{
//				imageCmd[0] = Image.FromFile("img\\fm101a.gif");
//				imageCmd[1] = Image.FromFile("img\\fm101b.gif");
//				imageCmd[2] = Image.FromFile("img\\fm102a.gif");
//				imageCmd[3] = Image.FromFile("img\\fm102b.gif");
//				imageCmd[4] = Image.FromFile("img\\fm103a.gif");
//				imageCmd[5] = Image.FromFile("img\\fm103b.gif");
//				imageCmd[6] = Image.FromFile("img\\fm104a.gif");
//				imageCmd[7] = Image.FromFile("img\\fm104b.gif");
//				imageCmd[8] = Image.FromFile("img\\fm105a.gif");
//				imageCmd[9] = Image.FromFile("img\\fm105b.gif");
//				imageCmd[10] = Image.FromFile("img\\upperbar.gif");
//// DEL 2006.07.11 東都）高木 画面変更 START
////				imageCmd[11] = Image.FromFile("img\\sidebar.gif");
//// DEL 2006.07.11 東都）高木 画面変更 END
//// DEL 2005.06.14 東都）高木 不要な為削除 START
////				imageCmd[12] = Image.FromFile("img\\i-start.gif");
//// DEL 2005.06.14 東都）高木 不要な為削除 END
//				imageCmd[13] = Image.FromFile("img\\fm106a.gif");
//				imageCmd[14] = Image.FromFile("img\\fm106b.gif");
//// ADD 2006.07.11 東都）高木 画面変更 START
//				img会員承認a = イメージ設定("img\\fm107a.gif");
//				img会員承認b = イメージ設定("img\\fm107b.gif");
//				img稼働率情a = イメージ設定("img\\fm108a.gif");
//				img稼働率情b = イメージ設定("img\\fm108b.gif");
//				img出荷状況a = イメージ設定("img\\fm109a.gif");
//				img出荷状況b = イメージ設定("img\\fm109b.gif");
//// ADD 2006.07.11 東都）高木 画面変更 END
//			}
//			else
//			{
//				imageCmd[6] = Image.FromFile("img\\fm102a.gif");
//				imageCmd[7] = Image.FromFile("img\\fm102b.gif");
//				imageCmd[10] = Image.FromFile("img\\upperbar.gif");
//// DEL 2006.11.06 東都）高木 店所情報画面の追加 START
////				imageCmd[13] = Image.FromFile("img\\fm支店登録a.gif");
////				imageCmd[14] = Image.FromFile("img\\fm支店登録b.gif");
//// DEL 2006.11.06 東都）高木 店所情報画面の追加 END
//				img会員承認a = イメージ設定("img\\fm201a.gif");
//				img会員承認b = イメージ設定("img\\fm201b.gif");
//				img稼働率情a = イメージ設定("img\\fm203a.gif");
//				img稼働率情b = イメージ設定("img\\fm203b.gif");
//				img出荷状況a = イメージ設定("img\\fm204a.gif");
//				img出荷状況b = イメージ設定("img\\fm204b.gif");
//			}
//// MOD 2006.10.04 東都）山本 店所メニューの切替対応 START
			if(imageCmd_a != null) return;
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
//// MOD 2007.12.04 KCL) 森本 お知らせ追加 START
////		imageCmd_a = new Image[10];
////		imageCmd_b = new Image[10];
//			imageCmd_a = new Image[11];
//			imageCmd_b = new Image[11];
			imageCmd_a = new Image[12];
			imageCmd_b = new Image[12];
// MOD 2007.12.04 KCL) 森本 お知らせ追加 END
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END

			img使用承認a = イメージ設定("img\\fm107a.gif");
			img使用承認b = イメージ設定("img\\fm107b.gif");
			imgお客様情a = イメージ設定("img\\fm104a.gif");
			imgお客様情b = イメージ設定("img\\fm104b.gif");
			img稼働率情a = イメージ設定("img\\fm108a.gif");
			img稼働率情b = イメージ設定("img\\fm108b.gif");
			img出荷状況a = イメージ設定("img\\fm109a.gif");
			img出荷状況b = イメージ設定("img\\fm109b.gif");
			imgメッセジa = イメージ設定("img\\fm106a.gif");
			imgメッセジb = イメージ設定("img\\fm106b.gif");
			img使用登録a = イメージ設定("img\\fm101a.gif");
			img使用登録b = イメージ設定("img\\fm101b.gif");
			img請求先登a = イメージ設定("img\\fm102a.gif");
			img請求先登b = イメージ設定("img\\fm102b.gif");
			img集約店登a = イメージ設定("img\\fm103a.gif");
			img集約店登b = イメージ設定("img\\fm103b.gif");
			img輸送商品a = イメージ設定("img\\fm105a.gif");
			img輸送商品b = イメージ設定("img\\fm105b.gif");

			img使用申込a = イメージ設定("img\\fm201a.gif");
			img使用申込b = イメージ設定("img\\fm201b.gif");
//			img請求先登a = イメージ設定("img\\fm202a.gif");
//			img請求先登b = イメージ設定("img\\fm202b.gif");
			img出荷照会a = イメージ設定("img\\fm203a.gif");
			img出荷照会b = イメージ設定("img\\fm203b.gif");
			img発店仕分a = イメージ設定("img\\fm204a.gif");
			img発店仕分b = イメージ設定("img\\fm204b.gif");
// ADD 2007.12.04 KCL) 森本 お知らせ追加 START
			imgお知らせa = イメージ設定("img\\fm111a.gif");
			imgお知らせb = イメージ設定("img\\fm111b.gif");
// ADD 2007.12.04 KCL) 森本 お知らせ追加 END
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
			imgお知表示a = イメージ設定("img\\fm206a.gif");;
			imgお知表示b = イメージ設定("img\\fm206b.gif");;
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
// MOD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
			imgマニュアa = イメージ設定("img\\fm207a.gif");;
			imgマニュアb = イメージ設定("img\\fm207b.gif");;
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
		}

// ADD 2006.07.11 東都）高木 画面変更 START
		private static Image イメージ設定(string s画像)
		{
			try{
				return Image.FromFile(s画像);
			}catch(FileNotFoundException){
				 ;
			}
			return null;
		}
// ADD 2006.07.11 東都）高木 画面変更 END

// ADD 2005.05.25 東都）小童谷 スレッド化 START
		private static  void ThreadTask()
		{
// ADD 2005.05.27 東都）高木 スレッド位置の変更 START
			if(sv_maintenance == null) sv_maintenance = new is2maintenance.Service1();
// ADD 2005.05.27 東都）高木 スレッド位置の変更 END
// ADD 2007.12.11 KCL) 森本 お知らせ追加 START
			if(sv_oshirase == null) sv_oshirase = new is2oshirase.Service1();
// ADD 2007.12.11 KCL) 森本 お知らせ追加 END
// MOD 2011.01.14 東都）高木 王子運送対応 START
			if(sv_oji == null) sv_oji = new is2oji.Service1();
// MOD 2011.01.14 東都）高木 王子運送対応 END
			if(g会員出力 == null) g会員出力 = new 会員情報ＣＳＶ出力();

// ADD 2005.05.27 東都）高木 メッセージ登録画面の追加 START
			if(gメセ登録 == null) gメセ登録 = new メッセージ登録();
// DEL 2006.10.04 東都）山本 店所メニュー切替対応 START
//			コマンドイメージの初期化();
// DEL 2006.10.04 東都）山本 店所メニュー切替対応 END
// ADD 2005.05.27 東都）高木 メッセージ登録画面の追加 END
// ADD 2006.07.11 東都）高木 画面変更 START
			if(g会員加入 == null) g会員加入 = new 会員加入();
			if(g稼働率情 == null) g稼働率情 = new 稼働率情();
			if(g出荷状況 == null) g出荷状況 = new 出荷状況();
// ADD 2006.07.11 東都）高木 画面変更 END
// ADD 2006.11.06 東都）高木 店所情報画面の追加 START
			if(g店所情報 == null) g店所情報 = new 店所情報();
// ADD 2006.11.06 東都）高木 店所情報画面の追加 END
// ADD 2007.02.06 東都）高木 イメージロードエラー対応 START
			if(g店所入力 == null) g店所入力 = new 店所入力();
// ADD 2007.02.06 東都）高木 イメージロードエラー対応 END
// ADD 2007.02.06 東都）高木 プレビュー画面の高速化 START
			if(gプレビュ == null) gプレビュ = new プレビュー画面();
// ADD 2007.02.06 東都）高木 プレビュー画面の高速化 END
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 START
			if(g稼動日登 == null) g稼動日登 = new 稼働日登録();
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 END

// ADD 2007.11.29 東都）高木 ログイン時のフォーカス障害対応 START
			if(Fログイン != null) Fログイン.Focus();
// ADD 2007.11.29 東都）高木 ログイン時のフォーカス障害対応 END
		}
// ADD 2005.05.25 東都）小童谷 スレッド化 END

// ADD 2006.07.11 東都）高木 画面変更 START
		private void pic０１_MouseEnter(object sender, System.EventArgs e)
		{
			pic０１.Image = imageCmd_b[1];
		}

		private void pic０１_MouseLeave(object sender, System.EventArgs e)
		{
			pic０１.Image = imageCmd_a[1];
		}

		private void pic０３_MouseEnter(object sender, System.EventArgs e)
		{
			pic０３.Image = imageCmd_b[3];
		}

		private void pic０３_MouseLeave(object sender, System.EventArgs e)
		{
			pic０３.Image = imageCmd_a[3];
		}

		private void pic０４_MouseEnter(object sender, System.EventArgs e)
		{
			pic０４.Image = imageCmd_b[4];
		}

		private void pic０４_MouseLeave(object sender, System.EventArgs e)
		{
			pic０４.Image = imageCmd_a[4];
		}
// ADD 2007.12.04 KCL) 森本 お知らせ追加 START
		private void pic１０_MouseEnter(object sender, System.EventArgs e)
		{
			pic１０.Image = imageCmd_b[10];
		}

		private void pic１０_MouseLeave(object sender, System.EventArgs e)
		{
			pic１０.Image = imageCmd_a[10];
		}
// ADD 2007.12.04 KCL) 森本 お知らせ追加 END

		private void pic０１_Click(object sender, System.EventArgs e)
		{
			if(g会員加入 == null) g会員加入 = new 会員加入();
			g会員加入.Left = this.Left;
			g会員加入.Top = this.Top;
			this.Visible = false;
			g会員加入.ShowDialog(this);
			this.Visible = true;
		}

		private void pic０３_Click(object sender, System.EventArgs e)
		{
// ADD 2006.11.24 東都）高木 障害回避の為、実行できなくした START
//			if(gs店所コード.Trim().Length == 0) return;
// ADD 2006.11.24 東都）高木 障害回避の為、実行できなくした END
// MOD 2006.10.04 東都）山本 店所メニューの切替対応 START
			if(gs店所コード.Trim().Length == 0)
			{
				if(g稼働率情 == null) g稼働率情 = new 稼働率情();
				g稼働率情.Left = this.Left + (this.Width  - g稼働率情.Width)  / 2;
				g稼働率情.Top  = this.Top  + (this.Height - g稼働率情.Height) / 2;
				g稼働率情.ShowDialog(this);
			}
			else
			{
// ADD 2006.12.12 東都）高木 画面追加 START
				if(g出荷照会 == null) g出荷照会 = new 出荷照会();
				g出荷照会.Left = this.Left + (this.Width  - g出荷照会.Width)  / 2;
				g出荷照会.Top  = this.Top  + (this.Height - g出荷照会.Height) / 2;
				this.Visible = false;
				g出荷照会.ShowDialog();
				this.Visible = true;
// ADD 2006.12.12 東都）高木 画面追加 END
			}
// MOD 2006.10.04 東都）山本 店所メニューの切替対応 END
		}

		private void pic０４_Click(object sender, System.EventArgs e)
		{
// ADD 2006.11.24 東都）高木 障害回避の為、実行できなくした START
//			if(gs店所コード.Trim().Length == 0) return;
// ADD 2006.11.24 東都）高木 障害回避の為、実行できなくした END
// MOD 2006.10.04 東都）山本 店所メニューの切替対応 START
			if(gs店所コード.Trim().Length == 0)
			{
				if(g出荷状況 == null) g出荷状況 = new 出荷状況();
				g出荷状況.Left = this.Left + (this.Width  - g出荷状況.Width)  / 2;
				g出荷状況.Top  = this.Top  + (this.Height - g出荷状況.Height) / 2;
				g出荷状況.ShowDialog(this);
			}
			else
			{
// MOD 2007.01.18 東都）高木 画面名の変更 START
//// ADD 2006.12.12 東都）高木 画面追加 START
//				if(g着店仕分 == null) g着店仕分 = new 着店仕分();
//				g着店仕分.Left = this.Left + (this.Width  - g着店仕分.Width)  / 2;
//				g着店仕分.Top  = this.Top  + (this.Height - g着店仕分.Height) / 2;
//				g着店仕分.ShowDialog();
//// ADD 2006.12.12 東都）高木 画面追加 END
// MOD 2007.02.19 FJCS）桑田 メニュー順の変更 START
//				if(g発店仕分 == null) g発店仕分 = new 発店仕分();
//				g発店仕分.Left = this.Left + (this.Width  - g発店仕分.Width)  / 2;
//				g発店仕分.Top  = this.Top  + (this.Height - g発店仕分.Height) / 2;
//				g発店仕分.ShowDialog();
				if(g出荷状況 == null) g出荷状況 = new 出荷状況();
				g出荷状況.Left = this.Left + (this.Width  - g出荷状況.Width)  / 2;
				g出荷状況.Top  = this.Top  + (this.Height - g出荷状況.Height) / 2;
				g出荷状況.ShowDialog(this);
// MOD 2007.02.19 FJCS）桑田 メニュー順の変更 END
// MOD 2007.01.18 東都）高木 画面名の変更 END
			}
// MOD 2006.10.04 東都）山本 店所メニューの切替対応 END
		}
// ADD 2006.07.11 東都）高木 画面変更 END

// ADD 2007.12.04 KCL) 森本 お知らせ追加 START
		private void pic１０_Click(object sender, System.EventArgs e)
		{
//保留// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 START
//保留			if(gs店所コード.Trim().Length > 0){
//保留				// お知らせ登録２フォーム表示
//保留				if (gお知登２ == null) gお知登２ = new お知らせ登録２();
//保留				gお知登２.Left = this.Left;
//保留				gお知登２.Top  = this.Top;
//保留				this.Visible = false;
//保留				gお知登２.ShowDialog(this);
//保留				this.Visible = true;
//保留				return;
//保留			}
//保留// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 END
			// お知らせ登録フォーム表示
			if (gお知登録 == null) gお知登録 = new お知らせ登録();
			gお知登録.Left = this.Left;
			gお知登録.Top  = this.Top;
			this.Visible = false;
			gお知登録.ShowDialog(this);
			this.Visible = true;
		}
// ADD 2007.12.04 KCL) 森本 お知らせ追加 END

// ADD 2007.01.31 東都）高木 管理者-営業所画面切替変更 START
		private void btn切替_Click(object sender, System.EventArgs e)
		{
// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 START
			// 管理者会員の場合
			if(gs管理者区分 != "1") return;
// MOD 2009.08.07 東都）高木 切替ボタンの制御障害対応 END

			if(gs店所コード.Trim().Length == 0)
			{
				// 店所入力画面を表示
				if(g店所入力 == null) g店所入力 = new 店所入力();
				g店所入力.ShowDialog();
			}
			else
			{
				gs店所コード = "";
			}
			//ボタン表示の変更
			メニューボタン設定();
		}

		private void メニューボタン設定()
		{
// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 START
			btn旧店所.Visible = false;
			btn旧店所.Text    = "";
			gs店所コード = gs店所コード.Trim();
// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 END
//保留 ADD 2008.01.06 東都）高木 メニュー０２拡張対応 START
//			if(gs店所コード.Trim().Length == 0 && btnメニュー０２.Text == "メニュー０２")
//			{
//				imageCmd_a[1] = imgパス照会a;
//				imageCmd_b[1] = imgパス照会b;
//				pic０１.Image = imageCmd_a[1];
//
//				pic０６.Visible = false;
//				pic０７.Visible = false;
//				pic０８.Visible = false;
//				pic０９.Visible = false;
//				pic１０.Visible = false;
//
//				btn切替.Text = "営業所\nメニュー";
//				btnメニュー０２.Text = "メニュー０１";
//				btnメニュー０２.Visible = true;
//			}
//			else
//保留 ADD 2008.01.06 東都）高木 メニュー０２拡張対応 END
			if(gs店所コード.Trim().Length == 0)
			{
				imageCmd_a[1] = img使用承認a;
				imageCmd_b[1] = img使用承認b;
				imageCmd_a[2] = imgお客様情a;
				imageCmd_b[2] = imgお客様情b;
				imageCmd_a[3] = img稼働率情a;
				imageCmd_b[3] = img稼働率情b;
				imageCmd_a[4] = img出荷状況a;
				imageCmd_b[4] = img出荷状況b;
				imageCmd_a[5] = imgメッセジa;
				imageCmd_b[5] = imgメッセジb;

				imageCmd_a[6] = img使用登録a;
				imageCmd_b[6] = img使用登録b;
				imageCmd_a[7] = img請求先登a;
				imageCmd_b[7] = img請求先登b;
				imageCmd_a[8] = img集約店登a;
				imageCmd_b[8] = img集約店登b;
				imageCmd_a[9] = img輸送商品a;
				imageCmd_b[9] = img輸送商品b;

// ADD 2007.12.04 KCL) 森本 お知らせ追加 START
				imageCmd_a[10] = imgお知らせa;
				imageCmd_b[10] = imgお知らせb;
// ADD 2007.12.04 KCL) 森本 お知らせ追加 END

				pic０１.Image = imageCmd_a[1];
				pic０２.Image = imageCmd_a[2];
				pic０３.Image = imageCmd_a[3];
				pic０４.Image = imageCmd_a[4];
				pic０５.Image = imageCmd_a[5];
				pic０６.Image = imageCmd_a[6];
				pic０７.Image = imageCmd_a[7];
				pic０８.Image = imageCmd_a[8];
				pic０９.Image = imageCmd_a[9];
// ADD 2007.12.04 KCL) 森本 お知らせ追加 START
				pic１０.Image = imageCmd_a[10];
// ADD 2007.12.04 KCL) 森本 お知らせ追加 END

// DEL 2007.02.01 東都）高木 営業所-出荷状況一覧対応 START
//				pic０５.Visible = true;
// DEL 2007.02.01 東都）高木 営業所-出荷状況一覧対応 END
				pic０６.Visible = true;
				pic０７.Visible = true;
				pic０８.Visible = true;
				pic０９.Visible = true;
// ADD 2007.12.04 KCL) 森本 お知らせ追加 START
				pic１０.Visible = true;
// ADD 2007.12.04 KCL) 森本 お知らせ追加 END

				btn切替.Text = "営業所\nメニュー";
//保留 ADD 2008.01.06 東都）高木 メニュー０２拡張対応 START
//				btnメニュー０２.Text = "メニュー０２";
//				btnメニュー０２.Visible = true;
//保留 ADD 2008.01.06 東都）高木 メニュー０２拡張対応 END
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 START
				btn稼働日登録.Visible = true;
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 END
// ADD 2010.06.05 KCL) 森本 BLUEDI管理画面呼出機能の追加 START
				btnBLUEDI管理.Visible = true;
// ADD 2010.06.05 KCL) 森本 BLUEDI管理画面呼出機能の追加 START
			}
			else
			{
				imageCmd_a[1] = img使用申込a;
				imageCmd_b[1] = img使用申込b;
				imageCmd_a[2] = img請求先登a;
				imageCmd_b[2] = img請求先登b;
				imageCmd_a[3] = img出荷照会a;
				imageCmd_b[3] = img出荷照会b;
// MOD 2007.02.19 FJCS）桑田 メニュー順変更 START
//				imageCmd_a[4] = img発店仕分a;
//				imageCmd_b[4] = img発店仕分b;
				imageCmd_a[4] = img出荷状況a;
				imageCmd_b[4] = img出荷状況b;
// ADD 2007.02.01 東都）高木 営業所-出荷状況一覧対応 START
//				imageCmd_a[5] = img出荷状況a;
//				imageCmd_b[5] = img出荷状況b;
// ADD 2007.02.01 東都）高木 営業所-出荷状況一覧対応 END
				imageCmd_a[5] = img発店仕分a;
				imageCmd_b[5] = img発店仕分b;
// MOD 2007.02.19 FJCS）桑田 メニュー順変更 END
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
				imageCmd_a[6] = imgお知表示a;
				imageCmd_b[6] = imgお知表示b;
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
				imageCmd_a[7] = imgマニュアa;
				imageCmd_b[7] = imgマニュアb;
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
				pic０１.Image = imageCmd_a[1];
				pic０２.Image = imageCmd_a[2];
				pic０３.Image = imageCmd_a[3];
				pic０４.Image = imageCmd_a[4];
// ADD 2007.02.01 東都）高木 営業所-出荷状況一覧対応 START
				pic０５.Image = imageCmd_a[5];
// ADD 2007.02.01 東都）高木 営業所-出荷状況一覧対応 END
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
				pic０６.Image = imageCmd_a[6];
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
				pic０７.Image = imageCmd_a[7];
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
//保留// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 START
//保留				pic１０.Image = imageCmd_a[10];
//保留// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 END

// DEL 2007.02.01 東都）高木 営業所-出荷状況一覧対応 START
//				pic０５.Visible = false;
// DEL 2007.02.01 東都）高木 営業所-出荷状況一覧対応 END
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
//// ADD 2009.04.23 KCL) 森本 使用申し込み登録を非表示に START
//				pic０６.Visible = false;
//// ADD 2009.04.23 KCL) 森本 使用申し込み登録を非表示に END
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 START
//				pic０７.Visible = false;
// MOD 2009.12.01 PSN）藤井 マニュアルダウンロード機能の追加 END
				pic０８.Visible = false;
				pic０９.Visible = false;
//保留// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 START
//保留//// ADD 2007.12.04 KCL) 森本 お知らせ追加 START
				pic１０.Visible = false;
//保留//// ADD 2007.12.04 KCL) 森本 お知らせ追加 END
//保留				pic１０.Visible = true;
//保留// MOD 2010.06.29 東都）高木 営業所用お知らせ登録機能の追加 END

				btn切替.Text = "管理\nメニュー";
// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 START
				if(gs店所コード == "255")
				{
					btn旧店所.Text    = "旧店所\nコード\n(260)";
					btn旧店所.Visible = true;
				}
				else if(gs店所コード == "260")
				{
					btn旧店所.Text    = "新店所\nコード\n(255)";
					btn旧店所.Visible = true;
// MOD 2010.09.30 東都）高木 埼玉福山通運対応 START
				}else if(gs店所コード == "263"){ // 所沢
					btn旧店所.Text    = "埼玉福通\n所沢\n(353)";
					btn旧店所.Visible = true;
				}else if(gs店所コード == "353"){ // 埼玉福山通運：所沢
					btn旧店所.Text    = "所沢\n(263)";
					btn旧店所.Visible = true;
				}else if(gs店所コード == "264"){ // 深谷
					btn旧店所.Text    = "埼玉福通\n深谷\n(347)";
					btn旧店所.Visible = true;
				}else if(gs店所コード == "347"){ // 埼玉福山通運：深谷
					btn旧店所.Text    = "深谷\n(264)";
					btn旧店所.Visible = true;
				}else if(gs店所コード == "265"){ // 川越
					btn旧店所.Text    = "埼玉福通\n川越\n(333)";
					btn旧店所.Visible = true;
				}else if(gs店所コード == "333"){ // 埼玉福山通運：川越
					btn旧店所.Text    = "川越\n(265)";
					btn旧店所.Visible = true;
// MOD 2010.09.30 東都）高木 埼玉福山通運対応 END
// MOD 2011.05.25 東都）高木 仙台支店対応 START
				}else if(gs店所コード == "161"){ // 旧仙台
// MOD 2011.06.30 東都）高木 仙台中央支店対応 START
//					btn旧店所.Text    = "仙台北\n(162)";
					btn旧店所.Text    = "仙台中央\n(162)";
// MOD 2011.06.30 東都）高木 仙台中央支店対応 END
					btn旧店所.Visible = true;
				}else if(gs店所コード == "162"){ // 仙台中央
// MOD 2011.06.30 東都）高木 仙台中央支店対応 START
//					btn旧店所.Text    = "仙台\n(161)";
					btn旧店所.Text    = "旧仙台\n(161)";
// MOD 2011.06.30 東都）高木 仙台中央支店対応 END
					btn旧店所.Visible = true;
// MOD 2011.05.25 東都）高木 仙台支店対応 END
				}
// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 END
//保留 ADD 2008.01.06 東都）高木 メニュー０２拡張対応 START
//				btnメニュー０２.Text = "";
//				btnメニュー０２.Visible = false;
//保留 ADD 2008.01.06 東都）高木 メニュー０２拡張対応 END
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 START
				btn稼働日登録.Visible = false;
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 END
// ADD 2010.06.05 KCL) 森本 BLUEDI管理画面呼出機能の追加 START
				btnBLUEDI管理.Visible = false;
// ADD 2010.06.05 KCL) 森本 BLUEDI管理画面呼出機能の追加 START
			}
		}
// ADD 2007.01.31 東都）高木 管理者-営業所画面切替変更 END

// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 END
		private void btn旧店所_Click(object sender, System.EventArgs e)
		{
			if(gs店所コード.Length == 0) return;

			if(gs店所コード == "255")
			{
				gs店所コード      = "260";
			}
			else if(gs店所コード == "260")
			{
				gs店所コード      = "255";
// ADD 2010.09.30 東都）高木 埼玉福山通運対応 START
			}else if(gs店所コード == "263"){ // 所沢
				gs店所コード      = "353";
			}else if(gs店所コード == "353"){ // 埼玉福山通運：所沢
				gs店所コード      = "263";
			}else if(gs店所コード == "264"){ // 深谷
				gs店所コード      = "347";
			}else if(gs店所コード == "347"){ // 埼玉福山通運：深谷
				gs店所コード      = "264";
			}else if(gs店所コード == "265"){ // 川越
				gs店所コード      = "333";
			}else if(gs店所コード == "333"){ // 埼玉福山通運：川越
				gs店所コード      = "265";
// ADD 2010.09.30 東都）高木 埼玉福山通運対応 END
// MOD 2011.05.25 東都）高木 仙台支店対応 START
			}else if(gs店所コード == "161"){ // 旧仙台
				gs店所コード      = "162";
			}else if(gs店所コード == "162"){ // 仙台中央
				gs店所コード      = "161";
// MOD 2011.05.25 東都）高木 仙台支店対応 END
			}
			
			//ボタン表示の変更
			メニューボタン設定();
		}
// ADD 2007.09.25 東都）高木 いばらぎ坂東系列移管対応 END

// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 START
		private void btn稼働日登録_Click(object sender, System.EventArgs e)
		{
			g稼動日登.Left = this.Left;
			g稼動日登.Top = this.Top;
			this.Visible = false;
			g稼動日登.ShowDialog();
			this.Visible = true;
		}
// ADD 2009.04.07 東都）高木 稼働日の管理機能の追加 END
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 START
		private string [] お知らせ詳細内容取得(string s登録日, string sシーケンスＮｏ) 
		{
			string [] sResults = new string[3];

			// 引数設定
			string [] sKey = new string [2];
			sKey[0] = s登録日;
			sKey[1] = sシーケンスＮｏ;

			// お知らせ情報取得
			string [] sRet = null;
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2AdminClient.is2oshirase.Service1();
				sRet = sv_oshirase.Sel_Oshirase(gsaユーザ, sKey);
			}
			catch (System.Net.WebException)
			{
				// 通信エラー発生
				sRet[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				// その他のエラー発生
				sRet[0] = "通信エラー：" + ex.Message;
			}

			// 結果処理
			switch (sRet[0].Trim()) 
			{
				case "正常終了" :	// 正常終了の場合

					// 詳細内容、ボタン名、アドレスを返す
					sResults[0] = sRet[3].Replace("\n", "\r\n");		// 詳細内容
					sResults[1] = sRet[4];								// ボタン名
					sResults[2] = sRet[5];								// アドレス

					break;

				default :			// 異常終了の場合

					// 空文字列を返す
					sResults[0] = sResults[1] = sResults[2] = string.Empty;
					// 警告音
					ビープ音();
					// エラーメッセージ表示
					texメッセージ.Text = sRet[0];

					break;
			}

			return sResults;
		}
		private void picお知らせ１_Click(object sender, System.EventArgs e)
		{
			if (sお知らせ一覧.Length > 0) 
			{
				this.お知らせ詳細表示(1);
			}
		}

		private void picお知らせ２_Click(object sender, System.EventArgs e)
		{
			if (sお知らせ一覧.Length > 1) 
			{
				this.お知らせ詳細表示(2);
			}
		}

		private void picお知らせ３_Click(object sender, System.EventArgs e)
		{
			if (sお知らせ一覧.Length > 2) 
			{
				this.お知らせ詳細表示(3);
			}
		}

		private void picお知らせ４_Click(object sender, System.EventArgs e)
		{
			if (sお知らせ一覧.Length > 3) 
			{
				this.お知らせ詳細表示(4);
			}
		}

		private void picお知らせ５_Click(object sender, System.EventArgs e)
		{
			if (sお知らせ一覧.Length > 4) 
			{
				this.お知らせ詳細表示(5);
			}
		}

		private void お知らせ詳細表示(int no) 
		{
			int idx = no - 1;

			if (gお知表示 == null) gお知表示 = new お知らせ表示();
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			if((sお知らせ一覧[idx]).Length > 4 && sお知らせ一覧[idx][4].Equals("2")){
				gお知表示.iモード	= 1;
			}else{
				gお知表示.iモード	= 0;
			}
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			gお知表示.s登録日	= sお知らせ一覧[idx][0];
			gお知表示.s表題		= sお知らせ一覧[idx][1];
			string [] naiyo		= this.お知らせ詳細内容取得(sお知らせ一覧[idx][2], sお知らせ一覧[idx][3]);
			gお知表示.s詳細内容	= naiyo[0];
			gお知表示.sボタン名  = naiyo[1];
			gお知表示.sアドレス	= naiyo[2];
			gお知表示.Top		= this.Top;
			gお知表示.Left		= this.Left;
			this.Visible		= false;
			gお知表示.ShowDialog(this);
			this.Visible		= true;
		}
		private void お知らせ初期設定() 
		{
			// お知らせ表題ボタンを配列にする
			btnList[0] = btnお知らせ１;
			btnList[1] = btnお知らせ２;
			btnList[2] = btnお知らせ３;
			btnList[3] = btnお知らせ４;
			btnList[4] = btnお知らせ５;
		}
		private void お知らせの取得と表示() 
		{
			// お知らせ取得条件の設定
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
//			string [] sKey = new string [5];
			string [] sKey = new string [6];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
			sKey[0] = string.Empty;		// 開始登録日
			sKey[1] = string.Empty;		// 終了登録日
			sKey[2] = string.Empty;		// 表題
			sKey[3] = string.Empty;		// 詳細内容
			sKey[4] = "5";				// 上位Ｎ件
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
			sKey[5] = "お知らせボタン";	// 機能
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END

			// お知らせ一覧を取得
			string [] sRet = null;
			try
			{
				if (sv_oshirase == null) sv_oshirase = new is2oshirase.Service1();
				sRet = sv_oshirase.Get_OshiraseTopN(gsaユーザ, sKey);
			}
			catch (System.Net.WebException)
			{
				// 通信エラー発生
				sRet[0] = gs通信エラー;
			}
			catch (Exception ex)
			{
				// その他のエラー発生
				sRet[0] = "通信エラー：" + ex.Message;
			}

			// 結果処理
			try 
			{
				switch (sRet[0].Trim()) 
				{
					case "正常終了" :		// 正常終了の場合

						// お知らせ取得
						sお知らせ一覧 = new string [sRet.Length - 1][];
						for (int i=1; i<sRet.Length; i++) 
						{
							string [] s項目 = sRet[i].Split('|');
							sお知らせ一覧[i-1] = new string [] {
															 s項目[1],	// 登録日（表示用）
															 s項目[2],	// 表題
															 s項目[3],	// 登録日（数字８桁）
															 s項目[4]	// シーケンスＮｏ
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
															 ,s項目[5]	// 管理者区分
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
														 };
						}

						break;

					default :				// 異常終了の場合

						throw new Exception(sRet[0]);
				}
			} 
			catch (Exception ex) 
			{
				// お知らせの取得に失敗

				// ボタンをすべて非表示に
				for (int i=0; i<5; i++) 
				{
					btnList[i].Visible = false;
				}
				// 警告音
				ビープ音();
				// エラーメッセージ表示
				texメッセージ.Text = "お知らせの取得に失敗しました。" + ex.Message;

				return;
			}

			// お知らせボタンを表示
			for (int i=0; i<5; i++) 
			{
				if (sお知らせ一覧.Length > i) 
				{
					// 表示するお知らせ有

					// ボタンを表示
					btnList[i].Visible = true;

					// 登録日と表題を表示
					btnList[i].日付 = sお知らせ一覧[i][0];
					btnList[i].表題 = sお知らせ一覧[i][1];
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 START
					if(sお知らせ一覧[i][4].Equals("2")){
						btnList[i].モード = 1;
					}else{
						btnList[i].モード = 0;
					}
// MOD 2009.06.08 東都）高木 営業所用お知らせ表示機能の追加 END
// MOD 2016.01.22 BEVAS) 松本 お知らせボタンの色切替え改修 START
					//お知らせ表題の先頭に「【重要】」が付くときは、ボタンの色を変える
					if(sお知らせ一覧[i][1].StartsWith("【重要】"))
					{
						btnList[i].モード = 2;
					}
// MOD 2016.01.22 BEVAS) 松本 お知らせボタンの色切替え改修 END
				} 
				else 
				{
					// 表示するお知らせ無

					// ボタンを表示しない
					btnList[i].Visible = false;
				}
			}
		}
// MOD 2009.06.08 東都）高木 お知らせ表示機能の追加 END

// ADD 2010.06.05 KCL) 森本 BLUEDI管理画面呼出機能の追加 START
		private void btnBLUEDI管理_Click(object sender, System.EventArgs e)
		{
			string path = Path.Combine(System.Environment.CurrentDirectory, "BLUEDIAdminClient.exe");
			System.Diagnostics.Process.Start(path, "v@NmA?:fvQ(7#r*g");
		}
// ADD 2010.06.05 KCL) 森本 BLUEDI管理画面呼出機能の追加 END
	}
}
