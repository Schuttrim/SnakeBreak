using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SnakeBreak
{
    class Ranking
    {
        private string _Folder;

        public Ranking()
        {
            GetFolder();
        }

        public void LoadRanking() {
        }
        public void SaveRanking() {
        }

        private void GetFolder()
        {
            _Folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SnakeBreak\\Ranking");
            System.Windows.Forms.MessageBox.Show(_Folder);

            // Check if folder exists and if not, create it
            if (!Directory.Exists(_Folder))
                Directory.CreateDirectory(_Folder);
        }
    }
}
