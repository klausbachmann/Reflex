using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject circle;
    public float gameSpeed = 0.5f;
    bool waiting = false;
    public int circlesHitted;
    public int circlesMissed;
    bool gameOver = false;

    public Text txtHits, txtMissed, txtAccuracy;
    

    // Use this for initialization
    void Start () {
		
	}

    public void hit() {
        circlesHitted++;
        txtHits.text = "Hits: " +  circlesHitted.ToString();
    }

    public void miss() {
        circlesMissed++;
        txtMissed.text = "Missed: " + circlesMissed.ToString();

        if (circlesMissed == 5) {
            // GAME OVER
            gameOver = true;
            print("GAME OVER");
        }
    }

    public IEnumerator wait()
    {
        waiting = true;
        yield return new WaitForSeconds(gameSpeed);
        waiting = false;
        print("CREATE");
        

        GameObject p;
        p = Instantiate(circle);
       
        p.transform.position = new Vector2(Random.Range(-8, 8), Random.Range(-4, 4));
        p.GetComponent<Animator>().Play("circleAnimation");

    }


    // Update is called once per frame
    void Update () {
        if (gameOver)
        {
            return;
        }

        if (!waiting)
        {
            StartCoroutine(wait());
        }
    }
}
