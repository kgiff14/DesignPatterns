using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Media_Player
{
    public interface IMediaPlayer
    {
        public void Player(string fileType, string fileName);
    }
}
