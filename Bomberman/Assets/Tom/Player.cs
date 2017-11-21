using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameManager gM;
    public string bombInput;
    public float bombTimer;
    public int bombStrenght;

	void Start ()
	{
        gM = GameObject.FindWithTag("GameManager").GetComponent<GameManager>();
	}

    private void Update()
    {
        if (Input.GetButtonDown(bombInput))
        {
            GameObject bomb = Instantiate(gM.bomb, transform.position, Quaternion.identity);
            Bomb bombScript = bomb.AddComponent<Bomb>();
            bombScript.timer = bombTimer;
            bombScript.strenght = bombStrenght;
        }
    }
}
