using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Media_Player.AdvancedMediaPlayer
{
    public interface IAdvancedMediaPlayer
    {
        public void playVlc(string fileName);
        public void playMp4(string fileName);
    }
}
