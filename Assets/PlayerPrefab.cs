using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefab : MonoBehaviour
{
    [SerializeField]
    private PlayerData info;

    private SetPlayerInfo setPlayerInfo;



    private void Start()
    {
        setPlayerInfo = GameObject.FindGameObjectWithTag("PlantInfoTag").GetComponent<SetPlayerInfo>();
    }

    private void OnMouseDown()
    {
        setPlayerInfo.OpenPlantPanel();
        setPlayerInfo.playerName.text = info.Name;
        setPlayerInfo.playernumber.text = info.number.ToString();
        setPlayerInfo.playerLevel.text = info.PlantThreat.ToString();
    }
    
}
