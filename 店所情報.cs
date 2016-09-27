using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace is2AdminClient
{
	/// <summary>
	/// [Œ_–ñ“XŠî•ñƒƒ“ƒeƒiƒ“ƒX]
	/// </summary>
	//--------------------------------------------------------------------------
	// C³—š—ğ
	//--------------------------------------------------------------------------
	// ADD 2008.05.07 “Œ“sj‚–Ø Œ_–ñ“XŠZŠ‚Ì‘SŠp”¼Šp¬İƒ`ƒFƒbƒN‚Ì’Ç‰Á 
	//--------------------------------------------------------------------------
	// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ 
	//--------------------------------------------------------------------------
	// ADD 2014.09.10 BEVASj‘O“c x“X~‚ß‹@”\’Ç‰Á‘Î‰ 
	//--------------------------------------------------------------------------
	// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ 
	//--------------------------------------------------------------------------
	public class “XŠî•ñ : ‹¤’ÊƒtƒH[ƒ€//System.Windows.Forms.Form
	{
		public  int    iƒAƒNƒeƒBƒu‚e‚f = 0;
		private string sXV“ú   = "00000000000000";
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ START
		private bool bx“X~‚ß‚e‚f‚P = false;
		private bool bx“X~‚ß‚e‚f‚Q = false;
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ END

		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button13;
		private System.Windows.Forms.Button btn•Â‚¶‚é;
		private System.Windows.Forms.Label lab‰ïˆõ–¼;
		private ‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texƒƒbƒZ[ƒW;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label5;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texŒ_–ñ“XŠ–¼;
		private System.Windows.Forms.Label labŒ_–ñ“XŠZŠ;
		private System.Windows.Forms.Label label1;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texŒ_–ñ“XŠZŠ‚Q;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texŒ_–ñ“XŠZŠ‚P;
		private System.Windows.Forms.Label labŒ_–ñ“XŠ—X•Ö;
		private System.Windows.Forms.Label labŒ_–ñ“XŠ“d˜b;
		private System.Windows.Forms.ComboBox cbŒ_–ñ“XŠŒ§;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label12;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texŒ_–ñ“XŠ“d˜b‚Q;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texŒ_–ñ“XŠ“d˜b‚R;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texŒ_–ñ“XŠ“d˜b‚P;
		private System.Windows.Forms.Button btnŒ_–ñ“XŠ—X•Ö;
		private System.Windows.Forms.Panel pnlŒ_–ñ“XŠ;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texŒ_–ñ“XŠ—X•Ö‚P;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX texŒ_–ñ“XŠ—X•Ö‚Q;
		private System.Windows.Forms.Button btnæÁ;
		private System.Windows.Forms.Button btn“o˜^;
		private System.Windows.Forms.Label labŒ_–ñ“XŠî•ñ;
		private System.Windows.Forms.Label labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel pnl“XŠƒR[ƒh;
		private System.Windows.Forms.Button btn“XŠî•ñÀs;
		private System.Windows.Forms.Button btn“XŠî•ñŒŸõ;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX tex“XŠƒR[ƒh;
		private System.Windows.Forms.Label lab“XŠƒR[ƒh;
		private System.Windows.Forms.Label lab’n‹æ‚P;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX tex’n‹æ‚P;
		private is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX tex’n‹æ‚Q;
		private System.Windows.Forms.Label lab’n‹æ‚Q;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox•Ÿ’Ê;
		private System.Windows.Forms.RadioButton rbtn•Ÿ’Ê‘Î‰;
		private System.Windows.Forms.RadioButton rbtn•Ÿ’Ê”ñ‘Î‰;
		private System.Windows.Forms.GroupBox groupBox‰¤q;
		private System.Windows.Forms.RadioButton rbtn‰¤q‘Î‰;
		private System.Windows.Forms.RadioButton rbtn‰¤q”ñ‘Î‰;
		private System.ComponentModel.IContainer components = null;

		public “XŠî•ñ()
		{
			//
			// Windows ƒtƒH[ƒ€ ƒfƒUƒCƒi ƒTƒ|[ƒg‚É•K—v‚Å‚·B
			//
			InitializeComponent();

			//
			// TODO: InitializeComponent ŒÄ‚Ño‚µ‚ÌŒã‚ÉAƒRƒ“ƒXƒgƒ‰ƒNƒ^ ƒR[ƒh‚ğ’Ç‰Á‚µ‚Ä‚­‚¾‚³‚¢B
			//
		}

		/// <summary>
		/// g—p‚³‚ê‚Ä‚¢‚éƒŠƒ\[ƒX‚ÉŒãˆ—‚ğÀs‚µ‚Ü‚·B
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

		#region Windows ƒtƒH[ƒ€ ƒfƒUƒCƒi‚Å¶¬‚³‚ê‚½ƒR[ƒh 
		/// <summary>
		/// ƒfƒUƒCƒi ƒTƒ|[ƒg‚É•K—v‚Èƒƒ\ƒbƒh‚Å‚·B‚±‚Ìƒƒ\ƒbƒh‚Ì“à—e‚ğ
		/// ƒR[ƒh ƒGƒfƒBƒ^‚Å•ÏX‚µ‚È‚¢‚Å‚­‚¾‚³‚¢B
		/// </summary>
		private void InitializeComponent()
		{
			this.texŒ_–ñ“XŠ–¼ = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.pnlŒ_–ñ“XŠ = new System.Windows.Forms.Panel();
			this.groupBox‰¤q = new System.Windows.Forms.GroupBox();
			this.rbtn‰¤q”ñ‘Î‰ = new System.Windows.Forms.RadioButton();
			this.rbtn‰¤q‘Î‰ = new System.Windows.Forms.RadioButton();
			this.groupBox•Ÿ’Ê = new System.Windows.Forms.GroupBox();
			this.rbtn•Ÿ’Ê”ñ‘Î‰ = new System.Windows.Forms.RadioButton();
			this.rbtn•Ÿ’Ê‘Î‰ = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.tex’n‹æ‚Q = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.lab’n‹æ‚Q = new System.Windows.Forms.Label();
			this.tex’n‹æ‚P = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.lab’n‹æ‚P = new System.Windows.Forms.Label();
			this.btnæÁ = new System.Windows.Forms.Button();
			this.btn“o˜^ = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.texŒ_–ñ“XŠ“d˜b‚Q = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.texŒ_–ñ“XŠ“d˜b‚R = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.texŒ_–ñ“XŠ“d˜b‚P = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.cbŒ_–ñ“XŠŒ§ = new System.Windows.Forms.ComboBox();
			this.labŒ_–ñ“XŠ“d˜b = new System.Windows.Forms.Label();
			this.labŒ_–ñ“XŠ—X•Ö = new System.Windows.Forms.Label();
			this.labŒ_–ñ“XŠî•ñ = new System.Windows.Forms.Label();
			this.lab‰ïˆõ–¼ = new System.Windows.Forms.Label();
			this.labŒ_–ñ“XŠZŠ = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.texŒ_–ñ“XŠ—X•Ö‚P = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.texŒ_–ñ“XŠ—X•Ö‚Q = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.btnŒ_–ñ“XŠ—X•Ö = new System.Windows.Forms.Button();
			this.texŒ_–ñ“XŠZŠ‚P = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.texŒ_–ñ“XŠZŠ‚Q = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹ = new System.Windows.Forms.Label();
			this.panel8 = new System.Windows.Forms.Panel();
			this.texƒƒbƒZ[ƒW = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.btn•Â‚¶‚é = new System.Windows.Forms.Button();
			this.button13 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pnl“XŠƒR[ƒh = new System.Windows.Forms.Panel();
			this.btn“XŠî•ñŒŸõ = new System.Windows.Forms.Button();
			this.btn“XŠî•ñÀs = new System.Windows.Forms.Button();
			this.lab“XŠƒR[ƒh = new System.Windows.Forms.Label();
			this.tex“XŠƒR[ƒh = new is2AdminClient.‹¤’ÊƒeƒLƒXƒgƒ{ƒbƒNƒX();
			this.pnlŒ_–ñ“XŠ.SuspendLayout();
			this.groupBox‰¤q.SuspendLayout();
			this.groupBox•Ÿ’Ê.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.pnl“XŠƒR[ƒh.SuspendLayout();
			this.SuspendLayout();
			// 
			// texŒ_–ñ“XŠ–¼
			// 
			this.texŒ_–ñ“XŠ–¼.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texŒ_–ñ“XŠ–¼.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.texŒ_–ñ“XŠ–¼.Location = new System.Drawing.Point(98, 6);
			this.texŒ_–ñ“XŠ–¼.MaxLength = 20;
			this.texŒ_–ñ“XŠ–¼.Name = "texŒ_–ñ“XŠ–¼";
			this.texŒ_–ñ“XŠ–¼.Size = new System.Drawing.Size(326, 23);
			this.texŒ_–ñ“XŠ–¼.TabIndex = 0;
			this.texŒ_–ñ“XŠ–¼.Text = "";
			// 
			// pnlŒ_–ñ“XŠ
			// 
			this.pnlŒ_–ñ“XŠ.BackColor = System.Drawing.Color.Honeydew;
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.groupBox‰¤q);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.groupBox•Ÿ’Ê);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.label2);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.tex’n‹æ‚Q);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.lab’n‹æ‚Q);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.tex’n‹æ‚P);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.lab’n‹æ‚P);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.btnæÁ);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.btn“o˜^);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.label4);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.label9);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.label12);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.texŒ_–ñ“XŠ“d˜b‚Q);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.texŒ_–ñ“XŠ“d˜b‚R);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.texŒ_–ñ“XŠ“d˜b‚P);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.cbŒ_–ñ“XŠŒ§);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.labŒ_–ñ“XŠ“d˜b);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.labŒ_–ñ“XŠ—X•Ö);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.labŒ_–ñ“XŠî•ñ);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.texŒ_–ñ“XŠ–¼);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.lab‰ïˆõ–¼);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.labŒ_–ñ“XŠZŠ);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.label1);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.texŒ_–ñ“XŠ—X•Ö‚P);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.texŒ_–ñ“XŠ—X•Ö‚Q);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.btnŒ_–ñ“XŠ—X•Ö);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.texŒ_–ñ“XŠZŠ‚P);
			this.pnlŒ_–ñ“XŠ.Controls.Add(this.texŒ_–ñ“XŠZŠ‚Q);
			this.pnlŒ_–ñ“XŠ.Location = new System.Drawing.Point(1, 6);
			this.pnlŒ_–ñ“XŠ.Name = "pnlŒ_–ñ“XŠ";
			this.pnlŒ_–ñ“XŠ.Size = new System.Drawing.Size(449, 308);
			this.pnlŒ_–ñ“XŠ.TabIndex = 0;
			// 
			// groupBox‰¤q
			// 
			this.groupBox‰¤q.Controls.Add(this.rbtn‰¤q”ñ‘Î‰);
			this.groupBox‰¤q.Controls.Add(this.rbtn‰¤q‘Î‰);
			this.groupBox‰¤q.Enabled = false;
			this.groupBox‰¤q.ForeColor = System.Drawing.Color.LimeGreen;
			this.groupBox‰¤q.Location = new System.Drawing.Point(102, 222);
			this.groupBox‰¤q.Name = "groupBox‰¤q";
			this.groupBox‰¤q.Size = new System.Drawing.Size(334, 40);
			this.groupBox‰¤q.TabIndex = 105;
			this.groupBox‰¤q.TabStop = false;
			this.groupBox‰¤q.Text = "‰¤q‰^‘—";
			// 
			// rbtn‰¤q”ñ‘Î‰
			// 
			this.rbtn‰¤q”ñ‘Î‰.Enabled = false;
			this.rbtn‰¤q”ñ‘Î‰.Location = new System.Drawing.Point(170, 12);
			this.rbtn‰¤q”ñ‘Î‰.Name = "rbtn‰¤q”ñ‘Î‰";
			this.rbtn‰¤q”ñ‘Î‰.TabIndex = 1;
			this.rbtn‰¤q”ñ‘Î‰.Text = "”ñ‘Î‰";
			// 
			// rbtn‰¤q‘Î‰
			// 
			this.rbtn‰¤q‘Î‰.Enabled = false;
			this.rbtn‰¤q‘Î‰.Location = new System.Drawing.Point(26, 14);
			this.rbtn‰¤q‘Î‰.Name = "rbtn‰¤q‘Î‰";
			this.rbtn‰¤q‘Î‰.TabIndex = 0;
			this.rbtn‰¤q‘Î‰.Text = "‘Î‰";
			// 
			// groupBox•Ÿ’Ê
			// 
			this.groupBox•Ÿ’Ê.Controls.Add(this.rbtn•Ÿ’Ê”ñ‘Î‰);
			this.groupBox•Ÿ’Ê.Controls.Add(this.rbtn•Ÿ’Ê‘Î‰);
			this.groupBox•Ÿ’Ê.ForeColor = System.Drawing.Color.LimeGreen;
			this.groupBox•Ÿ’Ê.Location = new System.Drawing.Point(102, 176);
			this.groupBox•Ÿ’Ê.Name = "groupBox•Ÿ’Ê";
			this.groupBox•Ÿ’Ê.Size = new System.Drawing.Size(334, 44);
			this.groupBox•Ÿ’Ê.TabIndex = 104;
			this.groupBox•Ÿ’Ê.TabStop = false;
			this.groupBox•Ÿ’Ê.Text = "•ŸR’Ê‰^";
			// 
			// rbtn•Ÿ’Ê”ñ‘Î‰
			// 
			this.rbtn•Ÿ’Ê”ñ‘Î‰.Location = new System.Drawing.Point(170, 14);
			this.rbtn•Ÿ’Ê”ñ‘Î‰.Name = "rbtn•Ÿ’Ê”ñ‘Î‰";
			this.rbtn•Ÿ’Ê”ñ‘Î‰.TabIndex = 1;
			this.rbtn•Ÿ’Ê”ñ‘Î‰.Text = "”ñ‘Î‰";
			// 
			// rbtn•Ÿ’Ê‘Î‰
			// 
			this.rbtn•Ÿ’Ê‘Î‰.Location = new System.Drawing.Point(26, 16);
			this.rbtn•Ÿ’Ê‘Î‰.Name = "rbtn•Ÿ’Ê‘Î‰";
			this.rbtn•Ÿ’Ê‘Î‰.TabIndex = 0;
			this.rbtn•Ÿ’Ê‘Î‰.Text = "‘Î‰";
			// 
			// label2
			// 
			this.label2.ForeColor = System.Drawing.Color.LimeGreen;
			this.label2.Location = new System.Drawing.Point(44, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 18);
			this.label2.TabIndex = 103;
			this.label2.Text = "x“X~‚ß";
			// 
			// tex’n‹æ‚Q
			// 
			this.tex’n‹æ‚Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex’n‹æ‚Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex’n‹æ‚Q.Location = new System.Drawing.Point(98, 150);
			this.tex’n‹æ‚Q.MaxLength = 3;
			this.tex’n‹æ‚Q.Name = "tex’n‹æ‚Q";
			this.tex’n‹æ‚Q.Size = new System.Drawing.Size(40, 23);
			this.tex’n‹æ‚Q.TabIndex = 14;
			this.tex’n‹æ‚Q.Text = "";
			// 
			// lab’n‹æ‚Q
			// 
			this.lab’n‹æ‚Q.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab’n‹æ‚Q.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab’n‹æ‚Q.Location = new System.Drawing.Point(60, 156);
			this.lab’n‹æ‚Q.Name = "lab’n‹æ‚Q";
			this.lab’n‹æ‚Q.Size = new System.Drawing.Size(38, 14);
			this.lab’n‹æ‚Q.TabIndex = 102;
			this.lab’n‹æ‚Q.Text = "’n‹æ‚Q";
			// 
			// tex’n‹æ‚P
			// 
			this.tex’n‹æ‚P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex’n‹æ‚P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex’n‹æ‚P.Location = new System.Drawing.Point(98, 126);
			this.tex’n‹æ‚P.MaxLength = 3;
			this.tex’n‹æ‚P.Name = "tex’n‹æ‚P";
			this.tex’n‹æ‚P.Size = new System.Drawing.Size(40, 23);
			this.tex’n‹æ‚P.TabIndex = 13;
			this.tex’n‹æ‚P.Text = "";
			// 
			// lab’n‹æ‚P
			// 
			this.lab’n‹æ‚P.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab’n‹æ‚P.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab’n‹æ‚P.Location = new System.Drawing.Point(60, 132);
			this.lab’n‹æ‚P.Name = "lab’n‹æ‚P";
			this.lab’n‹æ‚P.Size = new System.Drawing.Size(38, 14);
			this.lab’n‹æ‚P.TabIndex = 100;
			this.lab’n‹æ‚P.Text = "’n‹æ‚P";
			// 
			// btnæÁ
			// 
			this.btnæÁ.BackColor = System.Drawing.Color.Blue;
			this.btnæÁ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnæÁ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnæÁ.ForeColor = System.Drawing.Color.White;
			this.btnæÁ.Location = new System.Drawing.Point(388, 278);
			this.btnæÁ.Name = "btnæÁ";
			this.btnæÁ.Size = new System.Drawing.Size(48, 22);
			this.btnæÁ.TabIndex = 16;
			this.btnæÁ.Text = "æÁ";
			this.btnæÁ.Click += new System.EventHandler(this.btnæÁ_Click);
			// 
			// btn“o˜^
			// 
			this.btn“o˜^.BackColor = System.Drawing.Color.Blue;
			this.btn“o˜^.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn“o˜^.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn“o˜^.ForeColor = System.Drawing.Color.White;
			this.btn“o˜^.Location = new System.Drawing.Point(334, 278);
			this.btn“o˜^.Name = "btn“o˜^";
			this.btn“o˜^.Size = new System.Drawing.Size(48, 22);
			this.btn“o˜^.TabIndex = 15;
			this.btn“o˜^.Text = "“o˜^";
			this.btn“o˜^.Click += new System.EventHandler(this.btn“o˜^_Click);
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.LimeGreen;
			this.label4.Location = new System.Drawing.Point(88, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(10, 14);
			this.label4.TabIndex = 88;
			this.label4.Text = "i";
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label9.ForeColor = System.Drawing.Color.LimeGreen;
			this.label9.Location = new System.Drawing.Point(154, 108);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(12, 14);
			this.label9.TabIndex = 89;
			this.label9.Text = "j";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label12.ForeColor = System.Drawing.Color.LimeGreen;
			this.label12.Location = new System.Drawing.Point(210, 108);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(12, 14);
			this.label12.TabIndex = 90;
			this.label12.Text = "|";
			// 
			// texŒ_–ñ“XŠ“d˜b‚Q
			// 
			this.texŒ_–ñ“XŠ“d˜b‚Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texŒ_–ñ“XŠ“d˜b‚Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.texŒ_–ñ“XŠ“d˜b‚Q.Location = new System.Drawing.Point(170, 102);
			this.texŒ_–ñ“XŠ“d˜b‚Q.MaxLength = 4;
			this.texŒ_–ñ“XŠ“d˜b‚Q.Name = "texŒ_–ñ“XŠ“d˜b‚Q";
			this.texŒ_–ñ“XŠ“d˜b‚Q.Size = new System.Drawing.Size(40, 23);
			this.texŒ_–ñ“XŠ“d˜b‚Q.TabIndex = 8;
			this.texŒ_–ñ“XŠ“d˜b‚Q.Text = "";
			// 
			// texŒ_–ñ“XŠ“d˜b‚R
			// 
			this.texŒ_–ñ“XŠ“d˜b‚R.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texŒ_–ñ“XŠ“d˜b‚R.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.texŒ_–ñ“XŠ“d˜b‚R.Location = new System.Drawing.Point(224, 102);
			this.texŒ_–ñ“XŠ“d˜b‚R.MaxLength = 4;
			this.texŒ_–ñ“XŠ“d˜b‚R.Name = "texŒ_–ñ“XŠ“d˜b‚R";
			this.texŒ_–ñ“XŠ“d˜b‚R.Size = new System.Drawing.Size(40, 23);
			this.texŒ_–ñ“XŠ“d˜b‚R.TabIndex = 9;
			this.texŒ_–ñ“XŠ“d˜b‚R.Text = "";
			// 
			// texŒ_–ñ“XŠ“d˜b‚P
			// 
			this.texŒ_–ñ“XŠ“d˜b‚P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texŒ_–ñ“XŠ“d˜b‚P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.texŒ_–ñ“XŠ“d˜b‚P.Location = new System.Drawing.Point(98, 102);
			this.texŒ_–ñ“XŠ“d˜b‚P.MaxLength = 6;
			this.texŒ_–ñ“XŠ“d˜b‚P.Name = "texŒ_–ñ“XŠ“d˜b‚P";
			this.texŒ_–ñ“XŠ“d˜b‚P.Size = new System.Drawing.Size(56, 23);
			this.texŒ_–ñ“XŠ“d˜b‚P.TabIndex = 7;
			this.texŒ_–ñ“XŠ“d˜b‚P.Text = "";
			// 
			// cbŒ_–ñ“XŠŒ§
			// 
			this.cbŒ_–ñ“XŠŒ§.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.cbŒ_–ñ“XŠŒ§.Location = new System.Drawing.Point(98, 54);
			this.cbŒ_–ñ“XŠŒ§.Name = "cbŒ_–ñ“XŠŒ§";
			this.cbŒ_–ñ“XŠŒ§.Size = new System.Drawing.Size(88, 24);
			this.cbŒ_–ñ“XŠŒ§.TabIndex = 4;
			// 
			// labŒ_–ñ“XŠ“d˜b
			// 
			this.labŒ_–ñ“XŠ“d˜b.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labŒ_–ñ“XŠ“d˜b.ForeColor = System.Drawing.Color.LimeGreen;
			this.labŒ_–ñ“XŠ“d˜b.Location = new System.Drawing.Point(58, 108);
			this.labŒ_–ñ“XŠ“d˜b.Name = "labŒ_–ñ“XŠ“d˜b";
			this.labŒ_–ñ“XŠ“d˜b.Size = new System.Drawing.Size(30, 14);
			this.labŒ_–ñ“XŠ“d˜b.TabIndex = 82;
			this.labŒ_–ñ“XŠ“d˜b.Text = "‚s‚d‚k";
			// 
			// labŒ_–ñ“XŠ—X•Ö
			// 
			this.labŒ_–ñ“XŠ—X•Ö.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labŒ_–ñ“XŠ—X•Ö.ForeColor = System.Drawing.Color.LimeGreen;
			this.labŒ_–ñ“XŠ—X•Ö.Location = new System.Drawing.Point(82, 36);
			this.labŒ_–ñ“XŠ—X•Ö.Name = "labŒ_–ñ“XŠ—X•Ö";
			this.labŒ_–ñ“XŠ—X•Ö.Size = new System.Drawing.Size(14, 14);
			this.labŒ_–ñ“XŠ—X•Ö.TabIndex = 81;
			this.labŒ_–ñ“XŠ—X•Ö.Text = "§";
			// 
			// labŒ_–ñ“XŠî•ñ
			// 
			this.labŒ_–ñ“XŠî•ñ.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labŒ_–ñ“XŠî•ñ.Font = new System.Drawing.Font("‚l‚r ‚oƒSƒVƒbƒN", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.labŒ_–ñ“XŠî•ñ.ForeColor = System.Drawing.Color.Blue;
			this.labŒ_–ñ“XŠî•ñ.Location = new System.Drawing.Point(0, 0);
			this.labŒ_–ñ“XŠî•ñ.Name = "labŒ_–ñ“XŠî•ñ";
			this.labŒ_–ñ“XŠî•ñ.Size = new System.Drawing.Size(22, 306);
			this.labŒ_–ñ“XŠî•ñ.TabIndex = 44;
			this.labŒ_–ñ“XŠî•ñ.Text = "Œ_–ñ“XŠî•ñ";
			this.labŒ_–ñ“XŠî•ñ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lab‰ïˆõ–¼
			// 
			this.lab‰ïˆõ–¼.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab‰ïˆõ–¼.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab‰ïˆõ–¼.Location = new System.Drawing.Point(56, 12);
			this.lab‰ïˆõ–¼.Name = "lab‰ïˆõ–¼";
			this.lab‰ïˆõ–¼.Size = new System.Drawing.Size(42, 14);
			this.lab‰ïˆõ–¼.TabIndex = 9;
			this.lab‰ïˆõ–¼.Text = "“XŠ–¼";
			// 
			// labŒ_–ñ“XŠZŠ
			// 
			this.labŒ_–ñ“XŠZŠ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labŒ_–ñ“XŠZŠ.ForeColor = System.Drawing.Color.LimeGreen;
			this.labŒ_–ñ“XŠZŠ.Location = new System.Drawing.Point(44, 60);
			this.labŒ_–ñ“XŠZŠ.Name = "labŒ_–ñ“XŠZŠ";
			this.labŒ_–ñ“XŠZŠ.Size = new System.Drawing.Size(54, 14);
			this.labŒ_–ñ“XŠZŠ.TabIndex = 77;
			this.labŒ_–ñ“XŠZŠ.Text = "“XŠZŠ";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.label1.Location = new System.Drawing.Point(134, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(12, 14);
			this.label1.TabIndex = 80;
			this.label1.Text = "|";
			// 
			// texŒ_–ñ“XŠ—X•Ö‚P
			// 
			this.texŒ_–ñ“XŠ—X•Ö‚P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texŒ_–ñ“XŠ—X•Ö‚P.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.texŒ_–ñ“XŠ—X•Ö‚P.Location = new System.Drawing.Point(98, 30);
			this.texŒ_–ñ“XŠ—X•Ö‚P.MaxLength = 3;
			this.texŒ_–ñ“XŠ—X•Ö‚P.Name = "texŒ_–ñ“XŠ—X•Ö‚P";
			this.texŒ_–ñ“XŠ—X•Ö‚P.Size = new System.Drawing.Size(34, 23);
			this.texŒ_–ñ“XŠ—X•Ö‚P.TabIndex = 1;
			this.texŒ_–ñ“XŠ—X•Ö‚P.Text = "";
			// 
			// texŒ_–ñ“XŠ—X•Ö‚Q
			// 
			this.texŒ_–ñ“XŠ—X•Ö‚Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texŒ_–ñ“XŠ—X•Ö‚Q.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.texŒ_–ñ“XŠ—X•Ö‚Q.Location = new System.Drawing.Point(154, 30);
			this.texŒ_–ñ“XŠ—X•Ö‚Q.MaxLength = 4;
			this.texŒ_–ñ“XŠ—X•Ö‚Q.Name = "texŒ_–ñ“XŠ—X•Ö‚Q";
			this.texŒ_–ñ“XŠ—X•Ö‚Q.Size = new System.Drawing.Size(42, 23);
			this.texŒ_–ñ“XŠ—X•Ö‚Q.TabIndex = 2;
			this.texŒ_–ñ“XŠ—X•Ö‚Q.Text = "";
			this.texŒ_–ñ“XŠ—X•Ö‚Q.KeyDown += new System.Windows.Forms.KeyEventHandler(this.texŒ_–ñ“XŠ—X•Ö‚Q_KeyDown);
			this.texŒ_–ñ“XŠ—X•Ö‚Q.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texŒ_–ñ“XŠ—X•Ö‚Q_KeyPress);
			// 
			// btnŒ_–ñ“XŠ—X•Ö
			// 
			this.btnŒ_–ñ“XŠ—X•Ö.BackColor = System.Drawing.Color.SteelBlue;
			this.btnŒ_–ñ“XŠ—X•Ö.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnŒ_–ñ“XŠ—X•Ö.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btnŒ_–ñ“XŠ—X•Ö.ForeColor = System.Drawing.Color.White;
			this.btnŒ_–ñ“XŠ—X•Ö.Location = new System.Drawing.Point(204, 30);
			this.btnŒ_–ñ“XŠ—X•Ö.Name = "btnŒ_–ñ“XŠ—X•Ö";
			this.btnŒ_–ñ“XŠ—X•Ö.Size = new System.Drawing.Size(48, 22);
			this.btnŒ_–ñ“XŠ—X•Ö.TabIndex = 3;
			this.btnŒ_–ñ“XŠ—X•Ö.TabStop = false;
			this.btnŒ_–ñ“XŠ—X•Ö.Text = "ŒŸõ";
			this.btnŒ_–ñ“XŠ—X•Ö.Click += new System.EventHandler(this.btnŒ_–ñ“XŠ—X•Ö_Click);
			// 
			// texŒ_–ñ“XŠZŠ‚P
			// 
			this.texŒ_–ñ“XŠZŠ‚P.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texŒ_–ñ“XŠZŠ‚P.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.texŒ_–ñ“XŠZŠ‚P.Location = new System.Drawing.Point(186, 54);
			this.texŒ_–ñ“XŠZŠ‚P.MaxLength = 16;
			this.texŒ_–ñ“XŠZŠ‚P.Name = "texŒ_–ñ“XŠZŠ‚P";
			this.texŒ_–ñ“XŠZŠ‚P.Size = new System.Drawing.Size(262, 23);
			this.texŒ_–ñ“XŠZŠ‚P.TabIndex = 5;
			this.texŒ_–ñ“XŠZŠ‚P.Text = "";
			// 
			// texŒ_–ñ“XŠZŠ‚Q
			// 
			this.texŒ_–ñ“XŠZŠ‚Q.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texŒ_–ñ“XŠZŠ‚Q.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
			this.texŒ_–ñ“XŠZŠ‚Q.Location = new System.Drawing.Point(98, 78);
			this.texŒ_–ñ“XŠZŠ‚Q.MaxLength = 20;
			this.texŒ_–ñ“XŠZŠ‚Q.Name = "texŒ_–ñ“XŠZŠ‚Q";
			this.texŒ_–ñ“XŠZŠ‚Q.Size = new System.Drawing.Size(326, 23);
			this.texŒ_–ñ“XŠZŠ‚Q.TabIndex = 6;
			this.texŒ_–ñ“XŠZŠ‚Q.Text = "";
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
			this.panel7.Controls.Add(this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹);
			this.panel7.Location = new System.Drawing.Point(0, 0);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(462, 26);
			this.panel7.TabIndex = 13;
			// 
			// labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹
			// 
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(44)), ((System.Byte)(241)), ((System.Byte)(83)));
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹.ForeColor = System.Drawing.Color.White;
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹.Location = new System.Drawing.Point(12, 2);
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹.Name = "labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹";
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹.Size = new System.Drawing.Size(264, 24);
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹.TabIndex = 0;
			this.labŒ_–ñ“XŠî•ñƒ^ƒCƒgƒ‹.Text = "Œ_–ñ“XŠî•ñ";
			// 
			// panel8
			// 
			this.panel8.BackColor = System.Drawing.Color.PaleGreen;
			this.panel8.Controls.Add(this.texƒƒbƒZ[ƒW);
			this.panel8.Controls.Add(this.btn•Â‚¶‚é);
			this.panel8.Location = new System.Drawing.Point(0, 516);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(462, 58);
			this.panel8.TabIndex = 0;
			// 
			// texƒƒbƒZ[ƒW
			// 
			this.texƒƒbƒZ[ƒW.BackColor = System.Drawing.Color.PaleGreen;
			this.texƒƒbƒZ[ƒW.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.texƒƒbƒZ[ƒW.ForeColor = System.Drawing.Color.Red;
			this.texƒƒbƒZ[ƒW.Location = new System.Drawing.Point(76, 4);
			this.texƒƒbƒZ[ƒW.Multiline = true;
			this.texƒƒbƒZ[ƒW.Name = "texƒƒbƒZ[ƒW";
			this.texƒƒbƒZ[ƒW.ReadOnly = true;
			this.texƒƒbƒZ[ƒW.Size = new System.Drawing.Size(376, 50);
			this.texƒƒbƒZ[ƒW.TabIndex = 30;
			this.texƒƒbƒZ[ƒW.TabStop = false;
			this.texƒƒbƒZ[ƒW.Text = "";
			// 
			// btn•Â‚¶‚é
			// 
			this.btn•Â‚¶‚é.ForeColor = System.Drawing.Color.Red;
			this.btn•Â‚¶‚é.Location = new System.Drawing.Point(8, 6);
			this.btn•Â‚¶‚é.Name = "btn•Â‚¶‚é";
			this.btn•Â‚¶‚é.Size = new System.Drawing.Size(54, 48);
			this.btn•Â‚¶‚é.TabIndex = 5;
			this.btn•Â‚¶‚é.TabStop = false;
			this.btn•Â‚¶‚é.Text = "•Â‚¶‚é";
			this.btn•Â‚¶‚é.Click += new System.EventHandler(this.btn•Â‚¶‚é_Click);
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
			this.groupBox2.Controls.Add(this.pnlŒ_–ñ“XŠ);
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
			this.label5.Text = "‘S‚Ä•K{“ü—Í€–Ú‚Å‚·B";
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Honeydew;
			this.groupBox1.Controls.Add(this.pnl“XŠƒR[ƒh);
			this.groupBox1.ForeColor = System.Drawing.Color.Black;
			this.groupBox1.Location = new System.Drawing.Point(26, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(430, 40);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// pnl“XŠƒR[ƒh
			// 
			this.pnl“XŠƒR[ƒh.BackColor = System.Drawing.Color.Honeydew;
			this.pnl“XŠƒR[ƒh.Controls.Add(this.btn“XŠî•ñŒŸõ);
			this.pnl“XŠƒR[ƒh.Controls.Add(this.btn“XŠî•ñÀs);
			this.pnl“XŠƒR[ƒh.Controls.Add(this.lab“XŠƒR[ƒh);
			this.pnl“XŠƒR[ƒh.Controls.Add(this.tex“XŠƒR[ƒh);
			this.pnl“XŠƒR[ƒh.ForeColor = System.Drawing.Color.Black;
			this.pnl“XŠƒR[ƒh.Location = new System.Drawing.Point(1, 6);
			this.pnl“XŠƒR[ƒh.Name = "pnl“XŠƒR[ƒh";
			this.pnl“XŠƒR[ƒh.Size = new System.Drawing.Size(427, 32);
			this.pnl“XŠƒR[ƒh.TabIndex = 0;
			// 
			// btn“XŠî•ñŒŸõ
			// 
			this.btn“XŠî•ñŒŸõ.BackColor = System.Drawing.Color.Blue;
			this.btn“XŠî•ñŒŸõ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn“XŠî•ñŒŸõ.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn“XŠî•ñŒŸõ.ForeColor = System.Drawing.Color.White;
			this.btn“XŠî•ñŒŸõ.Location = new System.Drawing.Point(124, 6);
			this.btn“XŠî•ñŒŸõ.Name = "btn“XŠî•ñŒŸõ";
			this.btn“XŠî•ñŒŸõ.Size = new System.Drawing.Size(46, 22);
			this.btn“XŠî•ñŒŸõ.TabIndex = 1;
			this.btn“XŠî•ñŒŸõ.TabStop = false;
			this.btn“XŠî•ñŒŸõ.Text = "ŒŸõ";
			this.btn“XŠî•ñŒŸõ.Click += new System.EventHandler(this.btn“XŠî•ñŒŸõ_Click);
			// 
			// btn“XŠî•ñÀs
			// 
			this.btn“XŠî•ñÀs.BackColor = System.Drawing.Color.Blue;
			this.btn“XŠî•ñÀs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn“XŠî•ñÀs.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.btn“XŠî•ñÀs.ForeColor = System.Drawing.Color.White;
			this.btn“XŠî•ñÀs.Location = new System.Drawing.Point(176, 6);
			this.btn“XŠî•ñÀs.Name = "btn“XŠî•ñÀs";
			this.btn“XŠî•ñÀs.Size = new System.Drawing.Size(48, 22);
			this.btn“XŠî•ñÀs.TabIndex = 2;
			this.btn“XŠî•ñÀs.Text = "Às";
			this.btn“XŠî•ñÀs.Click += new System.EventHandler(this.btn“XŠî•ñÀs_Click);
			// 
			// lab“XŠƒR[ƒh
			// 
			this.lab“XŠƒR[ƒh.BackColor = System.Drawing.Color.Honeydew;
			this.lab“XŠƒR[ƒh.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.lab“XŠƒR[ƒh.ForeColor = System.Drawing.Color.LimeGreen;
			this.lab“XŠƒR[ƒh.Location = new System.Drawing.Point(4, 8);
			this.lab“XŠƒR[ƒh.Name = "lab“XŠƒR[ƒh";
			this.lab“XŠƒR[ƒh.Size = new System.Drawing.Size(72, 16);
			this.lab“XŠƒR[ƒh.TabIndex = 6;
			this.lab“XŠƒR[ƒh.Text = "“XŠƒR[ƒh";
			// 
			// tex“XŠƒR[ƒh
			// 
			this.tex“XŠƒR[ƒh.BackColor = System.Drawing.SystemColors.Window;
			this.tex“XŠƒR[ƒh.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(128)));
			this.tex“XŠƒR[ƒh.ImeMode = System.Windows.Forms.ImeMode.Disable;
			this.tex“XŠƒR[ƒh.Location = new System.Drawing.Point(76, 4);
			this.tex“XŠƒR[ƒh.MaxLength = 4;
			this.tex“XŠƒR[ƒh.Name = "tex“XŠƒR[ƒh";
			this.tex“XŠƒR[ƒh.Size = new System.Drawing.Size(42, 23);
			this.tex“XŠƒR[ƒh.TabIndex = 0;
			this.tex“XŠƒR[ƒh.Text = "";
			this.tex“XŠƒR[ƒh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tex“XŠƒR[ƒh_KeyDown);
			this.tex“XŠƒR[ƒh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex“XŠƒR[ƒh_KeyPress);
			// 
			// “XŠî•ñ
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
			this.Name = "“XŠî•ñ";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "is-2 Œ_–ñ“XŠî•ñƒƒ“ƒeƒiƒ“ƒX";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ƒGƒ“ƒ^[ˆÚ“®);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ƒGƒ“ƒ^[ƒLƒƒƒ“ƒZƒ‹);
			this.Load += new System.EventHandler(this.“XŠî•ñ_Load);
			this.Closed += new System.EventHandler(this.“XŠî•ñ_Closed);
			this.Activated += new System.EventHandler(this.“XŠî•ñ_Activated);
			this.pnlŒ_–ñ“XŠ.ResumeLayout(false);
			this.groupBox‰¤q.ResumeLayout(false);
			this.groupBox•Ÿ’Ê.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.pnl“XŠƒR[ƒh.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// ƒAƒvƒŠƒP[ƒVƒ‡ƒ“‚ÌƒƒCƒ“ ƒGƒ“ƒgƒŠ ƒ|ƒCƒ“ƒg‚Å‚·B
		/// </summary>
		private void btn•Â‚¶‚é_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void “XŠî•ñ_Load(object sender, System.EventArgs e)
		{
			// Œ§–¼‚Ì‰Šúİ’è
			cbŒ_–ñ“XŠŒ§.Items.Clear();
			cbŒ_–ñ“XŠŒ§.Items.AddRange(saŒ§);

			ƒNƒŠƒA();
			XVƒ‚[ƒh();

// ADD 2014.09.10 BEVAS)‘O“c x“X~‚ß’Ç‰Á‘Î‰ START
			// ŠÇ—ÒŒ ŒÀ‚Å‚Ì‚İAØ‘Ö‚ğ‹–‰Â‚·‚é
			if(gsŠÇ—Ò‹æ•ª == "1")
			{
				// ŠÇ—Ò‚Ì‚İ
				if(gs‰ïˆõƒR[ƒh == "oji")
				{
					// ‰¤q‰^‘—‚ÌŠÇ—Ò‚Ìê‡A
					// ‰¤q‘¤‚Ìx“X~‚ß‘Î‰‚Ì‚İ‚ğ•ÏX‹–‰Â
					this.groupBox•Ÿ’Ê.Enabled = false;
					this.groupBox‰¤q.Enabled = true;
					rbtn•Ÿ’Ê‘Î‰.Enabled = false;
					rbtn•Ÿ’Ê”ñ‘Î‰.Enabled = false;
					rbtn‰¤q‘Î‰.Enabled = true;
					rbtn‰¤q”ñ‘Î‰.Enabled = true;	
				}
				else if(gs‰ïˆõƒR[ƒh == "honbu")
				{
					// •ŸR’Ê‰^‚ÌŠÇ—Ò‚Ìê‡A
					// •Ÿ’Ê‘¤E‰¤q‘¤‚Ì—¼•û‚Ìx“X~‚ß‘Î‰‚ğ•ÏX‹–‰Â
					this.groupBox•Ÿ’Ê.Enabled = true;
					this.groupBox‰¤q.Enabled = true;
					rbtn•Ÿ’Ê‘Î‰.Enabled = true;
					rbtn•Ÿ’Ê”ñ‘Î‰.Enabled = true;
					rbtn‰¤q‘Î‰.Enabled = true;
					rbtn‰¤q”ñ‘Î‰.Enabled = true;	
				}
			}
			else
			{
				// ‚»‚êˆÈŠO‚ÌƒƒOƒCƒ“ƒ†[ƒU[ix“XŠÖŒWÒAƒ†[ƒU[j‚Ìê‡A
				// •Ÿ’Ê‘¤E‰¤q‘¤‚Ì—¼•û‚Ìx“X~‚ß‘Î‰‚ğ•ÏX•s‹–‰Â
				this.groupBox•Ÿ’Ê.Enabled = false;
				this.groupBox‰¤q.Enabled = false;
				rbtn•Ÿ’Ê‘Î‰.Enabled = false;
				rbtn•Ÿ’Ê”ñ‘Î‰.Enabled = false;
				rbtn‰¤q‘Î‰.Enabled = false;
				rbtn‰¤q”ñ‘Î‰.Enabled = false;	
			}
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ START
			bx“X~‚ß‚e‚f‚P = false;
			bx“X~‚ß‚e‚f‚Q = false;
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ END
// ADD 2014.09.10 BEVAS)‘O“c x“X~‚ß’Ç‰Á‘Î‰ END

			texŒ_–ñ“XŠ–¼.Focus();
		}

		private void XVƒ‚[ƒh()
		{
			if(gs“XŠƒR[ƒh.Trim().Length == 0)
			{
				//ŠÇ—“XŠ‚Ìê‡
				btn“XŠî•ñÀs.Visible = true;
				btn“XŠî•ñŒŸõ.Visible = true;
				lab’n‹æ‚P.Visible = true;
				tex’n‹æ‚P.Visible = true;
				lab’n‹æ‚Q.Visible = true;
				tex’n‹æ‚Q.Visible = true;
				btnæÁ.Visible = true;
			}
			else
			{
				//“XŠ‚Ìê‡
				btn“XŠî•ñÀs.Visible = false;
				btn“XŠî•ñŒŸõ.Visible = false;
				lab’n‹æ‚P.Visible = false;
				tex’n‹æ‚P.Visible = false;
				lab’n‹æ‚Q.Visible = false;
				tex’n‹æ‚Q.Visible = false;
				btnæÁ.Visible = false;
			}

			pnl“XŠƒR[ƒh.Enabled = false;
			pnlŒ_–ñ“XŠ.Enabled   = true;
			btn“o˜^.Text = "XV";
			btn“o˜^.Enabled = true;
		}

		private void tex“XŠƒR[ƒh_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
// MOD 2007.01.20 “Œ“sj‚–Ø ‰æ–Ê’²® START
//				“XŠî•ñŒŸõ();
				tex“XŠƒR[ƒh.Text = tex“XŠƒR[ƒh.Text.Trim();
				if(tex“XŠƒR[ƒh.Text.Length == 3)
					“XŠî•ñŒŸõ();
				else
					“XŠî•ñˆê——();
// MOD 2007.01.20 “Œ“sj‚–Ø ‰æ–Ê’²® END
			}
		}

		private void tex“XŠƒR[ƒh_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btn“XŠî•ñŒŸõ.Focus();
				“XŠî•ñˆê——();
				e.Handled = true;
			}
		}

		private void btn“XŠî•ñŒŸõ_Click(object sender, System.EventArgs e)
		{
			“XŠî•ñˆê——();
		}

		private void btn“XŠî•ñÀs_Click(object sender, System.EventArgs e)
		{
			“XŠî•ñŒŸõ();
		}

		private void “XŠî•ñˆê——()
		{
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			//ŒŸõ‰æ–Ê‚ğ•\¦‚·‚é
			if(g“XŠŒŸõ == null) g“XŠŒŸõ = new “XŠŒŸõ();
			g“XŠŒŸõ.Left = this.Left + 404;
//			g“XŠŒŸõ.Left = this.Left;
			g“XŠŒŸõ.Top = this.Top;

			// ƒR[ƒh‚Ì‰Šú•\¦
//			g“XŠŒŸõ.s“XŠƒR[ƒh = s“XŠƒR[ƒh.Trim();
// ADD 2007.01.20 “Œ“sj‚–Ø ‰Šú•\¦‚ÌƒNƒŠƒA START
			g“XŠŒŸõ.s“XŠƒR[ƒh = "";
			g“XŠŒŸõ.s“XŠ–¼ = "";
// ADD 2007.01.20 “Œ“sj‚–Ø ‰Šú•\¦‚ÌƒNƒŠƒA END
			g“XŠŒŸõ.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if(g“XŠŒŸõ.s“XŠƒR[ƒh.Trim().Length > 0)
			{
				tex“XŠƒR[ƒh.Text = g“XŠŒŸõ.s“XŠƒR[ƒh.Trim();
				“XŠî•ñŒŸõ();
			}
			else
			{
				tex“XŠƒR[ƒh.Focus();
			}
		}

		private void “XŠî•ñŒŸõ()
		{
			texƒƒbƒZ[ƒW.Text = "";
			tex“XŠƒR[ƒh.Text = tex“XŠƒR[ƒh.Text.Trim();
			if(!•K{ƒ`ƒFƒbƒN(tex“XŠƒR[ƒh, "“XŠƒR[ƒh")) return;
			if(!”¼Špƒ`ƒFƒbƒN(tex“XŠƒR[ƒh, "“XŠƒR[ƒh")) return;

			texƒƒbƒZ[ƒW.Text = "ŒŸõ’†DDD";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			try
			{
				string[] sKey  = new string[1];
				sKey[0] = tex“XŠƒR[ƒh.Text;
				string[] sData = sv_maintenance.Get_ShopInf(gsaƒ†[ƒU, sKey);
// ADD 2014.09.10 BEVAS)‘O“c x“X~‚ß’Ç‰Á‘Î‰ START
				string[] sDeliData = sv_maintenance.Sel_GeneralDelivery(gsaƒ†[ƒU, sKey);
// ADD 2014.09.10 BEVAS)‘O“c x“X~‚ß’Ç‰Á‘Î‰ END

// ADD 2014.09.10 BEVAS)‘O“c x“X~‚ß’Ç‰Á‘Î‰ START
				if (sData[0].Equals("³íI—¹"))
				{
// ADD 2014.09.10 BEVAS)‘O“c x“X~‚ß’Ç‰Á‘Î‰ END
					texƒƒbƒZ[ƒW.Text = "";

					//Še€–Ú‚Ìİ’è

					//“XŠî•ñ
					iƒAƒNƒeƒBƒu‚e‚f = 0;

					//Œ_–ñ“XŠî•ñ
					texŒ_–ñ“XŠ–¼.Text   = sData[1];
					if(sData[2].Length > 0)
						cbŒ_–ñ“XŠŒ§.SelectedIndex = int.Parse(sData[2]);
					else
						cbŒ_–ñ“XŠŒ§.SelectedIndex = 0;
					texŒ_–ñ“XŠZŠ‚P.Text = sData[3];
					texŒ_–ñ“XŠZŠ‚Q.Text = sData[4];

					string sŒ_–ñ“XŠ—X•Ö = sData[5];
					if(sŒ_–ñ“XŠ—X•Ö.Length <= 3){
						texŒ_–ñ“XŠ—X•Ö‚P.Text = sŒ_–ñ“XŠ—X•Ö;
					}else{
						texŒ_–ñ“XŠ—X•Ö‚P.Text = sŒ_–ñ“XŠ—X•Ö.Substring(0,3);
						texŒ_–ñ“XŠ—X•Ö‚Q.Text = sŒ_–ñ“XŠ—X•Ö.Substring(3);
					}

					string[] Œ_–ñ“XŠ“d˜b  = sData[6].Trim().Split('-');
					if(Œ_–ñ“XŠ“d˜b.Length > 0) texŒ_–ñ“XŠ“d˜b‚P.Text = Œ_–ñ“XŠ“d˜b[0];
					if(Œ_–ñ“XŠ“d˜b.Length > 1) texŒ_–ñ“XŠ“d˜b‚Q.Text = Œ_–ñ“XŠ“d˜b[1];
					if(Œ_–ñ“XŠ“d˜b.Length > 2) texŒ_–ñ“XŠ“d˜b‚R.Text = Œ_–ñ“XŠ“d˜b[2];

// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ START
//					string[] Œ_–ñ“XŠ‚e‚`‚w  = sData[7].Trim().Split('-');
//					if(Œ_–ñ“XŠ‚e‚`‚w.Length > 0) texŒ_–ñ“XŠ‚e‚`‚w‚P.Text = Œ_–ñ“XŠ‚e‚`‚w[0];
//					if(Œ_–ñ“XŠ‚e‚`‚w.Length > 1) texŒ_–ñ“XŠ‚e‚`‚w‚Q.Text = Œ_–ñ“XŠ‚e‚`‚w[1];
//					if(Œ_–ñ“XŠ‚e‚`‚w.Length > 2) texŒ_–ñ“XŠ‚e‚`‚w‚R.Text = Œ_–ñ“XŠ‚e‚`‚w[2];
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ END

					tex’n‹æ‚P.Text = sData[8];
					tex’n‹æ‚Q.Text = sData[9];

					//XVî•ñ
					sXV“ú = sData[10];

					XVƒ‚[ƒh();
					texŒ_–ñ“XŠ–¼.Focus();
				}
				else
				{
					texƒƒbƒZ[ƒW.Text = sData[0];
					ƒr[ƒv‰¹();
					if(gs“XŠƒR[ƒh.Trim().Length == 0){
						pnl“XŠƒR[ƒh.Enabled = true;
						tex“XŠƒR[ƒh.Focus();
					}
				}
// ADD 2014.09.10 BEVAS)‘O“c x“X~‚ß’Ç‰Á‘Î‰ START
				if (sDeliData[0].Equals("³íI—¹"))
				{
					if ((sDeliData[3].Trim()).Length > 6) 
					{
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ START
						//•Ÿ’Ê‘¤
						if(sDeliData[1].Equals("1"))
						{
							bx“X~‚ß‚e‚f‚P = true;
						}
						//‰¤q‘¤
						if(sDeliData[2].Equals("1"))
						{
							bx“X~‚ß‚e‚f‚Q = true;
						}
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ END
						// ŠÇ—ÒŒ ŒÀ‚Å‚Ì‚İAØ‘Ö‚ğ‹–‰Â‚·‚é
						if(gsŠÇ—Ò‹æ•ª == "1")
						{
							// ŠÇ—Ò‚Ì‚İ
							if(gs‰ïˆõƒR[ƒh == "oji")
							{
								// ‰¤q‰^‘—‚ÌŠÇ—Ò‚Ìê‡A
								// ‰¤q‘¤‚Ìx“X~‚ß‘Î‰‚Ì‚İ‚ğ•ÏX‹–‰Â
								this.groupBox•Ÿ’Ê.Enabled = false;
								this.groupBox‰¤q.Enabled = true;
								rbtn•Ÿ’Ê‘Î‰.Enabled = false;
								rbtn•Ÿ’Ê”ñ‘Î‰.Enabled = false;
								rbtn‰¤q‘Î‰.Enabled = true;
								rbtn‰¤q”ñ‘Î‰.Enabled = true;	
							}
							else if(gs‰ïˆõƒR[ƒh == "honbu")
							{
								// •ŸR’Ê‰^‚ÌŠÇ—Ò‚Ìê‡A
								// •Ÿ’Ê‘¤E‰¤q‘¤‚Ì—¼•û‚Ìx“X~‚ß‘Î‰‚ğ•ÏX‹–‰Â
								this.groupBox•Ÿ’Ê.Enabled = true;
								this.groupBox‰¤q.Enabled = true;
								rbtn•Ÿ’Ê‘Î‰.Enabled = true;
								rbtn•Ÿ’Ê”ñ‘Î‰.Enabled = true;
								rbtn‰¤q‘Î‰.Enabled = true;
								rbtn‰¤q”ñ‘Î‰.Enabled = true;	
							}
						}
						else
						{
							// ‚»‚êˆÈŠO‚ÌƒƒOƒCƒ“ƒ†[ƒU[ix“XŠÖŒWÒAƒ†[ƒU[j‚Ìê‡A
							// •Ÿ’Ê‘¤E‰¤q‘¤‚Ì—¼•û‚Ìx“X~‚ß‘Î‰‚ğ•ÏX•s‹–‰Â
							this.groupBox•Ÿ’Ê.Enabled = false;
							this.groupBox‰¤q.Enabled = false;
							rbtn•Ÿ’Ê‘Î‰.Enabled = false;
							rbtn•Ÿ’Ê”ñ‘Î‰.Enabled = false;
							rbtn‰¤q‘Î‰.Enabled = false;
							rbtn‰¤q”ñ‘Î‰.Enabled = false;	
						}

						// ƒ‰ƒWƒIƒ{ƒ^ƒ“‚Ìƒ`ƒFƒbƒN•\¦i•ŸR’Ê‰^—pj
						if (sDeliData[1].Equals("1"))
						{
							rbtn•Ÿ’Ê‘Î‰.Checked = true;
							rbtn•Ÿ’Ê”ñ‘Î‰.Checked = false;
						} 
						else 
						{
							rbtn•Ÿ’Ê‘Î‰.Checked = false;
							rbtn•Ÿ’Ê”ñ‘Î‰.Checked = true;
						}

						// ƒ‰ƒWƒIƒ{ƒ^ƒ“‚Ìƒ`ƒFƒbƒN•\¦i‰¤q‰^‘——pj
						if (sDeliData[2].Equals("1"))
						{
							rbtn‰¤q‘Î‰.Checked = true;
							rbtn‰¤q”ñ‘Î‰.Checked = false;
						}
						else
						{
							rbtn‰¤q‘Î‰.Checked = false;
							rbtn‰¤q”ñ‘Î‰.Checked = true;
						}
					}
					else 
					{
						// —X•Ö”Ô†‚ª‚È‚¢‚½‚ßAx“X~‚ß–³Œø
						this.groupBox•Ÿ’Ê.Enabled = false;
						this.groupBox‰¤q.Enabled = false;
						rbtn•Ÿ’Ê‘Î‰.Enabled = false;
						rbtn•Ÿ’Ê”ñ‘Î‰.Enabled = false;
						rbtn‰¤q‘Î‰.Enabled = false;
						rbtn‰¤q”ñ‘Î‰.Enabled = false;		
					}
				} 
				else 
				{
					// x“X~‚ß–³Œø
					this.groupBox•Ÿ’Ê.Enabled = false;
					this.groupBox‰¤q.Enabled = false;
					rbtn•Ÿ’Ê‘Î‰.Enabled = false;
					rbtn•Ÿ’Ê”ñ‘Î‰.Enabled = false;
					rbtn‰¤q‘Î‰.Enabled = false;
					rbtn‰¤q”ñ‘Î‰.Enabled = false;		
				}
// ADD 2014.09.10 BEVAS)‘O“c x“X~‚ß’Ç‰Á‘Î‰ END

			}
			catch (Exception ex)
			{
				texƒƒbƒZ[ƒW.Text = ex.Message;
				ƒr[ƒv‰¹();
				if(gs“XŠƒR[ƒh.Trim().Length == 0){
					pnl“XŠƒR[ƒh.Enabled = true;
					tex“XŠƒR[ƒh.Focus();
				}
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private void btn“o˜^_Click(object sender, System.EventArgs e)
		{

			if(“o˜^_ƒ`ƒFƒbƒN() != true) return;
			try
			{
// MOD 2014.09.12 BEVAS) ‘O“c x“X~‚ß‹@”\’Ç‰Á START
				// x“X~‚ß‚e‚f‚PC‚Q‚ğ’Ç‰Á
				//string[] sData  = new string[12];
				string[] sData  = new string[14];
// MOD 2014.09.12 BEVAS) ‘O“c x“X~‚ß‹@”\’Ç‰Á END

				//“XŠƒR[ƒh
				sData[0] = tex“XŠƒR[ƒh.Text;
				//Œ_–ñ“XŠî•ñ
				sData[1] = texŒ_–ñ“XŠ–¼.Text;
				sData[2] = cbŒ_–ñ“XŠŒ§.SelectedIndex.ToString("00");
				sData[3] = texŒ_–ñ“XŠZŠ‚P.Text;
				sData[4] = texŒ_–ñ“XŠZŠ‚Q.Text;

				sData[5] = texŒ_–ñ“XŠ—X•Ö‚P.Text + texŒ_–ñ“XŠ—X•Ö‚Q.Text;
				sData[6] = texŒ_–ñ“XŠ“d˜b‚P.Text;
				if(texŒ_–ñ“XŠ“d˜b‚Q.Text.Length > 0) sData[6] += "-" + texŒ_–ñ“XŠ“d˜b‚Q.Text;
				if(texŒ_–ñ“XŠ“d˜b‚R.Text.Length > 0) sData[6] += "-" + texŒ_–ñ“XŠ“d˜b‚R.Text;

// MOD 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ START
//				sData[7] = texŒ_–ñ“XŠ‚e‚`‚w‚P.Text;
//				if(texŒ_–ñ“XŠ‚e‚`‚w‚Q.Text.Length > 0) sData[7] += "-" + texŒ_–ñ“XŠ‚e‚`‚w‚Q.Text;
//				if(texŒ_–ñ“XŠ‚e‚`‚w‚R.Text.Length > 0) sData[7] += "-" + texŒ_–ñ“XŠ‚e‚`‚w‚R.Text;
				sData[7] = " ";
// MOD 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ END

				sData[8] = tex’n‹æ‚P.Text;
				sData[9] = tex’n‹æ‚Q.Text;

				//XVî•ñ
				sData[10] = sXV“ú;
				sData[11] = gs—˜—pÒƒR[ƒh;

// ADD 2014.09.12 BEVAS) ‘O“c x“X~‚ß‹@”\’Ç‰Á START
				if (rbtn•Ÿ’Ê‘Î‰.Enabled) 
				{
					if (rbtn•Ÿ’Ê‘Î‰.Checked == true) 
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
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ START
				else
				{
					//•Û‚µ‚Ä‚¢‚½’l‚É‚æ‚èİ’è
					if(bx“X~‚ß‚e‚f‚P)
					{
						sData[12] = "1";
					}
					else
					{
						sData[12] = "0";
					}
				}
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ END
				if (rbtn‰¤q‘Î‰.Enabled) 
				{
					if (rbtn‰¤q‘Î‰.Checked == true) 
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
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ START
				else
				{
					//•Û‚µ‚Ä‚¢‚½’l‚É‚æ‚èİ’è
					if(bx“X~‚ß‚e‚f‚Q)
					{
						sData[13] = "1";
					}
					else
					{
						sData[13] = "0";
					}
				}
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ END
// ADD 2014.09.12 BEVAS) ‘O“c x“X~‚ß‹@”\’Ç‰Á END

				for(int iCnt = 0; iCnt < sData.Length ; iCnt++)
					if(sData[iCnt].Length ==0) sData[iCnt] = " ";

				string[] sList = new string[1]{""};
				if (btn“o˜^.Text.Equals("“o˜^"))
				{
					;
				}
				else
				{
					sList = sv_maintenance.Upd_ShopInf(gsaƒ†[ƒU, sData);
					texƒƒbƒZ[ƒW.Text = sList[0];
					if (sList[0].Equals("³íI—¹"))
					{
						texƒƒbƒZ[ƒW.Text = "";
						//‰ïˆõ‚ÌXV
						sXV“ú = sList[1].Trim();
						texŒ_–ñ“XŠ–¼.Focus();
// ADD 2006.11.10 “Œ“sj‚–Ø@XVŒã‚Ì‰æ–Ê‘JˆÚ‚È‚Ç‚Ì•ÏX START
						if(gs“XŠƒR[ƒh.Trim().Length == 0){
							//[btnæÁ_Click]‚Æ“¯‚¶“®ì
							ƒNƒŠƒA();
							pnl“XŠƒR[ƒh.Enabled = true;
// ADD 2007.01.26 “Œ“sj‚–Ø ‰æ–Ê’²® START
							pnlŒ_–ñ“XŠ.Enabled = false;
// ADD 2007.01.26 “Œ“sj‚–Ø ‰æ–Ê’²® END
							tex“XŠƒR[ƒh.Text = " ";
							tex“XŠƒR[ƒh.Focus();
						}else{
							this.Close();
						}
// ADD 2006.11.10 “Œ“sj‚–Ø@XVŒã‚Ì‰æ–Ê‘JˆÚ‚È‚Ç‚Ì•ÏX END
					}
					else
					{
						ƒr[ƒv‰¹();
					}
				}
			}
			catch (Exception ex)
			{
				texƒƒbƒZ[ƒW.Text = ex.Message;
				ƒr[ƒv‰¹();
				texŒ_–ñ“XŠ–¼.Focus();
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
		}

		private bool “o˜^_ƒ`ƒFƒbƒN()
		{
			if(gs“XŠƒR[ƒh.Trim().Length != 0)
			{
				if (gs“XŠƒR[ƒh.Trim() != tex“XŠƒR[ƒh.Text.Trim())
				{
					MessageBox.Show("“XŠƒR[ƒh‚ª³‚µ‚­‚ ‚è‚Ü‚¹‚ñBi" + tex“XŠƒR[ƒh.Text.Trim() + "j","“ü—Íƒ`ƒFƒbƒN", MessageBoxButtons.OK);
					tex“XŠƒR[ƒh.Focus();
					return false;
				}
			}

			//‚s‚’‚‰‚
			texŒ_–ñ“XŠ–¼.Text = texŒ_–ñ“XŠ–¼.Text.Trim();
			texŒ_–ñ“XŠ—X•Ö‚P.Text = texŒ_–ñ“XŠ—X•Ö‚P.Text.Trim();
			texŒ_–ñ“XŠ—X•Ö‚Q.Text = texŒ_–ñ“XŠ—X•Ö‚Q.Text.Trim();
			cbŒ_–ñ“XŠŒ§.Text = cbŒ_–ñ“XŠŒ§.Text.Trim();
			texŒ_–ñ“XŠZŠ‚P.Text = texŒ_–ñ“XŠZŠ‚P.Text.Trim();
			texŒ_–ñ“XŠZŠ‚Q.Text = texŒ_–ñ“XŠZŠ‚Q.Text.Trim();
			texŒ_–ñ“XŠ“d˜b‚P.Text = texŒ_–ñ“XŠ“d˜b‚P.Text.Trim();
			texŒ_–ñ“XŠ“d˜b‚Q.Text = texŒ_–ñ“XŠ“d˜b‚Q.Text.Trim();
			texŒ_–ñ“XŠ“d˜b‚R.Text = texŒ_–ñ“XŠ“d˜b‚R.Text.Trim();
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ START
//			texŒ_–ñ“XŠ‚e‚`‚w‚P.Text = texŒ_–ñ“XŠ‚e‚`‚w‚P.Text.Trim();
//			texŒ_–ñ“XŠ‚e‚`‚w‚Q.Text = texŒ_–ñ“XŠ‚e‚`‚w‚Q.Text.Trim();
//			texŒ_–ñ“XŠ‚e‚`‚w‚R.Text = texŒ_–ñ“XŠ‚e‚`‚w‚R.Text.Trim();
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ END
			tex’n‹æ‚P.Text = tex’n‹æ‚P.Text.Trim();
			tex’n‹æ‚Q.Text = tex’n‹æ‚Q.Text.Trim();

			//•K{ƒ`ƒFƒbƒN
// MOD 2014.09.24 BEVAS)‘O“c Œ_–ñ‘€–Ú‚Ì“ü—Íƒ`ƒFƒbƒN‚ÌŠÉ˜a START
			bool ƒGƒ‰[ƒ`ƒFƒbƒNFG = true;
			//if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ–¼, "“XŠ–¼")) return false;
			if (texŒ_–ñ“XŠ–¼.Text.Length == 0) ƒGƒ‰[ƒ`ƒFƒbƒNFG = false;
			//if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ—X•Ö‚P, "—X•Ö”Ô†")) return false;
			if (texŒ_–ñ“XŠ—X•Ö‚P.Text.Length == 0) ƒGƒ‰[ƒ`ƒFƒbƒNFG = false;
			//if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ—X•Ö‚Q, "—X•Ö”Ô†")) return false;
			if (texŒ_–ñ“XŠ—X•Ö‚Q.Text.Length == 0) ƒGƒ‰[ƒ`ƒFƒbƒNFG = false;

			//if (!•K{ƒ`ƒFƒbƒN(cbŒ_–ñ“XŠŒ§, "“s“¹•{Œ§")) return false;
			if (cbŒ_–ñ“XŠŒ§.Text.Length == 0) ƒGƒ‰[ƒ`ƒFƒbƒNFG = false;

			//if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠZŠ‚P, "ZŠ‚P")) return false;
			if (texŒ_–ñ“XŠZŠ‚P.Text.Length == 0) ƒGƒ‰[ƒ`ƒFƒbƒNFG = false;

			//if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ“d˜b‚P, "“d˜b”Ô†")) return false;
			if (texŒ_–ñ“XŠ“d˜b‚P.Text.Length == 0) ƒGƒ‰[ƒ`ƒFƒbƒNFG = false;
			//if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ“d˜b‚Q, "“d˜b”Ô†")) return false;
			if (texŒ_–ñ“XŠ“d˜b‚Q.Text.Length == 0) ƒGƒ‰[ƒ`ƒFƒbƒNFG = false;
			//if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ“d˜b‚R, "“d˜b”Ô†")) return false;
			if (texŒ_–ñ“XŠ“d˜b‚R.Text.Length == 0) ƒGƒ‰[ƒ`ƒFƒbƒNFG = false;

			if (!ƒGƒ‰[ƒ`ƒFƒbƒNFG) 
			{
				if (MessageBox.Show("–¢“ü—Í€–Ú‚ª‚²‚´‚¢‚Ü‚·‚ªXV‚ğŒp‘±‚µ‚Ä‚à‚æ‚ë‚µ‚¢‚Å‚µ‚å‚¤‚©B","“ü—ÍŠm”F",MessageBoxButtons.YesNo) == DialogResult.No) 
				{
					// No ‚Ìê‡‚Íˆ—‚ğ’†’f‚µ‚ÄI—¹‚·‚é
					return false;
				}
			}
// MOD 2014.09.24 BEVAS)‘O“c Œ_–ñ‘€–Ú‚Ì“ü—Íƒ`ƒFƒbƒNŠÉ˜a END
		
			// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ START
//			if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ‚e‚`‚w‚P, "‚e‚`‚w”Ô†")) return false;
//			if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ‚e‚`‚w‚Q, "‚e‚`‚w”Ô†")) return false;
//			if (!•K{ƒ`ƒFƒbƒN(texŒ_–ñ“XŠ‚e‚`‚w‚R, "‚e‚`‚w”Ô†")) return false;
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ END

			//Œ^ƒ`ƒFƒbƒN
			if (!‘SŠpƒ`ƒFƒbƒN(texŒ_–ñ“XŠ–¼, "“XŠ–¼")) return false;
			if (!”¼Špƒ`ƒFƒbƒN(texŒ_–ñ“XŠ—X•Ö‚P, "—X•Ö”Ô†")) return false;
			if (!”¼Špƒ`ƒFƒbƒN(texŒ_–ñ“XŠ—X•Ö‚Q, "—X•Ö”Ô†")) return false;
//			if (!‘SŠpƒ`ƒFƒbƒN(texŒ_–ñ“XŠZŠ‚P, "“XŠZŠ‚P")) return false;
//			if (!‘SŠpƒ`ƒFƒbƒN(texŒ_–ñ“XŠZŠ‚Q, "“XŠZŠ‚Q")) return false;
// ADD 2008.05.07 “Œ“sj‚–Ø Œ_–ñ“XŠZŠ‚Ì‘SŠp”¼Šp¬İƒ`ƒFƒbƒN‚Ì’Ç‰Á START
			if(!‘SŠp”¼Šp¬İƒ`ƒFƒbƒN(texŒ_–ñ“XŠZŠ‚P, "“XŠZŠ‚P")) return false;
			if(!‘SŠp”¼Šp¬İƒ`ƒFƒbƒN(texŒ_–ñ“XŠZŠ‚Q, "“XŠZŠ‚Q")) return false;
// ADD 2008.05.07 “Œ“sj‚–Ø Œ_–ñ“XŠZŠ‚Ì‘SŠp”¼Šp¬İƒ`ƒFƒbƒN‚Ì’Ç‰Á END
			if (!”¼Špƒ`ƒFƒbƒN(texŒ_–ñ“XŠ“d˜b‚P, "“d˜b”Ô†")) return false;
			if (!”¼Špƒ`ƒFƒbƒN(texŒ_–ñ“XŠ“d˜b‚Q, "“d˜b”Ô†")) return false;
			if (!”¼Špƒ`ƒFƒbƒN(texŒ_–ñ“XŠ“d˜b‚R, "“d˜b”Ô†")) return false;
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ START
//			if (!”¼Špƒ`ƒFƒbƒN(texŒ_–ñ“XŠ‚e‚`‚w‚P, "‚e‚`‚w”Ô†")) return false;
//			if (!”¼Špƒ`ƒFƒbƒN(texŒ_–ñ“XŠ‚e‚`‚w‚Q, "‚e‚`‚w”Ô†")) return false;
//			if (!”¼Špƒ`ƒFƒbƒN(texŒ_–ñ“XŠ‚e‚`‚w‚R, "‚e‚`‚w”Ô†")) return false;
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ END
			if (!”¼Špƒ`ƒFƒbƒN(tex’n‹æ‚P, "’n‹æ‚P")) return false;
			if (!”¼Špƒ`ƒFƒbƒN(tex’n‹æ‚Q, "’n‹æ‚Q")) return false;

// ADD 2006.11.17 “Œ“sj‚–Ø@“d˜b”Ô†‚ÌŒ…”ƒ`ƒFƒbƒN‚Ì’Ç‰Á START
			if(texŒ_–ñ“XŠ“d˜b‚P.Text.Length + texŒ_–ñ“XŠ“d˜b‚Q.Text.Length + texŒ_–ñ“XŠ“d˜b‚R.Text.Length > 11)
			{
				MessageBox.Show("“d˜b”Ô†‚ğ11Œ…ˆÈ“à‚Å“ü—Í‚µ‚Ä‚­‚¾‚³‚¢",
					"“ü—Íƒ`ƒFƒbƒN",MessageBoxButtons.OK);
				texŒ_–ñ“XŠ“d˜b‚P.Focus();
				return false;
			}
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ START
//			if(texŒ_–ñ“XŠ‚e‚`‚w‚P.Text.Length + texŒ_–ñ“XŠ‚e‚`‚w‚Q.Text.Length + texŒ_–ñ“XŠ‚e‚`‚w‚R.Text.Length > 11)
//			{
//				MessageBox.Show("‚e‚`‚w”Ô†‚ğ11Œ…ˆÈ“à‚Å“ü—Í‚µ‚Ä‚­‚¾‚³‚¢",
//					"“ü—Íƒ`ƒFƒbƒN",MessageBoxButtons.OK);
//				texŒ_–ñ“XŠ‚e‚`‚w‚P.Focus();
//				return false;
//			}
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ END
// ADD 2006.11.17 “Œ“sj‚–Ø@“d˜b”Ô†‚ÌŒ…”ƒ`ƒFƒbƒN‚Ì’Ç‰Á END

// MOD 2014.09.24 BEVAS) ‘O“c —X•Ö”Ô†–¢“ü—Í‚Ìƒ`ƒFƒbƒN‚ğ‰ñ”ğ START
			if ((texŒ_–ñ“XŠ—X•Ö‚P.Text.Length > 0) || (texŒ_–ñ“XŠ—X•Ö‚Q.Text.Length > 0)) 
			{
				//ƒ}ƒXƒ^ƒ`ƒFƒbƒN
				if (!—X•ÖŒŸõ(texŒ_–ñ“XŠ—X•Ö‚P, texŒ_–ñ“XŠ—X•Ö‚Q, 
					cbŒ_–ñ“XŠŒ§, texŒ_–ñ“XŠZŠ‚P, texŒ_–ñ“XŠZŠ‚Q, null))
				{
					MessageBox.Show("—X•Ö”Ô†(" + texŒ_–ñ“XŠ—X•Ö‚P.Text + texŒ_–ñ“XŠ—X•Ö‚Q.Text + ")‚ª‘¶İ‚µ‚Ü‚¹‚ñ",
						"“ü—Íƒ`ƒFƒbƒN", MessageBoxButtons.OK);
					texŒ_–ñ“XŠ—X•Ö‚P.Focus();
					return false;
				}
				if (!Œ§–¼ƒ`ƒFƒbƒN(cbŒ_–ñ“XŠŒ§, "“s“¹•{Œ§")) return false;
			}
// MOD 2014.09.24 BEVAS) ‘O“c —X•Ö”Ô†–¢“ü—Í‚Ìƒ`ƒFƒbƒN‚ğ‰ñ”ğ END

			texƒƒbƒZ[ƒW.Text = btn“o˜^.Text + "’†DDD";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			return(true);
		}

		private void ƒNƒŠƒA()
		{
			texŒ_–ñ“XŠ–¼.Text = "";
			texŒ_–ñ“XŠ—X•Ö‚P.Text = "";
			texŒ_–ñ“XŠ—X•Ö‚Q.Text = "";
			cbŒ_–ñ“XŠŒ§.SelectedIndex = 0;
			texŒ_–ñ“XŠZŠ‚P.Text = "";
			texŒ_–ñ“XŠZŠ‚Q.Text = "";
			texŒ_–ñ“XŠ“d˜b‚P.Text = "";
			texŒ_–ñ“XŠ“d˜b‚Q.Text = "";
			texŒ_–ñ“XŠ“d˜b‚R.Text = "";
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ START
//			texŒ_–ñ“XŠ‚e‚`‚w‚P.Text = "";
//			texŒ_–ñ“XŠ‚e‚`‚w‚Q.Text = "";
//			texŒ_–ñ“XŠ‚e‚`‚w‚R.Text = "";
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ END

			tex’n‹æ‚P.Text = "";
			tex’n‹æ‚Q.Text = "";

// ADD 2014.09.10 BEVASj‘O“c x“X~‚ß‹@”\’Ç‰Á‘Î‰ START
			// x“X~‚ß‘Î‰ƒ‰ƒWƒIƒ{ƒ^ƒ“‚ğ‰Šú‰»
			rbtn•Ÿ’Ê”ñ‘Î‰.Checked = true;
			rbtn‰¤q”ñ‘Î‰.Checked = true;
// ADD 2014.09.10 BEVASj‘O“c x“X~‚ß‹@”\’Ç‰Á‘Î‰ END
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ START
			bx“X~‚ß‚e‚f‚P = false;
			bx“X~‚ß‚e‚f‚Q = false;
// MOD 2016.03.31 BEVASj¼–{ x“X~‚ß‚e‚f€–Ú’Ç‰Á‚É”º‚¤—áŠO”­¶ƒoƒO‚ÌC³ END
		}

		private void Œ…”•\¦()
		{
			tex“XŠƒR[ƒh.Text = "1234";

			texŒ_–ñ“XŠ–¼.Text = "‘SŠp20";
			texŒ_–ñ“XŠ—X•Ö‚P.Text = "123";
			texŒ_–ñ“XŠ—X•Ö‚Q.Text = "4567";
			cbŒ_–ñ“XŠŒ§.Text = "‘SŠp4";
			texŒ_–ñ“XŠZŠ‚P.Text = "‘SŠp16";
			texŒ_–ñ“XŠZŠ‚Q.Text = "‘SŠp20";
			texŒ_–ñ“XŠ“d˜b‚P.Text = "123456";
			texŒ_–ñ“XŠ“d˜b‚Q.Text = "1234";
			texŒ_–ñ“XŠ“d˜b‚R.Text = "1234";
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ START
//			texŒ_–ñ“XŠ‚e‚`‚w‚P.Text = "123456";
//			texŒ_–ñ“XŠ‚e‚`‚w‚Q.Text = "1234";
//			texŒ_–ñ“XŠ‚e‚`‚w‚R.Text = "1234";
// DEL 2006.12.11 “Œ“sj¬“¶’J@‚e‚`‚wíœ END

			tex’n‹æ‚P.Text = "1234";
			tex’n‹æ‚Q.Text = "1234";
		}

		private void btnæÁ_Click(object sender, System.EventArgs e)
		{
//			Œ…”•\¦();
			ƒNƒŠƒA();
			texƒƒbƒZ[ƒW.Text = "";
			pnl“XŠƒR[ƒh.Enabled = true;
// ADD 2007.01.26 “Œ“sj‚–Ø ‰æ–Ê’²® START
			pnlŒ_–ñ“XŠ.Enabled = false;
// ADD 2007.01.26 “Œ“sj‚–Ø ‰æ–Ê’²® END
			tex“XŠƒR[ƒh.Text = " ";
			tex“XŠƒR[ƒh.Focus();
		}

		private void texŒ_–ñ“XŠ—X•Ö‚Q_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter)
			{
				texƒƒbƒZ[ƒW.Text = "";
				if(texŒ_–ñ“XŠ—X•Ö‚P.Text.Length == 3 && texŒ_–ñ“XŠ—X•Ö‚Q.Text.Length == 4)
					—X•ÖŒŸõ(texŒ_–ñ“XŠ—X•Ö‚P, texŒ_–ñ“XŠ—X•Ö‚Q, 
						cbŒ_–ñ“XŠŒ§, texŒ_–ñ“XŠZŠ‚P, texŒ_–ñ“XŠZŠ‚Q, null);
				else{
					—X•Öˆê——(texŒ_–ñ“XŠ—X•Ö‚P, texŒ_–ñ“XŠ—X•Ö‚Q, 
						cbŒ_–ñ“XŠŒ§, texŒ_–ñ“XŠZŠ‚P, texŒ_–ñ“XŠZŠ‚Q, null);
				}
			}
		}

		private void texŒ_–ñ“XŠ—X•Ö‚Q_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (e.KeyChar.ToString().Equals("*"))
			{
				btnŒ_–ñ“XŠ—X•Ö.Focus();
				—X•Öˆê——(texŒ_–ñ“XŠ—X•Ö‚P, texŒ_–ñ“XŠ—X•Ö‚Q, 
					cbŒ_–ñ“XŠŒ§, texŒ_–ñ“XŠZŠ‚P, texŒ_–ñ“XŠZŠ‚Q, null);
				e.Handled = true;
			}
		}

		private void btnŒ_–ñ“XŠ—X•Ö_Click(object sender, System.EventArgs e)
		{
			—X•Öˆê——(texŒ_–ñ“XŠ—X•Ö‚P, texŒ_–ñ“XŠ—X•Ö‚Q, 
				cbŒ_–ñ“XŠŒ§, texŒ_–ñ“XŠZŠ‚P, texŒ_–ñ“XŠZŠ‚Q, null);
		}

		private bool •K{ƒ`ƒFƒbƒN(ComboBox cbŒ§, string name)
		{
			if(cbŒ§.Text.Length > 0) return true;
			MessageBox.Show("•K{€–Ú(" + name + ")‚ª“ü—Í‚³‚ê‚Ä‚¢‚Ü‚¹‚ñ",
				"“ü—Íƒ`ƒFƒbƒN",MessageBoxButtons.OK);
			cbŒ§.Focus();
			return false;
		}

		private void —X•Öˆê——(TextBox tex—X•Ö”Ô†‚P, TextBox tex—X•Ö”Ô†‚Q, 
			ComboBox cbŒ§, TextBox texZŠ‚P, TextBox texZŠ‚Q, TextBox tex“XŠ–¼)
		{
			tex—X•Ö”Ô†‚P.Text = tex—X•Ö”Ô†‚P.Text.Trim();
			tex—X•Ö”Ô†‚Q.Text = tex—X•Ö”Ô†‚Q.Text.Trim();
//			if(!”¼Špƒ`ƒFƒbƒN(tex—X•Ö”Ô†‚P, "—X•Ö”Ô†‚P")) return;
//			if(!”¼Špƒ`ƒFƒbƒN(tex—X•Ö”Ô†‚Q, "—X•Ö”Ô†‚Q")) return;

			this.Cursor = System.Windows.Forms.Cursors.AppStarting;
			if (gZŠŒŸõ == null) gZŠŒŸõ = new ZŠŒŸõ();
			// ŒŸõ‰æ–Ê‚ğ‰E‘¤‚É•\¦‚·‚é
			gZŠŒŸõ.Left = this.Left + 404;
			gZŠŒŸõ.Top = this.Top;
			// ƒR[ƒh‚Ì‰Šú•\¦
			gZŠŒŸõ.s—X•Ö”Ô†‚P = "";
			gZŠŒŸõ.s—X•Ö”Ô†‚Q = "";
			gZŠŒŸõ.sŠÇ—“XŠ   = "";
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ START
			//“XƒR[ƒh‚æ‚èŠÇ—Ò‹æ•ª‚ğŒŸõ
			String[] sList;
			string[] sKey2  = new string[1];
			sKey2[0] = tex“XŠƒR[ƒh.Text;
			sList = sv_oji.Sel_Member(gsaƒ†[ƒU, sKey2);
			gZŠŒŸõ.s‚¨‹q—l‚b‚c = "";
			if (sList[0].Equals("³íI—¹"))
			{
				if ((sList[4].Equals("3"))||(sList[4].Equals("4")))
				{
					//‰¤q‰^‘—‰ïˆõ
					gZŠŒŸõ.s‚¨‹q—l‚b‚c = "J";
				}
			}
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ END
			gZŠŒŸõ.ShowDialog();
			this.Cursor = System.Windows.Forms.Cursors.Default;

			if (gZŠŒŸõ.s—X•Ö”Ô†‚P.Trim().Length != 0)
			{
				tex—X•Ö”Ô†‚P.Text = gZŠŒŸõ.s—X•Ö”Ô†‚P.Trim();
				tex—X•Ö”Ô†‚Q.Text = gZŠŒŸõ.s—X•Ö”Ô†‚Q.Trim();
				if(tex“XŠ–¼ != null) 
				{
//					tex“XŠ–¼.Text = gZŠŒŸõ.sŠÇ—“XŠ.Trim();
//					—X•ÖŒŸõ(texİ’uêŠ—X•Ö‚P, texİ’uêŠ—X•Ö‚Q, 
//						cbİ’uêŠŒ§, texİ’uêŠZŠ‚P, texİ’uêŠZŠ‚Q, tex“XŠ–¼);
				}
				//cbŒ§.SelectedIndex = int.Parse(gZŠŒŸõ.s“s“¹•{Œ§‚b‚c.Trim());
//				texZŠ‚P.Text = gZŠŒŸõ.sZŠ.Trim();
				Œ§İ’è(gZŠŒŸõ.sZŠ.Trim(), cbŒ§, texZŠ‚P);
				texZŠ‚Q.Text = "";
				texZŠ‚Q.Focus();
			}
			else
			{
				tex—X•Ö”Ô†‚P.Focus();
			}
		}

		private bool —X•ÖŒŸõ(TextBox tex—X•Ö”Ô†‚P, TextBox tex—X•Ö”Ô†‚Q, 
			ComboBox cbŒ§, TextBox texZŠ‚P, TextBox texZŠ‚Q, TextBox tex“XŠ–¼)
		{
			tex—X•Ö”Ô†‚P.Text = tex—X•Ö”Ô†‚P.Text.Trim();
			tex—X•Ö”Ô†‚Q.Text = tex—X•Ö”Ô†‚Q.Text.Trim();
			//if (!•K{ƒ`ƒFƒbƒN(tex—X•Ö”Ô†‚P, "—X•Ö”Ô†‚P")) return false;
			//if (!”¼Špƒ`ƒFƒbƒN(tex—X•Ö”Ô†‚P, "—X•Ö”Ô†‚P")) return false;
			//if (!•K{ƒ`ƒFƒbƒN(tex—X•Ö”Ô†‚Q, "—X•Ö”Ô†‚Q")) return false;
			//if (!”¼Špƒ`ƒFƒbƒN(tex—X•Ö”Ô†‚Q, "—X•Ö”Ô†‚Q")) return false;
			if (tex—X•Ö”Ô†‚P.Text.Length == 0) return true;
			if (tex—X•Ö”Ô†‚Q.Text.Length == 0) return true;

			texƒƒbƒZ[ƒW.Text = "—X•Ö”Ô†ŒŸõ’†DDD";
			this.Cursor = System.Windows.Forms.Cursors.AppStarting;

			bool ret = true;
			try
			{
				string[] sKey = new string[1];
				sKey[0] = tex—X•Ö”Ô†‚P.Text + tex—X•Ö”Ô†‚Q.Text;
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ START
//				string[] sList = sv_maintenance.Sel_Postcode1(gsaƒ†[ƒU, sKey);
				//“XƒR[ƒh‚æ‚èŠÇ—Ò‹æ•ª‚ğŒŸõ
				String[] sList;
				string[] sKey2  = new string[1];
				sKey2[0] = tex“XŠƒR[ƒh.Text;
				sList = sv_oji.Sel_Member(gsaƒ†[ƒU, sKey2);
				if (sList[0].Equals("³íI—¹"))
				{
					if ((sList[4].Equals("3"))||(sList[4].Equals("4")))
					{
						//‰¤q‰^‘—‰ïˆõ
						sList = sv_oji.Sel_Postcode1(gsaƒ†[ƒU, sKey);
					}
					else
					{
						//•Ÿ’Ê‰ïˆõ
						sList = sv_maintenance.Sel_Postcode1(gsaƒ†[ƒU, sKey);
					}
				}
				else
				{
					sList = sv_maintenance.Sel_Postcode1(gsaƒ†[ƒU, sKey);
				}
// ADD 2010.12.14 ACTjŠ_Œ´ ‰¤q‰^‘—‘Î‰ END
				if (sList[0].Equals("³íI—¹"))
				{
					texƒƒbƒZ[ƒW.Text = "";
					if(tex“XŠ–¼ != null) tex“XŠ–¼.Text = sList[3].Trim();
					if(texZŠ‚P.Text.Trim().Length == 0 && texZŠ‚Q.Text.Trim().Length == 0)
					{
//						texZŠ‚P.Text = sList[2].Trim();
						Œ§İ’è(sList[2].Trim(), cbŒ§, texZŠ‚P);
						texZŠ‚Q.Focus();
					}
					else
						texZŠ‚P.Focus();
//					s“XŠƒR[ƒh = sList[4].Trim();
				}
				else
				{
					texƒƒbƒZ[ƒW.Text = sList[0];
					if(tex“XŠ–¼ != null) tex“XŠ–¼.Text = "";
					ƒr[ƒv‰¹();
					ret =  false;
				}
			}
			catch (Exception ex)
			{
				texƒƒbƒZ[ƒW.Text = ex.Message;
				ƒr[ƒv‰¹();
//				‰Šúƒ‚[ƒh();
				ret = false;
			}
			this.Cursor = System.Windows.Forms.Cursors.Default;
			return ret;
		}

		private void “XŠî•ñ_Closed(object sender, System.EventArgs e)
		{
			iƒAƒNƒeƒBƒu‚e‚f = 0;
			sXV“ú = "";
			ƒNƒŠƒA();
			texƒƒbƒZ[ƒW.Text = "";
			pnl“XŠƒR[ƒh.Enabled = true;
// ADD 2007.01.26 “Œ“sj‚–Ø ‰æ–Ê’²® START
			pnlŒ_–ñ“XŠ.Enabled = false;
// ADD 2007.01.26 “Œ“sj‚–Ø ‰æ–Ê’²® END
			tex“XŠƒR[ƒh.Text = " ";
			tex“XŠƒR[ƒh.Focus();
		}

		private void “XŠî•ñ_Activated(object sender, System.EventArgs e)
		{
			if(iƒAƒNƒeƒBƒu‚e‚f == 1){
				if(gs“XŠƒR[ƒh.Trim().Length > 0)
				{
					tex“XŠƒR[ƒh.Text = gs“XŠƒR[ƒh;
					pnl“XŠƒR[ƒh.Enabled = false;
					“XŠî•ñŒŸõ();
				}else{
					pnl“XŠƒR[ƒh.Enabled = true;
					tex“XŠƒR[ƒh.Text = " ";
					tex“XŠƒR[ƒh.Focus();
// ADD 2007.01.26 “Œ“sj‚–Ø ‰æ–Ê’²® START
					pnlŒ_–ñ“XŠ.Enabled = false;
// ADD 2007.01.26 “Œ“sj‚–Ø ‰æ–Ê’²® END
				}
			}
		}


	}
}
