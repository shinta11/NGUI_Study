using UnityEngine;
using System.Collections;

//**********************************************
/// <summary>
/// 入力情報を表示するクラス
/// </summary>
//**********************************************
public class InformationDisplay : MonoBehaviour
{
    private int languagesLength;                ///< 言語オブジェクトの要素数を保存

    public UILabel nameLabel;                   ///< オブジェクトを保存(Nameラベル)
    public UIToggle manToggle;                  ///< オブジェクトを保存(Manトグル)
    public IntrestLanguage[] intrectLanguage;   ///< オブジェクトを保存(言語チェックボックス)

    //********************************************
    /// <summary>
    /// 言語オブジェクトの要素数を保存する
    /// </summary>
    //********************************************
    void Awake()
    {
        languagesLength = intrectLanguage.Length;
    }

    //************************
    /// <summary>
    /// 情報表示をする
    /// </summary>
    //************************
    public void Display()
    {
        nameDisp();
        sexualityDisp();
        languageIntrestDisp();
    }

    //*****************************
    /// <summary>
    /// 名前表示をするメソッド
    /// </summary>
    //*****************************
    private void nameDisp()
    {
        //Name表示
        Debug.Log("Name : " + nameLabel.text);
    }

    //*****************************
    /// <summary>
    /// 性別表示をするメソッド
    /// </summary>
    //*****************************
    private void sexualityDisp()
    {
        UIToggle g = UIToggle.GetActiveToggle(manToggle.group);
        Debug.Log("性別 : " +  g.name);

        //男性か女性を表示
        /*if (manToggle.value)
        {
            Debug.Log("男性");
        }
        else
        {
            Debug.Log("女性");
        }*/
    }


    //**********************************
    /// <summary>
    /// 興味のある言語を表示するメソッド
    /// </summary>
    //**********************************
    private void languageIntrestDisp()
    {
        for (int i = 0; i < languagesLength; i++)
        {
            if (intrectLanguage[i].toggle.value)
            {
                Debug.Log("興味のある言語 : " + intrectLanguage[i].label.text);
            }
        }
    }
}
