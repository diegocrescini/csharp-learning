namespace Classes;

public class Color
{
    private byte red;
    private byte green;
    private byte blue;
    private byte alpha;

    public Color(byte red, byte green, byte blue, byte alpha)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = alpha;
    }
    public Color(byte red, byte green, byte blue)
    {
        this.red = red;
        this.green = green;
        this.blue = blue;
        this.alpha = 255;
    }

// return methods
    public byte GetRed()
    {
        return red;
    }
        public byte GetGreen()
    {
        return green;
    }
        public byte GetBlue()
    {
        return blue;
    }
        public byte GetAlpha()
    {
        return alpha;
    }

// Set methods
public void SetRed(byte red)
    {
        this.red = red;
    }
    public void SetGreen(byte green)
    {
        this.green = green;
 }
    public void SetBlue(byte blue)
    {
        this.blue = blue;
    }
    public void SetAlpha(byte alpha)
    {
        this.alpha = alpha;
    }

// Get grayscale value
public byte getGrayscale()
    {
        return (byte)((this.red + this.green + this.blue) / 3);

    }
}