using UnityEngine;
using System.Collections;

public class pp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.MoveTo(this.gameObject, iTween.Hash("path",iTweenPath.GetPath("PP"),"Time",10,"easetype", "linear"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
