using UnityEngine;
using System.Collections;

public class Move_Towards_Player : MonoBehaviour {
	
	private Transform player;
	public float speed = 1.0f; //How fast the enemy will move

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Duck_Ship").transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 delta = player.position - transform.position;
		delta.Normalize ();
		float moveSpeed = speed * Time.deltaTime;
		transform.position = transform.position + (delta * moveSpeed);
	}
}
