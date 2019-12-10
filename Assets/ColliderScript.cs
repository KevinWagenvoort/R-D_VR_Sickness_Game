using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{
    private Collider c1, c2;

    private void OnCollisionEnter(Collision collision)
    {
        c1 = collision.collider;
        Debug.Log("Applause!");
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
        Collider collider = GetComponent<BoxCollider>();
        c2 = collider;
        Physics.IgnoreCollision(c1, c2, true);
        Invoke("EnableAfter", 5);
    }

    void EnableAfter()
    {
        Physics.IgnoreCollision(c1, c2, false);
    }
}
