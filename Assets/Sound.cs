using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    // �Ԃ��������̉�
    public AudioClip se;
    // AudioClip�Đ��p
    public AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        // AudioSource�R���|�[�l���g�擾
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // �Ԃ��������ɉ���炷
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "CubeTag")
        {
            audio.PlayOneShot(se);
        }
        if (col.gameObject.tag == "groundTag")
        {
            audio.PlayOneShot(se);
        }

    }
}
