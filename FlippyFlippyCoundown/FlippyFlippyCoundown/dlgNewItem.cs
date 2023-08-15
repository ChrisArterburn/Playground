using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlippyFlippyCoundown
{
    public partial class dlgNewItem : Form
    {
        public dlgNewItem()
        {
            InitializeComponent();
            ValidateDialog();
        }

        public dlgNewItem(string eventName, DateTime eventDate)
            : this()
        {
            txtName.Text = eventName;
            dteSelectedDate.Value = eventDate;

            ValidateDialog();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length <= 0) return;
            if (dteSelectedDate.Value < DateTime.Now) return;

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            ValidateDialog();
        }

        private void dteSelectedDate_ValueChanged(object sender, EventArgs e)
        {
            ValidateDialog();

        }

        private void ValidateDialog()
        {
            if (txtName.Text.Length <= 0)
            {
                btnOK.Enabled = false;
                return;
            }

            if (dteSelectedDate.Value < DateTime.Now)
            {
                btnOK.Enabled = false;
                return;
            }


            btnOK.Enabled = true;

        }

        public string EventName => txtName.Text;
        public DateTime EventTime => dteSelectedDate.Value;
    }
}
