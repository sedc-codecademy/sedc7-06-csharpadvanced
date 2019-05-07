using StarcraftLib.Units.Protoss;
using StarcraftLib.Units.Terran;
using StarcraftLib.Units.Zerg;
using System;

namespace StarcraftLib.Units
{
    internal class UnitFactory
    {
        internal static Worker CreateWorker(Race race)
        {
            if (race == Race.Protoss)
            {
                return new Probe();
            }
            if (race == Race.Terran)
            {
                return new SCV();
            }
            if (race == Race.Zerg)
            {
                return new Drone();
            }
            throw new ApplicationException($"Invalid race {race}");
        }
    }
}