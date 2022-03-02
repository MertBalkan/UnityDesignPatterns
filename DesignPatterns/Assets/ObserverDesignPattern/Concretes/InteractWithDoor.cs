using System;
using ObserverDesignPattern.Abstracts;
using UnityEngine;

namespace ObserverDesignPattern.Concretes
{
    public class InteractWithDoor : MonoBehaviour, IInteract
    {
        private void OnEnable()
        {
            PlayerObserver.OnPlayerInteractDoor += Interact;
        }

        private void OnDisable()
        {
            PlayerObserver.OnPlayerInteractDoor -= Interact;
        }

        public void Interact()
        {
            Debug.Log("S VE A");
        }

        public void Interact(int scorePoint)
        {
            throw new NotImplementedException();
        }
    }
}