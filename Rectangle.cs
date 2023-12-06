public class Rectangle
{
    private float length;
    private float width;

    public Rectangle(float length, float width)
    {
        this.length = length;
        this.width = width;
    }

    public float CalcualteArea()
    {
        var area = length * width;

        Console.WriteLine("The area of rectangle is: "+ area);

        return area;
    }

}