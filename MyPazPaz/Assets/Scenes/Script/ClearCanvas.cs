using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearCanvas : MonoBehaviour
{

    public GameObject panel; //�p�l�������߂�

    public Text clearText; //�e�L�X�g�����߂�
    




    // Start is called before the first frame update
    void Start()
    {
        //�Q�[�����n�܂�����B��
        panel.SetActive(false);
    }

    void OnEnter()
    {
        //�v���C���[���烁�b�Z�[�W�������Ă�����\��
        panel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
