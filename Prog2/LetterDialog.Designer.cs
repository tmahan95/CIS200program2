namespace UPVApp
{
    partial class LetterDialog
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
            this.originAddrComBox = new System.Windows.Forms.ComboBox();
            this.destAddrComBox = new System.Windows.Forms.ComboBox();
            this.fixedCostTxtBox = new System.Windows.Forms.TextBox();
            this.originAddrLbl = new System.Windows.Forms.Label();
            this.destAddrLbl = new System.Windows.Forms.Label();
            this.fixedCostLbl = new System.Windows.Forms.Label();
            this.createLttrBttn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cnclBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // originAddrComBox
            // 
            this.originAddrComBox.DisplayMember = "Name";
            this.originAddrComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originAddrComBox.FormattingEnabled = true;
            this.originAddrComBox.Location = new System.Drawing.Point(221, 38);
            this.originAddrComBox.Name = "originAddrComBox";
            this.originAddrComBox.Size = new System.Drawing.Size(121, 28);
            this.originAddrComBox.TabIndex = 0;
            this.originAddrComBox.Validating += new System.ComponentModel.CancelEventHandler(this.originAddrComBox_Validating);
            this.originAddrComBox.Validated += new System.EventHandler(this.originAddrComBox_Validated);
            // 
            // destAddrComBox
            // 
            this.destAddrComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destAddrComBox.FormattingEnabled = true;
            this.destAddrComBox.Location = new System.Drawing.Point(221, 81);
            this.destAddrComBox.Name = "destAddrComBox";
            this.destAddrComBox.Size = new System.Drawing.Size(121, 28);
            this.destAddrComBox.TabIndex = 1;
            this.destAddrComBox.Validating += new System.ComponentModel.CancelEventHandler(this.destAddrComBox_Validating);
            this.destAddrComBox.Validated += new System.EventHandler(this.destAddrComBox_Validated);
            // 
            // fixedCostTxtBox
            // 
            this.fixedCostTxtBox.Location = new System.Drawing.Point(221, 128);
            this.fixedCostTxtBox.Name = "fixedCostTxtBox";
            this.fixedCostTxtBox.Size = new System.Drawing.Size(121, 26);
            this.fixedCostTxtBox.TabIndex = 2;
            this.fixedCostTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.fixedCostTxtBox_Validating);
            this.fixedCostTxtBox.Validated += new System.EventHandler(this.fixedCostTxtBox_Validated);
            // 
            // originAddrLbl
            // 
            this.originAddrLbl.AutoSize = true;
            this.originAddrLbl.Location = new System.Drawing.Point(61, 38);
            this.originAddrLbl.Name = "originAddrLbl";
            this.originAddrLbl.Size = new System.Drawing.Size(113, 20);
            this.originAddrLbl.TabIndex = 3;
            this.originAddrLbl.Text = "Origin Address";
            // 
            // destAddrLbl
            // 
            this.destAddrLbl.AutoSize = true;
            this.destAddrLbl.Location = new System.Drawing.Point(21, 81);
            this.destAddrLbl.Name = "destAddrLbl";
            this.destAddrLbl.Size = new System.Drawing.Size(153, 20);
            this.destAddrLbl.TabIndex = 4;
            this.destAddrLbl.Text = "Destination Address";
            // 
            // fixedCostLbl
            // 
            this.fixedCostLbl.AutoSize = true;
            this.fixedCostLbl.Location = new System.Drawing.Point(90, 128);
            this.fixedCostLbl.Name = "fixedCostLbl";
            this.fixedCostLbl.Size = new System.Drawing.Size(84, 20);
            this.fixedCostLbl.TabIndex = 5;
            this.fixedCostLbl.Text = "Fixed Cost";
            // 
            // createLttrBttn
            // 
            this.createLttrBttn.Location = new System.Drawing.Point(84, 181);
            this.createLttrBttn.Name = "createLttrBttn";
            this.createLttrBttn.Size = new System.Drawing.Size(90, 35);
            this.createLttrBttn.TabIndex = 6;
            this.createLttrBttn.Text = "Create Letter";
            this.createLttrBttn.UseVisualStyleBackColor = true;
            this.createLttrBttn.Click += new System.EventHandler(this.createLttrBttn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cnclBttn
            // 
            this.cnclBttn.Location = new System.Drawing.Point(205, 181);
            this.cnclBttn.Name = "cnclBttn";
            this.cnclBttn.Size = new System.Drawing.Size(90, 35);
            this.cnclBttn.TabIndex = 7;
            this.cnclBttn.Text = "Cancel";
            this.cnclBttn.UseVisualStyleBackColor = true;
            this.cnclBttn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cnclBttn_MouseDown);
            // 
            // LetterDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 228);
            this.Controls.Add(this.cnclBttn);
            this.Controls.Add(this.createLttrBttn);
            this.Controls.Add(this.fixedCostLbl);
            this.Controls.Add(this.destAddrLbl);
            this.Controls.Add(this.originAddrLbl);
            this.Controls.Add(this.fixedCostTxtBox);
            this.Controls.Add(this.destAddrComBox);
            this.Controls.Add(this.originAddrComBox);
            this.Name = "LetterDialog";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LetterDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox originAddrComBox;
        private System.Windows.Forms.ComboBox destAddrComBox;
        private System.Windows.Forms.TextBox fixedCostTxtBox;
        private System.Windows.Forms.Label originAddrLbl;
        private System.Windows.Forms.Label destAddrLbl;
        private System.Windows.Forms.Label fixedCostLbl;
        private System.Windows.Forms.Button createLttrBttn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cnclBttn;
    }
}