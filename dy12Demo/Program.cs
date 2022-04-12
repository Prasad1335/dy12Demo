//int a = 1;
//while (a!=21) {


//    Console.WriteLine(a);
//    a++;
//}

//Console.WriteLine(a);

//------------------------------------------------------------------
//int b = 1;
//while (b <= 21)
//{

//    if (b %2 == 0)
//    {
//        Console.WriteLine(b+" even number");
//        b++;
//    }
//    else
//    {
//        Console.WriteLine(b+" odd number");
//        b++;
//    }
//Console.WriteLine(b);
//b++;
//}
//------------------------------------------------------------------

//int c = 1;
//while (c <= 100)
//{

//    if (c % 2 == 0 && c %5== 0)
//    {
//        Console.WriteLine(c + " divide 5 and 2 number");
//    }

//    c++;

//}
//------------------------------------------------------------------

//Console.Write("enter number : ");
//int num=int.Parse(Console.ReadLine());

//int f = 0;
//int i = 2;
//while (i <= num / 2)
//{
//    if (num % i == 0)
//    {
//        f = 1;
//        break;
//    }
//    i++;
//}
//if (f == 0)
//    Console.WriteLine(num + " is a Prime Number");
//else
//    Console.WriteLine(num + " is not a Prime Number");
//=============================== for loop =========================

//for(int i = 0; i <= 10; i++)
//{
//    if (i%2 != 0)
//    {
//        Console.WriteLine(i+" odd num");
//    }
//    else
//    {
//        Console.WriteLine(i+":even");
//    }

//}

//------------------------------------------------------------------

//for (int i = 1; i <= 100; i++)
//{
//    if (i % 2== 0 && i%5==0)
//    {
//        Console.WriteLine(i + " divide number 5 and 2");
//    }
//    else
//    {
//      //  Console.WriteLine(i + "not divide");
//    }

//}
//-------------------------- pattern print using nested for loop ----------------------------------------
//* * * *
//# # # #
//* * * *

//for (int i = 1; i <= 3; i++) //row
//{

//    for (int j = 1; j <= 3; j++) //column
//    {

//        if (i == 2)
//        {
//            Console.Write("#\t");
//        }
//        else
//        {
//            Console.Write("*\t");
//        }

//    }

//    Console.WriteLine("\n");
//}

//------------------------------------------------------------------
//1 1 1
//1 0 1
//1 1 1
//for(int i = 1; i <= 3; i++)
//{
//    for(int j = 1; j <= 3; j++)
//    {
//        if (i == 2 && j==2)
//        {
//            Console.Write("1\t");
//        }
//        else
//        {
//            Console.Write("0\t");
//        }
//    }
//    Console.WriteLine("\n");

//}
//------------------------------------------------------------------
//1       #       #       #
//#       1       #       #
//#       #       1       #
//#       #       #       1

//for (int i = 1; i <= 4; i++)
//{
//    for(int j = 1; j <= 4; j++)
//    {
//        if (i == j)
//        {
//           Console.Write("1\t");
//        }
//        else
//        {
//            Console.Write("#\t");
//        }
//    }
//    Console.WriteLine();

//}
//------------------------------------------------------------------
for (int i = 1; i <= 4; i++)
{
    for (int j = 1; j <= 4; j++)
    {
        if (i == j)
        {
            Console.Write("1\t");
        }
        else if (j==i)
        {
            
                Console.Write("0\t");
        }
        else
        {
            Console.Write("#\t");
        }
    }
    Console.WriteLine();

}