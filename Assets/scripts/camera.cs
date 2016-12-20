using UnityEngine;
using System.Collections;

public class camera : MonoBehaviour {

    public float turnSpeed = 50f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.left * turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.right * turnSpeed * Time.deltaTime);
        }

    }

}
