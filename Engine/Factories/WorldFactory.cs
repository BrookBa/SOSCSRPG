using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World CreateWorld()
        {
            World newWorld = new World();

            newWorld.AddLocation(0, 0, "Island",
                "An island in the middle of a lake.",
                "/Engine;component/images/locations/island.jpg");

            newWorld.AddLocation(0, 1, "FeyVille Docks",
                "Colorful and Brightly lit docks welcome you to FeyVille.",
                "/Engine;component/images/locations/FVDocks.jpg");

            newWorld.AddLocation(0, 2, "FeyVille Trader",
                "The FeyVille Marketplace is a cluttered and brightly patterned collage. It's almost distracting enough that you miss the lack of other people...",
                "/Engine;component/images/locations/FVTrader.jpg");

            newWorld.AddLocation(-1, 2, "Fishmonger",
                "A vast variety of fish adorn her table. Were these all caught in The Lake?",
                "/Engine;component/images/locations/Fishmonger.jpg");

            newWorld.AddLocation(1, 2, "Ichthyologist",
                "Her eyes have a manic gleam as she welcomes you in, and you realize you will soon know a lot more about fish than you did an hour ago...",
                "/Engine;component/images/locations/ichthyologist.jpg");

            newWorld.AddLocation(-1, 0, "The Lake",
                "As you row out, you realize you can't see another side, only the island and two sets of docks behind you. Just how big is this \"Lake\"?",
                "/Engine;component/images/locations/Lake.jpg");

            newWorld.AddLocation(0, -1, "NightMoon Docks",
                "Though they're so small you would almost miss them but for the lonely lantern leading you in, there is a small \"Welcome to Nightmoon\" sign.",
                "/Engine;component/images/locations/NVDocks.jpg");

            newWorld.AddLocation(0, -2, "NightMoon Trader",
                "She has a wizened face and features that make you wonder how long she's been out here, peddling her wares.",
                "/Engine;component/images/locations/NVTrader.jpg");

            newWorld.AddLocation(-1, -2, "Butcher",
                "The butcher seems nice enough, but there's an intensity and accuracy to his movements that sets you on edge.",
                "/Engine;component/images/locations/Butcher.jpg");

            newWorld.AddLocation(1, -2, "Herbologist",
                "Although no one seems to be manning the store, you sense that if you touch anything it would not work out well for you...",
                "/Engine;component/images/locations/Herbologist.jpg");
            newWorld.LocationAt(1, -2).QuestsAvailableHere.Add(QuestFactory.GetQuestByID(1));

            newWorld.AddLocation(1, 0, "The Forest",
                "The forest welcomes you with soft sounds and a sense of adventure.",
                "/Engine;component/images/locations/Forest.jpg");

            return newWorld;
        }
    }
}
