using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sicca.Persistence.Modelos;

namespace sicca.IntegrationTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var C = new Db())
            {
                Console.WriteLine(C.recboletas.Count());
            }
        }
    }
}
