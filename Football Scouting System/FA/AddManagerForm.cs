﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Scouting_System.FA
{
    public partial class AddManagerForm : Form
    {
        AddStaffForm ParentForm_;
        public AddManagerForm(AddStaffForm _ParentForm_)
        {
            InitializeComponent();
            ParentForm_ = _ParentForm_;
        }

        private void AddManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ParentForm_.Show();
        }
    }
}