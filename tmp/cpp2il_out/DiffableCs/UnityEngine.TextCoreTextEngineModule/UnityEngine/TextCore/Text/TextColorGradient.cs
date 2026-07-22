namespace UnityEngine.TextCore.Text;

[ExcludeFromObjectFactory]
[ExcludeFromPreset]
public class TextColorGradient : ScriptableObject
{
	private const ColorGradientMode k_DefaultColorMode = 3; //Field offset: 0x0
	private static readonly Color k_DefaultColor; //Field offset: 0x0
	public ColorGradientMode colorMode; //Field offset: 0x18
	public Color topLeft; //Field offset: 0x1C
	public Color topRight; //Field offset: 0x2C
	public Color bottomLeft; //Field offset: 0x3C
	public Color bottomRight; //Field offset: 0x4C

	[CallerCount(Count = 0)]
	private static TextColorGradient() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	public TextColorGradient() { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TextColorGradient(Color color) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
	[DeduplicatedMethod]
	public TextColorGradient(Color color0, Color color1, Color color2, Color color3) { }

}

