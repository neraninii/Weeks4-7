
using UnityEngine;
using UnityEngine.InputSystem;

public class treatmovement : MonoBehaviour
{
    //Initializing Variables
    public float rotationSpeed = 10;
    public bool drop = false;

    public treatspawner treatspawner;

    public float t = 0;

    SpriteRenderer sr; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        //Tracking the treat's position and adding onto the y posiition for movement

        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += rotationSpeed * Time.deltaTime; 
        transform.eulerAngles = newRotation; 

        //setting drop boolean as for keyboard press
        if(Keyboard.current.anyKey.isPressed == true)
        {
            drop = true; 

        }

        //Tracking the treat's position and adding onto the y posiition for movement
        if (drop == true)
        {
            Vector2 newPosition = transform.position; 
            newPosition.y -= 20 * Time.deltaTime;
            transform.position = newPosition;

        }


    }
    
    //Function to change the size of the treats
    public void BigTreat(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
            

}
