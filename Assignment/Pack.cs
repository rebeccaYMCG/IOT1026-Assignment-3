namespace Assignment;

public class Pack
{
    private InventoryItem[] _items; // You can use another data structure here if you prefer.
    // You may need another private member variable if you use an array data structure.

    private readonly int _maxCount;
    private readonly float _maxVolume;
    private readonly float _maxWeight;

    /// <summary>
    /// Default constructor for the class.
    /// Sets the maxCount to 10, maxVolume to 20, and maxWeight to 30.
    /// </summary>
    public Pack() : this(10, 20, 30)
    {
        // ...
    }

    // not done yet
    public Pack(int maxCount, float maxVolume, float maxWeight)
    {
        _maxCount = maxCount;
        _maxVolume = maxVolume;
        _maxWeight = maxWeight;
    }

    // getter
    public int GetMaxCount()
    {
        return _maxCount;
    }

    public bool Add(InventoryItem item)
    {
        throw new NotImplementedException();
    }

    // Implement this class
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}

public class InventoryItem
{
    private readonly float _volume;
    private readonly float _weight;

    public InventoryItem(float volume, float weight)
    {
        _volume = volume;
        _weight = weight;
    }

    public float GetVolume()
    {
        return _volume;
    }

    public float GetWeight()
    {
        return _weight;
    }
}

// Implement these classes - each inherits from InventoryItem
// 1 line of code each - call base class constructor with appropriate arguments
class Arrow : InventoryItem
{
    public Arrow() : base(0.05f, 0.1f) { }
}

class Bow : InventoryItem
{
    public Bow() : base(1f, 4f) { }
}

class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f) { }
}

class Water : InventoryItem { }
class Food : InventoryItem { }
class Sword : InventoryItem { }
