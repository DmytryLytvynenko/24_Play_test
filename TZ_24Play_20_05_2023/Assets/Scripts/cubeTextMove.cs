using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeTextMove : MonoBehaviour
{
    public float velocity;// скорость подъема
    public float offsetY;

    private Vector3 end;// докуда подниматься

    void Start()
    {
        end = new Vector3(transform.position.x, transform.position.y + offsetY, transform.position.z);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, end, velocity * Time.deltaTime);
        Invoke(nameof(Die), 5f);
    }

    private void Die()
    {
        Destroy(this.gameObject);
    }
}
