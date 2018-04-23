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

    private void Update()
    {
        if(health == 0)
        {
            this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            this.gameObject.GetComponent<Collider>().enabled = false;
        }
    }
}
