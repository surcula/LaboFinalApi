﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboFinalAPIDomain.Models
{
    public class Entities
    {
        public int Id { get; set; }
        public Users Users { get; set; }
        public Backgrounds Backgrounds { get; set; }
        public Races Races { get; set; }
        public Classes Classes { get; set; }
        public Items Armor { get; set; }
        public Items Shield { get; set; }
        public Items WeaponOne { get; set; }
        public Items WeaponTwo { get; set; }
        public Items ToolOne { get; set; }
        public Items ToolTwo { get; set; }
        public string Name {  get; set; }
        public int Strenght { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Level { get; set; }
        public int HitPoints { get; set; }
        public string Treasures { get; set; }
        public string Particularities { get; set; }
        public int Gender { get; set; }
        public int Alignment { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        public int Xp { get; set; }
        public int Gold { get; set; }
        public string Eyes { get; set; }
        public string Skin { get; set; }
        public string Hair { get; set; }
        public string Appareance { get; set; }
        public string CharachterBackStory { get; set; }
        public string Personality { get; set; }
        public string Ideals { get; set; }
        public string Bonds { get; set; }
        public string Flaws { get; set; }
        public string allies { get; set; }
        public string AdditionalFeatures { get; set; }

    }
}
