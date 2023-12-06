

public class Program
{
    public static void Main(String[] args)
    {

        //EXERICSE 1
        Car obj = new Car("Tesla", 2023, 1500.25f);

        obj.printCarDetails();

        //EXERICSE 2

        BankAccount accountObj = new BankAccount("12345678910",0);

        accountObj.Deposit(1000);
        accountObj.Withdraw(500);
        accountObj.finalBalance();

        //EXERICSE 3

        Rectangle rectObj = new Rectangle(5,10);

        rectObj.CalcualteArea();

        //EXERICSE 4

        Circle areaObj = new Circle(5);

        areaObj.CalculateArea();

        //EXERICSE 5
        Student studentObj = new Student("John Doe", 20, "Computer Science");

        studentObj.Introduce();

        //EXERICSE 6

        Stack<int> stackObj = new Stack<int>();
        stackObj.Push(2);
        stackObj.Push(3);
        stackObj.Push(4);
        stackObj.Pop();
        stackObj.Peek();
        stackObj.isEmpty();

        //EXERICSE 7

        Calendar calendar = new Calendar();

        calendar.PrintWeekdays();

        //EXERICSE 8


        Point2D pointA = new Point2D { X = 1.0f, Y = 2.0f };
        Point2D pointB = new Point2D { X = 4.0f, Y = 6.0f };

       
        float distance = DistanceCalculator.CalculateDistance(pointA, pointB);

 
        Console.WriteLine($"Distance between Point A and Point B: {distance}");

    }
}