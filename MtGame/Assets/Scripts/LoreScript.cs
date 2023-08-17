using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoreScript : MonoBehaviour
{
    public AudioSource LoreSound;

    // Start is called before the first frame update
       void OnTriggerEnter(Collider other)
        {

            if (gameObject.tag == "Player")
            {
                LoreSound.Play();
                Destroy(this.gameObject);
            }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
