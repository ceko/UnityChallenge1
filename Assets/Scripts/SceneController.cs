using UnityEngine;
using System.Collections;

public class SceneController : MonoBehaviour {
	
	
	void Start () {
		
	}
	
	void OnGUI () {
		if(GUI.Button(new Rect(10, 10, 150, 50), "Reveal Port")) {
			StartCoroutine(GameObject.Find("/ImpossiblePath/MaskedSegment").GetComponent<AnimationSequences>().RunSequence());
			StartCoroutine(GameObject.Find("/ImpossiblePath/MiddlePath").GetComponent<ShowMiddle>().AnimateChildren());
		}

		if(GUI.Button(new Rect(10, 70, 150, 50), "Reload Scene")) {
			Application.LoadLevel(Application.loadedLevel);
		}
	}
	
}
