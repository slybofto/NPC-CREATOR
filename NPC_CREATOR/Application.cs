using System;
using System.Text.Json;
using System.IO;
using System.Collections.Generic;

namespace NPC_CREATOR
{
    class Application
    {
        
        static void Main(string[] args)
       {
            List<NPC> NPClist;
            string listPath = "npcList.json";

            try
            {
                //File.ReadAllText(listPath) != null;
                string listData = File.ReadAllText(listPath);

                NPClist = JsonSerializer.Deserialize<List<NPC>>(listData);
            }
            catch
            {
                NPClist = new List<NPC>();
                string jsonString = JsonSerializer.Serialize(NPClist);
                //string jsonString = File.ReadAllText(listPath);
                //NPClist = JsonSerializer.Deserialize<List<NPC>>(jsonString);
                File.WriteAllText(listPath, jsonString);

            }

            Console.WriteLine("True or False, Is this npc hostile?");
            bool isHostile = Convert.ToBoolean(Console.ReadLine());
            if(isHostile == false)
            {
                Console.WriteLine("This character is not hostile!");
                Console.ReadKey();

                PassiveNPC passive = new PassiveNPC();

                passive.buildDialogue();

            }

            else if (isHostile == true)
            {
                Console.WriteLine("This character is very hostile!");
                Console.ReadKey();

                HostileNPC hostile = new HostileNPC();

                hostile.buildDialogue();

                //Console.WriteLine($"Name: {hostile1.m_Name}");
                //Console.WriteLine($"Speed: {hostile1.m_Speed}");


            }

            string jsonNPCSerialize = JsonSerializer.Serialize(NPClist);
            Console.ReadKey();
        }
        
    }
}
