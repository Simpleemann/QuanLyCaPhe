﻿using QLCF.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCF
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();

            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery("exec dbo.USP_GetAccountByUserName @username", new object[]{"' or 1=1--"});
        }

        private void tpFoodCategory_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}