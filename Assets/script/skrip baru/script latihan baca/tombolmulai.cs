using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombolmulai : MonoBehaviour
{

public GameObject square, reset;

    // Start is called before the first frame update
    void Start()
    {
      
    }

public void diklik()
{
	if (square.activeInHierarchy == true){
		square.SetActive(false);
	reset.SetActive(false); }
	else {
		square.SetActive(true);
	reset.SetActive(true); }
}
	public void suara() {
GetComponent<AudioSource> ().Play ();}
    // Update is called once per frame
    void Update()
    {
        
    }
}
