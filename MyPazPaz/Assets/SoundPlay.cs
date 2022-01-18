using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundPlay : MonoBehaviour
{
    private AudioSource Audio;
    private AudioSource Audio2;


    public AudioClip clear;//AudioSource������
    public AudioClip rotate;
    bool isAudioStart = false; //�ȍĐ��̔���

    // Start is called before the first frame update
    void Start()
    {
        Audio = GetComponent<AudioSource>();//AudioSource�̎擾

        Audio2 = GetComponent<AudioSource>();
    }

    void OnEnter()
    {

        Audio.PlayOneShot(clear);//AudioSource���Đ�
        isAudioStart = true;//�Ȃ̍Đ��𔻒�

        if (!Audio.isPlaying && isAudioStart)
        //�Ȃ��Đ�����Ă��Ȃ��A�����Ȃ̍Đ����J�n����Ă��鎞
        {
            Destroy(gameObject);//�I�u�W�F�N�g������
        }
    }

    void OnStart()
    {
        Audio2.PlayOneShot(rotate);//AudioSource���Đ�
        isAudioStart = true;//�Ȃ̍Đ��𔻒�

        if (!Audio2.isPlaying && isAudioStart)
        //�Ȃ��Đ�����Ă��Ȃ��A�����Ȃ̍Đ����J�n����Ă��鎞
        {
            Destroy(gameObject);//�I�u�W�F�N�g������
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
