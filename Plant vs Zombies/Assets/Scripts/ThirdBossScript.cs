using UnityEngine;
using System.Collections;

public class ThirdBossScript : MonoBehaviour {

    void Start()
    {
        Vector2 vel = new Vector2(-0.8f, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;
        InvokeRepeating("ChangePosition", 2f, 2f);
    }

    void Update()
    {
        if (Zombie.zombieKilled == 20)
        {
            var pos = gameObject.transform.position;
            pos = new Vector3(8f, Random.Range(-2, 3) * 1.75f + 0.24f, pos.z);
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

    void ChangePosition()
    {
        var newPos = gameObject.transform.position;
        newPos = new Vector3(newPos.x, Random.Range(-2, 3) * 1.75f + 0.24f, newPos.z);
        gameObject.transform.position = newPos;
    }
}
