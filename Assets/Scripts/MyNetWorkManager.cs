using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetWorkManager : NetworkManager {
    public void MyStartHost()
    {
		Debug.Log( Time.timeSinceLevelLoad + "---StartHost " );
        StartHost();
    }

    public override void OnStartHost()
    {
		Debug.Log(Time.timeSinceLevelLoad+"---Host Started At"  );
    }


	public override void OnStartClient(NetworkClient myClient)
	{
		Debug.Log ( Time.timeSinceLevelLoad+"---Client Start Requested");
		InvokeRepeating	("printDots", 0f, 1f);
	}

	public override void OnClientConnect(NetworkConnection conn)
	{
		Debug.Log (Time.timeSinceLevelLoad + "Client Is Connected To IP : " + conn.address);
		CancelInvoke ("printDots");
	}

    void printDots()
	{
		print (".");
	}
}
