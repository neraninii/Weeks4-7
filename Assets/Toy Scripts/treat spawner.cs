using UnityEngine;

public class treatspawner : MonoBehaviour
{

    public GameObject applePrefab;
    public GameObject carrotPrefab;

    SpriteRenderer sr; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AppleSpawn()
    {
        Instantiate(applePrefab, transform.position, transform.rotation);
        
    }

    public void CarrotSpawn()
    {
        Instantiate(carrotPrefab, transform.position, transform.rotation);
    }

    public void BigTreat(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
}
