using UnityEngine;


using System.Collections;


public class BulletPatterns : MonoBehaviour {



	public GameObject gTar, ship;
	public GameObject basicBullet;
	private Transform gPos, sPos;

	void Start(){gPos = gTar.GetComponent<Transform>(); sPos = ship.GetComponent<Transform>();}

	void spawnBullet(float xDir, float yDir, GameObject bulletType){

		GameObject x = (GameObject)Instantiate (bulletType, gTar.GetComponent<Transform> ().position, Quaternion.identity);
		BasicBulletMovement y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = xDir;
		y.yDir = yDir;
	}

	public void CirclePattern1(){

		spawnBullet (-1f, 0f, basicBullet);
		spawnBullet (1f, 0f, basicBullet);
		spawnBullet (-0.951f, -0.309f, basicBullet);
		spawnBullet (-0.809f, -0.5878f, basicBullet);
		spawnBullet (-0.5878f, -0.809f, basicBullet);
		spawnBullet (-0.309f, -0.951f, basicBullet);
		spawnBullet (0f, -1f, basicBullet);
		spawnBullet (0.309f, -0.951f, basicBullet);
		spawnBullet (0.951f, -0.309f, basicBullet);
		spawnBullet (0.809f, -0.5878f, basicBullet);
		spawnBullet (0.5878f, -0.809f, basicBullet);
	}

	public void CirclePattern2(){

		spawnBullet (-0.9877f, -0.1564f, basicBullet);
		spawnBullet (0.9877f, -0.1564f, basicBullet);
		spawnBullet (-0.1564f, -0.9877f, basicBullet);
		spawnBullet (0.1564f, -0.9877f, basicBullet);
		spawnBullet (-0.454f, -0.891f, basicBullet);
		spawnBullet (-0.891f, -0.454f, basicBullet);
		spawnBullet (0.454f, -0.891f, basicBullet);
		spawnBullet (0.891f, -0.454f, basicBullet);
		spawnBullet (-0.7071f, -0.7071f, basicBullet);
		spawnBullet (0.7071f, -0.7071f, basicBullet);
	}

	public void TargetedPattern1(){

		Vector3 normal = new Vector3 (sPos.x - gPos.x, sPos.y - gPos.y);
		normal = normal / normal.magnitude;
		float angle = Mathf.Asin (normal.y);
		spawnBullet (Mathf.cos (angle + 16), Mathf.sin (angle + 16), basicBullet);
		spawnBullet (Mathf.cos (angle - 16), Mathf.sin (angle - 16), basicBullet);
		spawnBullet (normal.x, normal.y, basicBullet);
	}

	public void TargetedPattern2(){

		Vector3 normal = new Vector3 (sPos.x - gPos.x, sPos.y - gPos.y);
		normal = normal / normal.magnitude;
		float angle = Mathf.Asin (normal.y);
		spawnBullet (Mathf.Cos (angle + 8), Mathf.Sin (angle + 8), basicBullet);
		spawnBullet (Mathf.Cos (angle - 8), Mathf.Sin (angle - 8), basicBullet);
		spawnBullet (Mathf.Cos (angle + 24), Mathf.Sin (angle + 24), basicBullet);
		spawnBullet (Mathf.Cos (angle - 24), Mathf.Sin (angle - 24), basicBullet);
	}

	public void TargetedPattern3(){

		float root3Side = Mathf.Sin (60f) * 2f;
		TargetedPattern3BulletSpawner (sPos.x + 2, sPos.y, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x + root3Side, sPos.y + 1, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x + 1, sPos.y + root3Side, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x, sPos.y + 2, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x - root3Side, sPos.y + 1, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x - 1, sPos.y + root3Side, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x - 2, sPos.y, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x - root3Side, sPos.y - 1, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x - 1, sPos.y - root3Side, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x, sPos.y - 2, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x + root3Side, sPos.y - 1, basicBullet);
		TargetedPattern3BulletSpawner (sPos.x + 1, sPos.y - root3Side, basicBullet);
	}

	void TargetedPattern3BulletSpawner(float xPos, float yPos, GameObject bulletType){

		Vector3 normal = new Vector3 (sPos.x - xPos, sPos.y - yPos);
		normal = normal / normal.magnitude;
		GameObject x = (GameObject)Instantiate (bulletType, new Vector3 (xPos, yPos), Quaternion.identity);
		BasicBulletMovement y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = normal.x;
		y.yDir = normal.y;
	}

}
