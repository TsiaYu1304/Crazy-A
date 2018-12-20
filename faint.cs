using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_faint : MonoBehaviour {
    // Use this for initialization
    public GameObject Player;
    private bool flag = true;
    private float time = 1;
	void Start () {
        InvokeRepeating("timmer", 1f, 1f);
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 pos1 = gameObject.transform.position;
        Vector3 pos2 = Player.transform.position;
        float distance = Vector2.Distance(pos1, pos2);
        if (distance<=5&&flag)
        {
            flag = false;
            gameObject.transform.Rotate(new Vector3(0f,0f,180f) * Time.deltaTime);
            transform.localScale = new Vector3(0.7f, 1f, 0f);
        }
        
        
    }
    void timmer() {
        time += 1;
    }
}
