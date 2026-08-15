namespace Classes;

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0; // left to specify exactly the starting throwCount of the ball. But this line is not really necessary. 
    }

    public void Pop()
    {
        size = 0;
    }

    public void Throw()
    {
        if (size > 0)
        {
            throwCount += 1;
        }
    }

    public int GetThrowCount()
    {
        return throwCount;
    }
}