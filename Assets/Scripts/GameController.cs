using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Button buttonObject;
    private bool switch1;
    private float periodsecond = 1.0f;

    private void Start()
    {
        switch1 = true;
    }

    private IEnumerator Routine()
    {
        if(switch1)
        {
            //UnityEngine.Debug.Log("Yes!");
            SetColor(Color.red);
            switch1 = false;
        }
        else
        {
            //UnityEngine.Debug.Log("No!");
            SetColor(Color.blue);
            switch1 = true;
        }

        yield return new WaitForSeconds(periodsecond);
        StartCoroutine("Routine");
    }

    private void SetColor(Color newColor)
    {
        ColorBlock colorBlock = buttonObject.colors;
        colorBlock.normalColor = newColor;
        buttonObject.colors = colorBlock;
    }

    public void Play()
    {
        StartCoroutine("Routine");
    }

    public void Stop()
    {
        StopCoroutine("Routine");
    }
}
