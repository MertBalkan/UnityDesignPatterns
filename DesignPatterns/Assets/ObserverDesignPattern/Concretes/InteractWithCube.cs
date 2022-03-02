using System;
using ObserverDesignPattern.Abstracts;
using UnityEngine;

namespace ObserverDesignPattern.Concretes
{
    public class InteractWithCube : MonoBehaviour, IInteract
    {
        private void OnEnable()
        {
            PlayerObserver.OnPlayerCollect += Interact;
        }

        private void OnDisable()
        {
            PlayerObserver.OnPlayerCollect -= Interact;
        }

        public void Interact()
        {
            throw new NotImplementedException();
        }

        public void Interact(int scorePoint)
        {
            //Implement UI
        }
    }
}