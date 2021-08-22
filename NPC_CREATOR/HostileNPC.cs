using System;
using System.Collections.Generic;
using System.Text;

namespace NPC_CREATOR 
{
    public class HostileNPC : NPC
    {
        public int m_Power { get; set; }

        public void buildDialogue()
        {


            Console.WriteLine("Welcome to the npc creator!\n Press any key to begin.\n");
            Console.ReadKey();

            Console.WriteLine("Enter a name: ");
            m_Name = Console.ReadLine();


            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("For size[] at element" + i);
                m_Size[i] = (float)(Convert.ToDouble(Console.ReadLine()));

            }


            Console.WriteLine("How fast does this person go?: ");
            m_Speed = (float)(Convert.ToDouble(Console.ReadLine()));


            Console.WriteLine("Name is " + m_Name + ". \n They have a whopping punch with a power of " + m_Power+"!\n Size is " + m_Size[0] + " x " + m_Size[1] + " x " + m_Size[2]
            + ". \n Finally, the npc has a speed of " + m_Speed + ".");


        }
    }


}
