namespace System;

[IsReadOnly]
public struct decimal : IFormattable, IComparable, IConvertible, IComparable<Decimal>, IEquatable<Decimal>, IDeserializationCallback, ISpanFormattable
{
	private struct DecCalc
	{
		private struct Buf12
		{
			public uint U0; //Field offset: 0x0
			private ulong ulo64LE; //Field offset: 0x0
			public uint U1; //Field offset: 0x4
			private ulong uhigh64LE; //Field offset: 0x4
			public uint U2; //Field offset: 0x8

			public ulong High64
			{
				[CallerCount(Count = 34)]
				[DeduplicatedMethod]
				 get { } //Length: 7
				[CallerCount(Count = 4)]
				[DeduplicatedMethod]
				 set { } //Length: 5
			}

			public ulong Low64
			{
				[CallerCount(Count = 223)]
				[DeduplicatedMethod]
				 get { } //Length: 6
				[CallerCount(Count = 26)]
				[DeduplicatedMethod]
				 set { } //Length: 4
			}

			[CallerCount(Count = 34)]
			[DeduplicatedMethod]
			public ulong get_High64() { }

			[CallerCount(Count = 223)]
			[DeduplicatedMethod]
			public ulong get_Low64() { }

			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			public void set_High64(ulong value) { }

			[CallerCount(Count = 26)]
			[DeduplicatedMethod]
			public void set_Low64(ulong value) { }

		}

		private struct Buf16
		{
			public uint U0; //Field offset: 0x0
			private ulong ulo64LE; //Field offset: 0x0
			public uint U1; //Field offset: 0x4
			public uint U2; //Field offset: 0x8
			private ulong uhigh64LE; //Field offset: 0x8
			public uint U3; //Field offset: 0xC

			public ulong High64
			{
				[CallerCount(Count = 27)]
				[DeduplicatedMethod]
				 get { } //Length: 7
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				 set { } //Length: 5
			}

			public ulong Low64
			{
				[CallerCount(Count = 223)]
				[DeduplicatedMethod]
				 get { } //Length: 6
				[CallerCount(Count = 26)]
				[DeduplicatedMethod]
				 set { } //Length: 4
			}

			[CallerCount(Count = 27)]
			[DeduplicatedMethod]
			public ulong get_High64() { }

			[CallerCount(Count = 223)]
			[DeduplicatedMethod]
			public ulong get_Low64() { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public void set_High64(ulong value) { }

			[CallerCount(Count = 26)]
			[DeduplicatedMethod]
			public void set_Low64(ulong value) { }

		}

		private struct Buf24
		{
			public uint U0; //Field offset: 0x0
			private ulong ulo64LE; //Field offset: 0x0
			public uint U1; //Field offset: 0x4
			public uint U2; //Field offset: 0x8
			private ulong umid64LE; //Field offset: 0x8
			public uint U3; //Field offset: 0xC
			public uint U4; //Field offset: 0x10
			private ulong uhigh64LE; //Field offset: 0x10
			public uint U5; //Field offset: 0x14

			public ulong High64
			{
				[CallerCount(Count = 2)]
				[DeduplicatedMethod]
				 set { } //Length: 5
			}

			public ulong Low64
			{
				[CallerCount(Count = 223)]
				[DeduplicatedMethod]
				 get { } //Length: 6
				[CallerCount(Count = 26)]
				[DeduplicatedMethod]
				 set { } //Length: 4
			}

			public ulong Mid64
			{
				[CallerCount(Count = 0)]
				[DeduplicatedMethod]
				 set { } //Length: 5
			}

			[CallerCount(Count = 223)]
			[DeduplicatedMethod]
			public ulong get_Low64() { }

			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			public void set_High64(ulong value) { }

			[CallerCount(Count = 26)]
			[DeduplicatedMethod]
			public void set_Low64(ulong value) { }

			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			public void set_Mid64(ulong value) { }

		}

		private struct PowerOvfl
		{
			public readonly uint Hi; //Field offset: 0x0
			public readonly ulong MidLo; //Field offset: 0x8

			[CallerCount(Count = 0)]
			public PowerOvfl(uint hi, uint mid, uint lo) { }

		}

		public enum RoundingMode
		{
			ToEven = 0,
			AwayFromZero = 1,
			Truncate = 2,
			Floor = 3,
			Ceiling = 4,
		}

		private static readonly UInt32[] s_powers10; //Field offset: 0x0
		private static readonly UInt64[] s_ulongPowers10; //Field offset: 0x8
		private static readonly Double[] s_doublePowers10; //Field offset: 0x10
		private static readonly PowerOvfl[] PowerOvflValues; //Field offset: 0x18
		private uint uflags; //Field offset: 0x0
		private uint uhi; //Field offset: 0x4
		private uint ulo; //Field offset: 0x8
		private ulong ulomidLE; //Field offset: 0x8
		private uint umid; //Field offset: 0xC

		private uint High
		{
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			private get { } //Length: 4
			[CallerCount(Count = 9)]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		private bool IsNegative
		{
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			private get { } //Length: 6
		}

		private uint Low
		{
			[CallerCount(Count = 28)]
			[DeduplicatedMethod]
			private get { } //Length: 4
			[CallerCount(Count = 4)]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		private ulong Low64
		{
			[CallerCount(Count = 27)]
			[DeduplicatedMethod]
			private get { } //Length: 7
			[CallerCount(Count = 0)]
			[DeduplicatedMethod]
			private set { } //Length: 5
		}

		private uint Mid
		{
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			private get { } //Length: 4
			[CallerCount(Count = 2)]
			[DeduplicatedMethod]
			private set { } //Length: 4
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		private static DecCalc() { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private static bool Add32To96(ref Buf12 bufNum, uint value) { }

		[CalledBy(Type = typeof(Decimal), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Increment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Addition", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Subtraction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(DecCalc), Member = "ScaleResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf24*), typeof(uint), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal static void DecAddSub(ref DecCalc d1, ref DecCalc d2, bool sign) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		internal static uint DecDivMod1E9(ref DecCalc value) { }

		[CalledBy(Type = typeof(DecCalc), Member = "VarDecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		private static uint Div128By96(ref Buf16 bufNum, ref Buf12 bufDen) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private static uint Div96By32(ref Buf12 bufNum, uint den) { }

		[CalledBy(Type = typeof(DecCalc), Member = "VarDecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[ContainsUnimplementedInstructions]
		private static uint Div96By64(ref Buf12 bufNum, ulong den) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private static bool Div96ByConst(ref ulong high64, ref uint low, uint pow) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private static uint DivByConst(UInt32* result, uint hiRes, out uint quotient, out uint remainder, uint power) { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		private uint get_High() { }

		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		private bool get_IsNegative() { }

		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		private uint get_Low() { }

		[CallerCount(Count = 27)]
		[DeduplicatedMethod]
		private ulong get_Low64() { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private uint get_Mid() { }

		[CallerCount(Count = 0)]
		private static uint GetExponent(double d) { }

		[CallerCount(Count = 0)]
		private static uint GetExponent(float f) { }

		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal static int GetHashCode(in decimal d) { }

		[CallerCount(Count = 0)]
		private static uint IncreaseScale(ref Buf12 bufNum, uint power) { }

		[CallerCount(Count = 0)]
		private static void IncreaseScale64(ref Buf12 bufNum, uint power) { }

		[CalledBy(Type = typeof(DecCalc), Member = "LeadingZeroCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(int), typeof(MidpointRounding)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
		[CallerCount(Count = 6)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal static void InternalRound(ref DecCalc d, uint scale, RoundingMode mode) { }

		[CalledBy(Type = typeof(DecCalc), Member = "ScaleResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf24*), typeof(uint), typeof(int)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(DecCalc), Member = "VarDecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), "System.Decimal+DecCalc+RoundingMode"}, ReturnType = typeof(void))]
		[ContainsUnimplementedInstructions]
		private static int LeadingZeroCount(uint value) { }

		[CalledBy(Type = typeof(DecCalc), Member = "VarDecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		[ContainsUnimplementedInstructions]
		private static int OverflowUnscale(ref Buf12 bufQuo, int scale, bool sticky) { }

		[CalledBy(Type = typeof(DecCalc), Member = "DecAddSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecCalc), Member = "VarDecMul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecCalc), Member = "LeadingZeroCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 5)]
		[ContainsUnimplementedInstructions]
		private static int ScaleResult(Buf24* bufRes, uint hiRes, int scale) { }

		[CalledBy(Type = typeof(DecCalc), Member = "VarDecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		private static int SearchScale(ref Buf12 bufQuo, int scale) { }

		[CallerCount(Count = 9)]
		[DeduplicatedMethod]
		private void set_High(uint value) { }

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		private void set_Low(uint value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private void set_Low64(ulong value) { }

		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		private void set_Mid(uint value) { }

		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		private static ulong UInt32x32To64(uint a, uint b) { }

		[CalledBy(Type = typeof(DecCalc), Member = "VarDecFromR4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DecCalc), Member = "VarDecFromR8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 4)]
		private static void UInt64x64To128(ulong a, ulong b, ref DecCalc result) { }

		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		private static void Unscale(ref uint low, ref ulong high64, ref int scale) { }

		[CalledBy(Type = typeof(Decimal), Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Decimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Decimal), Member = "CompareTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
		[CalledBy(Type = typeof(Decimal), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(Decimal&))]
		[CalledBy(Type = typeof(Decimal), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(Decimal&))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_LessThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_LessThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_GreaterThan", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CalledBy(Type = typeof(Decimal), Member = "op_GreaterThanOrEqual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
		[CallerCount(Count = 13)]
		[Calls(Type = typeof(DecCalc), Member = "VarDecCmpSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
		internal static int VarDecCmp(in decimal d1, in decimal d2) { }

		[CalledBy(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		private static int VarDecCmpSub(in decimal d1, in decimal d2) { }

		[CalledBy(Type = typeof(Decimal), Member = "Divide", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecCalc), Member = "LeadingZeroCount", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DecCalc), Member = "Div128By96", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf16&), typeof(Buf12&)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(DecCalc), Member = "SearchScale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf12&), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DecCalc), Member = "OverflowUnscale", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf12&), typeof(int), typeof(bool)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(DecCalc), Member = "Div96By64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf12&), typeof(ulong)}, ReturnType = typeof(uint))]
		[Calls(Type = typeof(DivideByZeroException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		internal static void VarDecDiv(ref DecCalc d1, ref DecCalc d2) { }

		[CalledBy(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DecCalc), Member = "UInt64x64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal static void VarDecFromR4(float input, out DecCalc result) { }

		[CalledBy(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(DecCalc), Member = "UInt64x64To128", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong), typeof(ulong), typeof(DecCalc&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 6)]
		[ContainsUnimplementedInstructions]
		internal static void VarDecFromR8(double input, out DecCalc result) { }

		[CalledBy(Type = typeof(Decimal), Member = "Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(DecCalc), Member = "ScaleResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Buf24*), typeof(uint), typeof(int)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal static void VarDecMul(ref DecCalc d1, ref DecCalc d2) { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
		[ContainsUnimplementedInstructions]
		internal static float VarR4FromDec(in decimal value) { }

		[CalledBy(Type = typeof(DecCalc), Member = "VarR4FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Decimal), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
		[CalledBy(Type = typeof(Decimal), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
		[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
		[CallerCount(Count = 5)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		internal static double VarR8FromDec(in decimal value) { }

	}

	[DecimalConstant(0, 0, 0, 0, 0)]
	public static readonly decimal Zero; //Field offset: 0x0
	[DecimalConstant(0, 0, 0, 0, 1)]
	public static readonly decimal One; //Field offset: 0x10
	[DecimalConstant(0, 128, 0, 0, 1)]
	public static readonly decimal MinusOne; //Field offset: 0x20
	[DecimalConstant(0, 0, 4294967295, 4294967295, 4294967295)]
	public static readonly decimal MaxValue; //Field offset: 0x30
	[DecimalConstant(0, 128, 4294967295, 4294967295, 4294967295)]
	public static readonly decimal MinValue; //Field offset: 0x40
	private readonly int flags; //Field offset: 0x0
	private readonly int hi; //Field offset: 0x4
	private readonly int lo; //Field offset: 0x8
	private readonly ulong ulomidLE; //Field offset: 0x8
	private readonly int mid; //Field offset: 0xC

	internal uint High
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal bool IsNegative
	{
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		internal get { } //Length: 6
	}

	internal uint Low
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	private ulong Low64
	{
		[CallerCount(Count = 0)]
		private get { } //Length: 57
	}

	internal uint Mid
	{
		[CallerCount(Count = 2)]
		[DeduplicatedMethod]
		internal get { } //Length: 4
	}

	internal int Scale
	{
		[CalledBy(Type = typeof(Number), Member = "DecimalToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		internal get { } //Length: 9
	}

	[CallerCount(Count = 0)]
	private static Decimal() { }

	[CallerCount(Count = 77)]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public Decimal(int lo, int mid, int hi, bool isNegative, byte scale) { }

	[CalledBy(Type = typeof(ResourceReader), Member = "_LoadObjectV1", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = typeof(BinaryReader), Member = "ReadDecimal", ReturnType = typeof(Decimal))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public Decimal(Int32[] bits) { }

	[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "UnityEngine.InputSystem.Utilities.PrimitiveValue", Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecFromR8", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(DecCalc&)}, ReturnType = typeof(void))]
	public Decimal(double value) { }

	[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecFromR4", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(DecCalc&)}, ReturnType = typeof(void))]
	public Decimal(float value) { }

	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedLong", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 3)]
	[CLSCompliant(False)]
	public Decimal(ulong value) { }

	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_long", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDecimal", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = "System.Data.SqlTypes.SqlDecimal")]
	[CalledBy(Type = "System.Data.SqlTypes.SqlMoney", Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = "System.Data.SqlTypes.SqlMoney")]
	[CallerCount(Count = 7)]
	public Decimal(long value) { }

	[CallerCount(Count = 0)]
	private Decimal(in decimal d, int flags) { }

	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedInt", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	public Decimal(uint value) { }

	[CalledBy(Type = "System.Xml.Schema.Datatype_int", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_short", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_byte", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedShort", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedByte", Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.ReadType", typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = "Newtonsoft.Json.Utilities.ParseResult")]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	public Decimal(int value) { }

	[CalledBy(Type = typeof(Math), Member = "Abs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "CompareBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.BigInteger", typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static decimal Abs(ref decimal d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecCalc), Member = "DecAddSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&), typeof(bool)}, ReturnType = typeof(void))]
	public static decimal Add(decimal d1, decimal d2) { }

	[CallerCount(Count = 2063)]
	[DeduplicatedMethod]
	private static DecCalc AsMutable(ref decimal d) { }

	[CalledBy(Type = "System.Data.Common.DecimalStorage", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.Common.DecimalStorage", Member = "CompareValueTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	public static int Compare(decimal d1, decimal d2) { }

	[CalledBy(Type = "System.Xml.Schema.Datatype_decimal", Member = "Compare", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public override int CompareTo(object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "CompareBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.BigInteger", typeof(object)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	public override int CompareTo(decimal value) { }

	[CalledBy(Type = typeof(Number), Member = "DecimalToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	internal static uint DecDivMod1E9(ref decimal value) { }

	[CalledBy(Type = "System.Data.SqlTypes.SqlMoney", Member = "op_Division", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlMoney", "System.Data.SqlTypes.SqlMoney"}, ReturnType = "System.Data.SqlTypes.SqlMoney")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
	public static decimal Divide(decimal d1, decimal d2) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public virtual bool Equals(object value) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.MiscellaneousUtils", Member = "ValueEquals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public override bool Equals(decimal value) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal uint get_High() { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	internal bool get_IsNegative() { }

	[CallerCount(Count = 28)]
	[DeduplicatedMethod]
	internal uint get_Low() { }

	[CallerCount(Count = 0)]
	private ulong get_Low64() { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	internal uint get_Mid() { }

	[CalledBy(Type = typeof(Number), Member = "DecimalToNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(NumberBuffer&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal int get_Scale() { }

	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ConvertTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.ComponentModel.ITypeDescriptorContext", typeof(CultureInfo), typeof(object), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlDecimal", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Numerics.BigInteger", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public static Int32[] GetBits(decimal d) { }

	[CalledBy(Type = "System.Xml.Schema.KeySequence", Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public virtual int GetHashCode() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public override TypeCode GetTypeCode() { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	private static bool IsValid(int flags) { }

	[CalledBy(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlXml", Member = "get_CreateSqlReaderMethodInfo", ReturnType = typeof(MethodInfo))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	internal static decimal Max(ref decimal d1, ref decimal d2) { }

	[CalledBy(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	internal static decimal Min(ref decimal d1, ref decimal d2) { }

	[CalledBy(Type = "System.Data.SqlTypes.SqlMoney", Member = "op_Multiply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.SqlTypes.SqlMoney", "System.Data.SqlTypes.SqlMoney"}, ReturnType = "System.Data.SqlTypes.SqlMoney")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecMul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
	public static decimal Multiply(decimal d1, decimal d2) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static decimal Negate(decimal d) { }

	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "CalculateSequenceRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSequence", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "CalculateEffectiveTotalRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "CalculateEffectiveTotalRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = "Newtonsoft.Json.Utilities.ParseResult")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.UlongPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<UInt64>", "DG.Tweening.Core.DOSetter`1<UInt64>", typeof(float), typeof(ulong), typeof(ulong), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(DecCalc), Member = "DecAddSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&), typeof(bool)}, ReturnType = typeof(void))]
	public static decimal op_Addition(decimal d1, decimal d2) { }

	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = "Newtonsoft.Json.Utilities.ParseResult")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecDiv", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
	public static decimal op_Division(decimal d1, decimal d2) { }

	[CallerCount(Count = 74)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Equality(decimal d1, decimal d2) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.UlongPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<UInt64>", "DG.Tweening.Core.DOSetter`1<UInt64>", typeof(float), typeof(ulong), typeof(ulong), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	public static decimal op_Explicit(float value) { }

	[CalledBy(Type = "SQLite.SQLiteCommand", Member = "ReadCol", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int), "SQLite.SQLite3+ColType", typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "SQLite.FastColumnSetter+<>c__0`1", Member = "<GetFastSetter>b__0_12", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr), typeof(int)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "ConvertDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Checked", Member = "ConvertDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Decimal), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(void))]
	public static decimal op_Explicit(double value) { }

	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	public static int op_Explicit(decimal value) { }

	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "DG.Tweening.Plugins.UlongPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<UInt64>", "DG.Tweening.Core.DOSetter`1<UInt64>", typeof(float), typeof(ulong), typeof(ulong), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	[CLSCompliant(False)]
	public static ulong op_Explicit(decimal value) { }

	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	public static long op_Explicit(decimal value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsLong", ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.XmlSqlBinaryReader", Member = "ValueAsDouble", ReturnType = typeof(double))]
	[CalledBy(Type = "MS.Internal.Xml.XPath.ExtensionQuery", Member = "ProcessResult", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
	public static double op_Explicit(decimal value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static float op_Explicit(decimal value) { }

	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "CalculateEffectiveTotalRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleDataSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", "System.Data.DataTable", typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "IsDatasetParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = "Newtonsoft.Json.Utilities.ParseResult")]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "IsTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "CannonicalizeGroupRef", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaGroupRef", typeof(bool)}, ReturnType = "System.Xml.Schema.XmlSchemaParticle")]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionPreprocessor", Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "CalculateEffectiveTotalRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Preprocessor", Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Preprocessor", Member = "PreprocessLocalElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaInference", Member = "SetMinMaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionPreprocessor", Member = "PreprocessParticle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle"}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Data.XSDSchema", Member = "HandleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement"}, ReturnType = "System.Data.DataTable")]
	[CallerCount(Count = 21)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_GreaterThan(decimal d1, decimal d2) { }

	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	public static bool op_GreaterThanOrEqual(decimal d1, decimal d2) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(sbyte)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	public static decimal op_Implicit(sbyte value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Datatype_unsignedLong", Member = "TryParseValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "System.Xml.XmlNameTable", "System.Xml.IXmlNamespaceResolver", typeof(Object&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), "System.Xml.IXmlNamespaceResolver"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeTypeWildcardDestination", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Type), "System.Xml.IXmlNamespaceResolver"}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = "Newtonsoft.Json.Utilities.ParseResult")]
	[CalledBy(Type = "System.Data.Common.SqlConvert", Member = "ConvertToSqlMoney", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = "System.Data.SqlTypes.SqlMoney")]
	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "Convert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "ConvertUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Checked", Member = "ConvertUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(object))]
	[CalledBy(Type = "DG.Tweening.Plugins.UlongPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<UInt64>", "DG.Tweening.Core.DOSetter`1<UInt64>", typeof(float), typeof(ulong), typeof(ulong), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 15)]
	[CLSCompliant(False)]
	public static decimal op_Implicit(ulong value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "ConvertInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Checked", Member = "ConvertInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(object))]
	[CallerCount(Count = 13)]
	public static decimal op_Implicit(long value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 1)]
	[CLSCompliant(False)]
	public static decimal op_Implicit(uint value) { }

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public static decimal op_Implicit(char value) { }

	[CallerCount(Count = 2)]
	[CLSCompliant(False)]
	[DeduplicatedMethod]
	public static decimal op_Implicit(ushort value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(short), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CallerCount(Count = 2)]
	public static decimal op_Implicit(short value) { }

	[CalledBy(Type = typeof(byte), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 2)]
	public static decimal op_Implicit(byte value) { }

	[CalledBy(Type = typeof(bool), Member = "System.IConvertible.ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Checked", Member = "ConvertInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Linq.Expressions.Interpreter.NumericConvertInstruction+Unchecked", Member = "ConvertInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.UInt64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.Common.Int64Storage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Data.XDRSchema", Member = "InstantiateSimpleTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataSet", "System.Xml.XmlElement"}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Data.XDRSchema", Member = "InstantiateTable", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Data.DataSet", "System.Xml.XmlElement", "System.Xml.XmlElement"}, ReturnType = "System.Data.DataTable")]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ChangeType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Type)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "IsSequenceFromChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSequence", "System.Xml.Schema.XmlSchemaChoice"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Numerics.BigInteger", Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.BigInteger"}, ReturnType = typeof(Decimal))]
	[CallerCount(Count = 21)]
	public static decimal op_Implicit(int value) { }

	[CalledBy(Type = "System.Xml.Schema.RangeContentValidator", Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlQualifiedName", "System.Xml.Schema.ValidationState", typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = "Newtonsoft.Json.Utilities.ParseResult")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecCalc), Member = "DecAddSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&), typeof(bool)}, ReturnType = typeof(void))]
	public static decimal op_Increment(decimal d) { }

	[CallerCount(Count = 47)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_Inequality(decimal d1, decimal d2) { }

	[CalledBy(Type = "System.Xml.Schema.RangeContentValidator", Member = "ValidateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlQualifiedName", "System.Xml.Schema.ValidationState", typeof(Int32&)}, ReturnType = typeof(object))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "CalculateEffectiveTotalRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "CalculateEffectiveTotalRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccursString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccursString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = "DecimalToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	public static bool op_LessThan(decimal d1, decimal d2) { }

	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaGroupBase", "System.Xml.Schema.XmlSchemaAny"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "IsSequenceFromChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSequence", "System.Xml.Schema.XmlSchemaChoice"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "IsValidOccurrenceRangeRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", "System.Xml.Schema.XmlSchemaParticle"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "IsValidOccurrenceRangeRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal), typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "IsGroupBaseFromAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaGroupBase", "System.Xml.Schema.XmlSchemaAny"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "IsSequenceFromChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSequence", "System.Xml.Schema.XmlSchemaChoice"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "IsValidOccurrenceRangeRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", "System.Xml.Schema.XmlSchemaParticle"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "IsValidOccurrenceRangeRestriction", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(Decimal), typeof(Decimal), typeof(Decimal)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecCmp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(int))]
	[ContainsUnimplementedInstructions]
	public static bool op_LessThanOrEqual(decimal d1, decimal d2) { }

	[CalledBy(Type = "System.Xml.Schema.FacetsChecker", Member = "Power", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "IsElementFromGroupBase", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaElement", "System.Xml.Schema.XmlSchemaGroupBase", typeof(bool)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "CalculateSequenceRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSequence", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.SchemaCollectionCompiler", Member = "CalculateEffectiveTotalRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "IsSequenceFromChoice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaSequence", "System.Xml.Schema.XmlSchemaChoice"}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Xml.Schema.Compiler", Member = "CalculateEffectiveTotalRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.Schema.XmlSchemaParticle", typeof(Decimal&), typeof(Decimal&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Utilities.ConvertUtils", Member = "DecimalTryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Char[]", typeof(int), typeof(int), typeof(Decimal&)}, ReturnType = "Newtonsoft.Json.Utilities.ParseResult")]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "DG.Tweening.Plugins.UlongPlugin", Member = "EvaluateAndApply", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"DG.Tweening.Plugins.Options.NoOptions", "DG.Tweening.Tween", typeof(bool), "DG.Tweening.Core.DOGetter`1<UInt64>", "DG.Tweening.Core.DOSetter`1<UInt64>", typeof(float), typeof(ulong), typeof(ulong), typeof(float), typeof(bool), "DG.Tweening.Core.Enums.UpdateNotice"}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(DecCalc), Member = "VarDecMul", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&)}, ReturnType = typeof(void))]
	public static decimal op_Multiply(decimal d1, decimal d2) { }

	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Newtonsoft.Json.JsonTextReader", Member = "ParseReadNumber", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Newtonsoft.Json.ReadType", typeof(char), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "CompareBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.BigInteger", typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "Operation", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Linq.Expressions.ExpressionType", typeof(object), typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CalledBy(Type = "TMPro.TMP_Text", Member = "AddFloatToInternalTextBackingArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(int), typeof(int), typeof(Int32&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(DecCalc), Member = "DecAddSub", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(DecCalc&), typeof(bool)}, ReturnType = typeof(void))]
	public static decimal op_Subtraction(decimal d1, decimal d2) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static decimal op_UnaryNegation(decimal d) { }

	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadDecimal", ReturnType = typeof(Decimal))]
	[CalledBy(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE)}, ReturnType = typeof(object))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "ParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(Decimal))]
	public static decimal Parse(string s, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Convert), Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "FromString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberFormatInfo)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ExceptionArgument)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "ParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo)}, ReturnType = typeof(Decimal))]
	public static decimal Parse(string s, NumberStyles style, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 12)]
	private static decimal Round(ref decimal d, int decimals, MidpointRounding mode) { }

	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(Math), Member = "Round", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Data.Common.TimeSpanStorage", Member = "Aggregate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32[]", "System.Data.AggregateType"}, ReturnType = typeof(object))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static decimal Round(decimal d, int decimals) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToBoolean", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(bool))]
	private override bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	private override byte System.IConvertible.ToByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override char System.IConvertible.ToChar(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SR), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(InvalidCastException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 6)]
	private override DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	[CallerCount(Count = 18)]
	[DeduplicatedMethod]
	private override decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(double))]
	private override double System.IConvertible.ToDouble(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	private override short System.IConvertible.ToInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	private override int System.IConvertible.ToInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	private override long System.IConvertible.ToInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	private override sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(float))]
	private override float System.IConvertible.ToSingle(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "DefaultToType", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IConvertible), typeof(Type), typeof(IFormatProvider)}, ReturnType = typeof(object))]
	private override object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	private override ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	private override uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	private override ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 4)]
	private override void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

	[CalledBy(Type = typeof(Convert), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static byte ToByte(decimal value) { }

	[CalledBy(Type = "System.Data.SqlTypes.SqlMoney", Member = "ToDouble", ReturnType = typeof(double))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlMoney", Member = "ToSqlDouble", ReturnType = "System.Data.SqlTypes.SqlDouble")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
	public static double ToDouble(decimal d) { }

	[CalledBy(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	public static short ToInt16(decimal value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Decimal), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[CalledBy(Type = typeof(Decimal), Member = "ToInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(short))]
	[CalledBy(Type = typeof(Decimal), Member = "op_Explicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static int ToInt32(decimal d) { }

	[CalledBy(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(long))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	public static long ToInt64(decimal d) { }

	[CalledBy(Type = typeof(Convert), Member = "ToSByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(sbyte))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "ToInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[CLSCompliant(False)]
	public static sbyte ToSByte(decimal value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecCalc), Member = "VarR8FromDec", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal&)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static float ToSingle(decimal d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo", ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public virtual string ToString() { }

	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InternalPrimitiveTypeE), typeof(object)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckValueFacets", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), "System.Xml.Schema.XmlSchemaDatatype"}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Data.XmlTreeGen", Member = "SchemaTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Xml.XmlDocument", "System.Xml.XmlWriter", "System.Data.DataSet", "System.Data.DataTable", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 1)]
	public override string ToString(IFormatProvider provider) { }

	[CalledBy(Type = "System.Xml.BinXmlSqlMoney", Member = "ToString", ReturnType = typeof(string))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.ComponentModel.DecimalConverter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.JsonConvert", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = "System.Data.SqlTypes.SqlMoney", Member = "ToString", ReturnType = typeof(string))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "FormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo)}, ReturnType = typeof(string))]
	public override string ToString(string format, IFormatProvider provider) { }

	[CalledBy(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Decimal), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Exception)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 9)]
	[CLSCompliant(False)]
	public static ushort ToUInt16(decimal value) { }

	[CalledBy(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(uint))]
	[CalledBy(Type = typeof(Decimal), Member = "ToByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(byte))]
	[CalledBy(Type = typeof(Decimal), Member = "ToUInt16", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ushort))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static uint ToUInt32(decimal d) { }

	[CalledBy(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 5)]
	[CLSCompliant(False)]
	public static ulong ToUInt64(decimal d) { }

	[CalledBy(Type = typeof(Math), Member = "Truncate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(Decimal))]
	[CalledBy(Type = "System.Xml.Schema.Numeric10FacetsChecker", Member = "CheckTotalAndFractionDigits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(int), typeof(int), typeof(bool), typeof(bool)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MinOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlSchemaParticle", Member = "set_MaxOccurs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CalledBy(Type = "System.Xml.Schema.XmlNumeric10Converter", Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(string))]
	[CalledBy(Type = "Newtonsoft.Json.Linq.JValue", Member = "CompareBigInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Numerics.BigInteger", typeof(object)}, ReturnType = typeof(int))]
	[CalledBy(Type = "System.Numerics.BigInteger", Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[CallsUnknownMethods(Count = 1)]
	public static decimal Truncate(decimal d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DecCalc), Member = "InternalRound", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(DecCalc&), typeof(uint), typeof(RoundingMode)}, ReturnType = typeof(void))]
	private static void Truncate(ref decimal d) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "TryFormatDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Decimal), typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberFormatInfo), typeof(System.Span`1<System.Char>), typeof(Int32&)}, ReturnType = typeof(bool))]
	public override bool TryFormat(Span<Char> destination, out int charsWritten, ReadOnlySpan<Char> format = null, IFormatProvider provider = null) { }

	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Decimal&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "System.Xml.XmlConvert", Member = "TryToInteger", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Decimal&)}, ReturnType = typeof(Exception))]
	[CalledBy(Type = "Newtonsoft.Json.JsonReader", Member = "ReadDecimalString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = "System.Nullable`1<Decimal>")]
	[CalledBy(Type = "System.Data.ConstNode", Member = "SmallestDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(object))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "ValidateParseStyleFloatingPoint", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NumberStyles)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(string), Member = "GetRawStringData", ReturnType = typeof(Char&))]
	[Calls(Type = typeof(NumberFormatInfo), Member = "GetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider)}, ReturnType = typeof(NumberFormatInfo))]
	[Calls(Type = typeof(Number), Member = "TryParseDecimal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.ReadOnlySpan`1<System.Char>), typeof(NumberStyles), typeof(NumberFormatInfo), typeof(Decimal&)}, ReturnType = typeof(bool))]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result) { }

}

