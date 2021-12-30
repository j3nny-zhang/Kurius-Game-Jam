using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hoverable : MonoBehaviour
{
    public Button button;
    public Sprite nonHover;
    public Sprite hover;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.GetComponent<Image>().sprite = nonHover;
    }

    void OnMouseOver()
    {
        button.GetComponent<Image>().sprite = hover;
    }

    void OnMouseExit()
    {
        button.GetComponent<Image>().sprite = nonHover;
    }
}
