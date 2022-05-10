using System;

namespace Cs_2report
{
    class Program
    {
        static void _compare(int a, int b){
            if (b == 0){            //가위
                if(a==1){Console.WriteLine("승리입니다.");}
                if(a==2){Console.WriteLine("패배입니다.");}
            }
            else if(b == 1){        //바위
                if(a==0){Console.WriteLine("패배입니다.");}
                if(a==2){Console.WriteLine("승리입니다.");}
            }
            else{                    //보
                if(a==0){Console.WriteLine("승리입니다.");}
                if(a==1){Console.WriteLine("패배입니다.");}
            }

            if (a == b) {Console.WriteLine("동점입니다.");}
            if (a == 3) {Environment.Exit(0);}                 //종료 입력시 탈출

        }

        static void Main(string[] args)
        {
            // 1. 로또 번호 만들기 [random class / 반복문 / 배열 ]
            //     1. 1~45 사이 번호를 가진다
            //     2. 번호의 갯수 6개
            //     3. 로또 번호 6개는 한번에 출력
            //     4. 중복허용x

            //변수 선언, 초기화
            int[] num = new int[6];
            int rdval, i = 0, minwoo = -1; //rdval -> 랜덤변수, i는 -> 카운팅 변수, minwoo -> indexof 비교
            Random rd = new Random();      //instance 방식으로 rd 메모리할당

            while (i < 6)             
            {
                rdval = rd.Next(1, 46);             
                if (Array.IndexOf(num, rdval) == minwoo) // 비교문은 앞에 / 상수는 뒤에
                {                                  
                    num[i] = rdval;                //배열에 추가
                    i++;
                }
            }

            Console.Write("로또 당첨 번호는 :");
            Array.Sort(num);                       //정렬
            for (i = 0; i < num.Length; i++)       //출력
            {                                           
                Console.Write("{0,3}", num[i]);
                if (i == num.Length - 1)
                {                                  //마지막단에는 띄어쓰기
                    Console.Write("\n", num[i]);
                }
            }

            // 1. 가위바위보 게임
            //     1. 사용자 가위바위보 입력
            //     2. 컴퓨터는 랜덤 감맘보 고
            //     3. 승패를 콘솔창에 출력

            //변수선언 
            string[] rps = { "가위", "바위", "보", "종료" }; //Rock Paper Scissors
            string rorps;
            while (true)
            {
                int ii = rd.Next(3);
                rorps = rps[ii];                          //감맘보 랜덤
                Console.Write("'가위', '바위', '보' or '종료'를 입력하세요 : ");
                string _ent = Console.ReadLine();

                int per = Array.IndexOf(rps, _ent);         //인간의 감맘보
                int ro = Array.IndexOf(rps, rorps);         //로봇의 감맘보

                if (per != -1){
                    _compare(per,ro);
                }
            }


        }
    }
}



