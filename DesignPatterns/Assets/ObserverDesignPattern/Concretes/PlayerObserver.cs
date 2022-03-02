using System;
using UnityEngine;

namespace ObserverDesignPattern.Concretes
{
    public class PlayerObserver : MonoBehaviour
    {
        [SerializeField] private int scorePoint;

        public static System.Action<int> OnPlayerCollect;
        public static System.Action OnPlayerInteractDoor;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Object"))
            {
                scorePoint += 2;
                Destroy(other.gameObject);
                OnPlayerCollect?.Invoke(scorePoint);
            }
        }

        private void OnCollisionStay(Collision collision)
        {

            if (collision.gameObject.CompareTag("Door") && Input.GetKeyDown(KeyCode.E))
            {
                collision.gameObject.transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime * 50);
                OnPlayerInteractDoor?.Invoke();
            }
        }
    }
}