using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBase : MonoBehaviour
{

    public Action OnKill;

    public int startlife = 10;

    public bool destroyOnKill = false;
    public float delayToKill = 0f;

    private int _currentlife;
    private bool _isDead = false;

   private FlashColor _flashColor;

    private DeathScreenManager deathScreenManager;



    private void Awake()
    {
        Init();
        if (_flashColor == null)
        {
            _flashColor = GetComponentInChildren<FlashColor>();
        }

        if (CompareTag("Player"))
        {
            deathScreenManager = FindObjectOfType<DeathScreenManager>();
            OnKill += () => deathScreenManager?.ShowDeathScreen();
        }


    }


    private void Init()
    {
        _isDead = false;
        _currentlife = startlife;
    }

    public void Damage(int damage)
    {
        if (_isDead) return;

        _currentlife -= damage;

        if(_currentlife <= 0)
        {
            Kill();
        }

        if(_flashColor != null)
        {
            _flashColor.Flash();
        }
    }

    private void Kill()
    {
        _isDead = true;

        if (destroyOnKill)
        {
            Destroy(gameObject, delayToKill);
        }
        
        if(OnKill != null) OnKill.Invoke();
    }

}
