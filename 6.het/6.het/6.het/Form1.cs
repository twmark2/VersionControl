﻿using _6.het.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6.het
{
    public partial class Form1 : Form
    {
        private List<Ball> balls = new List<Ball>();
        private BallFactory _factory;
        public BallFactory Factory
        {
            get { return _factory; }
            set { _factory = value; }
        }




        public Form1()
        {
            InitializeComponent();


        }
    }
}

