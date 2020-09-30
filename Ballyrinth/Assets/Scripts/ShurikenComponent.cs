using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenComponent : MonoBehaviour
{
    public float Amplitude, Vitesse;
    private float MinLeft, MaxRight;
    private Vector3 movement, rotationPerSecond;
    private bool ADroite;

    private void Awake()
    {
        rotationPerSecond = new Vector3(0,1500,0);
        movement.x = Vitesse * Time.deltaTime;
        MinLeft = transform.position.x - Amplitude;
        MaxRight = transform.position.x + Amplitude;
    }
    void Update()
    {

        if (!ADroite)
        {
            transform.Translate(movement, Space.World);
            if (transform.position.x >= MaxRight)
            {
                ADroite = true;
            }
        }
        else
        {
            transform.Translate(-movement, Space.World);
            if (transform.position.x <= MinLeft)
            {
                ADroite = false;
            }
        }
        transform.Rotate(rotationPerSecond * Time.deltaTime, Space.World);
    }
}
