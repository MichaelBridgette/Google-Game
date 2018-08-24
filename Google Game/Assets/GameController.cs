using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenStore()
    {
        Application.OpenURL("https://store.google.com/");
    }
    public void OpenHopper()
    {
        Application.OpenURL("https://play.google.com/store/apps/details?id=com.area120.grasshopper&hl=en");
    }
    public void OpenNews()
    {
        Application.OpenURL("https://news.google.com/news");
    }
}
