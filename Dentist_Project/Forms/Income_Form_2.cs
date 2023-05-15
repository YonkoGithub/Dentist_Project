using DevExpress.XtraEditors;
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
    public partial class Income_Form_2 : DevExpress.XtraEditors.XtraForm
    {


        public void Show_Data()
        {
            var db = new DXL_LINQ.CLS_DXL_IINQDataContext();
            var data = from p in db.Table_Patients
                       select new
                       {
                           p.Patient_name,
                           p.Patient_tc,
                           p.Patient_date,
                           p.paied,
                           p.remind,

                           Details = db.Table_Patients.Where(x => x.Patient_id == p.Patient_id).ToList(),
                       };
            gridControl1.DataSource = data;
        }



        public Income_Form_2()
        {
            InitializeComponent();

            Show_Data();



        }


        protected override CreateParams CreateParams
        {

            get
            {
                CreateParams handleparam = base.CreateParams;
                handleparam.ExStyle |= 0x02000000;
                return handleparam;
            }
        }



        private void Btn_Toatal_Paid_Click_1(object sender, EventArgs e)
        {
            var db = new DXL_LINQ.CLS_DXL_IINQDataContext();

            var data = from p in db.Table_Patients
                       select new
                       {
                           p.paied,
                       };

            double sum = 0;

            dataGridView1.DataSource = data;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum = sum + (double)dataGridView1.Rows[i].Cells["paied"].Value;
            }

            Lbl_Income_Form.Text = "Total Paid : " + sum.ToString() + "$";
        }

        private void btn_Toatal_Remind_Click_1(object sender, EventArgs e)
        {
            var db = new DXL_LINQ.CLS_DXL_IINQDataContext();

            var data = from p in db.Table_Patients
                       select new
                       {
                           p.remind,
                       };

            double sum = 0;

            dataGridView1.DataSource = data;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                sum = sum + (double)dataGridView1.Rows[i].Cells["remind"].Value;
            }

            Lbl_Income_Form.Text = "Total Remind : " + sum.ToString() + "$";
        }

        private void Home_Click_1(object sender, EventArgs e)
        {
            Home_2_Form f = new Home_2_Form();
            this.Hide();
            f.ShowDialog();
        }
    }
}