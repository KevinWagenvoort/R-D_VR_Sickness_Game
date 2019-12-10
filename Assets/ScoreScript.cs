using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public AudioSource source;
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.name == "ScoreCollider")
        {
            Debug.Log("Applause");
            source.Play();
        }
    }
}
