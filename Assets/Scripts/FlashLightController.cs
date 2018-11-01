using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightController : MonoBehaviour {

    // Use this for initialization
    private  Light m_light;
    private MeshRenderer m_mesh;
    private bool CanProccesLight
    {
        get
        {
            return m_mesh != null && m_mesh.enabled;
        }
    }
    
	void Start () {
        m_mesh = GetComponent<MeshRenderer>();
        if (m_mesh)
        {
           m_mesh.enabled = false;
                }
        m_light = GetComponentInChildren<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.L) && CanProccesLight)
        {
          
                if (m_light)
                {
                    m_light.enabled = !m_light.enabled;
                }
            
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            if (m_light)
                m_light.enabled = false;
            if (m_mesh)
            m_mesh.enabled = !m_mesh.enabled;
           
          
        }

    }
}
