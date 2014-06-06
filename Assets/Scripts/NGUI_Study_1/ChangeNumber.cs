using UnityEngine;
using System.Collections;

//**************************************
/// <summary>
/// ラベルナンバーを変えるクラス
/// </summary>
//**************************************
public class ChangeNumber : MonoBehaviour
{
    private const int MAX_NUMBER = 10;  ///<Stageナンバー最大数
    private const int MIN_NUMBER = 0;   ///<Stageナンバー最小数

    private int curNum;                 ///<現在のTextのナンバー

    public UILabel label;               ///<オブジェクト取得    (Numberラベル)
    public ChangeActive upButton;       ///<オブジェクト取得    (Upボタン)
    public ChangeActive downButton;     ///<オブジェクト取得    (Dowmボタン)


    //********************
    /// <summary>
    /// numを０にする
    /// </summary>
    //********************
    void Awake()
    {
        curNum = 0;
    }

    //*****************************************
    /// <summary>
    /// 現在のTextナンバーが最小数かチェックする
    /// </summary>
    //*****************************************
    void Start()
    {
        if (curNum == MIN_NUMBER)
        {
            downButton.SetActive(false);
        }
    }

    //*******************************
    /// <summary>
    /// UPボタンが押されたときの処理
    /// </summary>
    //*******************************
    public void Up()
    {
        curNum++;
        if (curNum < MAX_NUMBER)
        {
            label.text =curNum.ToString();
            upButton.SetActive(true);
        }
        else
        {
            curNum = MAX_NUMBER;
            label.text = curNum.ToString();
            upButton.SetActive(false);
        }
        downButton.SetActive(true);
    }

    //*********************************
    /// <summary>
    /// Downボタンが押されたときの処理
    /// </summary>
    //*********************************
    public void Down()
    {
        curNum--;
        if (curNum > MIN_NUMBER)
        {
            label.text = curNum.ToString();
            downButton.SetActive(true);
        }
        else
        {
            curNum = MIN_NUMBER;
            label.text = curNum.ToString();
            downButton.SetActive(false);
        }
        upButton.SetActive(true);
    }
}
