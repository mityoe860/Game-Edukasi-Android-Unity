using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{
private void Awake()
{
GameObject[] musicObj = GameObject.FindGameObjectsWithTag("gamemusic");
if(musicObj.Length > 1)
{
Destroy(this.gameObject);
}
DontDestroyOnLoad(this.gameObject);
}
}