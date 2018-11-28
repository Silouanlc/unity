using UnityEngine;
using System.Collections;

public class Menuscript : MonoBehaviour {

	// bonne question
	void OnGUI () {
		const int buttonWidth = 84;
		const int buttonHeight = 60;
		// affiche ce putain de bouton de merde qui me cassse les couilles 
		if (
			GUI.Button (
			// doit etre la pos
			new Rect(
			Screen.width / 2- (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			),
			"Play"
		)
			)
		{ 

			Application.LoadLevel("stage1");
		
	}
	
	}
}
