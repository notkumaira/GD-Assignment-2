using UnityEngine;

public class DestroyBubble : MonoBehaviour
{
    void Start()
    {
        Destroy(gameObject, 5f);
    }
}