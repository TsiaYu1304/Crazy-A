using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class mouse_Separate : MonoBehaviour {
    private float time = 1;
    private float speed_left = 3.0f;
    private float speed_down = 1.0f;

    void Start()
    {
        InvokeRepeating("Timmer", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        //分身從本尊往下
        transform.Translate(Vector3.down * Time.deltaTime * speed_down);
        transform.Translate(Vector3.left * Time.deltaTime * speed_left);
        //往下2秒後停止
        if (time >= 2.0f)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed_down);
        }
        //5秒後移除分身
        if (time % 5== 0)
        {
            Destroy(gameObject);
        }
    }
    void Timmer()
    {
        time += 1;
    }
    
}
