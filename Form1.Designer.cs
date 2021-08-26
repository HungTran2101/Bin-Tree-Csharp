namespace DoAnCK_BinTree
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeArea = new System.Windows.Forms.Panel();
            this.AddBt = new System.Windows.Forms.Button();
            this.Addtxt = new System.Windows.Forms.TextBox();
            this.AddDelFindpnl = new System.Windows.Forms.Panel();
            this.clearBt = new System.Windows.Forms.Button();
            this.Findtxt = new System.Windows.Forms.TextBox();
            this.FindBt = new System.Windows.Forms.Button();
            this.Deltxt = new System.Windows.Forms.TextBox();
            this.DelBt = new System.Windows.Forms.Button();
            this.RandAddBt = new System.Windows.Forms.Button();
            this.RandTreepnl = new System.Windows.Forms.Panel();
            this.Nodetxt = new System.Windows.Forms.NumericUpDown();
            this.nodeLbl = new System.Windows.Forms.Label();
            this.Maxtxt = new System.Windows.Forms.NumericUpDown();
            this.Mintxt = new System.Windows.Forms.NumericUpDown();
            this.maxLbl = new System.Windows.Forms.Label();
            this.minLbl = new System.Windows.Forms.Label();
            this.RandTreeBt = new System.Windows.Forms.Button();
            this.Searchpnl = new System.Windows.Forms.Panel();
            this.InSBt = new System.Windows.Forms.Button();
            this.PosSBt = new System.Windows.Forms.Button();
            this.PreSBt = new System.Windows.Forms.Button();
            this.Resulttxt = new System.Windows.Forms.TextBox();
            this.searchLbl = new System.Windows.Forms.Label();
            this.resultPnl = new System.Windows.Forms.Panel();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.totalNodesLbl = new System.Windows.Forms.Label();
            this.BigPanel = new System.Windows.Forms.Panel();
            this.AddDelFindpnl.SuspendLayout();
            this.RandTreepnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nodetxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxtxt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mintxt)).BeginInit();
            this.Searchpnl.SuspendLayout();
            this.resultPnl.SuspendLayout();
            this.BigPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeArea
            // 
            this.treeArea.AutoScroll = true;
            this.treeArea.BackColor = System.Drawing.Color.LightGray;
            this.treeArea.Location = new System.Drawing.Point(230, 12);
            this.treeArea.Name = "treeArea";
            this.treeArea.Size = new System.Drawing.Size(893, 628);
            this.treeArea.TabIndex = 1;
            this.treeArea.Scroll += new System.Windows.Forms.ScrollEventHandler(this.treeArea_Scroll);
            this.treeArea.Paint += new System.Windows.Forms.PaintEventHandler(this.treeArea_Paint);
            // 
            // AddBt
            // 
            this.AddBt.BackColor = System.Drawing.Color.Gainsboro;
            this.AddBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBt.ForeColor = System.Drawing.Color.Black;
            this.AddBt.Location = new System.Drawing.Point(3, 14);
            this.AddBt.Name = "AddBt";
            this.AddBt.Size = new System.Drawing.Size(102, 35);
            this.AddBt.TabIndex = 2;
            this.AddBt.Text = "Add";
            this.AddBt.UseVisualStyleBackColor = false;
            this.AddBt.Click += new System.EventHandler(this.AddBt_Click);
            // 
            // Addtxt
            // 
            this.Addtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Addtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addtxt.ForeColor = System.Drawing.Color.Lime;
            this.Addtxt.Location = new System.Drawing.Point(111, 18);
            this.Addtxt.Name = "Addtxt";
            this.Addtxt.Size = new System.Drawing.Size(84, 24);
            this.Addtxt.TabIndex = 1;
            this.Addtxt.TextChanged += new System.EventHandler(this.Addtxt_TextChanged);
            this.Addtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Addtxt_KeyDown);
            // 
            // AddDelFindpnl
            // 
            this.AddDelFindpnl.BackColor = System.Drawing.Color.Black;
            this.AddDelFindpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AddDelFindpnl.Controls.Add(this.clearBt);
            this.AddDelFindpnl.Controls.Add(this.Findtxt);
            this.AddDelFindpnl.Controls.Add(this.FindBt);
            this.AddDelFindpnl.Controls.Add(this.Deltxt);
            this.AddDelFindpnl.Controls.Add(this.DelBt);
            this.AddDelFindpnl.Controls.Add(this.RandAddBt);
            this.AddDelFindpnl.Controls.Add(this.Addtxt);
            this.AddDelFindpnl.Controls.Add(this.AddBt);
            this.AddDelFindpnl.Location = new System.Drawing.Point(12, 12);
            this.AddDelFindpnl.Name = "AddDelFindpnl";
            this.AddDelFindpnl.Size = new System.Drawing.Size(200, 182);
            this.AddDelFindpnl.TabIndex = 5;
            // 
            // clearBt
            // 
            this.clearBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clearBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBt.Location = new System.Drawing.Point(111, 55);
            this.clearBt.Name = "clearBt";
            this.clearBt.Size = new System.Drawing.Size(81, 35);
            this.clearBt.TabIndex = 8;
            this.clearBt.Text = "Clear";
            this.clearBt.UseVisualStyleBackColor = true;
            this.clearBt.Click += new System.EventHandler(this.clearBt_Click);
            // 
            // Findtxt
            // 
            this.Findtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Findtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Findtxt.ForeColor = System.Drawing.Color.Lime;
            this.Findtxt.Location = new System.Drawing.Point(111, 141);
            this.Findtxt.Name = "Findtxt";
            this.Findtxt.Size = new System.Drawing.Size(84, 24);
            this.Findtxt.TabIndex = 6;
            this.Findtxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Findtxt_KeyDown);
            // 
            // FindBt
            // 
            this.FindBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FindBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindBt.Location = new System.Drawing.Point(3, 137);
            this.FindBt.Name = "FindBt";
            this.FindBt.Size = new System.Drawing.Size(102, 35);
            this.FindBt.TabIndex = 7;
            this.FindBt.Text = "Find";
            this.FindBt.UseVisualStyleBackColor = true;
            this.FindBt.Click += new System.EventHandler(this.FindBt_Click);
            // 
            // Deltxt
            // 
            this.Deltxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Deltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deltxt.ForeColor = System.Drawing.Color.Lime;
            this.Deltxt.Location = new System.Drawing.Point(111, 100);
            this.Deltxt.Name = "Deltxt";
            this.Deltxt.Size = new System.Drawing.Size(84, 24);
            this.Deltxt.TabIndex = 4;
            this.Deltxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Deltxt_KeyDown);
            // 
            // DelBt
            // 
            this.DelBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DelBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelBt.Location = new System.Drawing.Point(3, 96);
            this.DelBt.Name = "DelBt";
            this.DelBt.Size = new System.Drawing.Size(102, 35);
            this.DelBt.TabIndex = 5;
            this.DelBt.Text = "Delete";
            this.DelBt.UseVisualStyleBackColor = true;
            this.DelBt.Click += new System.EventHandler(this.DelBt_Click);
            // 
            // RandAddBt
            // 
            this.RandAddBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RandAddBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandAddBt.Location = new System.Drawing.Point(3, 55);
            this.RandAddBt.Name = "RandAddBt";
            this.RandAddBt.Size = new System.Drawing.Size(102, 35);
            this.RandAddBt.TabIndex = 3;
            this.RandAddBt.Text = "Random";
            this.RandAddBt.UseVisualStyleBackColor = true;
            this.RandAddBt.Click += new System.EventHandler(this.RandAddBt_Click);
            // 
            // RandTreepnl
            // 
            this.RandTreepnl.BackColor = System.Drawing.Color.Black;
            this.RandTreepnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RandTreepnl.Controls.Add(this.Nodetxt);
            this.RandTreepnl.Controls.Add(this.nodeLbl);
            this.RandTreepnl.Controls.Add(this.Maxtxt);
            this.RandTreepnl.Controls.Add(this.Mintxt);
            this.RandTreepnl.Controls.Add(this.maxLbl);
            this.RandTreepnl.Controls.Add(this.minLbl);
            this.RandTreepnl.Controls.Add(this.RandTreeBt);
            this.RandTreepnl.Location = new System.Drawing.Point(12, 200);
            this.RandTreepnl.Name = "RandTreepnl";
            this.RandTreepnl.Size = new System.Drawing.Size(200, 137);
            this.RandTreepnl.TabIndex = 6;
            // 
            // Nodetxt
            // 
            this.Nodetxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Nodetxt.ForeColor = System.Drawing.Color.Lime;
            this.Nodetxt.Location = new System.Drawing.Point(86, 16);
            this.Nodetxt.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.Nodetxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Nodetxt.Name = "Nodetxt";
            this.Nodetxt.Size = new System.Drawing.Size(95, 20);
            this.Nodetxt.TabIndex = 8;
            this.Nodetxt.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nodeLbl
            // 
            this.nodeLbl.AutoSize = true;
            this.nodeLbl.BackColor = System.Drawing.Color.Black;
            this.nodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nodeLbl.ForeColor = System.Drawing.Color.Lime;
            this.nodeLbl.Location = new System.Drawing.Point(13, 17);
            this.nodeLbl.Name = "nodeLbl";
            this.nodeLbl.Size = new System.Drawing.Size(65, 20);
            this.nodeLbl.TabIndex = 5;
            this.nodeLbl.Text = "Nodes:";
            this.nodeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Maxtxt
            // 
            this.Maxtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Maxtxt.ForeColor = System.Drawing.Color.Lime;
            this.Maxtxt.Location = new System.Drawing.Point(86, 69);
            this.Maxtxt.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Maxtxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Maxtxt.Name = "Maxtxt";
            this.Maxtxt.Size = new System.Drawing.Size(95, 20);
            this.Maxtxt.TabIndex = 10;
            this.Maxtxt.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // Mintxt
            // 
            this.Mintxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Mintxt.ForeColor = System.Drawing.Color.Lime;
            this.Mintxt.Location = new System.Drawing.Point(86, 43);
            this.Mintxt.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.Mintxt.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Mintxt.Name = "Mintxt";
            this.Mintxt.Size = new System.Drawing.Size(95, 20);
            this.Mintxt.TabIndex = 9;
            this.Mintxt.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maxLbl
            // 
            this.maxLbl.AutoSize = true;
            this.maxLbl.BackColor = System.Drawing.Color.Black;
            this.maxLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxLbl.ForeColor = System.Drawing.Color.Lime;
            this.maxLbl.Location = new System.Drawing.Point(13, 69);
            this.maxLbl.Name = "maxLbl";
            this.maxLbl.Size = new System.Drawing.Size(46, 20);
            this.maxLbl.TabIndex = 2;
            this.maxLbl.Text = "Max:";
            // 
            // minLbl
            // 
            this.minLbl.AutoSize = true;
            this.minLbl.BackColor = System.Drawing.Color.Black;
            this.minLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minLbl.ForeColor = System.Drawing.Color.Lime;
            this.minLbl.Location = new System.Drawing.Point(13, 43);
            this.minLbl.Name = "minLbl";
            this.minLbl.Size = new System.Drawing.Size(42, 20);
            this.minLbl.TabIndex = 1;
            this.minLbl.Text = "Min:";
            // 
            // RandTreeBt
            // 
            this.RandTreeBt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RandTreeBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RandTreeBt.Location = new System.Drawing.Point(0, 101);
            this.RandTreeBt.Name = "RandTreeBt";
            this.RandTreeBt.Size = new System.Drawing.Size(198, 34);
            this.RandTreeBt.TabIndex = 11;
            this.RandTreeBt.Text = "New random Tree";
            this.RandTreeBt.UseVisualStyleBackColor = true;
            this.RandTreeBt.Click += new System.EventHandler(this.RandTreeBt_Click);
            // 
            // Searchpnl
            // 
            this.Searchpnl.BackColor = System.Drawing.Color.Black;
            this.Searchpnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Searchpnl.Controls.Add(this.InSBt);
            this.Searchpnl.Controls.Add(this.PosSBt);
            this.Searchpnl.Controls.Add(this.PreSBt);
            this.Searchpnl.Location = new System.Drawing.Point(12, 343);
            this.Searchpnl.Name = "Searchpnl";
            this.Searchpnl.Size = new System.Drawing.Size(200, 122);
            this.Searchpnl.TabIndex = 10;
            // 
            // InSBt
            // 
            this.InSBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InSBt.Location = new System.Drawing.Point(17, 81);
            this.InSBt.Name = "InSBt";
            this.InSBt.Size = new System.Drawing.Size(164, 33);
            this.InSBt.TabIndex = 14;
            this.InSBt.Text = "In-order Search";
            this.InSBt.UseVisualStyleBackColor = true;
            this.InSBt.Click += new System.EventHandler(this.InSBt_Click);
            // 
            // PosSBt
            // 
            this.PosSBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosSBt.Location = new System.Drawing.Point(17, 42);
            this.PosSBt.Name = "PosSBt";
            this.PosSBt.Size = new System.Drawing.Size(164, 33);
            this.PosSBt.TabIndex = 13;
            this.PosSBt.Text = "Pos-order Search";
            this.PosSBt.UseVisualStyleBackColor = true;
            this.PosSBt.Click += new System.EventHandler(this.PosSBt_Click);
            // 
            // PreSBt
            // 
            this.PreSBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreSBt.Location = new System.Drawing.Point(17, 3);
            this.PreSBt.Name = "PreSBt";
            this.PreSBt.Size = new System.Drawing.Size(164, 33);
            this.PreSBt.TabIndex = 12;
            this.PreSBt.Text = "Pre-order Search";
            this.PreSBt.UseVisualStyleBackColor = true;
            this.PreSBt.Click += new System.EventHandler(this.PreSBt_Click);
            // 
            // Resulttxt
            // 
            this.Resulttxt.AllowDrop = true;
            this.Resulttxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Resulttxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Resulttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resulttxt.ForeColor = System.Drawing.Color.Lime;
            this.Resulttxt.Location = new System.Drawing.Point(-1, 35);
            this.Resulttxt.Multiline = true;
            this.Resulttxt.Name = "Resulttxt";
            this.Resulttxt.ReadOnly = true;
            this.Resulttxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Resulttxt.Size = new System.Drawing.Size(201, 45);
            this.Resulttxt.TabIndex = 3;
            this.Resulttxt.WordWrap = false;
            // 
            // searchLbl
            // 
            this.searchLbl.AutoSize = true;
            this.searchLbl.BackColor = System.Drawing.Color.Black;
            this.searchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLbl.ForeColor = System.Drawing.Color.Lime;
            this.searchLbl.Location = new System.Drawing.Point(40, 14);
            this.searchLbl.Name = "searchLbl";
            this.searchLbl.Size = new System.Drawing.Size(113, 18);
            this.searchLbl.TabIndex = 11;
            this.searchLbl.Text = "Search result:";
            // 
            // resultPnl
            // 
            this.resultPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultPnl.Controls.Add(this.Resulttxt);
            this.resultPnl.Controls.Add(this.searchLbl);
            this.resultPnl.Location = new System.Drawing.Point(12, 471);
            this.resultPnl.Name = "resultPnl";
            this.resultPnl.Size = new System.Drawing.Size(200, 98);
            this.resultPnl.TabIndex = 12;
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLbl.ForeColor = System.Drawing.Color.Cyan;
            this.InfoLbl.Location = new System.Drawing.Point(8, 620);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(102, 20);
            this.InfoLbl.TabIndex = 15;
            this.InfoLbl.Text = "Information...";
            this.InfoLbl.Click += new System.EventHandler(this.InfoLbl_Click);
            // 
            // totalNodesLbl
            // 
            this.totalNodesLbl.AutoSize = true;
            this.totalNodesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNodesLbl.ForeColor = System.Drawing.Color.Lime;
            this.totalNodesLbl.Location = new System.Drawing.Point(10, 572);
            this.totalNodesLbl.Name = "totalNodesLbl";
            this.totalNodesLbl.Size = new System.Drawing.Size(123, 20);
            this.totalNodesLbl.TabIndex = 17;
            this.totalNodesLbl.Text = "Total nodes: 0";
            // 
            // BigPanel
            // 
            this.BigPanel.BackColor = System.Drawing.Color.Black;
            this.BigPanel.Controls.Add(this.InfoLbl);
            this.BigPanel.Controls.Add(this.totalNodesLbl);
            this.BigPanel.Controls.Add(this.resultPnl);
            this.BigPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BigPanel.Location = new System.Drawing.Point(0, 0);
            this.BigPanel.Name = "BigPanel";
            this.BigPanel.Size = new System.Drawing.Size(1135, 650);
            this.BigPanel.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1135, 650);
            this.Controls.Add(this.Searchpnl);
            this.Controls.Add(this.RandTreepnl);
            this.Controls.Add(this.treeArea);
            this.Controls.Add(this.AddDelFindpnl);
            this.Controls.Add(this.BigPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Binary Tree Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AddDelFindpnl.ResumeLayout(false);
            this.AddDelFindpnl.PerformLayout();
            this.RandTreepnl.ResumeLayout(false);
            this.RandTreepnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nodetxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maxtxt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mintxt)).EndInit();
            this.Searchpnl.ResumeLayout(false);
            this.resultPnl.ResumeLayout(false);
            this.resultPnl.PerformLayout();
            this.BigPanel.ResumeLayout(false);
            this.BigPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button AddBt;
        private System.Windows.Forms.TextBox Addtxt;
        private System.Windows.Forms.Panel AddDelFindpnl;
        private System.Windows.Forms.Button RandAddBt;
        private System.Windows.Forms.TextBox Deltxt;
        private System.Windows.Forms.Button DelBt;
        private System.Windows.Forms.Panel RandTreepnl;
        private System.Windows.Forms.NumericUpDown Maxtxt;
        private System.Windows.Forms.NumericUpDown Mintxt;
        private System.Windows.Forms.Label maxLbl;
        private System.Windows.Forms.Label minLbl;
        private System.Windows.Forms.Button RandTreeBt;
        private System.Windows.Forms.Label nodeLbl;
        private System.Windows.Forms.NumericUpDown Nodetxt;
        private System.Windows.Forms.TextBox Findtxt;
        private System.Windows.Forms.Button FindBt;
        private System.Windows.Forms.Panel Searchpnl;
        private System.Windows.Forms.Button InSBt;
        private System.Windows.Forms.Button PosSBt;
        private System.Windows.Forms.Button PreSBt;
        private System.Windows.Forms.Label searchLbl;
        private System.Windows.Forms.Panel resultPnl;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Label totalNodesLbl;
        private System.Windows.Forms.Button clearBt;
        private System.Windows.Forms.Panel BigPanel;
        public System.Windows.Forms.Panel treeArea;
        public System.Windows.Forms.TextBox Resulttxt;
    }
}

