namespace UnityEngine.Rendering.Universal;

internal class XRPassUniversal : XRPass
{
	[CompilerGenerated]
	private bool <isLateLatchEnabled>k__BackingField; //Field offset: 0x738
	[CompilerGenerated]
	private bool <canMarkLateLatch>k__BackingField; //Field offset: 0x739
	[CompilerGenerated]
	private bool <hasMarkedLateLatch>k__BackingField; //Field offset: 0x73A
	[CompilerGenerated]
	private bool <canFoveateIntermediatePasses>k__BackingField; //Field offset: 0x73B

	internal bool canFoveateIntermediatePasses
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal bool canMarkLateLatch
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal bool hasMarkedLateLatch
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	internal bool isLateLatchEnabled
	{
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal get { } //Length: 8
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		internal set { } //Length: 7
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = ".ctor", ReturnType = typeof(void))]
	public XRPassUniversal() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(XRPass), Member = "InitBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(XRPassCreateInfo)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public static XRPass Create(XRPassCreateInfo createInfo) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_canFoveateIntermediatePasses() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_canMarkLateLatch() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_hasMarkedLateLatch() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal bool get_isLateLatchEnabled() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual void Release() { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_canFoveateIntermediatePasses(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_canMarkLateLatch(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_hasMarkedLateLatch(bool value) { }

	[CallerCount(Count = 0)]
	[CompilerGenerated]
	internal void set_isLateLatchEnabled(bool value) { }

}

