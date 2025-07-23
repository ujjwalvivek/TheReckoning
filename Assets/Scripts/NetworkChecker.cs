using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NetworkChecker : MonoBehaviour
{
    public GameObject no;
    public GameObject yes;
    public GameObject fadein;

    // Start is called before the first frame update
    void Start()
    {
        no.SetActive(false);
        yes.SetActive(false);
        Connection();
    }

    // Update is called once per frame
    void Update()
    {
        Connection();
    }

    private void Connection()
    {
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByBuildIndex(0))
        {
            if (!RoomManager.Instance.isConnected)
            {
                no.SetActive(true);
                yes.SetActive(false);
            }

            else
            {
                no.SetActive(false);
                yes.SetActive(true);

                if (Input.GetKeyDown(KeyCode.Return) && yes.activeSelf)
                {
                    fadein.SetActive(true);
                    StartCoroutine(DelayLoadLevel());
                }
            }
        }
    }

    private IEnumerator DelayLoadLevel()
    {
        yield return new WaitForSeconds(1.6f);
        Destroy(RoomManager.Instance.gameObject);
        SceneManager.LoadScene(0);
    }
}
