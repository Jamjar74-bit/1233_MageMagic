using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    private string nextlevel;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Mage")
        {
            //go to next level
            SceneManager.LoadScene(Nextlevel());
        }

        string Nextlevel()
            {
                throw new NotImplementedException();
            }
                 
    }

 
}
