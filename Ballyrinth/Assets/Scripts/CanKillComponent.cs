using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CanKillComponent : MonoBehaviour
{
    private Vector3 spawn1, spawn2;
    private Quaternion initialRot1, initialRot2;
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    private void Awake()
    {
        spawn1 = new Vector3(203.78f, 20.5f, 200.89f);
        spawn2 = new Vector3(204.05f, 20.5f, 223f);
        initialRot1 = new Quaternion(0, 0, 0, 0);
        initialRot2 = new Quaternion(0, 180, 0, 0);
    }
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            // Detect if the collision is with the player
            if (contact.otherCollider.name == "Player 1")
            {
                MusicSource.Play();
                contact.otherCollider.transform.position = spawn1;
                contact.otherCollider.transform.rotation = initialRot1;
            }
            if (contact.otherCollider.name == "Player 2")
            {
                MusicSource.Play();
                contact.otherCollider.transform.position = spawn2;
                contact.otherCollider.transform.rotation = initialRot2;
            }
        }
    }
}
