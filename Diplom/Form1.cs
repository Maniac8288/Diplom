﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        AddStudent addStudent;

        private void button1_Click(object sender, EventArgs e)
        {
            addStudent = new AddStudent();
            addStudent.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}