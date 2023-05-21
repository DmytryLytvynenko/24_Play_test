using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public Transform playerTransform;
    public Vector3 posOffset;

    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x + posOffset.x, playerTransform.position.y + posOffset.y, playerTransform.position.z + posOffset.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
