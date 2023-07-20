using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineup : MonoBehaviour
{
    public GameObject mainRigPrefab;

    public void StartLineUp()
    {
        int count = 0;
        var prefabgeoObj = mainRigPrefab.transform.GetChild(0);
        // hardcode along the x axis of 1.9
        while (count < prefabgeoObj.transform.childCount)
        {
            var myObj = Instantiate(mainRigPrefab, new Vector3(count * 1.9f, 0), Quaternion.identity);
            myObj.SetActive(true);
            var geoObj = myObj.transform.GetChild(0);
            var actualMesh = geoObj.transform.GetChild(count);
            Debug.Log(actualMesh);
            actualMesh.gameObject.SetActive(true);
            count++;
        }
    }
}
