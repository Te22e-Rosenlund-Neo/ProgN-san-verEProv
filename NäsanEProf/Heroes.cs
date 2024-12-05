namespace Hjältar
{

    class Hjältar
    {
        private string _namn;
        private int _hälsa;

        public Hjältar(string namn, int hälsa){
            _namn = namn;
            _hälsa = hälsa;
        }

        public void Information(){
            Console.WriteLine($"Namn: {_namn}");
            Console.WriteLine($"Hälsa: {_hälsa}");

        }
        public void BytHälsa(int mängd){
            _hälsa -= mängd;
        }
    }

    class GodHjälte : Hjältar{

        private int _helandeStyrka;

        public GodHjälte(string namn, int hp, int helandeStyrka) : base(namn, hp){
            _helandeStyrka = helandeStyrka;
        }

        public void GeHälsa(Hjältar Target){
            Target.BytHälsa(_helandeStyrka);
        }
    }

    class OndHjälte : Hjältar{

        private int _AttackStyrka; 

        public OndHjälte(string namn, int hp, int attackstyrka) : base(namn,hp){
            _AttackStyrka = attackstyrka;
        }

        public int skada(int mängd){
            return mängd;
        }

    }




}