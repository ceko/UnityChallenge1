using UnityEngine;
using System.Collections;

public class ShowMiddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//StartCoroutine(AnimateChildren());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator AnimateChildren() {
		foreach(Transform child in transform) {
			//show the child over the course of .2 seconds
			foreach(MeshRenderer meshRenderer in child.GetComponentsInChildren<MeshRenderer>()) {
				meshRenderer.enabled = true;
			}
			float timeToShow = .3f;
			Vector3 targetLocalScale = child.localScale;

			for(float i=0f;i<timeToShow;i+=Time.deltaTime) {
				child.localScale = Vector3.Slerp(Vector3.zero, targetLocalScale, i/timeToShow);
				yield return null;
			}

			child.localScale = targetLocalScale;
			child.gameObject.AddComponent<Levitate>();
		}
	}

}
