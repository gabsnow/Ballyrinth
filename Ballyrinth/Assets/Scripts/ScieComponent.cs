using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScieComponent : MonoBehaviour
{
    private float Amplitude = 1.5f;
    public float Vitesse;
    private float MinHeight, MaxHeight;
    private Vector3 movement, rotationPerSecond;
    private bool EnHaut;

    private void Awake()
    {
        rotationPerSecond = new Vector3(0, 500, 0);
        movement.y = Vitesse/2 * Time.deltaTime;
        MinHeight = transform.position.y - Amplitude;
        MaxHeight = transform.position.y;
    }
    void Update()
    {

        if (!EnHaut)
        {
            transform.Translate(movement, Space.World);
            if (transform.position.y >= MaxHeight)
            {
                EnHaut = true;
            }
        }
        else
        {
            transform.Translate(-movement, Space.World);
            if (transform.position.y <= MinHeight)
            {
                EnHaut = false;
            }
        }
        transform.Rotate(rotationPerSecond * Time.deltaTime, Space.World);
    }

        
}
