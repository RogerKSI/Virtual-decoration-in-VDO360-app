using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;
using System;

public class left : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{

    public float turnSpeed = 30f;
    private bool mouseDown;

    void Start()
    {
        mouseDown = false;
    }

    void Update()
    {
        if(mouseDown)
            Camera.main.GetComponent<camera>().transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime, Space.World);
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        mouseDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        mouseDown = false;
    }
}
