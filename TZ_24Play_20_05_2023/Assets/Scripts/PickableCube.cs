using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableCube : MonoBehaviour
{
    [SerializeField] private GameObject cubeStackEffect;
    [SerializeField] private GameObject cubeStackText;
    [SerializeField] private Transform player;
    [SerializeField] private float textPosY;

    private void Start()
    {
        player = GameObject.Find("Player").transform;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector3 textPos = new Vector3(player.position.x, textPosY, player.position.z - 1);

            Instantiate(cubeStackEffect, transform.position, Quaternion.identity);
            Instantiate(cubeStackText, textPos, Quaternion.identity, player);
            collision.transform.parent.GetComponent<AddCubeToPlayer>().AddCube();
            Destroy(this.gameObject);
        }
    }
}
