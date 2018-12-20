using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy_attack1 : MonoBehaviour {
    public GameObject Bullet;
    public GameObject Player;
    private bool flag=true;

    void Start () {
	}
	
	void Update () {
        Vector3 pos1 = gameObject.transform.position;
        Vector3 pos2 = Player.transform.position;
        float distance = Vector2.Distance(pos1, pos2);
        if (distance <=7&&flag)
        {
            flag = false;
            attack();
        }
        if(distance <=10&&distance>7)
        {
            flag = true;
        }
    }
    void attack()
    {
        Vector3 pos = gameObject.transform.position + new Vector3(0, 1.0f, 0);
        Instantiate(Bullet, pos, gameObject.transform.rotation);
    }
}
