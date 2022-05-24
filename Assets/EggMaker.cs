using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggMaker : MonoBehaviour
{
    public GameObject eggPrefab;
    public GameObject eggSpawnPoint;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.X))
        {
            GameObject clon;
            clon = Instantiate(eggPrefab);
            clon.transform.position = eggSpawnPoint.transform.position;
        }
    }
}