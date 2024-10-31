using OOP.Constructions;
var construction1 = new Construction();
var construction2 = new Construction(23.0f, 45.0f, 4, 4, "Material");
var construction3 = new Construction(
    new CreateConstructionDTO() {
        BuiltMaterial = "Material",
        Width = 100,
        Height = 100,
        Enterances = 2
    }
);
Console.WriteLine(construction2.BuildMaterial);
Console.WriteLine(construction2.HumanCapacity);
Console.WriteLine(construction2.Entrances);
Console.WriteLine(construction2.Width);
Console.WriteLine(construction2.Height);

Console.WriteLine(construction2.BuildMaterial);
Console.WriteLine(construction2.HumanCapacity);
Console.WriteLine(construction2.Entrances);
Console.WriteLine(construction2.Width);
Console.WriteLine(construction2.Height);