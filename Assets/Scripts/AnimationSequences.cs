using UnityEngine;
using System.Collections;

public class AnimationSequences : MonoBehaviour {

	[System.Serializable]
	public class AnimationSequence {
		public AnimationCurve Curve;
		public Vector3 EndPosition;
		public Vector3 EndRotation;
	}

	public AnimationSequence[] Sequences;

	void Start () {
		//StartCoroutine(RunSequence());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator RunSequence() {
		foreach(AnimationSequence sequence in Sequences) {
			Vector3 startPosition = transform.localPosition;
			Vector3 startRotation = transform.localRotation.eulerAngles;

			for(float i = 0f; i <= sequence.Curve[sequence.Curve.length - 1].time; i+= Time.deltaTime) {
				float curveValue = sequence.Curve.Evaluate(i);
				transform.localPosition = Vector3Lerp(startPosition, sequence.EndPosition, curveValue);
				transform.localRotation = Quaternion.Euler(Vector3Lerp(startRotation, sequence.EndRotation, curveValue));
				yield return null;
			}
		}

		yield return null;
	}

	private static Vector3 Vector3Lerp (Vector3 v1, Vector3 v2, float value) {

		return new Vector3 (v1.x + (v2.x - v1.x)*value, 
		                    v1.y + (v2.y - v1.y)*value, 
		                    v1.z + (v2.z - v1.z)*value );
	}
}
