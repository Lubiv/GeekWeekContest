using UnityEngine;
using System.Collections;

public class YouWonManager : MonoBehaviour
{
    Animator anim;
    float restartTimer;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }
	
	void Update()
    {
        if (Zombie.lastBossKilled == 2)
        {
            Zombie.zombieKilled = 0;
            Zombie.gotYou = false;
            Zombie.lastBossKilled = 0;

            anim.SetTrigger("YouWon");

            restartTimer = Time.deltaTime;

            if (restartTimer >= 5)
            {
                Application.LoadLevel(Application.loadedLevel);
            }
        }
	}
}
