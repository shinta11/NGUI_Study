using UnityEngine;
using System.Collections;

//*******************************************
/// <summary>
/// ミッション数、フェーズ数を表示する
/// </summary>
//*******************************************
public class MissionNo : MonoBehaviour 
{
    public ChangeSprite[] missionNumberSprites;     ///<ミッションオブジェクトを保存
    public ChangeSprite[] phaseNumberSprites;       ///<フェーズオブジェクトを保存


    //*********************************************************************
    /// <summary>
    /// ミッション数とフェーズ数を設定する
    /// </summary>
    /// <param name="missionId">現在のミッション数</param>
    /// <param name="phaseId">現在のフェーズ数</param>
    //*********************************************************************
    public void SetMissionId( int missionId, int phaseId )
    {
        setMission(missionId);
        setPhase(phaseId);
    }

    //********************************************************************
    /// <summary>
    /// 現在のミッション数を設定する
    /// </summary>
    /// <param name="missionId">現在のミッション数</param>
    //********************************************************************
    private void setMission(int missionId)
    {
        //missionIdが1桁のとき
        if (missionId < 10)
        {
            missionNumberSprites[0].SetSprite(missionId);
            missionNumberSprites[1].SetActiveSprite(false);
        }
        //ミッションが2桁のとき
        else
        {
            missionNumberSprites[0].SetSprite(missionId % 10);
            missionNumberSprites[1].SetActiveSprite(true);
            missionNumberSprites[1].SetSprite(missionId / 10);
        }
    }

    //*******************************************************************
    /// <summary>
    /// 現在のフェーズ数を設定する
    /// </summary>
    /// <param name="phaseId">現在のフェーズ数</param>
    //*******************************************************************
    private void setPhase(int phaseId)
    {
        //フェーズが1桁のとき
        if (phaseId < 10)
        {
            phaseNumberSprites[0].SetActiveSprite(false);
            phaseNumberSprites[1].SetSprite(phaseId);
        }
        //フェーズが2桁のとき
        else
        {
            phaseNumberSprites[0].SetActiveSprite(true);
            phaseNumberSprites[0].SetSprite(phaseId % 10);
            phaseNumberSprites[1].SetSprite(phaseId / 10);
        }
    }
}
