using UnityEngine;
using System.Collections;

public class SplitBulletMovement : MonoBehaviour {

	public float xDir, yDir, movementSpeed;
	public GameObject boolet;
	private int splitTimer = 0;
	private Transform transform;
	public BulletPatterns bulletSpawner;

	// Use this for initialization
	void Start () {
	
		transform = GetComponent<Transform> ();

	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate(new Vector3(xDir, yDir) * movementSpeed);		

		if(transform.position.x <  -10 || transform.position.x > 10 || transform.position.y < -10 || transform.position.y > 10)
			Destroy(GetComponent<GameObject>());

		if (splitTimer == 40) {

			if (boolet.tag.Equals ("BasicBullet")) {

				bulletSpawner.spawnBullet (xDir, yDir, boolet, transform.position);
				bulletSpawner.spawnBullet (-1 * xDir, yDir, boolet, transform.position);
				bulletSpawner.spawnBullet (-1 * xDir, -1 * yDir, boolet, transform.position);
				bulletSpawner.spawnBullet (xDir, -1 * yDir, boolet, transform.position);
				Destroy (GetComponent<GameObject> ());

			}

			bulletSpawner.spawnSplitterBullet (xDir, yDir, boolet, transform.position);
			bulletSpawner.spawnSplitterBullet (-1 * xDir, yDir, boolet, transform.position);
			bulletSpawner.spawnSplitterBullet (-1 * xDir, -1 * yDir, boolet, transform.position);
			bulletSpawner.spawnSplitterBullet (xDir, -1 * yDir, boolet, transform.position);
			Destroy (GetComponent<GameObject> ());

		}

		if(Random.Range(0, 2) == 1)
			splitTimer++;

	}
}
