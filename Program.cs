using System;

namespace TheGobblerGang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("----------------");
            Console.WriteLine("Enter a team member name> ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter a skill level> ");
            int SkillLevel = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Courage Factor> ");
            float Courage = float.Parse(Console.ReadLine());

            Console.WriteLine("----------------------");
            Console.WriteLine("Member Name: " + Name);
            Console.WriteLine("Skill: " + SkillLevel);
            Console.WriteLine("Courage: " + Courage);
        }

    }
}
