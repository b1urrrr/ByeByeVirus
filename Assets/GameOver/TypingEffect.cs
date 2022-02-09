using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TypingEffect : MonoBehaviour
{
    public Text tx;
    private string m_text = "지토는(은) 지구침략에 실패했습니다.";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(typing_());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

IEnumerator typing_()
    {
        //yield return new WaitForSeconds(2f);
        for(int i = 0; i <= m_text.Length; i++)
        {
            tx.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.15f);
        }
    }
}
