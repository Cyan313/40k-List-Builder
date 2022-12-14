using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Army
    {
        public string name;
        internal int Faction;
        public string subFaction;
        internal int detachment;
        internal int Points = 0;
        internal int PL = 0;
        internal int CP = 0;
        public int Maxpoints;
        

        
    }

    class Imperium : Army
    {
        
        public void printImp(Army army1, List<string> hq, List<string> troop, List<string> elite, List<string> fast, List<string> heavy, List<string> flyer, List<string> transport)
        {
            Console.WriteLine(army1.name + "\n");
            if (army1.detachment == 1)
                Console.WriteLine("Patrol Detachment\n");
            if (army1.detachment == 2)
                Console.WriteLine("Battalion Detachment\n");
            if (army1.detachment == 3)
                Console.WriteLine("Brigade Detachment\n");

            if (army1.Faction == 1)
                Console.WriteLine("Adepta Sororitas");
            if (army1.Faction == 2)
                Console.WriteLine("Adeptus Astartes");
            if (army1.Faction == 3)
                Console.WriteLine("Adeptus Custodes");
            if (army1.Faction == 4)
                Console.WriteLine("Adeptus Mechanicus");
            if (army1.Faction == 5)
                Console.WriteLine("Astra Millitarum");

            Console.WriteLine(army1.subFaction);
            Console.WriteLine(army1.CP + " Command Points");
            Console.WriteLine(army1.Points + " Points");
            Console.WriteLine(army1.PL + " PL");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("HQs");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < hq.Count; i++)
            {
                Console.WriteLine(hq[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Troops");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < troop.Count; i++)
            {
                Console.WriteLine(troop[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Elites");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < elite.Count; i++)
            {
                Console.WriteLine(elite[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Fast Attack");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < fast.Count; i++)
            {
                Console.WriteLine(fast[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Heavy Supports");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < heavy.Count; i++)
            {
                Console.WriteLine(heavy[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Flyers");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < flyer.Count; i++)
            {
                Console.WriteLine(flyer[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Dedicated Transports");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < transport.Count; i++)
            {
                Console.WriteLine(transport[i]);
            }
            Console.WriteLine("\n");
        }
    }

    class Chaos : Army
    {
        public void printChaos(Army army2, List<string> hq, List<string> troop, List<string> elite, List<string> fast, List<string> heavy, List<string> flyer, List<string> transport)
        {
            Console.WriteLine(army2.name + "\n");
            if (army2.detachment == 1)
                Console.WriteLine("Patrol Detachment\n");
            if (army2.detachment == 2)
                Console.WriteLine("Battalion Detachment\n");
            if (army2.detachment == 3)
                Console.WriteLine("Brigade Detachment\n");

            if (army2.Faction == 1)
                Console.WriteLine("Chaos Daemons");
            if (army2.Faction == 2)
                Console.WriteLine("Death Guard");
            if (army2.Faction == 3)
                Console.WriteLine("Chaos Space Marines");
            if (army2.Faction == 4)
                Console.WriteLine("Thousand Sons");

            Console.WriteLine(army2.subFaction);
            Console.WriteLine(army2.CP + " Command Points");
            Console.WriteLine(army2.Points + " Points");
            Console.WriteLine(army2.PL + " PL");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("HQs");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < hq.Count; i++)
            {
                Console.WriteLine(hq[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Troops");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < troop.Count; i++)
            {
                Console.WriteLine(troop[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Elites");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < elite.Count; i++)
            {
                Console.WriteLine(elite[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Fast Attack");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < fast.Count; i++)
            {
                Console.WriteLine(fast[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Heavy Supports");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < heavy.Count; i++)
            {
                Console.WriteLine(heavy[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Flyers");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < flyer.Count; i++)
            {
                Console.WriteLine(flyer[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Dedicated Transports");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < transport.Count; i++)
            {
                Console.WriteLine(transport[i]);
            }
            Console.WriteLine("\n");
        }
    }

    class Xenos : Army
    {
        public void printXenos(Army army3, List<string> hq, List<string> troop, List<string> elite, List<string> fast, List<string> heavy, List<string> flyer, List<string> transport)
        {
            Console.WriteLine(army3.name + "\n");
            if (army3.detachment == 1)
                Console.WriteLine("Patrol Detachment\n");
            if (army3.detachment == 2)
                Console.WriteLine("Battalion Detachment\n");
            if (army3.detachment == 3)
                Console.WriteLine("Brigade Detachment\n");

            if (army3.Faction == 1)
                Console.WriteLine("Craftworlds");
            if (army3.Faction == 2)
                Console.WriteLine("Drukhari");
            if (army3.Faction == 3)
                Console.WriteLine("Genestealer Cults");
            if (army3.Faction == 4)
                Console.WriteLine("Harlequins");
            if (army3.Faction == 5)
                Console.WriteLine("Necrons");
            if (army3.Faction == 6)
                Console.WriteLine("Orks");
            if (army3.Faction == 7)
                Console.WriteLine("T'au Empire");
            if (army3.Faction == 8)
                Console.WriteLine("Tyranids");
            if (army3.Faction == 9)
                Console.WriteLine("Ynnari");

            Console.WriteLine(army3.subFaction);
            Console.WriteLine(army3.CP + " Command Points");
            Console.WriteLine(army3.Points + " Points");
            Console.WriteLine(army3.PL + " PL");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("HQs");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < hq.Count; i++)
            {
                Console.WriteLine(hq[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Troops");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < troop.Count; i++)
            {
                Console.WriteLine(troop[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Elites");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < elite.Count; i++)
            {
                Console.WriteLine(elite[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Fast Attack");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < fast.Count; i++)
            {
                Console.WriteLine(fast[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Heavy Supports");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < heavy.Count; i++)
            {
                Console.WriteLine(heavy[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Flyers");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < flyer.Count; i++)
            {
                Console.WriteLine(flyer[i]);
            }
            Console.WriteLine("\n");
            Console.WriteLine("Dedicated Transports");
            Console.WriteLine("----------------------------------");
            for (int i = 0; i < transport.Count; i++)
            {
                Console.WriteLine(transport[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
