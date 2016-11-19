using UnityEngine;
using System.Collections;

public class FirstBossScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector2 vel = new Vector2(-0.8f, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;
    }
	
	// Update is called once per frame
	void Update () {
        if (Zombie.zombieKilled == 2)
        {
            var pos = gameObject.transform.position;
            pos = new Vector3(8f, -1f, pos.z);
            gameObject.transform.position = pos;
            Zombie.zombieKilled++;
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
