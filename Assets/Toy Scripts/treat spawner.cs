using System.Collections.Generic;
using UnityEngine;

public class treatspawner : MonoBehaviour
{

    public GameObject applePrefab;
    public GameObject carrotPrefab;

    public int appleNumber = 0;
    public int carrotNumber = 0;

    public GameObject SpawnedApple;
    public GameObject SpawnedCarrot; 

    public treatmovement treatmovement;

    public List<GameObject> apples;
    public List<GameObject> carrots;

    public Transform horsiepie;

    public float Ct = 0; 
    public float At = 0;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        for(int j = carrots.Count - 1; j >=0; j--)
        {
            float distanceCarrot = Vector2.Distance(carrots[j].transform.position, horsiepie.position);
            Ct += Time.deltaTime;

            if (distanceCarrot < 1.5f)
            {
                Debug.Log("carrot ate" + j);
                GameObject carrot = carrots[j];
                carrots.Remove(carrot);
                Destroy(carrot);
            }

            if (Ct > 5)
            {
                Debug.Log("carrot timed out" + j);
                GameObject carrot = carrots[j];
                carrots.Remove(carrot);
                Destroy(carrot);

                Ct = 0;
            }
        }

         for (int i = apples.Count - 1; i >= 0; i--)
        {
            float distanceApple = Vector2.Distance(apples[i].transform.position, horsiepie.position);
            At += Time.deltaTime;

            if (distanceApple < 2f)
            {
                Debug.Log("apple ate" + i);
                GameObject apple = apples[i];
                apples.Remove(apple);
                Destroy(apple);

            }

            if (At > 5)
            {
                Debug.Log("apple timed out" + i);
                GameObject apple = apples[i];
                apples.Remove(apple);
                Destroy(apple);

                At = 0;
            }
        }

    }

    public void AppleSpawn()
    {
        SpawnedApple = Instantiate(applePrefab, transform.position, transform.rotation);

        treatmovement = SpawnedApple.GetComponent<treatmovement>();

        appleNumber += 1;

        apples.Add(SpawnedApple);
       
    }

    public void CarrotSpawn()
    {
        SpawnedCarrot = Instantiate(carrotPrefab, transform.position, transform.rotation);

        treatmovement = SpawnedCarrot.GetComponent<treatmovement>();

        carrotNumber += 1; 

        carrots.Add(SpawnedCarrot);

    }

    public void BigTreat(float scale)
    {
        transform.localScale = Vector3.one * scale;
    }
}
