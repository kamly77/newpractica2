Random rand = new Random();
int MyNum;
int secret = rand.Next(1,101);
int count = 1;
Console.WriteLine("Компьютер загадал число от 0 до 100.Попробуйте отгадать");
while(true)
{
    MyNum = int.Parse(Console.ReadLine());
    if (MyNum == secret)
    {
        Console.WriteLine("Угадал,бро");
        break;   
    }
    else
    {
        if(MyNum > secret)
        {
            Console.WriteLine("Меньше,бро");
        }
        else
        {
            Console.WriteLine("Больше,бро");
        }
    }
}

Console.ReadKey();