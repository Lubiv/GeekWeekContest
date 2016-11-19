using UnityEngine;
using System.Collections;

public class ZombieScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector2 vel = new Vector2(-0.2f, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;

        var pos = gameObject.transform.position;
        pos = new Vector3(pos.x, Random.Range(-2, 3) * 1.75f, pos.z);
        gameObject.transform.position = pos;
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    int hp = 10;

    void OnTriggerEnter2D(Collider2D coll)
    {
        hp -= 2;
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}