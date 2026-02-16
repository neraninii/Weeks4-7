
using UnityEngine;

public class horsiepiemoves : MonoBehaviour
{
    //Initializing Variables
    public float speed = 2;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Tracking the horse's position and adding onto the x posiition for movement
    
        Vector2 newPos = transform.position; 

        newPos.x += speed * Time.deltaTime;  

        transform.position = newPos;

        //Setting bounds for the horse to bounce off and loop
        if(transform.position.x < -3 || transform.position.x > 5)
        {
            speed *= -1;
        }


        
    }
}
