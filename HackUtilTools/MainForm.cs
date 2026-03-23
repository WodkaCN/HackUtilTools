using System;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using UtilCrackTools.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UtilCrackTools
{
    public partial class MainForm : Form
    {
        ViewMatrixHelper.Corner selectedCorner = ViewMatrixHelper.Corner.LeftDown;

        public MainForm()
        {
            InitializeComponent();

            tbAddress.Focus();

            tbAddress.CharacterCasing = CharacterCasing.Upper;
            tbOffset.CharacterCasing = CharacterCasing.Upper;
            tbAddress.KeyPress += textBoxHex_KeyPress;
            cbOperator.SelectedIndex = 0;
            tbOffset.KeyPress += textBoxHex_KeyPress;

            tbAddressDiff1.CharacterCasing = CharacterCasing.Upper;
            tbAddressDiff2.CharacterCasing = CharacterCasing.Upper;
            tbAddressDiff1.KeyPress += textBoxHex_KeyPress;
            tbAddressDiff2.KeyPress += textBoxHex_KeyPress;

            tbScreenWidth.KeyPress += textBoxDigitsOnly_KeyPress;
            tbScreenWidth.KeyPress += textBoxDigitsOnly_KeyPress;
            tbRange.KeyPress += textBoxDigitsOnly_KeyPress;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addressTextBox1_TextChanged(object sender, System.EventArgs e)
        {
            CalculateAddress();
        }

        private void operatorComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            CalculateAddress();
        }

        private void offsetTextBox_TextChanged(object sender, System.EventArgs e)
        {
            CalculateAddress();
        }

        private void tbAddressDiff1_TextChanged(object sender, System.EventArgs e)
        { 
            CalculateOffset();
        }

        private void tbAddressDiff2_TextChanged(object sender, System.EventArgs e)
        {
            CalculateOffset();
        }

        private void btnLDCorner_Click(object sender, System.EventArgs e)
        {
            ChangeCornerButtonColors();

            selectedCorner = ViewMatrixHelper.Corner.LeftDown;
            btnLDCorner.BackColor = Color.LightBlue;
        }

        private void btnLUCorner_Click(object sender, System.EventArgs e)
        {
            ChangeCornerButtonColors();

            selectedCorner = ViewMatrixHelper.Corner.LeftUp;
            btnLUCorner.BackColor = Color.LightBlue;
        }

        private void btnRUCorner_Click(object sender, System.EventArgs e)
        {
            ChangeCornerButtonColors();

            selectedCorner = ViewMatrixHelper.Corner.RightUp;
            btnRUCorner.BackColor = Color.LightBlue;
        }

        private void btnRLCorner_Click(object sender, System.EventArgs e)
        {
            ChangeCornerButtonColors();

            selectedCorner = ViewMatrixHelper.Corner.RightDown;
            btnRDCorner.BackColor = Color.LightBlue;
        }

        private void tbRange_Leave(object sender, System.EventArgs e)
        {
            int.TryParse(tbRange.Text, out int value);

            if (value < 10)
                tbRange.Text = "10";
            else if (value > 50)
                tbRange.Text = "50";
        }

        private void btnInspect_Click(object sender, System.EventArgs e)
        {
            int screenWidth = int.Parse(tbScreenWidth.Text);
            int screenHeight = int.Parse(tbScreenHeight.Text);

            ViewMatrixHelper.InspectMatrix(screenWidth, screenHeight, tbMemoryArea.Text, tbVector.Text, int.Parse(tbRange.Text), selectedCorner,
                                           out string correctWindow, out string resultType, out string[] result, out string[] nvResultDef, out string[] nvResultTr, out string[] nvResultnearest);

            tbCorrectWindow.Text = correctWindow;

            tbResultNVDef1.Text = nvResultDef[0];
            tbResultNVDef2.Text = nvResultDef[1];

            tbResultNVTr1.Text = nvResultTr[0];
            tbResultNVTr2.Text = nvResultTr[1];

            tbResultNVNeares1.Text = nvResultnearest[0];
            tbResultNVNeares2.Text = nvResultnearest[1];

            if (result != null)
            {
                lResultType.ForeColor = Color.DarkGreen;
                lResultType.Text = resultType;

                tbResult1.Text = result[0];
                tbResult2.Text = result[1];
                tbResult3.Text = result[2];
            }
            else
            {
                lResultType.ForeColor = Color.Red;
                lResultType.Text = "Not Valid Values";
            }
        }

        private void textBoxHex_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Enter)
                return;

            if (char.IsControl(e.KeyChar))
                return;

            bool isHex = (e.KeyChar >= '0' && e.KeyChar <= '9') ||
                         (e.KeyChar >= 'A' && e.KeyChar <= 'F') ||
                         (e.KeyChar >= 'a' && e.KeyChar <= 'f');

            if (!isHex)
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void textBoxDigitsOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void CalculateAddress()
        {
            if (tbAddress.Text.Length >= 6 && tbOffset.Text.Length > 0)
            {
                AddressHelper.Operations operation;

                switch (cbOperator.SelectedIndex)
                {
                    case 0:
                        operation = AddressHelper.Operations.Add;
                        break;
                    case 1:
                        operation = AddressHelper.Operations.Subtract;
                        break;
                    default:
                        operation = AddressHelper.Operations.Add;
                        break;
                }

                tbAddressRes.Text = AddressHelper.CalculateAddress(tbAddress.Text, operation, tbOffset.Text);
            }
        }

        private void CalculateOffset()
        {
            if(tbAddressDiff1.Text.Length >= 6 && tbAddressDiff2.Text.Length >= 6)
            {
                tbOffsetDiff.Text = AddressHelper.CalculateOffset(tbAddressDiff1.Text, tbAddressDiff2.Text);
            }
        }

        private void ChangeCornerButtonColors()
        {
            btnLDCorner.BackColor = SystemColors.ControlDark;
            btnLUCorner.BackColor = SystemColors.ControlDark;
            btnRUCorner.BackColor = SystemColors.ControlDark;
            btnRDCorner.BackColor = SystemColors.ControlDark;
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragPanel.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
