using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class skor : MonoBehaviour
{
	public static int scoreValue = 0;
	Text score;
    // Start is called before the first frame update
    void Start()
    {   scoreValue = 0;
         score = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
		
     score.text = " Score : " + scoreValue;
    }
}
