namespace UnityEngine;

public class ResourcesAPI
{
	private static ResourcesAPI s_DefaultAPI; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static ResourcesAPI <overrideAPI>k__BackingField; //Field offset: 0x8

	internal static ResourcesAPI ActiveAPI
	{
		[CalledBy(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[CalledBy(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
		[CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
		[CalledBy(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
		[CalledBy(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(ResourceRequest))]
		[CalledBy(Type = typeof(Resources), Member = "UnloadAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
		[CallerCount(Count = 6)]
		internal get { } //Length: 184
	}

	public static ResourcesAPI overrideAPI
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		 get { } //Length: 79
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static ResourcesAPI() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	protected private ResourcesAPI() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected private override Object[] FindObjectsOfTypeAll(Type systemTypeInstance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesAPIInternal), Member = "FindShaderByName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	protected private override Shader FindShaderByName(string name) { }

	[CalledBy(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CalledBy(Type = typeof(Resources), Member = "FindObjectsOfTypeAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type)}, ReturnType = typeof(Object[]))]
	[CalledBy(Type = typeof(Resources), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	[CalledBy(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(ResourceRequest))]
	[CalledBy(Type = typeof(Resources), Member = "LoadAsync", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(ResourceRequest))]
	[CalledBy(Type = typeof(Resources), Member = "UnloadAsset", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 6)]
	internal static ResourcesAPI get_ActiveAPI() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	public static ResourcesAPI get_overrideAPI() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesAPIInternal), Member = "Load", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(Object))]
	protected private override object Load(string path, Type systemTypeInstance) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ResourcesAPIInternal), Member = "LoadAsyncInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type)}, ReturnType = typeof(ResourceRequest))]
	[CallsUnknownMethods(Count = 3)]
	protected private override ResourceRequest LoadAsync(string path, Type systemTypeInstance) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	protected private override void UnloadAsset(object assetToUnload) { }

}

