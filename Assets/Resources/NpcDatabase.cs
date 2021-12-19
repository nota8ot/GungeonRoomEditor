using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NpcDatabase : TileDatabase
{
    public override Dictionary<string, string> Entries { get; set; } = new Dictionary<string, string>()
    {      
        //NPCS
        { "old_red", "Merchant_Blank" },
        { "cursula", "Merchant_Curse" },
        { "flynt", "Merchant_Key" },
        { "trorc", "Merchant_Truck" },
        { "professor_goopton", "NPC_Goop_Merchant" },
        { "vampire", "NPC_Vampire" },
        { "sell_creep", "SellPit" },
        { "old_man", "NPC_Old_Man" },
        { "synergrace", "NPC_Synergrace" },
        { "muncher", "NPC_GunberMuncher" },
        { "evil_muncher", "NPC_GunberMuncher_Evil" },
        { "monster_manuel", "NPC_Monster_Manuel" },
        { "brother_albern", "NPC_Truth_Knower" },
        { "patches_and_mendy", "NPC_Smash_Tent" },
        { "witches", "NPC_Witches" },

        //Shrines
        { "ammo_shrine", "Shrine_Ammo" },
        { "beholster_shrine", "Shrine_Beholster" },
        { "blank_shrine", "Shrine_Blank" },
        { "blood_shrine", "Shrine_Blood" },
        { "cleanse_shrine", "Shrine_Cleanse" },
        { "companion_shrine", "Shrine_Companion" },
        { "dice_shrine", "Shrine_Dice" },
        { "angel_shrine", "Shrine_FallenAngel" },
        { "glass_shrine", "Shrine_Glass" },
        { "health_shrine", "Shrine_Health" },
        { "hero_shrine", "Shrine_Hero" },
        { "junk_shrine", "Shrine_Junk" },
        { "yv_shrine", "Shrine_YV" },

        { "challenge_shrine", "Challenge_Shrine" },

        { "random_shrine", "whichshrinewillitbe" },		// (A random shrine)
        //Lunk and Gunsling King are broken

        { "npc_cultist_interactible", "cultistbaldbowleft_cutout" },		// (The main cultist, interactible and talk-to-able)

        { "random_npc", "shopannex_contents_01" },		// (Random NPC that can appear as secondary in the shop. Most merchants, Vampire, and Sell Creep)
        { "baby_dragun", "babydragunjail" },		// (Baby Dragun)
        { "rat_merchant", "merchant_rat_placeable" }, //The version of the rat that gives free stuff


        { "heart_dispenser", "HeartDispenser" },
        { "teleporter", "teleporter" },

        { "locked_door", "SimpleLockedDoor" },
        { "jail_cell_door", "jaildoor" },		// (NPC Jail Cell Door)

        { "brazier", "brazier" },      
        { "lonks_backpack", "npc_lostadventurer_backpack" },		// (Lunk's backpack)
        { "lonks_shield", "npc_lostadventurer_shield" },		// (Lunk's Shield)
        { "lonks_sword", "npc_lostadventurer_sword" },		// (Lunk's Sword)
        { "abbey_entrance_altar", "gungeoncreststairs" },		// (The altar on which you place the old crest, and the special sarcophagus concealing the stairs. Fully functional)


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


