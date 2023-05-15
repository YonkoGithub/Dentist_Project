using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dentist_Project.Forms
{
    public partial class Send_WhatsApp_Form : Form
    {

        private static Send_WhatsApp_Form n; // Creater deleg to Controll Form From Another form 

        static void Cf(object sender, FormClosedEventArgs e)
        {
            n = null;
        }

        public static Send_WhatsApp_Form deleg
        {
            get
            {

                if (n == null)
                {
                    n = new Send_WhatsApp_Form();
                }
                return n;
            }


        }




        public Send_WhatsApp_Form()
        {
            InitializeComponent();

            if (n == null)
            {
                n = this;
            }

        }

        private void Send_WhatsApp_Form_Load(object sender, EventArgs e)
        {

        }

        private void lbl_Message_Watsapp_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Cancel_WattsApp_Click(object sender, EventArgs e) // Cnacel WatasApp Button
        {
            DialogResult result = MessageBox.Show("Are you sure to Close the Program?", "Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }

        private void Btn_Send_WattsApp_Click(object sender, EventArgs e)
        {
            try

            {

                if (Txt_Box_tel_WattsApp.Text == "")

                {

                    MessageBox.Show("No number added");

                }

                if (Txt_Box_tel_WattsApp.Text.Length <= 10)

                {

                    MessageBox.Show("Germany Code added automatically");

                    Txt_Box_tel_WattsApp.Text = "+49" + Txt_Box_tel_WattsApp.Text;

                }

                Txt_Box_tel_WattsApp.Text = Txt_Box_tel_WattsApp.Text.Replace(" ", "");



                System.Diagnostics.Process.Start("http://api.whatsapp.com/send?phone=" + Txt_Box_tel_WattsApp.Text + "&text=" + Txt_Box_tel_WattsApp.Text);

            }

            catch (Exception ex)

            {

            }
           

           
        }

        private void Txt_Box_Name_WattsApp_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}

