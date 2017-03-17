using CheckToolSet.Check;
using CheckToolSet.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckToolSet
{
    public partial class CheckToolSetForm : Form
    {
        public CheckToolSetForm()
        {
            InitializeComponent();
        }

        private void comboBoxVerifyMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClculateCheck();
        }

        private void radioBtnHexMode_CheckedChanged(object sender, EventArgs e)
        {
            ClculateCheck();
        }

        private void radioBtnAsciiMode_CheckedChanged(object sender, EventArgs e)
        {
            ClculateCheck();
        }

        private void textBoxMainEdit_TextChanged(object sender, EventArgs e)
        {
            ClculateCheck();
        }

        private void ClculateCheck()
        {
            byte[] data;
            string str = textBoxMainEdit.Text;

            str.Replace(' ', '\0');

            if (radioBtnAsciiMode.Checked == false)
            {
                data = ConvertArray.AsciiToHex(str.ToArray());
            }
            else
            {
                data = ConvertArray.CharToByte(str.ToArray());
            }

            switch (comboBoxVerifyMode.SelectedIndex)
            {
                case 0:
                    textBoxResult.Text = SumCheck.GetCheck(data).ToString("X2");
                    break;
                case 1:
                    textBoxResult.Text = XorCheck.GetCheck(data).ToString("X2");
                    break;
                case 2:
                    textBoxResult.Text = LrcCheck.GetCheck(data).ToString("X2");
                    break;
                case 3:
                    textBoxResult.Text = "Not Implemented";
                    break;
                case 4:
                    textBoxResult.Text = "Not Implemented";
                    break;
                default:
                    textBoxResult.Text = "ERROR";
                    break;
            }
        }
    }
}
