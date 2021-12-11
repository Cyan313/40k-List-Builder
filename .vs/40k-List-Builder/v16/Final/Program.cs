using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            int hqs, troops, elites, fasts, heavys, flyers, transports, remove, sub;
            int menu = 0;
            List<string> hq = new List<string>();
            List<string> troop = new List<string>();
            List<string> elite = new List<string>();
            List<string> fast = new List<string>();
            List<string> heavy = new List<string>();
            List<string> flyer = new List<string>();
            List<string> transport = new List<string>();
            List<int> hqp = new List<int>();
            List<int> troopp = new List<int>();
            List<int> elitep = new List<int>();
            List<int> fastp = new List<int>();
            List<int> heavyp = new List<int>();
            List<int> flyerp = new List<int>();
            List<int> transportp = new List<int>();
            List<int> hpl = new List<int>();
            List<int> tpl = new List<int>();
            List<int> epl = new List<int>();
            List<int> fpl = new List<int>();
            List<int> hepl = new List<int>();
            List<int> flpl = new List<int>();
            List<int> trpl = new List<int>();
            Console.WriteLine("Select an Army (1 for imperium, 2 for Chaos, 3 for Xenos).");
            int choice = Convert.ToInt32(Console.ReadLine());
            var army1 = new Imperium();
            var army2 = new Chaos();
            var army3 = new Xenos();
            if (choice == 1)
            {
                Console.WriteLine("What would you like to call your army?");
                army1.name = Console.ReadLine();
                Console.WriteLine("Which faction would you like?\n");
                Console.WriteLine("1 - Adepta Sororitas\n");
                Console.WriteLine("2 - Adeptus Astartes\n");
                Console.WriteLine("3 - Adeptus Custodes\n");
                Console.WriteLine("4 - Adetus Mechanicus\n");
                Console.WriteLine("5 - Astra Millitarum\n");
                army1.Faction = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("What Detachment would you like?");
                Console.WriteLine("1 - Patrol Detachment\n");
                Console.WriteLine("     2 HQs, 3 Troops, 2 Elites, 2 Fast Attacks, 2 Heavy Supports, 2 Flyers, 3 Dedicated Transport\n");

                Console.WriteLine("2 - Battalion Detachment\n");
                Console.WriteLine("     3 HQs, 6 Troops, 6 Elites, 3 Fast Attacks, 3 Heavy Supports, 2 Flyers, 6 Dedicated Transport\n");

                Console.WriteLine("3 - Brigade Detachment\n");
                Console.WriteLine("     5 HQs, 12 Troops, 8 Elites, 5 Fast Attacks, 5 Heavy Supports, 2 Flyers, 12 Dedicated Transport\n");
            
                army1.detachment = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("How many points is your army?");
                Console.WriteLine("1 - Combat Patrol (0-500)");
                Console.WriteLine("2 - Incursion (501-1000)");
                Console.WriteLine("3 - Strike Force (1001-2000)");
                Console.WriteLine("4 - Onslaught (2001-3000)");

                army1.Maxpoints = Convert.ToInt32(Console.ReadLine());

                if (army1.detachment == 1)
                    army1.CP = 3;
                if (army1.detachment == 2)
                    army1.CP = 6;
                if (army1.detachment == 3)
                    army1.CP = 12;
                if (army1.detachment == 4)
                    army1.CP = 18;
                Console.Clear();
            }
            if(choice == 2)
            {
                Console.WriteLine("What would you like to call your army?");
                army2.name = Console.ReadLine();
                Console.WriteLine("Which faction would you like?\n");
                Console.WriteLine("1 - Chaos Daemons\n");
                Console.WriteLine("2 - Death Guard\n");
                Console.WriteLine("3 - Chaos Space Marines\n");
                Console.WriteLine("4 - Thousand Sons\n");
                army2.Faction = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What Detachment would you like?");
                Console.WriteLine("1 - Patrol Detachment\n");
                Console.WriteLine("     2 HQs, 3 Troops, 2 Elites, 2 Fast Attacks, 2 Heavy Supports, 2 Flyers, 3 Dedicated Transport\n");

                Console.WriteLine("2 - Battalion Detachment\n");
                Console.WriteLine("     3 HQs, 6 Troops, 6 Elites, 3 Fast Attacks, 3 Heavy Supports, 2 Flyers, 6 Dedicated Transport\n");

                Console.WriteLine("3 - Brigade Detachment\n");
                Console.WriteLine("     5 HQs, 12 Troops, 8 Elites, 5 Fast Attacks, 5 Heavy Supports, 2 Flyers, 12 Dedicated Transport\n");

                army2.detachment = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many points is your army?");
                Console.WriteLine("1 - Combat Patrol (0-500)");
                Console.WriteLine("2 - Incursion (501-1000)");
                Console.WriteLine("3 - Strike Force (1001-2000)");
                Console.WriteLine("4 - Onslaught (2001-3000)");

                army2.Maxpoints = Convert.ToInt32(Console.ReadLine());
                if (army2.detachment == 1)
                    army2.CP = 3;
                if (army2.detachment == 2)
                    army2.CP = 6;
                if (army2.detachment == 3)
                    army2.CP = 12;
                if (army2.detachment == 4)
                    army2.CP = 18;
                Console.Clear();
            }
            if(choice == 3)
            {
                Console.WriteLine("What would you like to call your army?");
                army3.name = Console.ReadLine();
                Console.WriteLine("Which faction would you like?\n");
                Console.WriteLine("1 - Craftworlds\n");
                Console.WriteLine("2 - Drukhari\n");
                Console.WriteLine("3 - Genestealer Cults\n");
                Console.WriteLine("4 - Harlequins\n");
                Console.WriteLine("5 - Necrons\n");
                Console.WriteLine("6 - Orks\n");
                Console.WriteLine("7 - T'au Empire\n");
                Console.WriteLine("8 - Tyranids\n");
                Console.WriteLine("9 - Ynnari\n");
                army3.Faction = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What Detachment would you like?");
                Console.WriteLine("1 - Patrol Detachment\n");
                Console.WriteLine("     2 HQs, 3 Troops, 2 Elites, 2 Fast Attacks, 2 Heavy Supports, 2 Flyers, 3 Dedicated Transport\n");

                Console.WriteLine("2 - Battalion Detachment\n");
                Console.WriteLine("     3 HQs, 6 Troops, 6 Elites, 3 Fast Attacks, 3 Heavy Supports, 2 Flyers, 6 Dedicated Transport\n");

                Console.WriteLine("3 - Brigade Detachment\n");
                Console.WriteLine("     5 HQs, 12 Troops, 8 Elites, 5 Fast Attacks, 5 Heavy Supports, 2 Flyers, 12 Dedicated Transport\n");

                army3.detachment = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How many points is your army?");
                Console.WriteLine("1 - Combat Patrol (0-500)");
                Console.WriteLine("2 - Incursion (501-1000)");
                Console.WriteLine("3 - Strike Force (1001-2000)");
                Console.WriteLine("4 - Onslaught (2001-3000)");

                army3.Maxpoints = Convert.ToInt32(Console.ReadLine());

                if (army3.detachment == 1)
                    army3.CP = 3;
                if (army3.detachment == 2)
                    army3.CP = 6;
                if (army3.detachment == 3)
                    army3.CP = 12;
                if (army3.detachment == 4)
                    army3.CP = 18;
                Console.Clear();
            }
            do
            {
                Console.Clear();
                if (choice == 1)
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

                if (choice == 2)
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

                if (choice == 3)
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
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1 - Add an HQ");
                Console.WriteLine("2 - Add a Troop");
                Console.WriteLine("3 - Add an Elite");
                Console.WriteLine("4 - Add a Fast Attack");
                Console.WriteLine("5 - Add a Heavy Support");
                Console.WriteLine("6 - Add a Flyer");
                Console.WriteLine("7 - Add a Dedicated Transport");
                Console.WriteLine("8 - Remove a Unit");
                Console.WriteLine("9 - Change Army Name");
                Console.WriteLine("10 - Choose Sub-Faction");
                Console.WriteLine("11 - Exit");
                menu = Convert.ToInt32(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        if(choice == 1)
                        {
                            if(army1.Faction == 1)
                            {
                                Console.WriteLine("1 - Canoness\n");
                                Console.WriteLine("2 - Palatine\n");
                                Console.WriteLine("3 - Missionary with Chainsword\n");
                                Console.WriteLine("4 - Canoness Veridyan\n");
                                Console.WriteLine("5 - Junith Eruita\n");
                                Console.WriteLine("6 - Ephrael Stern & Kyganil\n");
                                Console.WriteLine("7 - Celestine, the Living Saint\n");
                                Console.WriteLine("8 - The Triumph of Saint Katherine\n");
                                Console.WriteLine("9 - Morvenn Vahl, Abbess Sanctorum of the Adepta Sororitas\n");
                                hqs = Convert.ToInt32(Console.ReadLine());

                                if(army1.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Canoness");
                                            army1.Points = army1.Points + 50;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Palatine");
                                            army1.Points = army1.Points + 45;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Missionary with Chainsword");
                                            army1.Points = army1.Points + 40;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(40);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Canoness Veridyan");
                                            army1.Points = army1.Points + 45;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Junith Eruita");
                                            army1.Points = army1.Points + 130;
                                            army1.PL = army1.PL + 7;
                                            hqp.Add(130);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Ephrael Stern & Kyganil");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Celestine, the Living Saint");
                                            army1.Points = army1.Points + 200;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(200);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("The Triumph of Saint Katherine");
                                            army1.Points = army1.Points + 220;
                                            army1.PL = army1.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Morvenn Vahl, Abbess Sanctorum of the Adepta Sororitas");
                                            army1.Points = army1.Points + 265;
                                            army1.PL = army1.PL + 13;
                                            hqp.Add(265);
                                            hpl.Add(13);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if(army1.detachment == 2)
                                {
                                    if(hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Canoness");
                                            army1.Points = army1.Points + 50;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Palatine");
                                            army1.Points = army1.Points + 45;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Missionary with Chainsword");
                                            army1.Points = army1.Points + 40;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(40);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Canoness Veridyan");
                                            army1.Points = army1.Points + 45;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Junith Eruita");
                                            army1.Points = army1.Points + 130;
                                            army1.PL = army1.PL + 7;
                                            hqp.Add(130);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Ephrael Stern & Kyganil");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Celestine, the Living Saint");
                                            army1.Points = army1.Points + 200;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(200);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("The Triumph of Saint Katherine");
                                            army1.Points = army1.Points + 220;
                                            army1.PL = army1.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Morvenn Vahl, Abbess Sanctorum of the Adepta Sororitas");
                                            army1.Points = army1.Points + 265;
                                            army1.PL = army1.PL + 13;
                                            hqp.Add(265);
                                            hpl.Add(13);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if(army1.detachment == 3)
                                {
                                    if(hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Canoness");
                                            army1.Points = army1.Points + 50;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Palatine");
                                            army1.Points = army1.Points + 45;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Missionary with Chainsword");
                                            army1.Points = army1.Points + 40;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(40);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Canoness Veridyan");
                                            army1.Points = army1.Points + 45;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Junith Eruita");
                                            army1.Points = army1.Points + 130;
                                            army1.PL = army1.PL + 7;
                                            hqp.Add(130);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Ephrael Stern & Kyganil");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Celestine, the Living Saint");
                                            army1.Points = army1.Points + 200;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(200);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("The Triumph of Saint Katherine");
                                            army1.Points = army1.Points + 220;
                                            army1.PL = army1.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Morvenn Vahl, Abbess Sanctorum of the Adepta Sororitas");
                                            army1.Points = army1.Points + 265;
                                            army1.PL = army1.PL + 13;
                                            hqp.Add(265);
                                            hpl.Add(13);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                            }
                            if(army1.Faction == 2)
                            {
                                Console.WriteLine("1 - Captain with Master-crafter Heavy Bolt Rifle");
                                Console.WriteLine("2 - Techmarine");
                                Console.WriteLine("3 - Space Marine Captain: Lord Executioner");
                                Console.WriteLine("4 - Chaplain with Jump Pack");
                                Console.WriteLine("5 - Space Marine Commander");
                                Console.WriteLine("6 - Space Marine Captain");
                                Console.WriteLine("7 - Librarian in Terminator Armour");
                                Console.WriteLine("8 - Masters of the Chapter");
                                Console.WriteLine("9 - Librarian");
                                Console.WriteLine("10 - Primaris Lieutenant in Reiver Armour");
                                Console.WriteLine("11 - Primaris Chaplain");
                                Console.WriteLine("12 - Primaris Librarian in Phobos Armour");
                                Console.WriteLine("13 - Primaris Lieutenant with Power Sword");
                                Console.WriteLine("14 - Primaris Librarian");
                                Console.WriteLine("15 - Spce Marines Chaplain");
                                Console.WriteLine("16 - Primaris Captain");
                                Console.WriteLine("17 - Primaris Techmarine");
                                Console.WriteLine("18 - Captain in Phobos Armour");
                                Console.WriteLine("19 - Primaris Chaplain on Bike");
                                Console.WriteLine("20 - Space Marine Heroes");
                                Console.WriteLine("21 - Company Command");
                                Console.WriteLine("22 - Heroes of the Chapter");
                                Console.WriteLine("23 - Space Marines: Honoured of the Chapter");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army1.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Captain with Master-crafter Heavy Bolt Rifle");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Techmarine");
                                            army1.Points = army1.Points + 70;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Space Marine Captain: Lord Executioner");
                                            army1.Points = army1.Points + 100;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Chaplain with Jump Pack");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Space Marine Commander");
                                            army1.Points = army1.Points + 165;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(165);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Space Marine Captain");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Librarian in Terminator Armour");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Masters of the Chapter");
                                            army1.Points = army1.Points + 200;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(200);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Librarian");
                                            army1.Points = army1.Points + 90;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Primaris Lieutenant in Reiver Armour");
                                            army1.Points = army1.Points + 75;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(75);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Primaris Chaplain");
                                            army1.Points = army1.Points + 85;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Primaris Librarian in Phobos Armour");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Primaris Lieutenant with Power Sword");
                                            army1.Points = army1.Points + 85;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(85);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Primaris Librarian");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Space Marines Chaplain");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(80);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Primaris Captain");
                                            army1.Points = army1.Points + 90;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Primaris Techmarine");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Captain in Phobos Armour");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(95);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Primaris Chaplain on Bike");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Space Marine Heroes");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Company Command");
                                            army1.Points = army1.Points + 100;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Heroes of the Chapter");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(120);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Space Marines: Honoured of the Chapter");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(120);
                                            hpl.Add(5);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Captain with Master-crafter Heavy Bolt Rifle");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Techmarine");
                                            army1.Points = army1.Points + 70;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Space Marine Captain: Lord Executioner");
                                            army1.Points = army1.Points + 100;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Chaplain with Jump Pack");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Space Marine Commander");
                                            army1.Points = army1.Points + 165;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(165);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Space Marine Captain");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Librarian in Terminator Armour");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Masters of the Chapter");
                                            army1.Points = army1.Points + 200;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(200);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Librarian");
                                            army1.Points = army1.Points + 90;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Primaris Lieutenant in Reiver Armour");
                                            army1.Points = army1.Points + 75;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(75);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Primaris Chaplain");
                                            army1.Points = army1.Points + 85;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Primaris Librarian in Phobos Armour");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Primaris Lieutenant with Power Sword");
                                            army1.Points = army1.Points + 85;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(85);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Primaris Librarian");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Space Marines Chaplain");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(80);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Primaris Captain");
                                            army1.Points = army1.Points + 90;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Primaris Techmarine");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Captain in Phobos Armour");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(95);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Primaris Chaplain on Bike");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Space Marine Heroes");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Company Command");
                                            army1.Points = army1.Points + 100;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Heroes of the Chapter");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(120);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Space Marines: Honoured of the Chapter");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(120);
                                            hpl.Add(5);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Captain with Master-crafter Heavy Bolt Rifle");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Techmarine");
                                            army1.Points = army1.Points + 70;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Space Marine Captain: Lord Executioner");
                                            army1.Points = army1.Points + 100;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Chaplain with Jump Pack");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Space Marine Commander");
                                            army1.Points = army1.Points + 165;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(165);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Space Marine Captain");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Librarian in Terminator Armour");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Masters of the Chapter");
                                            army1.Points = army1.Points + 200;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(200);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Librarian");
                                            army1.Points = army1.Points + 90;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Primaris Lieutenant in Reiver Armour");
                                            army1.Points = army1.Points + 75;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(75);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Primaris Chaplain");
                                            army1.Points = army1.Points + 85;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Primaris Librarian in Phobos Armour");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Primaris Lieutenant with Power Sword");
                                            army1.Points = army1.Points + 85;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(85);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Primaris Librarian");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Space Marines Chaplain");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(80);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Primaris Captain");
                                            army1.Points = army1.Points + 90;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Primaris Techmarine");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Captain in Phobos Armour");
                                            army1.Points = army1.Points + 95;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(95);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Primaris Chaplain on Bike");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Space Marine Heroes");
                                            army1.Points = army1.Points + 115;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(115);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Company Command");
                                            army1.Points = army1.Points + 100;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Heroes of the Chapter");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(120);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Space Marines: Honoured of the Chapter");
                                            army1.Points = army1.Points + 120;
                                            army1.PL = army1.PL + 5;
                                            hqp.Add(120);
                                            hpl.Add(5);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                            }
                            if (army1.Faction == 3)
                            {
                                Console.WriteLine("1 - Valerian and Aleya");
                                Console.WriteLine("2 - Vexilus Praetor in Allarus Terminator Armour");
                                Console.WriteLine("3 - Shield-Captain in Allarus Terminator Armour");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if(hqs == 1)
                                        {
                                            hq.Add("Valerian and Aleya");
                                            army1.Points = army1.Points +  200;
                                            army1.PL = army1.PL + 10;
                                            hqp.Add(200);
                                            hpl.Add(10);
                                        }

                                        if (hqs == 2)
                                        {
                                            hq.Add("Vexilus Praetor in Allarus Terminator Armour");
                                            army1.Points = army1.Points +  110;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Shield-Captain in Allarus Terminator Armour");
                                            army1.Points = army1.Points +  110;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if(army1.detachment == 2)
                                {
                                    if(hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Valerian and Aleya");
                                            army1.Points = army1.Points + 200;
                                            army1.PL = army1.PL + 10;
                                            hqp.Add(200);
                                            hpl.Add(10);
                                        }

                                        if (hqs == 2)
                                        {
                                            hq.Add("Vexilus Praetor in Allarus Terminator Armour");
                                            army1.Points = army1.Points + 110;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Shield-Captain in Allarus Terminator Armour");
                                            army1.Points = army1.Points + 110;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if(army1.detachment == 3)
                                {
                                    if(hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Valerian and Aleya");
                                            army1.Points = army1.Points + 200;
                                            army1.PL = army1.PL + 10;
                                            hqp.Add(200);
                                            hpl.Add(10);
                                        }

                                        if (hqs == 2)
                                        {
                                            hq.Add("Vexilus Praetor in Allarus Terminator Armour");
                                            army1.Points = army1.Points + 110;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Shield-Captain in Allarus Terminator Armour");
                                            army1.Points = army1.Points + 110;
                                            army1.PL = army1.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                            }
                            if (army1.Faction == 4)
                            {
                                Console.WriteLine("1 - Skitarii Marshal");
                                Console.WriteLine("2 - Tech-Priest Manipulus");
                                Console.WriteLine("3 - Tech-Priest Dominus");
                                Console.WriteLine("4 - Tech-Priest Enginseer");
                                Console.WriteLine("5 - Belisarius Cawl");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army1.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if(hqs == 1)
                                        {
                                            hq.Add("Skitarii Marshal");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Tech-Priest Manipulus");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Tech-Priest Dominus");
                                            army1.Points = army1.Points + 75;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Belisarius Cawl");
                                            army1.Points = army1.Points + 180;
                                            army1.PL = army1.PL + 9;
                                            hqp.Add(180);
                                            hpl.Add(9);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Skitarii Marshal");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Tech-Priest Manipulus");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Tech-Priest Dominus");
                                            army1.Points = army1.Points + 75;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Belisarius Cawl");
                                            army1.Points = army1.Points + 180;
                                            army1.PL = army1.PL + 9;
                                            hqp.Add(180);
                                            hpl.Add(9);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Skitarii Marshal");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Tech-Priest Manipulus");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Tech-Priest Dominus");
                                            army1.Points = army1.Points + 75;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Belisarius Cawl");
                                            army1.Points = army1.Points + 180;
                                            army1.PL = army1.PL + 9;
                                            hqp.Add(180);
                                            hpl.Add(9);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                            }
                            if (army1.Faction == 5)
                            { 
                                Console.WriteLine("1 - Commisar Yarrik");
                                Console.WriteLine("2 - Company Commander");
                                Console.WriteLine("3 - Primaris Psyker");
                                Console.WriteLine("4 - Tank Commander");
                                Console.WriteLine("5 - Colonel 'Iron Hand' Straken");
                                Console.WriteLine("6 - Lord Castellan Creed");
                                Console.WriteLine("7 - Tech-Priest Enginseer");
                                Console.WriteLine("8 - Gaunt's Ghosts");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if(hqs == 1)
                                        {
                                            hq.Add("Commisar Yarrik");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(105);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Company Commander");
                                            army1.Points = army1.Points + 35;
                                            army1.PL = army1.PL + 2;
                                            hqp.Add(35);
                                            hpl.Add(2);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Primaris Psyker");
                                            army1.Points = army1.Points + 50;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tank Commander");
                                            army1.Points = army1.Points + 195;
                                            army1.PL = army1.PL + 12;
                                            hqp.Add(195);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Colonel 'Iron Hand' Straken");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Lord Castellan Creed");
                                            army1.Points = army1.Points + 60;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Gaunt's Ghost");
                                            army1.Points = army1.Points + 135;
                                            army1.PL = army1.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Commisar Yarrik");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(105);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Company Commander");
                                            army1.Points = army1.Points + 35;
                                            army1.PL = army1.PL + 2;
                                            hqp.Add(35);
                                            hpl.Add(2);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Primaris Psyker");
                                            army1.Points = army1.Points + 50;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tank Commander");
                                            army1.Points = army1.Points + 195;
                                            army1.PL = army1.PL + 12;
                                            hqp.Add(195);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Colonel 'Iron Hand' Straken");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Lord Castellan Creed");
                                            army1.Points = army1.Points + 60;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Gaunt's Ghost");
                                            army1.Points = army1.Points + 135;
                                            army1.PL = army1.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Commisar Yarrik");
                                            army1.Points = army1.Points + 105;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(105);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Company Commander");
                                            army1.Points = army1.Points + 35;
                                            army1.PL = army1.PL + 2;
                                            hqp.Add(35);
                                            hpl.Add(2);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Primaris Psyker");
                                            army1.Points = army1.Points + 50;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tank Commander");
                                            army1.Points = army1.Points + 195;
                                            army1.PL = army1.PL + 12;
                                            hqp.Add(195);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Colonel 'Iron Hand' Straken");
                                            army1.Points = army1.Points + 80;
                                            army1.PL = army1.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Lord Castellan Creed");
                                            army1.Points = army1.Points + 60;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Gaunt's Ghost");
                                            army1.Points = army1.Points + 135;
                                            army1.PL = army1.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("There are too many HQs in your list");
                                        break;
                                    }
                                }
                            }
                        }
                        if (choice == 2)
                        {
                            if(army2.Faction == 1)
                            {
                                Console.WriteLine("1 - Lord of Change");
                                Console.WriteLine("2 - Great Unclean One");
                                Console.WriteLine("3 - Keeper of Secrets");
                                Console.WriteLine("4 - Daemons of Khrne Bloodthirster");
                                Console.WriteLine("5 - Kairos Fateweaver");
                                Console.WriteLine("6 - Herald of Slaanesh");
                                Console.WriteLine("7 - Bloodmaster, Herald of Khorne");
                                Console.WriteLine("8 - Poxbringer");
                                Console.WriteLine("9 - The Masque");
                                Console.WriteLine("10 - Sloppity Bilepiper");
                                Console.WriteLine("11 - Spoilpox Scrivener");
                                Console.WriteLine("12 - The Changeling");
                                Console.WriteLine("13 - Skulltaker");
                                Console.WriteLine("14 - The Blue Scribes");
                                Console.WriteLine("15 - Fluxmaster, Herald of Tzeentch");
                                Console.WriteLine("16 - Daemons of Khorne Bloodthrone");
                                Console.WriteLine("17 - Herald of Khorne on Juggernaut");
                                Console.WriteLine("18 - Fateskimmer, Herald of Tzeentch on Burning Chariot");
                                Console.WriteLine("19 - Daemon Prince");
                                Console.WriteLine("20 - Epidemius");
                                Console.WriteLine("21 - Syll'Esske: The Vengeful Allegiance");
                                Console.WriteLine("22 - Horticulous Slimux");
                                Console.WriteLine("23 - Skarbrand");
                                Console.WriteLine("24 - Rotigus");
                                Console.WriteLine("25 - Karanak, The Hound of Vengeance");
                                Console.WriteLine("26 - Infernal Enrapuress");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if(army2.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if(hqs == 1)
                                        {
                                            hq.Add("Lord of Change");
                                            army2.Points = army2.Points + 290;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(290);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Great Unclean One");
                                            army2.Points = army2.Points + 260;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(260);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Keeper of Secrets");
                                            army2.Points = army2.Points + 230;
                                            army2.PL = army2.PL + 12;
                                            hqp.Add(230);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Daemons of Khrne Bloodthirster");
                                            army2.Points = army2.Points + 250;
                                            army2.PL = army2.PL + 13;
                                            hqp.Add(250);
                                            hpl.Add(13);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Kairos Fateweaver");
                                            army2.Points = army2.Points + 270;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(270);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Herald of Slaanesh");
                                            army2.Points = army2.Points + 55;
                                            army2.PL = army2.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Bloodmaster, Herald of Khorne");
                                            army2.Points = army2.Points + 60;
                                            army2.PL = army2.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Poxbringer");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("The Masque");
                                            army2.Points = army2.Points + 85;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Sloppity Bilepiper");
                                            army2.Points = army2.Points + 65;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Spoilpox Scrivener");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("The Changeling");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Skulltaker");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("The Blue Scribes");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Fluxmaster, Herald of Tzeentch");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Daemons of Khorne Bloodthrone");
                                            army2.Points = army2.Points + 115;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Herald of Khorne on Juggernaut");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 10;
                                            hqp.Add(105);
                                            hpl.Add(10);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Fateskimmer, Herald of Tzeentch on Burning Chariot");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 9;
                                            hqp.Add(160);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Epidemius");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Syll'Esske: The Vengeful Allegiance");
                                            army2.Points = army2.Points + 230;
                                            army2.PL = army2.PL + 12;
                                            hqp.Add(230);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Horticulous Slimux");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Skarbrand");
                                            army2.Points = army2.Points + 310;
                                            army2.PL = army2.PL + 16;
                                            hqp.Add(310);
                                            hpl.Add(16);
                                        }
                                        if (hqs == 24)
                                        {
                                            hq.Add("Rotigus");
                                            army2.Points = army2.Points + 270;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(270);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 25)
                                        {
                                            hq.Add("Karanak, The Hound of Vengeance");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 26)
                                        {
                                            hq.Add("Infernal Enrapuress");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if(hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Lord of Change");
                                            army2.Points = army2.Points + 290;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(290);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Great Unclean One");
                                            army2.Points = army2.Points + 260;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(260);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Keeper of Secrets");
                                            army2.Points = army2.Points + 230;
                                            army2.PL = army2.PL + 12;
                                            hqp.Add(230);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Daemons of Khrne Bloodthirster");
                                            army2.Points = army2.Points + 250;
                                            army2.PL = army2.PL + 13;
                                            hqp.Add(250);
                                            hpl.Add(13);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Kairos Fateweaver");
                                            army2.Points = army2.Points + 270;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(270);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Herald of Slaanesh");
                                            army2.Points = army2.Points + 55;
                                            army2.PL = army2.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Bloodmaster, Herald of Khorne");
                                            army2.Points = army2.Points + 60;
                                            army2.PL = army2.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Poxbringer");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("The Masque");
                                            army2.Points = army2.Points + 85;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Sloppity Bilepiper");
                                            army2.Points = army2.Points + 65;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Spoilpox Scrivener");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("The Changeling");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Skulltaker");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("The Blue Scribes");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Fluxmaster, Herald of Tzeentch");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Daemons of Khorne Bloodthrone");
                                            army2.Points = army2.Points + 115;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Herald of Khorne on Juggernaut");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 10;
                                            hqp.Add(105);
                                            hpl.Add(10);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Fateskimmer, Herald of Tzeentch on Burning Chariot");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 9;
                                            hqp.Add(160);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Epidemius");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Syll'Esske: The Vengeful Allegiance");
                                            army2.Points = army2.Points + 230;
                                            army2.PL = army2.PL + 12;
                                            hqp.Add(230);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Horticulous Slimux");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Skarbrand");
                                            army2.Points = army2.Points + 310;
                                            army2.PL = army2.PL + 16;
                                            hqp.Add(310);
                                            hpl.Add(16);
                                        }
                                        if (hqs == 24)
                                        {
                                            hq.Add("Rotigus");
                                            army2.Points = army2.Points + 270;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(270);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 25)
                                        {
                                            hq.Add("Karanak, The Hound of Vengeance");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 26)
                                        {
                                            hq.Add("Infernal Enrapuress");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if(hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Lord of Change");
                                            army2.Points = army2.Points + 290;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(290);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Great Unclean One");
                                            army2.Points = army2.Points + 260;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(260);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Keeper of Secrets");
                                            army2.Points = army2.Points + 230;
                                            army2.PL = army2.PL + 12;
                                            hqp.Add(230);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Daemons of Khrne Bloodthirster");
                                            army2.Points = army2.Points + 250;
                                            army2.PL = army2.PL + 13;
                                            hqp.Add(250);
                                            hpl.Add(13);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Kairos Fateweaver");
                                            army2.Points = army2.Points + 270;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(270);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Herald of Slaanesh");
                                            army2.Points = army2.Points + 55;
                                            army2.PL = army2.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Bloodmaster, Herald of Khorne");
                                            army2.Points = army2.Points + 60;
                                            army2.PL = army2.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Poxbringer");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("The Masque");
                                            army2.Points = army2.Points + 85;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Sloppity Bilepiper");
                                            army2.Points = army2.Points + 65;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Spoilpox Scrivener");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("The Changeling");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Skulltaker");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("The Blue Scribes");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Fluxmaster, Herald of Tzeentch");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Daemons of Khorne Bloodthrone");
                                            army2.Points = army2.Points + 115;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Herald of Khorne on Juggernaut");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 10;
                                            hqp.Add(105);
                                            hpl.Add(10);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Fateskimmer, Herald of Tzeentch on Burning Chariot");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 9;
                                            hqp.Add(160);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Epidemius");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Syll'Esske: The Vengeful Allegiance");
                                            army2.Points = army2.Points + 230;
                                            army2.PL = army2.PL + 12;
                                            hqp.Add(230);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Horticulous Slimux");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Skarbrand");
                                            army2.Points = army2.Points + 310;
                                            army2.PL = army2.PL + 16;
                                            hqp.Add(310);
                                            hpl.Add(16);
                                        }
                                        if (hqs == 24)
                                        {
                                            hq.Add("Rotigus");
                                            army2.Points = army2.Points + 270;
                                            army2.PL = army2.PL + 14;
                                            hqp.Add(270);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 25)
                                        {
                                            hq.Add("Karanak, The Hound of Vengeance");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 26)
                                        {
                                            hq.Add("Infernal Enrapuress");
                                            army2.Points = army2.Points + 75;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                            }
                            if(army2.Faction == 2)
                            {
                                Console.WriteLine("1 - Lord Felthius");
                                Console.WriteLine("2 - Lord of Virulence");
                                Console.WriteLine("3 - Daemon Prince");
                                Console.WriteLine("4 - Typhus - Herald of the Plague God");
                                Console.WriteLine("5 - Nurgle Daemon Prince");
                                Console.WriteLine("6 - Chaos Space Marines Terminator Lord");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army2.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if(hqs == 1)
                                        {
                                            hq.Add("Lord Felthius");
                                            army2.Points = army2.Points + 120;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Lord of Virulence");
                                            army2.Points = army2.Points + 120;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Typhus - Herald of the Plague God");
                                            army2.Points = army2.Points + 165;
                                            army2.PL = army2.PL + 9;
                                            hqp.Add(165);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Nurgle Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Chaos Space Marines Terminator Lord");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Lord Felthius");
                                            army2.Points = army2.Points + 120;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Lord of Virulence");
                                            army2.Points = army2.Points + 120;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Typhus - Herald of the Plague God");
                                            army2.Points = army2.Points + 165;
                                            army2.PL = army2.PL + 9;
                                            hqp.Add(165);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Nurgle Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Chaos Space Marines Terminator Lord");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Lord Felthius");
                                            army2.Points = army2.Points + 120;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Lord of Virulence");
                                            army2.Points = army2.Points + 120;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Typhus - Herald of the Plague God");
                                            army2.Points = army2.Points + 165;
                                            army2.PL = army2.PL + 9;
                                            hqp.Add(165);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Nurgle Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Chaos Space Marines Terminator Lord");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                    }
                                }
                            }
                            if(army2.Faction == 3)
                            {
                                Console.WriteLine("1 - Abaddon the Despoiler");
                                Console.WriteLine("2 - Fabius Bile");
                                Console.WriteLine("3 - Chaos Space Marines Sorcerer");
                                Console.WriteLine("4 - Dark Apostle");
                                Console.WriteLine("5 - Vex Machinaotr, Arch-Lord Discordant");
                                Console.WriteLine("6 - Night Lords Chaos Lord");
                                Console.WriteLine("7 - Chaos Lord with Jump Pack");
                                Console.WriteLine("8 - Emperor's Children Lucius The Eternal");
                                Console.WriteLine("9 - Red Corsairs Huron Blackheart");
                                Console.WriteLine("10 - Chaos Space Marines Terminator Lord");
                                Console.WriteLine("11 - Warpsmith");
                                Console.WriteLine("12 - Sorcerer Lord in Terminator Armour");
                                Console.WriteLine("13 - Chaos Lord");
                                Console.WriteLine("14 - Master of Executions");
                                Console.WriteLine("15 - World Eaters Khârn the Betrayer");
                                Console.WriteLine("16 - Cypher");
                                Console.WriteLine("17 - Haarken Worldclaimer, Herald of the Apocalypse");
                                Console.WriteLine("18 - Nurgle Daemon Prince");
                                Console.WriteLine("19 - Daemon Prince");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army2.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if(hqs == 1)
                                        {
                                            hq.Add("Abaddon the Despoiler");
                                            army2.Points = army2.Points + 220;
                                            army2.PL = army2.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Fabius Bile");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Chaos Space Marines Sorcerer");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Dark Apostle");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Vex Machinaotr, Arch-Lord Discordant");
                                            army2.Points = army2.Points + 195;
                                            army2.PL = army2.PL + 10;
                                            hqp.Add(195);
                                            hpl.Add(10);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Night Lords Chaos Lord");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Chaos Lord with Jump Pack");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Emperor's Children Lucius The Eternal");
                                            army2.Points = army2.Points + 95;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Red Corsairs Huron Blackheart");
                                            army2.Points = army2.Points + 110;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Chaos Space Marines Terminator Lord");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Warpsmith");
                                            army2.Points = army2.Points + 70;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Sorcerer Lord in Terminator Armour");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Chaos Lord");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Master of Executions");
                                            army2.Points = army2.Points + 65;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("World Eaters Khârn the Betrayer");
                                            army2.Points = army2.Points + 115;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Cypher");
                                            army2.Points = army2.Points + 85;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Haarken Worldclaimer, Herald of the Apocalypse");
                                            army2.Points = army2.Points + 95;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Nurgle Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Abaddon the Despoiler");
                                            army2.Points = army2.Points + 220;
                                            army2.PL = army2.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Fabius Bile");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Chaos Space Marines Sorcerer");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Dark Apostle");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Vex Machinaotr, Arch-Lord Discordant");
                                            army2.Points = army2.Points + 195;
                                            army2.PL = army2.PL + 10;
                                            hqp.Add(195);
                                            hpl.Add(10);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Night Lords Chaos Lord");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Chaos Lord with Jump Pack");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Emperor's Children Lucius The Eternal");
                                            army2.Points = army2.Points + 95;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Red Corsairs Huron Blackheart");
                                            army2.Points = army2.Points + 110;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Chaos Space Marines Terminator Lord");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Warpsmith");
                                            army2.Points = army2.Points + 70;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Sorcerer Lord in Terminator Armour");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Chaos Lord");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Master of Executions");
                                            army2.Points = army2.Points + 65;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("World Eaters Khârn the Betrayer");
                                            army2.Points = army2.Points + 115;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Cypher");
                                            army2.Points = army2.Points + 85;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Haarken Worldclaimer, Herald of the Apocalypse");
                                            army2.Points = army2.Points + 95;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Nurgle Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Abaddon the Despoiler");
                                            army2.Points = army2.Points + 220;
                                            army2.PL = army2.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Fabius Bile");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Chaos Space Marines Sorcerer");
                                            army2.Points = army2.Points + 90;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Dark Apostle");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Vex Machinaotr, Arch-Lord Discordant");
                                            army2.Points = army2.Points + 195;
                                            army2.PL = army2.PL + 10;
                                            hqp.Add(195);
                                            hpl.Add(10);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Night Lords Chaos Lord");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Chaos Lord with Jump Pack");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Emperor's Children Lucius The Eternal");
                                            army2.Points = army2.Points + 95;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Red Corsairs Huron Blackheart");
                                            army2.Points = army2.Points + 110;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Chaos Space Marines Terminator Lord");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Warpsmith");
                                            army2.Points = army2.Points + 70;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Sorcerer Lord in Terminator Armour");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Chaos Lord");
                                            army2.Points = army2.Points + 80;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(80);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Master of Executions");
                                            army2.Points = army2.Points + 65;
                                            army2.PL = army2.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("World Eaters Khârn the Betrayer");
                                            army2.Points = army2.Points + 115;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Cypher");
                                            army2.Points = army2.Points + 85;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Haarken Worldclaimer, Herald of the Apocalypse");
                                            army2.Points = army2.Points + 95;
                                            army2.PL = army2.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Nurgle Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                            }
                            if(army2.Faction == 4)
                            {
                                Console.WriteLine("1 - Ahriman");
                                Console.WriteLine("2 - Exalted Sorcerers");
                                Console.WriteLine("3 - Sorcerer Lord in Terminator Armour");
                                Console.WriteLine("4 - Daemon Prince");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army2.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if(hqs == 1)
                                        {
                                            hq.Add("Ahriman");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Exalted Sorcerers");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Sorcerer Lord in Terminator Armour");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Ahriman");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Exalted Sorcerers");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Sorcerer Lord in Terminator Armour");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Ahriman");
                                            army2.Points = army2.Points + 160;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Exalted Sorcerers");
                                            army2.Points = army2.Points + 100;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Sorcerer Lord in Terminator Armour");
                                            army2.Points = army2.Points + 105;
                                            army2.PL = army2.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Daemon Prince");
                                            army2.Points = army2.Points + 150;
                                            army2.PL = army2.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                            }
                        }
                        if (choice == 3)
                        {
                            if (army3.Faction == 1)
                            {
                                Console.WriteLine("1 - Jain Zar");
                                Console.WriteLine("2 - Spiritseer");
                                Console.WriteLine("3 - Farseer");
                                Console.WriteLine("4 - Autarch");
                                Console.WriteLine("5 - Avatar of Khaine");
                                Console.WriteLine("6 - Warlock Skyrunner");
                                Console.WriteLine("7 - Eldar Farseer Skyrunner");
                                Console.WriteLine("8 - Eldrad Ulthran");
                                Console.WriteLine("9 - Farseer and Warlocks");
                                Console.WriteLine("10 - Autarch Skyrunner");
                                Console.WriteLine("11 - Phoenix Lord Baharroth");
                                Console.WriteLine("12 - Phoenix Lord Fuegan");
                                Console.WriteLine("13 - Prince Yriel");
                                Console.WriteLine("14 - Illic Nightspear");
                                Console.WriteLine("15 - Phoenix Lord Maugan Ra");
                                Console.WriteLine("16 - Phoenix Lord Karandras");
                                Console.WriteLine("17 - Phoenix Lord Asurmen");
                                Console.WriteLine("18 - Warlock with Witch Blade and Shuriken Pistol");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Jain Zar");
                                            army3.Points = army3.Points + 125;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(125);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Spiritseer");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Farseer");
                                            army3.Points = army3.Points + 115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Autarch");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Avatar of Khaine");
                                            army3.Points = army3.Points + 200;
                                            army3.PL = army3.PL + 12;
                                            hqp.Add(200);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Warlock Skyrunner");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Eldar Farseer Skyrunner");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Eldrad Ulthran");
                                            army3.Points = army3.Points + 155;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(155);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Farseer and Warlocks");
                                            army3.Points = army3.Points + 235;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(235);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Autarch Skyrunner");
                                            army3.Points = army3.Points + 105;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Phoenix Lord Baharroth");
                                            army3.Points = army3.Points + 120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Phoenix Lord Fuegan");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Prince Yriel");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Illic Nightspear");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Phoenix Lord Maugan Ra");
                                            army3.Points = army3.Points + 150;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Phoenix Lord Karandras");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Phoenix Lord Asurmen");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Warlock with Witch Blade and Shuriken Pistol");
                                            army3.Points = army3.Points + 50;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Jain Zar");
                                            army3.Points = army3.Points + 125;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(125);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Spiritseer");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Farseer");
                                            army3.Points = army3.Points + 115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Autarch");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Avatar of Khaine");
                                            army3.Points = army3.Points + 200;
                                            army3.PL = army3.PL + 12;
                                            hqp.Add(200);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Warlock Skyrunner");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Eldar Farseer Skyrunner");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Eldrad Ulthran");
                                            army3.Points = army3.Points + 155;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(155);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Farseer and Warlocks");
                                            army3.Points = army3.Points + 235;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(235);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Autarch Skyrunner");
                                            army3.Points = army3.Points + 105;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Phoenix Lord Baharroth");
                                            army3.Points = army3.Points + 120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Phoenix Lord Fuegan");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Prince Yriel");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Illic Nightspear");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Phoenix Lord Maugan Ra");
                                            army3.Points = army3.Points + 150;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Phoenix Lord Karandras");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Phoenix Lord Asurmen");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Warlock with Witch Blade and Shuriken Pistol");
                                            army3.Points = army3.Points + 50;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Jain Zar");
                                            army3.Points = army3.Points + 125;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(125);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Spiritseer");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Farseer");
                                            army3.Points = army3.Points + 115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Autarch");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Avatar of Khaine");
                                            army3.Points = army3.Points + 200;
                                            army3.PL = army3.PL + 12;
                                            hqp.Add(200);
                                            hpl.Add(12);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Warlock Skyrunner");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Eldar Farseer Skyrunner");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Eldrad Ulthran");
                                            army3.Points = army3.Points + 155;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(155);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Farseer and Warlocks");
                                            army3.Points = army3.Points + 235;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(235);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Autarch Skyrunner");
                                            army3.Points = army3.Points + 105;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Phoenix Lord Baharroth");
                                            army3.Points = army3.Points + 120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Phoenix Lord Fuegan");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Prince Yriel");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Illic Nightspear");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Phoenix Lord Maugan Ra");
                                            army3.Points = army3.Points + 150;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(150);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Phoenix Lord Karandras");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Phoenix Lord Asurmen");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Warlock with Witch Blade and Shuriken Pistol");
                                            army3.Points = army3.Points + 50;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 2)
                            {
                                Console.WriteLine("1 - Lelith Hesperax");
                                Console.WriteLine("2 - Drazhar");
                                Console.WriteLine("3 - Succbus");
                                Console.WriteLine("4 - Urien Rakarth");
                                Console.WriteLine("5 - Haemonculus");
                                Console.WriteLine("6 - Archon");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Lelith Hesperax");
                                            army3.Points = army3.Points +  90;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Drazhar");
                                            army3.Points = army3.Points +  145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Succbus");
                                            army3.Points = army3.Points +  80;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(80);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Urien Rakarth");
                                            army3.Points = army3.Points +  100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Haemonculus");
                                            army3.Points = army3.Points +  70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Archon");
                                            army3.Points = army3.Points +  75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Lelith Hesperax");
                                            army3.Points = army3.Points + 90;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Drazhar");
                                            army3.Points = army3.Points + 145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Succbus");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(80);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Urien Rakarth");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Haemonculus");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Archon");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Lelith Hesperax");
                                            army3.Points = army3.Points + 90;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Drazhar");
                                            army3.Points = army3.Points + 145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Succbus");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(80);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Urien Rakarth");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Haemonculus");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Archon");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 3)
                            {
                                Console.WriteLine("1 - Jackal Alphus");
                                Console.WriteLine("2 - Abominant");
                                Console.WriteLine("3 - Magus");
                                Console.WriteLine("4 - Acolyte Iconward");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Jackal Alphus");
                                            army3.Points = army3.Points +  75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Abominant");
                                            army3.Points = army3.Points +  110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Magus");
                                            army3.Points = army3.Points +  85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Acolyte Iconward");
                                            army3.Points = army3.Points +  60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Jackal Alphus");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Abominant");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Magus");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Acolyte Iconward");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 5)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Jackal Alphus");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Abominant");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Magus");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Acolyte Iconward");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 4)
                            {
                                Console.WriteLine("1 - Shadowseer");
                                Console.WriteLine("2 - Troupe Master");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Shadowseer");
                                            army3.Points = army3.Points +  115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Troupe Master");
                                            army3.Points = army3.Points +  65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Shadowseer");
                                            army3.Points = army3.Points + 115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Troupe Master");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Shadowseer");
                                            army3.Points = army3.Points + 115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Troupe Master");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 5)
                            {
                                Console.WriteLine("1 - Chronomancer");
                                Console.WriteLine("2 - Necron Catacomb Command Barge");
                                Console.WriteLine("3 - Necron Destroyer Lord");
                                Console.WriteLine("4 - Vargard Obyron");
                                Console.WriteLine("5 - Necron Lord with Resurrection Orb");
                                Console.WriteLine("6 - Cryptek");
                                Console.WriteLine("7 - Anrakyr the Traveller");
                                Console.WriteLine("8 - Imotekh the Stormlord");
                                Console.WriteLine("9 - Necron Overlord with Warscythe");
                                Console.WriteLine("10 - Orikan the Diviner");
                                Console.WriteLine("11 - Nemesor Zahndrekh");
                                Console.WriteLine("12 - Trazyn the Infinite");
                                Console.WriteLine("13 - Overlord");
                                Console.WriteLine("14 - Technomancer");
                                Console.WriteLine("15 - Psychomancer");
                                Console.WriteLine("16 - Illuminor Szeras");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Chronomancer");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Necron Catacomb Command Barge");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(160);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Necron Destroyer Lord");
                                            army3.Points = army3.Points + 105;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(105);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Vargard Obyron");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Necron Lord with Resurrection Orb");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Cryptek");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Anrakyr the Traveller");
                                            army3.Points = army3.Points + 140;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(140);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Imotekh the Stormlord");
                                            army3.Points = army3.Points + 145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Necron Overlord with Warscythe");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Orikan the Diviner");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Nemesor Zahndrekh");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Trazyn the Infinite");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Overlord");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Technomancer");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Psychomancer");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Illuminor Szeras");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Chronomancer");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Necron Catacomb Command Barge");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(160);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Necron Destroyer Lord");
                                            army3.Points = army3.Points + 105;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(105);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Vargard Obyron");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Necron Lord with Resurrection Orb");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Cryptek");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Anrakyr the Traveller");
                                            army3.Points = army3.Points + 140;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(140);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Imotekh the Stormlord");
                                            army3.Points = army3.Points + 145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Necron Overlord with Warscythe");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Orikan the Diviner");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Nemesor Zahndrekh");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Trazyn the Infinite");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Overlord");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Technomancer");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Psychomancer");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Illuminor Szeras");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Chronomancer");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Necron Catacomb Command Barge");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(160);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Necron Destroyer Lord");
                                            army3.Points = army3.Points + 105;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(105);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Vargard Obyron");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Necron Lord with Resurrection Orb");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Cryptek");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Anrakyr the Traveller");
                                            army3.Points = army3.Points + 140;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(140);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Imotekh the Stormlord");
                                            army3.Points = army3.Points + 145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Necron Overlord with Warscythe");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Orikan the Diviner");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Nemesor Zahndrekh");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(135);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Trazyn the Infinite");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(100);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Overlord");
                                            army3.Points = army3.Points + 100;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(100);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Technomancer");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Psychomancer");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Illuminor Szeras");
                                            army3.Points = army3.Points + 160;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(160);
                                            hpl.Add(8);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 6)
                            {
                                Console.WriteLine("1 - Da Red Gobbo and Bounca");
                                Console.WriteLine("2 - Mozrog Skragbad");
                                Console.WriteLine("3 - Panboss");
                                Console.WriteLine("4 - Zodgrod Wortsnagga");
                                Console.WriteLine("5 - Beastboss");
                                Console.WriteLine("6 - Big Mek with Kustom Force Field");
                                Console.WriteLine("7 - Ork Boss Zagstruk");
                                Console.WriteLine("8 - Kaptin Badrukk");
                                Console.WriteLine("9 - Ork Boss Snikrot");
                                Console.WriteLine("10 - Weirdboy");
                                Console.WriteLine("11 - Ork Warboss with Big Choppa");
                                Console.WriteLine("12 - Big Mek with Shokk Attac Gun");
                                Console.WriteLine("13 - Beastboss on Squigosaur");
                                Console.WriteLine("14 - Deffkilla Wartrike");
                                Console.WriteLine("15 - Big Mek in Mega Armour");
                                Console.WriteLine("16 - Ghazghkull Thraka");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Da Red Gobbo and Bounca");
                                            army3.Points = army3.Points +  80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Mozrog Skragbad");
                                            army3.Points = army3.Points +  170;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(170);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Panboss");
                                            army3.Points = army3.Points +  80;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(80);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Zodgrod Wortsnagga");
                                            army3.Points = army3.Points +  65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Beastboss");
                                            army3.Points = army3.Points +  95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Big Mek with Kustom Force Field");
                                            army3.Points = army3.Points +  85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Ork Boss Zagstruk");
                                            army3.Points = army3.Points +  110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Kaptin Badrukk");
                                            army3.Points = army3.Points +  95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Ork Boss Snikrot");
                                            army3.Points = army3.Points +  95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Weirdboy");
                                            army3.Points = army3.Points +  70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Ork Warboss with Big Choppa");
                                            army3.Points = army3.Points +  90;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Big Mek with Shokk Attac Gun");
                                            army3.Points = army3.Points +  110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Beastboss on Squigosaur");
                                            army3.Points = army3.Points +  145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Deffkilla Wartrike");
                                            army3.Points = army3.Points +  120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Big Mek in Mega Armour");
                                            army3.Points = army3.Points +  85;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(85);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Ghazghkull Thraka");
                                            army3.Points = army3.Points +  300;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(300);
                                            hpl.Add(15);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Da Red Gobbo and Bounca");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Mozrog Skragbad");
                                            army3.Points = army3.Points + 170;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(170);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Panboss");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(80);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Zodgrod Wortsnagga");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Beastboss");
                                            army3.Points = army3.Points + 95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Big Mek with Kustom Force Field");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Ork Boss Zagstruk");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Kaptin Badrukk");
                                            army3.Points = army3.Points + 95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Ork Boss Snikrot");
                                            army3.Points = army3.Points + 95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Weirdboy");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Ork Warboss with Big Choppa");
                                            army3.Points = army3.Points + 90;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Big Mek with Shokk Attac Gun");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Beastboss on Squigosaur");
                                            army3.Points = army3.Points + 145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Deffkilla Wartrike");
                                            army3.Points = army3.Points + 120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Big Mek in Mega Armour");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(85);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Ghazghkull Thraka");
                                            army3.Points = army3.Points + 300;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(300);
                                            hpl.Add(15);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Da Red Gobbo and Bounca");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Mozrog Skragbad");
                                            army3.Points = army3.Points + 170;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(170);
                                            hpl.Add(9);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Panboss");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(80);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Zodgrod Wortsnagga");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Beastboss");
                                            army3.Points = army3.Points + 95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Big Mek with Kustom Force Field");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Ork Boss Zagstruk");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Kaptin Badrukk");
                                            army3.Points = army3.Points + 95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Ork Boss Snikrot");
                                            army3.Points = army3.Points + 95;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(95);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Weirdboy");
                                            army3.Points = army3.Points + 70;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(70);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Ork Warboss with Big Choppa");
                                            army3.Points = army3.Points + 90;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(90);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Big Mek with Shokk Attac Gun");
                                            army3.Points = army3.Points + 110;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(110);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Beastboss on Squigosaur");
                                            army3.Points = army3.Points + 145;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(145);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Deffkilla Wartrike");
                                            army3.Points = army3.Points + 120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Big Mek in Mega Armour");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(85);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Ghazghkull Thraka");
                                            army3.Points = army3.Points + 300;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(300);
                                            hpl.Add(15);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 7)
                            {
                                Console.WriteLine("1 - Commander Shadowsun");
                                Console.WriteLine("2 - Commander Farsight");
                                Console.WriteLine("3 - T'au Empire Commander");
                                Console.WriteLine("4 - Aun'Va, Master of the Undying Spirit");
                                Console.WriteLine("5 - Cadre Fireblade");
                                Console.WriteLine("6 - Aun Shi T'au Ethereal");
                                Console.WriteLine("7 - Darkstrider");
                                Console.WriteLine("8 - Longstrike");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Commander Shadowsun");
                                            army3.Points = army3.Points +  155;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(155);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Commander Farsight");
                                            army3.Points = army3.Points +  130;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(130);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("T'au Empire Commander");
                                            army3.Points = army3.Points +  113;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(113);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Aun'Va, Master of the Undying Spirit");
                                            army3.Points = army3.Points +  85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Cadre Fireblade");
                                            army3.Points = army3.Points +  45;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Aun Shi T'au Ethereal");
                                            army3.Points = army3.Points +  55;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Darkstrider");
                                            army3.Points = army3.Points +  60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Longstrike");
                                            army3.Points = army3.Points +  205;
                                            army3.PL = army3.PL + 11;
                                            hqp.Add(205);
                                            hpl.Add(11);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Commander Shadowsun");
                                            army3.Points = army3.Points + 155;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(155);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Commander Farsight");
                                            army3.Points = army3.Points + 130;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(130);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("T'au Empire Commander");
                                            army3.Points = army3.Points + 113;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(113);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Aun'Va, Master of the Undying Spirit");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Cadre Fireblade");
                                            army3.Points = army3.Points + 45;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Aun Shi T'au Ethereal");
                                            army3.Points = army3.Points + 55;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Darkstrider");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Longstrike");
                                            army3.Points = army3.Points + 205;
                                            army3.PL = army3.PL + 11;
                                            hqp.Add(205);
                                            hpl.Add(11);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Commander Shadowsun");
                                            army3.Points = army3.Points + 155;
                                            army3.PL = army3.PL + 8;
                                            hqp.Add(155);
                                            hpl.Add(8);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Commander Farsight");
                                            army3.Points = army3.Points + 130;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(130);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("T'au Empire Commander");
                                            army3.Points = army3.Points + 113;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(113);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Aun'Va, Master of the Undying Spirit");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Cadre Fireblade");
                                            army3.Points = army3.Points + 45;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(45);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Aun Shi T'au Ethereal");
                                            army3.Points = army3.Points + 55;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(55);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Darkstrider");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Longstrike");
                                            army3.Points = army3.Points + 205;
                                            army3.PL = army3.PL + 11;
                                            hqp.Add(205);
                                            hpl.Add(11);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 8)
                            {
                                Console.WriteLine("1 - Broodlord");
                                Console.WriteLine("2 - The Swarmlord");
                                Console.WriteLine("3 - Old One Eye's Carnifex Brood");
                                Console.WriteLine("4 - Tyranids Hive Tyrant");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Broodlord");
                                            army3.Points = army3.Points +  125;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(125);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("The Swarmlord");
                                            army3.Points = army3.Points +  240;
                                            army3.PL = army3.PL + 14;
                                            hqp.Add(240);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Old One Eye's Carnifex Brood");
                                            army3.Points = army3.Points +  220;
                                            army3.PL = army3.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tyranids Hive Tyrant");
                                            army3.Points = army3.Points +  175;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(175);
                                            hpl.Add(9);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Broodlord");
                                            army3.Points = army3.Points + 125;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(125);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("The Swarmlord");
                                            army3.Points = army3.Points + 240;
                                            army3.PL = army3.PL + 14;
                                            hqp.Add(240);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Old One Eye's Carnifex Brood");
                                            army3.Points = army3.Points + 220;
                                            army3.PL = army3.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tyranids Hive Tyrant");
                                            army3.Points = army3.Points + 175;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(175);
                                            hpl.Add(9);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("Broodlord");
                                            army3.Points = army3.Points + 125;
                                            army3.PL = army3.PL + 7;
                                            hqp.Add(125);
                                            hpl.Add(7);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("The Swarmlord");
                                            army3.Points = army3.Points + 240;
                                            army3.PL = army3.PL + 14;
                                            hqp.Add(240);
                                            hpl.Add(14);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Old One Eye's Carnifex Brood");
                                            army3.Points = army3.Points + 220;
                                            army3.PL = army3.PL + 11;
                                            hqp.Add(220);
                                            hpl.Add(11);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tyranids Hive Tyrant");
                                            army3.Points = army3.Points + 175;
                                            army3.PL = army3.PL + 9;
                                            hqp.Add(175);
                                            hpl.Add(9);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 9)
                            {
                                Console.WriteLine("1 - The Yncarne, Avatar of Ynnead");
                                Console.WriteLine("2 - Yvraine, Emissary of Ynnead");
                                Console.WriteLine("3 - The Visarch, Sword of Ynnead");
                                Console.WriteLine("4 - Warlock with Wich Blade and Shuriken Pistol");
                                Console.WriteLine("5 - Succubus");
                                Console.WriteLine("6 - Autarch");
                                Console.WriteLine("7 - Farseer");
                                Console.WriteLine("8 - Archon");
                                Console.WriteLine("9 - Spiritseer");
                                Console.WriteLine("10 - Farseer and Warlocks");
                                Console.WriteLine("11 - Autarch Skyrunner");
                                Console.WriteLine("12 - Warlock Skyrunner");
                                Console.WriteLine("13 - Eldar Farseer Skyrunner");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (hq.Count < 2)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("The Yncarne, Avatar of Ynnead");
                                            army3.Points = army3.Points +  290;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(290);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Yvraine, Emissary of Ynnead");
                                            army3.Points = army3.Points +  120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("The Visarch, Sword of Ynnead");
                                            army3.Points = army3.Points +  85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Warlock with Wich Blade and Shuriken Pistol");
                                            army3.Points = army3.Points +  50;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Succubus");
                                            army3.Points = army3.Points +  80;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(80);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Autarch");
                                            army3.Points = army3.Points +  80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Farseer");
                                            army3.Points = army3.Points +  115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Archon");
                                            army3.Points = army3.Points +  75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Spiritseer");
                                            army3.Points = army3.Points +  60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Farseer and Warlocks");
                                            army3.Points = army3.Points +  235;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(235);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Autarch Skyrunner");
                                            army3.Points = army3.Points +  105;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Warlock Skyrunner");
                                            army3.Points = army3.Points +  65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Eldar Farseer Skyrunner");
                                            army3.Points = army3.Points +  135;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(135);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (hq.Count < 3)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("The Yncarne, Avatar of Ynnead");
                                            army3.Points = army3.Points + 290;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(290);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Yvraine, Emissary of Ynnead");
                                            army3.Points = army3.Points + 120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("The Visarch, Sword of Ynnead");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Warlock with Wich Blade and Shuriken Pistol");
                                            army3.Points = army3.Points + 50;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Succubus");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(80);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Autarch");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Farseer");
                                            army3.Points = army3.Points + 115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Archon");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Spiritseer");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Farseer and Warlocks");
                                            army3.Points = army3.Points + 235;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(235);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Autarch Skyrunner");
                                            army3.Points = army3.Points + 105;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Warlock Skyrunner");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Eldar Farseer Skyrunner");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(135);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (hq.Count < 5)
                                    {
                                        if (hqs == 1)
                                        {
                                            hq.Add("The Yncarne, Avatar of Ynnead");
                                            army3.Points = army3.Points + 290;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(290);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Yvraine, Emissary of Ynnead");
                                            army3.Points = army3.Points + 120;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(120);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("The Visarch, Sword of Ynnead");
                                            army3.Points = army3.Points + 85;
                                            army3.PL = army3.PL + 5;
                                            hqp.Add(85);
                                            hpl.Add(5);
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Warlock with Wich Blade and Shuriken Pistol");
                                            army3.Points = army3.Points + 50;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(50);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Succubus");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(80);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Autarch");
                                            army3.Points = army3.Points + 80;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(80);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Farseer");
                                            army3.Points = army3.Points + 115;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(115);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Archon");
                                            army3.Points = army3.Points + 75;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(75);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Spiritseer");
                                            army3.Points = army3.Points + 60;
                                            army3.PL = army3.PL + 3;
                                            hqp.Add(60);
                                            hpl.Add(3);
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Farseer and Warlocks");
                                            army3.Points = army3.Points + 235;
                                            army3.PL = army3.PL + 15;
                                            hqp.Add(235);
                                            hpl.Add(15);
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Autarch Skyrunner");
                                            army3.Points = army3.Points + 105;
                                            army3.PL = army3.PL + 6;
                                            hqp.Add(105);
                                            hpl.Add(6);
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Warlock Skyrunner");
                                            army3.Points = army3.Points + 65;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(65);
                                            hpl.Add(4);
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Eldar Farseer Skyrunner");
                                            army3.Points = army3.Points + 135;
                                            army3.PL = army3.PL + 4;
                                            hqp.Add(135);
                                            hpl.Add(4);
                                        }
                                    }
                                }
                            }
                        }
                        break;

                    case 2:
                        Console.Clear();
                        if(choice == 1)
                        {
                            if (army1.Faction == 1)
                            {
                                Console.WriteLine("1 - Battle Sister Squad\n");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if(troops == 1)
                                        {
                                            troop.Add("Battle Sister Squad");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            troopp.Add(55);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Battle Sister Squad");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            troopp.Add(55);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Battle Sister Squad");
                                            army1.Points = army1.Points + 55;
                                            army1.PL = army1.PL + 3;
                                            troopp.Add(55);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army1.Faction == 2)
                            {
                                Console.WriteLine("1 - Assault Intercessor Squad");
                                Console.WriteLine("2 - Heavy Intercessor Squad");
                                Console.WriteLine("3 - Inursor Squad");
                                Console.WriteLine("4 - Infiltrator Squad");
                                Console.WriteLine("5 - Intercessor Squad");
                                Console.WriteLine("6 - Tactical Squad");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if (army1.detachment == 1)
                                {
                                    if (troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Assault Intercessor Squad");
                                            army1.Points += 95;
                                            army1.PL += 5;
                                            troopp.Add(95);
                                            tpl.Add(5);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Heavy Intercessor Squad");
                                            army1.Points += 140;
                                            army1.PL += 7;
                                            troopp.Add(140);
                                            tpl.Add(7);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Inursor Squad");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            troopp.Add(105);
                                            tpl.Add(5);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Infiltrator Squad");
                                            army1.Points += 120;
                                            army1.PL += 6;
                                            troopp.Add(120);
                                            tpl.Add(6);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Intercessor Squad");
                                            army1.Points += 100;
                                            army1.PL += 5;
                                            troopp.Add(100);
                                            tpl.Add(5);
                                        }
                                        if (troops == 6)
                                        {
                                            troop.Add("Tactical Squad");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Assault Intercessor Squad");
                                            army1.Points += 95;
                                            army1.PL += 5;
                                            troopp.Add(95);
                                            tpl.Add(5);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Heavy Intercessor Squad");
                                            army1.Points += 140;
                                            army1.PL += 7;
                                            troopp.Add(140);
                                            tpl.Add(7);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Inursor Squad");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            troopp.Add(105);
                                            tpl.Add(5);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Infiltrator Squad");
                                            army1.Points += 120;
                                            army1.PL += 6;
                                            troopp.Add(120);
                                            tpl.Add(6);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Intercessor Squad");
                                            army1.Points += 100;
                                            army1.PL += 5;
                                            troopp.Add(100);
                                            tpl.Add(5);
                                        }
                                        if (troops == 6)
                                        {
                                            troop.Add("Tactical Squad");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Assault Intercessor Squad");
                                            army1.Points += 95;
                                            army1.PL += 5;
                                            troopp.Add(95);
                                            tpl.Add(5);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Heavy Intercessor Squad");
                                            army1.Points += 140;
                                            army1.PL += 7;
                                            troopp.Add(140);
                                            tpl.Add(7);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Inursor Squad");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            troopp.Add(105);
                                            tpl.Add(5);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Infiltrator Squad");
                                            army1.Points += 120;
                                            army1.PL += 6;
                                            troopp.Add(120);
                                            tpl.Add(6);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Intercessor Squad");
                                            army1.Points += 100;
                                            army1.PL += 5;
                                            troopp.Add(100);
                                            tpl.Add(5);
                                        }
                                        if (troops == 6)
                                        {
                                            troop.Add("Tactical Squad");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                            }
                            if (army1.Faction == 3)
                            {
                                Console.WriteLine("1 - Custodian Guard");
                                Console.WriteLine("2 - Sagittarum Custodians");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if(troops == 1)
                                        {
                                            troop.Add("Custodian Guard");
                                            army1.Points += 135;
                                            army1.PL += 7;
                                            troopp.Add(135);
                                            tpl.Add(7);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Sagittarum Custodians");
                                            army1.Points += 150;
                                            army1.PL += 7;
                                            troopp.Add(150);
                                            tpl.Add(7);
                                        }
                                    }    
                                }
                                if (army1.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Custodian Guard");
                                            army1.Points += 135;
                                            army1.PL += 7;
                                            troopp.Add(135);
                                            tpl.Add(7);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Sagittarum Custodians");
                                            army1.Points += 150;
                                            army1.PL += 7;
                                            troopp.Add(150);
                                            tpl.Add(7);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Custodian Guard");
                                            army1.Points += 135;
                                            army1.PL += 7;
                                            troopp.Add(135);
                                            tpl.Add(7);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Sagittarum Custodians");
                                            army1.Points += 150;
                                            army1.PL += 7;
                                            troopp.Add(150);
                                            tpl.Add(7);
                                        }
                                    }
                                }
                            }
                            if (army1.Faction == 4)
                            {
                                Console.WriteLine("1 - Skitarii Rangers");
                                Console.WriteLine("2 - Kataphron Breachers");
                                Console.WriteLine("3 - Skitarii Vanguard");
                                Console.WriteLine("4 - Kataphron Destroyers");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Skitarii Rangers");
                                            army1.Points += 45;
                                            army1.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Kataphron Breachers");
                                            army1.Points += 105;
                                            army1.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Skitarii Vanguard");
                                            army1.Points += 45;
                                            army1.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Kataphron Destroyers");
                                            army1.Points += 120;
                                            army1.PL += 7;
                                            troopp.Add(120);
                                            tpl.Add(7);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Skitarii Rangers");
                                            army1.Points += 45;
                                            army1.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Kataphron Breachers");
                                            army1.Points += 105;
                                            army1.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Skitarii Vanguard");
                                            army1.Points += 45;
                                            army1.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Kataphron Destroyers");
                                            army1.Points += 120;
                                            army1.PL += 7;
                                            troopp.Add(120);
                                            tpl.Add(7);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Skitarii Rangers");
                                            army1.Points += 45;
                                            army1.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Kataphron Breachers");
                                            army1.Points += 105;
                                            army1.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Skitarii Vanguard");
                                            army1.Points += 45;
                                            army1.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Kataphron Destroyers");
                                            army1.Points += 120;
                                            army1.PL += 7;
                                            troopp.Add(120);
                                            tpl.Add(7);
                                        }
                                    }
                                }
                            }
                            if (army1.Faction == 5)
                            {
                                Console.WriteLine("1 - Conscripts");
                                Console.WriteLine("2 - Infantry Squad");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if (army1.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Conscrips");
                                            army1.Points += 100;
                                            army1.PL += 5;
                                            troopp.Add(100);
                                            tpl.Add(5);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Infantry Squad");
                                            army1.Points += 55;
                                            army1.PL += 3;
                                            troopp.Add(55);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Conscrips");
                                            army1.Points += 100;
                                            army1.PL += 5;
                                            troopp.Add(100);
                                            tpl.Add(5);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Infantry Squad");
                                            army1.Points += 55;
                                            army1.PL += 3;
                                            troopp.Add(55);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Conscrips");
                                            army1.Points += 100;
                                            army1.PL += 5;
                                            troopp.Add(100);
                                            tpl.Add(5);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Infantry Squad");
                                            army1.Points += 55;
                                            army1.PL += 3;
                                            troopp.Add(55);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                            }
                        }
                        if(choice == 2)
                        {
                            if (army2.Faction == 1)
                            {
                                Console.WriteLine("1 - Horros of Tzeentch");
                                Console.WriteLine("2 - Nurglings");
                                Console.WriteLine("3 - Daemonettes of Slaanesh");
                                Console.WriteLine("4 - Daemons of Khorne Bloodletters");
                                Console.WriteLine("5 - Plaguebearers of Nurgle");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if (troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Horrors of Tzeentch");
                                            army2.Points += 35;
                                            army2.PL += 4;
                                            troopp.Add(35);
                                            tpl.Add(4);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Nurglings");
                                            army2.Points += 66;
                                            army2.PL += 3;
                                            troopp.Add(66);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Daemonettes of Saanesh");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            troopp.Add(70);
                                            tpl.Add(4);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Daemons of Khorne Bloodletters");
                                            army2.Points += 80;
                                            army2.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Plaguebearers of Nurgle");
                                            army2.Points += 90;
                                            army2.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Horrors of Tzeentch");
                                            army2.Points += 35;
                                            army2.PL += 4;
                                            troopp.Add(35);
                                            tpl.Add(4);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Nurglings");
                                            army2.Points += 66;
                                            army2.PL += 3;
                                            troopp.Add(66);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Daemonettes of Saanesh");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            troopp.Add(70);
                                            tpl.Add(4);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Daemons of Khorne Bloodletters");
                                            army2.Points += 80;
                                            army2.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Plaguebearers of Nurgle");
                                            army2.Points += 90;
                                            army2.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Horrors of Tzeentch");
                                            army2.Points += 35;
                                            army2.PL += 4;
                                            troopp.Add(35);
                                            tpl.Add(4);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Nurglings");
                                            army2.Points += 66;
                                            army2.PL += 3;
                                            troopp.Add(66);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Daemonettes of Saanesh");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            troopp.Add(70);
                                            tpl.Add(4);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Daemons of Khorne Bloodletters");
                                            army2.Points += 80;
                                            army2.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Plaguebearers of Nurgle");
                                            army2.Points += 90;
                                            army2.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                            }
                            if (army2.Faction == 2)
                            {
                                Console.WriteLine("1 - Plague Marines");
                                Console.WriteLine("2 - Poxwalkers");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army2.detachment == 1)
                                {
                                    if (troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Plague Marines");
                                            army2.Points += 105;
                                            army2.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Poxwalkers");
                                            army2.Points += 50;
                                            army2.PL += 2;
                                            troopp.Add(50);
                                            tpl.Add(2);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Plague Marines");
                                            army2.Points += 105;
                                            army2.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Poxwalkers");
                                            army2.Points += 50;
                                            army2.PL += 2;
                                            troopp.Add(50);
                                            tpl.Add(2);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Plague Marines");
                                            army2.Points += 105;
                                            army2.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Poxwalkers");
                                            army2.Points += 50;
                                            army2.PL += 2;
                                            troopp.Add(50);
                                            tpl.Add(2);
                                        }
                                    }
                                }
                            }
                            if (army2.Faction == 3)
                            {
                                Console.WriteLine("1 - Chaos Space Marines");
                                Console.WriteLine("2 - Black Legionnaires");
                                Console.WriteLine("3 - Chaos Cultists");
                                Console.WriteLine("4 - Khorne Berzerkers");
                                Console.WriteLine("5 - Noise Marines");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if (army2.detachment == 1)
                                {
                                    if (troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Chaos Space Marines");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            troopp.Add(70);
                                            tpl.Add(4);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Black Legionnaires");
                                            army2.Points += 28;
                                            army2.PL += 1;
                                            troopp.Add(28);
                                            tpl.Add(1);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Chaos Cultists");
                                            army2.Points += 50;
                                            army2.PL += 3;
                                            troopp.Add(50);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Khorne Berzerkers");
                                            army2.Points += 85;
                                            army2.PL += 5;
                                            troopp.Add(85);
                                            tpl.Add(5);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Noise Marines");
                                            army2.Points += 80;
                                            army2.PL += 5;
                                            troopp.Add(80);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Chaos Space Marines");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            troopp.Add(70);
                                            tpl.Add(4);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Black Legionnaires");
                                            army2.Points += 28;
                                            army2.PL += 1;
                                            troopp.Add(28);
                                            tpl.Add(1);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Chaos Cultists");
                                            army2.Points += 50;
                                            army2.PL += 3;
                                            troopp.Add(50);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Khorne Berzerkers");
                                            army2.Points += 85;
                                            army2.PL += 5;
                                            troopp.Add(85);
                                            tpl.Add(5);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Noise Marines");
                                            army2.Points += 80;
                                            army2.PL += 5;
                                            troopp.Add(80);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Chaos Space Marines");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            troopp.Add(70);
                                            tpl.Add(4);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Black Legionnaires");
                                            army2.Points += 28;
                                            army2.PL += 1;
                                            troopp.Add(28);
                                            tpl.Add(1);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Chaos Cultists");
                                            army2.Points += 50;
                                            army2.PL += 3;
                                            troopp.Add(50);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Khorne Berzerkers");
                                            army2.Points += 85;
                                            army2.PL += 5;
                                            troopp.Add(85);
                                            tpl.Add(5);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Noise Marines");
                                            army2.Points += 80;
                                            army2.PL += 5;
                                            troopp.Add(80);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                            }
                            if (army2.Faction == 4)
                            {
                                Console.WriteLine("1 - Rubric Marines");
                                Console.WriteLine("2 - Tzaangors");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army2.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if(troops == 1)
                                        {
                                            troop.Add("Rubric Marines");
                                            army2.Points += 105;
                                            army2.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Tzaangors");
                                            army2.Points += 70;
                                            army2.PL += 6;
                                            troopp.Add(70);
                                            tpl.Add(6);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Rubric Marines");
                                            army2.Points += 105;
                                            army2.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Tzaangors");
                                            army2.Points += 70;
                                            army2.PL += 6;
                                            troopp.Add(70);
                                            tpl.Add(6);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Rubric Marines");
                                            army2.Points += 105;
                                            army2.PL += 6;
                                            troopp.Add(105);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Tzaangors");
                                            army2.Points += 70;
                                            army2.PL += 6;
                                            troopp.Add(70);
                                            tpl.Add(6);
                                        }
                                    }
                                }
                            }
                        }
                        if(choice == 3)
                        {
                            if (army3.Faction == 1)
                            {
                                Console.WriteLine("1 - Dire Avengers");
                                Console.WriteLine("2 - Guardian Defenders");
                                Console.WriteLine("3 - Rangers");
                                Console.WriteLine("4 - Storm Guardians");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army3.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Dire Avengers");
                                            army3.Points += 55;
                                            army3.PL += 2;
                                            troopp.Add(55);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Guardian Defenders");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Rangers");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            troopp.Add(65);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Storm Guardians");
                                            army3.Points += 56;
                                            army3.PL += 3;
                                            troopp.Add(56);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Dire Avengers");
                                            army3.Points += 55;
                                            army3.PL += 2;
                                            troopp.Add(55);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Guardian Defenders");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Rangers");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            troopp.Add(65);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Storm Guardians");
                                            army3.Points += 56;
                                            army3.PL += 3;
                                            troopp.Add(56);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Dire Avengers");
                                            army3.Points += 55;
                                            army3.PL += 2;
                                            troopp.Add(55);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Guardian Defenders");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Rangers");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            troopp.Add(65);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Storm Guardians");
                                            army3.Points += 56;
                                            army3.PL += 3;
                                            troopp.Add(56);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 2)
                            {
                                Console.WriteLine("1 - Kabalite Warriors");
                                Console.WriteLine("2 - Wracks");
                                Console.WriteLine("3 - Wyches");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (troop.Count < 3)
                                    {
                                        if(troops == 1)
                                        {
                                            troop.Add("Kabalite Warriors");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Wracks");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Wyches");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Kabalite Warriors");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Wracks");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Wyches");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Kabalite Warriors");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Wracks");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Wyches");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 3)
                            {
                                Console.WriteLine("1 - Brood Brothers");
                                Console.WriteLine("2 - Neophyte Hybrids");
                                Console.WriteLine("3 - Acolyte Hybrids");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Brood Brothers");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Neophyte Hybrids");
                                            army3.Points += 60;
                                            army3.PL += 4;
                                            troopp.Add(60);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Acolyte Hybrids");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {

                                        if (troops == 1)
                                        {
                                            troop.Add("Brood Brothers");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Neophyte Hybrids");
                                            army3.Points += 60;
                                            army3.PL += 4;
                                            troopp.Add(60);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Acolyte Hybrids");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                        if (troop.Count < 12)
                                        {
                                        if (troops == 1)
                                        {
                                            troop.Add("Brood Brothers");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Neophyte Hybrids");
                                            army3.Points += 60;
                                            army3.PL += 4;
                                            troopp.Add(60);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Acolyte Hybrids");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 4)
                            {
                                Console.WriteLine("1 - Troupe");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army3.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        troop.Add("Troupe");
                                        army3.Points += 70;
                                        army3.PL += 5;
                                        troopp.Add(70);
                                        tpl.Add(5);
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        troop.Add("Troupe");
                                        army3.Points += 70;
                                        army3.PL += 5;
                                        troopp.Add(70);
                                        tpl.Add(5);
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        troop.Add("Troupe");
                                        army3.Points += 70;
                                        army3.PL += 5;
                                        troopp.Add(70);
                                        tpl.Add(5);
                                    }
                                }
                            }
                            if (army3.Faction == 5)
                            {
                                Console.WriteLine("1 - Necron Warriors");
                                Console.WriteLine("2 - Immortals");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army3.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if(troops == 1)
                                        {
                                            troop.Add("Necron Warriors");
                                            army3.Points += 130;
                                            army3.PL += 6;
                                            troopp.Add(130);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Immortals");
                                            army3.Points += 85;
                                            army3.PL += 4;
                                            troopp.Add(85);
                                            tpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Necron Warriors");
                                            army3.Points += 130;
                                            army3.PL += 6;
                                            troopp.Add(130);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Immortals");
                                            army3.Points += 85;
                                            army3.PL += 4;
                                            troopp.Add(85);
                                            tpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Necron Warriors");
                                            army3.Points += 130;
                                            army3.PL += 6;
                                            troopp.Add(130);
                                            tpl.Add(6);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Immortals");
                                            army3.Points += 85;
                                            army3.PL += 4;
                                            troopp.Add(85);
                                            tpl.Add(4);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 6)
                            {
                                Console.WriteLine("1 - Ork Boyz");
                                Console.WriteLine("2 - Ork Gretchin");
                                Console.WriteLine("3 - Ork Beast Snagga Boyz");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army3.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if(troops == 1)
                                        {
                                            troop.Add("Ork Boyz");
                                            army3.Points += 90;
                                            army3.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                        if(troops == 2)
                                        {
                                            troop.Add("Ork Gretchin");
                                            army3.Points += 50;
                                            army3.PL += 2;
                                            troopp.Add(50);
                                            tpl.Add(2);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Ork Beast Snagga Boyz");
                                            army3.Points += 110;
                                            army3.PL += 5;
                                            troopp.Add(110);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Ork Boyz");
                                            army3.Points += 90;
                                            army3.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Ork Gretchin");
                                            army3.Points += 50;
                                            army3.PL += 2;
                                            troopp.Add(50);
                                            tpl.Add(2);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Ork Beast Snagga Boyz");
                                            army3.Points += 110;
                                            army3.PL += 5;
                                            troopp.Add(110);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Ork Boyz");
                                            army3.Points += 90;
                                            army3.PL += 5;
                                            troopp.Add(90);
                                            tpl.Add(5);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Ork Gretchin");
                                            army3.Points += 50;
                                            army3.PL += 2;
                                            troopp.Add(50);
                                            tpl.Add(2);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Ork Beast Snagga Boyz");
                                            army3.Points += 110;
                                            army3.PL += 5;
                                            troopp.Add(110);
                                            tpl.Add(5);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 7)
                            {
                                Console.WriteLine("1 - Breacher Team");
                                Console.WriteLine("2 - Kroot Carnivores");
                                Console.WriteLine("3 - Strike Team");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army3.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if(troops == 1)
                                        {
                                            troop.Add("Breacher Team");
                                            army3.Points += 45;
                                            army3.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Kroot Carnivores");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Strike Team");
                                            army3.Points += 45;
                                            army3.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Breacher Team");
                                            army3.Points += 45;
                                            army3.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Kroot Carnivores");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Strike Team");
                                            army3.Points += 45;
                                            army3.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Breacher Team");
                                            army3.Points += 45;
                                            army3.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Kroot Carnivores");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Strike Team");
                                            army3.Points += 45;
                                            army3.PL += 2;
                                            troopp.Add(45);
                                            tpl.Add(2);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 8)
                            {
                                Console.WriteLine("1 - Genestealers");
                                Console.WriteLine("2 - Hormagaunts");
                                Console.WriteLine("3 - Ripper Swarm");
                                Console.WriteLine("4 - Termagants");
                                Console.WriteLine("5 - Tyranid Warriors");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army3.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Genestealers");
                                            army3.Points += 65;
                                            army3.PL += 4;
                                            troopp.Add(65);
                                            tpl.Add(4);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Hormagaunts");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Ripper Swarm");
                                            army3.Points += 36;
                                            army3.PL += 2;
                                            troopp.Add(36);
                                            tpl.Add(2);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Termagants");
                                            army3.Points += 50;
                                            army3.PL += 3;
                                            troopp.Add(50);
                                            tpl.Add(3);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Tyranid Warriors");
                                            army3.Points += 63;
                                            army3.PL += 4;
                                            troopp.Add(63);
                                            tpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Genestealers");
                                            army3.Points += 65;
                                            army3.PL += 4;
                                            troopp.Add(65);
                                            tpl.Add(4);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Hormagaunts");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Ripper Swarm");
                                            army3.Points += 36;
                                            army3.PL += 2;
                                            troopp.Add(36);
                                            tpl.Add(2);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Termagants");
                                            army3.Points += 50;
                                            army3.PL += 3;
                                            troopp.Add(50);
                                            tpl.Add(3);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Tyranid Warriors");
                                            army3.Points += 63;
                                            army3.PL += 4;
                                            troopp.Add(63);
                                            tpl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Genestealers");
                                            army3.Points += 65;
                                            army3.PL += 4;
                                            troopp.Add(65);
                                            tpl.Add(4);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Hormagaunts");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Ripper Swarm");
                                            army3.Points += 36;
                                            army3.PL += 2;
                                            troopp.Add(36);
                                            tpl.Add(2);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Termagants");
                                            army3.Points += 50;
                                            army3.PL += 3;
                                            troopp.Add(50);
                                            tpl.Add(3);
                                        }
                                        if (troops == 1)
                                        {
                                            troop.Add("Tyranid Warriors");
                                            army3.Points += 63;
                                            army3.PL += 4;
                                            troopp.Add(63);
                                            tpl.Add(4);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 9)
                            {
                                Console.WriteLine("1 - Dire Avengers");
                                Console.WriteLine("2 - Guardian Defenders");
                                Console.WriteLine("3 - Rangers");
                                Console.WriteLine("4 - Storm Guardians");
                                Console.WriteLine("5 - Kabalite Warriors");
                                Console.WriteLine("6 - Wracks");
                                Console.WriteLine("7 - Wyches");
                                troops = Convert.ToInt32(Console.ReadLine());
                                if(army3.detachment == 1)
                                {
                                    if(troop.Count < 3)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Dire Avengers");
                                            army3.Points += 55;
                                            army3.PL += 2;
                                            troopp.Add(55);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Guardian Defenders");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Rangers");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            troopp.Add(65);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Storm Guardians");
                                            army3.Points += 56;
                                            army3.PL += 3;
                                            troopp.Add(56);
                                            tpl.Add(3);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Kabalite Warriors");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 6)
                                        {
                                            troop.Add("Wracks");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 7)
                                        {
                                            troop.Add("Wyches");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (troop.Count < 6)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Dire Avengers");
                                            army3.Points += 55;
                                            army3.PL += 2;
                                            troopp.Add(55);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Guardian Defenders");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Rangers");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            troopp.Add(65);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Storm Guardians");
                                            army3.Points += 56;
                                            army3.PL += 3;
                                            troopp.Add(56);
                                            tpl.Add(3);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Kabalite Warriors");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 6)
                                        {
                                            troop.Add("Wracks");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 7)
                                        {
                                            troop.Add("Wyches");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (troop.Count < 12)
                                    {
                                        if (troops == 1)
                                        {
                                            troop.Add("Dire Avengers");
                                            army3.Points += 55;
                                            army3.PL += 2;
                                            troopp.Add(55);
                                            tpl.Add(2);
                                        }
                                        if (troops == 2)
                                        {
                                            troop.Add("Guardian Defenders");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            troopp.Add(80);
                                            tpl.Add(4);
                                        }
                                        if (troops == 3)
                                        {
                                            troop.Add("Rangers");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            troopp.Add(65);
                                            tpl.Add(3);
                                        }
                                        if (troops == 4)
                                        {
                                            troop.Add("Storm Guardians");
                                            army3.Points += 56;
                                            army3.PL += 3;
                                            troopp.Add(56);
                                            tpl.Add(3);
                                        }
                                        if (troops == 5)
                                        {
                                            troop.Add("Kabalite Warriors");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 6)
                                        {
                                            troop.Add("Wracks");
                                            army3.Points += 40;
                                            army3.PL += 3;
                                            troopp.Add(40);
                                            tpl.Add(3);
                                        }
                                        if (troops == 7)
                                        {
                                            troop.Add("Wyches");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            troopp.Add(60);
                                            tpl.Add(3);
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        Console.Clear();
                        if (choice == 1)
                        {
                            if (army1.Faction == 1)
                            {
                                Console.WriteLine("1 - Aestred Thurga, Reliquant at Arms");
                                Console.WriteLine("2 - Paragon warsuits");
                                Console.WriteLine("3 - Death Cult Assassins");
                                Console.WriteLine("4 - Crusaders");
                                Console.WriteLine("5 - Preacher with Chainsword");
                                Console.WriteLine("6 - Imagifier");
                                Console.WriteLine("7 - Sister Dogmata");
                                Console.WriteLine("8 - Hospitaller");
                                Console.WriteLine("9 - Dialogues");
                                Console.WriteLine("10 - Arco-flagellants");
                                Console.WriteLine("11 - Celestian Sacresants");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Aestred Thurga, Reliquant at Arms");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            elitep.Add(90);
                                            epl.Add(5);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Paragon warsuits");
                                            army1.Points += 240;
                                            army1.PL += 13;
                                            elitep.Add(240);
                                            epl.Add(13);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Death Cult Assassins");
                                            army1.Points += 26;
                                            army1.PL += 1;
                                            elitep.Add(26);
                                            epl.Add(1);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Crusaders");
                                            army1.Points += 22;
                                            army1.PL += 1;
                                            elitep.Add(22);
                                            epl.Add(1);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Preacher with Chainsword");
                                            army1.Points += 30;
                                            army1.PL += 2;
                                            elitep.Add(30);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Imagifier");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Sister Dogmata");
                                            army1.Points += 65;
                                            army1.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Hospitaller");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Dialogues");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Arco-flagellants");
                                            army1.Points += 39;
                                            army1.PL += 2;
                                            elitep.Add(39);
                                            epl.Add(2);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Celestian Sacresants");
                                            army1.Points += 70;
                                            army1.PL += 3;
                                            elitep.Add(70);
                                            epl.Add(3);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Aestred Thurga, Reliquant at Arms");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            elitep.Add(90);
                                            epl.Add(5);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Paragon warsuits");
                                            army1.Points += 240;
                                            army1.PL += 13;
                                            elitep.Add(240);
                                            epl.Add(13);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Death Cult Assassins");
                                            army1.Points += 26;
                                            army1.PL += 1;
                                            elitep.Add(26);
                                            epl.Add(1);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Crusaders");
                                            army1.Points += 22;
                                            army1.PL += 1;
                                            elitep.Add(22);
                                            epl.Add(1);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Preacher with Chainsword");
                                            army1.Points += 30;
                                            army1.PL += 2;
                                            elitep.Add(30);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Imagifier");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Sister Dogmata");
                                            army1.Points += 65;
                                            army1.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Hospitaller");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Dialogues");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Arco-flagellants");
                                            army1.Points += 39;
                                            army1.PL += 2;
                                            elitep.Add(39);
                                            epl.Add(2);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Celestian Sacresants");
                                            army1.Points += 70;
                                            army1.PL += 3;
                                            elitep.Add(70);
                                            epl.Add(3);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Aestred Thurga, Reliquant at Arms");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            elitep.Add(90);
                                            epl.Add(5);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Paragon warsuits");
                                            army1.Points += 240;
                                            army1.PL += 13;
                                            elitep.Add(240);
                                            epl.Add(13);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Death Cult Assassins");
                                            army1.Points += 26;
                                            army1.PL += 1;
                                            elitep.Add(26);
                                            epl.Add(1);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Crusaders");
                                            army1.Points += 22;
                                            army1.PL += 1;
                                            elitep.Add(22);
                                            epl.Add(1);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Preacher with Chainsword");
                                            army1.Points += 30;
                                            army1.PL += 2;
                                            elitep.Add(30);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Imagifier");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Sister Dogmata");
                                            army1.Points += 65;
                                            army1.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Hospitaller");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Dialogues");
                                            army1.Points += 50;
                                            army1.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Arco-flagellants");
                                            army1.Points += 39;
                                            army1.PL += 2;
                                            elitep.Add(39);
                                            epl.Add(2);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Celestian Sacresants");
                                            army1.Points += 70;
                                            army1.PL += 3;
                                            elitep.Add(70);
                                            epl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army1.Faction == 2)
                            {
                                Console.WriteLine("1 - Servirtors with Multi-Melta");
                                Console.WriteLine("2 - Servitors with Plasma Cannon");
                                Console.WriteLine("3 - Space Marine Scouts");
                                Console.WriteLine("4 - Scouts with Sniper Rifles");
                                Console.WriteLine("5 - Primaris Apothecary");
                                Console.WriteLine("6 - Vanguard Veteran Squad");
                                Console.WriteLine("7 - Bladeguard Veterans");
                                Console.WriteLine("8 - Primaris Aggressors");
                                Console.WriteLine("9 - Dreadnought");
                                Console.WriteLine("10 - Company Command");
                                Console.WriteLine("11 - Terminator Squad");
                                Console.WriteLine("12 - Terminator Assault Squad");
                                Console.WriteLine("13 - Ironclad Dreadnought");
                                Console.WriteLine("14 - Sternguard Veteran Squad");
                                Console.WriteLine("15 - Venerable Dreadnought");
                                Console.WriteLine("16 - Primaris Reivers");
                                Console.WriteLine("17 - Primaris Invictor Tactical Warsuit");
                                Console.WriteLine("18 - Tartaros Terminators");
                                Console.WriteLine("19 - Cataphractii Terminators");
                                Console.WriteLine("20 - Primaris Redemptor Dreadnought");
                                Console.WriteLine("21 - Centurion Assault Squad");
                                Console.WriteLine("22 - Contemptor Dreadnought");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if(elites == 1)
                                        {
                                            elite.Add("Servirtors with Multi-Melta");
                                            army1.Points += 60;
                                            army1.PL += 2;
                                            elitep.Add(60);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Servitors with Plasma Cannon");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Space Marine Scouts");
                                            army1.Points += 70;
                                            army1.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Scouts with Sniper Rifles");
                                            army1.Points += 80;
                                            army1.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Primaris Apothecary");
                                            army1.Points += 80;
                                            army1.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Vanguard Veteran Squad");
                                            army1.Points += 95;
                                            army1.PL += 6;
                                            elitep.Add(95);
                                            epl.Add(6);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Bladeguard Veterans");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Primaris Aggressors");
                                            army1.Points += 120;
                                            army1.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Dreadnought");
                                            army1.Points += 120;
                                            army1.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Company Command");
                                            army1.Points += 40;
                                            army1.PL += 3;
                                            elitep.Add(40);
                                            epl.Add(3);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Terminator Squad");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Terminator Assault Squad");
                                            army1.Points += 215;
                                            army1.PL += 9;
                                            elitep.Add(215);
                                            epl.Add(9);
                                        }
                                        if (elites == 13)
                                        {
                                            elite.Add("Ironclad Dreadnought");
                                            army1.Points += 135;
                                            army1.PL += 8;
                                            elitep.Add(135);
                                            epl.Add(8);
                                        }
                                        if (elites == 14)
                                        {
                                            elite.Add("Sternguard Veteran Squad");
                                            army1.Points += 100;
                                            army1.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                        if (elites == 15)
                                        {
                                            elite.Add("Venerable Dreadnought");
                                            army1.Points += 135;
                                            army1.PL += 8;
                                            elitep.Add(135);
                                            epl.Add(8);
                                        }
                                        if (elites == 16)
                                        {
                                            elite.Add("Primaris Reivers");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            elitep.Add(90);
                                            epl.Add(5);
                                        }
                                        if (elites == 17)
                                        {
                                            elite.Add("Primaris Invictor Tactical Warsuit");
                                            army1.Points += 160;
                                            army1.PL += 8;
                                            elitep.Add(160);
                                            epl.Add(8);
                                        }
                                        if (elites == 18)
                                        {
                                            elite.Add("Tartaros Terminators");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 19)
                                        {
                                            elite.Add("Cataphractii Terminators");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 20)
                                        {
                                            elite.Add("Primaris Redemptor Dreadnought");
                                            army1.Points += 175;
                                            army1.PL += 8;
                                            elitep.Add(175);
                                            epl.Add(8);
                                        }
                                        if (elites == 21)
                                        {
                                            elite.Add("Centurion Assault Squad");
                                            army1.Points += 165;
                                            army1.PL += 9;
                                            elitep.Add(165);
                                            epl.Add(9);
                                        }
                                        if (elites == 22)
                                        {
                                            elite.Add("Contemptor Dreadnought");
                                            army1.Points += 150;
                                            army1.PL += 8;
                                            elitep.Add(150);
                                            epl.Add(8);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Servirtors with Multi-Melta");
                                            army1.Points += 60;
                                            army1.PL += 2;
                                            elitep.Add(60);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Servitors with Plasma Cannon");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Space Marine Scouts");
                                            army1.Points += 70;
                                            army1.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Scouts with Sniper Rifles");
                                            army1.Points += 80;
                                            army1.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Primaris Apothecary");
                                            army1.Points += 80;
                                            army1.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Vanguard Veteran Squad");
                                            army1.Points += 95;
                                            army1.PL += 6;
                                            elitep.Add(95);
                                            epl.Add(6);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Bladeguard Veterans");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Primaris Aggressors");
                                            army1.Points += 120;
                                            army1.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Dreadnought");
                                            army1.Points += 120;
                                            army1.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Company Command");
                                            army1.Points += 40;
                                            army1.PL += 3;
                                            elitep.Add(40);
                                            epl.Add(3);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Terminator Squad");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Terminator Assault Squad");
                                            army1.Points += 215;
                                            army1.PL += 9;
                                            elitep.Add(215);
                                            epl.Add(9);
                                        }
                                        if (elites == 13)
                                        {
                                            elite.Add("Ironclad Dreadnought");
                                            army1.Points += 135;
                                            army1.PL += 8;
                                            elitep.Add(135);
                                            epl.Add(8);
                                        }
                                        if (elites == 14)
                                        {
                                            elite.Add("Sternguard Veteran Squad");
                                            army1.Points += 100;
                                            army1.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                        if (elites == 15)
                                        {
                                            elite.Add("Venerable Dreadnought");
                                            army1.Points += 135;
                                            army1.PL += 8;
                                            elitep.Add(135);
                                            epl.Add(8);
                                        }
                                        if (elites == 16)
                                        {
                                            elite.Add("Primaris Reivers");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            elitep.Add(90);
                                            epl.Add(5);
                                        }
                                        if (elites == 17)
                                        {
                                            elite.Add("Primaris Invictor Tactical Warsuit");
                                            army1.Points += 160;
                                            army1.PL += 8;
                                            elitep.Add(160);
                                            epl.Add(8);
                                        }
                                        if (elites == 18)
                                        {
                                            elite.Add("Tartaros Terminators");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 19)
                                        {
                                            elite.Add("Cataphractii Terminators");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 20)
                                        {
                                            elite.Add("Primaris Redemptor Dreadnought");
                                            army1.Points += 175;
                                            army1.PL += 8;
                                            elitep.Add(175);
                                            epl.Add(8);
                                        }
                                        if (elites == 21)
                                        {
                                            elite.Add("Centurion Assault Squad");
                                            army1.Points += 165;
                                            army1.PL += 9;
                                            elitep.Add(165);
                                            epl.Add(9);
                                        }
                                        if (elites == 22)
                                        {
                                            elite.Add("Contemptor Dreadnought");
                                            army1.Points += 150;
                                            army1.PL += 8;
                                            elitep.Add(150);
                                            epl.Add(8);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Servirtors with Multi-Melta");
                                            army1.Points += 60;
                                            army1.PL += 2;
                                            elitep.Add(60);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Servitors with Plasma Cannon");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Space Marine Scouts");
                                            army1.Points += 70;
                                            army1.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Scouts with Sniper Rifles");
                                            army1.Points += 80;
                                            army1.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Primaris Apothecary");
                                            army1.Points += 80;
                                            army1.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Vanguard Veteran Squad");
                                            army1.Points += 95;
                                            army1.PL += 6;
                                            elitep.Add(95);
                                            epl.Add(6);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Bladeguard Veterans");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Primaris Aggressors");
                                            army1.Points += 120;
                                            army1.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Dreadnought");
                                            army1.Points += 120;
                                            army1.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Company Command");
                                            army1.Points += 40;
                                            army1.PL += 3;
                                            elitep.Add(40);
                                            epl.Add(3);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Terminator Squad");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Terminator Assault Squad");
                                            army1.Points += 215;
                                            army1.PL += 9;
                                            elitep.Add(215);
                                            epl.Add(9);
                                        }
                                        if (elites == 13)
                                        {
                                            elite.Add("Ironclad Dreadnought");
                                            army1.Points += 135;
                                            army1.PL += 8;
                                            elitep.Add(135);
                                            epl.Add(8);
                                        }
                                        if (elites == 14)
                                        {
                                            elite.Add("Sternguard Veteran Squad");
                                            army1.Points += 100;
                                            army1.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                        if (elites == 15)
                                        {
                                            elite.Add("Venerable Dreadnought");
                                            army1.Points += 135;
                                            army1.PL += 8;
                                            elitep.Add(135);
                                            epl.Add(8);
                                        }
                                        if (elites == 16)
                                        {
                                            elite.Add("Primaris Reivers");
                                            army1.Points += 90;
                                            army1.PL += 5;
                                            elitep.Add(90);
                                            epl.Add(5);
                                        }
                                        if (elites == 17)
                                        {
                                            elite.Add("Primaris Invictor Tactical Warsuit");
                                            army1.Points += 160;
                                            army1.PL += 8;
                                            elitep.Add(160);
                                            epl.Add(8);
                                        }
                                        if (elites == 18)
                                        {
                                            elite.Add("Tartaros Terminators");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 19)
                                        {
                                            elite.Add("Cataphractii Terminators");
                                            army1.Points += 190;
                                            army1.PL += 9;
                                            elitep.Add(190);
                                            epl.Add(9);
                                        }
                                        if (elites == 20)
                                        {
                                            elite.Add("Primaris Redemptor Dreadnought");
                                            army1.Points += 175;
                                            army1.PL += 8;
                                            elitep.Add(175);
                                            epl.Add(8);
                                        }
                                        if (elites == 21)
                                        {
                                            elite.Add("Centurion Assault Squad");
                                            army1.Points += 165;
                                            army1.PL += 9;
                                            elitep.Add(165);
                                            epl.Add(9);
                                        }
                                        if (elites == 22)
                                        {
                                            elite.Add("Contemptor Dreadnought");
                                            army1.Points += 150;
                                            army1.PL += 8;
                                            elitep.Add(150);
                                            epl.Add(8);
                                        }
                                    }
                                }
                            }
                            if (army1.Faction == 3)
                            {
                                Console.WriteLine("1 - Allarus Custodians");
                                Console.WriteLine("2 - Custodian Wardens");
                                Console.WriteLine("3 - Venerable Contemptor Dreadnought");
                                Console.WriteLine("4 - Vexilus Praetor");
                                Console.WriteLine("5 - Vexilus Praetor in Allarus Terminator Armour");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if(elites == 1)
                                        {
                                            elite.Add("Allarus Custodians");
                                            army1.Points += 225;
                                            army1.PL += 9;
                                            elitep.Add(225);
                                            epl.Add(9);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Custodian Wardens");
                                            army1.Points += 165;
                                            army1.PL += 8;
                                            elitep.Add(165);
                                            epl.Add(8);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Venerable Contemptor Dreadnought");
                                            army1.Points += 155;
                                            army1.PL += 8;
                                            elitep.Add(155);
                                            epl.Add(8);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Vexilus Praetor");
                                            army1.Points += 110;
                                            army1.PL += 6;
                                            elitep.Add(110);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Vexilus Praetor in Allarus Terminator Armour");
                                            army1.Points += 115;
                                            army1.PL += 7;
                                            elitep.Add(115);
                                            epl.Add(7);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Allarus Custodians");
                                            army1.Points += 225;
                                            army1.PL += 9;
                                            elitep.Add(225);
                                            epl.Add(9);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Custodian Wardens");
                                            army1.Points += 165;
                                            army1.PL += 8;
                                            elitep.Add(165);
                                            epl.Add(8);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Venerable Contemptor Dreadnought");
                                            army1.Points += 155;
                                            army1.PL += 8;
                                            elitep.Add(155);
                                            epl.Add(8);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Vexilus Praetor");
                                            army1.Points += 110;
                                            army1.PL += 6;
                                            elitep.Add(110);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Vexilus Praetor in Allarus Terminator Armour");
                                            army1.Points += 115;
                                            army1.PL += 7;
                                            elitep.Add(115);
                                            epl.Add(7);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Allarus Custodians");
                                            army1.Points += 225;
                                            army1.PL += 9;
                                            elitep.Add(225);
                                            epl.Add(9);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Custodian Wardens");
                                            army1.Points += 165;
                                            army1.PL += 8;
                                            elitep.Add(165);
                                            epl.Add(8);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Venerable Contemptor Dreadnought");
                                            army1.Points += 155;
                                            army1.PL += 8;
                                            elitep.Add(155);
                                            epl.Add(8);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Vexilus Praetor");
                                            army1.Points += 110;
                                            army1.PL += 6;
                                            elitep.Add(110);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Vexilus Praetor in Allarus Terminator Armour");
                                            army1.Points += 115;
                                            army1.PL += 7;
                                            elitep.Add(115);
                                            epl.Add(7);
                                        }
                                    }
                                }
                            }
                            if (army1.Faction == 4)
                            {
                                Console.WriteLine("1 - Corpuscarii Electro-Priests");
                                Console.WriteLine("2 - Fulgurite Electro-Priests");
                                Console.WriteLine("3 - Sicarian Infiltrators");
                                Console.WriteLine("4 - Sicarian Ruststalkers");
                                Console.WriteLine("5 - Servitors with Plasma Cannon");
                                Console.WriteLine("6 - Servitors with Multi-Melta");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if(elites == 1)
                                        {
                                            elite.Add("Corpuscarii Electro-Priests");
                                            army1.Points += 75;
                                            army1.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Fulgurite Electro-Priests");
                                            army1.Points += 75;
                                            army1.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Sicarian Infiltrators");
                                            army1.Points += 95;
                                            army1.PL += 4;
                                            elitep.Add(95);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Sicarian Ruststalkers");
                                            army1.Points += 95;
                                            army1.PL += 4;
                                            elitep.Add(95);
                                            epl.Add(4);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Servitors with Plasma Cannon");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Servirtors with Multi-Melta");
                                            army1.Points += 60;
                                            army1.PL += 2;
                                            elitep.Add(60);
                                            epl.Add(2);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Corpuscarii Electro-Priests");
                                            army1.Points += 75;
                                            army1.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Fulgurite Electro-Priests");
                                            army1.Points += 75;
                                            army1.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Sicarian Infiltrators");
                                            army1.Points += 95;
                                            army1.PL += 4;
                                            elitep.Add(95);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Sicarian Ruststalkers");
                                            army1.Points += 95;
                                            army1.PL += 4;
                                            elitep.Add(95);
                                            epl.Add(4);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Servitors with Plasma Cannon");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Servirtors with Multi-Melta");
                                            army1.Points += 60;
                                            army1.PL += 2;
                                            elitep.Add(60);
                                            epl.Add(2);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Corpuscarii Electro-Priests");
                                            army1.Points += 75;
                                            army1.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Fulgurite Electro-Priests");
                                            army1.Points += 75;
                                            army1.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Sicarian Infiltrators");
                                            army1.Points += 95;
                                            army1.PL += 4;
                                            elitep.Add(95);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Sicarian Ruststalkers");
                                            army1.Points += 95;
                                            army1.PL += 4;
                                            elitep.Add(95);
                                            epl.Add(4);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Servitors with Plasma Cannon");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Servirtors with Multi-Melta");
                                            army1.Points += 60;
                                            army1.PL += 2;
                                            elitep.Add(60);
                                            epl.Add(2);
                                        }
                                    }
                                }
                            }
                            if (army1.Faction == 5)
                            {
                                Console.WriteLine("1 - Astropath");
                                Console.WriteLine("2 - Bullgryns");
                                Console.WriteLine("3 - Colour Sergeant Kell");
                                Console.WriteLine("4 - Combat Engineer Squad");
                                Console.WriteLine("5 - Command Squad");
                                Console.WriteLine("6 - Commissar");
                                Console.WriteLine("7 - Commissar Severina Raine");
                                Console.WriteLine("8 - Crusaders");
                                Console.WriteLine("9 - Death Rider Command Squad");
                                Console.WriteLine("10 - Gotfret de Montbard");
                                Console.WriteLine("11 - Master of Ordnance");
                                Console.WriteLine("12 - Millitarum Tempestus Command Squad");
                                Console.WriteLine("13 - Ministorum Priest");
                                Console.WriteLine("14 - Nork Deddog");
                                Console.WriteLine("15 - Officer of the Fleet");
                                Console.WriteLine("16 - Ogryn Bodyguard");
                                Console.WriteLine("17 - Ogryns");
                                Console.WriteLine("18 - Platoon Commander");
                                Console.WriteLine("19 - Ratlings");
                                Console.WriteLine("20 - Rein and Raus");
                                Console.WriteLine("21 - Special Weapons Squad");
                                Console.WriteLine("22 - Veterans");
                                Console.WriteLine("23 - Voidsmen-at-arms");
                                Console.WriteLine("24 - Wyrdvane Psykers");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if(elites == 1)
                                        {
                                            elite.Add("Astropath");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Bullgryns");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Colour Sergeant Kell");
                                            army1.Points += 45;
                                            army1.PL += 3;
                                            elitep.Add(45);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Combat Engineer Squad");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Command Squad");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Commissar");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Commissar Severina Raine");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Crusaders");
                                            army1.Points += 32;
                                            army1.PL += 2;
                                            elitep.Add(32);
                                            epl.Add(2);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Death Rider Command Squad");
                                            army1.Points += 85;
                                            army1.PL += 3;
                                            elitep.Add(85);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Gotfret de Montbard");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Master of Ordnance");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Millitarum Tempestus Command Squad");
                                            army1.Points += 40;
                                            army1.PL += 3;
                                            elitep.Add(40);
                                            epl.Add(3);
                                        }
                                        if (elites == 13)
                                        {
                                            elite.Add("Ministorum Priest");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 14)
                                        {
                                            elite.Add("Nork Deddog");
                                            army1.Points += 60;
                                            army1.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 15)
                                        {
                                            elite.Add("Officer of the Fleet");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 16)
                                        {
                                            elite.Add("Ogryn Bodyguard");
                                            army1.Points += 50;
                                            army1.PL += 6;
                                            elitep.Add(50);
                                            epl.Add(6);
                                        }
                                        if (elites == 17)
                                        {
                                            elite.Add("Ogryns");
                                            army1.Points += 75;
                                            army1.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 18)
                                        {
                                            elite.Add("Platoon Commander");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 19)
                                        {
                                            elite.Add("Ratlings");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 20)
                                        {
                                            elite.Add("Rein and Raus");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 21)
                                        {
                                            elite.Add("Special Weapons Squad");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 22)
                                        {
                                            elite.Add("Veterans");
                                            army1.Points += 65;
                                            army1.PL += 5;
                                            elitep.Add(65);
                                            epl.Add(5);
                                        }
                                        if (elites == 23)
                                        {
                                            elite.Add("Voidsmen-at-arms");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 24)
                                        {
                                            elite.Add("Wyrdvane Psykers");
                                            army1.Points += 24;
                                            army1.PL += 1;
                                            elitep.Add(24);
                                            epl.Add(1);
                                        }
                                    }
                                }
                                if (army1.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Astropath");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Bullgryns");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Colour Sergeant Kell");
                                            army1.Points += 45;
                                            army1.PL += 3;
                                            elitep.Add(45);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Combat Engineer Squad");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Command Squad");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Commissar");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Commissar Severina Raine");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Crusaders");
                                            army1.Points += 32;
                                            army1.PL += 2;
                                            elitep.Add(32);
                                            epl.Add(2);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Death Rider Command Squad");
                                            army1.Points += 85;
                                            army1.PL += 3;
                                            elitep.Add(85);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Gotfret de Montbard");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Master of Ordnance");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Millitarum Tempestus Command Squad");
                                            army1.Points += 40;
                                            army1.PL += 3;
                                            elitep.Add(40);
                                            epl.Add(3);
                                        }
                                        if (elites == 13)
                                        {
                                            elite.Add("Ministorum Priest");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 14)
                                        {
                                            elite.Add("Nork Deddog");
                                            army1.Points += 60;
                                            army1.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 15)
                                        {
                                            elite.Add("Officer of the Fleet");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 16)
                                        {
                                            elite.Add("Ogryn Bodyguard");
                                            army1.Points += 50;
                                            army1.PL += 6;
                                            elitep.Add(50);
                                            epl.Add(6);
                                        }
                                        if (elites == 17)
                                        {
                                            elite.Add("Ogryns");
                                            army1.Points += 75;
                                            army1.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 18)
                                        {
                                            elite.Add("Platoon Commander");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 19)
                                        {
                                            elite.Add("Ratlings");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 20)
                                        {
                                            elite.Add("Rein and Raus");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 21)
                                        {
                                            elite.Add("Special Weapons Squad");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 22)
                                        {
                                            elite.Add("Veterans");
                                            army1.Points += 65;
                                            army1.PL += 5;
                                            elitep.Add(65);
                                            epl.Add(5);
                                        }
                                        if (elites == 23)
                                        {
                                            elite.Add("Voidsmen-at-arms");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 24)
                                        {
                                            elite.Add("Wyrdvane Psykers");
                                            army1.Points += 24;
                                            army1.PL += 1;
                                            elitep.Add(24);
                                            epl.Add(1);
                                        }
                                    }
                                }
                                if (army1.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Astropath");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Bullgryns");
                                            army1.Points += 105;
                                            army1.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Colour Sergeant Kell");
                                            army1.Points += 45;
                                            army1.PL += 3;
                                            elitep.Add(45);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Combat Engineer Squad");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Command Squad");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Commissar");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Commissar Severina Raine");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Crusaders");
                                            army1.Points += 32;
                                            army1.PL += 2;
                                            elitep.Add(32);
                                            epl.Add(2);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Death Rider Command Squad");
                                            army1.Points += 85;
                                            army1.PL += 3;
                                            elitep.Add(85);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Gotfret de Montbard");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Master of Ordnance");
                                            army1.Points += 35;
                                            army1.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Millitarum Tempestus Command Squad");
                                            army1.Points += 40;
                                            army1.PL += 3;
                                            elitep.Add(40);
                                            epl.Add(3);
                                        }
                                        if (elites == 13)
                                        {
                                            elite.Add("Ministorum Priest");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 14)
                                        {
                                            elite.Add("Nork Deddog");
                                            army1.Points += 60;
                                            army1.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 15)
                                        {
                                            elite.Add("Officer of the Fleet");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 16)
                                        {
                                            elite.Add("Ogryn Bodyguard");
                                            army1.Points += 50;
                                            army1.PL += 6;
                                            elitep.Add(50);
                                            epl.Add(6);
                                        }
                                        if (elites == 17)
                                        {
                                            elite.Add("Ogryns");
                                            army1.Points += 75;
                                            army1.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 18)
                                        {
                                            elite.Add("Platoon Commander");
                                            army1.Points += 25;
                                            army1.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 19)
                                        {
                                            elite.Add("Ratlings");
                                            army1.Points += 50;
                                            army1.PL += 2;
                                            elitep.Add(50);
                                            epl.Add(2);
                                        }
                                        if (elites == 20)
                                        {
                                            elite.Add("Rein and Raus");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 21)
                                        {
                                            elite.Add("Special Weapons Squad");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 22)
                                        {
                                            elite.Add("Veterans");
                                            army1.Points += 65;
                                            army1.PL += 5;
                                            elitep.Add(65);
                                            epl.Add(5);
                                        }
                                        if (elites == 23)
                                        {
                                            elite.Add("Voidsmen-at-arms");
                                            army1.Points += 40;
                                            army1.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 24)
                                        {
                                            elite.Add("Wyrdvane Psykers");
                                            army1.Points += 24;
                                            army1.PL += 1;
                                            elitep.Add(24);
                                            epl.Add(1);
                                        }
                                    }
                                }
                            }
                        }
                        if (choice == 2)
                        {
                            if (army2.Faction == 1)
                            {
                                Console.WriteLine("1 - Beasts of Nurgle");
                                Console.WriteLine("2 - Bloodcrushers");
                                Console.WriteLine("3 - Exalted Flamers");
                                Console.WriteLine("4 - Fiends");
                                Console.WriteLine("5 - Flamers");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if(army2.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Beasts of Nurgel");
                                            army2.Points += 35;
                                            army2.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if(elites == 2)
                                        {
                                            elite.Add("Bloodcrushers");
                                            army2.Points += 120;
                                            army2.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Exalted Flamers");
                                            army2.Points += 60;
                                            army2.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fiends");
                                            army2.Points += 40;
                                            army2.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Flamers");
                                            army2.Points += 69;
                                            army2.PL += 3;
                                            elitep.Add(69);
                                            epl.Add(3);
                                        }
                                    }
                                    
                                }
                                if (army2.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Beasts of Nurgel");
                                            army2.Points += 35;
                                            army2.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Bloodcrushers");
                                            army2.Points += 120;
                                            army2.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Exalted Flamers");
                                            army2.Points += 60;
                                            army2.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fiends");
                                            army2.Points += 40;
                                            army2.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Flamers");
                                            army2.Points += 69;
                                            army2.PL += 3;
                                            elitep.Add(69);
                                            epl.Add(3);
                                        }
                                    }

                                }
                                if (army2.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Beasts of Nurgel");
                                            army2.Points += 35;
                                            army2.PL += 2;
                                            elitep.Add(35);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Bloodcrushers");
                                            army2.Points += 120;
                                            army2.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Exalted Flamers");
                                            army2.Points += 60;
                                            army2.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fiends");
                                            army2.Points += 40;
                                            army2.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Flamers");
                                            army2.Points += 69;
                                            army2.PL += 3;
                                            elitep.Add(69);
                                            epl.Add(3);
                                        }
                                    }

                                }
                            }
                            if (army2.Faction == 2)
                            {
                                Console.WriteLine("1 - Biologus Putrifier");
                                Console.WriteLine("2 - Blightlord Terminators");
                                Console.WriteLine("3 - Possessed");
                                Console.WriteLine("4 - Deathshroud Terminators");
                                Console.WriteLine("5 - Foul Blightspawn");
                                Console.WriteLine("6 - Helbrute");
                                Console.WriteLine("7 - Noxious Blightbringer");
                                Console.WriteLine("8 - Plague Surgeon");
                                Console.WriteLine("9 - Tallyman");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if(army2.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if(elites == 1)
                                        {
                                            elite.Add("Biologus Putrifier");
                                            army2.Points += 65;
                                            army2.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Blightlord Terminators");
                                            army2.Points += 200;
                                            army2.PL += 10;
                                            elitep.Add(200);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Possessed");
                                            army2.Points += 120;
                                            army2.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Deathshroud Terminators");
                                            army2.Points += 150;
                                            army2.PL += 7;
                                            elitep.Add(150);
                                            epl.Add(7);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Foul Blightspawn");
                                            army2.Points += 75;
                                            army2.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 120;
                                            army2.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Noxious Blightbringer");
                                            army2.Points += 60;
                                            army2.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Plague Surgeon");
                                            army2.Points += 75;
                                            army2.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Tallyman");
                                            army2.Points += 70;
                                            army2.PL += 5;
                                            elitep.Add(70);
                                            epl.Add(5);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Biologus Putrifier");
                                            army2.Points += 65;
                                            army2.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Blightlord Terminators");
                                            army2.Points += 200;
                                            army2.PL += 10;
                                            elitep.Add(200);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Possessed");
                                            army2.Points += 120;
                                            army2.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Deathshroud Terminators");
                                            army2.Points += 150;
                                            army2.PL += 7;
                                            elitep.Add(150);
                                            epl.Add(7);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Foul Blightspawn");
                                            army2.Points += 75;
                                            army2.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 120;
                                            army2.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Noxious Blightbringer");
                                            army2.Points += 60;
                                            army2.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Plague Surgeon");
                                            army2.Points += 75;
                                            army2.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Tallyman");
                                            army2.Points += 70;
                                            army2.PL += 5;
                                            elitep.Add(70);
                                            epl.Add(5);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Biologus Putrifier");
                                            army2.Points += 65;
                                            army2.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Blightlord Terminators");
                                            army2.Points += 200;
                                            army2.PL += 10;
                                            elitep.Add(200);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Possessed");
                                            army2.Points += 120;
                                            army2.PL += 6;
                                            elitep.Add(120);
                                            epl.Add(6);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Deathshroud Terminators");
                                            army2.Points += 150;
                                            army2.PL += 7;
                                            elitep.Add(150);
                                            epl.Add(7);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Foul Blightspawn");
                                            army2.Points += 75;
                                            army2.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 120;
                                            army2.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Noxious Blightbringer");
                                            army2.Points += 60;
                                            army2.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Plague Surgeon");
                                            army2.Points += 75;
                                            army2.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Tallyman");
                                            army2.Points += 70;
                                            army2.PL += 5;
                                            elitep.Add(70);
                                            epl.Add(5);
                                        }
                                    }
                                }
                            }
                            if (army2.Faction == 3)
                            {
                                Console.WriteLine("1 - Greater Possessed");
                                Console.WriteLine("2 - Helbrute");
                                Console.WriteLine("3 - Mutilators");
                                Console.WriteLine("4 - Possessed");
                                Console.WriteLine("5 - Terminators");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army2.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if(elites == 1)
                                        {
                                            elite.Add("Greater Possessed");
                                            army2.Points += 65;
                                            army2.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 115;
                                            army2.PL += 6;
                                            elitep.Add(115);
                                            epl.Add(6);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Mutilators");
                                            army2.Points += 105;
                                            army2.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Possessed");
                                            army2.Points += 100;
                                            army2.PL += 5;
                                            elitep.Add(100);
                                            epl.Add(5);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Terminators");
                                            army2.Points += 140;
                                            army2.PL += 8;
                                            elitep.Add(140);
                                            epl.Add(8);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Greater Possessed");
                                            army2.Points += 65;
                                            army2.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 115;
                                            army2.PL += 6;
                                            elitep.Add(115);
                                            epl.Add(6);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Mutilators");
                                            army2.Points += 105;
                                            army2.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Possessed");
                                            army2.Points += 100;
                                            army2.PL += 5;
                                            elitep.Add(100);
                                            epl.Add(5);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Terminators");
                                            army2.Points += 140;
                                            army2.PL += 8;
                                            elitep.Add(140);
                                            epl.Add(8);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Greater Possessed");
                                            army2.Points += 65;
                                            army2.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 115;
                                            army2.PL += 6;
                                            elitep.Add(115);
                                            epl.Add(6);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Mutilators");
                                            army2.Points += 105;
                                            army2.PL += 5;
                                            elitep.Add(105);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Possessed");
                                            army2.Points += 100;
                                            army2.PL += 5;
                                            elitep.Add(100);
                                            epl.Add(5);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Terminators");
                                            army2.Points += 140;
                                            army2.PL += 8;
                                            elitep.Add(140);
                                            epl.Add(8);
                                        }
                                    }
                                }
                            }
                            if (army2.Faction == 4)
                            {
                                Console.WriteLine("1 - Scarab Occult Terminators");
                                Console.WriteLine("2 - Tzaangor Shaman");
                                Console.WriteLine("3 - Helbrute");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if(army2.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if(elites == 1)
                                        {
                                            elite.Add("Scarab Occult Terminators");
                                            army2.Points += 200;
                                            army2.PL += 10;
                                            elitep.Add(200);
                                            epl.Add(10);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Tzaangor Shaman");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 125;
                                            army2.PL += 7;
                                            elitep.Add(125);
                                            epl.Add(7);
                                        }
                                    }
                                }
                                if (army2.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Scarab Occult Terminators");
                                            army2.Points += 200;
                                            army2.PL += 10;
                                            elitep.Add(200);
                                            epl.Add(10);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Tzaangor Shaman");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 125;
                                            army2.PL += 7;
                                            elitep.Add(125);
                                            epl.Add(7);
                                        }
                                    }
                                }
                                if (army2.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Scarab Occult Terminators");
                                            army2.Points += 200;
                                            army2.PL += 10;
                                            elitep.Add(200);
                                            epl.Add(10);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Tzaangor Shaman");
                                            army2.Points += 70;
                                            army2.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Helbrute");
                                            army2.Points += 125;
                                            army2.PL += 7;
                                            elitep.Add(125);
                                            epl.Add(7);
                                        }
                                    }
                                }
                            }
                        }
                        if (choice == 3)
                        {
                            if (army3.Faction == 1)
                            {
                                Console.WriteLine("1 - Howling Banshees");
                                Console.WriteLine("2 - Wraithguard");
                                Console.WriteLine("3 - Striking Scorpions");
                                Console.WriteLine("4 - Fire Dragons");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if(elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Howling Banshees");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if(elites == 2)
                                        {
                                            elite.Add("Wraithguard");
                                            army3.Points += 175;
                                            army3.PL += 10;
                                            elitep.Add(175);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Striking Scorpions");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fire Dragons");
                                            army3.Points += 100;
                                            army3.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Howling Banshees");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Wraithguard");
                                            army3.Points += 175;
                                            army3.PL += 10;
                                            elitep.Add(175);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Striking Scorpions");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fire Dragons");
                                            army3.Points += 100;
                                            army3.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Howling Banshees");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Wraithguard");
                                            army3.Points += 175;
                                            army3.PL += 10;
                                            elitep.Add(175);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Striking Scorpions");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fire Dragons");
                                            army3.Points += 100;
                                            army3.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                    }
                                }
                            }

                            if (army3.Faction == 2)
                            {
                                Console.WriteLine("1 - Incubi");
                                Console.WriteLine("2 - Medusae");
                                Console.WriteLine("3 - Lhamaean");
                                Console.WriteLine("4 - Sslyth");
                                Console.WriteLine("5 - Ur-Ghul");
                                Console.WriteLine("6 - Grotesque");
                                Console.WriteLine("7 - Beastmaster");
                                Console.WriteLine("8 - Mandrakes");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Incubi");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Medusae");
                                            army3.Points += 22;
                                            army3.PL += 5;
                                            elitep.Add(22);
                                            epl.Add(5);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Lhamaean");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Sslyth");
                                            army3.Points += 18;
                                            army3.PL += 5;
                                            elitep.Add(18);
                                            epl.Add(5);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Ur-Ghul");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Grotesque");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Beastmaster");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Mandrakes");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Incubi");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Medusae");
                                            army3.Points += 22;
                                            army3.PL += 5;
                                            elitep.Add(22);
                                            epl.Add(5);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Lhamaean");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Sslyth");
                                            army3.Points += 18;
                                            army3.PL += 5;
                                            elitep.Add(18);
                                            epl.Add(5);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Ur-Ghul");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Grotesque");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Beastmaster");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Mandrakes");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Incubi");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Medusae");
                                            army3.Points += 22;
                                            army3.PL += 5;
                                            elitep.Add(22);
                                            epl.Add(5);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Lhamaean");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Sslyth");
                                            army3.Points += 18;
                                            army3.PL += 5;
                                            elitep.Add(18);
                                            epl.Add(5);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Ur-Ghul");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Grotesque");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Beastmaster");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Mandrakes");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 3)
                            {
                                Console.WriteLine("1 - Aberrants");
                                Console.WriteLine("3 - Biophagus");
                                Console.WriteLine("4 - Clamavus");
                                Console.WriteLine("5 - Hybrid Metamorphs");
                                Console.WriteLine("6 - Kelermorph");
                                Console.WriteLine("7 - Locus");
                                Console.WriteLine("8 - Nexos");
                                Console.WriteLine("9 - Purestrain Genestealers");
                                Console.WriteLine("7 - Sanctus");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Aberrants");
                                            army3.Points += 175;
                                            army3.PL += 8;
                                            elitep.Add(175);
                                            epl.Add(8);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Biophagus");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Clamavus");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Hybrid Metamorphs");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Kelermorph");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Locus");
                                            army3.Points += 45;
                                            army3.PL += 3;
                                            elitep.Add(45);
                                            epl.Add(3);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Nexos");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Purestrain Genestealers");
                                            army3.Points += 75;
                                            army3.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Sanctus");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Aberrants");
                                            army3.Points += 175;
                                            army3.PL += 8;
                                            elitep.Add(175);
                                            epl.Add(8);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Biophagus");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Clamavus");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Hybrid Metamorphs");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Kelermorph");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Locus");
                                            army3.Points += 45;
                                            army3.PL += 3;
                                            elitep.Add(45);
                                            epl.Add(3);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Nexos");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Purestrain Genestealers");
                                            army3.Points += 75;
                                            army3.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Sanctus");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Aberrants");
                                            army3.Points += 175;
                                            army3.PL += 8;
                                            elitep.Add(175);
                                            epl.Add(8);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Biophagus");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Clamavus");
                                            army3.Points += 60;
                                            army3.PL += 3;
                                            elitep.Add(60);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Hybrid Metamorphs");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Kelermorph");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Locus");
                                            army3.Points += 45;
                                            army3.PL += 3;
                                            elitep.Add(45);
                                            epl.Add(3);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Nexos");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Purestrain Genestealers");
                                            army3.Points += 75;
                                            army3.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Sanctus");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 4)
                            {
                                Console.WriteLine("1 - Death Jester");
                                Console.WriteLine("2 - Solitaire");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Death Jester");
                                            army3.Points += 50;
                                            army3.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Solitaire");
                                            army3.Points += 100;
                                            army3.PL += 5;
                                            elitep.Add(100);
                                            epl.Add(5);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Death Jester");
                                            army3.Points += 50;
                                            army3.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Solitaire");
                                            army3.Points += 100;
                                            army3.PL += 5;
                                            elitep.Add(100);
                                            epl.Add(5);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Death Jester");
                                            army3.Points += 50;
                                            army3.PL += 3;
                                            elitep.Add(50);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Solitaire");
                                            army3.Points += 100;
                                            army3.PL += 5;
                                            elitep.Add(100);
                                            epl.Add(5);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 5)
                            {
                                Console.WriteLine("1 - Canoptek Plasmacyte");
                                Console.WriteLine("2 - Canoptek Reanimator");
                                Console.WriteLine("3 - Canoptek Spyders");
                                Console.WriteLine("4 - Cryptothralls");
                                Console.WriteLine("5 - C'tan Shard of the Deceiver");
                                Console.WriteLine("6 - C'tan Shard of the Nightbringer");
                                Console.WriteLine("7 - C'tan Shard of the Void Dragon");
                                Console.WriteLine("8 - Deathmarks");
                                Console.WriteLine("9 - Flayed Ones");
                                Console.WriteLine("10 - Hexmark Destroyer");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Canoptek Plasmacyte");
                                            army3.Points += 15;
                                            army3.PL += 1;
                                            elitep.Add(15);
                                            epl.Add(1);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Canoptek Reanimator");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Canoptek Spyders");
                                            army3.Points += 60;
                                            army3.PL += 4;
                                            elitep.Add(60);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Cryptothralls");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("C'tan Shard of the Deceiver");
                                            army3.Points += 350;
                                            army3.PL += 18;
                                            elitep.Add(350);
                                            epl.Add(18);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("C'tan Shard of the Nightbringer");
                                            army3.Points += 370;
                                            army3.PL += 19;
                                            elitep.Add(370);
                                            epl.Add(19);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("C'tan Shard of the Void Dragon");
                                            army3.Points += 350;
                                            army3.PL += 18;
                                            elitep.Add(350);
                                            epl.Add(18);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Deathmarks");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Flayed Ones");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Hexmark Destroyer");
                                            army3.Points += 75;
                                            army3.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Canoptek Plasmacyte");
                                            army3.Points += 15;
                                            army3.PL += 1;
                                            elitep.Add(15);
                                            epl.Add(1);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Canoptek Reanimator");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Canoptek Spyders");
                                            army3.Points += 60;
                                            army3.PL += 4;
                                            elitep.Add(60);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Cryptothralls");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("C'tan Shard of the Deceiver");
                                            army3.Points += 350;
                                            army3.PL += 18;
                                            elitep.Add(350);
                                            epl.Add(18);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("C'tan Shard of the Nightbringer");
                                            army3.Points += 370;
                                            army3.PL += 19;
                                            elitep.Add(370);
                                            epl.Add(19);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("C'tan Shard of the Void Dragon");
                                            army3.Points += 350;
                                            army3.PL += 18;
                                            elitep.Add(350);
                                            epl.Add(18);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Deathmarks");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Flayed Ones");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Hexmark Destroyer");
                                            army3.Points += 75;
                                            army3.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Canoptek Plasmacyte");
                                            army3.Points += 15;
                                            army3.PL += 1;
                                            elitep.Add(15);
                                            epl.Add(1);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Canoptek Reanimator");
                                            army3.Points += 80;
                                            army3.PL += 4;
                                            elitep.Add(80);
                                            epl.Add(4);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Canoptek Spyders");
                                            army3.Points += 60;
                                            army3.PL += 4;
                                            elitep.Add(60);
                                            epl.Add(4);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Cryptothralls");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("C'tan Shard of the Deceiver");
                                            army3.Points += 350;
                                            army3.PL += 18;
                                            elitep.Add(350);
                                            epl.Add(18);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("C'tan Shard of the Nightbringer");
                                            army3.Points += 370;
                                            army3.PL += 19;
                                            elitep.Add(370);
                                            epl.Add(19);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("C'tan Shard of the Void Dragon");
                                            army3.Points += 350;
                                            army3.PL += 18;
                                            elitep.Add(350);
                                            epl.Add(18);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Deathmarks");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Flayed Ones");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Hexmark Destroyer");
                                            army3.Points += 75;
                                            army3.PL += 4;
                                            elitep.Add(75);
                                            epl.Add(4);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 6)
                            {
                                Console.WriteLine("1 - Burna Boyz");
                                Console.WriteLine("2 - Kommandos");
                                Console.WriteLine("3 - Mad Dok Grotsnik");
                                Console.WriteLine("4 - Meganobz");
                                Console.WriteLine("5 - Mek");
                                Console.WriteLine("6 - Nob with Waaagh! Banner");
                                Console.WriteLine("7 - Nobz");
                                Console.WriteLine("8 - Tankbustas");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Burna Boyz");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Kommandos");
                                            army3.Points += 50;
                                            army3.PL += 4;
                                            elitep.Add(50);
                                            epl.Add(4);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Mad Dok Grotsnik");
                                            army3.Points += 85;
                                            army3.PL += 5;
                                            elitep.Add(85);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Meganobz");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Mek");
                                            army3.Points += 25;
                                            army3.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Nob with Waaagh! Banner");
                                            army3.Points += 70;
                                            army3.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Nobz");
                                            army3.Points += 90;
                                            army3.PL += 6;
                                            elitep.Add(90);
                                            epl.Add(6);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Tankbustas");
                                            army3.Points += 85;
                                            army3.PL += 4;
                                            elitep.Add(85);
                                            epl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Burna Boyz");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Kommandos");
                                            army3.Points += 50;
                                            army3.PL += 4;
                                            elitep.Add(50);
                                            epl.Add(4);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Mad Dok Grotsnik");
                                            army3.Points += 85;
                                            army3.PL += 5;
                                            elitep.Add(85);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Meganobz");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Mek");
                                            army3.Points += 25;
                                            army3.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Nob with Waaagh! Banner");
                                            army3.Points += 70;
                                            army3.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Nobz");
                                            army3.Points += 90;
                                            army3.PL += 6;
                                            elitep.Add(90);
                                            epl.Add(6);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Tankbustas");
                                            army3.Points += 85;
                                            army3.PL += 4;
                                            elitep.Add(85);
                                            epl.Add(4);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Burna Boyz");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Kommandos");
                                            army3.Points += 50;
                                            army3.PL += 4;
                                            elitep.Add(50);
                                            epl.Add(4);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Mad Dok Grotsnik");
                                            army3.Points += 85;
                                            army3.PL += 5;
                                            elitep.Add(85);
                                            epl.Add(5);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Meganobz");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Mek");
                                            army3.Points += 25;
                                            army3.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Nob with Waaagh! Banner");
                                            army3.Points += 70;
                                            army3.PL += 4;
                                            elitep.Add(70);
                                            epl.Add(4);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Nobz");
                                            army3.Points += 90;
                                            army3.PL += 6;
                                            elitep.Add(90);
                                            epl.Add(6);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Tankbustas");
                                            army3.Points += 85;
                                            army3.PL += 4;
                                            elitep.Add(85);
                                            epl.Add(4);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 7)
                            {
                                Console.WriteLine("1 - Dahyak Grekh");
                                Console.WriteLine("2 - Firesight Marksman");
                                Console.WriteLine("3 - Kroot Shaper");
                                Console.WriteLine("4 - Krootox Riders");
                                Console.WriteLine("5 - XV104 Riptide Battlesuit");
                                Console.WriteLine("6 - XV25 Stealth Battlesuits");
                                Console.WriteLine("7 - XV8 Crisis Battlesuits");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Dahyak Grekh");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Firesight Marksman");
                                            army3.Points += 30;
                                            army3.PL += 2;
                                            elitep.Add(30);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Kroot Shaper");
                                            army3.Points += 25;
                                            army3.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Krootox Riders");
                                            army3.Points += 28;
                                            army3.PL += 1;
                                            elitep.Add(28);
                                            epl.Add(1);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("XV104 Riptide Battlesuit");
                                            army3.Points += 274;
                                            army3.PL += 15;
                                            elitep.Add(274);
                                            epl.Add(15);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("XV25 Stealth Battlesuits");
                                            army3.Points += 78;
                                            army3.PL += 5;
                                            elitep.Add(78);
                                            epl.Add(5);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("XV8 Crisis Battlesuits");
                                            army3.Points += 99;
                                            army3.PL += 8;
                                            elitep.Add(99);
                                            epl.Add(8);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Dahyak Grekh");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Firesight Marksman");
                                            army3.Points += 30;
                                            army3.PL += 2;
                                            elitep.Add(30);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Kroot Shaper");
                                            army3.Points += 25;
                                            army3.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Krootox Riders");
                                            army3.Points += 28;
                                            army3.PL += 1;
                                            elitep.Add(28);
                                            epl.Add(1);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("XV104 Riptide Battlesuit");
                                            army3.Points += 274;
                                            army3.PL += 15;
                                            elitep.Add(274);
                                            epl.Add(15);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("XV25 Stealth Battlesuits");
                                            army3.Points += 78;
                                            army3.PL += 5;
                                            elitep.Add(78);
                                            epl.Add(5);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("XV8 Crisis Battlesuits");
                                            army3.Points += 99;
                                            army3.PL += 8;
                                            elitep.Add(99);
                                            epl.Add(8);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Dahyak Grekh");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Firesight Marksman");
                                            army3.Points += 30;
                                            army3.PL += 2;
                                            elitep.Add(30);
                                            epl.Add(2);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Kroot Shaper");
                                            army3.Points += 25;
                                            army3.PL += 2;
                                            elitep.Add(25);
                                            epl.Add(2);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Krootox Riders");
                                            army3.Points += 28;
                                            army3.PL += 1;
                                            elitep.Add(28);
                                            epl.Add(1);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("XV104 Riptide Battlesuit");
                                            army3.Points += 274;
                                            army3.PL += 15;
                                            elitep.Add(274);
                                            epl.Add(15);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("XV25 Stealth Battlesuits");
                                            army3.Points += 78;
                                            army3.PL += 5;
                                            elitep.Add(78);
                                            epl.Add(5);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("XV8 Crisis Battlesuits");
                                            army3.Points += 99;
                                            army3.PL += 8;
                                            elitep.Add(99);
                                            epl.Add(8);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 8)
                            {
                                Console.WriteLine("1 - Deathleaper");
                                Console.WriteLine("2 - Haruspex");
                                Console.WriteLine("3 - Hive Guard");
                                Console.WriteLine("4 - Lictor");
                                Console.WriteLine("5 - Maleceptor");
                                Console.WriteLine("6 - Pyrovores");
                                Console.WriteLine("7 - The Red Terror");
                                Console.WriteLine("8 - Tyrant Guard");
                                Console.WriteLine("9 - Venomthropes");
                                Console.WriteLine("10 - Zoanthropes");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Deathleaper");
                                            army3.Points += 65;
                                            army3.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Haruspex");
                                            army3.Points += 170;
                                            army3.PL += 9;
                                            elitep.Add(170);
                                            epl.Add(9);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Hive Guard");
                                            army3.Points += 135;
                                            army3.PL += 6;
                                            elitep.Add(135);
                                            epl.Add(6);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Lictor");
                                            army3.Points += 37;
                                            army3.PL += 2;
                                            elitep.Add(37);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Maleceptor");
                                            army3.Points += 170;
                                            army3.PL += 9;
                                            elitep.Add(170);
                                            epl.Add(9);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Pyrovores");
                                            army3.Points += 28;
                                            army3.PL += 1;
                                            elitep.Add(28);
                                            epl.Add(1);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("The Red Terror");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Tyrant Guard");
                                            army3.Points += 120;
                                            army3.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Venomthropes");
                                            army3.Points += 99;
                                            army3.PL += 5;
                                            elitep.Add(99);
                                            epl.Add(5);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Zoanthropes");
                                            army3.Points += 150;
                                            army3.PL += 7;
                                            elitep.Add(150);
                                            epl.Add(7);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Deathleaper");
                                            army3.Points += 65;
                                            army3.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Haruspex");
                                            army3.Points += 170;
                                            army3.PL += 9;
                                            elitep.Add(170);
                                            epl.Add(9);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Hive Guard");
                                            army3.Points += 135;
                                            army3.PL += 6;
                                            elitep.Add(135);
                                            epl.Add(6);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Lictor");
                                            army3.Points += 37;
                                            army3.PL += 2;
                                            elitep.Add(37);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Maleceptor");
                                            army3.Points += 170;
                                            army3.PL += 9;
                                            elitep.Add(170);
                                            epl.Add(9);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Pyrovores");
                                            army3.Points += 28;
                                            army3.PL += 1;
                                            elitep.Add(28);
                                            epl.Add(1);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("The Red Terror");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Tyrant Guard");
                                            army3.Points += 120;
                                            army3.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Venomthropes");
                                            army3.Points += 99;
                                            army3.PL += 5;
                                            elitep.Add(99);
                                            epl.Add(5);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Zoanthropes");
                                            army3.Points += 150;
                                            army3.PL += 7;
                                            elitep.Add(150);
                                            epl.Add(7);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Deathleaper");
                                            army3.Points += 65;
                                            army3.PL += 4;
                                            elitep.Add(65);
                                            epl.Add(4);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Haruspex");
                                            army3.Points += 170;
                                            army3.PL += 9;
                                            elitep.Add(170);
                                            epl.Add(9);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Hive Guard");
                                            army3.Points += 135;
                                            army3.PL += 6;
                                            elitep.Add(135);
                                            epl.Add(6);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Lictor");
                                            army3.Points += 37;
                                            army3.PL += 2;
                                            elitep.Add(37);
                                            epl.Add(2);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Maleceptor");
                                            army3.Points += 170;
                                            army3.PL += 9;
                                            elitep.Add(170);
                                            epl.Add(9);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Pyrovores");
                                            army3.Points += 28;
                                            army3.PL += 1;
                                            elitep.Add(28);
                                            epl.Add(1);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("The Red Terror");
                                            army3.Points += 55;
                                            army3.PL += 3;
                                            elitep.Add(55);
                                            epl.Add(3);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Tyrant Guard");
                                            army3.Points += 120;
                                            army3.PL += 7;
                                            elitep.Add(120);
                                            epl.Add(7);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Venomthropes");
                                            army3.Points += 99;
                                            army3.PL += 5;
                                            elitep.Add(99);
                                            epl.Add(5);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Zoanthropes");
                                            army3.Points += 150;
                                            army3.PL += 7;
                                            elitep.Add(150);
                                            epl.Add(7);
                                        }
                                    }
                                }
                            }
                            if (army3.Faction == 9)
                            {
                                Console.WriteLine("1 - Howling Banshees");
                                Console.WriteLine("2 - Wraithguard");
                                Console.WriteLine("3 - Striking Scorpions");
                                Console.WriteLine("4 - Fire Dragons");
                                Console.WriteLine("5 - Incubi");
                                Console.WriteLine("6 - Medusae");
                                Console.WriteLine("7 - Lhamaean");
                                Console.WriteLine("8 - Sslyth");
                                Console.WriteLine("9 - Ur-Ghul");
                                Console.WriteLine("10 - Grotesque");
                                Console.WriteLine("11 - Beastmaster");
                                Console.WriteLine("12 - Mandrakes");
                                elites = Convert.ToInt32(Console.ReadLine());
                                if (army3.detachment == 1)
                                {
                                    if (elite.Count < 2)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Howling Banshees");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Wraithguard");
                                            army3.Points += 175;
                                            army3.PL += 10;
                                            elitep.Add(175);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Striking Scorpions");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fire Dragons");
                                            army3.Points += 100;
                                            army3.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Incubi");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Medusae");
                                            army3.Points += 22;
                                            army3.PL += 5;
                                            elitep.Add(22);
                                            epl.Add(5);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Lhamaean");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Sslyth");
                                            army3.Points += 18;
                                            army3.PL += 5;
                                            elitep.Add(18);
                                            epl.Add(5);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Ur-Ghul");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Grotesque");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Beastmaster");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Mandrakes");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 2)
                                {
                                    if (elite.Count < 6)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Howling Banshees");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Wraithguard");
                                            army3.Points += 175;
                                            army3.PL += 10;
                                            elitep.Add(175);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Striking Scorpions");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fire Dragons");
                                            army3.Points += 100;
                                            army3.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Incubi");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Medusae");
                                            army3.Points += 22;
                                            army3.PL += 5;
                                            elitep.Add(22);
                                            epl.Add(5);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Lhamaean");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Sslyth");
                                            army3.Points += 18;
                                            army3.PL += 5;
                                            elitep.Add(18);
                                            epl.Add(5);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Ur-Ghul");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Grotesque");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Beastmaster");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Mandrakes");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                    }
                                }
                                if (army3.detachment == 3)
                                {
                                    if (elite.Count < 8)
                                    {
                                        if (elites == 1)
                                        {
                                            elite.Add("Howling Banshees");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                        if (elites == 2)
                                        {
                                            elite.Add("Wraithguard");
                                            army3.Points += 175;
                                            army3.PL += 10;
                                            elitep.Add(175);
                                            epl.Add(10);
                                        }
                                        if (elites == 3)
                                        {
                                            elite.Add("Striking Scorpions");
                                            army3.Points += 65;
                                            army3.PL += 3;
                                            elitep.Add(65);
                                            epl.Add(3);
                                        }
                                        if (elites == 4)
                                        {
                                            elite.Add("Fire Dragons");
                                            army3.Points += 100;
                                            army3.PL += 6;
                                            elitep.Add(100);
                                            epl.Add(6);
                                        }
                                        if (elites == 5)
                                        {
                                            elite.Add("Incubi");
                                            army3.Points += 90;
                                            army3.PL += 4;
                                            elitep.Add(90);
                                            epl.Add(4);
                                        }
                                        if (elites == 6)
                                        {
                                            elite.Add("Medusae");
                                            army3.Points += 22;
                                            army3.PL += 5;
                                            elitep.Add(22);
                                            epl.Add(5);
                                        }
                                        if (elites == 7)
                                        {
                                            elite.Add("Lhamaean");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 8)
                                        {
                                            elite.Add("Sslyth");
                                            army3.Points += 18;
                                            army3.PL += 5;
                                            elitep.Add(18);
                                            epl.Add(5);
                                        }
                                        if (elites == 9)
                                        {
                                            elite.Add("Ur-Ghul");
                                            army3.Points += 16;
                                            army3.PL += 5;
                                            elitep.Add(16);
                                            epl.Add(5);
                                        }
                                        if (elites == 10)
                                        {
                                            elite.Add("Grotesque");
                                            army3.Points += 105;
                                            army3.PL += 6;
                                            elitep.Add(105);
                                            epl.Add(6);
                                        }
                                        if (elites == 11)
                                        {
                                            elite.Add("Beastmaster");
                                            army3.Points += 40;
                                            army3.PL += 2;
                                            elitep.Add(40);
                                            epl.Add(2);
                                        }
                                        if (elites == 12)
                                        {
                                            elite.Add("Mandrakes");
                                            army3.Points += 75;
                                            army3.PL += 3;
                                            elitep.Add(75);
                                            epl.Add(3);
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 4:
                        if (choice == 1)
                        {
                            if (army1.Faction == 1)
                            {

                            }
                            if (army1.Faction == 2)
                            {

                            }
                            if (army1.Faction == 3)
                            {

                            }
                            if (army1.Faction == 4)
                            {

                            }
                            if (army1.Faction == 5)
                            {

                            }
                        }
                        if (choice == 2)
                        {
                            if (army2.Faction == 1)
                            {

                            }
                            if (army2.Faction == 2)
                            {

                            }
                            if (army2.Faction == 3)
                            {

                            }
                            if (army2.Faction == 4)
                            {

                            }
                        }
                        if (choice == 3)
                        {
                            if (army3.Faction == 1)
                            {

                            }
                            if (army3.Faction == 2)
                            {

                            }
                            if (army3.Faction == 3)
                            {

                            }
                            if (army3.Faction == 4)
                            {

                            }
                            if (army3.Faction == 5)
                            {

                            }
                            if (army3.Faction == 6)
                            {

                            }
                            if (army3.Faction == 7)
                            {

                            }
                            if (army3.Faction == 8)
                            {

                            }
                            if (army3.Faction == 9)
                            {

                            }
                        }
                        break;
                    case 5:
                        if (choice == 1)
                        {
                            if (army1.Faction == 1)
                            {

                            }
                            if (army1.Faction == 2)
                            {

                            }
                            if (army1.Faction == 3)
                            {

                            }
                            if (army1.Faction == 4)
                            {

                            }
                            if (army1.Faction == 5)
                            {

                            }
                        }
                        if (choice == 2)
                        {
                            if (army2.Faction == 1)
                            {

                            }
                            if (army2.Faction == 2)
                            {

                            }
                            if (army2.Faction == 3)
                            {

                            }
                            if (army2.Faction == 4)
                            {

                            }
                        }
                        if (choice == 3)
                        {
                            if (army3.Faction == 1)
                            {

                            }
                            if (army3.Faction == 2)
                            {

                            }
                            if (army3.Faction == 3)
                            {

                            }
                            if (army3.Faction == 4)
                            {

                            }
                            if (army3.Faction == 5)
                            {

                            }
                            if (army3.Faction == 6)
                            {

                            }
                            if (army3.Faction == 7)
                            {

                            }
                            if (army3.Faction == 8)
                            {

                            }
                            if (army3.Faction == 9)
                            {

                            }
                        }
                        break;
                    case 6:
                        if (choice == 1)
                        {
                            if (army1.Faction == 1)
                            {

                            }
                            if (army1.Faction == 2)
                            {

                            }
                            if (army1.Faction == 3)
                            {

                            }
                            if (army1.Faction == 4)
                            {

                            }
                            if (army1.Faction == 5)
                            {

                            }
                        }
                        if (choice == 2)
                        {
                            if (army2.Faction == 1)
                            {

                            }
                            if (army2.Faction == 2)
                            {

                            }
                            if (army2.Faction == 3)
                            {

                            }
                            if (army2.Faction == 4)
                            {

                            }
                        }
                        if (choice == 3)
                        {
                            if (army3.Faction == 1)
                            {

                            }
                            if (army3.Faction == 2)
                            {

                            }
                            if (army3.Faction == 3)
                            {

                            }
                            if (army3.Faction == 4)
                            {

                            }
                            if (army3.Faction == 5)
                            {

                            }
                            if (army3.Faction == 6)
                            {

                            }
                            if (army3.Faction == 7)
                            {

                            }
                            if (army3.Faction == 8)
                            {

                            }
                            if (army3.Faction == 9)
                            {

                            }
                        }
                        break;
                    case 7:
                        if (choice == 1)
                        {
                            if (army1.Faction == 1)
                            {

                            }
                            if (army1.Faction == 2)
                            {

                            }
                            if (army1.Faction == 3)
                            {

                            }
                            if (army1.Faction == 4)
                            {

                            }
                            if (army1.Faction == 5)
                            {

                            }
                        }
                        if (choice == 2)
                        {
                            if (army2.Faction == 1)
                            {

                            }
                            if (army2.Faction == 2)
                            {

                            }
                            if (army2.Faction == 3)
                            {

                            }
                            if (army2.Faction == 4)
                            {

                            }
                        }
                        if (choice == 3)
                        {
                            if (army3.Faction == 1)
                            {

                            }
                            if (army3.Faction == 2)
                            {

                            }
                            if (army3.Faction == 3)
                            {

                            }
                            if (army3.Faction == 4)
                            {

                            }
                            if (army3.Faction == 5)
                            {

                            }
                            if (army3.Faction == 6)
                            {

                            }
                            if (army3.Faction == 7)
                            {

                            }
                            if (army3.Faction == 8)
                            {

                            }
                            if (army3.Faction == 9)
                            {

                            }
                        }
                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("What would you like to remove?\n");
                        Console.WriteLine("1 - Hq\n");
                        Console.WriteLine("2 - Troop\n");
                        Console.WriteLine("3 - Elite\n");
                        Console.WriteLine("4 - Heavy Support\n");
                        Console.WriteLine("5 - Fast Attack\n");
                        Console.WriteLine("6 - Flyer\n");
                        Console.WriteLine("7 - Dedicated Transport\n");
                        remove = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        if (choice == 1)
                        {
                            if (army1.Faction == 1)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army1.Points -= hqp.ElementAt(remove);
                                        army1.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army1.Points -= troopp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army1.Points -= elitep.ElementAt(remove);
                                        army1.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army1.Points -= heavyp.ElementAt(remove);
                                        army1.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army1.Points -= fastp.ElementAt(remove);
                                        army1.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army1.Points -= flyerp.ElementAt(remove);
                                        army1.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army1.Points -= transportp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army1.Faction == 2)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army1.Points -= hqp.ElementAt(remove);
                                        army1.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army1.Points -= troopp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army1.Points -= elitep.ElementAt(remove);
                                        army1.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army1.Points -= heavyp.ElementAt(remove);
                                        army1.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army1.Points -= fastp.ElementAt(remove);
                                        army1.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army1.Points -= flyerp.ElementAt(remove);
                                        army1.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army1.Points -= transportp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army1.Faction == 3)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army1.Points -= hqp.ElementAt(remove);
                                        army1.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army1.Points -= troopp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army1.Points -= elitep.ElementAt(remove);
                                        army1.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army1.Points -= heavyp.ElementAt(remove);
                                        army1.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army1.Points -= fastp.ElementAt(remove);
                                        army1.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army1.Points -= flyerp.ElementAt(remove);
                                        army1.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army1.Points -= transportp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army1.Faction == 4)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army1.Points -= hqp.ElementAt(remove);
                                        army1.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army1.Points -= troopp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army1.Points -= elitep.ElementAt(remove);
                                        army1.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army1.Points -= heavyp.ElementAt(remove);
                                        army1.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army1.Points -= fastp.ElementAt(remove);
                                        army1.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army1.Points -= flyerp.ElementAt(remove);
                                        army1.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army1.Points -= transportp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army1.Faction == 5)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army1.Points -= hqp.ElementAt(remove);
                                        army1.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army1.Points -= troopp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army1.Points -= elitep.ElementAt(remove);
                                        army1.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army1.Points -= heavyp.ElementAt(remove);
                                        army1.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army1.Points -= fastp.ElementAt(remove);
                                        army1.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army1.Points -= flyerp.ElementAt(remove);
                                        army1.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army1.Points -= transportp.ElementAt(remove);
                                        army1.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                        }
                        if (choice == 2)
                        {
                            if (army2.Faction == 1)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army2.Points -= hqp.ElementAt(remove);
                                        army2.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army2.Points -= troopp.ElementAt(remove);
                                        army2.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army2.Points -= elitep.ElementAt(remove);
                                        army2.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army2.Points -= heavyp.ElementAt(remove);
                                        army2.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army2.Points -= fastp.ElementAt(remove);
                                        army2.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army2.Points -= flyerp.ElementAt(remove);
                                        army2.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army2.Points -= transportp.ElementAt(remove);
                                        army2.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army2.Faction == 2)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army2.Points -= hqp.ElementAt(remove);
                                        army2.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army2.Points -= troopp.ElementAt(remove);
                                        army2.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army2.Points -= elitep.ElementAt(remove);
                                        army2.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army2.Points -= heavyp.ElementAt(remove);
                                        army2.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army2.Points -= fastp.ElementAt(remove);
                                        army2.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army2.Points -= flyerp.ElementAt(remove);
                                        army2.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army2.Points -= transportp.ElementAt(remove);
                                        army2.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army2.Faction == 3)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army2.Points -= hqp.ElementAt(remove);
                                        army2.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army2.Points -= troopp.ElementAt(remove);
                                        army2.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army2.Points -= elitep.ElementAt(remove);
                                        army2.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army2.Points -= heavyp.ElementAt(remove);
                                        army2.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army2.Points -= fastp.ElementAt(remove);
                                        army2.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army2.Points -= flyerp.ElementAt(remove);
                                        army2.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army2.Points -= transportp.ElementAt(remove);
                                        army2.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army2.Faction == 4)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army2.Points -= hqp.ElementAt(remove);
                                        army2.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army2.Points -= troopp.ElementAt(remove);
                                        army2.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army2.Points -= elitep.ElementAt(remove);
                                        army2.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army2.Points -= heavyp.ElementAt(remove);
                                        army2.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army2.Points -= fastp.ElementAt(remove);
                                        army2.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army2.Points -= flyerp.ElementAt(remove);
                                        army2.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army2.Points -= transportp.ElementAt(remove);
                                        army2.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                        }
                        if (choice == 3)
                        {
                            if (army3.Faction == 1)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army3.Points -= hqp.ElementAt(remove);
                                        army3.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army3.Points -= troopp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army3.Points -= elitep.ElementAt(remove);
                                        army3.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army3.Points -= heavyp.ElementAt(remove);
                                        army3.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army3.Points -= fastp.ElementAt(remove);
                                        army3.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army3.Points -= flyerp.ElementAt(remove);
                                        army3.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army3.Points -= transportp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army3.Faction == 2)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army3.Points -= hqp.ElementAt(remove);
                                        army3.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army3.Points -= troopp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army3.Points -= elitep.ElementAt(remove);
                                        army3.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army3.Points -= heavyp.ElementAt(remove);
                                        army3.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army3.Points -= fastp.ElementAt(remove);
                                        army3.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army3.Points -= flyerp.ElementAt(remove);
                                        army3.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army3.Points -= transportp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army3.Faction == 3)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army3.Points -= hqp.ElementAt(remove);
                                        army3.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army3.Points -= troopp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army3.Points -= elitep.ElementAt(remove);
                                        army3.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army3.Points -= heavyp.ElementAt(remove);
                                        army3.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army3.Points -= fastp.ElementAt(remove);
                                        army3.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army3.Points -= flyerp.ElementAt(remove);
                                        army3.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army3.Points -= transportp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army3.Faction == 5)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army3.Points -= hqp.ElementAt(remove);
                                        army3.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army3.Points -= troopp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army3.Points -= elitep.ElementAt(remove);
                                        army3.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army3.Points -= heavyp.ElementAt(remove);
                                        army3.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army3.Points -= fastp.ElementAt(remove);
                                        army3.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army3.Points -= flyerp.ElementAt(remove);
                                        army3.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army3.Points -= transportp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army3.Faction == 6)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army3.Points -= hqp.ElementAt(remove);
                                        army3.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army3.Points -= troopp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army3.Points -= elitep.ElementAt(remove);
                                        army3.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army3.Points -= heavyp.ElementAt(remove);
                                        army3.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army3.Points -= fastp.ElementAt(remove);
                                        army3.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army3.Points -= flyerp.ElementAt(remove);
                                        army3.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army3.Points -= transportp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army3.Faction == 7)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army3.Points -= hqp.ElementAt(remove);
                                        army3.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army3.Points -= troopp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army3.Points -= elitep.ElementAt(remove);
                                        army3.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army3.Points -= heavyp.ElementAt(remove);
                                        army3.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army3.Points -= fastp.ElementAt(remove);
                                        army3.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army3.Points -= flyerp.ElementAt(remove);
                                        army3.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army3.Points -= transportp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army3.Faction == 8)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army3.Points -= hqp.ElementAt(remove);
                                        army3.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army3.Points -= troopp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army3.Points -= elitep.ElementAt(remove);
                                        army3.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army3.Points -= heavyp.ElementAt(remove);
                                        army3.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army3.Points -= fastp.ElementAt(remove);
                                        army3.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army3.Points -= flyerp.ElementAt(remove);
                                        army3.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army3.Points -= transportp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                            if (army3.Faction == 9)
                            {
                                if (remove == 1)
                                {
                                    if (hq.Count == 0)
                                    {
                                        Console.WriteLine("There are no HQs in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < hq.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + hq[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        hq.RemoveAt(remove);
                                        army3.Points -= hqp.ElementAt(remove);
                                        army3.PL -= hpl.ElementAt(remove);
                                        hqp.RemoveAt(remove);
                                        hpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 2)
                                {
                                    if (troop.Count == 0)
                                    {
                                        Console.WriteLine("There are no troops in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < troop.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + troop[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        troop.RemoveAt(remove);
                                        army3.Points -= troopp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        troopp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 3)
                                {
                                    if (elite.Count == 0)
                                    {
                                        Console.WriteLine("There are no elites in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < elite.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + elite[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        elite.RemoveAt(remove);
                                        army3.Points -= elitep.ElementAt(remove);
                                        army3.PL -= epl.ElementAt(remove);
                                        elitep.RemoveAt(remove);
                                        epl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 4)
                                {
                                    if (heavy.Count == 0)
                                    {
                                        Console.WriteLine("There are no heavy supports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < heavy.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + heavy[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        heavy.RemoveAt(remove);
                                        army3.Points -= heavyp.ElementAt(remove);
                                        army3.PL -= hepl.ElementAt(remove);
                                        heavyp.RemoveAt(remove);
                                        hepl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 5)
                                {
                                    if (fast.Count == 0)
                                    {
                                        Console.WriteLine("There are no fast attacks in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < fast.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + fast[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        fast.RemoveAt(remove);
                                        army3.Points -= fastp.ElementAt(remove);
                                        army3.PL -= fpl.ElementAt(remove);
                                        fastp.RemoveAt(remove);
                                        fpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 6)
                                {
                                    if (flyer.Count == 0)
                                    {
                                        Console.WriteLine("There are no flyers in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < flyer.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + flyer[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        flyer.RemoveAt(remove);
                                        army3.Points -= flyerp.ElementAt(remove);
                                        army3.PL -= flpl.ElementAt(remove);
                                        flyerp.RemoveAt(remove);
                                        flpl.RemoveAt(remove);
                                    }
                                }
                                if (remove == 7)
                                {
                                    if (transport.Count == 0)
                                    {
                                        Console.WriteLine("There are no dedicated transports in your list.");
                                    }
                                    else
                                    {
                                        for (int i = 0; i < transport.Count; i++)
                                        {
                                            Console.WriteLine(i + " - " + transport[i]);
                                        }
                                        remove = Convert.ToInt32(Console.ReadLine());
                                        transport.RemoveAt(remove);
                                        army3.Points -= transportp.ElementAt(remove);
                                        army3.PL -= tpl.ElementAt(remove);
                                        transportp.RemoveAt(remove);
                                        tpl.RemoveAt(remove);
                                    }
                                }
                            }
                        }
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("What would you like to change your army name to?");
                        if(choice == 1)
                        {
                            army1.name = Console.ReadLine();
                        }
                        if (choice == 2)
                        {
                            army2.name = Console.ReadLine();
                        }
                        if (choice == 3)
                        {
                            army3.name = Console.ReadLine();
                        }
                        break;
                    case 10:
                        Console.Clear();
                        if(choice == 1)
                        {
                            if(army1.Faction == 1)
                            {
                                Console.WriteLine("1 - Order of Our Martyred Lady");
                                Console.WriteLine("2 - Order of The Argent Shroud");
                                Console.WriteLine("3 - Order of the Bloody Rose");
                                Console.WriteLine("4 - Order of the Ebon Chalice");
                                Console.WriteLine("5 - Order of the Sacred Rose");
                                Console.WriteLine("6 - Order of the Valorous Heart");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army1.subFaction = "Order of Our Martyred Lady";
                                }
                                if (sub == 2)
                                {
                                    army1.subFaction = "Order of The Argent Shroud";
                                }
                                if (sub == 3)
                                {
                                    army1.subFaction = "Order of the Bloody Rose";
                                }
                                if (sub == 4)
                                {
                                    army1.subFaction = "Order of the Ebon Chalice";
                                }
                                if (sub == 5)
                                {
                                    army1.subFaction = "Order of the Sacred Rose";
                                }
                                if (sub == 6)
                                {
                                    army1.subFaction = "Order of the Valorous Heart";
                                }
                            }
                            if (army1.Faction == 2)
                            {
                                Console.WriteLine("1 - Astral Claws");
                                Console.WriteLine("2 - Black Templars");
                                Console.WriteLine("3 - Blood Angels");
                                Console.WriteLine("4 - Blood Ravens");
                                Console.WriteLine("5 - Carcharodons");
                                Console.WriteLine("6 - Crimson Fists");
                                Console.WriteLine("7 - Dark Angels");
                                Console.WriteLine("8 - Deathwatch");
                                Console.WriteLine("9 - Flesh Tearers");
                                Console.WriteLine("10 - Imperial Fists");
                                Console.WriteLine("11 - Iron Hands");
                                Console.WriteLine("12 - Minotaurs");
                                Console.WriteLine("13 - Raven Guard");
                                Console.WriteLine("14 - Red Scorpions");
                                Console.WriteLine("15 - Salamanders");
                                Console.WriteLine("16 - Space Wolves");
                                Console.WriteLine("17 - Ultramarines");
                                Console.WriteLine("18 - White Scars");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army1.subFaction = "Astral Claws";
                                }
                                if (sub == 2)
                                {
                                    army1.subFaction = "Black Templars";
                                }
                                if (sub == 3)
                                {
                                    army1.subFaction = "Blood Angles";
                                }
                                if (sub == 4)
                                {
                                    army1.subFaction = "Blood Ravens";
                                }
                                if (sub == 5)
                                {
                                    army1.subFaction = "Carcharodons";
                                }
                                if (sub == 6)
                                {
                                    army1.subFaction = "Crimson Fists";
                                }
                                if (sub == 7)
                                {
                                    army1.subFaction = "Dark Angels";
                                }
                                if (sub == 8)
                                {
                                    army1.subFaction = "Deathwatch";
                                }
                                if (sub == 9)
                                {
                                    army1.subFaction = "Flesh Tearers";
                                }
                                if (sub == 10)
                                {
                                    army1.subFaction = "Imperial Fists";
                                }
                                if (sub == 11)
                                {
                                    army1.subFaction = "Iron Hands";
                                }
                                if (sub == 12)
                                {
                                    army1.subFaction = "Minotaurs";
                                }
                                if (sub == 13)
                                {
                                    army1.subFaction = "Raven Guard";
                                }
                                if (sub == 14)
                                {
                                    army1.subFaction = "Red Scorpions";
                                }
                                if (sub == 15)
                                {
                                    army1.subFaction = "Salamanders";
                                }
                                if (sub == 16)
                                {
                                    army1.subFaction = "Space Wolves";
                                }
                                if (sub == 17)
                                {
                                    army1.subFaction = "Ultramarines";
                                }
                                if (sub == 18)
                                {
                                    army1.subFaction = "White Scars";
                                }
                            }
                            if (army1.Faction == 3)
                            {
                                Console.WriteLine("1 - Aquilan Shield");
                                Console.WriteLine("2 - Dread Host");
                                Console.WriteLine("3 - Emissaries Imperatus");
                                Console.WriteLine("4 - Shadowkeepers");
                                Console.WriteLine("5 - Solar Watch");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army1.subFaction = "Aquilan Shield";
                                }
                                if (sub == 2)
                                {
                                    army1.subFaction = "Dread Host";
                                }
                                if (sub == 3)
                                {
                                    army1.subFaction = "Emissaries Imperatus";
                                }
                                if (sub == 4)
                                {
                                    army1.subFaction = "Shadowkeepers";
                                }
                                if (sub == 5)
                                {
                                    army1.subFaction = "Solar Watch";
                                }
                            }
                            if (army1.Faction == 4)
                            {
                                Console.WriteLine("1 - Agripinaa");
                                Console.WriteLine("2 - Graia");
                                Console.WriteLine("3 - Lucius");
                                Console.WriteLine("4 - Mars");
                                Console.WriteLine("5 - Metalica");
                                Console.WriteLine("6 - Ryza");
                                Console.WriteLine("7 - Stygies VIII");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army1.subFaction = "Agripinaa";
                                }
                                if (sub == 2)
                                {
                                    army1.subFaction = "Graia";
                                }
                                if (sub == 3)
                                {
                                    army1.subFaction = "Lucius";
                                }
                                if (sub == 4)
                                {
                                    army1.subFaction = "Mars";
                                }
                                if (sub == 5)
                                {
                                    army1.subFaction = "Metalica";
                                }
                                if (sub == 6)
                                {
                                    army1.subFaction = "Ryza";
                                }
                                if (sub == 7)
                                {
                                    army1.subFaction = "Stygies VIII";
                                }
                            }
                            if (army1.Faction == 5)
                            {
                                Console.WriteLine("1 - Armageddon");
                                Console.WriteLine("2 - Cadian");
                                Console.WriteLine("3 - Catachan");
                                Console.WriteLine("4 - Krieg");
                                Console.WriteLine("5 - Mordian");
                                Console.WriteLine("6 - Tallarn");
                                Console.WriteLine("7 - Tanith");
                                Console.WriteLine("8 - Valhallan");
                                Console.WriteLine("9 - Vostroyan");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army1.subFaction = "Armageddon";
                                }
                                if (sub == 2)
                                {
                                    army1.subFaction = "Cadian";
                                }
                                if (sub == 3)
                                {
                                    army1.subFaction = "Catachan";
                                }
                                if (sub == 4)
                                {
                                    army1.subFaction = "Krieg";
                                }
                                if (sub == 5)
                                {
                                    army1.subFaction = "Mordian";
                                }
                                if (sub == 6)
                                {
                                    army1.subFaction = "Tallarn";
                                }
                                if (sub == 7)
                                {
                                    army1.subFaction = "Tanith";
                                }
                                if (sub == 8)
                                {
                                    army1.subFaction = "Valhallan";
                                }
                                if (sub == 9)
                                {
                                    army1.subFaction = "Vostroyan";
                                }
                            }
                        }
                        if(choice == 2)
                        {
                            if (army2.Faction == 1)
                            {


                                Console.WriteLine("1 - Khorne");
                                Console.WriteLine("2 - Nurgle");
                                Console.WriteLine("3 - Slaanesh");
                                Console.WriteLine("4 - Tzeentch");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army2.subFaction = "Khorne";
                                }
                                if (sub == 2)
                                {
                                    army2.subFaction = "Nurgle";
                                }
                                if (sub == 3)
                                {
                                    army2.subFaction = "Slaanesh";
                                }
                                if (sub == 4)
                                {
                                    army2.subFaction = "Tzeentch";
                                }
                            }
                            if(army2.Faction == 2)
                            {
                                Console.Write("1 - Ferrymen");
                                Console.Write("2 - Harbingers");
                                Console.Write("3 - Inexorable");
                                Console.Write("4 - Mortarion's Anvil");
                                Console.Write("5 - Mortarion's Chosen Sons");
                                Console.Write("6 - Poxmongers");
                                Console.Write("7 - Wretched");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army2.subFaction = "Ferrymen";
                                }
                                if (sub == 2)
                                {
                                    army2.subFaction = "Harbingers";
                                }
                                if (sub == 3)
                                {
                                    army2.subFaction = "Inexorable";
                                }
                                if (sub == 4)
                                {
                                    army2.subFaction = "Mortarion's Anvil";
                                }
                                if (sub == 5)
                                {
                                    army2.subFaction = "Mortarion's Chosen Sons";
                                }
                                if (sub == 6)
                                {
                                    army2.subFaction = "Poxmongers";
                                }
                                if (sub == 7)
                                {
                                    army2.subFaction = "Wretched";
                                }
                            }
                            if (army2.Faction == 3)
                            {
                                Console.WriteLine("1 - Alpha Legion");
                                Console.WriteLine("2 - Black Legion");
                                Console.WriteLine("3 - Brazen Beasts");
                                Console.WriteLine("4 - Creations of Bile");
                                Console.WriteLine("5 - Crimson Slaughter");
                                Console.WriteLine("6 - Emperor's Children");
                                Console.WriteLine("7 - Flawless Host");
                                Console.WriteLine("8 - Iron Warriors");
                                Console.WriteLine("9 - Night Lords");
                                Console.WriteLine("10 - Red Corsairs");
                                Console.WriteLine("11 - Renegade Chapter");
                                Console.WriteLine("12 - The Purge");
                                Console.WriteLine("13 - The Scourged");
                                Console.WriteLine("14 - Word Bearers");
                                Console.WriteLine("15 - World Eaters");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army1.subFaction = "Alpha Legion";
                                }
                                if (sub == 2)
                                {
                                    army1.subFaction = "Black Legion";
                                }
                                if (sub == 3)
                                {
                                    army1.subFaction = "Brazen Beasts";
                                }
                                if (sub == 4)
                                {
                                    army1.subFaction = "Creations of Bile";
                                }
                                if (sub == 5)
                                {
                                    army1.subFaction = "Crimson Slaughter";
                                }
                                if (sub == 6)
                                {
                                    army1.subFaction = "Emperor's Children";
                                }
                                if (sub == 7)
                                {
                                    army1.subFaction = "Flawless Host";
                                }
                                if (sub == 8)
                                {
                                    army1.subFaction = "Iron Warriors";
                                }
                                if (sub == 9)
                                {
                                    army1.subFaction = "Night Lords";
                                }
                                if (sub == 10)
                                {
                                    army1.subFaction = "Red Corsairs";
                                }
                                if (sub == 11)
                                {
                                    army1.subFaction = "Renegade Chapter";
                                }
                                if (sub == 12)
                                {
                                    army1.subFaction = "The Purge";
                                }
                                if (sub == 13)
                                {
                                    army1.subFaction = "The Scourged";
                                }
                                if (sub == 14)
                                {
                                    army1.subFaction = "Word Bearers";
                                }
                                if (sub == 15)
                                {
                                    army1.subFaction = "World Eaters";
                                }
                            }
                            if (army2.Faction == 4)
                            {
                                Console.WriteLine("1 - Cult of Change");
                                Console.WriteLine("2 - Cult of Duplicity");
                                Console.WriteLine("3 - Cult of Knowledge");
                                Console.WriteLine("4 - Cult of Magic");
                                Console.WriteLine("5 - Cult of Manipulation");
                                Console.WriteLine("6 - Cult of Mutation");
                                Console.WriteLine("7 - Cult of Prophecy");
                                Console.WriteLine("8 - Cult of Scheming");
                                Console.WriteLine("9 - Cult of Time");
                                sub = Convert.ToInt32(Console.ReadLine());
                                if (sub == 1)
                                {
                                    army1.subFaction = "Cult of Change";
                                }
                                if (sub == 2)
                                {
                                    army1.subFaction = "Cult of Duplicity";
                                }
                                if (sub == 3)
                                {
                                    army1.subFaction = "Cult of Knowledge";
                                }
                                if (sub == 4)
                                {
                                    army1.subFaction = "Cult of Magic";
                                }
                                if (sub == 5)
                                {
                                    army1.subFaction = "Cult of Manipulation";
                                }
                                if (sub == 6)
                                {
                                    army1.subFaction = "Cult of Mutation";
                                }
                                if (sub == 7)
                                {
                                    army1.subFaction = "Cult of Prophecy";
                                }
                                if (sub == 8)
                                {
                                    army1.subFaction = "Cult of Scheming";
                                }
                                if (sub == 9)
                                {
                                    army1.subFaction = "Cult of Time";
                                }
                            }
                        }
                        if(choice == 3)
                        {
                            if (army3.Faction == 1)
                            {
                                Console.WriteLine("1 - Alaitoc");
                                Console.WriteLine("2 - Biel-Tan");
                                Console.WriteLine("3 - Iyanden");
                                Console.WriteLine("4 - Saim-Hann");
                                Console.WriteLine("5 - Ulthwé");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                            if (army3.Faction == 2)
                            {
                                Console.WriteLine("1 - Haemonculus Coven");
                                Console.WriteLine("2 - Kabal");
                                Console.WriteLine("3 - Realspace Raid");
                                Console.WriteLine("4 - Wych Cult");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                            if (army3.Faction == 3)
                            {
                                Console.WriteLine("1 - Cult of the Four-armed Emperor");
                                Console.WriteLine("2 - The Bladed Cog");
                                Console.WriteLine("3 - The Hivecult");
                                Console.WriteLine("4 - The Pauper Princes");
                                Console.WriteLine("5 - The Rusted Claw");
                                Console.WriteLine("6 - The Twisted Helix");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                            if (army3.Faction == 4)
                            {
                                Console.WriteLine("1 - Dreaming Shadow");
                                Console.WriteLine("2 - Frozen Stars");
                                Console.WriteLine("3 - Midnight Sorrow");
                                Console.WriteLine("4 - Silent Shroud");
                                Console.WriteLine("5 - Soaring Spite");
                                Console.WriteLine("6 - Veiled Path");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                            if (army3.Faction == 5)
                            {
                                Console.WriteLine("1 - Mephrit");
                                Console.WriteLine("2 - Nephrekh");
                                Console.WriteLine("3 - Nihilakh");
                                Console.WriteLine("4 - Novokh");
                                Console.WriteLine("5 - Sautekh");
                                Console.WriteLine("6 - Szarekhan");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                            if (army3.Faction == 6)
                            {
                                Console.WriteLine("1 - Bad Moon");
                                Console.WriteLine("2 - Blood Axes");
                                Console.WriteLine("3 - Boomboyz");
                                Console.WriteLine("4 - Deathskulls");
                                Console.WriteLine("5 - Evil Sunz");
                                Console.WriteLine("6 - Feral Orks");
                                Console.WriteLine("7 - Flyboyz");
                                Console.WriteLine("8 - Freebooterz");
                                Console.WriteLine("9 - Goff");
                                Console.WriteLine("10 - Grot Mobs");
                                Console.WriteLine("11 - Huntas");
                                Console.WriteLine("12 - Madboyz");
                                Console.WriteLine("13 - Pyromaniacs");
                                Console.WriteLine("14 - Snakebite");
                                Console.WriteLine("15 - Tin 'Eads");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                            if (army3.Faction == 7)
                            {
                                Console.WriteLine("1 - Bork'an Sept");
                                Console.WriteLine("2 - Dal'yth Sept");
                                Console.WriteLine("3 - Farsight Enclaves");
                                Console.WriteLine("4 - Ke'lshan");
                                Console.WriteLine("5 - Sa'cea Sept");
                                Console.WriteLine("6 - T'au Sept");
                                Console.WriteLine("7 - Vior'la Sept");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                            if (army3.Faction == 8)
                            {
                                Console.WriteLine("1 - Behemoth");
                                Console.WriteLine("2 - Gorgon");
                                Console.WriteLine("3 - Hydra");
                                Console.WriteLine("4 - Jormungandr");
                                Console.WriteLine("5 - Kraken");
                                Console.WriteLine("6 - Kronos");
                                Console.WriteLine("7 - Leviathan");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                            if (army3.Faction == 9)
                            {
                                Console.WriteLine("1 - Reborn Asuryani");
                                Console.WriteLine("2 - Reborn Drukhari");
                                sub = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        break;
                    case 11:
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Not a valid Choice");
                        break;
                }
            } while (menu != 11);
        }
    }
}
