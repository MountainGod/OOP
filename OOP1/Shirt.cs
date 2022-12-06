namespace OOP1;

public class Shirt : ClothingItem
{
    private string _color = "";
    
    public string Color
    {
        get => _color;
        set => _color = value ?? throw new ArgumentNullException(nameof(value));
    }

    protected Shirt(int size, double cost, string color) : base(size, cost)
    {
        _color = color;
    }
}