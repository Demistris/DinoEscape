using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Safe : MonoBehaviour
{
    public Equipment eq;
    public CollectableObject key;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/safe"); // at the begining safe is closed so load this sprite
    }

    void OnMouseDown()
    {
        if (eq.items[3] != null && eq.items[3].GetIsSelected())
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Interacive/safe-open"); // load opened safe sprite
            key.gameObject.SetActive(true); // show key (activate object)
            eq.items[3].gameObject.SetActive(false); // disable and delete note from equipment
            eq.items[3] = null;
            eq.stuff[3] = false;
        }
    }
}
