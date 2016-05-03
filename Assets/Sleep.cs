using UnityEngine;
using System.Collections;
using System.Threading;
public class Sleep : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Thread.Sleep(1000000);
		iTween.MoveTo(gameObject, iTween.Hash("path",iTweenPath.GetPath("PP"),"Time",120));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
