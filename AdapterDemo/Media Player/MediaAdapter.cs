using AdapterDemo.Media_Player.AdvancedMediaPlayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterDemo.Media_Player
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer AdvancedMediaPlayer;

        public MediaAdapter(string audioType)
        {
            if (audioType.ToLower().Contains("vlc"))
            {
                AdvancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType.ToLower().Contains("mp4"))
            {
                AdvancedMediaPlayer = new Mp4Player();
            }
        }
        public void Player(string fileType, string fileName)
        {
            if (fileType.ToLower().Contains("vlc"))
            {
                AdvancedMediaPlayer.playVlc(fileName);
            }
            else if (fileType.ToLower().Contains("mp4"))
            {
                AdvancedMediaPlayer.playMp4(fileType);
            }
        }
    }
}
