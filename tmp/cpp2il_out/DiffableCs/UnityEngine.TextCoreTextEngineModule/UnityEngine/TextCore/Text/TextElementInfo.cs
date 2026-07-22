namespace UnityEngine.TextCore.Text;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule"})]
internal struct TextElementInfo
{
	public uint character; //Field offset: 0x0
	public int index; //Field offset: 0x4
	public TextElementType elementType; //Field offset: 0x8
	public int stringLength; //Field offset: 0xC
	public TextElement textElement; //Field offset: 0x10
	public Glyph alternativeGlyph; //Field offset: 0x18
	public FontAsset fontAsset; //Field offset: 0x20
	public SpriteAsset spriteAsset; //Field offset: 0x28
	public Material material; //Field offset: 0x30
	public int materialReferenceIndex; //Field offset: 0x38
	public bool isUsingAlternateTypeface; //Field offset: 0x3C
	public float pointSize; //Field offset: 0x40
	public int lineNumber; //Field offset: 0x44
	public int vertexIndex; //Field offset: 0x48
	public TextVertex vertexTopLeft; //Field offset: 0x4C
	public TextVertex vertexBottomLeft; //Field offset: 0x74
	public TextVertex vertexTopRight; //Field offset: 0x9C
	public TextVertex vertexBottomRight; //Field offset: 0xC4
	public Vector3 topLeft; //Field offset: 0xEC
	public Vector3 bottomLeft; //Field offset: 0xF8
	public Vector3 topRight; //Field offset: 0x104
	public Vector3 bottomRight; //Field offset: 0x110
	public float origin; //Field offset: 0x11C
	public float ascender; //Field offset: 0x120
	public float baseLine; //Field offset: 0x124
	public float descender; //Field offset: 0x128
	internal float adjustedAscender; //Field offset: 0x12C
	internal float adjustedDescender; //Field offset: 0x130
	internal float adjustedHorizontalAdvance; //Field offset: 0x134
	public float xAdvance; //Field offset: 0x138
	public float aspectRatio; //Field offset: 0x13C
	public float scale; //Field offset: 0x140
	public Color32 color; //Field offset: 0x144
	public Color32 underlineColor; //Field offset: 0x148
	public int underlineVertexIndex; //Field offset: 0x14C
	public Color32 strikethroughColor; //Field offset: 0x150
	public int strikethroughVertexIndex; //Field offset: 0x154
	public Color32 highlightColor; //Field offset: 0x158
	public HighlightState highlightState; //Field offset: 0x15C
	public FontStyles style; //Field offset: 0x170
	public bool isVisible; //Field offset: 0x174

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsUnknownMethods(Count = 314)]
	public virtual string ToString() { }

}

