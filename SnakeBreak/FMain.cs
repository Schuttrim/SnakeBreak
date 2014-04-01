using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeBreak
{
    public partial class FMain : Form
    {
        private PictureBox[,] _Field;
        private Snake _Snake;

        public FMain()
        {
            InitializeComponent();
            _Snake = new Snake(_Field, _pnlSnake);
            _Snake.StartSnake();
        }
        private void FMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case 'a':
                    _Snake.ChangeDirection('l');
                    break;
                case 's':
                    _Snake.ChangeDirection('d');
                    break;
                case 'd':
                    _Snake.ChangeDirection('r');
                    break;
                case 'w':
                    _Snake.ChangeDirection('u');
                    break;
                case ' ':
                    if (_Snake.Running)
                    {
                        _Snake.PauseSnake();
                    }
                    else
                    {
                        _Snake.StartSnake();
                    }
                    break;
            }
        }

        private void _tsmiShowRankings_Click(object sender, EventArgs e)
        {
            FRankings rankings = new FRankings();
            rankings.ShowDialog();
        }

    }
}
