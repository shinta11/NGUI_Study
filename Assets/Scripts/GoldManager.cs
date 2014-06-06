using UnityEngine;
using System.Collections;

//*******************************************
/// <summary>
/// ゴールドを管理するクラス
/// </summary>
//*******************************************
public class GoldManager : MonoBehaviour
{
    private const int ANIM_TIME      = 30;              ///<アニメーションタイム
    private const int DISP_MAX_VALUE = 9999999;         ///<描画の最大表示数

    private int curGold;            ///<現在のゴールド値
    private int tgtGold;            ///<ターゲットとなるゴールド値
    private int addGold;            ///<加算されるゴールド値

    public ChangeSprite[] numberSprites;    ///<オブジェクトを保存


    //*************************
    /// <summary>
    /// Awake this instance
    /// </summary>
    //*************************
    void Awake()
    {
        Init();
    }

    //************************
    /// <summary>
    /// 全ての数値を0にする
    /// </summary>
    //************************
    public void Init()
    {
        curGold = 0;
        tgtGold = 0;
        addGold = 0;

        for( int i = 0; i < numberSprites.Length; i++ )
        {
            //描画のゴールド値を0にする
            numberSprites[i].SetSprite(0);
        }
    }

    //********************************************************************
    /// <summary>
    /// ゴールド値を加算するメソッド
    /// </summary>
    /// <param name="value">キャラクターが持ってるゴールド値をもらう</param>
    //********************************************************************
    public void AddGold( int value )
    {
        //ゴールド更新を行う判定
        bool finishAnim = ( curGold == tgtGold );

        //ターゲットとなる値にvalueを加算する
        tgtGold += value;

        //加算する値を設定する
        addGold = ( tgtGold - curGold ) / ANIM_TIME;

        if( finishAnim ) 
        {
            StartCoroutine( updateGold() );
        }
    }

    //**************************************
    /// <summary>
    /// ゴールド値を更新するメソッド
    /// </summary>
    //**************************************
    private IEnumerator updateGold()
    {
        while( true )
        {
            //現在のゴールド値を加算する
            curGold += addGold;

            if( curGold < tgtGold ) 
            {
                drawGold();
            }
            else
            {
                curGold = tgtGold; 
                drawGold();
                break;
            }
            yield return 0;
        }
    }

    //*********************************
    /// <summary>
    /// 現在のゴールド値を描画する
    /// </summary>
    //*********************************
    private void drawGold()
    {
        int num = curGold;

        if( curGold > DISP_MAX_VALUE ) 
        {
            // 描画の最大数を表示する
            num = DISP_MAX_VALUE;
        }

        int digit = 0;

        //最大桁数を保存
        int tmp = numberSprites.Length;

        do
        {
        //ゴールド値を描画情報に反映させる
        numberSprites[digit].SetSprite( num%10 );
        num /= 10;
        digit++;
        }while( digit < tmp && num > 0 );
    }

    //*******************************************
    /// <summary>
    /// 現在のゴールド値を返す
    /// </summary>
    /// <returns>ゴールド値を返す</returns>
    //*******************************************
    public int GetGold() 
    {
        return tgtGold;
    }
}
