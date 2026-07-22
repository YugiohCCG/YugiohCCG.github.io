namespace Unity.Profiling;

[IsReadOnly]
[UsedByNativeCode]
public struct ProfilerCategory
{
	private readonly ushort m_CategoryId; //Field offset: 0x0

	public string Name
	{
		[CalledBy(Type = typeof(ProfilerCategory), Member = "ToString", ReturnType = typeof(string))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 3)]
		 get { } //Length: 280
	}

	public static ProfilerCategory Scripts
	{
		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	internal ProfilerCategory(ushort category) { }

	[CalledBy(Type = typeof(ProfilerCategory), Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(Byte[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public string get_Name() { }

	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	public static ProfilerCategory get_Scripts() { }

	[CalledBy(Type = "UnityEngine.UIElements.BaseTreeViewController", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public static ushort op_Implicit(ProfilerCategory category) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ProfilerCategory), Member = "get_Name", ReturnType = typeof(string))]
	public virtual string ToString() { }

}

