using UnityEngine;


using System.Collections;


public class BulletPatterns : MonoBehaviour {



	public GameObject gTar, ship;
	public GameObject basicBullet;

	void Start(){circlePattern1(); }

	private int testCounter = 0;

	void Update(){

		if (testCounter == 30)
			circlePattern2 ();

		testCounter++;
	}

	void spawnBullet(float xDir, float yDir, GameObject bulletType){

		GameObject x = (GameObject)Instantiate (bulletType, gTar.GetComponent<Transform> ().position, Quaternion.identity);
		BasicBulletMovement y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = xDir;
		y.yDir = yDir;

	}

	public void circlePattern1(){

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

	public void circlePattern2(){

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

}
