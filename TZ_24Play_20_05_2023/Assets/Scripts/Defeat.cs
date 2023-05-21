using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defeat : MonoBehaviour
{
    [SerializeField] private float wallHeight;
    private bool interacted = false;
    private Transform player;

    private void OnCollisionEnter(Collision collision)
    {
        if (interacted)
        {
            return;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            if (collision.transform.parent.transform.childCount - 2 <= wallHeight)
            {
                collision.transform.parent.GetComponent<PlayerMoovement>().Defeat();
            }
            interacted = true;
        }
    }
}
