namespace SprUML24._04.Classes.Przystanki;

public class Przystanek
{
    protected List<Przystanek> Przystanki = new();
    protected string NazwaPrzystanku;
    protected bool CzyPrzesiadkowy;
    protected bool CzyNaRzadanie;
    protected bool CzyPosiadaBiletomat;
    protected bool CzyPosiadaZadaszenie;
    protected Biletomat? Biletomat;
    public List<Autobus> Autobusy = new();

    public Przystanek(string nazwaPrzystanku, bool czyPrzesiadkowy, bool czyNaRzadanie, bool czyPosiadaBiletomat,
        bool czyPosiadaZadaszenie)
    {
        NazwaPrzystanku = nazwaPrzystanku;
        CzyPrzesiadkowy = czyPrzesiadkowy;
        CzyNaRzadanie = czyNaRzadanie;
        CzyPosiadaBiletomat = czyPosiadaBiletomat;
        CzyPosiadaZadaszenie = czyPosiadaZadaszenie;

        if (czyPosiadaBiletomat)
        {
            Biletomat = new Biletomat(100);
        }
    }

    public virtual void GdzieMoznaJechac()
    {
        Console.WriteLine($"Z przystanku {NazwaPrzystanku} możesz jechać na: ");
        WypiszPrzystanki();
    }

    public void DodajPrzystanek(Przystanek przystanek)
    {
        Przystanki.Add(przystanek);
    }

    protected void WypiszPrzystanki()
    {
        foreach (Przystanek przystanek in Przystanki)
        {
            Console.WriteLine(przystanek.NazwaPrzystanku);
        }

        Console.WriteLine("-----------");
    }

    public void OdjedzAutobusem(Przystanek przystanek)
    {
        if (!Przystanki.Contains(przystanek))
        {
            Console.WriteLine("Tam nie możesz bezpośrednio jechać!");
            return;
        }

        Autobus autobus = Autobusy[0];
        Console.WriteLine("Autobus odjeżdża!");
        autobus.Jedz();
        Autobusy.Remove(autobus);
        przystanek.Autobusy.Add(autobus);
    }
}

public class PunktCentralny : Przystanek
{
    public PunktCentralny(string nazwaPrzystanku, bool czyPrzesiadkowy, bool czyNaRzadanie, bool czyPosiadaBiletomat,
        bool czyPosiadaZadaszenie)
        : base(nazwaPrzystanku, czyPrzesiadkowy, czyNaRzadanie, czyPosiadaBiletomat, czyPosiadaZadaszenie)
    {
    }

    public override void GdzieMoznaJechac()
    {
        Console.WriteLine($"Ze startowego przystanku {NazwaPrzystanku} możesz jechać na");
        WypiszPrzystanki();
    }
}

public class Petla : Przystanek
{
    public Petla(string nazwaPrzystanku, bool czyPrzesiadkowy, bool czyNaRzadanie, bool czyPosiadaBiletomat, bool
        czyPosiadaZadaszenie) :
        base(nazwaPrzystanku, czyPrzesiadkowy, czyNaRzadanie, czyPosiadaBiletomat, czyPosiadaZadaszenie)
    {
        Przystanki = null!;
    }

    public override void GdzieMoznaJechac()
    {
        Console.WriteLine($"Jesteś na ostatnim przystanku {NazwaPrzystanku}");
    }
}

public class Biletomat
{
    private int IloscBiletow;

    public Biletomat(int iloscBiletow)
    {
        IloscBiletow = iloscBiletow;
    }
}

public class Autobus
{
    public void Jedz()
    {
        Console.WriteLine("Jadę!");
    }
}