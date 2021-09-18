using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PeopleMovement
{
    private static PeopleMovement instance;
    private List<GameObject> obstacles = new List<GameObject>();
    private List<GameObject> goals = new List<GameObject>();
    public List<GameObject> GoalLocations
    {
        get
        {
            return goals;
        }
    }
    public List<GameObject> Obstacles
    {
        get
        {
            return obstacles;
        }
    }

    public static PeopleMovement Singleton
    {
        get
        {
            if (instance == null)
            {
                instance = new PeopleMovement();
                instance.GoalLocations.AddRange(GameObject.FindGameObjectsWithTag("goal"));
            }
            return instance;
        }
    }

    public void AddObstacles(GameObject gameObstacles)
    {
        obstacles.Add(gameObstacles);
        //GoalLocations.Add();
    }

    public void RemoveObstacles(GameObject gameObstacles)
    {
        int index = obstacles.IndexOf(gameObstacles);
        obstacles.RemoveAt(index);
        GameObject.Destroy(gameObstacles);
    }
    public GameObject GetRandomGoalPositions()
    {
        int index=Random.Range(0,GoalLocations.Count);
        return goals[index];
    }
}
