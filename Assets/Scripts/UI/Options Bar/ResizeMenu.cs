using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UI;

public class ResizeMenu : MonoBehaviour
{
    public InputField dimX, dimY;
    public static ResizeMenu Instance;
    private HideableObject m_hideable;

    void Start()
    {
        m_hideable = GetComponent<HideableObject>();
        ResizeMenu.Instance = this;
        this.gameObject.SetActive(false);
    }

    void Awake()
    {
        var envMap = Manager.Instance.GetTilemap(TilemapHandler.MapType.Environment).map;
        var bounds = envMap.cellBounds;

        dimX.text = bounds.size.x.ToString();
        dimY.text = bounds.size.y.ToString();
    }

    public void OnCloseClicked()
    {
        m_hideable.Hide();
    }

    public void OnCreateClicked()
    {
        int
            x = int.Parse(dimX.text),
            y = int.Parse(dimY.text);
        if (x < 2 || y < 2)
        {
            Debug.LogError("Dimensions must be greater than 0!");
            return;
        }

        Manager.FilePath = null;
        Manager.roomSize = new Vector2Int(x, y);
        Manager.Reload();
    }

    

    public void Resize()
    {


        int x = int.Parse(dimX.text);
        int y = int.Parse(dimY.text);

        var envMap = Manager.Instance.GetTilemap(TilemapHandler.MapType.Environment).map;
        var bounds = envMap.cellBounds;
        



        Debug.Log(bounds);

        var newBounds = new BoundsInt(-x / 2, -y / 2, 0, x, y, 1);
        Manager.roomSize.x = newBounds.size.x;
        Manager.roomSize.y = newBounds.size.y;
        TilemapHandler.Bounds = newBounds;

        TileBase[] allTiles = envMap.GetTilesBlock(bounds);
        for (int tz = 0; tz < bounds.size.z; tz++)
        {
            for (int tx = 0; tx < bounds.size.x; tx++)
            {
                for (int ty = 0; ty < bounds.size.y; ty++)
                {
                    TileBase tile = allTiles[tx + ty * bounds.size.x];

                    var pos = new Vector3Int(tx, ty, tz);//envMap.WorldToCell();


                    if (tile != null)
                    {
                        //var a = new TileData;
                        Debug.Log(envMap.GetTile(pos));

                        if (!newBounds.Contains(pos))
                        {
                            Debug.Log(pos + ": has been cleared");
                            envMap.SetTile(pos, null);
                        }
                        //Debug.Log("x:" + tx + " y:" + ty + " tile:" + tile.name);
                    }

                }
            }
        }
        envMap.ResizeBounds();
        envMap.RefreshAllTiles();
        /*
        for(int tileY = 0; tileY > bounds.y; tileY++)
        {
           
            
            for (int tileX = 0; tileX > bounds.x; tileX++)
            {
                Debug.Log(new Vector2(tileX, tileY));
               
                //var tile = envMap.GetTile(new Vector3Int(tileX, tileY, 1));

                //if(!newBounds.Contains(new Vector3Int(tileX, tileY, 1)))
                //{
                //    envMap.SetTile(new Vector3Int(tileX, tileY, 1), null);
                //}
                
            }
        }


        foreach (var map in FindObjectsOfType<TilemapHandler>())
        {
            var tiles = map.map.GetTilesBlock(bounds);         
            map.map.ClearAllTiles();
            map.ResizeBounds();
            map.map.SetTilesBlock(newBounds, tiles);
        }*/

        FindObjectOfType<GridMap>()?.ResetAppearance();
        InputHandler.Instance.ClearUndoRedo();
    }
}
