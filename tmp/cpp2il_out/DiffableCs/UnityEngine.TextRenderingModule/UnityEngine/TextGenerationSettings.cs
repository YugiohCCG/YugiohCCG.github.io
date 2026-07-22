namespace UnityEngine;

public struct TextGenerationSettings
{
	public Font font; //Field offset: 0x0
	public Color color; //Field offset: 0x8
	public int fontSize; //Field offset: 0x18
	public float lineSpacing; //Field offset: 0x1C
	public bool richText; //Field offset: 0x20
	public float scaleFactor; //Field offset: 0x24
	public FontStyle fontStyle; //Field offset: 0x28
	public TextAnchor textAnchor; //Field offset: 0x2C
	public bool alignByGeometry; //Field offset: 0x30
	public bool resizeTextForBestFit; //Field offset: 0x31
	public int resizeTextMinSize; //Field offset: 0x34
	public int resizeTextMaxSize; //Field offset: 0x38
	public bool updateBounds; //Field offset: 0x3C
	public VerticalWrapMode verticalOverflow; //Field offset: 0x40
	public HorizontalWrapMode horizontalOverflow; //Field offset: 0x44
	public Vector2 generationExtents; //Field offset: 0x48
	public Vector2 pivot; //Field offset: 0x50
	public bool generateOutOfBounds; //Field offset: 0x58

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	private bool CompareColors(Color left, Color right) { }

	[CalledBy(Type = typeof(TextGenerationSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextGenerationSettings)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool CompareVector2(Vector2 left, Vector2 right) { }

	[CalledBy(Type = typeof(TextGenerator), Member = "PopulateWithError", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(TextGenerationSettings)}, ReturnType = typeof(TextGenerationError))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(TextGenerationSettings), Member = "CompareVector2", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 6)]
	[ContainsUnimplementedInstructions]
	public bool Equals(TextGenerationSettings other) { }

}

