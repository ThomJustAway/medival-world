using System.Collections;
using UnityEngine;

namespace Assets.script
{
    public class MoveCamera : MonoBehaviour
    {
        [SerializeField] private Transform m_Camera;

        void Update()
        {
            transform.position = m_Camera.position;
        }
    }
}