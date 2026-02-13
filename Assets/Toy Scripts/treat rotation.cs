
using UnityEngine;

public class treatrotation : MonoBehaviour
{
    public float speed = 10;

    SpriteRenderer sr; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    public void Update()
    {

        Vector3 newRotation = transform.eulerAngles;
        newRotation.z += speed * Time.deltaTime; 
        transform.eulerAngles = newRotation; 
    }
    

    public void BigTreat(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }

}
