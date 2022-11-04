using _6.het.Abstractions;
using _6.het.Entities;
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
        private List<Toy> _toys = new List<Toy>();
        private BallFactory _factory;
        public BallFactory IToyFactory
        {
            get { return _factory; }
            set { _factory = value; }
        }

        public Form1()
        {
            InitializeComponent();
            IToyFactory = new BallFactory();

        }

        private void CreateTimer_Tick(object sender, EventArgs e)
        {
            var ball = IToyFactory.CreateNew();
            _toys.Add(ball);
            ball.Left = -ball.Width;
            MainPanel.Controls.Add(ball);
        }

        private void ConveyorTimer_Tick(object sender, EventArgs e)
        {
            foreach (var ball in _toys)
            {
                var maxPosition = 0;
                ball.MoveToy();
                if (ball.Left>maxPosition)
                {
                    ball.MoveToy();
                    if (ball.Left > maxPosition)
                    {
                        maxPosition = ball.Left;
                    }
                    if (maxPosition>1000)
                    {
                        var oldestBall = _toys[0];
                        MainPanel.Controls.Remove(oldestBall);
                        _toys.Remove(oldestBall);
                    }
                }
            }
        }
    }
}

