﻿using System.Collections.Generic;

namespace LifeLike.Characters.CharacterClasses
{
    public class HoboClass : Character
    {
        public new static string ClassName = "Hobo";

        public HoboClass(CharacterStats statistic) : base(statistic)
        {
            SelectedClass=ClassName;
        }


        public const string ClassType = "HoboClass";

        public override List<string> SpecialActionsList()
        {
            return new List<string>()
            {
                "Normal Attack",
                "Tech Talk",

            };
        }
    }
}
