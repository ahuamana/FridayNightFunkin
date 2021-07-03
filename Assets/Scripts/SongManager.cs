using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongManager : MonoBehaviour
{

    public AudioClip song;
    public PrefabManagerBehabior_ prefabManager;


    void Start()
    {
        StartCoroutine(InstanciateArrows());
    }


    IEnumerator InstanciateArrows()
    {
        yield return new WaitForSeconds(1);
        prefabManager.InstantiateArrow("left");

        yield return new WaitForSeconds(1);
        prefabManager.InstantiateArrow("up");

        yield return new WaitForSeconds(1);
        prefabManager.InstantiateArrow("down");

        yield return new WaitForSeconds(1);
        prefabManager.InstantiateArrow("right");
    }
}
