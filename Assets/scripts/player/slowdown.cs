using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class slowdown : MonoBehaviour {

	public Button buttonSlowdown;

	// Use this for initialization
	void Start () {
		Button btn = buttonSlowdown.GetComponent<Button>();
		btn.onClick.AddListener(toggleActive);
	}

	void toggleActive()
	{
        GameObject.Find("Sphere").GetComponent<player>().downpoint(1);
	}

}
