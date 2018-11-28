using UnityEngine;
using System.Collections;

public class retourmenu : MonoBehaviour {

	void OnDestroy()
	{
		// Game Over.
		// Ajouter un nouveau script au parent
		// Car cet objet va être détruit sous peu
		transform.parent.gameObject.AddComponent<Gameover>();
	}
}