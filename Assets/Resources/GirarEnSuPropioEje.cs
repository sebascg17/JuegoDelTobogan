using UnityEngine;

public class RotarPista : MonoBehaviour
{
    public float velocidad = 10f;

    void Update ()
    {
        transform.Rotate(0, velocidad * Time.deltaTime, 0);
    }
}