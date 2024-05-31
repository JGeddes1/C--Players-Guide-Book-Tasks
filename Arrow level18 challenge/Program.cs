
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("What arrow do you want?");
Console.WriteLine("1 - Elite Arrow");
Console.WriteLine("2 - Beginner Arrow");
Console.WriteLine("3 - Marksman Arrow");
Console.WriteLine("4 - Custom Arrow");

string choice = Console.ReadLine();


Arrow arrow = choice switch
{
    "1" => Arrow.CreateEliteArrow(),
    "2" => Arrow.CreateBeginnerArrow(),
    "3" => Arrow.CreateMarksmanArrow(),
    _ => getArrow(),
};


Console.WriteLine($"That arrow costs {arrow.GetCost()} gold.");
Console.WriteLine(arrow.Length);
Arrow getArrow()
{
    Arrowhead_Type arrowhead = GetArrowheadType();
    Fletching_Type flecthching = GetFletchingType();
    float length = GetLength();
    return new Arrow(arrowhead, flecthching, length);

}

Arrowhead_Type GetArrowheadType()
{
    Console.Write("Arrowhead type (steel, wood, obsidian): ");
    string input = Console.ReadLine();
    return input switch
    {
        "steel" => Arrowhead_Type.steel,
        "wood" => Arrowhead_Type.wooden,
        "obsidian" => Arrowhead_Type.obsidian
    };
}


Fletching_Type GetFletchingType()
{
    Console.Write("Fletching type (plastic, turkey feather, goose feather): ");
    string input = Console.ReadLine();
    return input switch
    {
        "plastic" => Fletching_Type.plastic,
        "turkey feather" => Fletching_Type.turkey_feather,
        "goose feather" => Fletching_Type.goose_feather
    };
}


float GetLength()
{
    Console.Write("length 60-100 ");
    string input = Console.ReadLine();
    int intInput = Convert.ToInt32(input);
    if (intInput >= 60 && intInput <= 100)
    {
        return intInput;
    }
    else
    {
        GetLength();
        return 0;
    }
}




class Arrow
{

    public Arrowhead_Type ArrowHead { get; }
    public Fletching_Type Fletching { get; }
    public float Length { get;}


    public Arrow(Arrowhead_Type arrowhead, Fletching_Type fletching, float length)
    {
        ArrowHead = arrowhead;
        Fletching = fletching;
        Length = length;

    }

    public static Arrow CreateEliteArrow()
    {
        return new Arrow(Arrowhead_Type.steel, Fletching_Type.plastic, 95);


    }
    public static Arrow CreateBeginnerArrow() => new Arrow(Arrowhead_Type.wooden, Fletching_Type.goose_feather, 75);
    public static Arrow CreateMarksmanArrow() => new Arrow(Arrowhead_Type.steel, Fletching_Type.goose_feather, 65);





    public float GetCost()
    {
        float arrowheadCost = ArrowHead switch
        {
            Arrowhead_Type.steel => 10,
            Arrowhead_Type.wooden => 3,
            Arrowhead_Type.obsidian => 5
        };

        float fletchingCost = Fletching switch
        {
            Fletching_Type.plastic => 10,
            Fletching_Type.turkey_feather => 5,
            Fletching_Type.goose_feather => 3
        };

        float shaftCost = 0.05f * Length;

        return arrowheadCost + fletchingCost + shaftCost;
    }




}



enum Arrowhead_Type {
    wooden, steel, obsidian
    }


enum Fletching_Type
{
    plastic, turkey_feather, goose_feather

}

