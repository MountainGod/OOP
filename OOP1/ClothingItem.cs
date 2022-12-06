namespace OOP1;

public class ClothingItem
{
    protected int _size;
    protected double _cost;

    public int Size
    {
        get => _size;
        set => _size = value;
    }

    public double Cost
    {
        get => _cost;
        set => _cost = value;
    }

    protected ClothingItem(int size, double cost)
    {
        Size = size;
        Cost = cost;
    }
}