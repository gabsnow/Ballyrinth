using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushComponent : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            // Detect if the collision is with the player
            if (contact.otherCollider.name == "Player 1" || contact.otherCollider.name == "Player 2")
            {
                contact.otherCollider.GetComponent<Rigidbody>().AddForce(new Vector3(-5, 0, -5), ForceMode.Impulse);
            }
        }
    }
}
