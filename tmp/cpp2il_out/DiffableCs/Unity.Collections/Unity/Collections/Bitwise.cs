namespace Unity.Collections;

[GenerateTestsForBurstCompatibility]
internal struct Bitwise
{

	[CallerCount(Count = 0)]
	internal static int AlignDown(int value, int alignPow2) { }

	[CallerCount(Count = 0)]
	internal static long AlignDown(long value, int alignPow2) { }

	[CalledBy(Type = typeof(NativeBitArray), Member = "Clear", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Clear", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	internal static int AlignUp(int value, int alignPow2) { }

	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Realloc", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	internal static long AlignUp(long value, int alignPow2) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "CountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "CountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnly), Member = "CountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "CountBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 4)]
	internal static int CountBits(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[CallerCount(Count = 0)]
	internal static uint ExtractBits(uint input, int pos, uint mask) { }

	[CallerCount(Count = 0)]
	internal static ulong ExtractBits(ulong input, int pos, ulong mask) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(ReadOnly), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(Bitwise), Member = "FindWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	internal static int Find(UInt64* ptr, int pos, int count, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "lzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Bitwise), Member = "tzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	private static int FindByte(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int FindUint(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static int FindUlong(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "tzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 1)]
	private static int FindUpto14bits(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "tzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	private static int FindUpto6bits(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Bitwise), Member = "lzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Bitwise), Member = "tzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(int))]
	private static int FindUshort(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[CalledBy(Type = typeof(Bitwise), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Bitwise), Member = "lzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Bitwise), Member = "tzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Bitwise), Member = "lzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Bitwise), Member = "tzcnt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(byte)}, ReturnType = typeof(int))]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	internal static int FindWithBeginEnd(UInt64* ptr, int beginBit, int endBit, int numBits) { }

	[CallerCount(Count = 19)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	internal static int FromBool(bool value) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(ReadOnly), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "GetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(ulong))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "CopyUlong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(UnsafeBitArray&), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 9)]
	internal static ulong GetBits(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "IsSet", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeBitArrayDebugView), Member = "get_Bits", ReturnType = typeof(Boolean[]))]
	[CallerCount(Count = 5)]
	[ContainsUnimplementedInstructions]
	internal static bool IsSet(UInt64* ptr, int pos) { }

	[CalledBy(Type = typeof(Bitwise), Member = "FindUshort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Bitwise), Member = "FindWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int lzcnt(ushort value) { }

	[CalledBy(Type = typeof(Bitwise), Member = "FindByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Bitwise), Member = "FindWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int lzcnt(byte value) { }

	[CalledBy(Type = typeof(UnsafeBitArray), Member = "SetBits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ulong), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	internal static ulong ReplaceBits(ulong input, int pos, ulong mask, ulong value) { }

	[CallerCount(Count = 0)]
	internal static uint ReplaceBits(uint input, int pos, uint mask, uint value) { }

	[CallerCount(Count = 0)]
	private static ushort sar(ushort val, int shift) { }

	[CallerCount(Count = 0)]
	internal static ulong SetBits(ulong input, int pos, ulong mask, bool value) { }

	[CallerCount(Count = 0)]
	internal static uint SetBits(uint input, int pos, uint mask, bool value) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "TestAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "TestAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "TestAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "TestAll", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static bool TestAll(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "TestAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "TestAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "TestAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "TestAny", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static bool TestAny(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[CalledBy(Type = typeof(ReadOnly), Member = "TestNone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(NativeBitArray), Member = "TestNone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(ReadOnly), Member = "TestNone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "TestNone", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 4)]
	[ContainsUnimplementedInstructions]
	internal static bool TestNone(UInt64* ptr, int length, int pos, int numBits = 1) { }

	[CalledBy(Type = typeof(Bitwise), Member = "FindByte", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Bitwise), Member = "FindUpto14bits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Bitwise), Member = "FindUpto6bits", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Bitwise), Member = "FindWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 6)]
	[ContainsUnimplementedInstructions]
	internal static int tzcnt(byte value) { }

	[CalledBy(Type = typeof(Bitwise), Member = "FindUshort", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CalledBy(Type = typeof(Bitwise), Member = "FindWithBeginEnd", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallerCount(Count = 2)]
	[ContainsUnimplementedInstructions]
	internal static int tzcnt(ushort value) { }

}

