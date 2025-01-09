using System;

namespace 字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {


            //字符串的倒叙输出；；；                     
            //Console.WriteLine("请输入一组字母");
            //string str = Console.ReadLine();
            //char[] chr = str.ToCharArray();//把字符串转化为一个数组；
            //for (int i = 0; i < str.Length/2; i++)
            //{
            //    char temp = chr[i];
            //    chr[i] = chr[str.Length - i - 1];
            //    chr[str.Length - i - 1] = temp;
            //}
            //str = new string(chr);
            //Console.WriteLine(str);
            //倒叙循环
            //for (int i = str.Length-1; i >=0; i--)  
            //{
            //    Console.Write(str[i]);
            //}

            // 把hello world输出 world hello                       
            //Console.WriteLine("请输入一组字母");
            //string str = Console.ReadLine();
            //string[] strNew= str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length/2; i++)
            //{
            //    string temp = strNew[i];
            //    strNew[i] = strNew[strNew.Length - i - 1];
            //    strNew[strNew.Length - i - 1] = temp;
            //}
            //str=string.Join(' ', strNew);
            //Console.WriteLine(str);
            //for (int i = 0; i < strNew.Length; i++)
            //{
            //    Console.WriteLine(strNew[i]);
            //}



            //从邮箱中提取用户名和域名；abc@163.com                       
            //Console.WriteLine("请输入一组字母");
            //string str = Console.ReadLine();
            //int index=str.IndexOf("@"); //Indexof（）； 判断某个字符串在字符串中第一次出现的位置，如果没有，就返回 - 1
           
            //string name=str.Substring(0, index);//Substring();  截取字符串，在截取的时候包含要截取的那个位置；
            
            //string yuMing = str.Substring(index+1);
            //Console.WriteLine(name);
            //Console.WriteLine(yuMing);




            //让用书输入一句话，找出所有e的位置；           
            //string str = "ejdknfjekdmnfhelmdnreemde";
            //for (int i = 0; i < str.Length; i++)
            //{
            //    if (str[i] == 'e')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //int index=str.IndexOf("e");
            //Console.WriteLine("第一次出现e的位置是{0}", index+1); 
            //int i = 2;
            //while (index != -1)
            //{
            //    index=str.IndexOf("e", index + 1);

            //    i++;
            //    Console.WriteLine("第{0}次出现e的位置是{1}", i, index);
            //}


            //string str = "老张很厉害";
            //if (str.Contains("厉害"))
            //{
            //   str= str.Replace("厉害", "**");
            //}
            //Console.WriteLine(str);


            string[] name = { "ndjmn", "sfff", "sefafaf", "afqafafa" };
           string str = string.Join("|", name);
            string[] strNew=str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
,