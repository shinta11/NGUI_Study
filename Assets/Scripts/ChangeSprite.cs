using UnityEngine;
using System.Collections;

//**********************************************
/// <summary>
/// 描画を設定するクラス
/// </summary>
//**********************************************
public class ChangeSprite : MonoBehaviour
{
    public Sprite[] texs;     ///<スプライトナンバーを保存する配列
    public UI2DSprite spr;    ///<スプライトを描画するためのウィジェット


    //**************************************************************
    /// <summary>
    /// 描画を設定する
    /// </summary>
    /// <param name="number">スプライトナンバー</param>
    //**************************************************************
    public void SetSprite( int value )
    {
        //スプライトを設定する
        spr.nextSprite = texs[value];
    }

    //***********************************************
    /// <summary>
    /// 描画のActiveを切り替える
    /// </summary>
    /// <param set="set">描画の状態をsetする</param>
    //***********************************************
    public void SetActiveSprite( bool set )
    {
        spr.gameObject.SetActive(set);
    }
}
