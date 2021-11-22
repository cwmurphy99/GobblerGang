using System;

namespace TheGobblerGang
{

    public class TeamMember
    {
        private static int _memberIncrementer = 0;

        public TeamMember()
        {
            TotalMemberNumber = _memberIncrementer++;
        }
        public string Name { get; set; }
        public int Skill { get; set; }
        public float Courage { get; set; }
        public int TotalMemberNumber { get; set; }

        public string TeamMemberInfo
        {
            get
            {
                return $"Name: {Name}\nSkill Level: {Skill}\nCourage Factor: {Courage}";
            }
        }
    }


}