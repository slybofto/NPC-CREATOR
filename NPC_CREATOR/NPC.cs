using System;
using System.Collections.Generic;
using System.Text;

namespace NPC_CREATOR
{
    public class NPC
    {
        public string m_Name { get; set; }
        public float[] m_Size { get; set; }
        public float m_Speed { get; set; }

        public NPC()
        {
            m_Name = "NPC";
            m_Size = new float[3] { 1.0f, 1.0f, 1.0f };
            m_Speed = 0.2f;
        }
        public NPC(string name, float[] size, float speed)
        {
            m_Name = name;
            m_Size = size;
            m_Speed = speed;
        }
    }
}
