using UnityEngine;
using System.Collections;

public class FourthBossScript : MonoBehaviour {

    void Start()
    {
        Vector2 vel = new Vector2(-0.8f, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;
    }

    void Update()
    {
        if (Zombie.zombieKilled == 30)
        {
            var pos = gameObject.transform.position;
            pos = new Vector3(8f, Random.Range(1, 3) * 1.75f, pos.z);
            gameObject.transform.position = pos;
            Zombie.zombieKilled++;
        }

        if (gameObject.transform.position.x < -7f)
        {
            Zombie.gotYou = true;
        }
    }

    int hp = 16;

    void OnTriggerEnter2D(Collider2D coll)
    {
        hp -= 2;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
