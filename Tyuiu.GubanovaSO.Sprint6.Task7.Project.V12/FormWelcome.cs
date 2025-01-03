﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.GubanovaSO.Sprint6.Task7.Project.V12
{
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }
        private void buttonNext_GSO_Click(object sender, EventArgs e)
        {
            FormMain mainForm = new FormMain();
            this.Hide();
            mainForm.ShowDialog();
            this.Close();
        }
        private void buttonInfo_GSO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //
        }
    }
}
