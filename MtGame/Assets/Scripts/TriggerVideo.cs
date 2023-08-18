using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TriggerVideo : MonoBehaviour
{
    // Start is called before the first frame update
  
    public GameObject videoPlayer;
    public int timeToStop;

    private void Start()
    {
        videoPlayer.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        videoPlayer.SetActive(true);
        Destroy(videoPlayer, timeToStop);
    }
}
