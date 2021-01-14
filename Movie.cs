using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Movie : Media
    {
        int runTime { get; set; }
        public Movie(string title, string mediaType, int lentTimes,
            bool isAvailable, string currentBorrowingMember)
        {
            this.title = title;
            this.mediaType = mediaType;
            this.lentTimes = lentTimes;
            this.isAvailable = isAvailable;
            this.currentBorrowingMember = currentBorrowingMember;
        }
    }
}
