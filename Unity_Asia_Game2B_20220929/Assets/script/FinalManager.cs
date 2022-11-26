using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;



namespace MyNamespace 
{


    /// <summary>
    /// �����޲z��
    /// </summary>
    public class FinalManager : MonoBehaviour
    {

        public static FinalManager instance;

        private CanvasGroup groupFinal;

        private TextMeshProUGUI texttitle;

        private Button btnReplay;

        private void Awake()
        {
            instance = this;

            groupFinal = GameObject.Find("�����e��").GetComponent<CanvasGroup>();
            texttitle = GameObject.Find("�������D").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }


        /// <summary>
        /// �C������
        /// </summary>
        /// <param name="title"></param>
        public void GameOver(string title) 
        {
            texttitle.text = title;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// �H�J
        /// </summary>
        private IEnumerator FadeIn() 
        {
            for (int i =0; i<10;i++)
            {
                groupFinal.alpha += 0.1f;

                yield return new WaitForSeconds(0.02f);

            }

            groupFinal.interactable = true;
            groupFinal.blocksRaycasts = true;

        }

        private void Replay() 
        {
            SceneManager.LoadScene("�C���}�Y");
        }
    }
}
