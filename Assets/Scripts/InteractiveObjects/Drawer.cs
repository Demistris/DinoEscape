using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawer : MonoBehaviour
{
    public Equipment eq; // link to eq
    public CollectableObject uv; // linkt to uv light
    public GameObject background;

    // Start is called before the first frame update
    void Start()
    {
        uv.gameObject.SetActive(false); // make uv invisible
    }

    private void OnMouseDown()
    {
        if (eq.items[3] != null && eq.items[3].GetIsSelected())
        {
            background.gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites/Backgrounds/sciana1_zb_biurko_otw"); // load opened drawer sprite
            GetComponent<BoxCollider2D>().enabled = false; // disable drawer box collider
            uv.gameObject.SetActive(true); // make uv visible
            eq.items[3].gameObject.SetActive(false); // delete key from eq
            eq.stuff[3] = false;
            eq.items[3] = null;
        }
    }
}
