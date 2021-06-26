using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArrowBehavior : MonoBehaviour
{
    public float arrowVelocity = 5.0f;

    private Transform _arrowPosition;

    void Start()
    {
        _arrowPosition = gameObject.GetComponent<Transform>();
    }

    private void FixedUpdate()
    {
        transform.Translate(Vector2.up * arrowVelocity * Time.deltaTime);
        Debug.Log(Vector2.up * arrowVelocity*Time.deltaTime);
    }
}
