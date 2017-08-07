namespace Chapter10.PaymentApplication
{
    partial class frmPayment
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
            this.grpBoxBilling = new System.Windows.Forms.GroupBox();
            this._btnBillCustomer = new System.Windows.Forms.RadioButton();
            this._btnCreditCard = new System.Windows.Forms.RadioButton();
            this._lblCreditCardType = new System.Windows.Forms.Label();
            this._lstBoxCreditCardTypes = new System.Windows.Forms.ListBox();
            this._lblCardNumber = new System.Windows.Forms.Label();
            this._txtBoxCardNumber = new System.Windows.Forms.TextBox();
            this._lblExpirationDate = new System.Windows.Forms.Label();
            this._comboBoxMonth = new System.Windows.Forms.ComboBox();
            this._comboBoxYear = new System.Windows.Forms.ComboBox();
            this._chkBoxDefaultBilling = new System.Windows.Forms.CheckBox();
            this._btnOK = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.grpBoxBilling.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxBilling
            // 
            this.grpBoxBilling.Controls.Add(this._btnBillCustomer);
            this.grpBoxBilling.Controls.Add(this._btnCreditCard);
            this.grpBoxBilling.Location = new System.Drawing.Point(13, 13);
            this.grpBoxBilling.Name = "grpBoxBilling";
            this.grpBoxBilling.Size = new System.Drawing.Size(520, 100);
            this.grpBoxBilling.TabIndex = 0;
            this.grpBoxBilling.TabStop = false;
            this.grpBoxBilling.Text = "Billing";
            // 
            // _btnBillCustomer
            // 
            this._btnBillCustomer.AutoSize = true;
            this._btnBillCustomer.Location = new System.Drawing.Point(322, 39);
            this._btnBillCustomer.Name = "_btnBillCustomer";
            this._btnBillCustomer.Size = new System.Drawing.Size(109, 21);
            this._btnBillCustomer.TabIndex = 1;
            this._btnBillCustomer.TabStop = true;
            this._btnBillCustomer.Text = "Bill customer";
            this._btnBillCustomer.UseVisualStyleBackColor = true;
            this._btnBillCustomer.CheckedChanged += new System.EventHandler(this.OnBillCustomerCheckedChanged);
            // 
            // _btnCreditCard
            // 
            this._btnCreditCard.AutoSize = true;
            this._btnCreditCard.Location = new System.Drawing.Point(45, 39);
            this._btnCreditCard.Name = "_btnCreditCard";
            this._btnCreditCard.Size = new System.Drawing.Size(100, 21);
            this._btnCreditCard.TabIndex = 0;
            this._btnCreditCard.TabStop = true;
            this._btnCreditCard.Text = "Credit Card";
            this._btnCreditCard.UseVisualStyleBackColor = true;
            this._btnCreditCard.CheckedChanged += new System.EventHandler(this.OnCreditCardCheckedChanged);
            // 
            // _lblCreditCardType
            // 
            this._lblCreditCardType.AutoSize = true;
            this._lblCreditCardType.Location = new System.Drawing.Point(10, 142);
            this._lblCreditCardType.Name = "_lblCreditCardType";
            this._lblCreditCardType.Size = new System.Drawing.Size(114, 17);
            this._lblCreditCardType.TabIndex = 1;
            this._lblCreditCardType.Text = "Credit Card type:";
            // 
            // _lstBoxCreditCardTypes
            // 
            this._lstBoxCreditCardTypes.FormattingEnabled = true;
            this._lstBoxCreditCardTypes.ItemHeight = 16;
            this._lstBoxCreditCardTypes.Items.AddRange(new object[] {
            "Visa",
            "Mastercard",
            "American Express"});
            this._lstBoxCreditCardTypes.Location = new System.Drawing.Point(147, 142);
            this._lstBoxCreditCardTypes.Name = "_lstBoxCreditCardTypes";
            this._lstBoxCreditCardTypes.Size = new System.Drawing.Size(353, 84);
            this._lstBoxCreditCardTypes.TabIndex = 2;
            // 
            // _lblCardNumber
            // 
            this._lblCardNumber.AutoSize = true;
            this._lblCardNumber.Location = new System.Drawing.Point(10, 272);
            this._lblCardNumber.Name = "_lblCardNumber";
            this._lblCardNumber.Size = new System.Drawing.Size(94, 17);
            this._lblCardNumber.TabIndex = 3;
            this._lblCardNumber.Text = "Card number:";
            // 
            // _txtBoxCardNumber
            // 
            this._txtBoxCardNumber.Location = new System.Drawing.Point(147, 269);
            this._txtBoxCardNumber.MaxLength = 16;
            this._txtBoxCardNumber.Name = "_txtBoxCardNumber";
            this._txtBoxCardNumber.Size = new System.Drawing.Size(353, 22);
            this._txtBoxCardNumber.TabIndex = 4;
            this._txtBoxCardNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnCreditCardNumberKeyDown);
            this._txtBoxCardNumber.Leave += new System.EventHandler(this.OnLeaveFocus);
            this._txtBoxCardNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnTextBoxCardNumberMouseDown);
            this._txtBoxCardNumber.Validating += new System.ComponentModel.CancelEventHandler(this.OnCreditCardNumberValidating);
            // 
            // _lblExpirationDate
            // 
            this._lblExpirationDate.AutoSize = true;
            this._lblExpirationDate.Location = new System.Drawing.Point(10, 340);
            this._lblExpirationDate.Name = "_lblExpirationDate";
            this._lblExpirationDate.Size = new System.Drawing.Size(108, 17);
            this._lblExpirationDate.TabIndex = 5;
            this._lblExpirationDate.Text = "Expiration Date:";
            // 
            // _comboBoxMonth
            // 
            this._comboBoxMonth.FormattingEnabled = true;
            this._comboBoxMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this._comboBoxMonth.Location = new System.Drawing.Point(147, 337);
            this._comboBoxMonth.Name = "_comboBoxMonth";
            this._comboBoxMonth.Size = new System.Drawing.Size(121, 24);
            this._comboBoxMonth.TabIndex = 6;
            // 
            // _comboBoxYear
            // 
            this._comboBoxYear.FormattingEnabled = true;
            this._comboBoxYear.Items.AddRange(new object[] {
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this._comboBoxYear.Location = new System.Drawing.Point(335, 335);
            this._comboBoxYear.Name = "_comboBoxYear";
            this._comboBoxYear.Size = new System.Drawing.Size(121, 24);
            this._comboBoxYear.TabIndex = 7;
            // 
            // _chkBoxDefaultBilling
            // 
            this._chkBoxDefaultBilling.AutoSize = true;
            this._chkBoxDefaultBilling.Location = new System.Drawing.Point(13, 395);
            this._chkBoxDefaultBilling.Name = "_chkBoxDefaultBilling";
            this._chkBoxDefaultBilling.Size = new System.Drawing.Size(208, 21);
            this._chkBoxDefaultBilling.TabIndex = 8;
            this._chkBoxDefaultBilling.Text = "Set as default billing method";
            this._chkBoxDefaultBilling.UseVisualStyleBackColor = true;
            // 
            // _btnOK
            // 
            this._btnOK.Location = new System.Drawing.Point(279, 443);
            this._btnOK.Name = "_btnOK";
            this._btnOK.Size = new System.Drawing.Size(97, 23);
            this._btnOK.TabIndex = 9;
            this._btnOK.Text = "OK";
            this._btnOK.UseVisualStyleBackColor = true;
            // 
            // _btnCancel
            // 
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(413, 443);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(93, 23);
            this._btnCancel.TabIndex = 10;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // frmPayment
            // 
            this.AcceptButton = this._btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(545, 498);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnOK);
            this.Controls.Add(this._chkBoxDefaultBilling);
            this.Controls.Add(this._comboBoxYear);
            this.Controls.Add(this._comboBoxMonth);
            this.Controls.Add(this._lblExpirationDate);
            this.Controls.Add(this._txtBoxCardNumber);
            this.Controls.Add(this._lblCardNumber);
            this.Controls.Add(this._lstBoxCreditCardTypes);
            this.Controls.Add(this._lblCreditCardType);
            this.Controls.Add(this.grpBoxBilling);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.grpBoxBilling.ResumeLayout(false);
            this.grpBoxBilling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxBilling;
        private System.Windows.Forms.RadioButton _btnBillCustomer;
        private System.Windows.Forms.RadioButton _btnCreditCard;
        private System.Windows.Forms.Label _lblCreditCardType;
        private System.Windows.Forms.ListBox _lstBoxCreditCardTypes;
        private System.Windows.Forms.Label _lblCardNumber;
        private System.Windows.Forms.TextBox _txtBoxCardNumber;
        private System.Windows.Forms.Label _lblExpirationDate;
        private System.Windows.Forms.ComboBox _comboBoxMonth;
        private System.Windows.Forms.ComboBox _comboBoxYear;
        private System.Windows.Forms.CheckBox _chkBoxDefaultBilling;
        private System.Windows.Forms.Button _btnOK;
        private System.Windows.Forms.Button _btnCancel;
    }
}

