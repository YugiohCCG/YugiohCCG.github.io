namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
public struct Scene
{
	[HideInInspector]
	[SerializeField]
	private int m_Handle; //Field offset: 0x0

	internal string guid
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Scene), Member = "GetGUIDInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
		internal get { } //Length: 11
	}

	public int handle
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Scene), Member = "GetGUIDInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	internal string get_guid() { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public int get_handle() { }

	[CalledBy(Type = typeof(Scene), Member = "get_guid", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static string GetGUIDInternal(int sceneHandle) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private static void GetGUIDInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public virtual int GetHashCode() { }

}

