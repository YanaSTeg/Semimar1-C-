// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница

Console.WriteLine("Insert number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number == 1)
{
    Console.WriteLine("It's Monday");

}
else if(number == 2)
{
   Console.WriteLine("It's Tuesday");
 
}
else if(number == 3)
{
   Console.WriteLine("It's Wednesday");
 
}
else if(number == 4)
{
   Console.WriteLine("It's Thursday");
 
}
else if(number == 5)
{
   Console.WriteLine("It's Friday");
 
}
 else if(number == 6)
{
   Console.WriteLine("It's Saturday");
 
}
else if(number == 7)
{
   Console.WriteLine("It's Sunday");
 
}
else
{
 Console. WriteLine("Error");
}

switch (number)
{
    case 1:
    {
       Console.WriteLine("It's Monday"); 
       break;
    }
    default:
    Console. WriteLine("Error");
}
