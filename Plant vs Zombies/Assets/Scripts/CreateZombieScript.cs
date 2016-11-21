 using UnityEngine;
using System.Collections;

public class CreateZombieScript : MonoBehaviour {

    public GameObject zombie;
    public GameObject fourthBoss;

	void Start ()
    {
        InvokeRepeating("AddZombie", 1f, 4f);
	}

    void Update()
    {
        if(Zombie.zombieKilled == 31)
        {
            Instantiate(fourthBoss);
            var pos = fourthBoss.gameObject.transform.position;
            pos = new Vector3(8, Random.Range(-2, 1) * 1.75f, pos.z);
            fourthBoss.gameObject.transform.position = pos;
            Zombie.zombieKilled ++;
        }
    }

	void AddZombie ()
    {
        Instantiate(zombie);
	}
}
