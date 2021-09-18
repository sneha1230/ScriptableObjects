using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetPlayerInfo : MonoBehaviour
{
    public GameObject playerInfoPanel;
    public Text playerName;
    public Text playerLevel;
    public Text playernumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OpenPlantPanel()
    {
        playerInfoPanel.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
