using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class playPause : MonoBehaviour {
	public Button buttonPlay;

    private player player;
    private Sprite playImage, pauseImage;
	// Use this for initialization
	void Start () {
		Button btn = buttonPlay.GetComponent<Button>();
		btn.onClick.AddListener(toggleActive);

        player = GameObject.Find("Sphere").GetComponent<player>();

        playImage = Resources.Load("picture/b2", typeof(Sprite)) as Sprite;
        pauseImage = Resources.Load("picture/b1", typeof(Sprite)) as Sprite;

        buttonPlay.GetComponent<Image>().sprite = playImage;
    }

    void toggleActive()
	{
		if (!player.isPlay) {
            buttonPlay.GetComponent<Image>().sprite = pauseImage;
			player.isPlay = true;
        }
        else {
            buttonPlay.GetComponent<Image>().sprite = playImage;
            player.isPlay = false;
            player.tmpTime = Time.time - player.point;
        }
    }
}
