using UnityEngine;

namespace GeneralScripts.Concretes
{
    public class CharacterMove : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;

        void Update()
        {
            float horizontalMove = Input.GetAxis("Horizontal");
            float verticalMove = Input.GetAxis("Vertical");

            transform.Translate(new Vector3(horizontalMove, 0, verticalMove) * Time.deltaTime * moveSpeed);
        }
    }
}