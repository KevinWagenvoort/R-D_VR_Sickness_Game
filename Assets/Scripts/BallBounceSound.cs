using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceSound : MonoBehaviour {

    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.name != "ScoreCollider")
        {
            Debug.Log("Applause");
            AudioSource source = GetComponent<AudioSource>();
            source.Play();
        }
    }
}
