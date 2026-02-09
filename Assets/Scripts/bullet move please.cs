using UnityEngine;
using UnityEngine.InputSystem;

public class bulletmove : MonoBehaviour
{
    public float speed = 7;
    
    Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        direction = mousePos + transform.position * speed;
    
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position + direction * Time.deltaTime;
        transform.position = newPos;
    
    }
}
