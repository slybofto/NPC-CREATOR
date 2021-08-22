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

            List<NPC> newNPC = new List<NPC>();       

            Console.WriteLine("True or False, Is this npc hostile?");
            bool isHostile = Convert.ToBoolean(Console.ReadLine());
            if(isHostile == false)
            {
                Console.WriteLine("This character is not hostile!");
                Console.ReadKey();

                PassiveNPC passive = new PassiveNPC();

                passive.buildDialogue();

                string npcJson;

                npcJson = JsonSerializer.Serialize(passive);
                Console.WriteLine(npcJson);

                string fileName = "npc.json";
                string jsonString = JsonSerializer.Serialize(passive);
                File.WriteAllText(fileName, jsonString);

                Console.WriteLine(File.ReadAllText(fileName));
                    
            }

            else if (isHostile == true)
            {
                Console.WriteLine("This character is very hostile!");
                Console.ReadKey();

                HostileNPC hostile = new HostileNPC();

                hostile.buildDialogue();

                JsonSerializer.Serialize(hostile);

                string fileName = "npc.json";
                string jsonString = File.ReadAllText(fileName);
                HostileNPC hostile1 = JsonSerializer.Deserialize<HostileNPC>(jsonString);

                Console.WriteLine($"Name: {hostile1.m_Name}");
                Console.WriteLine($"Speed: {hostile1.m_Speed}");


            }
                       

            Console.ReadKey();
        }
        
    }
}
