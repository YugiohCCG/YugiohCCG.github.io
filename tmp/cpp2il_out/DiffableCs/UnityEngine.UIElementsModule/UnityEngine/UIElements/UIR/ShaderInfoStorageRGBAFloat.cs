namespace UnityEngine.UIElements.UIR;

internal class ShaderInfoStorageRGBAFloat : ShaderInfoStorage<Color>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		private static <>c() { }

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c() { }

		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		internal Color <.cctor>b__2_0(Color c) { }

	}

	private static readonly Func<Color, Color> s_Convert; //Field offset: 0x0

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Func`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	private static ShaderInfoStorageRGBAFloat() { }

	[CalledBy(Type = typeof(UIRVEShaderInfoAllocator), Member = "ReallyCreateStorage", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ShaderInfoStorage`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureFormat), "System.Func`2<Color, T>", typeof(int), typeof(int)}, ReturnType = typeof(void))]
	public ShaderInfoStorageRGBAFloat(int initialSize = 64, int maxSize = 4096) { }

}

