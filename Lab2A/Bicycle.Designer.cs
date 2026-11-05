namespace Lab2A
{
    partial class Bicycle
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
            this.txtStartingTime = new System.Windows.Forms.TextBox();
            this.txtEndingTime = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStartingTime
            // 
            this.txtStartingTime.Location = new System.Drawing.Point(185, 90);
            this.txtStartingTime.Name = "txtStartingTime";
            this.txtStartingTime.Size = new System.Drawing.Size(100, 20);
            this.txtStartingTime.TabIndex = 0;
            // 
            // txtEndingTime
            // 
            this.txtEndingTime.Location = new System.Drawing.Point(414, 90);
            this.txtEndingTime.Name = "txtEndingTime";
            this.txtEndingTime.Size = new System.Drawing.Size(100, 20);
            this.txtEndingTime.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(308, 159);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(379, 93);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(29, 13);
            this.lbEnd.TabIndex = 3;
            this.lbEnd.Text = "End:";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(251, 162);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 13);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "Total:";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(147, 93);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(32, 13);
            this.lbStart.TabIndex = 5;
            this.lbStart.Text = "Start:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(243, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(217, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(636, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(46, 47);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Bicycle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtEndingTime);
            this.Controls.Add(this.txtStartingTime);
            this.Name = "Bicycle";
            this.Text = "Bicycle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartingTime;
        private System.Windows.Forms.TextBox txtEndingTime;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
    }
}