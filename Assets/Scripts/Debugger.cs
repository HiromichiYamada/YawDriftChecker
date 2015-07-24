using UnityEngine;
using System.Collections;
using System.IO;
using System;

public class Debugger : MonoBehaviour {

	public GameObject objectTarget;	// CenterEyeAnchor

	FileInfo	fileInfo;
	StreamWriter	writer;

	double accTime;
	double	checkTime;	// cycleTime以下.
	double	cycleTime	= 1.0;	// チェックするタイミング.

	// Use this for initialization
	void Start () {
		fileInfo = new FileInfo (Application.dataPath + "/Log.csv");
		Debug.Log (Application.dataPath + "/Log.csv");
		writer = fileInfo.AppendText ();
		DateTime thisDay = DateTime.Now;
		writer.WriteLine("Start, {0}", thisDay.ToString("G"));

		writer.Flush ();
	}
	
	// Update is called once per frame
	void Update () {
		this.outputLog (Time.deltaTime);
	}

	void outputLog( double deltaTime ) {
		accTime += deltaTime;

		checkTime += deltaTime;
		if (checkTime >= cycleTime) {

			writer.WriteLine("{0:f5}, {1:f5}", accTime, objectTarget.transform.eulerAngles.y);
			writer.Flush ();

			checkTime -= cycleTime;
		}

	}
}
