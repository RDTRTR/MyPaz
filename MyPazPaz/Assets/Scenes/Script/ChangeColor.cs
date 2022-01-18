using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    // Unity�G�f�B�^��ŕς������F���w��ł���B
    public Color color;
    public GameObject plane;
    bool changeflag = false;
    public panelsetcolor mycolor = panelsetcolor.White;
    public GameObject playSound; //SE

    //�I�u�W�F�N�g���Փ˂����Ƃ�
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Blue")
        {
            var change = other.gameObject.GetComponent<Renderer>().material;

            plane.gameObject.GetComponent<Renderer>().material = change;

            mycolor = panelsetcolor.Blue;

            playSound.SendMessage("OnStart");

        }

        if (other.gameObject.name == "Red")
        {
            var change = other.gameObject.GetComponent<Renderer>().material;

            plane.gameObject.GetComponent<Renderer>().material = change;

            mycolor = panelsetcolor.Red;

        }
        
        
    }
}