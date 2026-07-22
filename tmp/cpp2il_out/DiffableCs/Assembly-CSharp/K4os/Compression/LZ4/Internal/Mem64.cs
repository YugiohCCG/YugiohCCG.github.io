namespace K4os.Compression.LZ4.Internal;

public class Mem64 : Mem
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Mem64() { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void Copy1(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void Copy16(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	public static void Copy18(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void Copy2(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void Copy4(Byte* target, Byte* source) { }

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	public static void Copy8(Byte* target, Byte* source) { }

	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	public static ushort Peek2(Void* p) { }

	[CallerCount(Count = 173)]
	[DeduplicatedMethod]
	public static uint Peek4(Void* p) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public static ulong Peek8(Void* p) { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public static ulong PeekW(Void* p) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void Poke2(Void* p, ushort v) { }

	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	public static void Poke4(Void* p, uint v) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public static void Poke8(Void* p, ulong v) { }

	[CallerCount(Count = 26)]
	[DeduplicatedMethod]
	public static void PokeW(Void* p, ulong v) { }

	[CallerCount(Count = 0)]
	public static void WildCopy32(Byte* target, Byte* source, Void* limit) { }

	[CallerCount(Count = 0)]
	public static void WildCopy8(Byte* target, Byte* source, Void* limit) { }

}

