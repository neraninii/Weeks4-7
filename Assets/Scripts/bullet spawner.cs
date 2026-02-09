using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     

        if(Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
            mousePos.z = 0; 
            
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
