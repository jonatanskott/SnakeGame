﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Information : Form
    {
        mainForm mainFrm;
        public Information(mainForm frm)
        {
            InitializeComponent();
            mainFrm = frm;
        }

        private void Information_Load(object sender, EventArgs e)
        {
            Location = new Point(180, 250);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            mainFrm.PauseGame();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            mainFrm.ResetGame();
        }
    }
}
