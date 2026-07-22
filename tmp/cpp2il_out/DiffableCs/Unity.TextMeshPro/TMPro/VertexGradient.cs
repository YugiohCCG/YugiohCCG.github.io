namespace TMPro;

public struct VertexGradient
{
	public Color topLeft; //Field offset: 0x0
	public Color topRight; //Field offset: 0x10
	public Color bottomLeft; //Field offset: 0x20
	public Color bottomRight; //Field offset: 0x30

	[CalledBy(Type = typeof(TMP_Text), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	public VertexGradient(Color color) { }

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public VertexGradient(Color color0, Color color1, Color color2, Color color3) { }

}

