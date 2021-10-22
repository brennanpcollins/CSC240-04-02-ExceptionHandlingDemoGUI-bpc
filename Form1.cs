using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC240_04_02_ExceptionHandlingDemoGUI_bpc
{
    public partial class ExceptionHandlingDemoGUI : Form
    {
        public ExceptionHandlingDemoGUI()
        {
            InitializeComponent();
        }

        private void UxFigureOutButton_Click(object sender, EventArgs e)
        {
            int integer;
            try
            {
                integer = Convert.ToInt32(UxTextBoxInput1.Text);
                UxOutputTextBox2.Text = "Yes, that is an integer";
                UxOutputTextBox2.Visible = true;
            }
            catch(Exception)
            {
                UxOutputTextBox2.Text = "Yeah, thats not an integer";
                UxOutputTextBox2.Visible = true;
            }
        }
    }
}
