using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdviceManager : MonoBehaviour
{
    public GameObject textBox;

    public GameObject workerTextImg;

    public GameObject secretaryTextImg;

    public GameObject censorTextImg;

    private string workerText = "";

    private string secretaryText = "";

    private string censorText = "";

    private Text txt;

    public void setWorkerText(string value)
    {
        workerText = value;
    }

    public void setsecretaryText(string value)
    {
        secretaryText = value;
    }

    public void setcensorText(string value)
    {
        censorText = value;
    }

    public void deleteText()
    {
        workerTextImg.SetActive(false);
        secretaryTextImg.SetActive(false);
        censorTextImg.SetActive(false);

        textBox.SetActive(false);
    }

    public void showAdviceWorker()
    {
        textBox.SetActive(true);

        txt = GameObject.Find("AdviceText").GetComponent<Text>();
        txt.text = workerText;

        workerTextImg.SetActive(true);
        secretaryTextImg.SetActive(false);
        censorTextImg.SetActive(false);
    }

    public void showAdviceSecretary()
    {
        textBox.SetActive(true);

        txt = GameObject.Find("AdviceText").GetComponent<Text>();
        txt.text = secretaryText;

        workerTextImg.SetActive(false);
        secretaryTextImg.SetActive(true);
        censorTextImg.SetActive(false);
    }

    public void showAdviceCensor()
    {
        textBox.SetActive(true);

        txt = GameObject.Find("AdviceText").GetComponent<Text>();
        txt.text = censorText;

        workerTextImg.SetActive(false);
        secretaryTextImg.SetActive(false);
        censorTextImg.SetActive(true);
    }
}
