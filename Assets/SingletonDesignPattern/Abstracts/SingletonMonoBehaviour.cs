using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SingletonDesignPattern.Abstracts
{
    public abstract class SingletonMonoBehaviour<T> : MonoBehaviour where T : Component
    {
        protected static T Instance { get; private set; }

        protected void ApplySingleton(T gameObject)
        {
            if (Instance == null)
            {
                Instance = gameObject;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        
    }
}