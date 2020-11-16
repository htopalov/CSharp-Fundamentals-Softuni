using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            bool hasBreak = false;

            while(true)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 0; i < input.Length; i+=2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();
                    if (material == "shards" || material =="fragments" || material =="motes")
                    {
                        keyMaterials[material] += quantity;
                        if (keyMaterials[material] >= 250)
                        {
                            keyMaterials[material] -= 250;
                            if (material == "shards")
                            {
                                Console.WriteLine("Shadowmourne obtained!");
                            }
                            else if (material == "fragments")
                            {
                                Console.WriteLine("Valanyr obtained!");
                            }
                            else if (material == "motes")
                            {
                                Console.WriteLine("Dragonwrath obtained!");
                            }
                            hasBreak = true;
                            break;
                        }
                    }
                    else
                    {
                        if(!junkMaterials.ContainsKey(material))
                        {
                            junkMaterials.Add(material, 0);
                        }
                        junkMaterials[material] += quantity;
                    }
                }
                if (hasBreak)
                {
                    break;
                }
            }
            Dictionary<string, int> filteredKeyMaterials = keyMaterials
                .OrderByDescending(v => v.Value)
                .ThenBy(k => k.Key)
                .ToDictionary(a => a.Key, a => a.Value);
            foreach (var item in filteredKeyMaterials)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials.OrderBy(k =>k.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
