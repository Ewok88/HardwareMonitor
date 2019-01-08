using System;
using System.IO;
using System.Windows.Forms;

namespace HardwareMonitor.Hardware
{
	class Checker
	{

        
        static public string name = @"log.txt";
        static public NotifyIcon icon;

        public string tipTitle = "Hardware Monitor";
        public string tipTextTemp = "Critical temperature";
        public string tipTextSpace = "Сritical amount of memory";
        public string tipTextRAM = "Critical amount of RAM";

        DateTime m_highTemperatureTime = DateTime.MinValue;
		DateTime m_lowDiskSpaceTime = DateTime.MinValue;
        DateTime m_lowRAMTime = DateTime.MinValue;


        public void CheckTemperature( int _currentTemp, int _criticalTemp )
		{
			if ( _currentTemp < _criticalTemp && m_highTemperatureTime == DateTime.MinValue )
				return;

			if ( _currentTemp > _criticalTemp )
			{
				if ( m_highTemperatureTime == DateTime.MinValue )
				{
					m_highTemperatureTime = DateTime.Now;

                    icon.BalloonTipTitle = tipTitle;
                    icon.BalloonTipText = tipTextTemp;
                    icon.Visible = true;
                    icon.BalloonTipIcon = ToolTipIcon.Warning;
                    icon.ShowBalloonTip(3);
                    icon.Visible = false;
                }
			}
			else
			{
                string logData =
                        "Critical Temperature from - "
                    + m_highTemperatureTime.ToString("dd-MM-yy: hh-mm-ss")
                    + " to - "
                    + DateTime.Now.ToString("dd-MM-yy: hh-mm-ss") + " was " + _currentTemp + " C";
				
				using ( StreamWriter sw = new StreamWriter(Path.Combine(AllSettings.folder, name), true, System.Text.Encoding.Default) )
					sw.WriteLine( logData );

				m_highTemperatureTime = DateTime.MinValue;
			}
		}


		public void CheckFreeSpace( int _currentFreeSpace, int _criticalFreeSpace )
		{
            if (_currentFreeSpace > _criticalFreeSpace && m_lowDiskSpaceTime == DateTime.MinValue)
                return;

            if (_currentFreeSpace < _criticalFreeSpace)
            {
                if (m_lowDiskSpaceTime == DateTime.MinValue)
                {
                    m_lowDiskSpaceTime = DateTime.Now;

                    icon.BalloonTipTitle = tipTitle;
                    icon.BalloonTipText = tipTextSpace;
                    icon.Visible = true;
                    icon.BalloonTipIcon = ToolTipIcon.Warning;
                    icon.ShowBalloonTip(3);
                    icon.Visible = false;
                }
            }
            else
            {
                string logData =
                        "Amount of memory from - "
                    + m_lowDiskSpaceTime.ToString("dd-MM-yy: hh-mm-ss")
                    + " to - "
                    + DateTime.Now.ToString("dd-MM-yy: hh-mm-ss") + " was " + _currentFreeSpace;

                using (StreamWriter sw = new StreamWriter(Path.Combine(AllSettings.folder, name), true, System.Text.Encoding.Default))
                    sw.WriteLine(logData);

                m_lowDiskSpaceTime = DateTime.MinValue;
            }


        }
        public void CheckFreeRAM(int _currentFreeRAM, int _criticalFreeRAM)
        {
            if (_currentFreeRAM > _criticalFreeRAM && m_lowRAMTime == DateTime.MinValue)
                return;

            if (_currentFreeRAM < _criticalFreeRAM)
            {
                if (m_lowRAMTime == DateTime.MinValue)
                {
                    m_lowRAMTime = DateTime.Now;

                    icon.BalloonTipTitle = tipTitle;
                    icon.BalloonTipText = tipTextRAM;
                    icon.Visible = true;
                    icon.BalloonTipIcon = ToolTipIcon.Warning;
                    icon.ShowBalloonTip(3);
                    icon.Visible = false;
                }
            }
            else
            {
                string logData =
                        "Amount of RAM from - "
                    + m_lowRAMTime.ToString("dd-MM-yy: hh-mm-ss")
                    + " to - "
                    + DateTime.Now.ToString("dd-MM-yy: hh-mm-ss") + " was " + _currentFreeRAM;

                using (StreamWriter sw = new StreamWriter(Path.Combine(AllSettings.folder, name), true, System.Text.Encoding.Default))
                    sw.WriteLine(logData);

                m_lowRAMTime = DateTime.MinValue;
            }
        }
    }
}
