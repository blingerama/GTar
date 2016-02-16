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


	public void circlePattern1(){

		Transform z = gTar.GetComponent<Transform> ();
		GameObject x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		BasicBulletMovement y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = -1f;
		y.yDir = 0f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = 1f;
		y.yDir = 0f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = -0.951f;
		y.yDir = -0.309f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = -0.809f;
		y.yDir = -0.5878f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = -0.5878f;
		y.yDir = -0.809f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = -0.309f;
		y.yDir = -0.951f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = 0f;
		y.yDir = -1f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = 0.309f;
		y.yDir = -0.951f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = 0.5878f;
		y.yDir = -0.809f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = 0.809f;
		y.yDir = -0.5878f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = 0.951f;
		y.yDir = -0.309f;

	}

	public void circlePattern2(){

		Transform z = gTar.GetComponent<Transform> ();
		GameObject x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		BasicBulletMovement y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.1564f;
		y.xDir = -0.9877f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.1564f;
		y.xDir = 0.9877f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.xDir = -0.1564f;
		y.yDir = -0.9877f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.9877f;
		y.xDir = 0.1564f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.454f;
		y.xDir = -0.891f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.891f;
		y.xDir = 0.454f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.891f;
		y.xDir = -0.454f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.454f;
		y.xDir = 0.891f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.7071f;
		y.xDir = -0.7071f;

		x = (GameObject)Instantiate(basicBullet, new Vector3(z.position.x, z.position.y), Quaternion.identity);
		y = x.GetComponent<BasicBulletMovement> ();
		y.yDir = -0.7071f;
		y.xDir = 0.7071f;

	}

}
