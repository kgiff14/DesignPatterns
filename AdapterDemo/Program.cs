using AdapterDemo.Media_Player;
using System;

namespace AdapterDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Player("mp3", "ayy baybee.mp3");
            audioPlayer.Player("vlc", "You know you wanna.vlc");
            audioPlayer.Player("mp4", "I think its time.mp4");
            audioPlayer.Player("avi", "Oh oh oh.avi");
        }
    }
}
