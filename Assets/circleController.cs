using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circleController : MonoBehaviour {


    public GameController gameController;

	// Use this for initialization
	void Start () {
		
	}



    // Update is called once per frame
	void Update () {
        
	}

 

    void destroyObject() {
        gameController.miss();
        Destroy(gameObject);
    }

    void OnMouseDown() {
        gameController.hit();
        Destroy(gameObject);
    }
}
