using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Media_Player
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter MediaAdapter;
        public void Player(string fileType, string fileName)
        {
            if (fileType.ToLower().Contains("mp3"))
            {
                Console.WriteLine("Playing mp3 file: " + fileName);
            }
            else if(fileType.ToLower().Contains("vlc") || fileType.ToLower().Contains("mp4"))
            {
                MediaAdapter = new MediaAdapter(fileType);
                MediaAdapter.Player(fileType, fileName);
            }
            else
            {
                Console.WriteLine("Media type " + fileType +  " is not supported");
            }
        }
    }
}
