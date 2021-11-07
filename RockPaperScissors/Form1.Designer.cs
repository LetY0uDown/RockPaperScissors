
namespace RockPaperScissors
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelGameResult = new System.Windows.Forms.Label();
            this.labelCompOutcome = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();
            this.bScissors = new System.Windows.Forms.Button();
            this.bPaper = new System.Windows.Forms.Button();
            this.bRock = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bExit = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.labelGameResult);
            this.splitContainer1.Panel1.Controls.Add(this.labelCompOutcome);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.bScissors);
            this.splitContainer1.Panel2.Controls.Add(this.bPaper);
            this.splitContainer1.Panel2.Controls.Add(this.bRock);
            this.splitContainer1.Size = new System.Drawing.Size(259, 266);
            this.splitContainer1.SplitterDistance = 203;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelGameResult
            // 
            this.labelGameResult.AutoSize = true;
            this.labelGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.labelGameResult.Location = new System.Drawing.Point(38, 139);
            this.labelGameResult.Name = "labelGameResult";
            this.labelGameResult.Size = new System.Drawing.Size(209, 29);
            this.labelGameResult.TabIndex = 1;
            this.labelGameResult.Text = "Результат игры";
            // 
            // labelCompOutcome
            // 
            this.labelCompOutcome.AutoSize = true;
            this.labelCompOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCompOutcome.Location = new System.Drawing.Point(39, 65);
            this.labelCompOutcome.Name = "labelCompOutcome";
            this.labelCompOutcome.Size = new System.Drawing.Size(160, 20);
            this.labelCompOutcome.TabIndex = 1;
            this.labelCompOutcome.Text = "Выбор компьютера:";
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.BackColor = System.Drawing.Color.Transparent;
            this.labelStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.labelStats.ForeColor = System.Drawing.Color.LightGray;
            this.labelStats.Location = new System.Drawing.Point(3, 4);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(206, 13);
            this.labelStats.TabIndex = 0;
            this.labelStats.Text = "Побед: 0 Поражений: 0 Ничьих: 0";
            // 
            // bScissors
            // 
            this.bScissors.Dock = System.Windows.Forms.DockStyle.Left;
            this.bScissors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bScissors.Location = new System.Drawing.Point(170, 0);
            this.bScissors.Name = "bScissors";
            this.bScissors.Size = new System.Drawing.Size(85, 55);
            this.bScissors.TabIndex = 1;
            this.bScissors.Text = "Ножницы";
            this.bScissors.UseVisualStyleBackColor = true;
            this.bScissors.Click += new System.EventHandler(this.bScissors_Click);
            // 
            // bPaper
            // 
            this.bPaper.Dock = System.Windows.Forms.DockStyle.Left;
            this.bPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bPaper.Location = new System.Drawing.Point(85, 0);
            this.bPaper.Name = "bPaper";
            this.bPaper.Size = new System.Drawing.Size(85, 55);
            this.bPaper.TabIndex = 2;
            this.bPaper.Text = "Бумага";
            this.bPaper.UseVisualStyleBackColor = true;
            this.bPaper.Click += new System.EventHandler(this.bPaper_Click);
            // 
            // bRock
            // 
            this.bRock.Dock = System.Windows.Forms.DockStyle.Left;
            this.bRock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.bRock.Location = new System.Drawing.Point(0, 0);
            this.bRock.Name = "bRock";
            this.bRock.Size = new System.Drawing.Size(85, 55);
            this.bRock.TabIndex = 0;
            this.bRock.Text = "Камень";
            this.bRock.UseVisualStyleBackColor = true;
            this.bRock.Click += new System.EventHandler(this.bRock_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.bExit);
            this.panel1.Controls.Add(this.labelStats);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 21);
            this.panel1.TabIndex = 2;
            // 
            // bExit
            // 
            this.bExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bExit.FlatAppearance.BorderSize = 0;
            this.bExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.bExit.IconColor = System.Drawing.Color.Red;
            this.bExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bExit.IconSize = 21;
            this.bExit.Location = new System.Drawing.Point(234, 0);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(21, 21);
            this.bExit.TabIndex = 0;
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(259, 266);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bScissors;
        private System.Windows.Forms.Button bPaper;
        private System.Windows.Forms.Button bRock;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelCompOutcome;
        private System.Windows.Forms.Label labelGameResult;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton bExit;
    }
}

