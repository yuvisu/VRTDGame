using System;
using System.IO;
using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	public TextAsset csvFile;
	// Use this for initialization
	void Start () {
		string[] records = csvFile.text.Split ('\n');
		foreach (string record in records){
			string[] attrs = csvFile.text.Split (',');
			foreach (string attr in attrs){
				Debug.Log(attr);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
