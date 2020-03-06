using UnityEngine;

public class WalkInCircles : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 1f;

    private void Update()
    {
        transform.position += transform.forward * moveSpeed * Time.deltaTime;
        transform.Rotate(0f, -1f, 0f);
    }
}