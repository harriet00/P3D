using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObject : MonoBehaviour
{

    public Transform spawnpoint;
    public GameObject prefab;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        Instantiate(prefab, spawnpoint.position, spawnpoint.rotation);
        
    }


}
