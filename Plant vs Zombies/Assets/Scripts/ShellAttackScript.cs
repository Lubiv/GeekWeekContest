using UnityEngine;
using System.Collections;

public class ShellAttackScript : MonoBehaviour
{

    public GameObject shell;

    void Start()
    {
        InvokeRepeating("AddShell", 1f, 1f);
    }

    static public float posY = 0;

    void Update()
    {
        posY = gameObject.transform.position.y + 0.24f;
        if (Input.GetKeyDown(KeyCode.W) && gameObject.transform.position.y < 3.5f)
        {
            var pos = gameObject.transform.position;
            pos.y += 1.75f;
            gameObject.transform.position = pos;
        }
        if (Input.GetKeyDown(KeyCode.S) && gameObject.transform.position.y > -3.5f)
        {
            var pos = gameObject.transform.position;
            pos.y -= 1.75f;
            gameObject.transform.position = pos;
        }
    }

    void AddShell()
    {
        Instantiate(shell);
    }
}
