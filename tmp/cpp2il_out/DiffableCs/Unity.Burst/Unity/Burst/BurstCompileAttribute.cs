namespace Unity.Burst;

[AttributeUsage(77)]
[RequireAttributeUsages]
public class BurstCompileAttribute : Attribute
{
	[CompilerGenerated]
	private FloatMode <FloatMode>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private FloatPrecision <FloatPrecision>k__BackingField; //Field offset: 0x14
	internal Nullable<Boolean> _compileSynchronously; //Field offset: 0x18
	internal Nullable<Boolean> _debug; //Field offset: 0x1A
	internal Nullable<Boolean> _disableSafetyChecks; //Field offset: 0x1C
	internal Nullable<Boolean> _disableDirectCall; //Field offset: 0x1E
	[CompilerGenerated]
	private OptimizeFor <OptimizeFor>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private String[] <Options>k__BackingField; //Field offset: 0x28

	public bool CompileSynchronously
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		 get { } //Length: 84
		[CalledBy(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
		[CallerCount(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public bool Debug
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		 get { } //Length: 84
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public bool DisableDirectCall
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		 get { } //Length: 84
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public bool DisableSafetyChecks
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
		 get { } //Length: 84
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		 set { } //Length: 91
	}

	public FloatMode FloatMode
	{
		[CallerCount(Count = 94)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 7)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public FloatPrecision FloatPrecision
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 5)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	public OptimizeFor OptimizeFor
	{
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 4
		[CallerCount(Count = 2)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 set { } //Length: 4
	}

	internal String[] Options
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal BurstCompileAttribute(String[] options) { }

	[CallerCount(Count = 162)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public BurstCompileAttribute() { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public BurstCompileAttribute(FloatPrecision floatPrecision, FloatMode floatMode) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	public bool get_CompileSynchronously() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	public bool get_Debug() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	public bool get_DisableDirectCall() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	public bool get_DisableSafetyChecks() { }

	[CallerCount(Count = 94)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public FloatMode get_FloatMode() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public FloatPrecision get_FloatPrecision() { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public OptimizeFor get_OptimizeFor() { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal String[] get_Options() { }

	[CalledBy(Type = typeof(BurstCompilerOptions), Member = "GetBurstCompileAttribute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MemberInfo)}, ReturnType = typeof(BurstCompileAttribute))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_CompileSynchronously(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_Debug(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_DisableDirectCall(bool value) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public void set_DisableSafetyChecks(bool value) { }

	[CallerCount(Count = 7)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_FloatMode(FloatMode value) { }

	[CallerCount(Count = 5)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_FloatPrecision(FloatPrecision value) { }

	[CallerCount(Count = 2)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public void set_OptimizeFor(OptimizeFor value) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	internal void set_Options(String[] value) { }

}

