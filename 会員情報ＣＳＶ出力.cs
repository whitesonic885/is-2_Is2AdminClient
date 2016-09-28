using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [お客様情報出力]
	/// </summary>
	//--------------------------------------------------------------------------
	// 修正履歴
	//--------------------------------------------------------------------------
	// DEL 2005.05.27 東都）高木 セッション制御の廃止 
	// MOD 2005.07.08 東都）小童谷 日付変換の変更 
	//--------------------------------------------------------------------------
	// MOD 2006.12.11 東都）小童谷 サーマル台数追加 
	//--------------------------------------------------------------------------
	// MOD 2009.03.03 東都）高木 サーマルシリアル番号の追加 
	//--------------------------------------------------------------------------
	// MOD 2009.11.25 東都）高木 お客様情報出力（ＣＳＶ）の項目追加 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACT）垣原 王子運送対応 
	//--------------------------------------------------------------------------
	public class 会員情報ＣＳＶ出力 : 共通フォーム
	{
		
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Panel panel6;
		private 共通テキストボックス texメッセージ;
		private System.Windows.Forms.Button btn閉じる;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Label lab集約店タイトル;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DateTimePicker dtpＳ使用開始日;
		private System.Windows.Forms.DateTimePicker dtpＥ使用開始日;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lab使用終了日;
		private System.Windows.Forms.Label lab会員コード;
		private System.Windows.Forms.Label lab利用者登録日;
		private System.Windows.Forms.Label lab使用開始日;
		private System.Windows.Forms.DateTimePicker dtpＳ使用終了日;
		private System.Windows.Forms.DateTimePicker dtpＥ使用終了日;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker dtp開始登録日;
		private System.Windows.Forms.DateTimePicker dtp終了登録日;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnＣＳＶ出力;
		private is2AdminClient.共通テキストボックス tex開始会員コード;
		private is2AdminClient.共通テキストボックス tex終了会員コード;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.CheckBox cBoxＳ使用開始日;
		private System.Windows.Forms.CheckBox cBoxＥ使用開始日;
		private System.Windows.Forms.CheckBox cBoxＳ使用終了日;
		private System.Windows.Forms.CheckBox cBoxＥ使用終了日;
		private System.Windows.Forms.CheckBox cBox開始登録日;
		private System.Windows.Forms.CheckBox cBox終了登録日;
		private System.Windows.Forms.Label labＳ使用開始日;
		private System.Windows.Forms.Label labＥ使用開始日;
		private System.Windows.Forms.Label labＳ使用終了日;
		private System.Windows.Forms.Label labＥ使用終了日;
		private System.Windows.Forms.Label lab開始登録日;
		private System.Windows.Forms.Label lab終了登録日;

		/// <summary>
		/// 必要なデザイナ変数です。
		/// </summary>
		private System.ComponentModel.Container components = null;

		public 会員情報ＣＳＶ出力()
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
			this.lab終了登録日 = new System.Windows.Forms.Label();
			this.lab開始登録日 = new System.Windows.Forms.Label();
			this.labＥ使用終了日 = new System.Windows.Forms.Label();
			this.labＳ使用終了日 = new System.Windows.Forms.Label();
			this.labＥ使用開始日 = new System.Windows.Forms.Label();
			this.labＳ使用開始日 = new System.Windows.Forms.Label();
			this.cBox終了登録日 = new System.Windows.Forms.CheckBox();
			this.cBox開始登録日 = new System.Windows.Forms.CheckBox();
			this.cBoxＥ使用終了日 = new System.Windows.Forms.CheckBox();
			this.cBoxＳ使用終了日 = new System.Windows.Forms.CheckBox();
			this.cBoxＥ使用開始日 = new System.Windows.Forms.CheckBox();
			this.cBoxＳ使用開始日 = new System.Windows.Forms.CheckBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dtp終了登録日 = new System.Windows.Forms.DateTimePicker();
			this.dtp開始登録日 = new System.Windows.Forms.DateTimePicker();
			this.label6 = new System.Windows.Forms.Label();
			this.dtpＥ使用終了日 = new System.Windows.Forms.DateTimePicker();
			this.dtpＳ使用終了日 = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.dtpＥ使用開始日 = new System.Windows.Forms.DateTimePicker();
			this.dtpＳ使用開始日 = new System.Windows.Forms.DateTimePicker();
			this.lab使用終了日 = new System.Windows.Forms.Label();
			this.lab会員コード = new System.Windows.Forms.Label();
			this.tex開始会員コード = new is2AdminClient.共通テキストボックス();
			this.label2 = new System.Windows.Forms.Label();
			this.lab利用者登録日 = new System.Windows.Forms.Label();
			this.lab使用開始日 = new System.Windows.Forms.Label();
			this.tex終了会員コード = new is2AdminClient.共通テキストボックス();
			this.panel7 = new System.Windows.Forms.Panel();
			this.lab集約店タイトル = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.btnＣＳＶ出力 = new System.Windows.Forms.Button();
			this.texメッセージ = new is2AdminClient.共通テキストボックス();
			this.btn閉じる = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.panel6 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.panel1.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Honeydew;
			this.panel1.Controls.Add(this.lab終了登録日);
			this.panel1.Controls.Add(this.lab開始登録日);
			this.panel1.Controls.Add(this.labＥ使用終了日);
			this.panel1.Controls.Add(this.labＳ使用終了日);
			this.panel1.Controls.Add(this.labＥ使用開始日);
			this.panel1.Controls.Add(this.labＳ使用開始日);
			this.panel1.Controls.Add(this.cBox終了登録日);
			this.panel1.Controls.Add(this.cBox開始登録日);
			this.panel1.Controls.Add(this.cBoxＥ使用終了日);
			this.panel1.Controls.Add(this.cBoxＳ使用終了日);
			this.panel1.Controls.Add(this.cBoxＥ使用開始日);
			this.panel1.Controls.Add(this.cBoxＳ使用開始日);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.dtp終了登録日);
			this.panel1.Controls.Add(this.dtp開始登録日);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.dtpＥ使用終了日);
			this.panel1.Controls.Add(this.dtpＳ使用終了日);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.dtpＥ使用開始日);
			this.panel1.Controls.Add(this.dtpＳ使用開始日);
			this.panel1.Controls.Add(this.lab使用終了日);
			this.panel1.Controls.Add(this.lab会員コード);
			this.panel1.Controls.Add(this.tex開始会員コード);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.lab利用者登録日);
			this.panel1.Controls.Add(this.lab使用開始日);
			this.panel1.Controls.Add(this.tex終了会員コード);
			this.panel1.Location = new System.Drawing.Point(1, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(374, 292);
			this.panel1.TabIndex = 1;
			// 
			// lab終了登録日
			// 
			this.lab終了登録日.BackColor = System.Drawing.Color.White;
			this.lab終了登録日.Location = new System.Drawing.Point(226, 260);
			this.lab終了登録日.Name = "lab終了登録日";
			this.lab終了登録日.Size = new System.Drawing.Size(112, 16);
			this.lab終了登録日.TabIndex = 94;
			// 
			// lab開始登録日
			// 
			this.lab開始登録日.BackColor = System.Drawing.Color.White;
			this.lab開始登録日.Location = new System.Drawing.Point(30, 260);
			this.lab開始登録日.Name = "lab開始登録日";
			this.lab開始登録日.Size = new System.Drawing.Size(112, 16);
			this.lab開始登録日.TabIndex = 93;
			// 
			// labＥ使用終了日
			// 
			this.labＥ使用終了日.BackColor = System.Drawing.Color.White;
			this.labＥ使用終了日.Location = new System.Drawing.Point(226, 190);
			this.labＥ使用終了日.Name = "labＥ使用終了日";
			this.labＥ使用終了日.Size = new System.Drawing.Size(112, 16);
			this.labＥ使用終了日.TabIndex = 92;
			// 
			// labＳ使用終了日
			// 
			this.labＳ使用終了日.BackColor = System.Drawing.Color.White;
			this.labＳ使用終了日.Location = new System.Drawing.Point(30, 190);
			this.labＳ使用終了日.Name = "labＳ使用終了日";
			this.labＳ使用終了日.Size = new System.Drawing.Size(114, 16);
			this.labＳ使用終了日.TabIndex = 91;
			// 
			// labＥ使用開始日
			// 
			this.labＥ使用開始日.BackColor = System.Drawing.Color.White;
			this.labＥ使用開始日.Location = new System.Drawing.Point(226, 118);
			this.labＥ使用開始日.Name = "labＥ使用開始日";
			this.labＥ使用開始日.Size = new System.Drawing.Size(114, 18);
			this.labＥ使用開始日.TabIndex = 90;
			// 
			// labＳ使用開始日
			// 
			this.labＳ使用開始日.BackColor = System.Drawing.Color.White;
			this.labＳ使用開始日.Location = new System.Drawing.Point(32, 118);
			this.labＳ使用開始日.Name = "labＳ使用開始日";
			this.labＳ使用開始日.Size = new System.Drawing.Size(110, 16);
			this.labＳ使用開始日.TabIndex = 89;
			// 
			// cBox終了登録日
			// 
			this.cBox終了登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox終了登録日.Location = new System.Drawing.Point(206, 256);
			this.cBox終了登録日.Name = "cBox終了登録日";
			this.cBox終了登録日.Size = new System.Drawing.Size(16, 24);
			this.cBox終了登録日.TabIndex = 88;
			this.cBox終了登録日.TabStop = false;
			this.cBox終了登録日.Click += new System.EventHandler(this.cBox終了登録日_Click);
			// 
			// cBox開始登録日
			// 
			this.cBox開始登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBox開始登録日.Location = new System.Drawing.Point(12, 256);
			this.cBox開始登録日.Name = "cBox開始登録日";
			this.cBox開始登録日.Size = new System.Drawing.Size(16, 24);
			this.cBox開始登録日.TabIndex = 87;
			this.cBox開始登録日.TabStop = false;
			this.cBox開始登録日.Click += new System.EventHandler(this.cBox開始登録日_Click);
			// 
			// cBoxＥ使用終了日
			// 
			this.cBoxＥ使用終了日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBoxＥ使用終了日.Location = new System.Drawing.Point(206, 186);
			this.cBoxＥ使用終了日.Name = "cBoxＥ使用終了日";
			this.cBoxＥ使用終了日.Size = new System.Drawing.Size(16, 24);
			this.cBoxＥ使用終了日.TabIndex = 86;
			this.cBoxＥ使用終了日.TabStop = false;
			this.cBoxＥ使用終了日.Click += new System.EventHandler(this.cBoxＥ使用終了日_Click);
			// 
			// cBoxＳ使用終了日
			// 
			this.cBoxＳ使用終了日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBoxＳ使用終了日.Location = new System.Drawing.Point(12, 186);
			this.cBoxＳ使用終了日.Name = "cBoxＳ使用終了日";
			this.cBoxＳ使用終了日.Size = new System.Drawing.Size(16, 24);
			this.cBoxＳ使用終了日.TabIndex = 85;
			this.cBoxＳ使用終了日.TabStop = false;
			this.cBoxＳ使用終了日.Click += new System.EventHandler(this.cBoxＳ使用終了日_Click);
			// 
			// cBoxＥ使用開始日
			// 
			this.cBoxＥ使用開始日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBoxＥ使用開始日.Location = new System.Drawing.Point(206, 114);
			this.cBoxＥ使用開始日.Name = "cBoxＥ使用開始日";
			this.cBoxＥ使用開始日.Size = new System.Drawing.Size(16, 24);
			this.cBoxＥ使用開始日.TabIndex = 84;
			this.cBoxＥ使用開始日.TabStop = false;
			this.cBoxＥ使用開始日.Click += new System.EventHandler(this.cBoxＥ使用開始日_Click);
			// 
			// cBoxＳ使用開始日
			// 
			this.cBoxＳ使用開始日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cBoxＳ使用開始日.Location = new System.Drawing.Point(12, 114);
			this.cBoxＳ使用開始日.Name = "cBoxＳ使用開始日";
			this.cBoxＳ使用開始日.Size = new System.Drawing.Size(16, 24);
			this.cBoxＳ使用開始日.TabIndex = 83;
			this.cBoxＳ使用開始日.TabStop = false;
			this.cBoxＳ使用開始日.Click += new System.EventHandler(this.cBoxＳ使用開始日_Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(174, 258);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 22);
			this.label7.TabIndex = 82;
			this.label7.Text = "～";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtp終了登録日
			// 
			this.dtp終了登録日.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp終了登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp終了登録日.Location = new System.Drawing.Point(222, 256);
			this.dtp終了登録日.Name = "dtp終了登録日";
			this.dtp終了登録日.Size = new System.Drawing.Size(138, 23);
			this.dtp終了登録日.TabIndex = 8;
			this.dtp終了登録日.TabStop = false;
			this.dtp終了登録日.DropDown += new System.EventHandler(this.dtp終了登録日_DropDown);
			// 
			// dtp開始登録日
			// 
			this.dtp開始登録日.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp開始登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtp開始登録日.Location = new System.Drawing.Point(28, 256);
			this.dtp開始登録日.Name = "dtp開始登録日";
			this.dtp開始登録日.Size = new System.Drawing.Size(138, 23);
			this.dtp開始登録日.TabIndex = 7;
			this.dtp開始登録日.TabStop = false;
			this.dtp開始登録日.DropDown += new System.EventHandler(this.dtp開始登録日_DropDown);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(174, 188);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 22);
			this.label6.TabIndex = 79;
			this.label6.Text = "～";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpＥ使用終了日
			// 
			this.dtpＥ使用終了日.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtpＥ使用終了日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtpＥ使用終了日.Location = new System.Drawing.Point(222, 186);
			this.dtpＥ使用終了日.Name = "dtpＥ使用終了日";
			this.dtpＥ使用終了日.Size = new System.Drawing.Size(138, 23);
			this.dtpＥ使用終了日.TabIndex = 6;
			this.dtpＥ使用終了日.TabStop = false;
			this.dtpＥ使用終了日.DropDown += new System.EventHandler(this.dtpＥ使用終了日_DropDown);
			// 
			// dtpＳ使用終了日
			// 
			this.dtpＳ使用終了日.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtpＳ使用終了日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtpＳ使用終了日.Location = new System.Drawing.Point(28, 186);
			this.dtpＳ使用終了日.Name = "dtpＳ使用終了日";
			this.dtpＳ使用終了日.Size = new System.Drawing.Size(138, 23);
			this.dtpＳ使用終了日.TabIndex = 5;
			this.dtpＳ使用終了日.TabStop = false;
			this.dtpＳ使用終了日.DropDown += new System.EventHandler(this.dtpＳ使用終了日_DropDown);
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(174, 116);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 22);
			this.label5.TabIndex = 76;
			this.label5.Text = "～";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dtpＥ使用開始日
			// 
			this.dtpＥ使用開始日.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtpＥ使用開始日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtpＥ使用開始日.Location = new System.Drawing.Point(222, 114);
			this.dtpＥ使用開始日.Name = "dtpＥ使用開始日";
			this.dtpＥ使用開始日.Size = new System.Drawing.Size(138, 23);
			this.dtpＥ使用開始日.TabIndex = 4;
			this.dtpＥ使用開始日.TabStop = false;
			this.dtpＥ使用開始日.DropDown += new System.EventHandler(this.dtpＥ使用開始日_DropDown);
			// 
			// dtpＳ使用開始日
			// 
			this.dtpＳ使用開始日.CalendarFont = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtpＳ使用開始日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.dtpＳ使用開始日.Location = new System.Drawing.Point(28, 114);
			this.dtpＳ使用開始日.Name = "dtpＳ使用開始日";
			this.dtpＳ使用開始日.Size = new System.Drawing.Size(138, 23);
			this.dtpＳ使用開始日.TabIndex = 3;
			this.dtpＳ使用開始日.TabStop = false;
			this.dtpＳ使用開始日.DropDown += new System.EventHandler(this.dtpＳ使用開始日_DropDown);
			// 
			// lab使用終了日
			// 
			this.lab使用終了日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab使用終了日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab使用終了日.Location = new System.Drawing.Point(16, 156);
			this.lab使用終了日.Name = "lab使用終了日";
			this.lab使用終了日.Size = new System.Drawing.Size(88, 18);
			this.lab使用終了日.TabIndex = 67;
			this.lab使用終了日.Text = "使用終了日";
			// 
			// lab会員コード
			// 
			this.lab会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab会員コード.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab会員コード.Location = new System.Drawing.Point(16, 14);
			this.lab会員コード.Name = "lab会員コード";
			this.lab会員コード.Size = new System.Drawing.Size(98, 18);
			this.lab会員コード.TabIndex = 61;
			this.lab会員コード.Text = "お客様コード";
			// 
			// tex開始会員コード
			// 
			this.tex開始会員コード.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.tex開始会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex開始会員コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex開始会員コード.Location = new System.Drawing.Point(12, 42);
			this.tex開始会員コード.MaxLength = 12;
			this.tex開始会員コード.Name = "tex開始会員コード";
			this.tex開始会員コード.Size = new System.Drawing.Size(154, 23);
			this.tex開始会員コード.TabIndex = 1;
			this.tex開始会員コード.Text = "";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(174, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 22);
			this.label2.TabIndex = 59;
			this.label2.Text = "～";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab利用者登録日
			// 
			this.lab利用者登録日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab利用者登録日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab利用者登録日.Location = new System.Drawing.Point(16, 226);
			this.lab利用者登録日.Name = "lab利用者登録日";
			this.lab利用者登録日.Size = new System.Drawing.Size(128, 20);
			this.lab利用者登録日.TabIndex = 57;
			this.lab利用者登録日.Text = "ユーザー登録日";
			// 
			// lab使用開始日
			// 
			this.lab使用開始日.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab使用開始日.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab使用開始日.Location = new System.Drawing.Point(16, 84);
			this.lab使用開始日.Name = "lab使用開始日";
			this.lab使用開始日.Size = new System.Drawing.Size(92, 18);
			this.lab使用開始日.TabIndex = 56;
			this.lab使用開始日.Text = "使用開始日";
			// 
			// tex終了会員コード
			// 
			this.tex終了会員コード.BackColor = System.Drawing.SystemColors.Window;
			this.tex終了会員コード.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex終了会員コード.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex終了会員コード.Location = new System.Drawing.Point(206, 42);
			this.tex終了会員コード.MaxLength = 12;
			this.tex終了会員コード.Name = "tex終了会員コード";
			this.tex終了会員コード.Size = new System.Drawing.Size(154, 23);
			this.tex終了会員コード.TabIndex = 2;
			this.tex終了会員コード.Text = "";
			// 
			// panel7
			// 
			this.panel7.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.panel7.Controls.Add(this.lab集約店タイトル);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(396, 26);
			this.panel7.TabIndex = 13;
			// 
			// lab集約店タイトル
			// 
			this.lab集約店タイトル.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.lab集約店タイトル.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab集約店タイトル.ForeColor = System.Drawing.Color.White;
			this.lab集約店タイトル.Location = new System.Drawing.Point(12, 2);
			this.lab集約店タイトル.Name = "lab集約店タイトル";
			this.lab集約店タイトル.Size = new System.Drawing.Size(264, 24);
			this.lab集約店タイトル.TabIndex = 0;
			this.lab集約店タイトル.Text = "お客様情報出力";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.btnＣＳＶ出力);
			this.panel8.Controls.Add(this.texメッセージ);
			this.panel8.Controls.Add(this.btn閉じる);
			this.panel8.Location = new System.Drawing.Point(0, 354);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(388, 58);
			this.panel8.TabIndex = 2;
			// 
			// btnＣＳＶ出力
			// 
			this.btnＣＳＶ出力.ForeColor = System.Drawing.Color.Blue;
			this.btnＣＳＶ出力.Location = new System.Drawing.Point(76, 6);
			this.btnＣＳＶ出力.Name = "btnＣＳＶ出力";
			this.btnＣＳＶ出力.Size = new System.Drawing.Size(54, 48);
			this.btnＣＳＶ出力.TabIndex = 7;
			this.btnＣＳＶ出力.Text = "ＣＳＶ　出力";
			this.btnＣＳＶ出力.Click += new System.EventHandler(this.btnＣＳＶ出力_Click);
			// 
			// texメッセージ
			// 
			this.texメッセージ.BackColor = System.Drawing.Color.PaleGreen;
			this.texメッセージ.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texメッセージ.ForeColor = System.Drawing.Color.Red;
			this.texメッセージ.Location = new System.Drawing.Point(140, 4);
			this.texメッセージ.Multiline = true;
			this.texメッセージ.Name = "texメッセージ";
			this.texメッセージ.ReadOnly = true;
			this.texメッセージ.Size = new System.Drawing.Size(242, 50);
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
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.panel1);
			this.groupBox2.Location = new System.Drawing.Point(7, 50);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(377, 300);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// 会員情報ＣＳＶ出力
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 12);
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(388, 412);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.panel8);
			this.Controls.Add(this.panel7);
			this.Controls.Add(this.groupBox2);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(394, 444);
			this.Name = "会員情報ＣＳＶ出力";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 お客様情報出力";
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 START
            //this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.エンター移動);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Onエンター移動);
            //this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.エンターキャンセル);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Onエンターキャンセル);
// MOD 2016.9.27 Vivouac) 菊池 Visual Studio 2013形式対応 END
            this.Load += new System.EventHandler(this.Form1_Load);
			this.Closed += new System.EventHandler(this.会員情報ＣＳＶ出力_Closed);
			this.panel1.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
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
			項目初期化();
		}

		private void 項目初期化()
		{
			tex開始会員コード.Text = " ";
			tex終了会員コード.Text = "";

			dtpＳ使用開始日.Value = System.DateTime.Now;
			cBoxＳ使用開始日.Checked = false;
			labＳ使用開始日.Visible = true;

			dtpＥ使用開始日.Value = System.DateTime.Now;
			cBoxＥ使用開始日.Checked = false;
			labＥ使用開始日.Visible = true;

			dtpＳ使用終了日.Value = System.DateTime.Now;
			cBoxＳ使用終了日.Checked = false;
			labＳ使用終了日.Visible = true;

			dtpＥ使用終了日.Value = System.DateTime.Now;
			cBoxＥ使用終了日.Checked = false;
			labＥ使用終了日.Visible = true;

			dtp開始登録日.Value = System.DateTime.Now;
			cBox開始登録日.Checked = false;
			lab開始登録日.Visible = true;

			dtp終了登録日.Value = System.DateTime.Now;
			cBox終了登録日.Checked = false;
			lab終了登録日.Visible = true;

			dtpＳ使用開始日.Value = System.DateTime.Now;
			cBoxＳ使用開始日.Checked = false;
			labＳ使用開始日.Visible = true;

			dtpＥ使用開始日.Value = System.DateTime.Now;
			cBoxＥ使用開始日.Checked = false;
			labＥ使用開始日.Visible = true;

			dtpＳ使用終了日.Value = System.DateTime.Now;
			cBoxＳ使用終了日.Checked = false;
			labＳ使用終了日.Visible = true;

			dtpＥ使用終了日.Value = System.DateTime.Now;
			cBoxＥ使用終了日.Checked = false;
			labＥ使用終了日.Visible = true;
		}
		private void btn閉じる_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void btnＣＳＶ出力_Click(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";

			tex開始会員コード.Text = tex開始会員コード.Text.Trim();
			tex終了会員コード.Text = tex終了会員コード.Text.Trim();

			if(!半角チェック(tex開始会員コード,"開始お客様コード")) return;
			if(!半角チェック(tex終了会員コード,"終了お客様コード")) return;

			if(cBoxＳ使用開始日.Checked == true && cBoxＥ使用開始日.Checked == true)
			{
				if (dtpＳ使用開始日.Value > dtpＥ使用開始日.Value)
				{
					MessageBox.Show("使用開始日の範囲が正しく入力されていません","入力チェック",MessageBoxButtons.OK );
					dtpＳ使用開始日.Focus();
					return;
				}
			}
			if(cBoxＳ使用終了日.Checked == true && cBoxＥ使用終了日.Checked == true)
			{
				if (dtpＳ使用終了日.Value > dtpＥ使用終了日.Value)
				{
					MessageBox.Show("使用終了日の範囲が正しく入力されていません","入力チェック",MessageBoxButtons.OK );
					dtpＳ使用終了日.Focus();
					return;
				}
			}
			if(cBox開始登録日.Checked == true && cBox終了登録日.Checked == true)
			{
				if (dtp開始登録日.Value > dtp終了登録日.Value)
				{
					MessageBox.Show("ユーザー登録日の範囲が正しく入力されていません","入力チェック",MessageBoxButtons.OK );
					dtp開始登録日.Focus();
					return;
				}
			}

			String[] sList;
			string[] sData = new string[8];
			sData[0] = tex開始会員コード.Text;
			if(sData[0].Length == 0)
			{
				sData[0] = tex終了会員コード.Text;
				sData[1] = "";
			}
			else
				sData[1] = tex終了会員コード.Text;

			sData[2] = "";
			sData[3] = "";
			if(cBoxＳ使用開始日.Checked == true)
// MOD 2005.07.08 東都）小童谷 日付変換の変更 START
//				sData[2] = dtpＳ使用開始日.Value.ToShortDateString().Replace("/","");
				sData[2] = YYYYMMDD変換(dtpＳ使用開始日.Value);
// MOD 2005.07.08 東都）小童谷 日付変換の変更 END

			if(cBoxＥ使用開始日.Checked == true)
			{
// MOD 2005.07.08 東都）小童谷 日付変換の変更 START
				if(sData[2].Length == 0)
//					sData[2] = dtpＥ使用開始日.Value.ToShortDateString().Replace("/","");
					sData[2] = YYYYMMDD変換(dtpＥ使用開始日.Value);
				else
//					sData[3] = dtpＥ使用開始日.Value.ToShortDateString().Replace("/","");
					sData[3] = YYYYMMDD変換(dtpＥ使用開始日.Value);
// MOD 2005.07.08 東都）小童谷 日付変換の変更 END
			}

			sData[4] = "";
			sData[5] = "";
			if(cBoxＳ使用終了日.Checked == true)
// MOD 2005.07.08 東都）小童谷 日付変換の変更 START
//				sData[4] = dtpＳ使用終了日.Value.ToShortDateString().Replace("/","");
				sData[4] = YYYYMMDD変換(dtpＳ使用終了日.Value);
// MOD 2005.07.08 東都）小童谷 日付変換の変更 END

			if(cBoxＥ使用終了日.Checked == true)
			{
// MOD 2005.07.08 東都）小童谷 日付変換の変更 START
				if(sData[4].Length == 0)
//					sData[4] = dtpＥ使用終了日.Value.ToShortDateString().Replace("/","");
					sData[4] = YYYYMMDD変換(dtpＥ使用終了日.Value);
				else
//					sData[5] = dtpＥ使用終了日.Value.ToShortDateString().Replace("/","");
					sData[5] = YYYYMMDD変換(dtpＥ使用終了日.Value);
// MOD 2005.07.08 東都）小童谷 日付変換の変更 END
			}

			sData[6] = "";
			sData[7] = "";
			if(cBox開始登録日.Checked == true)
// MOD 2005.07.08 東都）小童谷 日付変換の変更 START
//				sData[6] = dtp開始登録日.Value.ToShortDateString().Replace("/","");
				sData[6] = YYYYMMDD変換(dtp開始登録日.Value);
// MOD 2005.07.08 東都）小童谷 日付変換の変更 END

			if(cBox終了登録日.Checked == true)
			{
// MOD 2005.07.08 東都）小童谷 日付変換の変更 START
				if(sData[6].Length == 0)
//					sData[6] = dtp終了登録日.Value.ToShortDateString().Replace("/","");
					sData[6] = YYYYMMDD変換(dtp終了登録日.Value);
				else
//					sData[7] = dtp終了登録日.Value.ToShortDateString().Replace("/","");
					sData[7] = YYYYMMDD変換(dtp終了登録日.Value);
// MOD 2005.07.08 東都）小童谷 日付変換の変更 END
			}

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			try
			{
				if(sv_maintenance == null)
				{
					sv_maintenance = new is2maintenance.Service1();
// DEL 2005.05.27 東都）高木 セッション制御の廃止 START
//					sv_maintenance.CookieContainer = cContainer;
// DEL 2005.05.27 東都）高木 セッション制御の廃止 END
				}
				sList = sv_maintenance.Get_csvwrite(gsaユーザ, sData);
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
				// 王子運送分のみ取得
				String[] sList_oji;
				sList_oji =  sv_oji.Get_csvwrite(gsaユーザ, sData);
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

				this.Cursor = System.Windows.Forms.Cursors.Default;

// ADD 2010.12.14 ACT）垣原 王子運送対応 START
//				if(sList[0].Length == 4)
				if((sList[0].Length == 4) || (sList_oji[0].Length == 4))
// ADD 2010.12.14 ACT）垣原 王子運送対応 END
				{
					sList[0] = "\"お客様コード\",\"お客様名\",\"使用開始日\",\"使用終了日\","
// MOD 2009.11.25 東都）高木 お客様情報出力（ＣＳＶ）の項目追加 START
//						+ "\"部門コード\",\"部門名\",\"管理店所コード\",\"管理店所名\","
						+ "\"管理者区分\",\"運賃非表示\",\"お客様登録日時\",\"お客様更新日時\","
						+ "\"セクションコード\",\"セクション名\",\"管理店所コード\",\"管理店所名\","
// MOD 2009.11.25 東都）高木 お客様情報出力（ＣＳＶ）の項目追加 END
						+ "\"設置先住所１\",\"設置先住所２\","
// MOD 2009.11.25 東都）高木 お客様情報出力（ＣＳＶ）の項目追加 START
						+ "\"Ver.\",\"郵便番号\",\"使用料\",\"申込受付ＮＯ\","
						+ "\"セクション登録日時\",\"セクション更新日時\","
// MOD 2009.11.25 東都）高木 お客様情報出力（ＣＳＶ）の項目追加 END
// MOD 2006.12.11 東都）小童谷 サーマル台数追加 START
//						+ "\"利用者コード\",\"パスワード\",\"利用者名\",\"利用者登録日\"";
						+ "\"ユーザコード\",\"パスワード\",\"ユーザ名\",\"ユーザ登録日\","
// MOD 2009.11.25 東都）高木 お客様情報出力（ＣＳＶ）の項目追加 START
						+ "\"ご依頼主コード\",\"ラベル印刷禁止\",\"認証エラー回数\",\"パスワード更新日\","
						+ "\"ユーザ登録日時\",\"ユーザ更新日時\","
// MOD 2009.11.25 東都）高木 お客様情報出力（ＣＳＶ）の項目追加 END
						+ "\"サーマル台数\""
// MOD 2006.12.11 東都）小童谷 サーマル台数追加 END
// MOD 2009.03.03 東都）高木 サーマルシリアル番号の追加 START
						+ ",\"シリアル番号１\",\"状態１\",\"シリアル番号２\",\"状態２\""
						+ ",\"シリアル番号３\",\"状態３\",\"シリアル番号４\",\"状態４\""
// MOD 2009.03.03 東都）高木 サーマルシリアル番号の追加 END
						;

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
// ADD 2010.12.14 ACT）垣原 王子運送対応 START
						sList_oji[0] = sList[0];
						int iCnt_oji;
						if  (sList.Length == 0 )
						{
							iCnt_oji = 0;
						} 
						else
						{
							iCnt_oji = 1;
						}
						for(int iCnt = iCnt_oji; iCnt < sList_oji.Length; iCnt++)
						{
							bSJIS = toSJIS(sList_oji[iCnt]);
							fs.Write(bSJIS, 0 , bSJIS.Length);
						}				
// ADD 2010.12.14 ACT）垣原 王子運送対応 END

						fs.Close();
						texメッセージ.Text = "";
					}
				}
				else
				{
					if (sList[0].Equals("該当データがありません"))
					{
						texメッセージ.Text = "";
						MessageBox.Show("該当データがありません","ＣＳＶ出力",MessageBoxButtons.OK);
					}
					else
					{
						ビープ音();
						texメッセージ.Text = sList[0];
					}
				}
			}
			catch(Exception ex)
			{
				this.Cursor = System.Windows.Forms.Cursors.Default;
				texメッセージ.Text = ex.Message;
			}
			tex開始会員コード.Focus();
		}

		private void cBoxＳ使用開始日_Click(object sender, System.EventArgs e)
		{
			if(cBoxＳ使用開始日.Checked == true)
				labＳ使用開始日.Visible = false;
			else
				labＳ使用開始日.Visible = true;
		}

		private void cBoxＥ使用開始日_Click(object sender, System.EventArgs e)
		{
			if(cBoxＥ使用開始日.Checked == true)
				labＥ使用開始日.Visible = false;
			else
				labＥ使用開始日.Visible = true;
		}

		private void cBoxＳ使用終了日_Click(object sender, System.EventArgs e)
		{
			if(cBoxＳ使用終了日.Checked == true)
				labＳ使用終了日.Visible = false;
			else
				labＳ使用終了日.Visible = true;
		}

		private void cBoxＥ使用終了日_Click(object sender, System.EventArgs e)
		{
			if(cBoxＥ使用終了日.Checked == true)
				labＥ使用終了日.Visible = false;
			else
				labＥ使用終了日.Visible = true;
		}

		private void cBox開始登録日_Click(object sender, System.EventArgs e)
		{
			if(cBox開始登録日.Checked == true)
				lab開始登録日.Visible = false;
			else
				lab開始登録日.Visible = true;
		}

		private void cBox終了登録日_Click(object sender, System.EventArgs e)
		{
			if(cBox終了登録日.Checked == true)
				lab終了登録日.Visible = false;
			else
				lab終了登録日.Visible = true;
		}

		private void dtpＳ使用開始日_DropDown(object sender, System.EventArgs e)
		{
			if(cBoxＳ使用開始日.Checked == false)
			{
				cBoxＳ使用開始日.Checked = true;
				labＳ使用開始日.Visible  = false;
			}
		}

		private void dtpＥ使用開始日_DropDown(object sender, System.EventArgs e)
		{
			if(cBoxＥ使用開始日.Checked == false)
			{
				cBoxＥ使用開始日.Checked = true;
				labＥ使用開始日.Visible  = false;
			}
		}

		private void dtpＳ使用終了日_DropDown(object sender, System.EventArgs e)
		{
			if(cBoxＳ使用終了日.Checked == false)
			{
				cBoxＳ使用終了日.Checked = true;
				labＳ使用終了日.Visible  = false;
			}
		}

		private void dtpＥ使用終了日_DropDown(object sender, System.EventArgs e)
		{
			if(cBoxＥ使用終了日.Checked == false)
			{
				cBoxＥ使用終了日.Checked = true;
				labＥ使用終了日.Visible  = false;
			}
		}

		private void dtp開始登録日_DropDown(object sender, System.EventArgs e)
		{
			if(cBox開始登録日.Checked == false)
			{
				cBox開始登録日.Checked = true;
				lab開始登録日.Visible  = false;
			}
		}

		private void dtp終了登録日_DropDown(object sender, System.EventArgs e)
		{
			if(cBox終了登録日.Checked == false)
			{
				cBox終了登録日.Checked = true;
				lab終了登録日.Visible  = false;
			}
		}

		private void 会員情報ＣＳＶ出力_Closed(object sender, System.EventArgs e)
		{
			texメッセージ.Text = "";
			tex開始会員コード.Focus();
		}

	}
}
