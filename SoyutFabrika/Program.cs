using System;

namespace SoyutFabrika
{
    class Program
    {
        static void Main(string[] args)
        {
            SoyutFabrika icerik = new facebookApp();
            istemci a = new istemci(icerik);
            a.calistir();
            SoyutFabrika icerik1 = new instagramApp();
            istemci b = new istemci(icerik1);
            b.calistir();

            Console.ReadKey();
        }
    }
    abstract class SoyutFabrika
    {
        public abstract SoyutFotograf YayınlaFoto();
        public abstract SoyutVideo YayınlaVideo();

    }
    class instagramApp : SoyutFabrika
    {
        public override SoyutFotograf YayınlaFoto()
        {
            return new ifoto();
        }
        public override SoyutVideo YayınlaVideo()
        {
            return new ivideo();
        }
    }
    class facebookApp : SoyutFabrika
    {
        public override SoyutFotograf YayınlaFoto()
        {
            return new Foto();
        }
        public override SoyutVideo YayınlaVideo()
        {
            return new Video();
        }
    }
    abstract class SoyutFotograf
    {
        public abstract void yayinla(SoyutFotograf urun);
    }
    class ifoto : SoyutFotograf
    {
        public override void yayinla(SoyutFotograf urun)
        {
            Console.WriteLine(" www.instagram.com adresinde " + urun.GetType().Name + " paylaşıldı");
        }
    }
    abstract class SoyutVideo
    {
        public abstract void yayinla(SoyutVideo urun);
    }
    class ivideo : SoyutVideo
    {
        public override void yayinla(SoyutVideo urun)
        {
            Console.WriteLine(" www.instagram.com adresinde " + urun.GetType().Name + " paylaşıldı");
        }
    }
    class Foto : SoyutFotograf
    {
        public override void yayinla(SoyutFotograf urun)
        {
            Console.WriteLine(" www.facebook.com adresinde  " + urun.GetType().Name + " paylaşıldı");
        }
    }
    class Video : SoyutVideo
    {
        public override void yayinla(SoyutVideo urun)
        {
            Console.WriteLine("wwww.facebook.com adresinde " + urun.GetType().Name + " paylaşıldı");
        }
    }

    class istemci
    {
        private SoyutFotograf _soyutFoto;
        private SoyutVideo _soyutVideo;

        public istemci(SoyutFabrika fabrika)
        {
            _soyutFoto = fabrika.YayınlaFoto();
            _soyutVideo = fabrika.YayınlaVideo();
        }
        public void calistir()
        {
            _soyutVideo.yayinla(_soyutVideo);
            _soyutFoto.yayinla(_soyutFoto);
        }
    }
}
