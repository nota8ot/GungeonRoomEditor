﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using RoomData = ImportExport.RoomData;

public class EnvironmentMap : TilemapHandler
{
    public void DrawBorder()
    {
        Vector2Int pos = Vector2Int.zero;
        int
            xmin = Bounds.xMin, 
            ymin = Bounds.yMin,
            xmax = Bounds.xMax,
            ymax = Bounds.yMax;
        for (int x = xmin; x < xmax; x++)
        {
            for (int y = ymin; y < ymax; y++)
            {
                if (x != xmin && y != ymin && x != xmax - 1 && y != ymax - 1)
                    continue;
                //this.map.SetTile(new Vector3Int(x, y, 0), palette["floor"]);
                else
                    this.map.SetTile(new Vector3Int(x, y, 0), palette["wall"]);
            }
        }
    }

    public Texture2D CollectDataForExport()
    {
        Texture2D texture = new Texture2D(Bounds.size.x, Bounds.size.y);
        BoundsInt boundsInt = new BoundsInt((Vector3Int)Bounds.position, (Vector3Int)Bounds.size);
        var tiles = AllTiles();
        for (int x = 0; x < tiles.GetLength(0); x++)
        {
            for (int y = 0; y < tiles.GetLength(1); y++)
            {
                var tile = tiles[x, y];
                if (!tile)
                {
                    texture.SetPixel(x, y, Color.magenta);
                    continue;
                }
                string name = tile.name.ToLower();
                if (name.Contains("floor"))
                    texture.SetPixel(x, y, Color.white);
                else if (name.Contains("wall"))
                    texture.SetPixel(x, y, Color.grey);
                else if (name.Contains("pit"))
                    texture.SetPixel(x, y, Color.black);
                else if (name.Contains("ice"))
                    texture.SetPixel(x, y, new Color32(0, 127, 255, 255));
                else if (name.Contains("water"))
                    texture.SetPixel(x, y, new Color32(0, 0, 127, 255));
                else if (name.Contains("carpet"))
                    texture.SetPixel(x, y, new Color32(127, 0, 0, 255));
                else if (name.Contains("grass"))
                    texture.SetPixel(x, y, new Color32(127, 255, 127, 255));
                else if (name.Contains("bone"))
                    texture.SetPixel(x, y, new Color32(127, 127, 127, 255));
                else if (name.Contains("flesh"))
                    texture.SetPixel(x, y, new Color32(255, 127, 0, 255));
                else if (name.Contains("goop"))
                    texture.SetPixel(x, y, new Color32(255, 127, 127, 255));
                else if (name.Contains("damage"))
                    texture.SetPixel(x, y, new Color32(0, 255, 0, 255));
            }
        }
        return texture;
    }

    public override TileDatabase InitializeDatabase()
    {
        tileDatabase = new TileDatabase();
        tileDatabase.Entries = new Dictionary<string, string>()
        {
            { "floor", null },
            { "wall", null },
            { "pit", null },
        };
        tileDatabase.spriteDirectory = "sprites/environment";
        return tileDatabase;
    }
}
