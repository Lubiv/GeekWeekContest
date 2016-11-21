using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {

	void Start () {
        Vector2 vel = new Vector2(-0.2f, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;

        var pos = gameObject.transform.position;
        pos = new Vector3(pos.x, Random.Range(-2, 3) * 1.75f, pos.z);
        gameObject.transform.position = pos;
    }
	
	void Update () {
        if(gameObject.transform.position.x < -7f)
        {
            Zombie.gotYou = true;
        }
	
	}

    int hp = 10;

    void OnTriggerEnter2D(Collider2D coll)
    {
        hp -= 2;
        if (hp <= 0)
        {
            Destroy(gameObject);
            Zombie.zombieKilled++;
        }
    }
}