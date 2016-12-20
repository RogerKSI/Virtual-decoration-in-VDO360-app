using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonFurniture : MonoBehaviour {

    public GameObject furniture;

    // Use this for initialization

    private furnitureManager manager;

    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        manager = GameObject.Find("panelChooseFurniture").GetComponent<furnitureManager>();
    }

    void TaskOnClick()
    {
        manager.targetFurniture = furniture;
        manager.bitCheck |= 2;
    }

    void Update()
    {
        ColorBlock cb = GetComponent<Button>().colors;
        if (manager.bitCheck >= 2 && manager.targetFurniture == furniture)
        {
            cb.normalColor = cb.pressedColor;
            cb.highlightedColor = cb.pressedColor;
        }
        else
        {
            cb.normalColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
            cb.highlightedColor = new Color(0.8f, 0.8f, 0.8f, 0.8f);
        }
        GetComponent<Button>().colors = cb;
    }
}
