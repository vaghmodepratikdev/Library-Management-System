using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public abstract class Media
    {
        public string title { get; set; }
        public string mediaType { get; set; }
        public int serialNumber { get; set; }
        public int lentTimes { get; set; }
        public bool isAvailable { get; set; }
        public string currentBorrowingMember { get; set; }

    }
}
