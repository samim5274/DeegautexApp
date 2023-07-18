using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deegautex
{
    class Manager
    {
        public List<TB_GenderInfo> GetGender()
        {
            var context = new DGTDBEntities();
            var q = from g in context.TB_GenderInfo select g;
            return q.ToList();
        }
    }
}
