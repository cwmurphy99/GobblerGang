using System;
using System.Collections.Generic;

namespace TheGobblerGang
{

    public class TeamMember
    {
        private static int _memberIncrementer = 0;

        public TeamMember()
        {
            _memberIncrementer++;
        }

        public string Name { get; set; }
        public int Skill { get; set; }
        public float Courage { get; set; }
        public int TotalMemberNumber { get { return _memberIncrementer; } }
        public string TeamMemberInfo
        {
            get
            {
                return $"\nName: {Name}\nSkill Level: {Skill}\nCourage Factor: {Courage}";
            }
        }



    }


}