using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTargetBehabior : MonoBehaviour
{

    public float excellentPress; //3.41 - 3.49  //--> 3.45
    public float okPress; //2.55 - 3.4
    public float goodPress;//3.5 -- 3.6
    public float badPress;//

    ScoreBehabior scoreText;

    private void Awake()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<ScoreBehabior>();
    }

    private void Update()
    {
        var positionY = this.transform.position.y;

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("LeftArrow pressed!!!");
            checkPositionY(positionY);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) )
        {
            Debug.Log("RightArrow pressed!!!");
            checkPositionY(positionY);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("UpArrow pressed!!!");
            checkPositionY(positionY);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow) )
        {
            Debug.Log("DownArrow pressed!!!");
            checkPositionY(positionY);
        }

    }

    public void checkPositionY( float positionY)
    {

        if ( (positionY < excellentPress + 0.04) && (positionY > excellentPress - 0.04))
        {
            scoreText.ExcellentPressExecution();
        }
        if ( (positionY < okPress) && (positionY > excellentPress - 1))
        {
            scoreText.OkPressExecution();
        }
        if ( (positionY > goodPress) && (positionY < excellentPress + 1))
        {
            scoreText.GoodPressExecution();
        }
        if ((positionY > badPress))
        {
            scoreText.BadPressExecution();
        }

    }

    

}
