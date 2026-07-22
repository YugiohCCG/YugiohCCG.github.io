namespace UnityEngine.UIElements.StyleSheets.Syntax;

internal struct ExpressionMultiplier
{
	public const int Infinity = 100; //Field offset: 0x0
	private ExpressionMultiplierType m_Type; //Field offset: 0x0
	public int min; //Field offset: 0x4
	public int max; //Field offset: 0x8

	public ExpressionMultiplierType type
	{
		[CallerCount(Count = 262)]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ExpressionMultiplier), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
		 set { } //Length: 8
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionMultiplier), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
	public ExpressionMultiplier(ExpressionMultiplierType type = 0) { }

	[CallerCount(Count = 262)]
	[DeduplicatedMethod]
	public ExpressionMultiplierType get_type() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ExpressionMultiplier), Member = "SetType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
	public void set_type(ExpressionMultiplierType value) { }

	[CalledBy(Type = typeof(ExpressionMultiplier), Member = "set_type", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ExpressionMultiplier), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExpressionMultiplierType)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void SetType(ExpressionMultiplierType value) { }

}

