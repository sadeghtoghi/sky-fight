using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    public Vector2 rawValue;
    public float speed=5f;
    [Space(3)]
    Vector2 minBound;
    Vector2 maxBound;
    [Header("Padding")]
    public float LeftPadding = 0;
    public float RightPadding = 0;
    public float TopPadding = 0;
    public float ButtomPaddings = 0;

    private void Start()
    {
        InitBoundry();
    }
    private void InitBoundry()
    {
        Vector2 viewPortMinBound = new Vector2(0,0);
        Vector2 viewPortMaxBound = new Vector2(1,1);

        minBound = Camera.main.ViewportToWorldPoint(viewPortMinBound);
        maxBound= Camera.main.ViewportToWorldPoint(viewPortMaxBound);

        //Debug.Log($"min point=[{minpoint} : max point [{maxpoint}]");
    }

    void Move()
    {
        Vector3 delta = Time.deltaTime * speed * rawValue;
        float clapedX=Mathf.Clamp(transform.position.x+ delta.x, minBound.x+LeftPadding, maxBound.x-RightPadding);
        float clapedY=Mathf.Clamp(transform.position.y+ delta.y, minBound.y+ButtomPaddings, maxBound.y-TopPadding);
        transform.position =new Vector3(clapedX,clapedY,transform.position.z);
    }
    void OnMove(InputValue value)
    {
        rawValue=value.Get<Vector2>();
        Debug.Log($"input is :{rawValue}");
    }

    private void Update()
    {
        Move();
    }
}
