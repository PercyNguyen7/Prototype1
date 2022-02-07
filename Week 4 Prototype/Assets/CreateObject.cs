using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnTriggerEnter()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
