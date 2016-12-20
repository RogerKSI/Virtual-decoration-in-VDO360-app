using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonColor : MonoBehaviour {

    public Color color;

    private furnitureManager manager;
    // Use this for initialization
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);

        manager = GameObject.Find("panelChooseFurniture").GetComponent<furnitureManager>();
    }

    void TaskOnClick()
    {
        manager.targetColor = color;
        manager.bitCheck |= 1;
    }

    void Update()
    {
        ColorBlock cb = GetComponent<Button>().colors;
        if (manager.bitCheck % 2 == 1 && manager.targetColor == color)
            cb.normalColor = new Color(1.0f, 1.0f, 1.0f, 1.0f);
        else
            cb.normalColor = new Color(0.7f, 0.7f, 0.7f, 0.3f);
        GetComponent<Button>().colors = cb;
    }
}