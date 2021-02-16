using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IdentityManager manager = new IdentityManager(new IdentityDal());
            
            Console.WriteLine(manager.GetById(1));
        }
    }
}
