using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ninjectioc.Repo
{
    public class BookEF : IBook
    {
        public string GetCoolTitle()
        {
            return "Cool Title Here!";
        }
    }
}