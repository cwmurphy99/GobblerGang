using System;
using System.Collections.Generic;
namespace TheGobblerGang
{
    class Program
    {
        public static List<TeamMember> Team = new List<TeamMember>();
        public static int luckValue = new Random().Next(-10, 11);
        public static int bankDifficulty = 100 + luckValue;
        public static int totalSkill = 0;
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("----------------");
            MemberPrompt();
            while (MemberPrompt() == true)
            {
                MemberPrompt();
            }
            foreach (TeamMember teamate in Team)
            {
                Console.WriteLine(teamate.TeamMemberInfo);
                totalSkill += teamate.Skill;
            }
            Console.WriteLine();
            Console.WriteLine($"Number of Members: {Team[Team.Count - 1].TotalMemberNumber}");
            Console.ReadLine();
            Console.Clear();
            if (totalSkill >= bankDifficulty)
            {
                Console.WriteLine("");
                Console.WriteLine($"Total Skill Level: {totalSkill}");
                Console.WriteLine();
                Console.WriteLine($"Bank Difficulty: {bankDifficulty}");
                Console.WriteLine();
                Console.WriteLine("Nice Job!");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"Total Skill Level: {totalSkill}");
                Console.WriteLine();
                Console.WriteLine($"Bank Difficulty: {bankDifficulty}");
                Console.WriteLine();
                Console.WriteLine("You Suck.");
            }
        }
        static bool MemberPrompt()
        {
            Console.Write("\nMember name> ");
            string Name = Console.ReadLine();
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
                return true;
            }
        }
    }
}
