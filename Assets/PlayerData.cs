using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "PlayerData", order = 50)]

public class PlayerData : ScriptableObject
{
    public enum LEVEL { Beginner,Intermediate,Advanced }
    [SerializeField]
    private string playerName;
    [SerializeField]
    private LEVEL playerThreat;
    [SerializeField]
    private int playerNumber;

    public string Name { get { return playerName; } }
    public LEVEL PlantThreat { get { return playerThreat; } }
    public int number { get { return playerNumber; } }
}
