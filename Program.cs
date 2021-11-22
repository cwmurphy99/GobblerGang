using System;

namespace TheGobblerGang
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("----------------");
            MemberPrompt();


        }

        static void MemberPrompt()
        {

            Console.WriteLine("Enter a team member name> ");
            string Name = Console.ReadLine();
            if (Name == "")
            {
                return;
            }
            else
            {

                Console.WriteLine("Enter a skill level> ");
                int SkillLevel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter a Courage Factor> ");
                float Courage = float.Parse(Console.ReadLine());

                TeamMember NewMember = new TeamMember()
                {
                    Name = Name,
                    Skill = SkillLevel,
                    Courage = Courage
                };
                Console.WriteLine("----------------------");
                Console.WriteLine(NewMember.TeamMemberInfo);
                MemberPrompt();
                Console.WriteLine("member total: ", NewMember.TotalMemberNumber)
            }

        }
    }
}
