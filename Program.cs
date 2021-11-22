using System;
using System.Collections.Generic;

namespace TheGobblerGang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("----------------");
            MemberPrompt();
            while (MemberPrompt() == true)
            {
                MemberPrompt();
            }

        }

        static bool MemberPrompt()
        {
            Console.Write("\nMember name> ");
            string Name = Console.ReadLine();
            List<TeamMember> Team = new List<TeamMember>();
            if (Name == "")
            {
                return false;
            }
            else
            {
                Console.Write("Skill level> ");
                int SkillLevel = Int32.Parse(Console.ReadLine());
                Console.Write("Courage Factor> ");
                float Courage = float.Parse(Console.ReadLine());

                TeamMember NewMember = new TeamMember()
                {
                    Name = Name,
                    Skill = SkillLevel,
                    Courage = Courage
                };
                Team.Add(NewMember);
                Console.WriteLine("\n----------------------");
                return true;
            }
        }
    }
}
