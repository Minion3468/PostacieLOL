Garen g = new Garen();
g.ctrl3();

RubyCrystal rb = new RubyCrystal();
g.showHP();
g.buyItem(rb);
g.showHP();

DoransShield DsS = new DoransShield();
g.buyItem(DsS);
g.showHP();

DoransBlade DsB = new DoransBlade();
g.buyItem(DsB);
g.showHP();
g.showAD();


class Champion
{
    public string name;
    public float hp;
    public float ap;
    public Item[] items;

    public Champion()
    {
        name = "";
        hp = 0;
        ap = 0;
        items = new Item[6];
        Console.WriteLine("Konstruktor klasy Champion");
    }
    public void buyItem(Item i)
    {
        Console.WriteLine(name.ToString() + " kupuje " + i.name.ToString());
        items[0] = i;
        hp += i.stats["HP"];
        ap += i.stats["AP"];
    }
    public void showHP()
    {
        Console.WriteLine("Postać ma " + hp.ToString() + "HP");
    }
    public void showAD()
    {
        Console.WriteLine("Postać ma " + ap.ToString() + "AP");
    }
}
class Garen : Champion
{
    public Garen()
    {
        name = "Garen";
        hp = 620;
        ap = 66;
        Console.WriteLine("Konstruktor klasy Garen");
    }

    public void ctrl3()
    {
        Console.WriteLine("Garen tańczy!");
    }


}

public class Item
{
    public string name;
    public int price;
    public Dictionary<string, float> stats;

    public Item()
    {
        name = "";
        price = 0;
        stats = new Dictionary<string, float>();
        stats.Add("HP", 0);
        stats.Add("AP", 0);
        stats.Add("AD", 0);
    }
}
public class RubyCrystal : Item
{
    public int bonusHP = 150;
    public RubyCrystal()
    {
        name = "Ruby Crystal";
        price = 400;
        stats["HP"] = 150;
    }
}
public class DoransShield : Item
{
    public int bonusHP = 80;
    public DoransShield()
    {
        name = "Dorans's Shield";
        price = 450;
        stats["HP"] = 80;
    }

}
public class DoransBlade : Item
{
    public int bonusHP = 80;
    public int bonussAP = 8;
    public DoransBlade()
    {
        name = "Dorans's Blade";
        price = 450;
        stats["HP"] = 80;
        stats["AP"] = 8;
    }
}
