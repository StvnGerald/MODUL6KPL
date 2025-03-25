using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MOD6
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title) || title.Length > 100)
                throw new ArgumentException("Judul tidak boleh kosong dan maksimal 100 karakter.");
            Random rdm = new Random();
            this.id = rdm.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
                throw new ArgumentOutOfRangeException("Jumlah play count harus antara 0 sampai dengan 10.000.000");
            playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID VIDEO         : " + id);
            Console.WriteLine("Judul            : " + title);
            Console.WriteLine("Jumlah pemutaran : " + playCount);
        }

        public int getPlayCount()
        {
            return playCount;
        }

        public String getTitle()
        {
            return title;
        }
    }
}
