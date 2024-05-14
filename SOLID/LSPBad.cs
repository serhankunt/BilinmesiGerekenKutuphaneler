﻿using System;
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
        public abstract void TakePhoto();

    }

    public class Iphone : BasePhone
    {
        public override void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi");
        }
    }

    public class Nokia3310 : BasePhone
    {
        public override void TakePhoto()
        {
            throw new NotImplementedException();
        }
    }
}
