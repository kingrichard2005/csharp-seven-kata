﻿using System;

namespace csharp_seven_kata
{
    /*
     * From: https://docs.microsoft.com/en-us/dotnet/articles/csharp/csharp-7#pattern-matching
     * Pattern matching is a feature that allows you to implement method dispatch on properties other than the type of an object.
     * You're probably already familiar with method dispatch based on the type of an object.
     * In Object Oriented programming, virtual and override methods provide language syntax to implement method dispatching based on an object's type.
     * Base and Derived classes provide different implementations. Pattern matching expressions extend this concept so that
     * you can easily implement similar dispatch patterns for types and data elements that are not related through an inheritance hierarchy.
     *
     * Pattern matching supports is expressions and switch expressions.
     * Each enables inspecting an object and its properties to determine if that object satisfies the sought pattern. 
     * You use the when keyword to specify additional rules to the pattern.
     */
    public class PatternMatchingKata
    {

        // KATA (complete): Replace the "as" convention and null check with the "is" syntax
        // Note: Should be able to accomplish without the use of "as," "ToString()," "switch" or casting.
        public string PatternMatchingIsExpression(object val) => (val is string) ? $"{val}Bar" : throw new Exception($"Object param {val} is not a string");

        // KATA (complete): Replace the conditional statement under the Moblin case with 2 separate cases where one uses 
        // pattern matching to check to see if the color on the Moblin is "Red"
        public string PatternMatchingSwitch(ICreature creature) {

            var creatureName = string.Empty;

            switch (creature) {
                case Chuchu c:
                    creatureName = "Chuchu";
                    break;
                case Octorok o:
                    creatureName = "Octorok";
                    break;
                // Triggers: Error	CS8120	The switch case has already been handled by a previous case
                //case Moblin m:
                //    creatureName = "Moblin";
                //    break;
                case Moblin m when m.Color.Equals("red", StringComparison.CurrentCultureIgnoreCase):
                    creatureName = "Red Moblin";
                    break;
                case Moblin m:
                    creatureName = "Moblin";
                    break;
                default:
                    creatureName = "Unknown Creature";
                    break;

            }

            return creatureName;


        }

    }

    public interface ICreature {}

    public class Creature : ICreature {}

    public class Chuchu : Creature
    {
        public int Strength { get; set; }
        public int HitPoints { get; set; }

    }

    public class Octorok : Creature
    {
        public int Strength { get; set; }
        public int HitPoints { get; set; }
    }

    public class Moblin : Creature
    {
        public int Strength { get; set; }
        public int HitPoints { get; set; }
        public string Color { get; set; }
    }


}
