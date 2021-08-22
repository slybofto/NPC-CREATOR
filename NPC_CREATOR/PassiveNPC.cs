using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace NPC_CREATOR
{
    public class PassiveNPC : NPC
    {
        public bool m_HasDialogue { get; set; }

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

            Console.WriteLine("True or False, Can this character talk?");
            m_HasDialogue = Convert.ToBoolean(Console.ReadLine());

            if (m_HasDialogue == true)
            {
                Console.WriteLine("Good, I have a lot to say. Moving on though...");

                //Console.WriteLine("Name is" + m_Name + ". \n They cannot talk. \n Size is " + m_Size[0] + " x " + m_Size[1] + " x " + m_Size[2]
            //+ ". \n Finally, " + m_Name + "has a speed of" + m_Speed + ".");

            }

            else if(m_HasDialogue == false)
            {
                Console.WriteLine("That's a shame, no way to live if you ask me. Moving on though...");

                //Console.WriteLine("Name is" + m_Name + ". \n They have a lot to say! \n Size is " + m_Size[0] + " x " + m_Size[1] + " x " + m_Size[2]
          // + ". \n Finally,"+m_Name+"has a speed of" + m_Speed + ".");
            }



           




        }

    }
}
