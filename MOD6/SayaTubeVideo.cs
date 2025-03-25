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
            if (string.IsNullOrEmpty(title) || title.Length > 200)
                throw new ArgumentException("Judul tidak boleh kosong dan maksimal 200 karakter.");
            Random rdm = new Random();
            this.id = rdm.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 25000000)
                throw new ArgumentOutOfRangeException("Jumlah play count harus antara 0 sampai dengan 25.000.000");
            if (playCount > int.MaxValue - count)
                throw new OverflowException("Jumlah playcount melebihi batas maksimum");
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
