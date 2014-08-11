using UnityEngine;
using System.Collections;

public class PathInitialization : MonoBehaviour {

	public int RenderQueue = 3000; //default geometry render queue

	// Use this for initialization
	void Start () {
		renderer.material.renderQueue = RenderQueue;
	}

	void Awake () {
		Material[] materials = renderer.materials;
		for (int i = 0; i < materials.Length; ++i) {
			materials[i].renderQueue = RenderQueue;
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
