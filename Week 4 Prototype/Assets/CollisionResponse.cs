using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionResponse : MonoBehaviour
{
    public bool triggered = false;
    public GameObject player;
    // Start is called before the first frame update
    private void Awake()
    {
      
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
          triggered = true;
            this.GetComponent<Rigidbody>().AddForce(-5000,0,0);
            Debug.Log("collision detected hooray" );
            
        }
    }
}
