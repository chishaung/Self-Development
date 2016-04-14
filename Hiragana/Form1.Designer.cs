namespace Hiragana
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Check = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hiraganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kataganaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Check
            // 
            this.Check.Location = new System.Drawing.Point(42, 202);
            this.Check.Name = "Check";
            this.Check.Size = new System.Drawing.Size(75, 23);
            this.Check.TabIndex = 1;
            this.Check.Text = "Check";
            this.Check.UseVisualStyleBackColor = true;
            this.Check.Click += new System.EventHandler(this.Check_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(80, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(214, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(66, 16);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Hiragana";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(213, 49);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(67, 16);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Katakana";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "a.png");
            this.imageList1.Images.SetKeyName(1, "i.png");
            this.imageList1.Images.SetKeyName(2, "u.png");
            this.imageList1.Images.SetKeyName(3, "e.png");
            this.imageList1.Images.SetKeyName(4, "o.png");
            this.imageList1.Images.SetKeyName(5, "ka.png");
            this.imageList1.Images.SetKeyName(6, "ki.png");
            this.imageList1.Images.SetKeyName(7, "ku.png");
            this.imageList1.Images.SetKeyName(8, "ke.png");
            this.imageList1.Images.SetKeyName(9, "ko.png");
            this.imageList1.Images.SetKeyName(10, "sa.png");
            this.imageList1.Images.SetKeyName(11, "shi.png");
            this.imageList1.Images.SetKeyName(12, "su.png");
            this.imageList1.Images.SetKeyName(13, "se.png");
            this.imageList1.Images.SetKeyName(14, "so.png");
            this.imageList1.Images.SetKeyName(15, "ta.png");
            this.imageList1.Images.SetKeyName(16, "chi.png");
            this.imageList1.Images.SetKeyName(17, "tsu.png");
            this.imageList1.Images.SetKeyName(18, "te.png");
            this.imageList1.Images.SetKeyName(19, "to.png");
            this.imageList1.Images.SetKeyName(20, "na.png");
            this.imageList1.Images.SetKeyName(21, "ni.png");
            this.imageList1.Images.SetKeyName(22, "nu.png");
            this.imageList1.Images.SetKeyName(23, "ne.png");
            this.imageList1.Images.SetKeyName(24, "no.png");
            this.imageList1.Images.SetKeyName(25, "ha.png");
            this.imageList1.Images.SetKeyName(26, "hi.png");
            this.imageList1.Images.SetKeyName(27, "fu.png");
            this.imageList1.Images.SetKeyName(28, "he.png");
            this.imageList1.Images.SetKeyName(29, "ho.png");
            this.imageList1.Images.SetKeyName(30, "ma.png");
            this.imageList1.Images.SetKeyName(31, "mi.png");
            this.imageList1.Images.SetKeyName(32, "mu.png");
            this.imageList1.Images.SetKeyName(33, "me.png");
            this.imageList1.Images.SetKeyName(34, "mo.png");
            this.imageList1.Images.SetKeyName(35, "ya.png");
            this.imageList1.Images.SetKeyName(36, "yu.png");
            this.imageList1.Images.SetKeyName(37, "yo.png");
            this.imageList1.Images.SetKeyName(38, "ra.png");
            this.imageList1.Images.SetKeyName(39, "ri.png");
            this.imageList1.Images.SetKeyName(40, "ru.png");
            this.imageList1.Images.SetKeyName(41, "re.png");
            this.imageList1.Images.SetKeyName(42, "ro.png");
            this.imageList1.Images.SetKeyName(43, "wa.png");
            this.imageList1.Images.SetKeyName(44, "wi.png");
            this.imageList1.Images.SetKeyName(45, "we.png");
            this.imageList1.Images.SetKeyName(46, "wo.png");
            this.imageList1.Images.SetKeyName(47, "n.png");
            this.imageList1.Images.SetKeyName(48, "a.png");
            this.imageList1.Images.SetKeyName(49, "i.png");
            this.imageList1.Images.SetKeyName(50, "u.png");
            this.imageList1.Images.SetKeyName(51, "e.png");
            this.imageList1.Images.SetKeyName(52, "o.png");
            this.imageList1.Images.SetKeyName(53, "ka.png");
            this.imageList1.Images.SetKeyName(54, "ki.png");
            this.imageList1.Images.SetKeyName(55, "ku.png");
            this.imageList1.Images.SetKeyName(56, "ke.png");
            this.imageList1.Images.SetKeyName(57, "ko.png");
            this.imageList1.Images.SetKeyName(58, "sa.png");
            this.imageList1.Images.SetKeyName(59, "shi.png");
            this.imageList1.Images.SetKeyName(60, "su.png");
            this.imageList1.Images.SetKeyName(61, "se.png");
            this.imageList1.Images.SetKeyName(62, "so.png");
            this.imageList1.Images.SetKeyName(63, "ta.png");
            this.imageList1.Images.SetKeyName(64, "chi.png");
            this.imageList1.Images.SetKeyName(65, "tsu.png");
            this.imageList1.Images.SetKeyName(66, "te.png");
            this.imageList1.Images.SetKeyName(67, "to.png");
            this.imageList1.Images.SetKeyName(68, "na.png");
            this.imageList1.Images.SetKeyName(69, "ni.png");
            this.imageList1.Images.SetKeyName(70, "nu.png");
            this.imageList1.Images.SetKeyName(71, "ne.png");
            this.imageList1.Images.SetKeyName(72, "no.png");
            this.imageList1.Images.SetKeyName(73, "ha.png");
            this.imageList1.Images.SetKeyName(74, "hi.png");
            this.imageList1.Images.SetKeyName(75, "fu.png");
            this.imageList1.Images.SetKeyName(76, "he.png");
            this.imageList1.Images.SetKeyName(77, "ho.png");
            this.imageList1.Images.SetKeyName(78, "ma.png");
            this.imageList1.Images.SetKeyName(79, "mi.png");
            this.imageList1.Images.SetKeyName(80, "mu.png");
            this.imageList1.Images.SetKeyName(81, "me.png");
            this.imageList1.Images.SetKeyName(82, "mo.png");
            this.imageList1.Images.SetKeyName(83, "ya.png");
            this.imageList1.Images.SetKeyName(84, "yu.png");
            this.imageList1.Images.SetKeyName(85, "yo.png");
            this.imageList1.Images.SetKeyName(86, "ra.png");
            this.imageList1.Images.SetKeyName(87, "ri.png");
            this.imageList1.Images.SetKeyName(88, "ru.png");
            this.imageList1.Images.SetKeyName(89, "re.png");
            this.imageList1.Images.SetKeyName(90, "ro.png");
            this.imageList1.Images.SetKeyName(91, "wa.png");
            this.imageList1.Images.SetKeyName(92, "wi.png");
            this.imageList1.Images.SetKeyName(93, "we.png");
            this.imageList1.Images.SetKeyName(94, "wo.png");
            this.imageList1.Images.SetKeyName(95, "n.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "Answer";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Result";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(280, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(47, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hiraganaToolStripMenuItem,
            this.kataganaToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem3.Text = "Gojuon Table";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem.Text = "ABout";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hiragana.Properties.Resources.full;
            this.pictureBox1.Location = new System.Drawing.Point(60, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 141);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // hiraganaToolStripMenuItem
            // 
            this.hiraganaToolStripMenuItem.Name = "hiraganaToolStripMenuItem";
            this.hiraganaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.hiraganaToolStripMenuItem.Text = "Hiragana 平仮名";
            this.hiraganaToolStripMenuItem.Click += new System.EventHandler(this.hiraganaToolStripMenuItem_Click);
            // 
            // kataganaToolStripMenuItem
            // 
            this.kataganaToolStripMenuItem.Name = "kataganaToolStripMenuItem";
            this.kataganaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.kataganaToolStripMenuItem.Text = "Katagana 片仮名";
            this.kataganaToolStripMenuItem.Click += new System.EventHandler(this.kataganaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 238);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Gojūon 五十音";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Check;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hiraganaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kataganaToolStripMenuItem;
    }
}

