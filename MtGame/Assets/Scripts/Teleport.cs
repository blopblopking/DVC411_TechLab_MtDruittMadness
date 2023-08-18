using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerg;
    

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("collideded");
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("yo collision");
            playerg.SetActive(false);
            playerg.GetComponent<CharacterController>().enabled = false;
            player.position = destination.position;
            playerg.GetComponent<CharacterController>().enabled = true;
            playerg.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("collideded");
        if (other.gameObject.CompareTag("Player"))
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
