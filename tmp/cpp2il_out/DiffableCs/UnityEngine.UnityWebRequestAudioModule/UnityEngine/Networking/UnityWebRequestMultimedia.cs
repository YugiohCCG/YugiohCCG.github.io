namespace UnityEngine.Networking;

public static class UnityWebRequestMultimedia
{

	[CalledBy(Type = "Manager.Sound+<LoadCustomClip>d__38", Member = "MoveNext", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DownloadHandlerAudioClip), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DownloadHandlerAudioClip), typeof(string), typeof(AudioType)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(UnityWebRequest), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(DownloadHandler), typeof(UploadHandler)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	public static UnityWebRequest GetAudioClip(string uri, AudioType audioType) { }

}

