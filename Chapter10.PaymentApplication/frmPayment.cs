using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter10.PaymentApplication
{
    public partial class frmPayment : Form
    {
        private const string DEFAULT_CARD_NUMBER = "XXXX-XXXX-XXXX-XXXX";

        public frmPayment()
        {
            InitializeComponent();

            this.Shown += OnFormShown;
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            _lstBoxCreditCardTypes.SelectedIndex = 0;
            _comboBoxMonth.SelectedIndex = 0;
            _comboBoxYear.SelectedIndex = 0;
            _txtBoxCardNumber.Text = DEFAULT_CARD_NUMBER;
        }

        private void OnCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnTextBoxCardNumberMouseDown(object sender, MouseEventArgs e)
        {
            if(_txtBoxCardNumber.Text.Equals(DEFAULT_CARD_NUMBER))
            {
                _txtBoxCardNumber.Text = "";
            }
        }

        private void OnLeaveFocus(object sender, EventArgs e)
        {
            if(_txtBoxCardNumber.Text.Equals(""))
            {
                _txtBoxCardNumber.Text = DEFAULT_CARD_NUMBER;
            }
        }

        private void EnableCreditCardControls(bool enable)
        {
            _lstBoxCreditCardTypes.Enabled = enable;
            _txtBoxCardNumber.Enabled = enable;
            _comboBoxMonth.Enabled = _comboBoxYear.Enabled = enable;
            _lblCardNumber.Enabled = enable;
            _lblCreditCardType.Enabled = enable;
            _lblExpirationDate.Enabled = enable;
        }

        private void OnCreditCardCheckedChanged(object sender, EventArgs e)
        {
            if(_btnCreditCard.Checked)
            {
                EnableCreditCardControls(true);
            }
        }

        private void OnBillCustomerCheckedChanged(object sender, EventArgs e)
        {
            if(_btnBillCustomer.Checked)
            {
                EnableCreditCardControls(false);
            }
        }

        private void OnCreditCardNumberKeyDown(object sender, KeyEventArgs e)
        {
            if( e.KeyCode != Keys.D0 &&
                e.KeyCode != Keys.D1 &&
                e.KeyCode != Keys.D2 &&
                e.KeyCode != Keys.D3 &&
                e.KeyCode != Keys.D4 &&
                e.KeyCode != Keys.D5 &&
                e.KeyCode != Keys.D6 &&
                e.KeyCode != Keys.D7 &&
                e.KeyCode != Keys.D8 &&
                e.KeyCode != Keys.D9 &&
                e.KeyCode != Keys.Back)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void OnCreditCardNumberValidating(object sender, CancelEventArgs e)
        {
            if(_txtBoxCardNumber.Text.Length != 16)
            {
                e.Cancel = true;
            }
        }
    }
}
