using UnityEditor.SearchService;
using UnityEngine;

public class DestroyOutBound : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;

    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);    
        } else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
