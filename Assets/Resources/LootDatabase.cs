using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class LootDatabase : TileDatabase
{
    public override Dictionary<string, string> Entries { get; set; } = new Dictionary<string, string>()
    {
       
        //Chests
        { "double_loot_brown_chest", "Chest_Wood_Two_Items" },

        { "blue_chest", "chest_silver"},
        { "green_chest", "chest_green"},
        { "red_chest", "chest_red"},
        { "black_chest", "chest_black"},
        { "rainbow_chest", "chest_rainbow"},
        { "synergy_chest", "chest_synergy"},
        { "truth_chest", "TruthChest" },
        { "rat_chest", "chest_rat"},
        

       
        { "high_dragunfire_chest", "highdragunfire_chest_red" },		// (The High Dragunfire Chest)
        { "random_chest", "aaa_floorchestplacer"},
        { "random_unlocked_chest", "secretroomfloorchestunlocked" },		// (Random unlocked chest)
        { "random_mimic_chest", "almostdefinitelyamimicchestplacer"},
        { "cursed_mirror", "Shrine_Mirror" },

        //ITEMS
        { "key", "keybullet placeable" },
        { "random_pickup", "secret_room_pickup_placeable_garaunteed" },
        { "blank", "blank" },		// (A humble blank)
        { "ammo", "ammo_pickup" },
        { "spread_ammo", "ammo_pickup_spread" },


        //We're no strangers to love.
        //You know the rules, and so do I.
        //A full commitment's what I'm thinking of
        //You wouldn't get this from any other guy
        //I just wanna tell you how I'm feeling
        //Gotta make you understand
        //Never gonna give you up
        //Never gonna let you down
        //Never gonna run around and desert you
        //Never gonna make you cry
        //Never gonna say goodbye
        //Never gonna tell a lie and hurt you
    };
}


