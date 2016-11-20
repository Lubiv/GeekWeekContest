using UnityEngine;
using System.Collections;

public class GameOverManager : MonoBehaviour
{
    Animator anim;
    float restartTimer;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        if (Zombie.gotYou)
        {
            Zombie.zombieKilled = 0;

            anim.SetTrigger("GameOver");

            Zombie.gotYou = false;

            restartTimer += Time.deltaTime;

            if (restartTimer >= 5)
            {             
                Application.LoadLevel(Application.loadedLevel);
            }
        }
    }
}
