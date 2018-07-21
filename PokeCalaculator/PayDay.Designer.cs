namespace PokeCalaculator
{
    partial class PayDay
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
            this.level = new System.Windows.Forms.TextBox();
            this.descLevel = new System.Windows.Forms.Label();
            this.calc = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // level
            // 
            this.level.Location = new System.Drawing.Point(16, 40);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(293, 20);
            this.level.TabIndex = 0;
            // 
            // descLevel
            // 
            this.descLevel.AutoSize = true;
            this.descLevel.Location = new System.Drawing.Point(145, 24);
            this.descLevel.Name = "descLevel";
            this.descLevel.Size = new System.Drawing.Size(36, 13);
            this.descLevel.TabIndex = 2;
            this.descLevel.Text = "Level:";
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(13, 67);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(296, 23);
            this.calc.TabIndex = 3;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.button1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(13, 105);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 5;
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(0, 8);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(324, 13);
            this.Desc.TabIndex = 6;
            this.Desc.Text = "Amount of money  given after the battle when payday is used once.";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(234, 105);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 7;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // PayDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 130);
            this.Controls.Add(this.back);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.result);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.descLevel);
            this.Controls.Add(this.level);
            this.Name = "PayDay";
            this.Text = "Pay Day";
            this.Load += new System.EventHandler(this.PayDay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox level;
        private System.Windows.Forms.Label descLevel;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Button back;
    }
}