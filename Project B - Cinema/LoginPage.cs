﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_B___Cinema
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.ShowDialog();
        }

        private void snacksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SnackPage sp = new SnackPage();
            sp.ShowDialog();
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContactPage cp = new ContactPage();
            cp.ShowDialog();
        }
    }
}