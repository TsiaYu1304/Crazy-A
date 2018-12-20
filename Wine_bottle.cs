using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Wine_bottle : MonoBehaviour {
    private float time=1;
    private bool flag= true;
    public GameObject Bullet;
    private int state ;

    // Use this for initialization
    void Start () {
        InvokeRepeating("Timmer",0.1f,0.1f);
        Vector3 pos1 = gameObject.transform.position;
        Vector3 pos2 = Bullet.transform.position;
        float distance = pos2.y - pos1.y;
        if (distance > 0)
        {
            state = 1;
        }
        if (distance<=0) {
            state = 2;
        }
    }
	
	// Update is called once per frame
	void Update () {

        if (state == 1) {
            attack_up();
        }
        if (state==2)
        {
            attack_down();
        }
     
        //1.5秒後移除酒瓶
        if (time>=1.7)
        {
            Destroy(gameObject);
        }
    }
    void Timmer(){
        time +=0.1f;
    }
    void attack_up() {
        gameObject.transform.position += new Vector3(-0.2f, 0.2f, 0f);
    }
    void attack_down() {
        gameObject.transform.position += new Vector3(-0.2f, -0.2f, 0f);
    }
}
