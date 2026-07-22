namespace UnityEngine.UIElements.Experimental;

internal static class Lerp
{

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public static float Interpolate(float start, float end, float ratio) { }

	[CallerCount(Count = 0)]
	public static Color Interpolate(Color start, Color end, float ratio) { }

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StyleValueCollection), Member = "TryGetStyleValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(StylePropertyId), typeof(StyleValue&)}, ReturnType = typeof(bool))]
	[ContainsInvalidInstructions]
	internal static StyleValues Interpolate(StyleValues start, StyleValues end, float ratio) { }

}

