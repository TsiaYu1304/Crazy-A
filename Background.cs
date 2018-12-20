using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Background : MonoBehaviour {
    public float mSpeed=3.0F;

	void Start () {
		
	}
    void Update()
    {
        //Translate form right to left  
        transform.Translate(Vector3.right * Time.deltaTime * mSpeed);
        // If first background is out of camera view,then show sencond background  
        if (transform.position.x <= -16.4F)
        {
            //We can chenge this value to reduce the wdith between 2 background  
            transform.position = new Vector3(16.4F, transform.position.y, transform.position.z);
        }
    }
}
