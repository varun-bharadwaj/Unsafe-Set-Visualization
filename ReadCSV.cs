using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System.Globalization;

using UnityEngine;

public class ReadCSV : MonoBehaviour
{
    public Transform point;

    // Start is called before the first frame update
    void Start()
    {
        string filePath = @"C:\Users\epicv\Documents\ISAACS\visualization\output.csv";
            using (StreamReader reader = new StreamReader(File.OpenRead(filePath))) { 
            List<float> x = new List<float>();
            List<float> y = new List<float>();
            List<float> z = new List<float>();
            List<float> value = new List<float>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                x.Add(float.Parse(values[0]));
                y.Add(float.Parse(values[1]));
                z.Add(float.Parse(values[2]));
                Instantiate(point, new Vector3(float.Parse(values[0]), float.Parse(values[1]), float.Parse(values[2])), Quaternion.identity);
                value.Add(float.Parse(values[3]));
            }

            Debug.Log(y.Count);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
