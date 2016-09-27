using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;
using System.Net;

namespace is2AdminClient
{
	/// <summary>
	/// [マニュアルダウンロード]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// ADD 2009.12.01 PSN) 藤井 新規作成 
	//--------------------------------------------------------------------------
	// MOD 2010.04.02 PSN) 藤井 参照PDFの変更 
	// MOD 2010.04.13 東都）高木 『ｉSTAR-2新規荷主申込付随書』等追加 
	// MOD 2010.06.01 PSN) 藤井、東都）高木 FAQのWeb表示の追加 
	//--------------------------------------------------------------------------
	// MOD 2011.06.22 東都）高木 王子運送対応 
	//--------------------------------------------------------------------------
	// MOD 2011.08.09 アクト）川上 新荷主EDI、Bluetooth対応新規設置手順書操作マニュアル追加 
	//--------------------------------------------------------------------------
	// MOD 2015.04.24 BEVAS)前田　SSアイテム版紹介資料ダウンロードボタンの追加
	// MOD 2015.04.24 BEVAS)前田　iS2自動出力マニュアルダウンロードボタンの追加
	//--------------------------------------------------------------------------
	// MOD 2016.05.19 BEVAS）松本　iS2プリンタ交換依頼書ダウンロードボタンの追加
	//--------------------------------------------------------------------------
	public class マニュアルダウンロード : 共通フォーム
	{
		public string sマニュアルＵＲＬ = "";
// MOD 2011.06.22 東都）高木 王子運送対応 START
		private string s会社区分 = "";
// MOD 2011.06.22 東都）高木 王子運送対応 END

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.TextBox texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label lab日時;
		private System.Windows.Forms.Timer timer1;
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btniS2マニュアル６;
		private System.Windows.Forms.Button btniS2マニュアル５;
		private System.Windows.Forms.Button btniS2マニュアル４;
		private System.Windows.Forms.Button btniS2マニュアル３;
		private System.Windows.Forms.Button btniS2マニュアル２;
		private System.Windows.Forms.Button btniS2マニュアル１;
		private System.Windows.Forms.Button btnSSマニュアル２;
		private System.Windows.Forms.Button btnSSマニュアル１;
		private System.Windows.Forms.Button btnその他１;
		private System.Windows.Forms.Label labマニュアルダウンロードタイトル;
		private System.Windows.Forms.GroupBox grbiS2;
		private System.Windows.Forms.GroupBox grbSS;
		private System.Windows.Forms.GroupBox grbその他;
		private System.Windows.Forms.Button btnその他２;
		private System.Windows.Forms.Button btnその他３;
		private System.Windows.Forms.Label labその他３;
		private System.Windows.Forms.Label labその他２;
		private System.Windows.Forms.Label labその他１;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btniS2FAQ;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btnSSマニュアル３;
		private System.Windows.Forms.Button btnSSマニュアル４;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button btnSSマニュアル２c;
		private System.Windows.Forms.Button btnSSマニュアル3別紙;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label labその他４;
		private System.Windows.Forms.Button btnその他４;
		private System.Windows.Forms.Label label6;
		//private decimal d更新日時		= 0m;

		public マニュアルダウンロード()
		{
			//
			// Windows フォーム デザイナ サポートに必要です。
			//
			InitializeComponent();
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
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab日時 = new System.Windows.Forms.Label();
			this.labマニュアルダウンロードタイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texメッセージ = new System.Windows.Forms.TextBox();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.grbiS2 = new System.Windows.Forms.GroupBox();
			this.btniS2FAQ = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.btniS2マニュアル６ = new System.Windows.Forms.Button();
			this.btniS2マニュアル５ = new System.Windows.Forms.Button();
			this.btniS2マニュアル４ = new System.Windows.Forms.Button();
			this.btniS2マニュアル３ = new System.Windows.Forms.Button();
			this.btniS2マニュアル２ = new System.Windows.Forms.Button();
			this.btniS2マニュアル１ = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.grbSS = new System.Windows.Forms.GroupBox();
			this.label12 = new System.Windows.Forms.Label();
			this.btnSSマニュアル２c = new System.Windows.Forms.Button();
			this.btnSSマニュアル3別紙 = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btnSSマニュアル４ = new System.Windows.Forms.Button();
			this.btnSSマニュアル３ = new System.Windows.Forms.Button();
			this.btnSSマニュアル２ = new System.Windows.Forms.Button();
			this.btnSSマニュアル１ = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.grbその他 = new System.Windows.Forms.GroupBox();
			this.btnその他４ = new System.Windows.Forms.Button();
			this.labその他４ = new System.Windows.Forms.Label();
			this.btnその他３ = new System.Windows.Forms.Button();
			this.btnその他２ = new System.Windows.Forms.Button();
			this.labその他３ = new System.Windows.Forms.Label();
			this.labその他２ = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.btnその他１ = new System.Windows.Forms.Button();
			this.labその他１ = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.grbiS2.SuspendLayout();
			this.grbSS.SuspendLayout();
			this.grbその他.SuspendLayout();
			this.SuspendLayout();
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
			this.panel7.Controls.Add(this.lab日時);
			this.panel7.Controls.Add(this.labマニュアルダウンロードタイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(798, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab日時
			// 
			this.lab日時.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab日時.ForeColor = System.Drawing.Color.White;
			this.lab日時.Location = new System.Drawing.Point(674, 8);
			this.lab日時.Name = "lab日時";
			this.lab日時.Size = new System.Drawing.Size(112, 14);
			this.lab日時.TabIndex = 2;
			this.lab日時.Text = "2005/xx/xx 12:00:00";
			// 
			// labマニュアルダウンロードタイトル
			// 
			this.labマニュアルダウンロードタイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labマニュアルダウンロードタイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labマニュアルダウンロードタイトル.ForeColor = System.Drawing.Color.White;
			this.labマニュアルダウンロードタイトル.Location = new System.Drawing.Point(12, 2);
			this.labマニュアルダウンロードタイトル.Name = "labマニュアルダウンロードタイトル";
			this.labマニュアルダウンロードタイトル.Size = new System.Drawing.Size(264, 24);
			this.labマニュアルダウンロードタイトル.TabIndex = 0;
			this.labマニュアルダウンロードタイトル.Text = "マニュアルダウンロード";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(792, 58);
			this.panel8.TabIndex = 2;
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(260, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(530, 50);
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
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// grbiS2
			// 
			this.grbiS2.Controls.Add(this.btniS2FAQ);
			this.grbiS2.Controls.Add(this.label4);
			this.grbiS2.Controls.Add(this.btniS2マニュアル６);
			this.grbiS2.Controls.Add(this.btniS2マニュアル５);
			this.grbiS2.Controls.Add(this.btniS2マニュアル４);
			this.grbiS2.Controls.Add(this.btniS2マニュアル３);
			this.grbiS2.Controls.Add(this.btniS2マニュアル２);
			this.grbiS2.Controls.Add(this.btniS2マニュアル１);
			this.grbiS2.Controls.Add(this.label8);
			this.grbiS2.Controls.Add(this.label16);
			this.grbiS2.Controls.Add(this.label17);
			this.grbiS2.Controls.Add(this.label18);
			this.grbiS2.Controls.Add(this.label19);
			this.grbiS2.Controls.Add(this.label20);
			this.grbiS2.Controls.Add(this.label22);
			this.grbiS2.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.grbiS2.ForeColor = System.Drawing.Color.Green;
			this.grbiS2.Location = new System.Drawing.Point(36, 60);
			this.grbiS2.Name = "grbiS2";
			this.grbiS2.Size = new System.Drawing.Size(350, 446);
			this.grbiS2.TabIndex = 28;
			this.grbiS2.TabStop = false;
			// 
			// btniS2FAQ
			// 
			this.btniS2FAQ.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2FAQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2FAQ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2FAQ.ForeColor = System.Drawing.Color.White;
			this.btniS2FAQ.Location = new System.Drawing.Point(256, 354);
			this.btniS2FAQ.Name = "btniS2FAQ";
			this.btniS2FAQ.Size = new System.Drawing.Size(72, 22);
			this.btniS2FAQ.TabIndex = 96;
			this.btniS2FAQ.TabStop = false;
			this.btniS2FAQ.Text = "Ｗｅｂ";
			this.btniS2FAQ.Click += new System.EventHandler(this.btniS2FAQ_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label4.Location = new System.Drawing.Point(24, 360);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(168, 16);
			this.label4.TabIndex = 95;
			this.label4.Text = "（７）　ＦＡＱ（よくある質問）";
			// 
			// btniS2マニュアル６
			// 
			this.btniS2マニュアル６.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2マニュアル６.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2マニュアル６.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2マニュアル６.ForeColor = System.Drawing.Color.White;
			this.btniS2マニュアル６.Location = new System.Drawing.Point(256, 310);
			this.btniS2マニュアル６.Name = "btniS2マニュアル６";
			this.btniS2マニュアル６.Size = new System.Drawing.Size(72, 22);
			this.btniS2マニュアル６.TabIndex = 94;
			this.btniS2マニュアル６.TabStop = false;
			this.btniS2マニュアル６.Text = "ダウンロード";
			this.btniS2マニュアル６.Click += new System.EventHandler(this.btniS2マニュアル６_Click);
			// 
			// btniS2マニュアル５
			// 
			this.btniS2マニュアル５.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2マニュアル５.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2マニュアル５.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2マニュアル５.ForeColor = System.Drawing.Color.White;
			this.btniS2マニュアル５.Location = new System.Drawing.Point(256, 257);
			this.btniS2マニュアル５.Name = "btniS2マニュアル５";
			this.btniS2マニュアル５.Size = new System.Drawing.Size(72, 22);
			this.btniS2マニュアル５.TabIndex = 93;
			this.btniS2マニュアル５.TabStop = false;
			this.btniS2マニュアル５.Text = "ダウンロード";
			this.btniS2マニュアル５.Click += new System.EventHandler(this.btniS2マニュアル５_Click);
			// 
			// btniS2マニュアル４
			// 
			this.btniS2マニュアル４.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2マニュアル４.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2マニュアル４.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2マニュアル４.ForeColor = System.Drawing.Color.White;
			this.btniS2マニュアル４.Location = new System.Drawing.Point(255, 200);
			this.btniS2マニュアル４.Name = "btniS2マニュアル４";
			this.btniS2マニュアル４.Size = new System.Drawing.Size(72, 22);
			this.btniS2マニュアル４.TabIndex = 92;
			this.btniS2マニュアル４.TabStop = false;
			this.btniS2マニュアル４.Text = "ダウンロード";
			this.btniS2マニュアル４.Click += new System.EventHandler(this.btniS2マニュアル４_Click);
			// 
			// btniS2マニュアル３
			// 
			this.btniS2マニュアル３.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2マニュアル３.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2マニュアル３.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2マニュアル３.ForeColor = System.Drawing.Color.White;
			this.btniS2マニュアル３.Location = new System.Drawing.Point(256, 152);
			this.btniS2マニュアル３.Name = "btniS2マニュアル３";
			this.btniS2マニュアル３.Size = new System.Drawing.Size(72, 22);
			this.btniS2マニュアル３.TabIndex = 91;
			this.btniS2マニュアル３.TabStop = false;
			this.btniS2マニュアル３.Text = "ダウンロード";
			this.btniS2マニュアル３.Click += new System.EventHandler(this.btniS2マニュアル３_Click);
			// 
			// btniS2マニュアル２
			// 
			this.btniS2マニュアル２.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2マニュアル２.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2マニュアル２.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2マニュアル２.ForeColor = System.Drawing.Color.White;
			this.btniS2マニュアル２.Location = new System.Drawing.Point(256, 96);
			this.btniS2マニュアル２.Name = "btniS2マニュアル２";
			this.btniS2マニュアル２.Size = new System.Drawing.Size(72, 22);
			this.btniS2マニュアル２.TabIndex = 90;
			this.btniS2マニュアル２.TabStop = false;
			this.btniS2マニュアル２.Text = "ダウンロード";
			this.btniS2マニュアル２.Click += new System.EventHandler(this.btniS2マニュアル２_Click);
			// 
			// btniS2マニュアル１
			// 
			this.btniS2マニュアル１.BackColor = System.Drawing.Color.SteelBlue;
			this.btniS2マニュアル１.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btniS2マニュアル１.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btniS2マニュアル１.ForeColor = System.Drawing.Color.White;
			this.btniS2マニュアル１.Location = new System.Drawing.Point(256, 45);
			this.btniS2マニュアル１.Name = "btniS2マニュアル１";
			this.btniS2マニュアル１.Size = new System.Drawing.Size(72, 22);
			this.btniS2マニュアル１.TabIndex = 89;
			this.btniS2マニュアル１.TabStop = false;
			this.btniS2マニュアル１.Text = "ダウンロード";
			this.btniS2マニュアル１.Click += new System.EventHandler(this.btniS2マニュアル１_Click);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label8.Location = new System.Drawing.Point(24, 313);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(216, 16);
			this.label8.TabIndex = 76;
			this.label8.Text = "（６）　SATOプリンタ再セットアップ手引き";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label16.Location = new System.Drawing.Point(24, 260);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(200, 16);
			this.label16.TabIndex = 75;
			this.label16.Text = "（５）　iSTAR-2再セットアップ手引き";
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label17.Location = new System.Drawing.Point(23, 207);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(200, 16);
			this.label17.TabIndex = 74;
			this.label17.Text = "（４）　iSTAR-2セットアップ手引き";
			// 
			// label18
			// 
			this.label18.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label18.Location = new System.Drawing.Point(24, 155);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(200, 16);
			this.label18.TabIndex = 73;
			this.label18.Text = "（３）　iSTAR-2営業所マニュアル";
			// 
			// label19
			// 
			this.label19.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label19.Location = new System.Drawing.Point(24, 99);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(200, 16);
			this.label19.TabIndex = 72;
			this.label19.Text = "（２）　iSTAR-2簡易マニュアル";
			// 
			// label20
			// 
			this.label20.Cursor = System.Windows.Forms.Cursors.No;
			this.label20.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label20.Location = new System.Drawing.Point(24, 48);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(192, 16);
			this.label20.TabIndex = 70;
			this.label20.Text = "（１）　iSTAR-2操作マニュアル";
			// 
			// label22
			// 
			this.label22.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label22.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label22.ForeColor = System.Drawing.Color.White;
			this.label22.Location = new System.Drawing.Point(0, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(349, 20);
			this.label22.TabIndex = 68;
			this.label22.Text = "iSTAR-2";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grbSS
			// 
			this.grbSS.Controls.Add(this.label12);
			this.grbSS.Controls.Add(this.btnSSマニュアル２c);
			this.grbSS.Controls.Add(this.btnSSマニュアル3別紙);
			this.grbSS.Controls.Add(this.label11);
			this.grbSS.Controls.Add(this.label10);
			this.grbSS.Controls.Add(this.btnSSマニュアル４);
			this.grbSS.Controls.Add(this.btnSSマニュアル３);
			this.grbSS.Controls.Add(this.btnSSマニュアル２);
			this.grbSS.Controls.Add(this.btnSSマニュアル１);
			this.grbSS.Controls.Add(this.label1);
			this.grbSS.Controls.Add(this.label2);
			this.grbSS.Controls.Add(this.label7);
			this.grbSS.Controls.Add(this.label9);
			this.grbSS.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.grbSS.ForeColor = System.Drawing.Color.Honeydew;
			this.grbSS.Location = new System.Drawing.Point(410, 72);
			this.grbSS.Name = "grbSS";
			this.grbSS.Size = new System.Drawing.Size(350, 222);
			this.grbSS.TabIndex = 30;
			this.grbSS.TabStop = false;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label12.Location = new System.Drawing.Point(54, 104);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(200, 16);
			this.label12.TabIndex = 96;
			this.label12.Text = "操作手引書別紙";
			// 
			// btnSSマニュアル２c
			// 
			this.btnSSマニュアル２c.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSSマニュアル２c.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSSマニュアル２c.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSSマニュアル２c.ForeColor = System.Drawing.Color.White;
			this.btnSSマニュアル２c.Location = new System.Drawing.Point(264, 124);
			this.btnSSマニュアル２c.Name = "btnSSマニュアル２c";
			this.btnSSマニュアル２c.Size = new System.Drawing.Size(72, 22);
			this.btnSSマニュアル２c.TabIndex = 95;
			this.btnSSマニュアル２c.TabStop = false;
			this.btnSSマニュアル２c.Text = "ダウンロード";
			this.btnSSマニュアル２c.Click += new System.EventHandler(this.btnSSマニュアル２c_Click);
			// 
			// btnSSマニュアル3別紙
			// 
			this.btnSSマニュアル3別紙.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSSマニュアル3別紙.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSSマニュアル3別紙.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSSマニュアル3別紙.ForeColor = System.Drawing.Color.White;
			this.btnSSマニュアル3別紙.Location = new System.Drawing.Point(264, 90);
			this.btnSSマニュアル3別紙.Name = "btnSSマニュアル3別紙";
			this.btnSSマニュアル3別紙.Size = new System.Drawing.Size(72, 22);
			this.btnSSマニュアル3別紙.TabIndex = 94;
			this.btnSSマニュアル3別紙.TabStop = false;
			this.btnSSマニュアル3別紙.Text = "ダウンロード";
			this.btnSSマニュアル3別紙.Click += new System.EventHandler(this.button1_Click);
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label11.Location = new System.Drawing.Point(24, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(224, 16);
			this.label11.TabIndex = 93;
			this.label11.Text = "（４）　スーパースターアイテム版説明資料";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label10.Location = new System.Drawing.Point(24, 88);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(232, 16);
			this.label10.TabIndex = 92;
			this.label10.Text = "（３）　スーパースターアイテム版";
			// 
			// btnSSマニュアル４
			// 
			this.btnSSマニュアル４.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSSマニュアル４.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSSマニュアル４.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSSマニュアル４.ForeColor = System.Drawing.Color.White;
			this.btnSSマニュアル４.Location = new System.Drawing.Point(264, 188);
			this.btnSSマニュアル４.Name = "btnSSマニュアル４";
			this.btnSSマニュアル４.Size = new System.Drawing.Size(72, 22);
			this.btnSSマニュアル４.TabIndex = 91;
			this.btnSSマニュアル４.TabStop = false;
			this.btnSSマニュアル４.Text = "ダウンロード";
			this.btnSSマニュアル４.Click += new System.EventHandler(this.btnSSマニュアル４_Click);
			// 
			// btnSSマニュアル３
			// 
			this.btnSSマニュアル３.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSSマニュアル３.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSSマニュアル３.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSSマニュアル３.ForeColor = System.Drawing.Color.White;
			this.btnSSマニュアル３.Location = new System.Drawing.Point(264, 156);
			this.btnSSマニュアル３.Name = "btnSSマニュアル３";
			this.btnSSマニュアル３.Size = new System.Drawing.Size(72, 22);
			this.btnSSマニュアル３.TabIndex = 91;
			this.btnSSマニュアル３.TabStop = false;
			this.btnSSマニュアル３.Text = "ダウンロード";
			this.btnSSマニュアル３.Click += new System.EventHandler(this.btnSSマニュアル３_Click);
			// 
			// btnSSマニュアル２
			// 
			this.btnSSマニュアル２.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSSマニュアル２.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSSマニュアル２.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSSマニュアル２.ForeColor = System.Drawing.Color.White;
			this.btnSSマニュアル２.Location = new System.Drawing.Point(264, 52);
			this.btnSSマニュアル２.Name = "btnSSマニュアル２";
			this.btnSSマニュアル２.Size = new System.Drawing.Size(72, 22);
			this.btnSSマニュアル２.TabIndex = 91;
			this.btnSSマニュアル２.TabStop = false;
			this.btnSSマニュアル２.Text = "ダウンロード";
			this.btnSSマニュアル２.Click += new System.EventHandler(this.btnSSマニュアル２_Click);
			// 
			// btnSSマニュアル１
			// 
			this.btnSSマニュアル１.BackColor = System.Drawing.Color.SteelBlue;
			this.btnSSマニュアル１.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSSマニュアル１.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnSSマニュアル１.ForeColor = System.Drawing.Color.White;
			this.btnSSマニュアル１.Location = new System.Drawing.Point(264, 20);
			this.btnSSマニュアル１.Name = "btnSSマニュアル１";
			this.btnSSマニュアル１.Size = new System.Drawing.Size(72, 22);
			this.btnSSマニュアル１.TabIndex = 90;
			this.btnSSマニュアル１.TabStop = false;
			this.btnSSマニュアル１.Text = "ダウンロード";
			this.btnSSマニュアル１.Click += new System.EventHandler(this.btnSSマニュアル１_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(24, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(256, 16);
			this.label1.TabIndex = 64;
			this.label1.Text = "（２）　スーパースターアイテム版操作手引書";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label2.Location = new System.Drawing.Point(24, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(248, 16);
			this.label2.TabIndex = 62;
			this.label2.Text = "（１）　スーパースター標準版操作手引書";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label7.Location = new System.Drawing.Point(24, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(256, 16);
			this.label7.TabIndex = 64;
			this.label7.Text = "（５）　新荷主EDI(Bluetooth)操作マニュアル";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label9.Location = new System.Drawing.Point(24, 192);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(256, 16);
			this.label9.TabIndex = 64;
			this.label9.Text = "（６）　Bluetooth対応新規設置手順書";
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label3.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(410, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(349, 22);
			this.label3.TabIndex = 60;
			this.label3.Text = "スーパースター";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grbその他
			// 
			this.grbその他.Controls.Add(this.btnその他４);
			this.grbその他.Controls.Add(this.labその他４);
			this.grbその他.Controls.Add(this.btnその他３);
			this.grbその他.Controls.Add(this.btnその他２);
			this.grbその他.Controls.Add(this.labその他３);
			this.grbその他.Controls.Add(this.labその他２);
			this.grbその他.Controls.Add(this.label6);
			this.grbその他.Controls.Add(this.btnその他１);
			this.grbその他.Controls.Add(this.labその他１);
			this.grbその他.Controls.Add(this.label5);
			this.grbその他.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.grbその他.ForeColor = System.Drawing.Color.Green;
			this.grbその他.Location = new System.Drawing.Point(410, 300);
			this.grbその他.Name = "grbその他";
			this.grbその他.Size = new System.Drawing.Size(350, 206);
			this.grbその他.TabIndex = 31;
			this.grbその他.TabStop = false;
			// 
			// btnその他４
			// 
			this.btnその他４.BackColor = System.Drawing.Color.SteelBlue;
			this.btnその他４.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnその他４.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnその他４.ForeColor = System.Drawing.Color.White;
			this.btnその他４.Location = new System.Drawing.Point(264, 148);
			this.btnその他４.Name = "btnその他４";
			this.btnその他４.Size = new System.Drawing.Size(72, 22);
			this.btnその他４.TabIndex = 99;
			this.btnその他４.TabStop = false;
			this.btnその他４.Text = "ダウンロード";
			this.btnその他４.Click += new System.EventHandler(this.btnその他４_Click);
			// 
			// labその他４
			// 
			this.labその他４.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labその他４.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labその他４.Location = new System.Drawing.Point(24, 152);
			this.labその他４.Name = "labその他４";
			this.labその他４.Size = new System.Drawing.Size(224, 16);
			this.labその他４.TabIndex = 98;
			this.labその他４.Text = "（４）　iSTAR-2プリンタ交換依頼書";
			// 
			// btnその他３
			// 
			this.btnその他３.BackColor = System.Drawing.Color.SteelBlue;
			this.btnその他３.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnその他３.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnその他３.ForeColor = System.Drawing.Color.White;
			this.btnその他３.Location = new System.Drawing.Point(264, 116);
			this.btnその他３.Name = "btnその他３";
			this.btnその他３.Size = new System.Drawing.Size(72, 22);
			this.btnその他３.TabIndex = 97;
			this.btnその他３.TabStop = false;
			this.btnその他３.Text = "ダウンロード";
			this.btnその他３.Click += new System.EventHandler(this.btnその他３_Click);
			// 
			// btnその他２
			// 
			this.btnその他２.BackColor = System.Drawing.Color.SteelBlue;
			this.btnその他２.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnその他２.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnその他２.ForeColor = System.Drawing.Color.White;
			this.btnその他２.Location = new System.Drawing.Point(264, 84);
			this.btnその他２.Name = "btnその他２";
			this.btnその他２.Size = new System.Drawing.Size(72, 22);
			this.btnその他２.TabIndex = 96;
			this.btnその他２.TabStop = false;
			this.btnその他２.Text = "ダウンロード";
			this.btnその他２.Click += new System.EventHandler(this.btnその他２_Click);
			// 
			// labその他３
			// 
			this.labその他３.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labその他３.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labその他３.Location = new System.Drawing.Point(24, 120);
			this.labその他３.Name = "labその他３";
			this.labその他３.Size = new System.Drawing.Size(224, 16);
			this.labその他３.TabIndex = 95;
			this.labその他３.Text = "（３）　スーパースター導入依頼書";
			// 
			// labその他２
			// 
			this.labその他２.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labその他２.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labその他２.Location = new System.Drawing.Point(24, 88);
			this.labその他２.Name = "labその他２";
			this.labその他２.Size = new System.Drawing.Size(224, 16);
			this.labその他２.TabIndex = 94;
			this.labその他２.Text = "（２）　ｉSTAR-2新規荷主申込付随書";
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(56, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(160, 23);
			this.label6.TabIndex = 93;
			this.label6.Text = "(iSTAR-2・292シリーズ)";
			// 
			// btnその他１
			// 
			this.btnその他１.BackColor = System.Drawing.Color.SteelBlue;
			this.btnその他１.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnその他１.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnその他１.ForeColor = System.Drawing.Color.White;
			this.btnその他１.Location = new System.Drawing.Point(264, 43);
			this.btnその他１.Name = "btnその他１";
			this.btnその他１.Size = new System.Drawing.Size(72, 22);
			this.btnその他１.TabIndex = 92;
			this.btnその他１.TabStop = false;
			this.btnその他１.Text = "ダウンロード";
			this.btnその他１.Click += new System.EventHandler(this.btnその他１_Click);
			// 
			// labその他１
			// 
			this.labその他１.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labその他１.ForeColor = System.Drawing.SystemColors.ControlText;
			this.labその他１.Location = new System.Drawing.Point(24, 40);
			this.labその他１.Name = "labその他１";
			this.labその他１.Size = new System.Drawing.Size(224, 32);
			this.labその他１.TabIndex = 60;
			this.labその他１.Text = "（１）　キャンセル報告書";
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.label5.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(0, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(349, 20);
			this.label5.TabIndex = 58;
			this.label5.Text = "その他";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// マニュアルダウンロード
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(794, 582);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.grbその他);
			this.Controls.Add(this.grbSS);
			this.Controls.Add(this.grbiS2);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.panel6);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(800, 607);
			this.Name = "マニュアルダウンロード";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 マニュアルダウンロード";
			this.Load += new System.EventHandler(this.マニュアルダウンロード_Load);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.grbiS2.ResumeLayout(false);
			this.grbSS.ResumeLayout(false);
			this.grbその他.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion
		//マニュアルのＰＤＦ
		private static string[] sマニュアルＰＤＦ = {"is2manual.pdf"
												, "is2manual_kani.pdf"
// MOD 2010.04.02 PSN) 藤井 参照PDFの変更 START
//												, "is2_eigyo.pdf"
												, "is2manual_eigyo.pdf"
// MOD 2010.04.02 PSN) 藤井 参照PDFの変更 END
												, "is2Setuptebiki.pdf"
												, "is-2saisetup.pdf"
												, "satosetup.pdf"
// MOD 2010.04.02 PSN) 藤井 参照PDFの変更 START
//												, "SSnormal.pdf"
//												, "SSitem.pdf"
												, "SSmanual_normal.pdf"
												, "SSmanual_item.pdf"
// MOD 2010.04.02 PSN) 藤井 参照PDFの変更 END
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 START
												, "SSmanual_bluetooth.pdf"
												, "SSmanual_bluetoothsinki.pdf"
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 END
												, "cancel.xls"
// MOD 2010.04.13 東都）高木 『ｉSTAR-2新規荷主申込付随書』等追加 START
												, "iS-2新規荷主申込付随書.xls"
												, "スーパースター導入依頼書.xls"
// MOD 2010.04.13 東都）高木 『ｉSTAR-2新規荷主申込付随書』等追加 END
// MOD 2015.04.24 BEVAS)前田　SSアイテム版紹介資料ダウンロードボタンの追加 START
												, "SS_item_appendix.pdf"
												, "SS_item_outline.pdf"
// MOD 2015.04.24 BEVAS)前田　SSアイテム版紹介資料ダウンロードボタンの追加 END
// MOD 2016.05.19 BEVAS）松本　iS2プリンタ交換依頼書ダウンロードボタンの追加 START
												, "【iSTAR-2】プリンター交換依頼書.xls"
// MOD 2016.05.19 BEVAS）松本　iS2プリンタ交換依頼書ダウンロードボタンの追加 END
											};
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			// このフォームを閉じる
			this.Close();
		}


		private void timer1_Tick(object sender, System.EventArgs e)
		{
			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
		}


		private void マニュアルダウンロード_Load(object sender, System.EventArgs e)
		{
			// 日時の初期設定
			lab日時.Text = DateTime.Now.ToString("yyyy/MM/dd HH:mm");
			timer1.Interval = 10000;
			timer1.Enabled = true;
// MOD 2011.07.13 アクト）川上 王子運送対応 START
			label1.Visible = true;
			btnSSマニュアル２.Visible = true;
// MOD 2011.07.13 アクト）川上 王子運送対応 END
// MOD 2011.06.22 東都）高木 王子運送対応 START
			s会社区分 = "";
			try{
				string[] sKey = {gs店所コード};
				if(sv_oji == null) sv_oji = new is2oji.Service1();
				string[] sList = sv_oji.Sel_Member(gsaユーザ, sKey);
				if(sList[0].Equals("正常終了")){
					if((sList[4] == "3") || (sList[4] == "4")){
						s会社区分 = "J";
// MOD 2011.07.13 アクト）川上 王子運送対応 START
						label1.Visible = false;
						btnSSマニュアル２.Visible = false;
// MOD 2011.07.13 アクト）川上 王子運送対応 END
					}
				}else if(sList[0].Equals("該当データがありません")){
					;
				}else{
					texメッセージ.Text = sList[0];
					ビープ音();
				}
			}catch (Exception ex){
				texメッセージ.Text = ex.Message;
				ビープ音();
			}
// MOD 2011.06.22 東都）高木 王子運送対応 END
		}

		private void btniS2マニュアル１_Click(object sender, System.EventArgs e)
		{
			//iS-2操作マニュアル
// MOD 2011.06.22 東都）高木 王子運送対応 START
			if(s会社区分 != "J"){
// MOD 2011.06.22 東都）高木 王子運送対応 END
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[0]);
// MOD 2011.06.22 東都）高木 王子運送対応 START
			}else{
				Process.Start("iexplore.exe"
								, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
								 + sマニュアルＰＤＦ[0].Replace(".pdf","(王子).pdf"));
			}
// MOD 2011.06.22 東都）高木 王子運送対応 END
		}

		private void btniS2マニュアル２_Click(object sender, System.EventArgs e)
		{
			//iS-2簡易マニュアル
// MOD 2011.06.22 東都）高木 王子運送対応 START
			if(s会社区分 != "J"){
// MOD 2011.06.22 東都）高木 王子運送対応 END
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[1]);
// MOD 2011.06.22 東都）高木 王子運送対応 START
			}else{
				Process.Start("iexplore.exe"
								, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
								 + sマニュアルＰＤＦ[1].Replace(".pdf","(王子).pdf"));
			}
// MOD 2011.06.22 東都）高木 王子運送対応 END
		}

		private void btniS2マニュアル３_Click(object sender, System.EventArgs e)
		{
			//iS-2営業所マニュアル
			Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[2]);
		}

		private void btniS2マニュアル４_Click(object sender, System.EventArgs e)
		{
// MOD 2011.06.22 東都）高木 王子運送対応 START
			if(s会社区分 != "J"){
// MOD 2011.06.22 東都）高木 王子運送対応 END
				//iS-2セットアップ手引き
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[3]);
// MOD 2011.06.22 東都）高木 王子運送対応 START
			}else{
				Process.Start("iexplore.exe"
								, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
								 + sマニュアルＰＤＦ[3].Replace(".pdf","(王子).pdf"));
			}
// MOD 2011.06.22 東都）高木 王子運送対応 END
		}

		private void btniS2マニュアル５_Click(object sender, System.EventArgs e)
		{
// MOD 2011.06.22 東都）高木 王子運送対応 START
			if(s会社区分 != "J"){
// MOD 2011.06.22 東都）高木 王子運送対応 END
				//iS-2再セットアップ手引き
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[4]);
// MOD 2011.06.22 東都）高木 王子運送対応 START
			}else{
				Process.Start("iexplore.exe"
								, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
								 + sマニュアルＰＤＦ[4].Replace(".pdf","(王子).pdf"));
			}
// MOD 2011.06.22 東都）高木 王子運送対応 END
		}

		private void btniS2マニュアル６_Click(object sender, System.EventArgs e)
		{
// MOD 2011.06.22 東都）高木 王子運送対応 START
			if(s会社区分 != "J"){
// MOD 2011.06.22 東都）高木 王子運送対応 END
				//SATO再セットアップ手引き
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[5]);
// MOD 2011.06.22 東都）高木 王子運送対応 START
			}else{
				Process.Start("iexplore.exe"
								, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
								 + sマニュアルＰＤＦ[5].Replace(".pdf","(王子).pdf"));
			}
// MOD 2011.06.22 東都）高木 王子運送対応 END
		}

		private void btnSSマニュアル１_Click(object sender, System.EventArgs e)
		{
// MOD 2011.07.13 アクト）川上 王子運送対応 START
			if(s会社区分 != "J")
			{
// MOD 2011.07.13 アクト）川上 王子運送対応 END
				//SS標準版操作手引書
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[6]);
// MOD 2011.07.13 アクト）川上 王子運送対応 START
			}
			else
			{
				Process.Start("iexplore.exe"
					, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
					+ sマニュアルＰＤＦ[6].Replace(".pdf","(王子).pdf"));
			}
// MOD 2011.07.13 アクト）川上 王子運送対応 END
		}

		private void btnSSマニュアル２_Click(object sender, System.EventArgs e)
		{
// MOD 2011.07.13 アクト）川上 王子運送対応 START
			if(s会社区分 != "J")
			{
// MOD 2011.07.13 アクト）川上 王子運送対応 END
				//SSアイテム版操作手引書
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[7]);
// MOD 2011.07.13 アクト）川上 王子運送対応 START
			}
			else
			{
				Process.Start("iexplore.exe"
				, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
				+ sマニュアルＰＤＦ[7].Replace(".pdf","(王子).pdf"));
			}
// MOD 2011.07.13 アクト）川上 王子運送対応 END
		}
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 START
		private void btnSSマニュアル３_Click(object sender, System.EventArgs e)
		{
			//新荷主EDI(Bluetooth)操作マニュアル
			if(s会社区分 != "J")
			{
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[8]);
			}
			else
			{
				Process.Start("iexplore.exe"
					, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
					+ sマニュアルＰＤＦ[8].Replace(".pdf","(王子).pdf"));
			}
		}
		private void btnSSマニュアル４_Click(object sender, System.EventArgs e)
		{
			//Bluetooth対応新規設置手順書
			if(s会社区分 != "J")
			{
				Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[9]);
			}
			else
			{
				Process.Start("iexplore.exe"
					, sマニュアルＵＲＬ.Replace("/manual/","/manualJ/")
					+ sマニュアルＰＤＦ[9].Replace(".pdf","(王子).pdf"));
			}
		}
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 END

		private void btnその他１_Click(object sender, System.EventArgs e)
		{
			//キャンセル報告書
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 START
			//Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[8]);
			Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[10]);
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 END
		}
// MOD 2010.04.13 東都）高木 『ｉSTAR-2新規荷主申込付随書』等追加 START
		private void btnその他２_Click(object sender, System.EventArgs e)
		{
			//ｉSTAR-2新規荷主申込付随書
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 START
			//Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[9]);
			Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[11]);
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 END
		}

		private void btnその他３_Click(object sender, System.EventArgs e)
		{
			//スーパースター導入依頼書
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 START
			//Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[10]);
			Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[12]);
// MOD 2011.08.09 アクト）川上　Bluetooth関連操作マニュアル追加 END
		}
// MOD 2010.04.13 東都）高木 『ｉSTAR-2新規荷主申込付随書』等追加 END
// MOD 2010.06.01 PSN) 藤井、東都）高木 FAQのWeb表示の追加 START
		private void btniS2FAQ_Click(object sender, System.EventArgs e)
		{
			//iS-2 FAQ
			// sマニュアルＵＲＬ[https://wwwis2.fukutsu.co.jp/is2/manual/]
			//                  [https://wwwis2.fukutsu.co.jp/hp/faq/is2Faq.htm]
// MOD 2011.06.22 東都）高木 王子運送対応 START
			if(s会社区分 != "J"){
// MOD 2011.06.22 東都）高木 王子運送対応 END
				Process.Start("iexplore.exe"
				, sマニュアルＵＲＬ.Replace("/is2/manual/","/hp/faq/is2Faq.htm"));
// MOD 2011.06.22 東都）高木 王子運送対応 START
			}else{
				Process.Start("iexplore.exe"
				, sマニュアルＵＲＬ.Replace("/is2/manual/","/hpj/faq/is2Faq.htm"));
			}
// MOD 2011.06.22 東都）高木 王子運送対応 END
		}

// MOD 2015.04.24 BEVAS)前田　SSアイテム版紹介資料ダウンロードボタンの追加 START
		private void btnSSマニュアル２c_Click(object sender, System.EventArgs e)
		{
			Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[14]);	
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[13]);		
		}
// MOD 2015.04.24 BEVAS)前田　SSアイテム版紹介資料ダウンロードボタンの追加 END

// MOD 2010.06.01 PSN) 藤井、東都）高木 FAQのWeb表示の追加 END
// MOD 2016.05.19 BEVAS）松本　iS2プリンタ交換依頼書ダウンロードボタンの追加 START
		private void btnその他４_Click(object sender, System.EventArgs e)
		{
			Process.Start("iexplore.exe", sマニュアルＵＲＬ + sマニュアルＰＤＦ[15]);
		}
// MOD 2016.05.19 BEVAS）松本　iS2プリンタ交換依頼書ダウンロードボタンの追加 END
	}

}
