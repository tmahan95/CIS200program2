namespace UPVApp
{
    partial class AddressDialog
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
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.addr1TxtBox = new System.Windows.Forms.TextBox();
            this.addr2TxtBox = new System.Windows.Forms.TextBox();
            this.cityTxtBox = new System.Windows.Forms.TextBox();
            this.zipTxtBox = new System.Windows.Forms.TextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addr1Lbl = new System.Windows.Forms.Label();
            this.addr2Lbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.stateComBox = new System.Windows.Forms.ComboBox();
            this.zipLbl = new System.Windows.Forms.Label();
            this.createAddrBttn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cnclBttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(145, 12);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(232, 26);
            this.nameTxtBox.TabIndex = 0;
            this.nameTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.nameTxtBox_Validating);
            this.nameTxtBox.Validated += new System.EventHandler(this.nameTxtBox_Validated);
            // 
            // addr1TxtBox
            // 
            this.addr1TxtBox.Location = new System.Drawing.Point(145, 56);
            this.addr1TxtBox.Name = "addr1TxtBox";
            this.addr1TxtBox.Size = new System.Drawing.Size(232, 26);
            this.addr1TxtBox.TabIndex = 1;
            this.addr1TxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.addr1TxtBox_Validating);
            this.addr1TxtBox.Validated += new System.EventHandler(this.addr1TxtBox_Validated);
            // 
            // addr2TxtBox
            // 
            this.addr2TxtBox.Location = new System.Drawing.Point(145, 100);
            this.addr2TxtBox.Name = "addr2TxtBox";
            this.addr2TxtBox.Size = new System.Drawing.Size(232, 26);
            this.addr2TxtBox.TabIndex = 2;
            // 
            // cityTxtBox
            // 
            this.cityTxtBox.Location = new System.Drawing.Point(145, 151);
            this.cityTxtBox.Name = "cityTxtBox";
            this.cityTxtBox.Size = new System.Drawing.Size(232, 26);
            this.cityTxtBox.TabIndex = 3;
            this.cityTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.cityTxtBox_Validating);
            this.cityTxtBox.Validated += new System.EventHandler(this.cityTxtBox_Validated);
            // 
            // zipTxtBox
            // 
            this.zipTxtBox.Location = new System.Drawing.Point(145, 251);
            this.zipTxtBox.Name = "zipTxtBox";
            this.zipTxtBox.Size = new System.Drawing.Size(232, 26);
            this.zipTxtBox.TabIndex = 5;
            this.zipTxtBox.Validating += new System.ComponentModel.CancelEventHandler(this.zipTxtBox_Validating);
            this.zipTxtBox.Validated += new System.EventHandler(this.zipTxtBox_Validated);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(45, 18);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(57, 20);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "*Name";
            // 
            // addr1Lbl
            // 
            this.addr1Lbl.AutoSize = true;
            this.addr1Lbl.Location = new System.Drawing.Point(19, 59);
            this.addr1Lbl.Name = "addr1Lbl";
            this.addr1Lbl.Size = new System.Drawing.Size(87, 20);
            this.addr1Lbl.TabIndex = 6;
            this.addr1Lbl.Text = "*Address 1";
            // 
            // addr2Lbl
            // 
            this.addr2Lbl.AutoSize = true;
            this.addr2Lbl.Location = new System.Drawing.Point(25, 106);
            this.addr2Lbl.Name = "addr2Lbl";
            this.addr2Lbl.Size = new System.Drawing.Size(81, 20);
            this.addr2Lbl.TabIndex = 7;
            this.addr2Lbl.Text = "Address 2";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(65, 157);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(41, 20);
            this.cityLbl.TabIndex = 8;
            this.cityLbl.Text = "*City";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(52, 197);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(54, 20);
            this.stateLbl.TabIndex = 9;
            this.stateLbl.Text = "*State";
            // 
            // stateComBox
            // 
            this.stateComBox.AllowDrop = true;
            this.stateComBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComBox.FormattingEnabled = true;
            this.stateComBox.Location = new System.Drawing.Point(145, 197);
            this.stateComBox.Name = "stateComBox";
            this.stateComBox.Size = new System.Drawing.Size(121, 28);
            this.stateComBox.TabIndex = 5;
            this.stateComBox.Validating += new System.ComponentModel.CancelEventHandler(this.stateComBox_Validating);
            this.stateComBox.Validated += new System.EventHandler(this.stateComBox_Validated);
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Location = new System.Drawing.Point(69, 254);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(37, 20);
            this.zipLbl.TabIndex = 11;
            this.zipLbl.Text = "*Zip";
            // 
            // createAddrBttn
            // 
            this.createAddrBttn.Location = new System.Drawing.Point(97, 300);
            this.createAddrBttn.Name = "createAddrBttn";
            this.createAddrBttn.Size = new System.Drawing.Size(87, 37);
            this.createAddrBttn.TabIndex = 6;
            this.createAddrBttn.Text = "OK";
            this.createAddrBttn.UseVisualStyleBackColor = true;
            this.createAddrBttn.Click += new System.EventHandler(this.createAddrBttn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cnclBttn
            // 
            this.cnclBttn.Location = new System.Drawing.Point(224, 300);
            this.cnclBttn.Name = "cnclBttn";
            this.cnclBttn.Size = new System.Drawing.Size(87, 37);
            this.cnclBttn.TabIndex = 12;
            this.cnclBttn.Text = "Cancel";
            this.cnclBttn.UseVisualStyleBackColor = true;
            this.cnclBttn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cnclBttn_MouseDown);
            // 
            // AddressDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 349);
            this.Controls.Add(this.cnclBttn);
            this.Controls.Add(this.createAddrBttn);
            this.Controls.Add(this.zipLbl);
            this.Controls.Add(this.stateComBox);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.addr2Lbl);
            this.Controls.Add(this.addr1Lbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.zipTxtBox);
            this.Controls.Add(this.cityTxtBox);
            this.Controls.Add(this.addr2TxtBox);
            this.Controls.Add(this.addr1TxtBox);
            this.Controls.Add(this.nameTxtBox);
            this.Name = "AddressDialog";
            this.Text = "AddressDialog";
            this.Load += new System.EventHandler(this.AddressDialog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.TextBox addr1TxtBox;
        private System.Windows.Forms.TextBox addr2TxtBox;
        private System.Windows.Forms.TextBox cityTxtBox;
        private System.Windows.Forms.TextBox zipTxtBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addr1Lbl;
        private System.Windows.Forms.Label addr2Lbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.ComboBox stateComBox;
        private System.Windows.Forms.Label zipLbl;
        private System.Windows.Forms.Button createAddrBttn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button cnclBttn;
    }
}