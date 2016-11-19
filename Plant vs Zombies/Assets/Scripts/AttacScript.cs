using UnityEngine;
using System.Collections;

public class AttacScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector2 vel = new Vector2(4f, 0);
        gameObject.GetComponent<Rigidbody2D>().velocity = vel;

        var pos = gameObject.transform.position;
        pos = new Vector3(pos.x, ShellAttackScript.posY, pos.z);
        gameObject.transform.position = pos;
    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        Destroy(gameObject);
    }
}
