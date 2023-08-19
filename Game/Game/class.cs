﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    #region 클래스
    // 사용자 정의 데이터 유형으로 속성과 함수가
    // 포함되어 있으며, 클래스를 통해 객체를 생성하여
    // 접근하고 사용할 수 있는 집합체입니다.
    public class Monster
    {
        // 접근 지정자란?
        // 클래스 내부에 포함되어 있는 속성에 접근 범위를
        // 제한하는 지정자입니다.

        // public : 클래스 내부와 클래스 외부 그리고 자기가 상속
        //          하는 클래스에서 접근을 허용하는 제한자입니다.

        // private : 클래스 내부에서만 접근이 가능하며, 클래스 외부와
        //           자기가 상속하는 클래스에서 접근을 허용하지 못하게 하는 제한자입니다.

        // protected : 클래스 내부와 자기가 상속하고 있는 클래스에서만 접근을 허용하며,
        //             클래스 외부에서는 접근을 허용하지 못하게 하는 제한자입니다.
        //             
        // 기본 접근 지정자 : private

        public int health;
        public char grade;

        // 바이트 패딩이란?
        // 멤버 변수를 메모리에서 CPUㄹ로 읽을 때 한 번에 
        // 읽을 수 있도록, 컴파일러가 레지스타의 블록에
        // 맞추어 바이트를 패딩해주는 최적화 작업입니다.
    }

    #endregion 
    internal class Class
    {
        static void Main {string[] args}
        #region 배열
        // 같은 자료형의 변수들로 이루어진 유한 집합입니다.
        // int[] array = new int[3];
        // 
        // 4 byte 4 byte 4 byte
        // [ 10 ] [ 20 ] [ 30 ]
        //   0      1      2
        // 배열의 경우 첫 번째 원소는 0붙 시작합니다.
        // array[0] = 10;
        // array[1] = 20;
        // array[2] = 30;
        //
        // 배열은 원하는 원소에 원하는 값을 저장할 수 있으며,
        // 배열의 크기는 컴파일이 되는 시점부터 고정된
        // 메모리 공간을 가지게 됩니다.
        #endregion

        #region 박싱과 언박싱
        //
        // // 박싱: 값 형식을 참조 형식을 참조 형식 
        // int x = 100;
        // 
        // object obj = x
        //
        // // 언박싱: 값 형식을 
        // int result = (int)obj
        // 
        //
        #endregion

        #region 클래스의 선언
        Monster monster = new Monster();
        monster.health = 100;

            #endregion
    }
}
