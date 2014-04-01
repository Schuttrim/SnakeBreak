using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeBreak
{
    class Direction
    {
        private char _Direction;

        /// <summary>
        /// Get Direction
        /// u = Up
        /// d = Down
        /// l = Left
        /// r = Right
        /// </summary>
        public char direction { get { return _Direction; } }

        /// <summary>
        /// Set Direction
        /// </summary>
        public bool Up { set { _Direction = 'u'; } }
        /// <summary>
        /// Set Direction
        /// </summary>
        public bool Down { set { _Direction = 'd'; } }
        /// <summary>
        /// Set Direction
        /// </summary>
        public bool Left { set { _Direction = 'l'; } }
        /// <summary>
        /// Set Direction
        /// </summary>
        public bool Right { set { _Direction = 'r'; } }

        /// <summary>
        /// Gibt zurück ob die Richtungsänderung zulässig ist.
        /// (Wechsel in Gegenrichtung nicht erlaubt)
        /// </summary>
        /// <param name="newDirection">Neue Richtung</param>
        /// <returns></returns>
        public bool IsValidChange(char newDirection)
        {
            bool returnvalue = true;

            switch (newDirection)
            {
                case 'u':
                    if (_Direction == 'd')
                        returnvalue = false;
                    break;
                case 'd':
                    if (_Direction == 'u')
                        returnvalue = false;
                    break;
                case 'l':
                    if (_Direction == 'r')
                        returnvalue = false;
                    break;
                case 'r':
                    if (_Direction == 'l')
                        returnvalue = false;
                    break;
            }

            return returnvalue;
        }
    }
}
