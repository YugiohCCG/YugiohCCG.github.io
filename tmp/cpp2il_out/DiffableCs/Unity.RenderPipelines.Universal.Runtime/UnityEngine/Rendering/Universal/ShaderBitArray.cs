namespace UnityEngine.Rendering.Universal;

[DefaultMember("Item")]
internal struct ShaderBitArray
{
	private const int k_BitsPerElement = 32; //Field offset: 0x0
	private const int k_ElementShift = 5; //Field offset: 0x0
	private const int k_ElementMask = 31; //Field offset: 0x0
	private Single[] m_Data; //Field offset: 0x0

	public int bitCapacity
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 22
	}

	public Single[] data
	{
		[CallerCount(Count = 138)]
		[DeduplicatedMethod]
		 get { } //Length: 4
	}

	public int elemLength
	{
		[CallerCount(Count = 0)]
		 get { } //Length: 16
	}

	public bool Item
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 get { } //Length: 72
		[CalledBy(Type = typeof(LightCookieManager), Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData), typeof(WorkSlice`1<LightCookieMapping>&), typeof(WorkSlice`1<Vector4>&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		 set { } //Length: 81
	}

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCookieManager), Member = "Setup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightCookieManager), Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData), typeof(WorkSlice`1<LightCookieMapping>&), typeof(WorkSlice`1<Vector4>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public void Clear() { }

	[CallerCount(Count = 0)]
	public int get_bitCapacity() { }

	[CallerCount(Count = 138)]
	[DeduplicatedMethod]
	public Single[] get_data() { }

	[CallerCount(Count = 0)]
	public int get_elemLength() { }

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public bool get_Item(int index) { }

	[CallerCount(Count = 0)]
	private void GetElementIndexAndBitOffset(int index, out int elemIndex, out int bitOffset) { }

	[CalledBy(Type = "UnityEngine.Rendering.Universal.LightCookieManager+LightCookieShaderData", Member = "Resize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public void Resize(int bitCount) { }

	[CalledBy(Type = typeof(LightCookieManager), Member = "UploadAdditionalLights", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(CommandBuffer), typeof(UniversalLightData), typeof(WorkSlice`1<LightCookieMapping>&), typeof(WorkSlice`1<Vector4>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public void set_Item(int index, bool value) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
	[Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SByte*), typeof(int), typeof(int), typeof(Encoding)}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	public virtual string ToString() { }

}

