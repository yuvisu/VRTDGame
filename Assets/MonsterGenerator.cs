using UnityEngine;
using System.Collections;

public class MonsterGenerator : MonoBehaviour {
	
	public Transform InitalPosition;
	public GameObject[] Monsters = new GameObject[4];
	private float nextTime = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		Generate(0);
	
	}

	void Generate(int idx){
		if(Time.time > nextTime){
			nextTime = Time.time + 5;
			Instantiate (Monsters[idx], InitalPosition.position, InitalPosition.rotation);
			Debug.Log("DoSomething Loop"+Time.time);
		}
	}
}
