using System;

namespace 抽象类的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 使用多态求圆形和矩形的面积和周长；
            //shape sh = new circle(5);
            //double area = sh.GetAres();
            //double per = sh.GetPerimeter();
            //Console.WriteLine("{0}     {1}", area, per);

            //电脑，优盘，移动硬盘，MP3；

            //MobileDisk md = new MobileDisk();
            //Udisk ud = new Udisk();
            //mp3 mp3 = new mp3();
            //computer com = new computer();
            //com.cpuReader(md);
            //com.cpuReader(md);
            //Console.ReadKey();

            //传参；
            //MobileStorage ms = new mp3();//new MobileDisk();//new Udisk();
            //computer cpu = new computer();
            //cpu.cpuReader(ms);
            //cpu.cpuReader(ms);

            //字段
            MobileStorage ms = new mp3();//new MobileDisk();//new Udisk();
            computer cpu = new computer();
            cpu.Ms = ms;
            cpu.cpuReader();
            cpu.cpuWrite();


            

        }
    }
    //public abstract class shape//父类
    // {
    //   public abstract double GetAres();//抽象方法
    //   public abstract double GetPerimeter();
    // }
    //public class circle : shape
    //{
    //    private double _r;
    //    public double R
    //    {
    //        get { return _r; }
    //        set { _r = value; }
    //    }
    //    public circle(double r)
    //    {
    //        this.R = r;
    //    }
    //    public override double GetAres()
    //    {
    //        return Math.PI * this.R * this.R;
    //    }
    //    public override double GetPerimeter()
    //    {
    //        return Math.PI * 2 * this.R;
    //    }
    //}
    //public class perimeter:shape
    //{
    //    private double _h;
    //    public double H
    //    {
    //        get { return _h; }
    //        set { _h = value; }
    //    }
    //    private double _a;
    //    public double A
    //    {
    //        get { return _a; }
    //        set { _a = value; }
    //    }
    //    public perimeter(double h, double a)
    //    {
    //        this.H = h;
    //        this.A = a;
    //    }
    //    public override double GetAres()
    //    {
    //        return this.H * this.A;
    //    }
    //    public override double GetPerimeter()
    //    {
    //            return 2 * (this.H + this.A);           
    //    }

      //}

    public abstract class MobileStorage
    {
        public abstract void  Write();
        public abstract void Reader();
    }
    public  class MobileDisk:MobileStorage
    {
        public override void Reader()
        {
            Console.WriteLine("移动硬盘的读");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘的写");
        }
    }
    public class mp3 : MobileStorage
    {
        public override void Reader()
        {
            Console.WriteLine("MP3的读");
        }
        public override void Write()
        {
            Console.WriteLine("MP3的xie");
        }
        public  void playMusic()
        {
            Console.WriteLine("mp3播放音乐");
        }
    }
    public class Udisk : MobileStorage
    {
        public override void Reader()
        {
            Console.WriteLine("U盘的读");
        }
        public override void Write()
        {
            Console.WriteLine("Up盘的xie");
        }
    }

    public class computer
    {
        //要拿到父类的元素，有两种方法，传参，字段
        private MobileStorage _ms;
        public MobileStorage Ms
        {
            get { return _ms; }
            set { _ms = value; }
        }

        public void cpuWrite(/*MobileStorage ms*/)
        {
            Ms.Write();
        }
        public void cpuReader(/*MobileStorage  ms*/)
        {
            Ms.Reader();
        }
    }


   
}
