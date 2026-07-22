namespace UnityEngine.UIElements.UIR;

internal struct TextCoreSettings : IEquatable<TextCoreSettings>
{
	public Color faceColor; //Field offset: 0x0
	public Color outlineColor; //Field offset: 0x10
	public float outlineWidth; //Field offset: 0x20
	public Color underlayColor; //Field offset: 0x24
	public Vector2 underlayOffset; //Field offset: 0x34
	public float underlaySoftness; //Field offset: 0x3C

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextCoreSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextCoreSettings)}, ReturnType = typeof(bool))]
	[CallsUnknownMethods(Count = 1)]
	public virtual bool Equals(object obj) { }

	[CalledBy(Type = typeof(TextCoreSettings), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public override bool Equals(TextCoreSettings other) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	public virtual int GetHashCode() { }

}

