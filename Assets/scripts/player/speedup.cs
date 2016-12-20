using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class speedup : MonoBehaviour {

	public Button buttonSpeedup;

	// Use this for initialization
	void Start () {
		Button btn = buttonSpeedup.GetComponent<Button>();
		btn.onClick.AddListener(toggleActive);
	}

	void toggleActive()
	{
        GameObject.Find("Sphere").GetComponent<player>().uppoint(1);
	}

}
