using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PICKUPS : MonoBehaviour
{
    public GameObject scoreText;
    public AudioSource collectSound;

     void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        Destroy(this.gameObject);
    }

    private void Update()
    {

    }

}
