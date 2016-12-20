
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class resetFurniture : MonoBehaviour
{

    public void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(destroyAllFurniture);
    }

    private void destroyAllFurniture()
    {
        GameObject[] furnitures = GameObject.FindGameObjectsWithTag("furniture");

        foreach (GameObject furniture in furnitures)
            Destroy(furniture);
    }
}