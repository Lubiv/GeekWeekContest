using UnityEngine;
using System.Collections;

public class AttackScript : MonoBehaviour {

	void Start () {
        Vector2 vel = new Vector2(Zombie.shellSpeed, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;

        var pos = gameObject.transform.position;
        pos = new Vector3(pos.x, ShellAttackScript.posY, pos.z);
        gameObject.transform.position = pos;
    }

    void Update () {
        if (gameObject.transform.position.x > 12.5) Destroy(gameObject);
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(gameObject);
    }
}
