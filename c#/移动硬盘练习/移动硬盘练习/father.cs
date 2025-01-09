using System;
using System.Collections.Generic;
using System.Text;

namespace 移动硬盘练习
{
    public abstract class father
    {
        public abstract void read();
        public abstract void write();
    }
    public class upan : father
    {
        public override void read()
        {
            Console.WriteLine("u盘的读");
        }
        public override void write()
        {
            Console.WriteLine("upan的写");
        }
    }
    public class mp3 : father
    {
        public override void read()
        {
            Console.WriteLine("MP3的读");
        }
        public override void write()
        {
            Console.WriteLine("mp3的写");
        }
    }
    public class computer
    {
        public void cpuread( father fa)
        {
            fa.read();
        }
        public void cpuwrite(father fa)
        {
            fa.write();
        }
    }
}
