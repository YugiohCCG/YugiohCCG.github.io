namespace UnityEngine;

public struct LazyLoadReference
{
	private const int kInstanceID_None = 0; //Field offset: 0x0
	[SerializeField]
	private int m_InstanceID; //Field offset: 0x0

	public T asset
	{
		[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+AssetEntry", Member = "get_asset", ReturnType = typeof(Object))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "ForceLoadFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 get { } //Length: 193
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "IsPersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[DeduplicatedMethod]
		 set { } //Length: 246
	}

	public bool isSet
	{
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 7
	}

	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+AssetEntry", Member = "get_asset", ReturnType = typeof(Object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "ForceLoadFromInstanceID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Object))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public T get_asset() { }

	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public bool get_isSet() { }

	[CalledBy(Type = "UnityEngine.UIElements.VisualTreeAsset+AssetEntry", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Type), typeof(Object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	public static LazyLoadReference<T> op_Implicit(T asset) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "IsPersistent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "GetInstanceID", ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[DeduplicatedMethod]
	public void set_asset(T value) { }

}

