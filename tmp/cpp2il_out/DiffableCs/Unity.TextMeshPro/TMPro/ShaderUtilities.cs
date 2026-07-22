namespace TMPro;

public static class ShaderUtilities
{
	public static int ID_MainTex; //Field offset: 0x0
	public static int ID_FaceTex; //Field offset: 0x4
	public static int ID_FaceColor; //Field offset: 0x8
	public static int ID_FaceDilate; //Field offset: 0xC
	public static int ID_Shininess; //Field offset: 0x10
	public static int ID_OutlineOffset1; //Field offset: 0x14
	public static int ID_OutlineOffset2; //Field offset: 0x18
	public static int ID_OutlineOffset3; //Field offset: 0x1C
	public static int ID_OutlineMode; //Field offset: 0x20
	public static int ID_IsoPerimeter; //Field offset: 0x24
	public static int ID_Softness; //Field offset: 0x28
	public static int ID_UnderlayColor; //Field offset: 0x2C
	public static int ID_UnderlayOffsetX; //Field offset: 0x30
	public static int ID_UnderlayOffsetY; //Field offset: 0x34
	public static int ID_UnderlayDilate; //Field offset: 0x38
	public static int ID_UnderlaySoftness; //Field offset: 0x3C
	public static int ID_UnderlayOffset; //Field offset: 0x40
	public static int ID_UnderlayIsoPerimeter; //Field offset: 0x44
	public static int ID_WeightNormal; //Field offset: 0x48
	public static int ID_WeightBold; //Field offset: 0x4C
	public static int ID_OutlineTex; //Field offset: 0x50
	public static int ID_OutlineWidth; //Field offset: 0x54
	public static int ID_OutlineSoftness; //Field offset: 0x58
	public static int ID_OutlineColor; //Field offset: 0x5C
	public static int ID_Outline2Color; //Field offset: 0x60
	public static int ID_Outline2Width; //Field offset: 0x64
	public static int ID_Padding; //Field offset: 0x68
	public static int ID_GradientScale; //Field offset: 0x6C
	public static int ID_ScaleX; //Field offset: 0x70
	public static int ID_ScaleY; //Field offset: 0x74
	public static int ID_PerspectiveFilter; //Field offset: 0x78
	public static int ID_Sharpness; //Field offset: 0x7C
	public static int ID_TextureWidth; //Field offset: 0x80
	public static int ID_TextureHeight; //Field offset: 0x84
	public static int ID_BevelAmount; //Field offset: 0x88
	public static int ID_GlowColor; //Field offset: 0x8C
	public static int ID_GlowOffset; //Field offset: 0x90
	public static int ID_GlowPower; //Field offset: 0x94
	public static int ID_GlowOuter; //Field offset: 0x98
	public static int ID_GlowInner; //Field offset: 0x9C
	public static int ID_LightAngle; //Field offset: 0xA0
	public static int ID_EnvMap; //Field offset: 0xA4
	public static int ID_EnvMatrix; //Field offset: 0xA8
	public static int ID_EnvMatrixRotation; //Field offset: 0xAC
	public static int ID_MaskCoord; //Field offset: 0xB0
	public static int ID_ClipRect; //Field offset: 0xB4
	public static int ID_MaskSoftnessX; //Field offset: 0xB8
	public static int ID_MaskSoftnessY; //Field offset: 0xBC
	public static int ID_VertexOffsetX; //Field offset: 0xC0
	public static int ID_VertexOffsetY; //Field offset: 0xC4
	public static int ID_UseClipRect; //Field offset: 0xC8
	public static int ID_StencilID; //Field offset: 0xCC
	public static int ID_StencilOp; //Field offset: 0xD0
	public static int ID_StencilComp; //Field offset: 0xD4
	public static int ID_StencilReadMask; //Field offset: 0xD8
	public static int ID_StencilWriteMask; //Field offset: 0xDC
	public static int ID_ShaderFlags; //Field offset: 0xE0
	public static int ID_ScaleRatio_A; //Field offset: 0xE4
	public static int ID_ScaleRatio_B; //Field offset: 0xE8
	public static int ID_ScaleRatio_C; //Field offset: 0xEC
	public static string Keyword_Bevel; //Field offset: 0xF0
	public static string Keyword_Glow; //Field offset: 0xF8
	public static string Keyword_Underlay; //Field offset: 0x100
	public static string Keyword_Ratios; //Field offset: 0x108
	public static string Keyword_MASK_SOFT; //Field offset: 0x110
	public static string Keyword_MASK_HARD; //Field offset: 0x118
	public static string Keyword_MASK_TEX; //Field offset: 0x120
	public static string Keyword_Outline; //Field offset: 0x128
	public static string ShaderTag_ZTestMode; //Field offset: 0x130
	public static string ShaderTag_CullMode; //Field offset: 0x138
	private static float m_clamp; //Field offset: 0x140
	public static bool isInitialized; //Field offset: 0x144
	private static Shader k_ShaderRef_MobileSDF; //Field offset: 0x148
	private static Shader k_ShaderRef_MobileBitmap; //Field offset: 0x150

	internal static Shader ShaderRef_MobileBitmap
	{
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 280
	}

	internal static Shader ShaderRef_MobileSDF
	{
		[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
		[CallsUnknownMethods(Count = 1)]
		internal get { } //Length: 280
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 10)]
	private static ShaderUtilities() { }

	[CalledBy(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Material), Member = "GetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	private static float ComputePaddingForProperties(Material mat) { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CallsUnknownMethods(Count = 1)]
	internal static Shader get_ShaderRef_MobileBitmap() { }

	[CalledBy(Type = typeof(TMP_FontAsset), Member = "CreateFontAssetInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Font), typeof(int), typeof(GlyphRenderMode), typeof(int), typeof(int), typeof(AtlasPopulationMode), typeof(bool)}, ReturnType = typeof(TMP_FontAsset))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CallsUnknownMethods(Count = 1)]
	internal static Shader get_ShaderRef_MobileSDF() { }

	[CallerCount(Count = 0)]
	public static Vector4 GetFontExtent(Material material) { }

	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateMeshPadding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPaddingForMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "UpdateMeshPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateMeshPadding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "UpdateMeshPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TMP_SubMesh), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_SubMeshUI), Member = "GetPaddingForMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(float))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(Material), Member = "GetVector", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Vector4))]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "UpdateShaderRatios", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "ComputePaddingForProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(float))]
	[CallsDeduplicatedMethods(Count = 17)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static float GetPadding(Material material, bool enableExtraPadding, bool isBold) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ShaderUtilities), Member = "GetShaderPropertyIDs", ReturnType = typeof(void))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(ShaderUtilities), Member = "UpdateShaderRatios", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 15)]
	[CallsUnknownMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	public static float GetPadding(Material[] materials, bool enableExtraPadding, bool isBold) { }

	[CalledBy(Type = typeof(TMP_MaterialManager), Member = "GetStencilMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(int)}, ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(ShaderUtilities), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[]), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_SpriteAsset), Member = "GetDefaultSpriteMaterial", ReturnType = typeof(Material))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateMask", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "GetMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(Material))]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Shader), Member = "Find", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(Shader))]
	[CallsUnknownMethods(Count = 2)]
	public static void GetShaderPropertyIDs() { }

	[CalledBy(Type = typeof(TMP_Text), Member = "GetPaddingForMaterial", ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TMP_Text), Member = "GetPaddingForMaterial", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "UpdateMeshPadding", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshPro), Member = "LoadFontAsset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(TextMeshProUGUI), Member = "UpdateMeshPadding", ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static bool IsMaskingEnabled(Material material) { }

	[CalledBy(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CalledBy(Type = typeof(ShaderUtilities), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Material[]), typeof(bool), typeof(bool)}, ReturnType = typeof(float))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Enumerable), Member = "Contains", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Object>), typeof(object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Material), Member = "HasProperty", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 16)]
	[CallsUnknownMethods(Count = 1)]
	public static void UpdateShaderRatios(Material mat) { }

}

