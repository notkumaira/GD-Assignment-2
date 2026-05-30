using UnityEngine;

public class DestroyBubble : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 3f);
    }
}