using HackUtilTools.DTO;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using UtilCrackTools.Utils;

namespace UtilCrackTools
{
    public partial class MainForm : Form
    {
        ViewMatrixHelper.Corner selectedCorner = ViewMatrixHelper.Corner.LeftDown;

        public MainForm()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            lHeader.Text = $"{lHeader.Text} {assembly.GetName().Version}";

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
            else if (value > 100)
                tbRange.Text = "100";
        }

        private void btnInspect_Click(object sender, System.EventArgs e)
        {
            int screenWidth = int.Parse(tbScreenWidth.Text);
            int screenHeight = int.Parse(tbScreenHeight.Text);

            MatrixInspectionResult result = ViewMatrixHelper.InspectMatrix(screenWidth, screenHeight, tbMemoryArea.Text, tbVector.Text, int.Parse(tbRange.Text), selectedCorner);

            tbCorrectWindow.Text = result.CorrectWindow;

            tbResultNVDef1.Text = result.NvResultDef[0];
            tbResultNVDef2.Text = result.NvResultDef[1];

            tbResultNVTr1.Text = result.NvResultTr[0];
            tbResultNVTr2.Text = result.NvResultTr[1];

            tbResultNVNeares1.Text = result.NvResultNearest[0];
            tbResultNVNeares2.Text = result.NvResultNearest[1];

            switch (result.ResultType.Type)
            {
                case InspectResult.ResultType.Default:
                case InspectResult.ResultType.Transposed:
                    lResultType.ForeColor = Color.DarkGreen;
                    break;
                default:
                    lResultType.ForeColor = Color.Red;
                    break;
            }

            lResultType.Text = result.ResultType.Text;

            tbResult1.Text = result.Result[0];
            tbResult2.Text = result.Result[1];
            tbResult3.Text = result.Result[2];
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
            if (tbAddressDiff1.Text.Length >= 6 && tbAddressDiff2.Text.Length >= 6)
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

        private void DragWindow()
        {
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragPanel.Capture = false;
            DragWindow();
        }

        private void lHeader_MouseDown(object sender, MouseEventArgs e)
        {
            lHeader.Capture = false;
            DragWindow();
        }
    }
}
