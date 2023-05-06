namespace PATPD.C9_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTripDest = new Label();
            lblMilesTravelled = new Label();
            lblGallonsUsed = new Label();
            txtBxTripDest = new TextBox();
            txtBxMilesTravelled = new TextBox();
            txtBxGallonsUsed = new TextBox();
            BtnCalculate = new Button();
            BtnReset = new Button();
            lblMPG = new Label();
            txtBxMPG = new TextBox();
            SuspendLayout();
            // 
            // lblTripDest
            // 
            lblTripDest.AutoSize = true;
            lblTripDest.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTripDest.ForeColor = Color.White;
            lblTripDest.Location = new Point(53, 45);
            lblTripDest.Name = "lblTripDest";
            lblTripDest.Size = new Size(171, 23);
            lblTripDest.TabIndex = 0;
            lblTripDest.Text = "Trip Destination:";
            // 
            // lblMilesTravelled
            // 
            lblMilesTravelled.AutoSize = true;
            lblMilesTravelled.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMilesTravelled.ForeColor = Color.White;
            lblMilesTravelled.Location = new Point(53, 98);
            lblMilesTravelled.Name = "lblMilesTravelled";
            lblMilesTravelled.Size = new Size(163, 23);
            lblMilesTravelled.TabIndex = 1;
            lblMilesTravelled.Text = "Miles Travelled:";
            // 
            // lblGallonsUsed
            // 
            lblGallonsUsed.AutoSize = true;
            lblGallonsUsed.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblGallonsUsed.ForeColor = Color.White;
            lblGallonsUsed.Location = new Point(53, 151);
            lblGallonsUsed.Name = "lblGallonsUsed";
            lblGallonsUsed.Size = new Size(208, 23);
            lblGallonsUsed.TabIndex = 2;
            lblGallonsUsed.Text = "Galons of Gas Used:";
            // 
            // txtBxTripDest
            // 
            txtBxTripDest.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxTripDest.Location = new Point(317, 48);
            txtBxTripDest.Name = "txtBxTripDest";
            txtBxTripDest.Size = new Size(125, 32);
            txtBxTripDest.TabIndex = 3;
            // 
            // txtBxMilesTravelled
            // 
            txtBxMilesTravelled.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMilesTravelled.Location = new Point(317, 98);
            txtBxMilesTravelled.Name = "txtBxMilesTravelled";
            txtBxMilesTravelled.Size = new Size(125, 32);
            txtBxMilesTravelled.TabIndex = 4;
            txtBxMilesTravelled.Text = "0";
            txtBxMilesTravelled.TextAlign = HorizontalAlignment.Right;
            // 
            // txtBxGallonsUsed
            // 
            txtBxGallonsUsed.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxGallonsUsed.Location = new Point(317, 147);
            txtBxGallonsUsed.Name = "txtBxGallonsUsed";
            txtBxGallonsUsed.Size = new Size(125, 32);
            txtBxGallonsUsed.TabIndex = 5;
            txtBxGallonsUsed.Text = "0";
            txtBxGallonsUsed.TextAlign = HorizontalAlignment.Right;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCalculate.Location = new Point(112, 217);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(123, 45);
            BtnCalculate.TabIndex = 6;
            BtnCalculate.Text = "Caculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // BtnReset
            // 
            BtnReset.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnReset.Location = new Point(276, 217);
            BtnReset.Name = "BtnReset";
            BtnReset.Size = new Size(123, 45);
            BtnReset.TabIndex = 7;
            BtnReset.Text = "Reset";
            BtnReset.UseVisualStyleBackColor = true;
            BtnReset.Click += BtnReset_Click;
            // 
            // lblMPG
            // 
            lblMPG.AutoSize = true;
            lblMPG.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblMPG.ForeColor = SystemColors.ButtonFace;
            lblMPG.Location = new Point(53, 317);
            lblMPG.Name = "lblMPG";
            lblMPG.Size = new Size(235, 23);
            lblMPG.TabIndex = 8;
            lblMPG.Text = "Miles per Gallon (mpg):";
            // 
            // txtBxMPG
            // 
            txtBxMPG.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBxMPG.Location = new Point(317, 313);
            txtBxMPG.Name = "txtBxMPG";
            txtBxMPG.Size = new Size(125, 32);
            txtBxMPG.TabIndex = 9;
            txtBxMPG.Text = "0";
            txtBxMPG.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Navy;
            ClientSize = new Size(468, 450);
            Controls.Add(txtBxMPG);
            Controls.Add(lblMPG);
            Controls.Add(BtnReset);
            Controls.Add(BtnCalculate);
            Controls.Add(txtBxGallonsUsed);
            Controls.Add(txtBxMilesTravelled);
            Controls.Add(txtBxTripDest);
            Controls.Add(lblGallonsUsed);
            Controls.Add(lblMilesTravelled);
            Controls.Add(lblTripDest);
            Name = "Form1";
            Text = "Trip calcuator Windows App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTripDest;
        private Label lblMilesTravelled;
        private Label lblGallonsUsed;
        private TextBox txtBxTripDest;
        private TextBox txtBxMilesTravelled;
        private TextBox txtBxGallonsUsed;
        private Button BtnCalculate;
        private Button BtnReset;
        private Label lblMPG;
        private TextBox txtBxMPG;
    }
}