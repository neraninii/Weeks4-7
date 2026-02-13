

using UnityEngine;

public class horsiepiemoves : MonoBehaviour
{
    public float speed = 2;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        Vector2 newPos = transform.position; 

        newPos.x += speed * Time.deltaTime;  

        transform.position = newPos;


        if(transform.position.x < -3 || transform.position.x > 5)
        {
            speed *= -1;
        }


        
    }
}
