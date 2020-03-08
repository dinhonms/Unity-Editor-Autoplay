﻿using UnityEngine;
using UnityEditor;

[InitializeOnLoad]
public class Autorun
{
    static Autorun()
    {
        foreach (var so in GetAllInstances<ScriptableObject>())
        {
            if (so.name == "EditorSettings")
            {
                var t = (EditorSettings)so;

                if (t.autorun)
                    EditorApplication.isPlaying = true;
                break;
            }
        }
    }

    public static T[] GetAllInstances<T>() where T : ScriptableObject
    {
        string[] guids = AssetDatabase.FindAssets("t:" + typeof(T).Name);  //FindAssets uses tags check documentation for more info
        T[] a = new T[guids.Length];

        for (int i = 0; i < guids.Length; i++)         //probably could get optimized 
        {
            string path = AssetDatabase.GUIDToAssetPath(guids[i]);
            a[i] = AssetDatabase.LoadAssetAtPath<T>(path);
        }

        return a;
    }
}
