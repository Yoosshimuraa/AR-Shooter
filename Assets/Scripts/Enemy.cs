using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private ParticleSystem _deathEffect;

    public event UnityAction<Enemy> Dying;
    public void Die()
    {
        Dying?.Invoke(this);
        Instantiate(_deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
