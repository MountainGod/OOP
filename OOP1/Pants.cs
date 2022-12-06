namespace OOP1;

public class Pants : ClothingItem
{
    private int _size;
    private double _cost;
    private int _pocketCount;

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

    public int PocketCount
    {
        get => _pocketCount;
        set => _pocketCount = value;
    }

    public Pants(int size, double cost, int pocketCount): base(size, cost)
    {
        _pocketCount = pocketCount;
    }
}