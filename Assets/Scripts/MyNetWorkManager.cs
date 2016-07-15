using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetWorkManager : NetworkManager {
    public void MyStartHost()
    {
        Debug.Log("should start my host at : " + Time.timeSinceLevelLoad);
        StartHost();
    }

    public override void OnStartHost()
    {
        Debug.Log("Host Started At" + Time.timeSinceLevelLoad);
    }

	// Use this for initialization
	void Start ()
    {

    }
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
