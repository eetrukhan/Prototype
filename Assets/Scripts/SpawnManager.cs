using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject projectile;

    private Vector3 startPos = new Vector3(30, 0, 0);
    private float startDelay = 2;
    private float repeatRate = 2;
    private PlayerController playerControllerScript;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), startDelay, repeatRate);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    } 
    //test1

    // Update is called once per frame
    private void SpawnObstacle()
    {
        if( playerControllerScript.isGameOver == false)
            Instantiate(projectile, startPos, projectile.transform.rotation);
    }
}
