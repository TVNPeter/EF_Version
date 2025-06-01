using EF_Version.DataSet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Version.Reports
{
    public partial class frmViewPreDetail : Form
    {
        int Id = 0;
        public frmViewPreDetail()
        {
            InitializeComponent();
        }
        public frmViewPreDetail(int id)
        {
            InitializeComponent();
            Id = id;
        }

        private void frmViewPreDetail_Load(object sender, EventArgs e)
        {
            // Fix: Pass the correct type (DataForPrescriptionDetailDataTable) to the Fill method.
            var dataTable = new DataForPrescription.DataForPrescriptionDetailDataTable();
            this.dataForPrescriptionDetailTableAdapter.Fill(dataTable, 1);

            this.reportViewer1.RefreshReport();
        }
    }
}
