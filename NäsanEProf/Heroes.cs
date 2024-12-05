namespace Hjältar
{

    class Hjältar
    {
        private string _namn;
        private int _hälsa;
        //Konstruktor för att ge variabler värden
        public Hjältar(string namn, int hälsa)
        {
            _namn = namn;
            _hälsa = hälsa;
        }
        //metod för att visa informationen som hjälten har
        public void Information()
        {
            Console.WriteLine($"Namn: {_namn}");
            Console.WriteLine($"Hälsa: {_hälsa}");

        }
        //när vi skadar eller ger hälsa kallas denna
        public void BytHälsa(int mängd)
        {
            _hälsa += mängd;
        }
    }

    class GodHjälte : Hjältar
    {

        private int _helandeStyrka;
        //konstruktor som skickar tillbaka data till parent klassen 
        public GodHjälte(string namn, int hp, int helandeStyrka) : base(namn, hp)
        {
            _helandeStyrka = helandeStyrka;
        }
        //ger hälsa till given hjälte
        public void GeHälsa(Hjältar Target)
        {
            Target.BytHälsa(_helandeStyrka);
        }
    }

    class OndHjälte : Hjältar
    {

        private int _AttackStyrka;
        //skickar tillbaka data till parent klassen
        public OndHjälte(string namn, int hp, int attackstyrka) : base(namn, hp)
        {
            _AttackStyrka = attackstyrka;
        }
        //ger tillbaka en int som anger hur mycket skada som gjorts
        public int skada(int mängd)
        {
            return mängd;
        }

    }




}