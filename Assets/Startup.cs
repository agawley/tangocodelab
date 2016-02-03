using UnityEngine;
using System.Collections;
using Tango;

public class Startup : MonoBehaviour, ITangoLifecycle {

	private TangoApplication m_tangoApplication;

	public void Start()
	{
		m_tangoApplication = FindObjectOfType<TangoApplication>();
		if (m_tangoApplication != null)
		{
			m_tangoApplication.Register(this);
			m_tangoApplication.RequestPermissions();
		}
	}

	public void OnTangoPermissions(bool permissionsGranted)
	{
		if (permissionsGranted)
			{
				Debug.Log("Permission!");
			}
		else
			{
				// No Area Descriptions available.
				Debug.Log("No area descriptions available.");
			}
	}

	public void OnTangoServiceConnected()
	{
	}

	public void OnTangoServiceDisconnected()
	{
	}
}
