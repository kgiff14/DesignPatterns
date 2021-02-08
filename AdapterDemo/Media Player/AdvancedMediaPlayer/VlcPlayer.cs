using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Media_Player.AdvancedMediaPlayer
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            //do nothing
        }

        public void playVlc(string fileName)
        {
            Console.WriteLine("Playing vlc file: " + fileName);
        }
    }
}
