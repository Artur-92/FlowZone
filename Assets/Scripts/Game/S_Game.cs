using System;
using UnityEngine;

public class S_Game : MonoBehaviour
{
    #region References
    private S_Score score;
    private S_Player player;
    private S_ModuleSpawner spawner;
    private S_GameUI gameUI;
    private S_IngamePlayerUI ingameUI;
    #endregion
    
    public static Action<float> PassScore;
    
    private void Awake()
    {
        score = FindFirstObjectByType<S_Score>();
        player = FindFirstObjectByType<S_Player>();
        spawner = FindFirstObjectByType<S_ModuleSpawner>();
        gameUI = FindFirstObjectByType<S_GameUI>();
        ingameUI = FindFirstObjectByType<S_IngamePlayerUI>();
        
        Cursor.visible = false;

        AwakeDebug();
        
        S_Interactable.AddMultiplier += score.AddMultiplier;
        S_Interactable.AddMultiplierPoint += score.AddMultiplierPoint;
        
        S_Score.ChangeStage += ChangeState;
        
        S_Player.OnPlayerDeath += OnPlayerDeath;
        S_Player.AddScore += score.AddScore;
        S_Player.JumpPickupCollected += ingameUI.ShowJumpPickup;
        S_Player.SlowPickupCollected += ingameUI.ShowSlowPickup;
        S_Player.ResetMultiplier += score.ResetMultiplier;
        S_Player.AddMultiplier += score.AddMultiplier;
        
        PassScore += gameUI.getEndScore;
    }
    
    private void OnDisable()
    {
        S_Interactable.AddMultiplier -= score.AddMultiplier;
        S_Interactable.AddMultiplierPoint -= score.AddMultiplierPoint;
            
        S_Score.ChangeStage -= ChangeState;
        
        S_Player.OnPlayerDeath -= OnPlayerDeath;
        S_Player.AddScore -= score.AddScore;
        S_Player.JumpPickupCollected -= ingameUI.ShowJumpPickup;
        S_Player.SlowPickupCollected -= ingameUI.ShowSlowPickup;
        S_Player.ResetMultiplier -= score.ResetMultiplier;
        S_Player.AddMultiplier -= score.AddMultiplier;
        
        PassScore -= gameUI.getEndScore;
    }

    void OnPlayerDeath()
    {
        gameUI.showGameOverWindow();
        SetScore();
        score.StopScore();
        
        Cursor.visible = true;
    }

    private void SetScore()
    {
        PassScore?.Invoke(score.CurrentScore);
    }
    
    private void ChangeState(int stage)
    {
        spawner.LoadStage(stage);
    }

    void AwakeDebug()
    {
        Debug.Assert(score, "SCORE NOT ASSIGNED TO GAME");
        Debug.Assert(player, "PLAYER NOT ASSIGNED TO GAME");
        Debug.Assert(spawner, "SPAWNER NOT ASSIGNED TO GAME");
        Debug.Assert(gameUI, "UIMANAGER NOT ASSIGNED TO GAME");
        Debug.Assert(ingameUI, "INGAMEUI NOT ASSIGNED TO GAME");
    }
}