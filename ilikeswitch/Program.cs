using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ilikeswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            Console.Write("학년을 입력하세요 : ");
            var input = Console.ReadLine();


            switch (input)
            {
                case "level1":
                    Console.WriteLine("12학점");
                    break;
                case "level2":
                    Console.WriteLine("18학점");
                    break;
                case "level3":
                    Console.WriteLine("10학점");
                    break;
                case "level4":
                    Console.WriteLine("18학점");
                    break;
                
            }
        }
    
    }
}
