using UnityEngine;

public class VirtualJoystick : MonoBehaviour
{
    public RectTransform joystickArea;
    private Vector2 joystickPosition;
    private Vector2 inputVector;
    private bool joystickActive;

    void Update()
    {
        if (joystickActive)
        {
            MoveJoystick();
        }
    }

    public void OnPointerDown(Vector2 pointerPosition)
    {
        joystickActive = true;
        joystickPosition = pointerPosition;
    }

    public void OnPointerUp()
    {
        joystickActive = false;
        inputVector = Vector2.zero;
        ResetJoystick();
    }

    private void MoveJoystick()
    {
        Vector2 offset = joystickPosition - (Vector2)joystickArea.position;
        inputVector = offset.normalized;
    }

    private void ResetJoystick()
    {
        // Reset joystick visual position
    }

    public Vector2 GetInputVector()
    {
        return inputVector;
    }
}