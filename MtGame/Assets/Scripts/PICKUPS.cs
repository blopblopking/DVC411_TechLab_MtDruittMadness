using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PICKUPS : MonoBehaviour
{
    public GameObject scoreText;
    public AudioSource collectSound;
    public AudioSource loreSound;

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        loreSound.Play();
        Destroy(this.gameObject);
    }

    private void Update()
    {

    }

}
