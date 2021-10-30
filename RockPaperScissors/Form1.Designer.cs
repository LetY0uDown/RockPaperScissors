
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
            System.Windows.Forms.SplitContainer splitContainer1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelGameResult = new System.Windows.Forms.Label();
            this.labelCompOutcome = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();
            this.bScissors = new System.Windows.Forms.Button();
            this.bPaper = new System.Windows.Forms.Button();
            this.bRock = new System.Windows.Forms.Button();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(this.labelGameResult);
            splitContainer1.Panel1.Controls.Add(this.labelCompOutcome);
            splitContainer1.Panel1.Controls.Add(this.labelStats);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(this.bScissors);
            splitContainer1.Panel2.Controls.Add(this.bPaper);
            splitContainer1.Panel2.Controls.Add(this.bRock);
            splitContainer1.Size = new System.Drawing.Size(259, 207);
            splitContainer1.SplitterDistance = 147;
            splitContainer1.TabIndex = 0;
            // 
            // labelGameResult
            // 
            this.labelGameResult.AutoSize = true;
            this.labelGameResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameResult.Location = new System.Drawing.Point(38, 104);
            this.labelGameResult.Name = "labelGameResult";
            this.labelGameResult.Size = new System.Drawing.Size(182, 25);
            this.labelGameResult.TabIndex = 1;
            this.labelGameResult.Text = "Результат игры";
            // 
            // labelCompOutcome
            // 
            this.labelCompOutcome.AutoSize = true;
            this.labelCompOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelCompOutcome.Location = new System.Drawing.Point(39, 45);
            this.labelCompOutcome.Name = "labelCompOutcome";
            this.labelCompOutcome.Size = new System.Drawing.Size(160, 20);
            this.labelCompOutcome.TabIndex = 1;
            this.labelCompOutcome.Text = "Выбор компьютера:";
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold);
            this.labelStats.Location = new System.Drawing.Point(3, 0);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(229, 15);
            this.labelStats.TabIndex = 0;
            this.labelStats.Text = "Побед: 0 Поражений: 0 Ничьих: 0";
            // 
            // bScissors
            // 
            this.bScissors.Location = new System.Drawing.Point(91, 7);
            this.bScissors.Name = "bScissors";
            this.bScissors.Size = new System.Drawing.Size(75, 40);
            this.bScissors.TabIndex = 1;
            this.bScissors.Text = "Ножницы";
            this.bScissors.UseVisualStyleBackColor = true;
            this.bScissors.Click += new System.EventHandler(this.bScissors_Click);
            // 
            // bPaper
            // 
            this.bPaper.Location = new System.Drawing.Point(170, 7);
            this.bPaper.Name = "bPaper";
            this.bPaper.Size = new System.Drawing.Size(75, 40);
            this.bPaper.TabIndex = 2;
            this.bPaper.Text = "Бумага";
            this.bPaper.UseVisualStyleBackColor = true;
            this.bPaper.Click += new System.EventHandler(this.bPaper_Click);
            // 
            // bRock
            // 
            this.bRock.Location = new System.Drawing.Point(10, 7);
            this.bRock.Name = "bRock";
            this.bRock.Size = new System.Drawing.Size(75, 40);
            this.bRock.TabIndex = 0;
            this.bRock.Text = "Камень";
            this.bRock.UseVisualStyleBackColor = true;
            this.bRock.Click += new System.EventHandler(this.bRock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(259, 207);
            this.Controls.Add(splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Камень Ножницы Бумага";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer1)).EndInit();
            splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bScissors;
        private System.Windows.Forms.Button bPaper;
        private System.Windows.Forms.Button bRock;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelCompOutcome;
        private System.Windows.Forms.Label labelGameResult;
    }
}

