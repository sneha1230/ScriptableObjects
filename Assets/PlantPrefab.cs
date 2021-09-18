using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlantPrefab : MonoBehaviour
{
    [SerializeField]
    private PlantData info;

    private SetPlantInfo setPlantInfo;



    private void Start()
    {
        setPlantInfo = GameObject.FindGameObjectWithTag("PlantInfoTag").GetComponent<SetPlantInfo>();
    }

    private void OnMouseDown()
    {
        setPlantInfo.OpenPlantPanel();
        setPlantInfo.planeName.text = info.Name;
        setPlantInfo.plantIcon.GetComponent<RawImage>().texture = info.Icon;
        setPlantInfo.phreatLevel.text = info.PlantThreat.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")&&info.PlantThreat==PlantData.THREAT.High)
        {
            PlayerController.dead = true;
        }
    }
}
