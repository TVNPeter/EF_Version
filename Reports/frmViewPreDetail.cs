﻿using System;
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
        int ID = 0;
        public frmViewPreDetail()
        {
            InitializeComponent();
        }
        public frmViewPreDetail(int id)
        {
            InitializeComponent();
            ID = id;
        }

        private void frmViewPreDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.DataForPrescriptionDetail' table. You can move, or remove it, as needed.
            this.dataForPrescriptionDetailTableAdapter.Fill(this.dataSet1.DataForPrescriptionDetail, ID);

            this.reportViewer1.RefreshReport();
        }
    }
}
