using System.Collections;

namespace Listek;

/// <summary>
/// Composite pattern - implementácia leaf prvku reprezentujúceho položku menu
/// </summary>
public class MenuItem : IMenuItem
{
    public string Nazev { get; set; }
    public string Popis { get; set; }
    public decimal Cena { get; set; }
    public bool JeVegetarianske { get; set; }

    public IMenuItem this[int i]
    {
        get => throw new System.NotSupportedException();
        set => throw new System.NotSupportedException();
    }

    public void Add(IMenuItem item) => throw new System.NotSupportedException();

    public void Remove(IMenuItem item) => throw new System.NotSupportedException();
    
    public bool HasChild => false;
    public string Print() => this.ToString();
        
    public IEnumerator<IMenuItem> GetEnumerator() => Enumerable.Empty<IMenuItem>().GetEnumerator();


    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        

    public override string ToString()
    {
        string vegetarian = JeVegetarianske ? "(v)" : String.Empty;
        return $"\t{Nazev} {vegetarian},{Cena}\n\t  -- {Popis}\n" ;
    }
}