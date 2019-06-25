using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CustomScroll : MonoBehaviour
{
    public Scrollbar scroll;
    public int scroll_length;
    private int scroll_dist;
    private float scroll_position;
    private Vector2 self_transform;
    private Vector2 original_position;
    private int window_length;

    // Start is called before the first frame update
    void Start()
    {
        window_length = 52;
        original_position = new Vector2(transform.position.x, transform.position.y);
        self_transform = new Vector2(transform.position.x, transform.position.y);
        scroll_dist = (scroll_length - 3)*window_length;
    }

    // Update is called once per frame
    void Update()
    {
        scroll.value -= Input.mouseScrollDelta.y * (0.2f/scroll_length);
        scroll_position = (scroll.value * scroll_dist);
        self_transform.y = original_position.y + scroll_position;
        transform.position = self_transform;
    }
}
