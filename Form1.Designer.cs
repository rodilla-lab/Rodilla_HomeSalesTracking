namespace Rodilla_HomeSalesTracking
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
            this.Lbl_Header = new System.Windows.Forms.Label();
            this.Lbl_Guide = new System.Windows.Forms.Label();
            this.Lbl_Initial = new System.Windows.Forms.Label();
            this.Lbl_Amount = new System.Windows.Forms.Label();
            this.Txt_SalesInitial = new System.Windows.Forms.TextBox();
            this.Txt_SalesAmount = new System.Windows.Forms.TextBox();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.Btn_Print = new System.Windows.Forms.Button();
            this.Lbl_Display = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_Header
            // 
            this.Lbl_Header.BackColor = System.Drawing.Color.Azure;
            this.Lbl_Header.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Header.Location = new System.Drawing.Point(12, 9);
            this.Lbl_Header.Name = "Lbl_Header";
            this.Lbl_Header.Size = new System.Drawing.Size(800, 45);
            this.Lbl_Header.TabIndex = 0;
            this.Lbl_Header.Text = "Home Sales Tracking Application";
            this.Lbl_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Guide
            // 
            this.Lbl_Guide.BackColor = System.Drawing.Color.AliceBlue;
            this.Lbl_Guide.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Guide.Location = new System.Drawing.Point(12, 71);
            this.Lbl_Guide.Name = "Lbl_Guide";
            this.Lbl_Guide.Size = new System.Drawing.Size(800, 35);
            this.Lbl_Guide.TabIndex = 1;
            this.Lbl_Guide.Text = "D   -   Danielle          E   -   Edward          F   -   Fatima";
            this.Lbl_Guide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Initial
            // 
            this.Lbl_Initial.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Initial.Location = new System.Drawing.Point(81, 174);
            this.Lbl_Initial.Name = "Lbl_Initial";
            this.Lbl_Initial.Size = new System.Drawing.Size(280, 35);
            this.Lbl_Initial.TabIndex = 2;
            this.Lbl_Initial.Text = "Enter Sales Person Initial : ";
            this.Lbl_Initial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl_Amount
            // 
            this.Lbl_Amount.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Amount.Location = new System.Drawing.Point(81, 223);
            this.Lbl_Amount.Name = "Lbl_Amount";
            this.Lbl_Amount.Size = new System.Drawing.Size(280, 35);
            this.Lbl_Amount.TabIndex = 3;
            this.Lbl_Amount.Text = "Amount of Sale : ";
            this.Lbl_Amount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_Amount.Click += new System.EventHandler(this.label2_Click);
            // 
            // Txt_SalesInitial
            // 
            this.Txt_SalesInitial.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SalesInitial.Location = new System.Drawing.Point(328, 177);
            this.Txt_SalesInitial.Name = "Txt_SalesInitial";
            this.Txt_SalesInitial.Size = new System.Drawing.Size(250, 25);
            this.Txt_SalesInitial.TabIndex = 4;
            this.Txt_SalesInitial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Txt_SalesAmount
            // 
            this.Txt_SalesAmount.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SalesAmount.Location = new System.Drawing.Point(328, 226);
            this.Txt_SalesAmount.Name = "Txt_SalesAmount";
            this.Txt_SalesAmount.Size = new System.Drawing.Size(250, 25);
            this.Txt_SalesAmount.TabIndex = 5;
            this.Txt_SalesAmount.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.BackColor = System.Drawing.Color.LightGreen;
            this.Btn_Submit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Submit.ForeColor = System.Drawing.Color.White;
            this.Btn_Submit.Location = new System.Drawing.Point(84, 285);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(130, 45);
            this.Btn_Submit.TabIndex = 6;
            this.Btn_Submit.Text = "SUBMIT";
            this.Btn_Submit.UseVisualStyleBackColor = false;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.BackColor = System.Drawing.Color.LightGray;
            this.Btn_Clear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Clear.ForeColor = System.Drawing.Color.White;
            this.Btn_Clear.Location = new System.Drawing.Point(304, 285);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(130, 45);
            this.Btn_Clear.TabIndex = 7;
            this.Btn_Clear.Text = "CLEAR";
            this.Btn_Clear.UseVisualStyleBackColor = false;
            // 
            // Btn_Print
            // 
            this.Btn_Print.BackColor = System.Drawing.Color.LightBlue;
            this.Btn_Print.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Print.ForeColor = System.Drawing.Color.White;
            this.Btn_Print.Location = new System.Drawing.Point(512, 285);
            this.Btn_Print.Name = "Btn_Print";
            this.Btn_Print.Size = new System.Drawing.Size(130, 45);
            this.Btn_Print.TabIndex = 8;
            this.Btn_Print.Text = "PRINT";
            this.Btn_Print.UseVisualStyleBackColor = false;
            // 
            // Lbl_Display
            // 
            this.Lbl_Display.BackColor = System.Drawing.Color.White;
            this.Lbl_Display.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lbl_Display.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Display.Location = new System.Drawing.Point(32, 347);
            this.Lbl_Display.Name = "Lbl_Display";
            this.Lbl_Display.Size = new System.Drawing.Size(780, 180);
            this.Lbl_Display.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 610);
            this.Controls.Add(this.Lbl_Display);
            this.Controls.Add(this.Btn_Print);
            this.Controls.Add(this.Btn_Clear);
            this.Controls.Add(this.Btn_Submit);
            this.Controls.Add(this.Txt_SalesAmount);
            this.Controls.Add(this.Txt_SalesInitial);
            this.Controls.Add(this.Lbl_Amount);
            this.Controls.Add(this.Lbl_Initial);
            this.Controls.Add(this.Lbl_Guide);
            this.Controls.Add(this.Lbl_Header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Sales Tracking Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Header;
        private System.Windows.Forms.Label Lbl_Guide;
        private System.Windows.Forms.Label Lbl_Initial;
        private System.Windows.Forms.Label Lbl_Amount;
        private System.Windows.Forms.TextBox Txt_SalesInitial;
        private System.Windows.Forms.TextBox Txt_SalesAmount;
        private System.Windows.Forms.Button Btn_Submit;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.Button Btn_Print;
        private System.Windows.Forms.Label Lbl_Display;
    }
}

