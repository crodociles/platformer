using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ledgeButtonPress : MonoBehaviour {

    public Transform ledgeTarget;
    public Sprite button_pressed;
    public Sprite button_unpressed;
    public Vector3 outPosition = new Vector3(14, 0, 0);
    public Vector3 inPosition = new Vector3(15, 0, 0);

    void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<SpriteRenderer>().sprite = button_pressed;
        ledgeTarget.GetComponent<SpriteRenderer>().transform.position = outPosition;
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        this.GetComponent<SpriteRenderer>().sprite = button_unpressed;
        ledgeTarget.GetComponent<SpriteRenderer>().transform.position = inPosition;
    }
}
