using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class togglePanel : MonoBehaviour {
    public Button buttonAdd;

    private GameObject panelFurniture;

    void Start()
    {
        Button btn = buttonAdd.GetComponent<Button>();
        panelFurniture = GameObject.Find("panelChooseFurniture");
        toggleActive();
        btn.onClick.AddListener(toggleActive);
    }

    void toggleActive()
    {
        panelFurniture.SetActive(!panelFurniture.activeSelf);
    }
        
}