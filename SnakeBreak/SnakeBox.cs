using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeBreak
{
    class SnakeBox
    {
        private bool _Fruit;
        private bool _CanEnter;
            
        /// <summary>
        /// Ob sich eine Frucht auf dem Feld befindet
        /// </summary>
        public bool Fruit { get { return _Fruit; } set { _Fruit = value; } }

        /// <summary>
        /// Ob das Feld betreten werden kann (Schlangenkörper / Mauer)
        /// </summary>
        public bool CanEnter { get { return _CanEnter; } set { _CanEnter = value; } }


        /// <summary>
        /// Standardkonstruktor für Snakebox
        /// Alles wird false gesetzt
        /// </summary>
        public SnakeBox()
        {
            _Fruit = false;
            _CanEnter = false;
        }

        /// <summary>
        /// Konstruktor für Snakebox mit Parametern
        /// </summary>
        /// <param name="fruit">Ob im Feld eine Frucht ist</param>
        /// <param name="canEnter">Ob Feld betretbar ist</param>
        public SnakeBox(bool fruit, bool canEnter)
        {
            _Fruit = fruit;
            _CanEnter = canEnter;
        }
    }
}
