using UnityEngine;
using System.Collections;

public class rotatio : MonoBehaviour {
	
	public float speed = 10.5f;
	public string axisName = "Horizontal";
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKey(KeyCode.LeftArrow)) {
			// Clockwise
			transform.Rotate(0, 0, -2.0f); // --> Instead of "transform.Rotate(-1.0f, 0.0f, 0.0f);"
		}
		
		if(Input.GetKey(KeyCode.RightArrow)) {
			// Counter-clockwise
			transform.Rotate(0, 0, 2.0f); // --> Instead of transform.Rotate(1.0f, 0.0f, 0.0f);
		}
		
	}
}