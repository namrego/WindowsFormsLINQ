using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WindowsFormsLINQ
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public int Kor { get; set; }
        public int Math { get; set; }
        public int Eng { get; set; }

        public Student(string id, string name, int kor, int math, int eng)
        {
            ID = id;
            Name = name;
            Kor = kor;
            Math = math;
            Eng = eng;
        }
    }

    // 사용자 예외처리 클래스 선언
    public class InvalidScoreExceptioin : Exception
    { 
        public InvalidScoreExceptioin() { }

        public InvalidScoreExceptioin(string message) : base(message) { }

        public InvalidScoreExceptioin(string message, Exception inner)
            : base(message, inner) { }
    }
}
