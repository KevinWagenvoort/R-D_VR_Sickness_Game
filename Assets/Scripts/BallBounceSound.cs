﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour {

    public AudioClip clip;
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name != "ScoreCollider")
        {
            Debug.Log("Applause");
            AudioSource source = GetComponents<AudioSource>()[0];
            source.clip = clip;
            source.Play();
        }
    }
}
