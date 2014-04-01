using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeBreak
{
    class Constants
    {
        /// <summary>
        /// Grösse eines Feldes FIELDSIZE : FIELDSIZE
        /// </summary>
        public const int FIELDSIZE = 10;

        /// <summary>
        /// Xachse anzahl Felder
        /// </summary>
        public const int XSIZE = 40;

        /// <summary>
        /// Yachse anzahl Felder
        /// </summary>
        public const int YSIZE = 40;

        /// <summary>
        /// Hintergrundfarbe für Standardfelder
        /// </summary>
        public static System.Drawing.Color BACKGOURNDCOLOR() { return System.Drawing.Color.Black; } 

        /// <summary>
        /// Hintergrundfarbe für Blocks
        /// </summary>
        public static System.Drawing.Color BLOCKCOLOR() { return System.Drawing.Color.LightGreen; }

        /// <summary>
        /// Hintergrundfarbe für Fruits
        /// </summary>
        public static System.Drawing.Color FRUITCOLOR() { return System.Drawing.Color.LightSteelBlue; } 

        /// <summary>
        /// Startpunkt für die Schlange
        /// </summary>
        public static SnakePoint STARTPOINT() { return new SnakePoint(20, 20);}

        /// <summary>
        /// Timer Intervall für Schlange
        /// </summary>
        public static int TIMERINTERVAL = 100;
    }
}
