using UnityEngine;
using System.Collections;

//******************************
///<summary>
///キャラクターの状態
///</summary>
//******************************
public enum CharaState
{
    Normal = 0, //<! ノーマル
    Standby,    //<! スタンバイ
    Wait,       //<! ウェイト
}

//***********************************************
/// <summary>
/// キャラクターススプライトの設定を制御する
/// </summary>
//***********************************************
public class CharacterManager : MonoBehaviour
{
    public CharacterSprite[] characterSprite;   ///<オブジェクト保存用配列

    private int charaSpriteLength;              ///<スプライト配列保存用変数

    //************************
    /// <summary>
    /// Awake this instance
    /// </summary>
    //************************
    void Awake()
    {
        //配列の長さを保存
        charaSpriteLength = characterSprite.Length;
    }

    //*********************************************************
    /// <summary>
    /// キャラクタースプライトの状態を設定する
    /// </summary>
    /// <param name="curCharaId">キャラクターのIDを受け取る</param>
    //*********************************************************
    public void SetCharaId(int curCharaId)
    {
        //現在のIdはスタンバイに設定する
        characterSprite[curCharaId].SetFrameState(CharaState.Standby);

        //0から現在の(id-1)までウェイトに設定する
        for (int i = 0; i < curCharaId; i++)
        {
            characterSprite[i].SetFrameState(CharaState.Wait);
        }

        //現在の(Id+1)からキャラ最大数までノーマルに設定する
        for (int i = curCharaId + 1; i < charaSpriteLength; i++)
        {
            characterSprite[i].SetFrameState(CharaState.Normal);
        }
    }
}
