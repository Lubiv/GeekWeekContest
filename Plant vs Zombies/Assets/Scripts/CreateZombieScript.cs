using UnityEngine;
using System.Collections;

public class CreateZombieScript : MonoBehaviour {

    public GameObject zombie;

	// Use this for initialization
	void Start () {
        InvokeRepeating("AddZombie", 1f, 4f);
	}
	
	// Update is called once per frame
	void AddZombie () {
        Instantiate(zombie);
	}
}
