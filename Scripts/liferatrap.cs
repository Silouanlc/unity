using UnityEngine;
using System.Collections;

public class liferatrap : MonoBehaviour {

	void OncollisionEnter2D(Collision2D Player){
		if(Player.collider.tag=="ratrapeuse"){

			Destroy(gameObject);

	}
}
}