namespace UnityEngine.Rendering;

[AttributeUsage(AttributeTargets::Field (256))]
public class SurfaceDataAttributes : Attribute
{
	public String[] displayNames; //Field offset: 0x10
	public bool isDirection; //Field offset: 0x18
	public bool sRGBDisplay; //Field offset: 0x19
	public FieldPrecision precision; //Field offset: 0x1C
	public bool checkIsNormalized; //Field offset: 0x20
	public string preprocessor; //Field offset: 0x28

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	public SurfaceDataAttributes(string displayName = "", bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = 2, bool checkIsNormalized = false, string preprocessor = "") { }

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public SurfaceDataAttributes(String[] displayNames, bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = 2, bool checkIsNormalized = false, string preprocessor = "") { }

}

