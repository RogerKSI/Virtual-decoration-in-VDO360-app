using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class tableColor : MonoBehaviour {
	public Button buttonAdd;

	private GameObject panelFurniture;

	void Start()
	{
		Button btn = buttonAdd.GetComponent<Button>();
		panelFurniture = GameObject.Find("c1");
		toggleActive();
		btn.onClick.AddListener(toggleActive);
		panelFurniture = GameObject.Find("c2");
		toggleActive();
		btn.onClick.AddListener(toggleActive);
	}

	void toggleActive()
	{
		panelFurniture.SetActive(!panelFurniture.activeSelf);
	}

}