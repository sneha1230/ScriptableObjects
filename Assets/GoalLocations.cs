using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class GoalLocations
{
    private static GoalLocations instance;

    private List<GameObject> locations = new List<GameObject>();
    
    public  List<GameObject> Locations
    {
        get
        {
            return locations;
        }
    }
    public static GoalLocations Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new GoalLocations();
            }
            return instance;
        }
    }
    public void AddLocation(GameObject loc)
    {
        Locations.Add(loc);
    }
    public void RemoveLocation(GameObject loc)
    {
        int index = locations.IndexOf(loc);
        locations.RemoveAt(index);
        GameObject.Destroy(loc);
    }
}
