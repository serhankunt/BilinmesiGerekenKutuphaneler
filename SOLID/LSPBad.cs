using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSPBad
{

    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı");
        }
        public abstract void TakePhone();

    }

    public class Iphone : BasePhone
    {
        public override void TakePhone()
        {
            Console.WriteLine("Fotoğraf çekildi");
        }
    }

    public class Nokia3310 : BasePhone
    {
        public override void TakePhone()
        {
            throw new NotImplementedException();
        }
    }
}
