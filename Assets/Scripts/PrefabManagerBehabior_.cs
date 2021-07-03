using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManagerBehabior_ : MonoBehaviour
{
    public GameObject leftArrowPrefab;
    public Vector3 leftArrowPrefabPosition;

    public GameObject upArrowPrefab;
    public Vector3 upArrowPrefabPosition;

    public GameObject downArrowPrefab;
    public Vector3 downArrowPrefabPosition;

    public GameObject rightArrowPrefab;
    public Vector3 rightArrowPrefabPosition;



    public void InstantiateArrow(string arrow)
    {
        switch (arrow)
        {
            case "left":
                Instantiate(leftArrowPrefab, leftArrowPrefabPosition, Quaternion.identity);
                Debug.Log("Instanciate arrow left");
                break;

            case "up":
                Instantiate(upArrowPrefab, upArrowPrefabPosition, Quaternion.identity);
                Debug.Log("Instanciate arrow up");
                break;

            case "down":
                Instantiate(downArrowPrefab, downArrowPrefabPosition, Quaternion.identity);
                Debug.Log("Instanciate arrow down");
                break;

            case "right":
                Instantiate(rightArrowPrefab, rightArrowPrefabPosition, Quaternion.identity);
                Debug.Log("Instanciate arrow right");
                break;

            default:
                Debug.Log("Case not found");
                break;
        }
    }
}
