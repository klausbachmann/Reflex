using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {

    public GameController gameController;

    void OnMouseDown()
    {
        gameController.miss();
    }
}
