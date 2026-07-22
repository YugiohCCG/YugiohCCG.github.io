namespace K4os.Compression.LZ4.Engine;

public static class Pubternal
{
	internal class FastContext : UnmanagedResources
	{
		[CompilerGenerated]
		private readonly LZ4_stream_t* <Context>k__BackingField; //Field offset: 0x18

		internal LZ4_stream_t* Context
		{
			[CallerCount(Count = 31)]
			[CompilerGenerated]
			[DeduplicatedMethod]
			internal get { } //Length: 5
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public FastContext() { }

		[CallerCount(Count = 31)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		internal LZ4_stream_t* get_Context() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Marshal), Member = "FreeHGlobal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
		protected virtual void ReleaseUnmanaged() { }

	}


	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LLxx), Member = "LZ4_compress_fast_continue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LZ4_stream_t*), typeof(Byte*), typeof(Byte*), typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[CallsUnknownMethods(Count = 1)]
	public static int CompressFast(FastContext context, Byte* source, Byte* target, int sourceLength, int targetLength, int acceleration) { }

}

