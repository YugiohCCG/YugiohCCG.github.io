namespace K4os.Compression.LZ4.Internal;

public class Mem32 : Mem
{

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Mem32() { }

	[CallerCount(Count = 0)]
	public static void Copy16(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	public static void Copy18(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	public static uint PeekW(Void* p) { }

	[CallerCount(Count = 0)]
	public static void PokeW(Void* p, uint v) { }

	[CallerCount(Count = 0)]
	public static void WildCopy32(Byte* target, Byte* source, Void* limit) { }

	[CallerCount(Count = 0)]
	public static void WildCopy8(Byte* target, Byte* source, Void* limit) { }

}

