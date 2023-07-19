using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoginButtonController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject idText;
    public GameObject pwText;
    void Start() {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void login() {
        bool success = true;

		if (success) {
            SceneManager.LoadScene("CharacterSelect");
        }
		else {
		}
    }
}
