using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCubeToPlayer : MonoBehaviour
{
    public GameObject playerCube;
    public GameObject player;
    public void AddCube()
    {
        Vector3 pos = player.transform.position;
        player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 1.1f, player.transform.position.z);
        Instantiate(playerCube, pos, Quaternion.identity, transform);
    }
}
