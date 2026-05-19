
//for (int i = 1; i<= 30 ; i++)
//{
//    Console.WriteLine(i);
//    if (i % 2 != 0)
//    {
//        continue;
//    }
//    if (i % 5 == 0)
//    {
//        break;
//    }
//};

//string password = "admin123", userAnswer;

//do
//{
//    Console.Write("Parolni kiriting: ");
//    userAnswer = Console.ReadLine();

//    if (userAnswer == "Exit" || userAnswer == "exit")
//    {
//        break;
//    }

//}while (userAnswer == password);

//Console.WriteLine("Xush kelibsiz!");

//int end, result = 0;

//while(true)
//{
//    Console.Write("Musbat son kiriting: ");
//    end = int.Parse(Console.ReadLine());

//    if( end < 0)
//    {
//        continue;
//    }
//    if( end == 0)
//    {
//        break;
//    }
//    result+= end;
//}
//Console.WriteLine(result);



//for (int son = 1; son <= 100; son++)
//{
//    bool tub = true;

//    for (int i = 2; i < son; i++)
//    {
//        if (son % i == 0)
//        {
//            tub = false;
//            break;
//        }
//    }

//    if (son > 1 && tub)
//    {
//        Console.WriteLine(son);
//    }
//}