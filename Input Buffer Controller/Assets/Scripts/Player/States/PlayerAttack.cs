using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : State
{
    Player _player;
    AttackStat _stat;
    public PlayerAttack(Player stateMachine, AttackStat attack) : base(stateMachine)
    {
        _player = (Player)stateMachine;  
        _stat = attack;  
    }
    public override void Enter()
    {
        base.Enter();
        Debug.Log(_stat.name);
    }
    public override void Update()
    {
        base.Update();

        if (_player.HasPressedLight && _stat.ComboLevel <= _player.StatSheet.Light.ComboLevel)
            _player.SetState(new PlayerAttack(_player, _player.StatSheet.Light));
        else if (_player.HasPressedMedium && _stat.ComboLevel < _player.StatSheet.Medium.ComboLevel)
            _player.SetState(new PlayerAttack(_player, _player.StatSheet.Medium));
        else if (_player.HasPressedHeavy && _stat.ComboLevel < _player.StatSheet.Heavy.ComboLevel )
            _player.SetState(new PlayerAttack(_player, _player.StatSheet.Heavy));
    }
    public override void Exit()
    {
        base.Exit();
    }
}
