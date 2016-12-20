using UnityEngine;
using UnityEngine.UI;

public class generateListFurniture : MonoBehaviour {

    public GameObject button;

    private string[] furnitures;

	// Use this for initialization
	void Start () {
        furnitures = new string[] { "black table", "white chair", "wood table", "wood chair", "sofa" ,"","","","","","","","",""};
        for(int i=0; i<furnitures.Length; i++) {
            string s = furnitures[i];
            GameObject instantiatedPrefab = Instantiate(button) as GameObject;
            instantiatedPrefab.transform.SetParent(gameObject.transform,false);
            instantiatedPrefab.transform.position += new Vector3(0,-30 * i,0);
            instantiatedPrefab.GetComponentInChildren<Text>().text = s;
            buttonFurniture btnf = instantiatedPrefab.AddComponent<buttonFurniture>();
            btnf.furniture = (Resources.Load("models/furnitures/" + s,typeof(GameObject)) as GameObject);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
