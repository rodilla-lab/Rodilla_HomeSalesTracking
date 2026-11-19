namespace Rodilla_HomeSalesTracking
{
    partial class Form2
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
            this.Lbl_ReportTitle = new System.Windows.Forms.Label();
            this.Lbl_DanielleTotal = new System.Windows.Forms.Label();
            this.Lbl_EdwardTotal = new System.Windows.Forms.Label();
            this.Lbl_FatimaTotal = new System.Windows.Forms.Label();
            this.Lbl_GrandTotal = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_ReportTitle
            // 
            this.Lbl_ReportTitle.BackColor = System.Drawing.Color.Azure;
            this.Lbl_ReportTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ReportTitle.Location = new System.Drawing.Point(42, 9);
            this.Lbl_ReportTitle.Name = "Lbl_ReportTitle";
            this.Lbl_ReportTitle.Size = new System.Drawing.Size(500, 50);
            this.Lbl_ReportTitle.TabIndex = 0;
            this.Lbl_ReportTitle.Text = "SALES SUMMARY REPORT";
            this.Lbl_ReportTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_DanielleTotal
            // 
            this.Lbl_DanielleTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.Lbl_DanielleTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DanielleTotal.Location = new System.Drawing.Point(42, 79);
            this.Lbl_DanielleTotal.Name = "Lbl_DanielleTotal";
            this.Lbl_DanielleTotal.Size = new System.Drawing.Size(500, 40);
            this.Lbl_DanielleTotal.TabIndex = 1;
            this.Lbl_DanielleTotal.Text = "Danielle Total Sales:                                                            " +
    "         ₱0.00";
            this.Lbl_DanielleTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_EdwardTotal
            // 
            this.Lbl_EdwardTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.Lbl_EdwardTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EdwardTotal.Location = new System.Drawing.Point(42, 128);
            this.Lbl_EdwardTotal.Name = "Lbl_EdwardTotal";
            this.Lbl_EdwardTotal.Size = new System.Drawing.Size(500, 40);
            this.Lbl_EdwardTotal.TabIndex = 2;
            this.Lbl_EdwardTotal.Text = "Edward Total Sales:                                                              " +
    "        ₱0.00";
            this.Lbl_EdwardTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_FatimaTotal
            // 
            this.Lbl_FatimaTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.Lbl_FatimaTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_FatimaTotal.Location = new System.Drawing.Point(42, 178);
            this.Lbl_FatimaTotal.Name = "Lbl_FatimaTotal";
            this.Lbl_FatimaTotal.Size = new System.Drawing.Size(500, 40);
            this.Lbl_FatimaTotal.TabIndex = 3;
            this.Lbl_FatimaTotal.Text = "Fatima Total Sales:                                                              " +
    "          ₱0.00";
            this.Lbl_FatimaTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_GrandTotal
            // 
            this.Lbl_GrandTotal.BackColor = System.Drawing.Color.AliceBlue;
            this.Lbl_GrandTotal.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_GrandTotal.Location = new System.Drawing.Point(42, 236);
            this.Lbl_GrandTotal.Name = "Lbl_GrandTotal";
            this.Lbl_GrandTotal.Size = new System.Drawing.Size(500, 50);
            this.Lbl_GrandTotal.TabIndex = 4;
            this.Lbl_GrandTotal.Text = "GRAND TOTAL:                                          ₱0.00   ";
            this.Lbl_GrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_GrandTotal.Click += new System.EventHandler(this.Lbl_GrandTotal_Click);
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.Color.MidnightBlue;
            this.Btn_Close.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(239, 307);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(120, 40);
            this.Btn_Close.TabIndex = 5;
            this.Btn_Close.Text = "X  CLOSE";
            this.Btn_Close.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 410);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lbl_GrandTotal);
            this.Controls.Add(this.Lbl_FatimaTotal);
            this.Controls.Add(this.Lbl_EdwardTotal);
            this.Controls.Add(this.Lbl_DanielleTotal);
            this.Controls.Add(this.Lbl_ReportTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Summary Report";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ReportTitle;
        private System.Windows.Forms.Label Lbl_DanielleTotal;
        private System.Windows.Forms.Label Lbl_EdwardTotal;
        private System.Windows.Forms.Label Lbl_FatimaTotal;
        private System.Windows.Forms.Label Lbl_GrandTotal;
        private System.Windows.Forms.Button Btn_Close;
    }
}