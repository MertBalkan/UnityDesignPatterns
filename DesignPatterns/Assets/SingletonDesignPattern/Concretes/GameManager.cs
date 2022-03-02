using System;
using SingletonDesignPattern.Abstracts;
using UnityEngine;

namespace SingletonDesignPattern.Concretes
{
    public class GameManager : SingletonMonoBehaviour<GameManager>
    {
        private void Start()
        {
            ApplySingleton(this);
        }
    }
}