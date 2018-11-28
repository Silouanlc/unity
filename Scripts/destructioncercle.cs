using UnityEngine;
using System.Collections;

public class destructioncercle : MonoBehaviour {

	void OnTriggerExit2D(Collider2D other)
		{
		Destroy(gameObject);
	}
}