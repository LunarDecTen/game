using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Dialogue_System : MonoBehaviour
{
    [Header("UI组件")]
    public Text textLabel;
    public Image BackImage;

    [Header("背景")]
    public Sprite train, Yanan;
    
    [Header("文本文件")]
    public TextAsset textfile;
    public int index;

    List<string> textList = new List<string>();
    bool Textfinish;
    public float textSpeed;

    // Start is called before the first frame update
    void Start()
    {
        GetText(textfile);
        textLabel.text = textList[index];
        BackImage.sprite = train;
        Textfinish = true;
    }

    // Update is called once per frame
    void Update()
    {
        DialogueChange();
    }
    void DialogueChange()
    {
        if (Input.GetKeyDown(KeyCode.R) && Textfinish)
        {
            if (index == textList.Count)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                return;
            }
            StartCoroutine(SetTextUI());
        }
    }
    void GetText(TextAsset file)
    {
        textList.Clear();
        index = 0;
        var Data = file.text.Split('\n');
        foreach (var tmp in Data)
        {
            textList.Add(tmp);
        }
    }
    IEnumerator SetTextUI()
    {
        Textfinish = false;
        textLabel.text="";
        switch (textList[index])
        {
            case "C\r":
                BackImage.sprite = Yanan;
                index++;
                break;
            default:
                break;
        }
        for (int i=0;i<textList[index].Length;i++)
        {
            textLabel.text += textList[index][i];
            yield return new WaitForSeconds(textSpeed);
        }
        Textfinish = true;
        index++;
    }
}
