using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using UnityStandardAssets.CrossPlatformInput;

public class Player : NetworkBehaviour {

    public float movementSpeed = 10;
    //NetworkBehaviour isLocal;

    Camera playerCamera;



    public override void OnStartLocalPlayer()
    {
        //base.OnStartLocalPlayer();
        //GameObject CamObj = new GameObject();
        //CamObj.name = "cam2";
        //CamObj.transform.parent = transform;
        //CamObj.AddComponent<Camera>();
        //CamObj.transform.position = new Vector3(0, 1.29f, -1.29f);
       
        GetComponentInChildren<Camera>().enabled = true;

    }


    // Use this for initialization
    void Start ()
    {
	    
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if (!isLocal.isLocalPlayer)
        if(!isLocalPlayer)
        {
            return;
        }

        else
        {
            float xMovement = (CrossPlatformInputManager.GetAxis("Horizontal"));
            transform.Translate(new Vector3(xMovement * movementSpeed * Time.deltaTime, 0, 0));
            
            float yMovement = CrossPlatformInputManager.GetAxis("Vertical");
            transform.Translate(new Vector3(0, 0, yMovement * movementSpeed * Time.deltaTime));
        }
        
	}
}
