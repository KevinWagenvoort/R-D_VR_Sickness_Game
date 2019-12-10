using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public AudioClip clip;
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "ScoreCollider")
        {
            Debug.Log("Applause");
            AudioSource source = GetComponent<AudioSource>();
            source.clip = clip;
            source.Play();
        }
    }
}
