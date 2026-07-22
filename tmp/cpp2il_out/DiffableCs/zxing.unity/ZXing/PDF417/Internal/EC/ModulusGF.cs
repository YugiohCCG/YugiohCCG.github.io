namespace ZXing.PDF417.Internal.EC;

internal sealed class ModulusGF
{
	public static ModulusGF PDF417_GF; //Field offset: 0x0
	private readonly Int32[] expTable; //Field offset: 0x10
	private readonly Int32[] logTable; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ModulusPoly <Zero>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ModulusPoly <One>k__BackingField; //Field offset: 0x28
	private readonly int modulus; //Field offset: 0x30

	public private ModulusPoly One
	{
		[CallerCount(Count = 15)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	internal int Size
	{
		[CallerCount(Count = 3)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	public private ModulusPoly Zero
	{
		[CallerCount(Count = 12)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		 get { } //Length: 5
		[CallerCount(Count = 10)]
		[CallsUnknownMethods(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set { } //Length: 13
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ModulusGF), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ModulusGF() { }

	[CalledBy(Type = typeof(ModulusGF), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	[ContainsUnimplementedInstructions]
	public ModulusGF(int modulus, int generator) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal int add(int a, int b) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly[]))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ModulusPoly), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusGF), typeof(Int32[])}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal ModulusPoly buildMonomial(int degree, int coefficient) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal int exp(int a) { }

	[CallerCount(Count = 15)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ModulusPoly get_One() { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	internal int get_Size() { }

	[CallerCount(Count = 12)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	public ModulusPoly get_Zero() { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(Int32[]), typeof(Int32&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CalledBy(Type = typeof(ErrorCorrection), Member = "findErrorLocations", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(Int32[]))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(ArithmeticException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal int inverse(int a) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	internal int log(int a) { }

	[CalledBy(Type = typeof(ErrorCorrection), Member = "runEuclideanAlgorithm", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly), typeof(ModulusPoly), typeof(int)}, ReturnType = typeof(ModulusPoly[]))]
	[CalledBy(Type = typeof(ModulusPoly), Member = "multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ModulusPoly)}, ReturnType = typeof(ModulusPoly))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal int multiply(int a, int b) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_One(ModulusPoly value) { }

	[CallerCount(Count = 10)]
	[CallsUnknownMethods(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	private void set_Zero(ModulusPoly value) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	internal int subtract(int a, int b) { }

}

