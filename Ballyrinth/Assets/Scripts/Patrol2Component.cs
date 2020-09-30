using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol2Component : MonoBehaviour
{
    public float Amplitude, Vitesse;
    private float MinLeft, MaxRight;
    private Vector3 movement;
    private bool ADroite;

    private void Awake()
    {        
        movement.z = Vitesse * Time.deltaTime;
        MinLeft = transform.position.z - Amplitude;
        MaxRight = transform.position.z + Amplitude;
    }
    void Update()
    {
        Debug.Log(movement);
        if (!ADroite)
        {
            transform.Translate(movement, Space.World);
            if (transform.position.z >= MaxRight)
            {
                ADroite = true;
            }
        }
        else
        {
            transform.Translate(-movement, Space.World);
            if (transform.position.z <= MinLeft)
            {
                ADroite = false;
            }
        }
    }
}
