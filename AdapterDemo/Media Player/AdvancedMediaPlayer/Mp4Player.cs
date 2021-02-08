using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Media_Player.AdvancedMediaPlayer
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public void playMp4(string fileName)
        {
            Console.WriteLine("Playing mp4 file: " + fileName);
        }

        public void playVlc(string fileName)
        {
            //do nothing
        }
    }
}
