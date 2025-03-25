using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MOD6
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> UploadedVideos;
        public string Username;

        public SayaTubeUser(String Username)
        {
            if (string.IsNullOrEmpty(Username) || Username.Length > 100)
                throw new ArgumentException("Username tidak boleh kosong mapupun lebih dari 100 karakter");
            Random rdm = new Random();
            this.id = rdm.Next(10000, 99999);
            this.Username = Username;
            this.UploadedVideos = new List<SayaTubeVideo>();
        }

        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach(var video in UploadedVideos)
            {
                total += video.getPlayCount();
            }
            return total;
        }

        public void addVideo(SayaTubeVideo video)
        {
            if (video == null)
                throw new ArgumentNullException("Video tidak boleh kosong");
            UploadedVideos.Add(video);
        }

        public void printAllVideoPlaycount()
        {
            Console.WriteLine("User " + Username);
            for (int i = 0; i < UploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i+1} judul : {UploadedVideos[i].getTitle()}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            SayaTubeUser user = new SayaTubeUser("Steven");

            List<SayaTubeVideo> videos = new List<SayaTubeVideo>
            {
                new SayaTubeVideo("Tutorial coding java by Steven"),
                new SayaTubeVideo("Tutorial coding c# by Steven"),
                new SayaTubeVideo("Tutorial java Swing by Steven")
            };

            foreach (var video in videos)
            {
                user.addVideo(video);
            }
            videos[0].IncreasePlayCount(2100);
            videos[1].IncreasePlayCount(3500);
            videos[0].IncreasePlayCount(2230);

            foreach (var video in videos)
            {
                video.PrintVideoDetails();
                Console.WriteLine();
            }

            Console.WriteLine("Total pemutaran semua video adalah " + user.GetTotalVideoPlayCount());
            Console.WriteLine();
            user.printAllVideoPlaycount();
        }
    }
}
