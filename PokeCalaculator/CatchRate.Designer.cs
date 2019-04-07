namespace PokeCalaculator
{
    partial class CatchRate
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
            this.descLabel = new System.Windows.Forms.Label();
            this.rand0 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Generation34Radio = new System.Windows.Forms.RadioButton();
            this.Generation5radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(13, 13);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(297, 13);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "This will show you the chance you have to catch a pokemon.";
            // 
            // rand0
            // 
            this.rand0.AutoSize = true;
            this.rand0.Location = new System.Drawing.Point(12, 65);
            this.rand0.Name = "rand0";
            this.rand0.Size = new System.Drawing.Size(0, 13);
            this.rand0.TabIndex = 9;
            // 
            // resultText
            // 
            this.resultText.AutoSize = true;
            this.resultText.Location = new System.Drawing.Point(20, 399);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(0, 13);
            this.resultText.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Generation:";
            // 
            // Generation34Radio
            // 
            this.Generation34Radio.AutoSize = true;
            this.Generation34Radio.Location = new System.Drawing.Point(13, 82);
            this.Generation34Radio.Name = "Generation34Radio";
            this.Generation34Radio.Size = new System.Drawing.Size(121, 17);
            this.Generation34Radio.TabIndex = 19;
            this.Generation34Radio.TabStop = true;
            this.Generation34Radio.Text = "Generations 3 and 4";
            this.Generation34Radio.UseVisualStyleBackColor = true;
            // 
            // Generation5radio
            // 
            this.Generation5radio.AutoSize = true;
            this.Generation5radio.Location = new System.Drawing.Point(13, 106);
            this.Generation5radio.Name = "Generation5radio";
            this.Generation5radio.Size = new System.Drawing.Size(86, 17);
            this.Generation5radio.TabIndex = 20;
            this.Generation5radio.TabStop = true;
            this.Generation5radio.Text = "Generation 5";
            this.Generation5radio.UseVisualStyleBackColor = true;
            // 
            // CatchRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(406, 450);
            this.Controls.Add(this.Generation5radio);
            this.Controls.Add(this.Generation34Radio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.rand0);
            this.Controls.Add(this.descLabel);
            this.Name = "CatchRate";
            this.Text = "Opponents current hp:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label rand0;
        private System.Windows.Forms.Label resultText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Generation34Radio;
        private System.Windows.Forms.RadioButton Generation5radio;
    }
}