using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextWriter : MonoBehaviour
{
    bool writing;
    [SerializeField] string[] textos;
    [SerializeField] float velocidadTexto;
    int counter;
    [SerializeField] Text espacioTexto;
    string currentText;
    // Update is called once per frame
    void Update()
    {

    }
    public void StartText()
    {
        StartCoroutine("text");
    }
    public void NextText()
    {
        if (writing)
        {
            velocidadTexto = 0;
        }
        else
        {
            counter++;
            StartCoroutine("WriteText");
        }
    }
    IEnumerator WriteText()
    {
        writing = true;
        for (int i = 0; i < textos[counter].Length; i++)
        {
            currentText = textos[counter].Substring(0, i);
            espacioTexto.text = currentText;
            if (i + 1 == textos[counter].Length)
            {
                writing = false;
            }
            yield return new WaitForSeconds(velocidadTexto);
        }
    }
}
