using System;
using System.Timers;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Post post1 = new Post(
                "Thanks for the birthday wishes",
                true,
                "Kevin Stapleton"
                );

            Console.WriteLine(post1.ToString());

            ImagePost imgPost = new ImagePost("Check out my gout", "Kevin Stapleton", "https://imaages.com/1312312", true);
            Console.WriteLine(imgPost.ToString());

            VideoPost vidPost = new VideoPost("Check out my big tow", "Kevin Stapleton", "https://videos.com/1312312", true, 5);
            Console.WriteLine(vidPost.ToString());
            vidPost.Play();
            Console.WriteLine("Press any key to stop the video");
            Console.ReadKey();
            vidPost.Stop();
        }
    }
}
