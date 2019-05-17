using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //ตัดเกรดธรรมดา

            //int score = int.Parse(Console.ReadLine());
            //if (score > 80)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score > 70)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score > 60)
            //{
            //    Console.WriteLine("C");
            //}
            //else
            //{
            //    Console.WriteLine("F");
            //}





            //ตัดเกรดพี่อ้้น
            //int score = int.Parse(Console.ReadLine());

            //if (score > 60)
            //{
            //    Console.WriteLine("grade C");
            //}
            //else if (score > 70)
            //{
            //    Console.WriteLine("grade B");
            //}
            //else if (score > 80)
            //{
            //    Console.WriteLine("grade A");
            //}
            //else
            //{
            //    Console.WriteLine("grade F");
            //}





            //เข้าผับ
            //Console.WriteLine("Please enter your age");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("Pass");
            //}
            //else
            //{
            //    age = 18 - age;
            //    Console.WriteLine("You have to wait for " + age + " years");
            //}





            //เป่ายิงฉุบ
            //Console.WriteLine("1=Hummer " + "2=scissors " + "3=paper");
            //int player1 = int.Parse(Console.ReadLine());
            //int player2 = int.Parse(Console.ReadLine());

            //int total = player1 - player2;

            //switch (total)
            //{
            //    case 0: Console.WriteLine("draw"); break;
            //    case 1: Console.WriteLine("Player1 " + "lose"); break;
            //    case -1: Console.WriteLine("Player1 " + "win"); break;
            //    case 2: Console.WriteLine("Player1 " + "win"); break;
            //    case -2: Console.WriteLine("Player1 " + "lose"); break;

            //    default:
            //        Console.WriteLine("error");
            //        break;
            //}



            //if (player1 == 1 & player2 == 1)
            //{
            //    Console.WriteLine("Draw");
            //}
            //else if (player1 == 1 & player2 == 2)
            //{
            //    Console.WriteLine("player1 " + "Win");
            //}
            //else if (player1 == 1 & player2 == 3)
            //{
            //    Console.WriteLine("player1 " + "lose");
            //}
            //else if (player1 == 2 & player2 == 1)
            //{
            //    Console.WriteLine("player1 " + "lose");
            //}
            //else if (player1 == 2 & player2 == 3)
            //{
            //    Console.WriteLine("player1 " + "win");
            //}
            //else if (player1 == 2 & player2 == 2)
            //{
            //    Console.WriteLine("draw");
            //}
            //else if (player1 == 3 & player2 == 3)
            //{
            //    Console.WriteLine("draw");
            //}
            //else if (player1 == 3 & player2 == 1)
            //{
            //    Console.WriteLine("player1 " + "win");
            //}
            //else if (player1 == 3 & player2 == 2)
            //{
            //    Console.WriteLine("player1 " + "lose");
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}





            //โจทย์น้องเปา ลดราคา
            //int input = int.Parse(Console.ReadLine());
            //if (input >= 5000 & input <= 10000)
            //{
            //    //double result = input*0.03;
            //    Console.WriteLine("discount 3%");
            //    Console.WriteLine(input - (input * 0.03));

            //}

            //else if (input >= 10001 & input <= 20000)
            //{
            //    Console.WriteLine("discount 5%");
            //    Console.WriteLine(input - (input * 0.05));
            //}

            //else if (input >= 20001)
            //{
            //    Console.WriteLine("discount 10%");
            //    Console.WriteLine(input - (input * 0.1));
            //}

            //else
            //{
            //    Console.WriteLine("No discount");
            //    Console.WriteLine(input);
            //}





            ////เงินทอน
            //while (true)
            //{
            //    //int change = 5630;      // เงินที่จะทอน
            //    int thousandBank = 0;   // จำนวนแบงค์ 1000 ที่จะใช้
            //    int fiveHundredBank = 0;
            //    int hundredBank = 0;
            //    int fiftyBank = 0;
            //    int twentytyBank = 0;
            //    int ten = 0;
            //    int five = 0;
            //    int one = 0;

            //    Console.Write("Please input yourmoney: ");
            //    int input = int.Parse(Console.ReadLine());
            //    Console.Write("How much: ");
            //    int price = int.Parse(Console.ReadLine());
            //    int change;

            //    change = input - price;

            //    Console.WriteLine(change);


            //    if (change >= 1000)
            //    {
            //        thousandBank = (int)change / 1000;
            //        Console.WriteLine("1000: " + thousandBank);
            //        change = change - (1000 * thousandBank);
            //    }


            //    if (change >= 500)
            //    {
            //        fiveHundredBank = (int)change / 500;
            //        Console.WriteLine("500: " + fiveHundredBank);
            //        change = change - (500 * fiveHundredBank);
            //    }


            //    if (change >= 100)
            //    {
            //        hundredBank = (int)change / 100;
            //        Console.WriteLine("100: " + hundredBank);
            //    }
            //    change = change - (100 * hundredBank);


            //    if (change >= 50)
            //    {
            //        fiftyBank = (int)change / 50;
            //        Console.WriteLine("50: " + fiftyBank);
            //    }
            //    change = change - (50 * fiftyBank);


            //    if (change >= 20)
            //    {
            //        twentytyBank = (int)change / 20;
            //        Console.WriteLine("20: " + twentytyBank);
            //    }
            //    change = change - (20 * twentytyBank);


            //    if (change >= 10)
            //    {
            //        ten = (int)change / 10;
            //        Console.WriteLine("10: " + ten);
            //    }
            //    change = change - (10 * ten);

            //    if (change >= 5)
            //    {
            //        five = (int)change / 5;
            //        Console.WriteLine("10: " + five);
            //    }
            //    change = change - (5 * five);


            //    if (change >= 1)
            //    {
            //        one = (int)change / 1;
            //        Console.WriteLine("1: " + one);
            //    }
            //    ////change = change - (1 * one);


            //    if (change < 0)
            //    {
            //        Console.WriteLine("Can not buy it");
            //    }









            //โปรแกรมบวกเลข -while loop
            //int input1 = int.Parse(Console.ReadLine());
            //int input2 = int.Parse(Console.ReadLine());
            //int count = 1;
            //int result = 0;
            //while (count <= input2)
            //{
            //    result += input1;
            //    count++;
            //}
            //Console.WriteLine(result);





            // โปรแกรมบวกเลข-while loop
            //string answer = "yes";
            //while (answer == "yes")
            //{
            //    int result = 0;
            //    int count = 1;

            //    Console.WriteLine("how many round?");
            //    int round = int.Parse(Console.ReadLine());
            //    while (count <= round)
            //    {
            //        Console.Write("input your number ");
            //        int input = int.Parse(Console.ReadLine());
            //        result += input;
            //        count++;
            //    }
            //    Console.WriteLine("The answer is " + result);

            //    Console.WriteLine("Do you want to continue? (yes/no)");
            //    answer = (Console.ReadLine());
            //}

            //Console.WriteLine("Good BYE");








            // โปรแกรมสร้างพีระมิด-while loop
            //Console.WriteLine("how many floor?");
            //int floor = int.Parse(Console.ReadLine());

            //string a = "*";
            //string b = "";

            //while (floor > 0)
            //{
            //    b += a;
            //    Console.WriteLine(b);

            //    floor--;
            //}



            //เครื่องผลิตปีศาจ --ทำให้มันเลิกผลิตโดยการใส่break
            //do
            //{
            //    break;
            //    Console.WriteLine("Summon a monster");
            //} while (true);


            //เครื่องโชว์สัตว์เลี้ยง

            string a = "";
            string b = "";
            Console.WriteLine("Here a cute cat");
            Console.WriteLine("Do you want to see a dog (y/n)");

            do

                Console.WriteLine("Do you want to see a dog (y/n)");

            while (a == "y");
            {

                Console.WriteLine("Here an awesome dog");

            }
            Console.WriteLine("Good BYE");

        }
    }

}
