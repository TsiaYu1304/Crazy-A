using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour {
    public GameObject Bullet;
    public GameObject Player;
    private bool flag = true;

    void Start()
    {
        
    }

    void Update()
    {
        Vector3 pos1 = gameObject.transform.position;
        Vector3 pos2 = Player.transform.position;
        float distance = Vector2.Distance(pos1, pos2);
        if (distance<=5&&flag)
        {
            flag = false;
            attack();
        }
        if (distance <=10&& distance>=5)
        {
            flag = true;
        }
    }
    void attack() {
        Instantiate(Bullet, gameObject.transform.position, gameObject.transform.rotation);
    }
    
}
