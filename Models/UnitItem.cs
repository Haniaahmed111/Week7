namespace InventorySystem.Models;

public sealed class UnitItem : Item
{
    public double WeightPerItemKg { get; }


    public uint InventoryLocation { get; set; }

    public UnitItem(string name, decimal pricePerUnit, double weightPerItemKg)
        : base(name, pricePerUnit)
    {
        WeightPerItemKg = weightPerItemKg;
    }

    public override string ToString() => $"{Name} ({PricePerUnit:C} / pcs)";
}