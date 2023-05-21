using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TouchControll : MonoBehaviour, IDragHandler, IPointerDownHandler
{
    public float moveSpeed;
    [SerializeField] private float rightBorder;
    [SerializeField] private float leftBorder;
    public GameObject startText;
    public GameObject player;

    public void OnDrag(PointerEventData eventData)
    {
        if (eventData.delta.x > 0 && player.transform.position.x < rightBorder)
        {
            player.transform.position += Vector3.right * moveSpeed;
        }
        else if (player.transform.position.x > leftBorder)
        {
            player.transform.position += Vector3.left * moveSpeed;
        }
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        player.GetComponent<PlayerMoovement>().Activate();
        startText.SetActive(false);
        OnDrag(eventData);

    }
}
