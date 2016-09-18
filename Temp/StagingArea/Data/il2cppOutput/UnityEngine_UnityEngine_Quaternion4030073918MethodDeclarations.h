#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// System.String
struct String_t;
// System.Object
struct Il2CppObject;
// UnityEngine.Quaternion
struct Quaternion_t4030073918;
struct Quaternion_t4030073918_marshaled_pinvoke;
struct Quaternion_t4030073918_marshaled_com;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_Quaternion4030073918.h"
#include "UnityEngine_UnityEngine_Vector32243707580.h"
#include "mscorlib_System_Object2689449295.h"

// System.String UnityEngine.Quaternion::ToString()
extern "C"  String_t* Quaternion_ToString_m2638853272 (Quaternion_t4030073918 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Quaternion::get_eulerAngles()
extern "C"  Vector3_t2243707580  Quaternion_get_eulerAngles_m3302573991 (Quaternion_t4030073918 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Quaternion UnityEngine.Quaternion::Euler(UnityEngine.Vector3)
extern "C"  Quaternion_t4030073918  Quaternion_Euler_m3586339259 (Il2CppObject * __this /* static, unused */, Vector3_t2243707580  ___euler0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Quaternion::Internal_MakePositive(UnityEngine.Vector3)
extern "C"  Vector3_t2243707580  Quaternion_Internal_MakePositive_m2921671247 (Il2CppObject * __this /* static, unused */, Vector3_t2243707580  ___euler0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Quaternion::Internal_ToEulerRad(UnityEngine.Quaternion)
extern "C"  Vector3_t2243707580  Quaternion_Internal_ToEulerRad_m2807508879 (Il2CppObject * __this /* static, unused */, Quaternion_t4030073918  ___rotation0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Quaternion::INTERNAL_CALL_Internal_ToEulerRad(UnityEngine.Quaternion&,UnityEngine.Vector3&)
extern "C"  void Quaternion_INTERNAL_CALL_Internal_ToEulerRad_m1077217777 (Il2CppObject * __this /* static, unused */, Quaternion_t4030073918 * ___rotation0, Vector3_t2243707580 * ___value1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Quaternion UnityEngine.Quaternion::Internal_FromEulerRad(UnityEngine.Vector3)
extern "C"  Quaternion_t4030073918  Quaternion_Internal_FromEulerRad_m1121344272 (Il2CppObject * __this /* static, unused */, Vector3_t2243707580  ___euler0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Quaternion::INTERNAL_CALL_Internal_FromEulerRad(UnityEngine.Vector3&,UnityEngine.Quaternion&)
extern "C"  void Quaternion_INTERNAL_CALL_Internal_FromEulerRad_m1113788132 (Il2CppObject * __this /* static, unused */, Vector3_t2243707580 * ___euler0, Quaternion_t4030073918 * ___value1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Quaternion::GetHashCode()
extern "C"  int32_t Quaternion_GetHashCode_m2270520528 (Quaternion_t4030073918 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Quaternion::Equals(System.Object)
extern "C"  bool Quaternion_Equals_m3730391696 (Quaternion_t4030073918 * __this, Il2CppObject * ___other0, const MethodInfo* method) IL2CPP_METHOD_ATTR;

// Methods for marshaling
struct Quaternion_t4030073918;
struct Quaternion_t4030073918_marshaled_pinvoke;

extern "C" void Quaternion_t4030073918_marshal_pinvoke(const Quaternion_t4030073918& unmarshaled, Quaternion_t4030073918_marshaled_pinvoke& marshaled);
extern "C" void Quaternion_t4030073918_marshal_pinvoke_back(const Quaternion_t4030073918_marshaled_pinvoke& marshaled, Quaternion_t4030073918& unmarshaled);
extern "C" void Quaternion_t4030073918_marshal_pinvoke_cleanup(Quaternion_t4030073918_marshaled_pinvoke& marshaled);

// Methods for marshaling
struct Quaternion_t4030073918;
struct Quaternion_t4030073918_marshaled_com;

extern "C" void Quaternion_t4030073918_marshal_com(const Quaternion_t4030073918& unmarshaled, Quaternion_t4030073918_marshaled_com& marshaled);
extern "C" void Quaternion_t4030073918_marshal_com_back(const Quaternion_t4030073918_marshaled_com& marshaled, Quaternion_t4030073918& unmarshaled);
extern "C" void Quaternion_t4030073918_marshal_com_cleanup(Quaternion_t4030073918_marshaled_com& marshaled);
