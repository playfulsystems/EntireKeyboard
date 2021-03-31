using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
	//public KeyCode key;
	public string key;
	float growSpeed = 5f;
	float maxScale = 0.2f;
	Vector3 initScale;

	void Start()
	{
		initScale = transform.localScale;
		GetComponent<CircleCollider2D>().enabled = false;
	}

	void Update()
    {
        if (Input.GetKey(key))
		{
			if (transform.localScale.x < maxScale)
			{
				float scaleInc = (Time.deltaTime * growSpeed);
				transform.localScale += new Vector3(scaleInc, scaleInc, 1);
			}
			GetComponent<CircleCollider2D>().enabled = true;
		}
		else
		{
			transform.localScale = initScale;
			GetComponent<CircleCollider2D>().enabled = false;
		}
        
    }
}
