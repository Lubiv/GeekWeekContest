using UnityEngine;
using System.Collections;

public class BoosterScript : MonoBehaviour
{
    Animator anim;
    public GameObject sun;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        InvokeRepeating("AddBooster", 10f, 10f);
        InvokeRepeating("DestroyBooster", 13f, 13f);
    }

    void Update()
    {
        if (sun && Input.GetKeyDown(KeyCode.F))
        {
            Zombie.shellSpeed = 8f;
            Zombie.shellPeriod = 0.5f;
        }
    }

    void AddBooster()
    {
        Instantiate(sun);
        anim.SetTrigger("Booster");
    }
    void DestroyBooster()
    {
        Destroy(sun);
        Zombie.shellSpeed = 4f;
        Zombie.shellPeriod = 1f;
    }
}