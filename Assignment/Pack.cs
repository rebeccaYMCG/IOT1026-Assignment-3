namespace Assignment;

public class Pack
{
    private InventoryItem[] _items; // You can use another data structure here if you prefer.
    // You may need another private member variable if you use an array data structure.

    private readonly int _maxCount;
    private readonly float _maxVolume;
    private readonly float _maxWeight;
    private int _currentCount; // Defaults to 0
    private float _currentVolume;
    private float _currentWeight;

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
        _items = new InventoryItem[maxCount];
        _maxCount = maxCount;
        _maxVolume = maxVolume;
        _maxWeight = maxWeight;
    }

    // getter
    public int GetMaxCount()
    {
        return _maxCount;
    }

    public float GetVolume()
    {
        return _currentVolume;
    }

    public bool Add(InventoryItem item)
    {
        // In the `Add` method, check if adding the item would exceed the pack's 
        // maximum count, weight, or volume. If it would not exceed these limits, 
        // add the item to the pack and return `true`. Otherwise, return `false`.

        // Does the current item cause _currentCount to be > _maxCount ... same for vol. and weight
        // if the new item will exceed these parameters, return false
        // else add it to the _items array and return true.

        // Do your logic to ensure the item can be added
        float weight = item.GetWeight();
        float volume = item.GetVolume();
        if (volume <= _maxVolume)
        {
            _currentWeight += weight;
            _currentVolume += volume;
            _items[_currentCount++] = item;
            return true;
        }
        return false;
    }

    // Implement this class
    public override string ToString()
    {
        throw new NotImplementedException();
    }
}

public abstract class InventoryItem
{
    private readonly float _volume;
    private readonly float _weight;

    protected InventoryItem(float volume, float weight)
    {
        if (volume <= 0f || weight <= 0f)
        {
            throw new ArgumentOutOfRangeException($"An item can't have {volume} volume or {weight} weight");
        }
        _volume = volume;
        _weight = weight;
    }

    // returns a string repersenting the quantities of the item (volume & weight of the item)
    public abstract string Display();

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
public class Arrow : InventoryItem
{
    public Arrow() : base(0.05f, 0.1f) { }

    public override string Display()
    {
        return $"An arrow with weight {GetWeight} and volume {GetVolume};
    }
}

public class Bow : InventoryItem
{
    public Bow() : base(1f, 4f) { }

    public override string Display()
    {
        return $"An bow with weight {GetWeight} and volume {GetVolume};
    }
}

public class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f) { }

    public override string Display()
    {
        return $"An rope with weight {GetWeight} and volume {GetVolume};
    }
}

public class Water : InventoryItem
{
    public Water() : base(2f, 3f) { }

    public override string Display()
    {
        return $"A flask of water with weight {GetWeight} and volume {GetVolume};
    }
}

public class Food : InventoryItem
{
    public Food() : base(1f, 0.5f) { }

    public override string Display()
    {
        return $"A bag of snacks with weight {GetWeight} and volume {GetVolume};
    }
}

public class Sword : InventoryItem
{
    public Sword() : base(5f, 3f) { }

    public override string Display()
    {
        return $"A glimmering sword with weight {GetWeight} and volume {GetVolume};
    }
}