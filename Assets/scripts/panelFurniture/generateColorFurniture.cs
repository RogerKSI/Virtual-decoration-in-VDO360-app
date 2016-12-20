using UnityEngine;
using UnityEngine.UI;

public class generateColorFurniture : MonoBehaviour
{

    public GameObject button;

    private Color[] colors;

    // Use this for initialization
    void Start()
    {
        colors = new Color[] { Color.red,Color.white,Color.yellow,Color.green,Color.blue,Color.cyan,Color.magenta,Color.black };
        for (int i = 0; i < colors.Length; i++)
        {

            GameObject instantiatedPrefab = Instantiate(button) as GameObject;
            instantiatedPrefab.transform.SetParent(gameObject.transform, false);
            instantiatedPrefab.GetComponent<Image>().color = colors[i];
            buttonColor btnc = instantiatedPrefab.AddComponent<buttonColor>();
            btnc.color = colors[i];
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
