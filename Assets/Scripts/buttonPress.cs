using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour {

    public Sprite button_pressed;
    public Sprite light_off;
    public Transform light_target;
    public Transform box_target;
    public float massAfter = 0.5f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        this.GetComponent<SpriteRenderer>().sprite = button_pressed;
        light_target.GetComponent<SpriteRenderer>().sprite = light_off;
        box_target.GetComponent<Rigidbody2D>().mass = massAfter;
    }
}
