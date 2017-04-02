﻿using System.Collections.Generic;

namespace Characters.CharacterClasses
{
    public class ItGuyClass : BaseCharacter
    {
        public static string ClassName = "IT Guy";

        public ItGuyClass(CharacterStatisticDataModel statistic) : base(statistic)
        {
        }


        public const string ClassType = "ITGuyClass";

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
