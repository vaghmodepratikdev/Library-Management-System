using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Magazine : Book
    {
        public int issueNumber { get; set; }

        public Magazine(string title, string mediaType, int lentTimes,
            bool isAvailable,string currentBorrowingMember) : 
            base(title, mediaType, lentTimes, isAvailable, currentBorrowingMember)
        {
            this.title = title;
            this.mediaType = mediaType;
            this.lentTimes = lentTimes;
            this.isAvailable = isAvailable;
            this.currentBorrowingMember = currentBorrowingMember;
        }
    }
}
