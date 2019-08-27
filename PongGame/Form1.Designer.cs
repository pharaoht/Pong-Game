namespace PongGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.aPaddle2 = new System.Windows.Forms.PictureBox();
            this.aPaddle1 = new System.Windows.Forms.PictureBox();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.aTimer = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.aLabelPlayer1 = new System.Windows.Forms.Label();
            this.aLabelPlayer2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            this.SuspendLayout();
            // 
            // aPaddle2
            // 
            this.aPaddle2.Image = ((System.Drawing.Image)(resources.GetObject("aPaddle2.Image")));
            this.aPaddle2.Location = new System.Drawing.Point(1219, 305);
            this.aPaddle2.Name = "aPaddle2";
            this.aPaddle2.Size = new System.Drawing.Size(22, 202);
            this.aPaddle2.TabIndex = 0;
            this.aPaddle2.TabStop = false;
            // 
            // aPaddle1
            // 
            this.aPaddle1.Image = ((System.Drawing.Image)(resources.GetObject("aPaddle1.Image")));
            this.aPaddle1.Location = new System.Drawing.Point(12, 305);
            this.aPaddle1.Name = "aPaddle1";
            this.aPaddle1.Size = new System.Drawing.Size(22, 201);
            this.aPaddle1.TabIndex = 1;
            this.aPaddle1.TabStop = false;
            // 
            // aBall
            // 
            this.aBall.Image = ((System.Drawing.Image)(resources.GetObject("aBall.Image")));
            this.aBall.Location = new System.Drawing.Point(560, 305);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(34, 33);
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            // 
            // aTimer
            // 
            this.aTimer.Enabled = true;
            this.aTimer.Interval = 1;
            this.aTimer.Tick += new System.EventHandler(this.ATimer_Tick);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.scoreLabel.Location = new System.Drawing.Point(556, 9);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(96, 35);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "SCORE";
            this.scoreLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // aLabelPlayer1
            // 
            this.aLabelPlayer1.AutoSize = true;
            this.aLabelPlayer1.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelPlayer1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aLabelPlayer1.Location = new System.Drawing.Point(556, 32);
            this.aLabelPlayer1.Name = "aLabelPlayer1";
            this.aLabelPlayer1.Size = new System.Drawing.Size(20, 23);
            this.aLabelPlayer1.TabIndex = 4;
            this.aLabelPlayer1.Text = "0";
            this.aLabelPlayer1.Click += new System.EventHandler(this.Label2_Click);
            // 
            // aLabelPlayer2
            // 
            this.aLabelPlayer2.AutoSize = true;
            this.aLabelPlayer2.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aLabelPlayer2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.aLabelPlayer2.Location = new System.Drawing.Point(600, 32);
            this.aLabelPlayer2.Name = "aLabelPlayer2";
            this.aLabelPlayer2.Size = new System.Drawing.Size(20, 23);
            this.aLabelPlayer2.TabIndex = 5;
            this.aLabelPlayer2.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(577, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "|";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1253, 900);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.aLabelPlayer2);
            this.Controls.Add(this.aLabelPlayer1);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.aPaddle1);
            this.Controls.Add(this.aPaddle2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aPaddle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox aPaddle2;
        private System.Windows.Forms.PictureBox aPaddle1;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer aTimer;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label aLabelPlayer1;
        private System.Windows.Forms.Label aLabelPlayer2;
        private System.Windows.Forms.Label label4;
    }
}

