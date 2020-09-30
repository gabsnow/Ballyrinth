using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciateArrowComponent : MonoBehaviour
{
    public GameObject projectileToShoot;
    public float projectileSpeed = 150;
    public Transform projectileExit;
    public float timeBetweenShots = 1.5f;
    private float elapsedTime = 0;

    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= timeBetweenShots)
        {
            elapsedTime = 0;
            GameObject projectile = Instantiate(projectileToShoot, projectileExit.position, projectileExit.rotation);
            projectile.GetComponent<MoveForwardComponent>().displacementPerSecond = projectileSpeed;
        }        
    }
}
