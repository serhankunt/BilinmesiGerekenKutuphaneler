namespace SOLID.LSPGood
{
    public interface ITakePhoto
    {
        void TakePhoto();
    }
    public abstract class BasePhone
    {
        public void Call()
        {
            Console.WriteLine("Arama yapıldı");
        }
        

    }

    public class Iphone : BasePhone,ITakePhoto
    {
      public void TakePhoto()
        {
            Console.WriteLine("Fotoğraf çekildi.");
        }
    }

    public class Nokia3310 : BasePhone
    {
        
    }
}
