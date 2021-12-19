using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DecorDatabase : TileDatabase
{
    public override Dictionary<string, string> Entries { get; set; } = new Dictionary<string, string>()
    {
        //TABLES
        { "adaptive_table_horizontal", "horizontal table" },
        { "adaptive_table_vertical", "vertical table" },
        { "table_horizontal", "Table_Horizontal" },
        { "table_vertical", "Table_Vertical" },
        { "stone_table_horizontal", "Table_Horizontal_Stone" },
        { "stone_table_vertical", "Table_Vertical_Stone" },
        { "coffin_vertical", "Coffin_Vertical" },
        { "coffin_horizontal", "Coffin_Horizontal" },

        //MISC
        { "heart_dispenser", "HeartDispenser" },
        { "teleporter", "teleporter" },
        { "elevator_arrival", "elevator_arrival" },
        { "elevator_departure", "elevator_departure" },

        //DECOR
        { "chest_platform", "gungeon_treasure_dais" },
        { "chest_platform_carpet", "treasure_dais_stone_carpet" },
        { "chandelier", "Hanging_Chandelier" },
        { "hanging_pot", "Hanging_Pot" },
        { "bench_vertical", "monk_bench_tall" },
        { "random_statue", "rat figure random" },
        { "barrel", "barrel_collection"},
        { "crate", "crate"},
        { "globe", "Table_Globe" },
        { "stack_of_books", "pileorstackofbooks"},
        { "pot", "pot"},
        { "tall_pot", "Tall Pot"},
        { "blue_pot", "Default Pot Blue" },
        { "rock", "rock"},
        { "bush", "bush"},
        { "bush_flowers", "bush flowers"},
        { "apple_barrel", "barrel_apple"},
        { "suit_of_armour", "suitofarmor"},
        { "ash_bulletman", "ash_bulletman"},
        { "ash_shotgun_man", "ash_shotgunman"},
        { "green_lantern", "Shrine_Lantern" },
        { "purple_lantern", "Purple_Lantern" },
        { "blue_torch", "defaulttorchblue" },
        { "blue_torch_side", "defaulttorchsideblue" },



        //DOORS
        { "default_door_vertical", "IronWoodDoor_Vertical" },
        { "default_door_horizontal", "IronWoodDoor_Horizontal" },

        //#DECOR (USUALLY MINOR BREAKABLES)-----------------------------------

        { "inanimate_candle_kin", "bulletman_candle_a" },		// (a random candle shaped roughly like a Bullet Kin)
        { "random_candles", "candles" },		// (A cluster of a random number of candles)
        { "one_candle", "candle" },		// (always 1 candle)
        { "two_candles", "doublecandle" },		// (Always 2 candles)
        { "three_candles", "triplecandle" },		// (always 3 candles)
        { "random_sometimes_candles", "candles_chance" },		// (Same as 'candles' but there's a chance for the number to be 0)
        { "floating_candle", "floatingcandle" },		// (A single levitating Candle)
        { "bench_horizontal", "monk_bench_long" },		// (A horizontally placed bench)
        { "pink_bench", "pink_bench_001" },		// (A horizontally placed bench)
        { "pile_of_skulls", "catacombs_skull_pile" },
        { "big_skull_down", "big_skull_001" },		// (south-facing)
        { "big_skull_left", "big_skull_002" },		// (West facing)
        { "big_skull_right", "big_skull_003" },		// (East Facing)
        { "sitting_skeleton_left", "skeleton_left_sit_corner" },
        { "sitting_skeleton_right", "skeleton_right_sit_corner" },
        { "broken_pot", "default pot broken" },		// (a pre-broken pot)
        { "ash_pot", "forge_ash_pot_01" },		// (An ashen pot from the forge)
        { "maggot_pot", "hell pot full" },		// (A Hell Pot full of writhing maggots)
        { "urn", "default urn" },
        { "wine_rack", "wine_rack_001" },
        { "writhing_bulletkin", "writhing bulletman" },		// (A sick bullet kin writhing in pain from the Oubliette)
        { "barrelman_down", "barrelman_down" },		// (A bullet kin in a barrel with his primer sticking out)
        { "barrelman_up", "barrelman_up" },		// (As above, but the Bullet Kin is the other way around)
        { "metal_bar_barrel", "barrel full of rods" },		// (A metal barrel of iron rods from the Forge)
        { "bunsen_burner", "bunson_burner" },		// (A metal barrel of iron rods from the Forge)
        { "wood_pedestal", "wooden_pedestal_001" },		// (Some sort of lectern)
        { "cabinet", "wine_cabinet" },		// (Some sort of lectern)
        { "cartstub_east", "cartstub_east" },		// (the blocks used to stop minecarts in the mines. Indestructable)
        { "cartstub_west", "cartstub_west" },		// (the blocks used to stop minecarts in the mines. Indestructable)
        { "cartstub_north", "cartstub_north" },		// (the blocks used to stop minecarts in the mines. Indestructable)
        { "cartstub_south", "cartstub_south" },		// (the blocks used to stop minecarts in the mines. Indestructable)
        { "big_crate_vertical", "default crate long" },		// (vertical crate)
        { "big_crate_horizontal", "default crate wide" },		// (horizontal crate)
        { "pillory", "pillory" },		// (horizontal crate)
        { "statue_bullet", "ratfigure_bullet" },		// (horizontal crate)
        { "statue_convict", "ratfigure_convict" },		// (horizontal crate)
        { "statue_hunter", "ratfigure_hunter" },		// (horizontal crate)
        { "statue_pilot", "ratfigure_pilot" },		// (horizontal crate)
        { "statue_robot", "ratfigure_robot" },		// (horizontal crate)
        { "statue_marine", "ratfigure_soldier" },		// (horizontal crate)
        { "telescope", "telescope" },		// (horizontal crate)
        { "sold_out_card", "sign_soldout" },

        //#MAJOR DECOR (USUALLY UNBREAKABLE)----------------------------------

        { "random_sarcophagus", "sarcophogus" },		// (A random sarcophagus)
        { "sarcophagus_bulletshield", "sarcophagus_bulletshield" },
        { "sarcophagus_bulletsword", "sarcophagus_bulletsword" },
        { "sarcophagus_shotgunbook", "sarcophagus_shotgunbook" },
        { "sarcophagus_shotgunmace", "sarcophagus_shotgunmace" },
        { "kaliber_statue", "bulletkingoldwall_statue" },		// (A statue of Kaliber from the Old King's bossroom)
        { "gargoyle_blood_fountain", "bulletkingoldwall_blood_font" },		// (A gargoyle head spewing blood into a bowl, meant to be placed on the northern wall of the old king's bossroom)
        { "gatling_gull_nest", "gatlinggullnest" },		// (The Gatling Gull's Nest)
        { "glass_case_pedestal", "shop_specialcase" },		// (Glass Display case from the shop)
        { "round_shop_table", "shoptable" },		// (The round table from the shop)
        { "ratty_carpet", "ratty_carpet_001" },
        { "maintenance_sign", "elevatormaintenancesign" },
        //{ "loreye", "creepyeye_room" }, //Can be placed, but doesn't reeeeeally work very well.

        { "npc_synerscope_right", "npc_synerscope_left" },		// (A Synerscope facing right)
        { "npc_synerscope_left", "npc_synerscope_right" },		// (Same as above but facing left)
        { "npc_cultist_bowback", "cultistbaldbowback_cutout" },		// (A cultist with his hood down bowing away from the camera)
        { "npc_cultist_bowright", "cultistbaldbowbackleft_cutout" },		// (A cultist with his hood down bowing to the right)
        { "npc_cultist_bowleft", "cultistbaldbowbackright_cutout" },		// (A cultist with his hood down bowing to the left)
        
        { "npc_cultist_hooded_facingaway", "cultisthoodbowback_cutout" },		// (A cultist with his hood up facing away from the camera)
        { "npc_cultist_hooded_facingright", "cultisthoodbowleft_cutout" },		// (A cultist with his hood up facing right)
        { "npc_cultist_hooded_facingleft", "cultisthoodbowright_cutout" },		// (A cultist with his hood up facing left)

        //#LIGHTING EFFECTS--------------------------------------------------

        //{ "gatlinggullarenalight", "gatlinggullarenalight" },		// (A decorative shadow cast on the ground, as though the roof of the room contains a giant spinning turbine)
        //{ "godrays_placeable", "godrays_placeable" },		// (A beam of light from above, creating a blightly lit area on the ground. Seen in chest rooms)
        //{ "defaulttorch", "defaulttorch" },		// (A yellow torch for a northern wall)
        //{ "defaulttorchside", "defaulttorchside" },		// (a yellow torch for a western wall)
        //{ "defaulttorchpurple", "defaulttorchpurple" },		// (a purple torch for a northern wall)
        //{ "defaulttorchsidepurple", "defaulttorchsidepurple" },		// (a purple torch for a western wall)
        //{ "sconce_light", "sconce_light" },		// (a purple torch for a western wall)
        //{ "sconce_light_side", "sconce_light_side" },		// (a purple torch for a western wall)


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


