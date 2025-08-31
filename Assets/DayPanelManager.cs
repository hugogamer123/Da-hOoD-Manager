using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
namespace PanelManager
{
    public class DayPanelManager : MonoBehaviour
    {
        private GameObject SelectedPanel;
        private void OnEnable()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
                SelectedPanel.SetActive(false);
        }

        public void EnablePanel()
        {
            SelectedPanel.SetActive(true);
        }
    }    
}
