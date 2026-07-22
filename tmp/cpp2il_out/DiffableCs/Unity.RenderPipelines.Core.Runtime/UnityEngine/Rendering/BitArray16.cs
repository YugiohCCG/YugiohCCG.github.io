namespace UnityEngine.Rendering;

[DebuggerDisplay("{this.GetType().Name} {humanizedData}")]
[DefaultMember("Item")]
public struct BitArray16 : IBitArray
{
	[SerializeField]
	private ushort data; //Field offset: 0x0

	public override bool allFalse
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		 get { } //Length: 8
	}

	public override bool allTrue
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 12
	}

	public override uint capacity
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		 get { } //Length: 6
	}

	public override string humanizedData
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
		[CallsUnknownMethods(Count = 1)]
		 get { } //Length: 315
	}

	public override bool Item
	{
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 25
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 25
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public BitArray16(ushort initValue) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"TSource"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.IEnumerable`1<TSource>"}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Enumerable), Member = "ElementAt", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.UInt32>), typeof(int)}, ReturnType = typeof(uint))]
	[ContainsUnimplementedInstructions]
	public BitArray16(IEnumerable<UInt32> bitIndexTrue) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override IBitArray BitAnd(IBitArray other) { }

	[CallerCount(Count = 0)]
	public override IBitArray BitNot() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	public override IBitArray BitOr(IBitArray other) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object obj) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public override bool get_allFalse() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_allTrue() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public override uint get_capacity() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(uint), Member = "ToString", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Convert), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(char)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Regex), Member = "Replace", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "TrimEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 1)]
	public override string get_humanizedData() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override bool get_Item(uint index) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	public static BitArray16 op_BitwiseAnd(BitArray16 a, BitArray16 b) { }

	[CallerCount(Count = 0)]
	public static BitArray16 op_BitwiseOr(BitArray16 a, BitArray16 b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Equality(BitArray16 a, BitArray16 b) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static bool op_Inequality(BitArray16 a, BitArray16 b) { }

	[CallerCount(Count = 0)]
	public static BitArray16 op_OnesComplement(BitArray16 a) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	public override void set_Item(uint index, bool value) { }

}

