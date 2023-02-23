using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Mono.Cecil.Cil;

public class GameScript : MonoBehaviour
{
    public List<GameObject> people;
    public List<GameObject> NewPeople;
    public int index = 0;
    public int indexPeps = 0;
    public int indexLoc = 0;
    Vector2 startLoc = new Vector2(1.01f, -0.43f);

    public void Enqueue()
    {
       if (index == 0)
        {
            GameObject newPeople = Instantiate(people[indexPeps], startLoc, Quaternion.identity);
            NewPeople.Add(newPeople);
            indexPeps++;
            index++;
        }
        else if (index > 0)
        {
            Vector2 loc = NewPeople[indexLoc].transform.position;
            GameObject newPeople = Instantiate(people[indexPeps], loc + Vector2.left * 1.8f, Quaternion.identity);
            NewPeople.Add(newPeople);
            indexPeps++;
            indexLoc++;
            index++;
        }
        if (indexPeps == 5)
        {
            indexPeps = 0;
        }
    }
    public void Dequeue()
    {
        if (index > 0)
        {
            for (int i = NewPeople.Count - 1; i > 0; i--)
            {
                NewPeople[i].transform.position = NewPeople[i - 1].transform.position;
            }

            Destroy(NewPeople[0]);
            NewPeople.RemoveAt(0);
            index--;
            if (indexLoc > 0)
            {
                indexLoc--;
            }
        }
       
    }
    public void ResetVal()
    {
        index = 0;
        indexPeps = 0;
        indexLoc = 0;
        startLoc = new Vector2(1.01f, -0.43f);
    }
    public void Clear()
    {
        ResetVal();
        for (int i = 0; i < NewPeople.Count; i++)
        {
            Destroy(NewPeople[i]);
        }
        NewPeople.Clear();
    }
}
