using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeBreak
{
    class SnakePoint
    {
        private int _xValue;
        private int _yValue;

        /// <summary>
        /// Get und Set für das XValue
        /// </summary>
        public int xValue { get { return _xValue; } set { _xValue = value; } }

        /// <summary>
        /// Get und Set für das YValue
        /// </summary>
        public int yValue { get { return _yValue; } set { _yValue = value; } }


        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="xValue">x Ort (nullbasiert)</param>
        /// <param name="yValue">y Ort (nullbasiert)</param>
        public SnakePoint(int xValue, int yValue)
        {
            _xValue = xValue;
            _yValue = yValue;
        }

    }
}
