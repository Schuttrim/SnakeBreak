using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeBreak
{
    class Snake
    {
        private List<SnakePoint> _List;
        private PictureBox[,] _BoxField;
        private Direction _Direction;
        private Timer _Timer;
        private bool _HasFruit;
        private Random _Random;
        private Panel _Panel;
        private Ranking _Ranking;

        public bool Running { get { return _Timer.Enabled; } }

        #region Constructor

        /// <summary>
        /// Erzeugt neues Snake Objekt
        /// </summary>
        /// <param name="boxField">Picturebox Feld auf welchem sich die Schlange bewegt</param>
        /// <param name="panel">Panel auf welchem sich das Snake befindet</param>
        public Snake(PictureBox[,] boxField, Panel panel)
        {
            _BoxField = boxField;
            _Panel = panel;
            ResetAll();
        }

        #endregion Constructor

        #region Functions

        #region public

        /// <summary>
        /// Starts Snake Game
        /// </summary>
        public void StartSnake()
        {
            _Timer.Start();
        }

        public void PauseSnake()
        {
            _Timer.Stop();
        }

        /// <summary>
        /// Ändert die Fortbewegungsrichtung der Schlange
        /// </summary>
        /// <param name="direction"></param>
        public void ChangeDirection(char direction)
        {
            if (new char[] { 'u', 'd', 'l', 'r' }.Contains(direction))
            {
                if(_Direction.IsValidChange(direction))
                {
                    switch (direction)
                    {
                        case 'u':
                            _Direction.Up = true;
                            break;
                        case 'd':
                            _Direction.Down = true;
                            break;
                        case 'l':
                            _Direction.Left = true;
                            break;
                        case 'r':
                            _Direction.Right = true;
                            break;
                    }
                }
            }
        }

        #endregion public

        #region private

        private void InitializeField()
        {
            _Panel.Controls.Clear();

            _BoxField = new PictureBox[Constants.XSIZE, Constants.YSIZE];

            for (int yAchse = 0; yAchse < Constants.YSIZE; yAchse++)
            {
                for (int xAchse = 0; xAchse < Constants.XSIZE; xAchse++)
                {
                    _BoxField[xAchse, yAchse] = new System.Windows.Forms.PictureBox();
                    ((System.ComponentModel.ISupportInitialize)(_BoxField[xAchse, yAchse])).BeginInit();

                    _BoxField[xAchse, yAchse].BackColor = Constants.BACKGOURNDCOLOR();
                    _BoxField[xAchse, yAchse].Location = new System.Drawing.Point(xAchse * Constants.FIELDSIZE, yAchse * Constants.FIELDSIZE);
                    _BoxField[xAchse, yAchse].Name = "SnakeField_" + (xAchse.ToString() + 1) + "_" + (yAchse.ToString() + 1);
                    _BoxField[xAchse, yAchse].Size = new System.Drawing.Size(Constants.FIELDSIZE, Constants.FIELDSIZE);
                    _BoxField[xAchse, yAchse].TabIndex = 0;
                    _BoxField[xAchse, yAchse].TabStop = false;
                    _BoxField[xAchse, yAchse].Tag = new SnakeBox(false, true);

                    _Panel.Controls.Add(_BoxField[xAchse, yAchse]);
                }
            }

        }

        private void TimerTick(object sender, EventArgs e)
        {
            if (!_HasFruit)
                FruitGenerate();
            Forward();
        }

        private void FruitGenerate()
        {
            _HasFruit = true;
            PictureBox pb = _BoxField[_Random.Next(0, Constants.XSIZE), _Random.Next(0, Constants.XSIZE)];
            ((SnakeBox)pb.Tag).Fruit = true;
            pb.BackColor = Constants.FRUITCOLOR();
        }

        /// <summary>
        /// Die Schlange rückt einen Punkt in richtung Direction vor
        /// </summary>
        private void Forward()
        {
            // Kollisionstest
            SnakePoint nextPoint = NextPoint();
            if (((SnakeBox)_BoxField[nextPoint.xValue, nextPoint.yValue].Tag).CanEnter)
            {
                // Schlange bewegen 
                if (((SnakeBox)_BoxField[nextPoint.xValue, nextPoint.yValue].Tag).Fruit)
                {
                    // Wenn Frucht auf nächstem Feld Schlange erweitern
                    _List.Add(null);
                    _HasFruit = false;
                    ((SnakeBox)_BoxField[nextPoint.xValue, nextPoint.yValue].Tag).Fruit = false;
                }
                else
                {
                    // Letztes Löschen
                    PictureBox pb = (_BoxField[(_List[_List.Count - 1]).xValue, (_List[_List.Count - 1]).yValue]);
                    pb.BackColor = Constants.BACKGOURNDCOLOR();
                    ((SnakeBox)pb.Tag).CanEnter = true;
                }

                // Nachrutschen
                for (int i = _List.Count - 1; i > 0; i--)
                {
                    _List[i] = _List[i - 1];
                }

                // Neues Feld wieder auf Platz 1
                _List[0] = nextPoint;

                // Neuer Kopfpunkt der Schlange Einfärben
                PictureBox pb1 = _BoxField[_List[0].xValue, _List[0].yValue];
                pb1.BackColor = Constants.BLOCKCOLOR();
                ((SnakeBox)pb1.Tag).CanEnter = false;
            }
            else
            {
                // Kollision !
                PauseSnake();
                MessageBox.Show("Ihre Schlange war " + _List.Count.ToString() + " lang.\n Das Spiel wird neu gestartet.", "Gratuliere", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetAll();
            }
        }

        /// <summary>
        /// Gibt nächster Punkt zurück
        /// </summary>
        /// <returns>Nächster Punkt</returns>
        private SnakePoint NextPoint()
        {
            // Kopie des Kopfes der Schlange
            SnakePoint point = new SnakePoint(_List[0].xValue, _List[0].yValue);

            // Verschieben in Richtung direction
            switch (_Direction.direction)
            {
                case 'u':
                    point.yValue--;
                    break;
                case 'd':
                    point.yValue++;
                    break;
                case 'l':
                    point.xValue--;
                    break;
                case 'r':
                    point.xValue++;
                    break;
            }

            if (point.yValue >= Constants.YSIZE)
            {
                point.yValue = 0;
            }
            else if(point.yValue < 0)
            {
                point.yValue = Constants.YSIZE - 1;
            }

            if (point.xValue >= Constants.XSIZE)
            {
                point.xValue = 0;
            }
            else if (point.xValue < 0)
            {
                point.xValue = Constants.XSIZE - 1;
            }

            return point;
        }
        /// <summary>
        /// Resets all Variables and Fields
        /// </summary>
        private void ResetAll()
        {
            // Initialisations
            _List = new List<SnakePoint>();
            _Direction = new Direction();
            _Random = new Random();
            _Ranking = new Ranking();
            InitializeField();


            // Timer
            _Timer = new Timer();
            _Timer.Interval = Constants.TIMERINTERVAL;
            _Timer.Tick += new EventHandler(TimerTick);
            _Timer.Enabled = true;
            _Timer.Stop();

            // Startvalues
            _HasFruit = false;
            _Direction.Up = true;

            SnakePoint point = Constants.STARTPOINT();
            point.yValue = point.yValue + 1;
            _List.Add(point);

            point = Constants.STARTPOINT();
            point.yValue = point.yValue + 2;
            _List.Add(point);

            point = Constants.STARTPOINT();
            point.yValue = point.yValue + 3;
            _List.Add(point);
        }
    }
        #endregion private
}
        #endregion Functions
