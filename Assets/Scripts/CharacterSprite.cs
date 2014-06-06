using UnityEngine;
using System.Collections;

//********************************************
/// <summary>
/// 描画キャラクターを設定するクラス
/// </summary>
//********************************************
public class CharacterSprite : MonoBehaviour
{
    public GameObject turn;             ///<Turnオブジェクト保存用の変数
    public GameObject ok;               ///<Okオブジェクト保存用の変数
    public ChangeSprite frameSprite;    ///<オブジェクト保存用の変数


    //**********************************************************
    /// <summary>
    /// キャラクターのフレームを設定する
    /// </summary>
    /// <param name="state">キャラクターの状態を受け取る</param>
    //**********************************************************
    public void SetFrameState(CharaState state)
    {
        switch (state)
        {
        //ノーマル状態の場合
        case CharaState.Normal: 
            setActiveState(state);
            break;

        //スタンバイ状態の場合
        case CharaState.Standby:
            setActiveState(state);
            break;

        //ウェイト状態の場合
        case CharaState.Wait:
            setActiveState(state);
            break;
        }

        frameSprite.SetSprite((int)state);
    }

    //******************************************************
    /// <summary>
    /// スプライト、「Turn」か「Ok」か切り替える
    /// </summary>
    /// <param name="state">フレームの状態を受け取る</param>
    //******************************************************
    private void setActiveState(CharaState state)
    {
        //スタンバイ状態のとき
        if (state == CharaState.Standby)
        {
            ok.SetActive(true);
            turn.SetActive(false);
        }
        //ノーマルとウェイト状態のとき
        else
        {
            ok.SetActive(false);
            turn.SetActive(true);
        }
    }
}
