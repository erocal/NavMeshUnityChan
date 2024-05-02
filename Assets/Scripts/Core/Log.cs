using System;

public static class Log
{
    public static void Trace(string msg)
    {
#if UNITY_EDITOR
        UnityEngine.Debug.Log(msg);
#endif
    }

    public static void Debug(string msg)
    {
#if UNITY_EDITOR
        UnityEngine.Debug.Log(msg);
#endif
    }

    public static void Info(string msg)
    {
#if UNITY_EDITOR
        UnityEngine.Debug.Log(msg);
        #endif
    }

    public static void Warning(string msg)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogWarning(msg);
        #endif
    }

    public static void Error(string msg)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogError(msg);
        #endif
    }

    public static void Error(Exception e)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogException(e);
        #endif
    }

    public static void Trace(string message, params object[] args)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogFormat(message, args);
        #endif
    }

    public static void Warning(string message, params object[] args)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogWarningFormat(message, args);
        #endif
    }

    public static void Info(string message, params object[] args)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogFormat(message, args);
        #endif
    }

    public static void Debug(string message, params object[] args)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogFormat(message, args);
        #endif
    }

    public static void Error(string message, params object[] args)
    {
        #if UNITY_EDITOR
        UnityEngine.Debug.LogErrorFormat(message, args);
        #endif
    }

}