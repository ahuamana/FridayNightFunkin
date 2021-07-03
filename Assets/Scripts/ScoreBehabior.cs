using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBehabior : MonoBehaviour
{

    private Text scoreText;
    private float points = 0;

    public float excellentPoints = 100;
    public float okPoints = 75;
    public float goodPoints = 50;

    private void Awake()
    {
        scoreText = this.gameObject.GetComponent<Text>();
        scoreText.text = points.ToString();
    }

    public void ExcellentPressExecution()
    {
        Debug.Log("Excellent Press!!!");
        points += excellentPoints;
        scoreText.text = points.ToString();
    }

    public void OkPressExecution()
    {
        Debug.Log("Ok Press!!!");
        points += okPoints;
        scoreText.text = points.ToString();
    }

    public void GoodPressExecution()
    {
        Debug.Log("Good Press!!!");
        points += goodPoints;
        scoreText.text = points.ToString();
    }

    public void BadPressExecution()
    {
        Debug.Log("Bad Press!!!");
    }
}
