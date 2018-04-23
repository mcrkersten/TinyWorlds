using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {

    public GameObject selected;

    [Header("Materials")]
    public Material enemySelected;
    public Material ownSelected;
    public Material nonSelected;

    [Header("playerIslands")]
    public GameObject[] islandsP1;
    public GameObject[] islandsP2;

    public bool turn;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
    {
        setColor();
        selectIsland();
        buttonPress();
	}

    void setColor()
    {
        for (int i = 0; i < islandsP1.Length; i++)
        {
            islandsP1[i].GetComponent<Renderer>().material = nonSelected;
        }
        for (int i = 0; i < islandsP2.Length; i++)
        {
            islandsP2[i].GetComponent<Renderer>().material = nonSelected;
        }
    }

    void buttonPress()
    {
        if (Input.GetKeyDown("w"))
        {
            if(turn == true)
            {
                for (int i = 0; i < islandsP1.Length; i++)
                {
                    if (selected == islandsP1[i])
                    {
                        islandsP1[i].GetComponent<Island>().health += 1;
                    }
                    else
                    {
                        islandsP2[i].GetComponent<Island>().health -= 1;
                    }
                }
            }
            else
            {
                for (int i = 0; i < islandsP2.Length; i++)
                {
                    if (selected == islandsP2[i])
                    {
                        islandsP2[i].GetComponent<Island>().health += 1;
                    }
                    else
                    {
                        islandsP1[i].GetComponent<Island>().health -= 1;
                    }
                }
            }
            selected = null;
        }
    }

    void selectIsland()
    {
        if (selected == null)
        {
            return;
        }
        else
        {
            if (turn == true)
            {
                for (int i = 0; i < islandsP1.Length; i++)
                {
                    if (selected == islandsP1[i])
                    {
                        islandsP1[i].GetComponent<Renderer>().material = ownSelected;
                    }
                    if (selected == islandsP2[i])
                    {
                        islandsP2[i].GetComponent<Renderer>().material = enemySelected;
                    }
                }
            }
            else
            {
                for (int i = 0; i < islandsP2.Length; i++)
                {
                    if (selected == islandsP2[i])
                    {
                        islandsP2[i].GetComponent<Renderer>().material = ownSelected;
                    }
                    if (selected == islandsP1[i])
                    {
                        islandsP1[i].GetComponent<Renderer>().material = enemySelected;
                    }
                }
            }
        }
    }
}
