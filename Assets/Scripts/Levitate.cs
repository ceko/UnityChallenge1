using UnityEngine;
using System.Collections;

public class Levitate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(RunLevitateAnimation());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator RunLevitateAnimation() {
		float cycleTime = 1f;
		float yVariance = .02f;
		Vector3 startPosition = transform.localPosition;

		while(true) {
			Vector3 lastStartPosition = transform.localPosition;
			for(float i=0f;i<cycleTime;i+=Time.deltaTime) {
				transform.localPosition = Vector3.Slerp(lastStartPosition, startPosition + Vector3.up * yVariance, i/cycleTime);
				yield return null;
			}

			lastStartPosition = transform.localPosition;

			for(float i=0f;i<cycleTime;i+=Time.deltaTime) {
				transform.localPosition = Vector3.Slerp(lastStartPosition, startPosition - Vector3.up * yVariance, i/cycleTime);
				yield return null;
			}
		}
	}
}
