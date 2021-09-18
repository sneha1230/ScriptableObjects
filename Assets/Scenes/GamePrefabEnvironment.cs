using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePrefabEnvironment : MonoBehaviour
{
    public int width, depth;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < depth; j++)
            {
                Vector3 pos = new Vector3(i, Mathf.PerlinNoise(i*0.2f,j*0.2f)*3, j);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
