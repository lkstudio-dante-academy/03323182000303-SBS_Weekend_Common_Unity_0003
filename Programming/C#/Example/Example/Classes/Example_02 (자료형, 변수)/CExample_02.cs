using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 자료형이란?
 * - 데이터를 해석하는 방법을 의미한다. (즉, 동일한
 * 형태의 데이터라고 하더라도 자료형에 따라 처리되는
 * 방식이 달라진다는 것을 알 수 있다.)
 * 
 * 또한, 자료형은 데이터가 표현 할 수 있는 최대 범위를
 * 제한하는 역할도 수행한다. (즉, 제작하는 프로그램의
 * 목적에 맞게 적절한 자료형을 사용 할 필요가 있다.)
 * 
 * C# 의 자료형은 크게 값 형식 자료형과 참조 형식
 * 자료형을 구분된다.
 * 
 * C# 값 형식 자료형 종류
 * // 정수
 * - byte or sbyte : 1 바이트
 * - short or ushort : 2 바이트
 * - int or uint : 4 바이트
 * - long or ulong : 8 바이트
 * 
 * // 실수
 * - float : 4 바이트
 * - double : 8 바이트
 * - decimal : 16 바이트
 * 
 * // 논리
 * - bool : 1 바이트
 * 
 * // 문자
 * - char : 2 바이트
 * 
 * // 기타
 * - enum
 * - struct
 * 
 * C# 참조 형식 자료형 종류
 * - class
 * - object
 * - string
 * 
 * 변수란?
 * - 데이터를 저장하거나 읽어들일 수 있는 공간을 의미한다. (즉, 변수를
 * 활용하면 특정 데이터를 저장하거나 필요에 따라 재사용하는 것이
 * 가능하다.)
 * 
 * 변수는 메모리의 특정 영역에 생성 되기 때문에 해당 변수에 접근하기
 * 위한 방법이 필요하며 C# 은 변수 이름을 제공함으로서 변수에 접근하는
 * 것이 가능하다.
 * 
 * C# 변수 선언 방법
 * - 자료형 + 변수 이름
 * 
 * Ex)
 * int nVal = 0;
 * float fVal = 0.0f;
 * 
 * C# 변수 이름 작성 규칙
 * - C# 은 다국어를 지원하기 때문에 영어를 비롯한 여러 문자를 가지고
 * 변수 이름을 작성하는 것이 가능하다.
 * 
 * 단, 전통적으로 변수 이름에 사용 할 수 있는 문자의 종류는 알파벳
 * 대/소문자, _ (언더 스코어), 숫자 만을 사용하는 것이기 때문에
 * 가능하면 해당 문자만을 사용하는 것은 추천한다.
 * 
 * 단, 변수 이름의 첫 문자는 숫자를 사용하는 것이 불가능하기 때문에
 * 주의가 필요하며 알파벳 대문자와 소문자를 구분하기 때문에 같은
 * 단어라고 하더라도 대/소문자의 조합이 다르다면 다른 변수 이름으로
 * 구분된다.
 * 
 * Ex)
 * int nVal01 = 0;
 * int 01nVal = 0;      <- 컴파일 에러
 * 
 * float fFloat = 0.0f;
 * float ffloat = 0.0f;     <- 대/소문자가 구분되기 때문에 다른 변수
 * 
 * 상수란?
 * - 변수와 마찬가지로 데이터를 저장하거나 읽어들일 수 있는 공간을
 * 의미한다.
 * 
 * 단, 변수는 자유롭게 데이터를 저장 할 수 있는 반면 상수는 한번
 * 데이터가 저장되고 나면 더이상 변경하는 것은 불가능하다. (즉, 읽어
 * 들이는 것만 가능하다.)
 */
namespace Example.Classes.Example_02
{
    internal class CExample_02
    {
        /** 초기화 */
        public static void Start(string[] args)
        {
            byte nByteA = byte.MaxValue;
            sbyte nByteB = sbyte.MaxValue;

            short nShortA = short.MaxValue;
            ushort nShortB = ushort.MaxValue;

            int nIntA = int.MaxValue;
            int nIntB = int.MaxValue;

            long nLongA = long.MaxValue;
            ulong nLongB = long.MaxValue;

            Console.WriteLine("=====> 정수 <=====");
            Console.WriteLine("Byte : {0}, {1}", nByteA, nByteB);
            Console.WriteLine("Short : {0}, {1}", nShortA, nShortB);
            Console.WriteLine("Int : {0}, {1}", nIntA, nIntB);
            Console.WriteLine("Long : {0}, {1}", nLongA, nLongB);

            float fFloat = float.MaxValue;
            double dblDouble = double.MaxValue;
            decimal dmDecimal = decimal.MaxValue;

            Console.WriteLine("\n=====> 실수 <=====");
            Console.WriteLine("Float : {0}", fFloat);
            Console.WriteLine("Double : {0}", dblDouble);
            Console.WriteLine("Decimal : {0}", dmDecimal);
        }
    }
}
