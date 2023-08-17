using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmyManSound : MonoBehaviour
{
    public AudioSource openingSound;
    public float timer;
    public float deleteTimer;
    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        openingSound.Play();
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > deleteTimer)
        {
            Destroy(gameObject);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
