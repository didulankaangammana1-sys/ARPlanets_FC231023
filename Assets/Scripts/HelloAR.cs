
using UnityEngine;

public class HelloAR : MonoBehaviour
{
    public float spinSpeed = 45f;

    void Update()
    {
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f);
    }
}
