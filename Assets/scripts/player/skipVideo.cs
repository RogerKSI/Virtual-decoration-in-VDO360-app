using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System;

public class skipVideo : MonoBehaviour,IPointerClickHandler {

    private Scrollbar videobar;
    private player player;

    void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
    {
        Vector2 localCursor;
        var rect1 = GetComponent<RectTransform>();
        var pos1 = Input.mousePosition;
        if (!RectTransformUtility.ScreenPointToLocalPointInRectangle(rect1, pos1, null, out localCursor)) return;

        int xpos = (int)(localCursor.x);
        
        if (xpos < 0) xpos = xpos + (int)rect1.rect.width / 2;
        else xpos += (int)rect1.rect.width / 2;

        videobar.size = (float)(xpos) / (489.3f);
        player.tmpTime = ((int)(videobar.size * player.numberOfFrames - 1)) * 1.0f / player.frameRate;
        player.point = Time.time - player.tmpTime;
    }

    // Use this for initialization
    void Start () {
        videobar = GetComponent<Scrollbar>();
        player = GameObject.Find("Sphere").GetComponent<player>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
