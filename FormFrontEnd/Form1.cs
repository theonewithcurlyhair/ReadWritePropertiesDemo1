using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormFrontEnd
{
    public partial class Form1 : Form
    {
        Balloon myFirstBallon;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            try
            {
                //Chris must instanciate his object
                myFirstBallon = new Balloon()
                {
                    Color = txtColor.Text.Trim(),
                    Diameter = Convert.ToDecimal(txtDiameter.Text.Trim()),
                    Height = Convert.ToDecimal(txtHeight.Text.Trim())

                };

                //myFirstBallon.Color = txtColor.Text.Trim();
                //myFirstBallon.Height = Convert.ToDecimal(txtHeight.Text.Trim());
                //myFirstBallon.Diameter = Convert.ToDecimal(txtDiameter.Text.Trim());
            }
            catch(ConstraintException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch(DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString(), MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            lblOutput.Text = $"Color: {myFirstBallon.Color} \n Height: {myFirstBallon.Height} \n Diameter: {myFirstBallon.Diameter}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
