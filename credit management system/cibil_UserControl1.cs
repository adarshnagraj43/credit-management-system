﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace credit_management_system
{
    public partial class cibil_UserControl1 : UserControl
    {
        private static cibil_UserControl1 _instance;

        public static cibil_UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new cibil_UserControl1();
                }
                return _instance;
            }
        }
        public cibil_UserControl1()
        {
            InitializeComponent();
        }

        private void cibil_UserControl1_Load(object sender, EventArgs e)
        {

        }
    }
}