using UnityEngine;
using System.Collections;

public class sunny : MonoBehaviour {

    public Light light;
    public Light sun;
    public float timeMultiplier = 1f;

    private player player;
    private float time;

    void Start()
    {
        player = GameObject.Find("Sphere").GetComponent<player>();
        time = 250.0f / player.numberOfFrames;
    }

    void Update()
    {
        if (player.isPlay)
        {
            Quaternion rot = new Quaternion();
            rot.eulerAngles = new Vector3(25 + 130.0f * player.currentFrame / player.numberOfFrames,-90,0);
            light.transform.rotation = rot;

            rot.eulerAngles = new Vector3(205 + 130.0f * player.currentFrame / player.numberOfFrames,-90,0);
            sun.transform.rotation = rot;
        }

    }

}