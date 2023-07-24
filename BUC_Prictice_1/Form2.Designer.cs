
namespace BUC_Prictice_1
{
    partial class frmTwo
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
            this.rdbCt = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.rdnCs = new System.Windows.Forms.RadioButton();
            this.btnChoose = new System.Windows.Forms.Button();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.cbBox = new System.Windows.Forms.ComboBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rdbCt
            // 
            this.rdbCt.AutoSize = true;
            this.rdbCt.Location = new System.Drawing.Point(344, 129);
            this.rdbCt.Name = "rdbCt";
            this.rdbCt.Size = new System.Drawing.Size(149, 17);
            this.rdbCt.TabIndex = 1;
            this.rdbCt.TabStop = true;
            this.rdbCt.Text = "Computer Technology(CT)";
            this.rdbCt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose One :";
            // 
            // rdnCs
            // 
            this.rdnCs.AutoSize = true;
            this.rdnCs.Location = new System.Drawing.Point(344, 96);
            this.rdnCs.Name = "rdnCs";
            this.rdnCs.Size = new System.Drawing.Size(132, 17);
            this.rdnCs.TabIndex = 3;
            this.rdnCs.TabStop = true;
            this.rdnCs.Text = "Computer Science(CS)";
            this.rdnCs.UseVisualStyleBackColor = true;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(335, 212);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(75, 23);
            this.btnChoose.TabIndex = 4;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(210, 170);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 5;
            // 
            // cbBox
            // 
            this.cbBox.FormattingEnabled = true;
            this.cbBox.Items.AddRange(new object[] {
            "UCSY",
            "UCSTgi",
            "UCSM"});
            this.cbBox.Location = new System.Drawing.Point(431, 169);
            this.cbBox.Name = "cbBox";
            this.cbBox.Size = new System.Drawing.Size(121, 21);
            this.cbBox.TabIndex = 6;
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(431, 212);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // frmTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.cbBox);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.rdnCs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdbCt);
            this.Name = "frmTwo";
            this.Text = "Page 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdbCt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdnCs;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.ComboBox cbBox;
        private System.Windows.Forms.Button btnContinue;
    }
}