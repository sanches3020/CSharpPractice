using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ModeController
    {
   
        private static ModeController _instance;

        private string _currentMode;

        private ModeController()
        {
            _currentMode = "обычный";
        }

        public static ModeController GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ModeController();
            }
            return _instance;
        }

        public void SetMode(string mode)
        {
            _currentMode = mode;
        }

        public string GetMode()
        {
            return _currentMode;
        }
    }
}