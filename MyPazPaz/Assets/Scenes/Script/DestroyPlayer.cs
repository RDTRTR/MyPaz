using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour
{
	/// <summary>
	/// �Փ˂�����
	/// </summary>
	/// <param name="collision"></param>
	private void OnCollisionEnter(Collision collision)
	{
		// �Փ˂��������Player�^�O���t���Ă���Ƃ�
		if (collision.gameObject.tag == "Player")
		{
			// �������������1�b��ɍ폜
			Destroy(collision.gameObject, 1.0f);
		}
	}
}