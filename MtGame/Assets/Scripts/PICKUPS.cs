using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PICKUPS : MonoBehaviour
{
    public GameObject scoreText;
    public int amountPickedUp;
    public AudioSource collectSound;
    public GameObject Door;

     void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        amountPickedUp += 1;
        scoreText.GetComponent<Text>().text = "KARMA: " + amountPickedUp + "/5";
        Destroy(gameObject);
   
    }

    private void Update()
    {
        if (amountPickedUp == 5)
        {
            Destroy(obj: Door);
        }
        else
        {
            Debug.Log("You have not picked up 5 collectable");
        }
    }

}
