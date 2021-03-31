using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayoutKeys : MonoBehaviour
{
    public GameObject keyPrefab;
    public Vector2 startPos;
    public Vector2 padding;

    string allLetters = "qwertyuiopasdfghjklzxcvbnm";
    char[] letters;

    void Start()
    {
        letters = allLetters.ToCharArray();

        Vector2 letterPosition = startPos;
        foreach(char letter in allLetters)
		{
            GameObject newKeyObject = Instantiate(keyPrefab);
            newKeyObject.GetComponent<KeyScript>().key = letter.ToString();
            newKeyObject.transform.position = letterPosition;

            // adding x padding to x position
            letterPosition += new Vector2(padding.x, 0);

            // adding y padding to y position
            if (letter == 'p' || letter == 'l') {
                letterPosition -= new Vector2(0, padding.y);

                // when you get to the end of the line indent by adding more to x
                float resetXpos = startPos.x;
                if (letter == 'p') resetXpos += padding.x * 0.5f;
                if (letter == 'l') resetXpos += padding.x * 1.5f;

                letterPosition = new Vector2(resetXpos, letterPosition.y);
            }
        }
    }

}
