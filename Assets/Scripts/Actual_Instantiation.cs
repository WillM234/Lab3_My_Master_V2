using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actual_Instantiation : MonoBehaviour
{
public GameObject BallPrefab;
public float BallYStart;
public float BallXStart;

public List<GameObject> ballList = new List<GameObject>();
    // Start is called before the first frame update
void Start()
    {
        
    }

    // Update is called once per frame
void Update()
    {
        
    }
public void ButtonDrop()
{
    GameObject newBall = Instantiate(BallPrefab, new Vector3(BallXStart, BallYStart, 0f), Quaternion.identity);
    ballList.Add(newBall);
    
}
public void ButtonClear()
{
foreach(GameObject ball in ballList)
    {
    Destroy(ball);
    }
    ballList.Clear();
}
}
