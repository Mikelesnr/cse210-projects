using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _vidsList = new List<Video>();

        // Create vid instances with updated details
        Video vid1 = new Video("Morning Coffee", "Emma Smith", "1:12:12");
        Video vid2 = new Video("Sunset Vibes", "Alex Turner", "1:30");
        Video vid3 = new Video("Chill Beats", "Sophia Lee", "57");

        // Add custom comments to vids
        vid1._comments.Add(new Comment("@Liam_Parker", "Perfect way to start the day!"));
        vid1._comments.Add(new Comment("@Olivia_Green", "Love the background music."));
        vid1._comments.Add(new Comment("@Scarlet _Tonomy", "I’m sipping coffee and nodding along."));
        vid2._comments.Add(new Comment("@James_Gun", "Magical sunset! 🌅"));
        vid2._comments.Add(new Comment("@Kevin_Feige", "This song makes me feel nostalgic."));
        vid2._comments.Add(new Comment("@Rocket_Racoon", "Perfect for winding down after a long day"));
        vid2._comments.Add(new Comment("@Groot", "I am Groot"));
        vid3._comments.Add(new Comment("@T'chala", "I could listen to this all day."));
        vid3._comments.Add(new Comment("@Steve_Roggers", "Great background music for work."));
        vid3._comments.Add(new Comment("@Haime_Reyas", "Groovy vibes! 🎶"));

        // Add vids to the list
        _vidsList.Add(vid1);
        _vidsList.Add(vid2);
        _vidsList.Add(vid3);

        Console.Clear();
        // Display updated vid details
        foreach (Video vid in _vidsList)
        {
            vid.DisplayVideoDetails();
            Console.WriteLine();
        }
    }
}
