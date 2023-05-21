using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoovement : MonoBehaviour
{
    [SerializeField] private GameObject loseScreen;
    [SerializeField] private float moveSpeed;
    private float tempMoveSpeed;
    public bool defeated = false;
    private void Start()
    {
        tempMoveSpeed = moveSpeed;
        moveSpeed = 0;
    }
    void Update()
    {
        transform.Translate(new Vector3(0,0, moveSpeed));
        Debug.Log(transform.childCount);
    }

    public void Activate()
    {
        moveSpeed = tempMoveSpeed;
    }
    public void Defeat()
    {
        moveSpeed = 0;
        loseScreen.SetActive(true);
        defeated = true;
    }
}
