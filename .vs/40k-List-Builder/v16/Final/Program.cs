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
            int hqs, troops, elites, fasts, heavys, flyers, transports;
            int menu = 0;
            List<string> hq = new List<string>();
            List<string> troop = new List<string>();
            List<string> elite = new List<string>();
            List<string> fast = new List<string>();
            List<string> heavy = new List<string>();
            List<string> flyer = new List<string>();
            List<string> transport = new List<string>();
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
                Console.WriteLine("2 - Chaos Knights\n");
                Console.WriteLine("3 - Chaos Space Marines\n");
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
                    if (army1.Faction == 6)
                        Console.WriteLine("Imperial Knights");

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
                        Console.WriteLine("Chaos Knights");
                    if (army2.Faction == 3)
                        Console.WriteLine("Chaos Space Marines");

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
                Console.WriteLine("9 - Exit");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Palatine");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Missionary with Chainsword");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Canoness Veridyan");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Junith Eruita");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Ephrael Stern & Kyganil");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Celestine, the Living Saint");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("The Triumph of Saint Katherine");
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Morvenn Vahl, Abbess Sanctorum of the Adepta Sororitas");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Palatine");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Missionary with Chainsword");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Canoness Veridyan");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Junith Eruita");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Ephrael Stern & Kyganil");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Celestine, the Living Saint");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("The Triumph of Saint Katherine");
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Morvenn Vahl, Abbess Sanctorum of the Adepta Sororitas");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Palatine");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Missionary with Chainsword");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Canoness Veridyan");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Junith Eruita");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Ephrael Stern & Kyganil");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Celestine, the Living Saint");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("The Triumph of Saint Katherine");
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Morvenn Vahl, Abbess Sanctorum of the Adepta Sororitas");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Techmarine");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Space Marine Captain: Lord Executioner");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Chaplain with Jump Pack");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Space Marine Commander");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Space Marine Captain");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Librarian in Terminator Armour");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Masters of the Chapter");
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Librarian");
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Primaris Lieutenant in Reiver Armour");
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Primaris Chaplain");
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Primaris Librarian in Phobos Armour");
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Primaris Lieutenant with Power Sword");
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Primaris Librarian");
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Spce Marines Chaplain");
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Primaris Captain");
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Primaris Techmarine");
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Captain in Phobos Armour");
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Primaris Chaplain on Bike");
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Space Marine Heroes");
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Company Command");
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Heroes of the Chapter");
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Space Marines: Honoured of the Chapter");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Techmarine");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Space Marine Captain: Lord Executioner");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Chaplain with Jump Pack");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Space Marine Commander");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Space Marine Captain");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Librarian in Terminator Armour");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Masters of the Chapter");
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Librarian");
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Primaris Lieutenant in Reiver Armour");
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Primaris Chaplain");
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Primaris Librarian in Phobos Armour");
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Primaris Lieutenant with Power Sword");
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Primaris Librarian");
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Spce Marines Chaplain");
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Primaris Captain");
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Primaris Techmarine");
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Captain in Phobos Armour");
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Primaris Chaplain on Bike");
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Space Marine Heroes");
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Company Command");
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Heroes of the Chapter");
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Space Marines: Honoured of the Chapter");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Techmarine");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Space Marine Captain: Lord Executioner");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Chaplain with Jump Pack");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Space Marine Commander");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Space Marine Captain");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Librarian in Terminator Armour");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Masters of the Chapter");
                                        }
                                        if (hqs == 9)
                                        {
                                            hq.Add("Librarian");
                                        }
                                        if (hqs == 10)
                                        {
                                            hq.Add("Primaris Lieutenant in Reiver Armour");
                                        }
                                        if (hqs == 11)
                                        {
                                            hq.Add("Primaris Chaplain");
                                        }
                                        if (hqs == 12)
                                        {
                                            hq.Add("Primaris Librarian in Phobos Armour");
                                        }
                                        if (hqs == 13)
                                        {
                                            hq.Add("Primaris Lieutenant with Power Sword");
                                        }
                                        if (hqs == 14)
                                        {
                                            hq.Add("Primaris Librarian");
                                        }
                                        if (hqs == 15)
                                        {
                                            hq.Add("Spce Marines Chaplain");
                                        }
                                        if (hqs == 16)
                                        {
                                            hq.Add("Primaris Captain");
                                        }
                                        if (hqs == 17)
                                        {
                                            hq.Add("Primaris Techmarine");
                                        }
                                        if (hqs == 18)
                                        {
                                            hq.Add("Captain in Phobos Armour");
                                        }
                                        if (hqs == 19)
                                        {
                                            hq.Add("Primaris Chaplain on Bike");
                                        }
                                        if (hqs == 20)
                                        {
                                            hq.Add("Space Marine Heroes");
                                        }
                                        if (hqs == 21)
                                        {
                                            hq.Add("Company Command");
                                        }
                                        if (hqs == 22)
                                        {
                                            hq.Add("Heroes of the Chapter");
                                        }
                                        if (hqs == 23)
                                        {
                                            hq.Add("Space Marines: Honoured of the Chapter");
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
                                Console.WriteLine("2 - Allarus Custodians");
                                Console.WriteLine("3 - Vexilus Praetor in Allarus Terminator Armour");
                                Console.WriteLine("4 - Shield-Captain in Allarus Terminator Armour");
                                hqs = Convert.ToInt32(Console.ReadLine());
                                if(army1.detachment == 1)
                                {
                                    if(hq.Count < 2)
                                    {
                                        if(hqs == 1)
                                        {
                                            hq.Add("Valerian and Aleya");
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Allarus Custodians");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Vexilus Praetor in Allarus Terminator Armour");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Shield-Captain in Allarus Terminator Armour");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Allarus Custodians");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Vexilus Praetor in Allarus Terminator Armour");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Shield-Captain in Allarus Terminator Armour");
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
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Allarus Custodians");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Vexilus Praetor in Allarus Terminator Armour");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Shield-Captain in Allarus Terminator Armour");
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
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Manipulus");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Dominus");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Belisarius Cawl");
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
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Manipulus");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Dominus");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Belisarius Cawl");
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
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Manipulus");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Dominus");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                        }
                                        if (hqs == 1)
                                        {
                                            hq.Add("Belisarius Cawl");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Company Commander");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Primaris Psyker");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tank Commander");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Colonel 'Iron Hand' Straken");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Lord Castellan Creed");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Gaunt's Ghost");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Company Commander");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Primaris Psyker");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tank Commander");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Colonel 'Iron Hand' Straken");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Lord Castellan Creed");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Gaunt's Ghost");
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
                                        }
                                        if (hqs == 2)
                                        {
                                            hq.Add("Company Commander");
                                        }
                                        if (hqs == 3)
                                        {
                                            hq.Add("Primaris Psyker");
                                        }
                                        if (hqs == 4)
                                        {
                                            hq.Add("Tank Commander");
                                        }
                                        if (hqs == 5)
                                        {
                                            hq.Add("Colonel 'Iron Hand' Straken");
                                        }
                                        if (hqs == 6)
                                        {
                                            hq.Add("Lord Castellan Creed");
                                        }
                                        if (hqs == 7)
                                        {
                                            hq.Add("Tech-Priest Enginseer");
                                        }
                                        if (hqs == 8)
                                        {
                                            hq.Add("Gaunt's Ghost");
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

                        }
                        if (choice == 3)
                        {

                        }
                        break;

                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                    case 6:

                        break;
                    case 7:

                        break;
                    case 8:

                        break;
                    case 9:
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Not a valid Choice");
                        break;
                }
            } while (menu != 9);
        }
    }
}
