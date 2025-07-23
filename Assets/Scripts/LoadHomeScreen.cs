using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadHomeScreen : MonoBehaviour
{
    public GameObject fadeIn;

    // Start is called before the first frame update
    void Start()
    {
        fadeIn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            //Destroy(RoomManager.Instance.gameObject);
            fadeIn.SetActive(true);

            StartCoroutine(DelayLoadLevel());
        }

        //implement skip feature only accesible if the cutscene hasnt ended. if ended, directly load the level
    }

    private IEnumerator DelayLoadLevel()
    {
        yield return new WaitForSeconds(1.6f);
        SceneManager.LoadScene(2);
    }
}
