namespace Spine;

public class Atlas : IEnumerable<AtlasRegion>, IEnumerable
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public AtlasPage page; //Field offset: 0x10
		public String[] entry; //Field offset: 0x18
		public AtlasRegion region; //Field offset: 0x20

		[CallerCount(Count = 2180)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		public <>c__DisplayClass10_0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__0() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 3)]
		internal void <.ctor>b__1() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__10() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__11() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__12() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RuntimeTypeHandle)}, ReturnType = typeof(Type))]
		[Calls(Type = typeof(Enum), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(string), typeof(bool)}, ReturnType = typeof(object))]
		[CallsUnknownMethods(Count = 4)]
		internal void <.ctor>b__2() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__3() { }

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__4() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__5() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__6() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__7() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__8() { }

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[Calls(Type = typeof(int), Member = "Parse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IFormatProvider)}, ReturnType = typeof(int))]
		[CallsUnknownMethods(Count = 2)]
		internal void <.ctor>b__9() { }

	}

	private readonly List<AtlasPage> pages; //Field offset: 0x10
	private List<AtlasRegion> regions; //Field offset: 0x18
	private TextureLoader textureLoader; //Field offset: 0x20

	public List<AtlasPage> Pages
	{
		[CallerCount(Count = 106)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	public List<AtlasRegion> Regions
	{
		[CallerCount(Count = 31)]
		[DeduplicatedMethod]
		 get { } //Length: 5
	}

	[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "LoadAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.U2D.SpriteAtlas"}, ReturnType = typeof(Atlas))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 15)]
	public Atlas(List<AtlasPage> pages, List<AtlasRegion> regions) { }

	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GetAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Atlas))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "ToArray", ReturnType = "T[]")]
	[Calls(Type = typeof(int), Member = "TryParse", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(NumberStyles), typeof(IFormatProvider), typeof(Int32&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Object&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Atlas), Member = "ReadEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(String[]), typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<System.Object, System.Object>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 28)]
	[CallsUnknownMethods(Count = 35)]
	public Atlas(TextReader reader, string imagesDir, TextureLoader textureLoader) { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	public void Dispose() { }

	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GenerateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), "UnityEngine.Mesh", "UnityEngine.Material&", typeof(float)}, ReturnType = "UnityEngine.Mesh")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	public AtlasRegion FindRegion(string name) { }

	[CalledBy(Type = "Spine.Unity.SpineAtlasAsset", Member = "GetAtlas", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Atlas))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void FlipV() { }

	[CallerCount(Count = 106)]
	[DeduplicatedMethod]
	public List<AtlasPage> get_Pages() { }

	[CallerCount(Count = 31)]
	[DeduplicatedMethod]
	public List<AtlasRegion> get_Regions() { }

	[CalledBy(Type = "Spine.Unity.SpineSpriteAtlasAsset", Member = "AssignRegionsFromSavedRegions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.Sprite[]", typeof(Atlas)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 1)]
	public override IEnumerator<AtlasRegion> GetEnumerator() { }

	[CalledBy(Type = typeof(Atlas), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextReader), typeof(string), typeof(TextureLoader)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(char), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(string), Member = "Substring", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 5)]
	private static int ReadEntry(String[] entry, string line) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[CallsUnknownMethods(Count = 1)]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

