using System;

namespace 飞行器小游戏
{
    class Program
    {   static int[] PlayersPloy = new int[2];
        static string[] PlayName = new string[2];//存入两个玩家的姓名;
        public static int[] Maps = new int[100];
        public static bool[] Flog = new bool[2];
        static void Main(string[] args)  
        {     
            GameShow();
            #region;//玩家mingming；
            Console.WriteLine("请输入玩家的姓名");
            PlayName[0] = Console.ReadLine();
            while (PlayName[0] == "")
            {
                Console.WriteLine("输入错误，请重新输入");
                PlayName[0] = Console.ReadLine();
            }
            PlayName[1] = Console.ReadLine();
            while (PlayName[1] == "" || PlayName[0] == PlayName[1])
            {
                if(PlayName[0] == PlayName[1])
                {
                    Console.WriteLine("与A的名字重复。请重新输入");
                    PlayName[1] = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("请重新输入 ");
                    PlayName[1] = Console.ReadLine();
                }
            }
            #endregion;
            //玩家输入姓名之后，需要清屏；
            Console.Clear();//清清屏;
            GameShow();
            Console.WriteLine("{0}的图标用A表示", PlayName[0]);
            Console.WriteLine("{0}的图标用B表示", PlayName[1]);
            InitaiMap();
            DrawerMap();
            while (PlayersPloy[0] < 99 && PlayersPloy[1] < 99)
            {
                if (Flog[0] == false)
                {
                    PlayGame(0);
                }
                else
                {
                    Flog[0] = false;
                }
                if (PlayersPloy[0] > 99)
                {
                    Console.WriteLine("玩家{0}赢得了比赛", PlayName[0]);
                }
                if (Flog[1] == false)
                {
                    PlayGame(1);
                }
                else
                {
                    Flog[1] = false;
                }
                if (PlayersPloy[1] > 99)
                {
                    Console.WriteLine("玩家{1}赢得了比赛", PlayName[1]);
                }
            }
            Console.ReadKey();
        }
        /// <summary>
        /// 初始化地图
        /// </summary>
        public static void InitaiMap()
        {
            int[] Luckyturn = { 6, 23, 40, 55, 69, 83 };//幸运轮盘
            for (int i = 0; i <Luckyturn.Length; i++)
            {
                int index = Luckyturn[i];
                Maps[index] = 1;
            }
            int[] LandMine = { 5, 13, 17, 33, 38, 50, 64, 80, 94 };//地雷
            for (int i = 0; i < LandMine .Length; i++)
            {
                int index = LandMine[i];
                Maps[index] = 2;
            }
            int[] pause = { 9, 27, 60, 93 };//暂停
            for (int i = 0; i < pause.Length; i++)
            {
                int index = pause[i];
                Maps[index] = 3;
            }
            int[] timeTunnel = { 20, 25, 45, 63, 72, 88, 90 };//时空隧道
            for (int i = 0; i < timeTunnel.Length; i++)
            {
                int index = timeTunnel[i];
                Maps[index] = 4;
            }
        }
       /// <summary>
       /// 开头
       /// </summary>
        public static void GameShow()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("****飞行器小游戏****");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("********************");
        }
        /// <summary>
        /// 第一行的地图
        /// </summary>
        public static void DrawerMap()
        {
            Console.WriteLine("图例:幸运轮盘:◎   地雷:☆   暂停:▲   时空隧道:卐");
            for (int i = 0; i < 30; i++)
            {
                Console.Write(DrawingStringMaps(i));      
            }//第一横行；
            Console.WriteLine();
            for (int i = 30; i < 35; i++)
            {
                for (int j = 0; j < 29; j++)
                {
                    Console.Write("  ");
                }
                Console.WriteLine(DrawingStringMaps(i));
            }
            for (int i = 35; i < 64; i++)
            {
                Console.Write(DrawingStringMaps(i));
            }//第二横行；
            for (int i = 64; i <70; i++)
            {
                Console.WriteLine(DrawingStringMaps(i));               
            }//第二竖行；
            for (int i = 70; i < 100; i++)
            {
                Console.Write(DrawingStringMaps(i));
            }//第三横行;
            //画完最后一行，换行；
            Console.WriteLine();

        }
        public static string DrawingStringMaps(int i)
        {
            string str = "";
            //ab相同时的位置
            if (PlayersPloy[0] == PlayersPloy[1] && PlayersPloy[0] == i)
            {
                str="<>";
            }
            //不同时候的位置；
            else if (PlayersPloy[0] == i)
            {
                str="A";
            }
            else if (PlayersPloy[1] == i)
            {
               str="B";
            }
            else
            {
                switch (Maps[i])
                {

                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        str = "□";
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Green;
                        str = "◎";
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.White;
                        str = "★";
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Gray;
                        str = "▲";
                        break;
                    case 4:
                        str="卍";
                        break;
                }
                
            }return str;
        }
        /// <summary>
        /// 玩游戏
        /// </summary>
        /// <param name="playNumber"></param>
        public static void PlayGame(int playNumber)
        {
            Random r = new Random();
            int rNumber = r.Next(1, 7);//生成随机数；
            Console.WriteLine("{0}按任意键开始扔骰子", PlayName[playNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}仍出了{1}", PlayName[playNumber],rNumber);
            PlayersPloy[playNumber] += rNumber;
            ChangePor();
            Console.ReadKey(true);
            Console.WriteLine("{0}按任意键开始行动", PlayName[playNumber]);
            Console.ReadKey(true);
            Console.WriteLine("{0}移动完了", PlayName[playNumber]);
            Console.ReadKey(true);
            if (PlayersPloy[playNumber] == PlayersPloy[1- playNumber])
            {
                Console.WriteLine("{0}踩到了{1}，玩家{2}退六格", PlayName[playNumber], PlayName[1 - playNumber], PlayName[1 -playNumber]);
                PlayersPloy[1-playNumber] -= 6;
                Console.ReadKey(true);
            }
            else
            {
                switch (Maps[PlayersPloy[playNumber]])
                {
                    case 0:
                        Console.WriteLine("玩家{0}踩到方框，安全", PlayName[playNumber]);
                        Console.ReadKey(true);
                        break;
                    case 1:
                        Console.WriteLine("玩家{0}猜到幸运轮盘，请选择1--交换位置，2--轰炸对方", PlayName[playNumber]);
                        string input = Console.ReadLine();
                        while (true)
                        {
                            if (input == "1")
                            {
                                Console.WriteLine("玩家{0}与玩家{1}交换位置", PlayName[playNumber], PlayName[1 - playNumber]);
                                int temp = PlayersPloy[playNumber];
                                PlayersPloy[playNumber] = PlayersPloy[1 - playNumber];
                                PlayersPloy[1 - playNumber] = temp;
                                Console.WriteLine("位置交换完成");
                                Console.ReadKey(true);
                                break;
                            }
                            else if (input == "2")
                            {
                                Console.WriteLine("玩家{0}开始轰炸玩家{1}，玩家{2}退六格", PlayName[playNumber], PlayName[1 - playNumber], PlayName[1 - playNumber]);
                                Console.ReadKey(true);
                                PlayersPloy[1 - playNumber] -= 6;
                                Console.ReadKey(true);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("只能输入1或2，1--交换位置。2--轰炸对方");
                                input = Console.ReadLine();
                                Console.ReadKey(true);

                            }
                        }
                        break;

                    case 2:
                        Console.WriteLine("玩家{0}踩到地雷，到退六格", PlayName[playNumber]);
                        Console.ReadKey(true);
                        PlayersPloy[playNumber] -= 6;
                        Console.ReadKey(true);
                        break;
                    case 3:
                        Console.WriteLine("玩家{0}踩到暂停，暂停一回合", PlayName[playNumber]);
                        Flog[playNumber] = true;
                        Console.ReadKey(true);
                        break;
                    case 4:
                        Console.WriteLine("玩家{0}踩到时空隧道，前进十格", PlayName[playNumber]);
                        Console.ReadKey(true);
                        PlayersPloy[playNumber] += 10;
                        Console.ReadKey(true);
                        break;
                }
            }//else
            ChangePor();
            Console.Clear();
            DrawerMap();
        }
        /// <summary>
        /// 判断玩家位置是否超过地图
        /// </summary>
        public static void ChangePor()
        {
            if (PlayersPloy[0] < 0)
            {
                PlayersPloy[0] = 0;
            }
            if (PlayersPloy[0] >= 99)
            {
                PlayersPloy[0] = 99;
            }
            if (PlayersPloy[1] < 0)
            {
                PlayersPloy[1] = 0;
            }
            if (PlayersPloy[1] >= 99)
            {
                PlayersPloy[1] = 99;
            }
        }
    }
}
