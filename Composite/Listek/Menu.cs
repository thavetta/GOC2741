using System.Collections;
using System.Text;

namespace Listek;

/// <summary>
/// Ukážka Composite patternu - implementácia kontajneru reprezentujúceho menu
/// </summary>
public class Menu : IMenuItem
{
    private readonly List<IMenuItem> seznam = new();
    public IEnumerator<IMenuItem> GetEnumerator() => seznam.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
    public string Nazev { get; set; }
    public string Popis { get; set; }
    public decimal Cena { get; set; }
    public bool JeVegetarianske { get; set; }

    public IMenuItem this[int i]
    {
        get => seznam[i];
        set => seznam[i] = value;
    }

    public void Add(IMenuItem item) => seznam.Add(item);
        
    public void Remove(IMenuItem item) => seznam.Remove(item);
        

    public bool HasChild => true;
    public string Print()
    {
        var sb = new StringBuilder();
        sb.Append(this);
        foreach (var menuItem in seznam)
        {
            sb.Append(menuItem.Print());
        }
        return sb.ToString();
    }

    public override string ToString()
    {
        return $"*****************\n{Nazev}\n*****************\n";
    }

        
}