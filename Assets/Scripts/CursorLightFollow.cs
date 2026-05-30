using UnityEngine;
using UnityEngine.InputSystem;

public class CursorLightFollow : MonoBehaviour
{
    void Update()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();

        mousePos.z = Mathf.Abs(Camera.main.transform.position.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        transform.position = new Vector3(worldPos.x, worldPos.y, 0f);
    }
}