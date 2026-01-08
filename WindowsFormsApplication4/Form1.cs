using SAPbobsCOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Company company = new Company();

            if (server.Text != "")
                company.Server = server.Text;

            company.UserName = user.Text;
            company.Password = pass.Text;
            company.CompanyDB = compDb.Text;
            company.DbServerType = BoDataServerTypes.dst_MSSQL2019;

            if (sld.Text != "")
                company.SLDServer = sld.Text;

            if (lisans.Text != "")
                company.LicenseServer = lisans.Text;

            var conn = company.Connect();

            if (company.Connected)
            {
                MessageBox.Show(company.CompanyName);
            }
            else
            {
                MessageBox.Show(company.GetLastErrorCode() + " " + company.GetLastErrorDescription());
            }
        }
    }
}
