using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogue : MonoBehaviour
{
    
    public Text textComponent;
    public string[] lines;
    private float textSpeed = 0.1f;

    private int index;

    // Start is called before the first frame update
    private void Start()
    {
       
        textComponent.text = string.Empty;
        StartDialogue();
    }

    // Update is called once per frame
    private void Update()
    {

        if (Input.GetKeyDown("space"))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
                
            }
        }
        
    }

    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    private IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
            Debug.Log("ejnbfewfew");
            SceneManager.LoadScene("Main");
        }
    }
}
