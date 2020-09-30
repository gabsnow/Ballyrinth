using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinComponent : MonoBehaviour
{
    public Vector3 rotationPerSecond;
    public Space space;

    void Update()
    {
        transform.Rotate(rotationPerSecond * Time.deltaTime, space);
    }
}
