using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTargetBehabior : MonoBehaviour
{
    public Text scoreText;

    public float Points;
    public float excellentPoints = 100;
    public float okPoints = 75;
    public float goodPoints = 50;

    public float excellentPress; //3.41 - 3.49  //--> 3.45
    public float okPress; //2.55 - 3.4
    public float goodPress;//3.5 -- 3.6
    public float badPress;//


    private void Start()
    {
        scoreText.text = "0";
    }

    private void Update()
    {
        var positionY = this.transform.position.y;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (positionY < excellentPress + 0.04) && (positionY > excellentPress - 0.04))
        {
            Debug.Log("Excellent Press!!!");
            Points += excellentPoints;
            scoreText.text = Points.ToString();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (positionY < okPress) && (positionY > excellentPress - 1))
        {
            Debug.Log("Ok Press!!!");
            Points += okPoints;
            scoreText.text = Points.ToString();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (positionY > goodPress) && (positionY < excellentPress + 1))
        {
            Debug.Log("Good Press!!!");
            Points += goodPoints;
            scoreText.text = Points.ToString();
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow) && (positionY > badPress))
        {
            Debug.Log("Bad Press!!!");
        }

    }

}
