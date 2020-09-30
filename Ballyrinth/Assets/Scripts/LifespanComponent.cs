using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifespanComponent : MonoBehaviour
{
    private float elapsedTime;
    private float maxLifespan = 6;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;

        if (elapsedTime >= maxLifespan)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        Destroy(gameObject);
    }
}
