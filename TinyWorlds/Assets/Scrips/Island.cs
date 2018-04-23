using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Island : MonoBehaviour
{
    public int health;
    public Manager manager;

    void OnMouseDown()
    {
        manager.selected = this.gameObject;
    }
}
