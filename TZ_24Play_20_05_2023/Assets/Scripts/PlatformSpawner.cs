using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 posOffset;
    public GameObject Platform;
    public float halfPlatformLength;
    public int start;
    private float currentPos;
    private bool spawned = false;

    void Update()
    {
        transform.position = new Vector3(0,posOffset.y, playerTransform.position.z + posOffset.z);
        SpawnPlatform();
        
    }
    private void SpawnPlatform()
    {
        SpawnedUpdate();
        if (spawned)
        {
            return;
        }
        if ((int)(transform.position.z - start) % (halfPlatformLength * 2 - 1) == 0)
        {
            Vector3 pos = new Vector3(transform.position.x, transform.position.y, (int)transform.position.z - halfPlatformLength);
            Instantiate(Platform, pos, Quaternion.identity);
            spawned = true;
            currentPos = transform.position.z;
        }
    }
    private void SpawnedUpdate()
    {
        if (transform.position.z > (currentPos + 5))
        {
        spawned = false;
        }
    }
}
