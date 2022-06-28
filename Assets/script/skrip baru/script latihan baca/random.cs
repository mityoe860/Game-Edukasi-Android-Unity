using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour
{
	public GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        
    }
	int terjawab = 0;
public void random_object() {
			 for (int i = 0; i < 10; i++) {
				 transform.GetChild(i).gameObject.SetActive(false);
			 }
			 int a = Random.Range(0,10);
			 if (transform.GetChild(a).name != "terjawab" ) {
				 terjawab += 1;
				 transform.GetChild(a).gameObject.SetActive(true);
				 transform.GetChild(a).name = "terjawab";
			 }
			 else {
				 if (terjawab < 10)
				 {
					 random_object();
				 }
				 else {
					 square.SetActive(true);
				 }
			 }
			 }
			 
    // Update is called once per frame
    void Update()
    {
        
    }
}
