using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using DungeonMusicState = Enums.DungeonMusicState;

public class MusicStateDropDownThing : MonoBehaviour
{

    public Dropdown triggerDropdown;
    public List<Transform> triggerDropdowns;

    
    void Awake()
    {
        
        SetupCategoryDropdowns();
    }

    private void SetupCategoryDropdowns()
    {
        triggerDropdowns = new List<Transform>();
        SetupDropdown<DungeonMusicState>(triggerDropdown);

        triggerDropdowns.Add(triggerDropdown.transform);
    }

    private void SetupDropdown<T>(Dropdown dropdown) where T : Enum
    {
        List<string> options = new List<string>();
        foreach (var e in Enum.GetValues(typeof(T)))
        {
            options.Add(e.ToString());
        }
        dropdown.AddOptions(options);

    }

}
