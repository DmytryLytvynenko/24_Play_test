using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBrick : MonoBehaviour
{
    private bool interacted = false;
    private Transform player;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (interacted)
        {
            return;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Mathf.Floor(player.position.y) <= transform.position.y)
            {
                collision.transform.parent.GetComponent<PlayerMoovement>().Defeat();
            }
            collision.transform.parent = null;
            collision.transform.GetComponent<Rigidbody>().useGravity = false;
            interacted = true;
        }
    }
}
