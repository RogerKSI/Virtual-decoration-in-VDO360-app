
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class addFurniture : MonoBehaviour
{
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
        if (manager.bitCheck >= 2)
        {

            Vector3 position = Camera.main.transform.position + Camera.main.transform.forward * 70;
            position.y = -40;
            GameObject instantiatedPrefab = Instantiate(manager.targetFurniture, position, Quaternion.identity) as GameObject;
            if (manager.bitCheck % 2 == 1)
            {
                Renderer rend = instantiatedPrefab.GetComponent<Renderer>();
                rend.material.color = manager.targetColor;
            }

            instantiatedPrefab.transform.localScale = new Vector3(10, 10, 10);
            instantiatedPrefab.transform.Rotate(new Vector3(-90, 0, 0), Space.World);
            instantiatedPrefab.AddComponent<furniture>();
            instantiatedPrefab.AddComponent<BoxCollider>();
            instantiatedPrefab.tag = "furniture";

            manager.bitCheck = 0;
            GameObject.Find("panelChooseFurniture").SetActive(false);
        }
    }
}
