using UnityEngine;

class ColorChangable : MonoBehaviour, IColorChangable
{
    public void ChangeColor(Color color)
    {
        // �����ŐF��ς��鏈��������B
        Debug.Log("change color to " + color);
    }
}