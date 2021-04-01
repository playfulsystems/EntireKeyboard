using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollider : MonoBehaviour
{
	public GameObject keyObject;    // the gameobject that grows
	public GameObject alphaObject;  // alpha object to show where key is
	public string key;				// which character to press
	float growSpeed = 4f;			// how fast it will grow
	float maxScale = 0.3f;			// max scale for keyObject
	Vector3 initScale;				// to hold initial scale

	void Start()
	{
		initScale = keyObject.transform.localScale;
		keyObject.GetComponent<CircleCollider2D>().enabled = false;
		alphaObject.transform.localScale = new Vector3(maxScale, maxScale, 1f);
	}

	void Update()
    {
        if (Input.GetKey(key))
		{
			if (keyObject.transform.localScale.x < maxScale)
			{
				float scaleInc = (Time.deltaTime * growSpeed);
				keyObject.transform.localScale += new Vector3(scaleInc, scaleInc, 1);
			}
			else
			{
				keyObject.transform.localScale = new Vector3(maxScale, maxScale, 1);
			}
			keyObject.GetComponent<CircleCollider2D>().enabled = true;
		}
		else
		{
			keyObject.transform.localScale = initScale;
			keyObject.GetComponent<CircleCollider2D>().enabled = false;
		}
        
    }
}
