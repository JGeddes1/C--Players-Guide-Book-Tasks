Pack pack = new Pack(10, 20, 30);

while (true)
{
    
    Console.WriteLine($"Pack is currently at {pack.CurrentCount}/{pack.MaxLength} items, {pack.CurrentWeight}/{pack.MaxWeight} weight, and {pack.CurrentVolume}/{pack.MaxVolume} volume.");
    Console.WriteLine(pack.ToString());
   
    Console.WriteLine("What do you want to add?");
    Console.WriteLine("1 - Arrow");
    Console.WriteLine("2 - Bow");
    Console.WriteLine("3 - Rope");
    Console.WriteLine("4 - Water");
    Console.WriteLine("5 - Food");
    Console.WriteLine("6 - Sword");
    int choice = Convert.ToInt32(Console.ReadLine());

    InventoryItem newItem = choice switch
    {
        1 => new Arrow(),
        2 => new Bow(),
        3 => new Rope(),
        4 => new Water(),
        5 => new FoodRations(),
        6 => new Sword()
    };
    Console.WriteLine(newItem.ToString());
    pack.Add(newItem);
}

public class InventoryItem
{
    public float _weight { get; set;}
    public float _volume { get; set;}

    public InventoryItem(float Weight, float Volume)
    {
        _weight = Weight;
        _volume = Volume;

    }
    
}

public class Arrow : InventoryItem
{
    public Arrow() : base(0.1f, 0.05f) { }

    public override string ToString() => "Arrow";


}

public class Bow : InventoryItem
{
    public Bow() : base(0.1f, 4f)
    {

    }
    public override string ToString() => "Bow";
}


public class Rope : InventoryItem
{
    public Rope() : base(1f, 1.5f)
    {

    }
    public override string ToString() => "Rope";
}

public class Water : InventoryItem
{
    public Water() : base(2f, 3f)
    {

    }
    public override string ToString() => "Water";
}


public class FoodRations : InventoryItem
{
    public FoodRations() : base(1f, 0.5f)
    {


    }
    public override string ToString()
    {
        return "Food Rations";
    }
}

public class Sword : InventoryItem
{
    public Sword() : base(5f, 3f)
    {

    }

    public override string ToString()
    {
        return "Sword";
    }
}


public class Pack
{

    private InventoryItem[] inventoryItems ;
    public float MaxVolume { get; }
    public float MaxWeight { get; }

    public int MaxLength { get; }

    public int CurrentCount { get; private set; }
    public float CurrentVolume { get; private set; }
    public float CurrentWeight { get; private set; }


    public Pack(float maxVolume, float maxWeight, int maxLength)
    {
        MaxLength = maxLength;
        MaxVolume = maxVolume;
        MaxWeight = maxWeight;
        inventoryItems = new InventoryItem[MaxLength];
    }


    public bool Add(InventoryItem item)
    {
        if (CurrentCount >= MaxLength) return false;
        if (CurrentVolume + item._volume > MaxVolume) return false;
        if (CurrentWeight + item._weight > MaxWeight) return false;

        inventoryItems[CurrentCount] = item;
        CurrentCount++;
        CurrentVolume += item._volume;
        CurrentWeight += item._weight;
        return true;
    }

    public override string ToString()
    {
        string contents = "Pack containing ";


        for (int i = 0; i < CurrentCount; i++)
        {
            contents += inventoryItems[i].ToString() + " ";

        }
        if(CurrentCount ==0) contents += "Nothing";

        return contents;
    }
}