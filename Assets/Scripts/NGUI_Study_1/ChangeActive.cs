using UnityEngine;
using System.Collections;

//**************************************
/// <summary>
/// オブジェクトの振る舞いを切り替える
/// </summary>
//**************************************
public class ChangeActive : MonoBehaviour
{
    public UIButton button;             ///<オブジェクト取得(ボタン)


    //********************************************************
    ///<summary>
    ///ボタンの状態を切り替える
    ///</summary>
    ///<param name="set">切り替えを行うbool値をもらう</param>
    //********************************************************
    public void SetActive(bool isEnabled)
    {
        button.isEnabled = isEnabled;
    }
}
