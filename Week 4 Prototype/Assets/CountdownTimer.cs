using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    CollisionResponse collisionResponse;
    [SerializeField] GameObject sphere;
 
    float currentTime = 0f;

    [SerializeField] float startingTime;
    [SerializeField] Text countdownText;
    // Start is called before the first frame update
    private void Awake()
    {
        collisionResponse = sphere.GetComponent<CollisionResponse>();
    }
    void Start()
    {
     
        /* currentTime = startingTime;
         Destroy(gameObject, currentTime);
     */
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Debug.Log("countdown script:" + collisionResponse.triggered);
        if (collisionResponse.triggered == false) {
            currentTime += 1 * Time.deltaTime;
            countdownText.color = Color.white;
        }
        else
        {
            countdownText.color = Color.magenta;
        }

        countdownText.text = "Time:"+currentTime.ToString("0");

      

        if(currentTime <= 0)
        {
            currentTime = 0;
        }
    }

 
}
