using System.Collections;
using UnityEngine;

namespace Assets.script
{
    public class PlayerCamera : MonoBehaviour
    {
        public float sensex;
        public float sensey;

        public Transform orientation;

        private float XRotation;
        private float YRotation;

        private void Start()
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        private void Update()
        {
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensex;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensey;

            YRotation += mouseX;
            XRotation -= mouseY;

            XRotation = Mathf.Clamp(XRotation, -90f , 90f);
            transform.rotation = Quaternion.Euler(XRotation, YRotation, 0);
            orientation.rotation = Quaternion.Euler(0,YRotation, 0);
        }
    }
}