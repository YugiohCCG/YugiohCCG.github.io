namespace K4os.Compression.LZ4.Internal;

public class Mem
{
	public const int K1 = 1024; //Field offset: 0x0
	public const int K2 = 2048; //Field offset: 0x0
	public const int K4 = 4096; //Field offset: 0x0
	public const int K8 = 8192; //Field offset: 0x0
	public const int K16 = 16384; //Field offset: 0x0
	public const int K32 = 32768; //Field offset: 0x0
	public const int K64 = 65536; //Field offset: 0x0
	public const int K128 = 131072; //Field offset: 0x0
	public const int K256 = 262144; //Field offset: 0x0
	public const int K512 = 524288; //Field offset: 0x0
	public const int M1 = 1048576; //Field offset: 0x0
	public const int M4 = 4194304; //Field offset: 0x0
	public static readonly Byte[] Empty; //Field offset: 0x0

	public static bool System32
	{
		[CallerCount(Count = 271)]
		[DeduplicatedMethod]
		 get { } //Length: 3
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private static Mem() { }

	[CallerCount(Count = 2180)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	public Mem() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	public static Void* Alloc(int size) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 1)]
	public static Void* AllocZero(int size) { }

	[CalledBy(Type = typeof(Mem), Member = "CloneArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(Int32*))]
	[CalledBy(Type = typeof(LL), Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Marshal), Member = "AllocHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	public static Void* CloneAnyArray(T[] array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mem), Member = "CloneAnyArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T[]"}, ReturnType = typeof(Void*))]
	public static Int32* CloneArray(Int32[] array) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Mem), Member = "CloneAnyArray", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt32[])}, ReturnType = typeof(Void*))]
	public static UInt32* CloneArray(UInt32[] array) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Copy(Byte* target, Byte* source, int length) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static void Copy1(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	public static void Copy2(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	public static void Copy4(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	public static void Copy8(Byte* target, Byte* source) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static void CpBlk(Void* target, Void* source, uint length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Byte* Fill(Byte* target, byte value, int length) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	public static void Free(Void* ptr) { }

	[CallerCount(Count = 271)]
	[DeduplicatedMethod]
	public static bool get_System32() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Buffer), Member = "MemoryCopy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long), typeof(long)}, ReturnType = typeof(void))]
	public static void Move(Byte* target, Byte* source, int length) { }

	[CallerCount(Count = 89)]
	[DeduplicatedMethod]
	public static byte Peek1(Void* p) { }

	[CallerCount(Count = 0)]
	public static ushort Peek2(Void* p) { }

	[CallerCount(Count = 0)]
	public static uint Peek4(Void* p) { }

	[CallerCount(Count = 0)]
	public static ulong Peek8(Void* p) { }

	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	public static void Poke1(Void* p, byte v) { }

	[CallerCount(Count = 0)]
	public static void Poke2(Void* p, ushort v) { }

	[CallerCount(Count = 0)]
	public static void Poke4(Void* p, uint v) { }

	[CallerCount(Count = 0)]
	public static void Poke8(Void* p, ulong v) { }

	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	public static int RoundUp(int value, int step) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	internal static void ZBlk(Void* target, byte value, uint length) { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static Byte* Zero(Byte* target, int length) { }

}

