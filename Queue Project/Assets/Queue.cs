using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Queue : MonoBehaviour
{
    public List<GameObject> person;

    public Queue<GameObject> waitingLine;

    //a queue of game objects called waiting line. This exist so that the "person" can go inside the queue.
    private GameObject temp;

    //variable for storing the game objects in.
    private int random;

    //Create a queue of Game objects called waitingLine.
    //Contains a for each loop for spawning people in random order each time it starts up.

    private void Awake()
    {
        waitingLine = new Queue<GameObject>();

        for (int k = 0; k < 5; k++)
        {
            random = Random.Range(0,person.Count);
            temp = Instantiate(person[random], new Vector3((float)-k / 2, 0, 0), person[random].transform.rotation);
            waitingLine.Enqueue(temp);
        }
    }
}
