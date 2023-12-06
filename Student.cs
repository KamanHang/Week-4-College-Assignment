public class Student
{
    private string name;
    private int age;
    private string major;


    public Student(string name, int age, string major ) 
    { 
        
        this.name = name;
        this.age = age;
        this.major = major;

    }

    public void Introduce()
    {
        Console.WriteLine("Hello Everyone I am "+name+", I am "+ age +" years old and my major is " + major);
    }




}