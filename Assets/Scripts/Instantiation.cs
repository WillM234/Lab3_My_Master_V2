using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiation : MonoBehaviour
{
public GameObject[] BallPrefabs;
public Camera cam;
private GameObject newSpawn;


public List<GameObject> placeList = new List<GameObject>();

private void Update()
{
Vector3 position = cam.ScreenToWorldPoint(Input.mousePosition);
position.z = 0f;
if(position.x > -7 && position.y > -1)
{
if(Input.GetMouseButtonDown(0))
    {
    GameObject newPlat = Instantiate(BallPrefabs[0], position, Quaternion.identity);
    placeList.Add(newPlat);
    
    }
if(Input.GetMouseButtonDown(1))
    {
    GameObject newPlat = Instantiate(BallPrefabs[1], position, transform.rotation);
    placeList.Add(newPlat);
    
    }
if(Input.GetKeyDown(KeyCode.Space))
    {
    GameObject newPlat = Instantiate(BallPrefabs[2], position, Quaternion.identity);
    placeList.Add(newPlat);
   
    }
}
}

public void ButtonClear()
    {
    foreach(GameObject platform in placeList)
        {
        Destroy(platform);
        }
        placeList.Clear();
    }

}