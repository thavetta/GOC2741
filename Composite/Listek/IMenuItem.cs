namespace Listek;
/// <summary>
/// Ukážka Composite patternu - základný interface pre menu a menu item
/// </summary>
public interface IMenuItem : IEnumerable<IMenuItem>
{
    string Nazev { get; set; }
    string Popis { get; set; }
    decimal Cena { get; set; }
    bool JeVegetarianske { get; set; }
    IMenuItem this[int i] { get; set; }
    void Add(IMenuItem item);
    void Remove(IMenuItem item);
    bool HasChild { get; }
    string Print();
}