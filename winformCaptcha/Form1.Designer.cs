namespace winformCaptcha
{
    partial class winformCaptcha
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winformCaptcha));
            this.panel1 = new System.Windows.Forms.Panel();
            this.resultText = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.backgroundPanel = new System.Windows.Forms.Panel();
            this.charOne = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.backgroundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.resultText);
            this.panel1.Controls.Add(this.lblAnswer);
            this.panel1.Controls.Add(this.okayButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.backgroundPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(417, 262);
            this.panel1.TabIndex = 1;
            // 
            // resultText
            // 
            this.resultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultText.ForeColor = System.Drawing.Color.Red;
            this.resultText.Location = new System.Drawing.Point(161, 164);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(186, 30);
            this.resultText.TabIndex = 4;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnswer.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblAnswer.Location = new System.Drawing.Point(49, 164);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(106, 29);
            this.lblAnswer.TabIndex = 3;
            this.lblAnswer.Text = "Answer:";
            // 
            // okayButton
            // 
            this.okayButton.BackColor = System.Drawing.Color.White;
            this.okayButton.ForeColor = System.Drawing.Color.White;
            this.okayButton.Image = global::winformCaptcha.Properties.Resources._checked;
            this.okayButton.Location = new System.Drawing.Point(243, 201);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(63, 50);
            this.okayButton.TabIndex = 2;
            this.okayButton.UseVisualStyleBackColor = false;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.refreshButton.BackgroundImage = global::winformCaptcha.Properties.Resources.refresh;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.refreshButton.ForeColor = System.Drawing.Color.Transparent;
            this.refreshButton.Location = new System.Drawing.Point(179, 201);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(58, 50);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // backgroundPanel
            // 
            this.backgroundPanel.BackgroundImage = global::winformCaptcha.Properties.Resources.BackGround;
            this.backgroundPanel.Controls.Add(this.charOne);
            this.backgroundPanel.Location = new System.Drawing.Point(3, 3);
            this.backgroundPanel.Name = "backgroundPanel";
            this.backgroundPanel.Size = new System.Drawing.Size(411, 142);
            this.backgroundPanel.TabIndex = 0;
            // 
            // charOne
            // 
            this.charOne.AutoSize = true;
            this.charOne.BackColor = System.Drawing.Color.Transparent;
            this.charOne.Font = new System.Drawing.Font("Ravie", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charOne.ForeColor = System.Drawing.Color.Aqua;
            this.charOne.Location = new System.Drawing.Point(51, 23);
            this.charOne.Name = "charOne";
            this.charOne.Size = new System.Drawing.Size(293, 107);
            this.charOne.TabIndex = 1;
            this.charOne.Text = "test";
            // 
            // winformCaptcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 262);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "winformCaptcha";
            this.Text = "wfCaptcha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.backgroundPanel.ResumeLayout(false);
            this.backgroundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label charOne;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel backgroundPanel;
    }
}

