using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public int numberOfFrames;
    public float frameRate;
    public string nameVideo;
	public bool isPlay;
    public float point;
	public float tmpTime;

    private Texture2D[] frames;
    public int currentFrame;

    public Scrollbar videobar;

    public void uppoint(float val)
    {
        if (point + val < Time.time)
            point += val;
    }

    public void downpoint(float val)
    {
        if ((int)((Time.time - (point - val)) * frameRate) < frames.Length)
            point -= val;
    }

    void Start()
    {
        // load the frames
        frames = new Texture2D[numberOfFrames];
		tmpTime = 0;
		point = 0;
		isPlay = false;
        for (int i = 0; i < numberOfFrames; ++i)
            frames[i] = (Resources.Load("video/" + nameVideo + "/frame/" + nameVideo + string.Format("{0:d4}", i + 1) , typeof(Texture2D))) as Texture2D;
    }

    void Update()
    {
        if(!isPlay){
            point = Time.time - tmpTime;
        }
        currentFrame = (int)((Time.time - point) * frameRate);
        tmpTime = Time.time - point;

        if (currentFrame >= frames.Length) {
			currentFrame = frames.Length - 1;
			point = Time.time;
		}
        videobar.size = (float)(currentFrame) / (frames.Length - 1);
        GetComponent<Renderer>().material.mainTexture = frames[currentFrame];
    }
}