using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Models.DataModels
{
    public class Purchase
    {
        public DateTime date = new DateTime();

        public int GoodId { get; set; }

        public int Amount { get; set; }

    }
}
