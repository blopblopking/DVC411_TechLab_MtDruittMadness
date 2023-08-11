using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Openthenorr : MonoBehaviour
{
    public int amountPickedUp;
    public GameObject Door;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(CompareTag("Pick Up"))
        amountPickedUp += 1;
    }
    // Update is called once per frame
    void Update()
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
