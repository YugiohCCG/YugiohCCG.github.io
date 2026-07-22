namespace UnityEngine;

[MovedFrom("UnityEditor")]
[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEditor.UIBuilderModule"})]
internal class NumericFieldDraggerUtility
{
	private static bool s_UseYSign; //Field offset: 0x0

	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.SliderInt", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	public static float Acceleration(bool shiftPressed, bool altPressed) { }

	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static double CalculateFloatDragSensitivity(double value) { }

	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[ContainsUnimplementedInstructions]
	public static double CalculateFloatDragSensitivity(double value, double minValue, double maxValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(NumericFieldDraggerUtility), Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static long CalculateIntDragSensitivity(long value) { }

	[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumericFieldDraggerUtility), Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static ulong CalculateIntDragSensitivity(ulong value) { }

	[CalledBy(Type = typeof(NumericFieldDraggerUtility), Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long)}, ReturnType = typeof(long))]
	[CalledBy(Type = typeof(NumericFieldDraggerUtility), Member = "CalculateIntDragSensitivity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, ReturnType = typeof(ulong))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Math), Member = "Pow", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(double), typeof(double)}, ReturnType = typeof(double))]
	[ContainsUnimplementedInstructions]
	public static double CalculateIntDragSensitivity(double value) { }

	[CalledBy(Type = "UnityEngine.UIElements.SliderInt", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long)}, ReturnType = typeof(long))]
	[ContainsUnimplementedInstructions]
	public static long CalculateIntDragSensitivity(long value, long minValue, long maxValue) { }

	[CalledBy(Type = "UnityEngine.UIElements.DoubleField+DoubleInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(double)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.FloatField+FloatInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.IntegerField+IntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.LongField+LongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(long)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.Slider", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.SliderInt", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedIntegerField+UnsignedIntegerInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UnsignedLongField+UnsignedLongInput", Member = "ApplyInputDeviceDelta", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), "UnityEngine.UIElements.DeltaSpeed", typeof(ulong)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[CallsUnknownMethods(Count = 1)]
	public static float NiceDelta(Vector2 deviceDelta, float acceleration) { }

}

