using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class TrapDatabase : TileDatabase
{
    public override Dictionary<string, string> Entries { get; set; } = new Dictionary<string, string>()
    {
        
        //BARRELS
        { "random_drum", "drum_variety" },
        { "poison_drum", "Yellow Drum" },
        { "explosive_drum", "Red Drum" },
        { "water_drum", "Blue Drum" },
        { "oil_drum", "Purple Drum"},
        { "explosive_barrel", "Red Barrel" },
        { "ice_cube_bomb", "Ice Cube Bomb" },

       

        //TRAPS
        { "curse_pot", "curse pot" },
        { "floor_spikes", "trap_spike_gungeon_2x2" },
        { "flame_trap", "trap_flame_poofy_gungeon_1x1" },
        { "pitfall_trap", "trap_pit_gungeon_trigger_2x2" },
        { "forge_shoot_face_west", "forge_face_shootseast" },
        { "forge_shoot_face_north", "forge_face_shootssouth" },
        { "forge_shoot_face_east", "forge_face_shootswest" },
        //{ "moving_platform_3x3", "default_platform_3x3" },
        
        //Won't work without additional setup:
        /* Logs
         * Sawblades
         * Mine Collapses
         * Crush Traps
         * default_platform_3x3 (moves)
         */
        //MISSING TRAPS: Flaming Pipes, Rotating Fire Bars, Fire Rings, Crush Traps

        //#TRAPS-------------------------------------------------------------

        //{ "conveyor_belt_right", "conveyor_horizontal" },		// (A conveyor belt to the right)
        //{ "conveyor_vertical", "conveyor_vertical" },		// (A conveyor belt going upwards) DOESN'T ACTUALLY WORK
        { "web_circle", "webplaceable" },		// (A pool of Phaser Spider web-goop)

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


