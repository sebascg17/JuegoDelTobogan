using UnityEngine;

public class BallTransform : MonoBehaviour
{
    public Vector3 scaleChange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale += scaleChange;
    }
}
