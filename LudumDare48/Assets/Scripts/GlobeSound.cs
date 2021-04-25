using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobeSound : MonoBehaviour
{
    private AudioSource audio;

    private GameObject octopus;

    // Start is called before the first frame update
    void Start()
    {
        audio = this.GetComponent<AudioSource>();
        octopus = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(this.transform.position, octopus.transform.position) < audio.maxDistance && !audio.isPlaying)
        {
            audio.Play();
        }
        else if (Vector2.Distance(this.transform.position, octopus.transform.position) > audio.maxDistance && audio.isPlaying)
            audio.Stop();
        audio.volume = 0.5f / Vector2.Distance(this.transform.position, octopus.transform.position);
    }
}
