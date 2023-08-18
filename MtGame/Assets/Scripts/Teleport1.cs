using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport1 : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerg;
    


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Debug.Log("yo collision");
            playerg.SetActive(false);
            playerg.GetComponent<CharacterController>().enabled = false;
            player.position = destination.position;
            playerg.GetComponent<CharacterController>().enabled = true;
            playerg.SetActive(true);
        }

    }

}
