using System;
using UnityEngine;

namespace ObserverDesignPattern.Concretes
{
    public class PlayerObserver : MonoBehaviour
    {
        [SerializeField] private int scorePoint;
        public static System.Action<int> OnPlayerCollect;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Object"))
            {
                scorePoint += 2;
                Destroy(other.gameObject);
                OnPlayerCollect?.Invoke(scorePoint);
            }
        }
    }
}