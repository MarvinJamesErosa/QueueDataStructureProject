using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


public class Try : MonoBehaviour
{
    public GameObject[] prefabs;
    public Transform[] locations;
    public GameObject[] clones;




    public UnityEvent buttonClick;

    void Awake()
    {
        if (buttonClick == null) { buttonClick = new UnityEvent(); }
    }

    public void OnClick()
    {
        buttonClick.Invoke();
        //GameObject person = Instantiate(prefab, transform.position, Quaternion.identity);
        //person.transform.position += Vector3.up * Random.Range(minHeight, maxHeight);
        //for (int i = 0; i<1; i++)
        //{
        //    Instantiate(prefab, new Vector3(transform.position.x * i, transform.position.y, transform.position.z), Quaternion.identity);
        //}
        //Instantiate(prefabs, transform.position, transform.rotation);

        clones[0] = Instantiate(prefabs[0], locations[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        clones[1] = Instantiate(prefabs[1], locations[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        clones[2] = Instantiate(prefabs[2], locations[2].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
    }


}
