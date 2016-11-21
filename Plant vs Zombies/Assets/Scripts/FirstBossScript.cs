using UnityEngine;
using System.Collections;

public class FirstBossScript : MonoBehaviour {

	void Start () {
        Vector2 vel = new Vector2(-0.8f, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;
    }
	
	void Update () {
        if (Zombie.zombieKilled == 5)
        {
            var pos = gameObject.transform.position;
            pos = new Vector3(8f, -1f, pos.z);
            gameObject.transform.position = pos;
            Zombie.zombieKilled++;
        }

        if (gameObject.transform.position.x < -7f)
        {
            Zombie.gotYou = true;
        }
    }

    int hp = 30;

    void OnTriggerEnter2D(Collider2D coll)
    {
        hp -= 2;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
