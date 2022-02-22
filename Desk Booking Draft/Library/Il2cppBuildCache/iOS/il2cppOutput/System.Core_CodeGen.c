#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2 (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8 (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mB89E91246572F009281D79730950808F17C3F353 (void);
// 0x00000005 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000006 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000007 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000008 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x00000009 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::OrderBy(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000C System.Linq.IOrderedEnumerable`1<TSource> System.Linq.Enumerable::ThenBy(System.Linq.IOrderedEnumerable`1<TSource>,System.Func`2<TSource,TKey>)
// 0x0000000D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000000F TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000010 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000012 TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000013 TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000014 TSource System.Linq.Enumerable::ElementAt(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x00000015 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000016 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000017 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000018 System.Int32 System.Linq.Enumerable::Count(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000019 System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource)
// 0x0000001A System.Boolean System.Linq.Enumerable::Contains(System.Collections.Generic.IEnumerable`1<TSource>,TSource,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x0000001B System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x0000001C TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x0000001D System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x0000001E System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x0000001F System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000020 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000021 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000022 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000023 System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x00000024 System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000025 System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x00000026 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000027 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x00000028 System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000029 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x0000002A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000002B System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002C System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x0000002D System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x0000002E System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x0000002F System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000030 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000031 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000032 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x00000033 System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x00000034 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000035 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000036 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000037 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x00000038 System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x00000039 System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x0000003A System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000003B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000003C System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003D System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x0000003E System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x0000003F System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000040 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000041 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000042 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x00000043 System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x00000044 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000045 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000046 System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x00000047 System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x00000048 System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x00000049 TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x0000004A System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x0000004B System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x0000004C System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x0000004D System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x0000004E System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x0000004F TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x00000050 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x00000051 System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x00000052 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x00000053 System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x00000054 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x00000055 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x00000056 System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x00000057 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x00000058 TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000059 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x0000005A System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x0000005B System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x0000005C System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000005D System.Linq.IOrderedEnumerable`1<TElement> System.Linq.IOrderedEnumerable`1::CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000005E System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x0000005F System.Boolean System.Linq.Set`1::Add(TElement)
// 0x00000060 System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x00000061 System.Void System.Linq.Set`1::Resize()
// 0x00000062 System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x00000063 System.Collections.Generic.IEnumerator`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerator()
// 0x00000064 System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`1::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000065 System.Collections.IEnumerator System.Linq.OrderedEnumerable`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000066 System.Linq.IOrderedEnumerable`1<TElement> System.Linq.OrderedEnumerable`1::System.Linq.IOrderedEnumerable<TElement>.CreateOrderedEnumerable(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x00000067 System.Void System.Linq.OrderedEnumerable`1::.ctor()
// 0x00000068 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::.ctor(System.Int32)
// 0x00000069 System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.IDisposable.Dispose()
// 0x0000006A System.Boolean System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::MoveNext()
// 0x0000006B TElement System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.Generic.IEnumerator<TElement>.get_Current()
// 0x0000006C System.Void System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.Reset()
// 0x0000006D System.Object System.Linq.OrderedEnumerable`1/<GetEnumerator>d__1::System.Collections.IEnumerator.get_Current()
// 0x0000006E System.Void System.Linq.OrderedEnumerable`2::.ctor(System.Collections.Generic.IEnumerable`1<TElement>,System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean)
// 0x0000006F System.Linq.EnumerableSorter`1<TElement> System.Linq.OrderedEnumerable`2::GetEnumerableSorter(System.Linq.EnumerableSorter`1<TElement>)
// 0x00000070 System.Void System.Linq.EnumerableSorter`1::ComputeKeys(TElement[],System.Int32)
// 0x00000071 System.Int32 System.Linq.EnumerableSorter`1::CompareKeys(System.Int32,System.Int32)
// 0x00000072 System.Int32[] System.Linq.EnumerableSorter`1::Sort(TElement[],System.Int32)
// 0x00000073 System.Void System.Linq.EnumerableSorter`1::QuickSort(System.Int32[],System.Int32,System.Int32)
// 0x00000074 System.Void System.Linq.EnumerableSorter`1::.ctor()
// 0x00000075 System.Void System.Linq.EnumerableSorter`2::.ctor(System.Func`2<TElement,TKey>,System.Collections.Generic.IComparer`1<TKey>,System.Boolean,System.Linq.EnumerableSorter`1<TElement>)
// 0x00000076 System.Void System.Linq.EnumerableSorter`2::ComputeKeys(TElement[],System.Int32)
// 0x00000077 System.Int32 System.Linq.EnumerableSorter`2::CompareKeys(System.Int32,System.Int32)
// 0x00000078 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000079 TElement[] System.Linq.Buffer`1::ToArray()
// 0x0000007A System.Void System.Collections.Generic.HashSet`1::.ctor()
// 0x0000007B System.Void System.Collections.Generic.HashSet`1::.ctor(System.Collections.Generic.IEqualityComparer`1<T>)
// 0x0000007C System.Void System.Collections.Generic.HashSet`1::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x0000007D System.Void System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.Add(T)
// 0x0000007E System.Void System.Collections.Generic.HashSet`1::Clear()
// 0x0000007F System.Boolean System.Collections.Generic.HashSet`1::Contains(T)
// 0x00000080 System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32)
// 0x00000081 System.Boolean System.Collections.Generic.HashSet`1::Remove(T)
// 0x00000082 System.Int32 System.Collections.Generic.HashSet`1::get_Count()
// 0x00000083 System.Boolean System.Collections.Generic.HashSet`1::System.Collections.Generic.ICollection<T>.get_IsReadOnly()
// 0x00000084 System.Collections.Generic.HashSet`1/Enumerator<T> System.Collections.Generic.HashSet`1::GetEnumerator()
// 0x00000085 System.Collections.Generic.IEnumerator`1<T> System.Collections.Generic.HashSet`1::System.Collections.Generic.IEnumerable<T>.GetEnumerator()
// 0x00000086 System.Collections.IEnumerator System.Collections.Generic.HashSet`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000087 System.Void System.Collections.Generic.HashSet`1::GetObjectData(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
// 0x00000088 System.Void System.Collections.Generic.HashSet`1::OnDeserialization(System.Object)
// 0x00000089 System.Boolean System.Collections.Generic.HashSet`1::Add(T)
// 0x0000008A System.Void System.Collections.Generic.HashSet`1::CopyTo(T[])
// 0x0000008B System.Void System.Collections.Generic.HashSet`1::CopyTo(T[],System.Int32,System.Int32)
// 0x0000008C System.Void System.Collections.Generic.HashSet`1::Initialize(System.Int32)
// 0x0000008D System.Void System.Collections.Generic.HashSet`1::IncreaseCapacity()
// 0x0000008E System.Void System.Collections.Generic.HashSet`1::SetCapacity(System.Int32)
// 0x0000008F System.Boolean System.Collections.Generic.HashSet`1::AddIfNotPresent(T)
// 0x00000090 System.Int32 System.Collections.Generic.HashSet`1::InternalGetHashCode(T)
// 0x00000091 System.Void System.Collections.Generic.HashSet`1/Enumerator::.ctor(System.Collections.Generic.HashSet`1<T>)
// 0x00000092 System.Void System.Collections.Generic.HashSet`1/Enumerator::Dispose()
// 0x00000093 System.Boolean System.Collections.Generic.HashSet`1/Enumerator::MoveNext()
// 0x00000094 T System.Collections.Generic.HashSet`1/Enumerator::get_Current()
// 0x00000095 System.Object System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.get_Current()
// 0x00000096 System.Void System.Collections.Generic.HashSet`1/Enumerator::System.Collections.IEnumerator.Reset()
static Il2CppMethodPointer s_methodPointers[150] = 
{
	Error_ArgumentNull_m0EDA0D46D72CA692518E3E2EB75B48044D8FD41E,
	Error_ArgumentOutOfRange_m2EFB999454161A6B48F8DAC3753FDC190538F0F2,
	Error_MoreThanOneMatch_m4C4756AF34A76EF12F3B2B6D8C78DE547F0FBCF8,
	Error_NoElements_mB89E91246572F009281D79730950808F17C3F353,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[150] = 
{
	3471,
	3471,
	3588,
	3588,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[49] = 
{
	{ 0x02000004, { 73, 4 } },
	{ 0x02000005, { 77, 9 } },
	{ 0x02000006, { 88, 7 } },
	{ 0x02000007, { 97, 10 } },
	{ 0x02000008, { 109, 11 } },
	{ 0x02000009, { 123, 9 } },
	{ 0x0200000A, { 135, 12 } },
	{ 0x0200000B, { 150, 1 } },
	{ 0x0200000C, { 151, 2 } },
	{ 0x0200000D, { 153, 12 } },
	{ 0x0200000E, { 165, 11 } },
	{ 0x02000010, { 176, 8 } },
	{ 0x02000012, { 184, 3 } },
	{ 0x02000013, { 189, 5 } },
	{ 0x02000014, { 194, 7 } },
	{ 0x02000015, { 201, 3 } },
	{ 0x02000016, { 204, 7 } },
	{ 0x02000017, { 211, 4 } },
	{ 0x02000018, { 215, 21 } },
	{ 0x0200001A, { 236, 2 } },
	{ 0x06000005, { 0, 10 } },
	{ 0x06000006, { 10, 10 } },
	{ 0x06000007, { 20, 5 } },
	{ 0x06000008, { 25, 5 } },
	{ 0x06000009, { 30, 1 } },
	{ 0x0600000A, { 31, 2 } },
	{ 0x0600000B, { 33, 2 } },
	{ 0x0600000C, { 35, 1 } },
	{ 0x0600000D, { 36, 1 } },
	{ 0x0600000E, { 37, 2 } },
	{ 0x0600000F, { 39, 3 } },
	{ 0x06000010, { 42, 2 } },
	{ 0x06000011, { 44, 4 } },
	{ 0x06000012, { 48, 3 } },
	{ 0x06000013, { 51, 3 } },
	{ 0x06000014, { 54, 3 } },
	{ 0x06000015, { 57, 1 } },
	{ 0x06000016, { 58, 3 } },
	{ 0x06000017, { 61, 2 } },
	{ 0x06000018, { 63, 3 } },
	{ 0x06000019, { 66, 2 } },
	{ 0x0600001A, { 68, 5 } },
	{ 0x0600002A, { 86, 2 } },
	{ 0x0600002F, { 95, 2 } },
	{ 0x06000034, { 107, 2 } },
	{ 0x0600003A, { 120, 3 } },
	{ 0x0600003F, { 132, 3 } },
	{ 0x06000044, { 147, 3 } },
	{ 0x06000066, { 187, 2 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[238] = 
{
	{ (Il2CppRGCTXDataType)2, 1743 },
	{ (Il2CppRGCTXDataType)3, 6254 },
	{ (Il2CppRGCTXDataType)2, 2988 },
	{ (Il2CppRGCTXDataType)2, 2540 },
	{ (Il2CppRGCTXDataType)3, 12296 },
	{ (Il2CppRGCTXDataType)2, 1854 },
	{ (Il2CppRGCTXDataType)2, 2547 },
	{ (Il2CppRGCTXDataType)3, 12335 },
	{ (Il2CppRGCTXDataType)2, 2542 },
	{ (Il2CppRGCTXDataType)3, 12303 },
	{ (Il2CppRGCTXDataType)2, 1744 },
	{ (Il2CppRGCTXDataType)3, 6255 },
	{ (Il2CppRGCTXDataType)2, 3010 },
	{ (Il2CppRGCTXDataType)2, 2549 },
	{ (Il2CppRGCTXDataType)3, 12342 },
	{ (Il2CppRGCTXDataType)2, 1873 },
	{ (Il2CppRGCTXDataType)2, 2557 },
	{ (Il2CppRGCTXDataType)3, 12399 },
	{ (Il2CppRGCTXDataType)2, 2553 },
	{ (Il2CppRGCTXDataType)3, 12368 },
	{ (Il2CppRGCTXDataType)2, 611 },
	{ (Il2CppRGCTXDataType)3, 56 },
	{ (Il2CppRGCTXDataType)3, 57 },
	{ (Il2CppRGCTXDataType)2, 1133 },
	{ (Il2CppRGCTXDataType)3, 4723 },
	{ (Il2CppRGCTXDataType)2, 612 },
	{ (Il2CppRGCTXDataType)3, 68 },
	{ (Il2CppRGCTXDataType)3, 69 },
	{ (Il2CppRGCTXDataType)2, 1143 },
	{ (Il2CppRGCTXDataType)3, 4727 },
	{ (Il2CppRGCTXDataType)3, 14505 },
	{ (Il2CppRGCTXDataType)2, 617 },
	{ (Il2CppRGCTXDataType)3, 102 },
	{ (Il2CppRGCTXDataType)2, 2254 },
	{ (Il2CppRGCTXDataType)3, 9907 },
	{ (Il2CppRGCTXDataType)3, 5202 },
	{ (Il2CppRGCTXDataType)3, 14477 },
	{ (Il2CppRGCTXDataType)2, 613 },
	{ (Il2CppRGCTXDataType)3, 74 },
	{ (Il2CppRGCTXDataType)2, 721 },
	{ (Il2CppRGCTXDataType)3, 896 },
	{ (Il2CppRGCTXDataType)3, 897 },
	{ (Il2CppRGCTXDataType)2, 1855 },
	{ (Il2CppRGCTXDataType)3, 6663 },
	{ (Il2CppRGCTXDataType)2, 1679 },
	{ (Il2CppRGCTXDataType)2, 1276 },
	{ (Il2CppRGCTXDataType)2, 1373 },
	{ (Il2CppRGCTXDataType)2, 1455 },
	{ (Il2CppRGCTXDataType)2, 1374 },
	{ (Il2CppRGCTXDataType)2, 1456 },
	{ (Il2CppRGCTXDataType)3, 4725 },
	{ (Il2CppRGCTXDataType)2, 1375 },
	{ (Il2CppRGCTXDataType)2, 1457 },
	{ (Il2CppRGCTXDataType)3, 4726 },
	{ (Il2CppRGCTXDataType)2, 1678 },
	{ (Il2CppRGCTXDataType)2, 1372 },
	{ (Il2CppRGCTXDataType)2, 1454 },
	{ (Il2CppRGCTXDataType)2, 1362 },
	{ (Il2CppRGCTXDataType)2, 1363 },
	{ (Il2CppRGCTXDataType)2, 1451 },
	{ (Il2CppRGCTXDataType)3, 4722 },
	{ (Il2CppRGCTXDataType)2, 1275 },
	{ (Il2CppRGCTXDataType)2, 1370 },
	{ (Il2CppRGCTXDataType)2, 1371 },
	{ (Il2CppRGCTXDataType)2, 1453 },
	{ (Il2CppRGCTXDataType)3, 4724 },
	{ (Il2CppRGCTXDataType)2, 1274 },
	{ (Il2CppRGCTXDataType)3, 14464 },
	{ (Il2CppRGCTXDataType)3, 4139 },
	{ (Il2CppRGCTXDataType)2, 1010 },
	{ (Il2CppRGCTXDataType)2, 1365 },
	{ (Il2CppRGCTXDataType)2, 1452 },
	{ (Il2CppRGCTXDataType)2, 1518 },
	{ (Il2CppRGCTXDataType)3, 6256 },
	{ (Il2CppRGCTXDataType)3, 6258 },
	{ (Il2CppRGCTXDataType)2, 419 },
	{ (Il2CppRGCTXDataType)3, 6257 },
	{ (Il2CppRGCTXDataType)3, 6266 },
	{ (Il2CppRGCTXDataType)2, 1747 },
	{ (Il2CppRGCTXDataType)2, 2543 },
	{ (Il2CppRGCTXDataType)3, 12304 },
	{ (Il2CppRGCTXDataType)3, 6267 },
	{ (Il2CppRGCTXDataType)2, 1416 },
	{ (Il2CppRGCTXDataType)2, 1480 },
	{ (Il2CppRGCTXDataType)3, 4734 },
	{ (Il2CppRGCTXDataType)3, 14450 },
	{ (Il2CppRGCTXDataType)2, 2554 },
	{ (Il2CppRGCTXDataType)3, 12369 },
	{ (Il2CppRGCTXDataType)3, 6259 },
	{ (Il2CppRGCTXDataType)2, 1746 },
	{ (Il2CppRGCTXDataType)2, 2541 },
	{ (Il2CppRGCTXDataType)3, 12297 },
	{ (Il2CppRGCTXDataType)3, 4733 },
	{ (Il2CppRGCTXDataType)3, 6260 },
	{ (Il2CppRGCTXDataType)3, 14449 },
	{ (Il2CppRGCTXDataType)2, 2550 },
	{ (Il2CppRGCTXDataType)3, 12343 },
	{ (Il2CppRGCTXDataType)3, 6273 },
	{ (Il2CppRGCTXDataType)2, 1748 },
	{ (Il2CppRGCTXDataType)2, 2548 },
	{ (Il2CppRGCTXDataType)3, 12336 },
	{ (Il2CppRGCTXDataType)3, 6713 },
	{ (Il2CppRGCTXDataType)3, 3379 },
	{ (Il2CppRGCTXDataType)3, 4735 },
	{ (Il2CppRGCTXDataType)3, 3378 },
	{ (Il2CppRGCTXDataType)3, 6274 },
	{ (Il2CppRGCTXDataType)3, 14451 },
	{ (Il2CppRGCTXDataType)2, 2558 },
	{ (Il2CppRGCTXDataType)3, 12400 },
	{ (Il2CppRGCTXDataType)3, 6287 },
	{ (Il2CppRGCTXDataType)2, 1750 },
	{ (Il2CppRGCTXDataType)2, 2556 },
	{ (Il2CppRGCTXDataType)3, 12371 },
	{ (Il2CppRGCTXDataType)3, 6288 },
	{ (Il2CppRGCTXDataType)2, 1419 },
	{ (Il2CppRGCTXDataType)2, 1483 },
	{ (Il2CppRGCTXDataType)3, 4739 },
	{ (Il2CppRGCTXDataType)3, 4738 },
	{ (Il2CppRGCTXDataType)2, 2545 },
	{ (Il2CppRGCTXDataType)3, 12306 },
	{ (Il2CppRGCTXDataType)3, 14458 },
	{ (Il2CppRGCTXDataType)2, 2555 },
	{ (Il2CppRGCTXDataType)3, 12370 },
	{ (Il2CppRGCTXDataType)3, 6280 },
	{ (Il2CppRGCTXDataType)2, 1749 },
	{ (Il2CppRGCTXDataType)2, 2552 },
	{ (Il2CppRGCTXDataType)3, 12345 },
	{ (Il2CppRGCTXDataType)3, 4737 },
	{ (Il2CppRGCTXDataType)3, 4736 },
	{ (Il2CppRGCTXDataType)3, 6281 },
	{ (Il2CppRGCTXDataType)2, 2544 },
	{ (Il2CppRGCTXDataType)3, 12305 },
	{ (Il2CppRGCTXDataType)3, 14457 },
	{ (Il2CppRGCTXDataType)2, 2551 },
	{ (Il2CppRGCTXDataType)3, 12344 },
	{ (Il2CppRGCTXDataType)3, 6294 },
	{ (Il2CppRGCTXDataType)2, 1751 },
	{ (Il2CppRGCTXDataType)2, 2560 },
	{ (Il2CppRGCTXDataType)3, 12402 },
	{ (Il2CppRGCTXDataType)3, 6714 },
	{ (Il2CppRGCTXDataType)3, 3381 },
	{ (Il2CppRGCTXDataType)3, 4741 },
	{ (Il2CppRGCTXDataType)3, 4740 },
	{ (Il2CppRGCTXDataType)3, 3380 },
	{ (Il2CppRGCTXDataType)3, 6295 },
	{ (Il2CppRGCTXDataType)2, 2546 },
	{ (Il2CppRGCTXDataType)3, 12307 },
	{ (Il2CppRGCTXDataType)3, 14459 },
	{ (Il2CppRGCTXDataType)2, 2559 },
	{ (Il2CppRGCTXDataType)3, 12401 },
	{ (Il2CppRGCTXDataType)3, 4730 },
	{ (Il2CppRGCTXDataType)3, 4731 },
	{ (Il2CppRGCTXDataType)3, 4742 },
	{ (Il2CppRGCTXDataType)3, 105 },
	{ (Il2CppRGCTXDataType)3, 104 },
	{ (Il2CppRGCTXDataType)2, 1411 },
	{ (Il2CppRGCTXDataType)2, 1476 },
	{ (Il2CppRGCTXDataType)3, 4732 },
	{ (Il2CppRGCTXDataType)2, 1425 },
	{ (Il2CppRGCTXDataType)2, 1493 },
	{ (Il2CppRGCTXDataType)3, 107 },
	{ (Il2CppRGCTXDataType)2, 545 },
	{ (Il2CppRGCTXDataType)2, 618 },
	{ (Il2CppRGCTXDataType)3, 103 },
	{ (Il2CppRGCTXDataType)3, 106 },
	{ (Il2CppRGCTXDataType)3, 76 },
	{ (Il2CppRGCTXDataType)2, 2344 },
	{ (Il2CppRGCTXDataType)3, 11199 },
	{ (Il2CppRGCTXDataType)2, 1408 },
	{ (Il2CppRGCTXDataType)2, 1474 },
	{ (Il2CppRGCTXDataType)3, 11200 },
	{ (Il2CppRGCTXDataType)3, 78 },
	{ (Il2CppRGCTXDataType)2, 416 },
	{ (Il2CppRGCTXDataType)2, 614 },
	{ (Il2CppRGCTXDataType)3, 75 },
	{ (Il2CppRGCTXDataType)3, 77 },
	{ (Il2CppRGCTXDataType)3, 4172 },
	{ (Il2CppRGCTXDataType)2, 1024 },
	{ (Il2CppRGCTXDataType)2, 3094 },
	{ (Il2CppRGCTXDataType)3, 11196 },
	{ (Il2CppRGCTXDataType)3, 11197 },
	{ (Il2CppRGCTXDataType)2, 1532 },
	{ (Il2CppRGCTXDataType)3, 11198 },
	{ (Il2CppRGCTXDataType)2, 354 },
	{ (Il2CppRGCTXDataType)2, 615 },
	{ (Il2CppRGCTXDataType)3, 88 },
	{ (Il2CppRGCTXDataType)3, 9894 },
	{ (Il2CppRGCTXDataType)2, 2255 },
	{ (Il2CppRGCTXDataType)3, 9908 },
	{ (Il2CppRGCTXDataType)2, 722 },
	{ (Il2CppRGCTXDataType)3, 898 },
	{ (Il2CppRGCTXDataType)3, 9900 },
	{ (Il2CppRGCTXDataType)3, 3354 },
	{ (Il2CppRGCTXDataType)2, 449 },
	{ (Il2CppRGCTXDataType)3, 9895 },
	{ (Il2CppRGCTXDataType)2, 2251 },
	{ (Il2CppRGCTXDataType)3, 934 },
	{ (Il2CppRGCTXDataType)2, 736 },
	{ (Il2CppRGCTXDataType)2, 986 },
	{ (Il2CppRGCTXDataType)3, 3360 },
	{ (Il2CppRGCTXDataType)3, 9896 },
	{ (Il2CppRGCTXDataType)3, 3349 },
	{ (Il2CppRGCTXDataType)3, 3350 },
	{ (Il2CppRGCTXDataType)3, 3348 },
	{ (Il2CppRGCTXDataType)3, 3351 },
	{ (Il2CppRGCTXDataType)2, 982 },
	{ (Il2CppRGCTXDataType)2, 3057 },
	{ (Il2CppRGCTXDataType)3, 4729 },
	{ (Il2CppRGCTXDataType)3, 3353 },
	{ (Il2CppRGCTXDataType)2, 1348 },
	{ (Il2CppRGCTXDataType)3, 3352 },
	{ (Il2CppRGCTXDataType)2, 1277 },
	{ (Il2CppRGCTXDataType)2, 3013 },
	{ (Il2CppRGCTXDataType)2, 1388 },
	{ (Il2CppRGCTXDataType)2, 1458 },
	{ (Il2CppRGCTXDataType)3, 4155 },
	{ (Il2CppRGCTXDataType)2, 1018 },
	{ (Il2CppRGCTXDataType)3, 5064 },
	{ (Il2CppRGCTXDataType)3, 5065 },
	{ (Il2CppRGCTXDataType)3, 5070 },
	{ (Il2CppRGCTXDataType)2, 1527 },
	{ (Il2CppRGCTXDataType)3, 5067 },
	{ (Il2CppRGCTXDataType)3, 14828 },
	{ (Il2CppRGCTXDataType)2, 988 },
	{ (Il2CppRGCTXDataType)3, 3372 },
	{ (Il2CppRGCTXDataType)1, 1345 },
	{ (Il2CppRGCTXDataType)2, 3025 },
	{ (Il2CppRGCTXDataType)3, 5066 },
	{ (Il2CppRGCTXDataType)1, 3025 },
	{ (Il2CppRGCTXDataType)1, 1527 },
	{ (Il2CppRGCTXDataType)2, 3092 },
	{ (Il2CppRGCTXDataType)2, 3025 },
	{ (Il2CppRGCTXDataType)3, 5071 },
	{ (Il2CppRGCTXDataType)3, 5069 },
	{ (Il2CppRGCTXDataType)3, 5068 },
	{ (Il2CppRGCTXDataType)2, 294 },
	{ (Il2CppRGCTXDataType)3, 3382 },
	{ (Il2CppRGCTXDataType)2, 429 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	150,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	49,
	s_rgctxIndices,
	238,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
