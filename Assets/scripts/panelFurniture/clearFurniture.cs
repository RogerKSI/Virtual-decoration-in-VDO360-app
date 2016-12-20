using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class clearFurniture : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        furnitureManager manager = GameObject.Find("panelChooseFurniture").GetComponent<furnitureManager>();
        manager.bitCheck = 0;
    }
}
