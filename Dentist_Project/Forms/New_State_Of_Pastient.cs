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
    public partial class New_State_Of_Pastient : Form
    {
        PL.CLS_Add_New_Patient ob = new PL.CLS_Add_New_Patient(); // New Object from  Add New Patient State Class
        public New_State_Of_Pastient()
        {
            InitializeComponent();
        }

        private void Btn_CLose_New_State_form_Click(object sender, EventArgs e)
        {
            this.Close();
            Close();
        }

        private void New_State_Of_Pastient_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void Btn_Add_New_State_Form_Click_Click(object sender, EventArgs e)
        {


            ob.add_new_state(Txt_Box_New_State_Form.Text); // when we Klick on Add Buttom it Will Call add_new_state Function which is responsible to Insert New State data in the Database Table

            MessageBox.Show("The State has ben  Saved ", "Saving the State", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

