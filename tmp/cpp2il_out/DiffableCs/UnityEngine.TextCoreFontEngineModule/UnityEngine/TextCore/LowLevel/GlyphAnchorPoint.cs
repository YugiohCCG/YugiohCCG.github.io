namespace UnityEngine.TextCore.LowLevel;

[UsedByNativeCode]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.TextCoreTextEngineModule"})]
internal struct GlyphAnchorPoint
{
	[NativeName("xPositionAdjustment")]
	[SerializeField]
	private float m_XCoordinate; //Field offset: 0x0
	[NativeName("yPositionAdjustment")]
	[SerializeField]
	private float m_YCoordinate; //Field offset: 0x4

	public float xCoordinate
	{
		[CallerCount(Count = 84)]
		[DeduplicatedMethod]
		 get { } //Length: 7
		[CallerCount(Count = 22)]
		[DeduplicatedMethod]
		 set { } //Length: 5
	}

	public float yCoordinate
	{
		[CallerCount(Count = 83)]
		[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
		[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 15)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 742
		[CallerCount(Count = 14)]
		[DeduplicatedMethod]
		 set { } //Length: 6
	}

	[CallerCount(Count = 84)]
	[DeduplicatedMethod]
	public float get_xCoordinate() { }

	[CallerCount(Count = 83)]
	[Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(float), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(string))]
	[Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 15)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public float get_yCoordinate() { }

	[CallerCount(Count = 22)]
	[DeduplicatedMethod]
	public void set_xCoordinate(float value) { }

	[CallerCount(Count = 14)]
	[DeduplicatedMethod]
	public void set_yCoordinate(float value) { }

}

