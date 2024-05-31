

(Type type, Ingredients ingredient, Seasoning seasoning) soup = (Type.soup, Ingredients.potato, Seasoning.salty);

soup = GetSoup();

Console.WriteLine($"{soup.Item3} {soup.Item2} {soup.Item1}");


(Type, Ingredients, Seasoning) GetSoup()
{
    Type type = GetSoupType();
    Ingredients ingredients =  GetIngredient();
    Seasoning seasoning = GetSeasoning();
    return (type, ingredients, seasoning);
}


Seasoning GetSeasoning()
{
    Console.Write("Seasoning (spicy, salty, sweet): ");
    string input = Console.ReadLine();
    return input switch
    {
        "spicy" => Seasoning.spicy,
        "salty" => Seasoning.salty,
        "sweet" => Seasoning.sweet,
    };
}


Ingredients GetIngredient()
{

    Console.Write("Main ingredient (mushroom, chicken, carrot, potato): ");
    string input = Console.ReadLine();
    return input switch
    {
        "mushroom" => Ingredients.mushrooms,
        "chicken" => Ingredients.chicken,
        "carrot" => Ingredients.carrots,
        "potato" => Ingredients.potato
    };
}

Type GetSoupType()

{
    Console.Write("Pick a Soup type (soup, stew, gumbo): ");
    string input = Console.ReadLine();
    if (input == "soup")
    {
        return Type.soup;
    }else if (input == "stew")
    {
        return Type.stew;
    }else if (input == "gumbo") {
        return Type.gumbo;

    }
    else
    {
        return Type.soup;
    }
}




//(string type, string ingredient, string seasoning) GetScore() => ("soup", "mushrooms", "spicy");



enum Type
{
    soup,
    stew,
    gumbo
}
enum Ingredients
{
    mushrooms,
    chicken,
    carrots,
    potato
}
enum Seasoning
{
    spicy,
    salty,
    sweet
}