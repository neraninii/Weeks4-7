

using UnityEngine;

public class horsiepiemoves : MonoBehaviour
{
    public float speed = 2;
    public AnimationCurve curve;
    public float t = 0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        // t += Time.deltaTime;

        //if (t > 1)
        //{
            //t = 0f;
        //}

        Vector2 newPos = transform.position; 

        newPos.x += speed * Time.deltaTime; //curve.Evaluate(t); 

        transform.position = newPos;

        if(newPos.x < -3 || newPos.x > 5)
        {
            speed = speed * -1;
        }


        
    }
}
