using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    // ぶつかった時の音
    public AudioClip se;
    // AudioClip再生用
    public AudioSource audio;


    // Start is called before the first frame update
    void Start()
    {
        // AudioSourceコンポーネント取得
        audio = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // ぶつかった時に音を鳴らす
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
