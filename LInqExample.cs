using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsLINQ
{
    public partial class LInqExample : Form
    {

        private BindingList<Student> _student = new BindingList<Student>();
        private BindingList<Student> _studentCondition = new BindingList<Student>();

        List<Student> students = new List<Student>();

        public LInqExample()
        {
            InitializeComponent();

            dgvStudents.DataSource = _student;
            dgvConditon.DataSource = _studentCondition;
            InitStudents();
        }
        

        private int InputScore(string subject, string text)
        {
            int score = 0;

            // text 가 공백인지 판별 -> FormatException 처리

            if (string.IsNullOrWhiteSpace(text))
            {
                throw new FormatException("오류");
            }

            if (!int.TryParse(text, out score))
            {
                // test 가 숫자인지 판별 -> FormatException 처리
                throw new FormatException("오류");
            }
            // int.TryParse(text, out score)
            // if (!int.Parse(text, out score))

            if (!(0 <= score || score <= 100))
            {
                throw new InvalidScoreExceptioin("오류");
            }

            // score 값이 0 ~ 100 범위 밖에 있는지 판별 -> InvalidScoreExceptioin  처리

            return score;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                string name = txtName.Text.Trim();


                if (string.IsNullOrWhiteSpace(id))
                {
                    throw new FormatException("오류");
                }
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new FormatException("오류");
                }
                // ID 가 공백문자인지 판별 -> FormatException 처리

                // Name 이 공백문자인지 판별 -> FormatException 처리


                int kor = InputScore("국어", txtKor.Text.Trim());
                int math = InputScore("수학", txtMath.Text.Trim());
                int eng = InputScore("영어", txtEng.Text.Trim());

                //전부 올바른 값이면 Student 클래스에 멤버 추가
                Student stu = new Student(id, name, kor, math, eng);
                _student.Add(stu);

            }
            catch (InvalidScoreExceptioin ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void Clearinput()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtKor.Text = "";
            txtEng.Text = "";
            txtMath.Text = "";
            txtCID.Text = "";
            txtCName.Text = "";
            txtCKor.Text = "";
            txtCEng.Text = "";
            txtCMath.Text = "";
        }
        private void addResult2DGVcondition(IEnumerable<Student> _result)
        {
            foreach (var _results in _result)
            {
                _studentCondition.Add(_results);
            }
        }

        private void btnLinq_Click(object sender, EventArgs e)
        {
            string id = txtCID.Text.Trim();
            string name = txtCName.Text.Trim();
            string kor = txtCKor.Text.Trim();
            string math = txtCMath.Text.Trim();
            string eng = txtCEng.Text.Trim();

            IEnumerable<Student> results;
             

            if (!string.IsNullOrEmpty(id))
            {
                var _result = students
                    .Where( s => s.ID == id)
                    .Select(s => s);

                addResult2DGVcondition(_result);


                // LINQ 를 이용해서 id 가 동일한 멤버를 선택
                // dgvCondition(데이터그리드뷰) 에 추가
            }
            else if (!string.IsNullOrEmpty(name))
            {
                var _result = students
                    .Where(s => s.Name == name)
                    .Select(s => s);

                addResult2DGVcondition(_result);

                // LINQ 를 이용해서 name 이 동일한 멤버를 선택
                // dgvCondition(데이터그리드뷰) 에 추가
            }
            else if (!string.IsNullOrEmpty(kor))
            {
                var _result = students
                    .Where(s => s.Kor >= int.Parse(kor))
                    .Select(s => s);

                addResult2DGVcondition(_result);
                // LINQ 를 이용해서 kor 점수 >= 입력받은 점수 인 멤버를 선택
                // dgvCondition(데이터그리드뷰) 에 추가
            }
            else if (!string.IsNullOrEmpty(math))
            {
                var _result = students
                    .Where(s => s.Math >= int.Parse(math))
                    .Select(s => s);

                addResult2DGVcondition(_result);
                // LINQ 를 이용해서 math 점수 >= 입력받은 점수 인 멤버를 선택
                // dgvCondition(데이터그리드뷰) 에 추가
            }
            else if (!string.IsNullOrEmpty(eng))
            {
                var _result = students
                    .Where(s => s.Eng >= int.Parse(eng))
                    .Select(s => s);

                addResult2DGVcondition(_result);
                // LINQ 를 이용해서 eng 점수 >= 입력받은 점수 인 멤버를 선택
                // dgvCondition(데이터그리드뷰) 에 추가
            }
        }
        private void InitStudents()
        {
            Student stu = new Student("001", "김철수", 100, 90, 100);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("002", "이영희", 100, 100, 100);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("003", "한하나", 90, 80, 80);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("004", "남두리", 90, 40, 20);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("005", "오샛별", 80, 90, 40);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("006", "강나라", 80, 90, 100);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("007", "오나라", 70, 50, 10);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("008", "한빛나", 70, 0, 0);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("009", "나보람", 80, 100, 80);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("010", "이미나", 90, 90, 90);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("011", "정미숙", 60, 50, 50);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("012", "유동일", 60, 65, 70);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("013", "안동일", 60, 70, 80);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("014", "안장미", 50, 90, 70);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("015", "이백합", 30, 20, 40);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("020", "노마스", 40, 30, 20);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("021", "최동일", 45, 55, 30);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("022", "한준호", 55, 30, 10);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("023", "이선영", 95, 85, 95);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("024", "최우혁", 100, 100, 100);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("025", "한동욱", 90, 90, 90);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("030", "한이삭", 80, 70, 40);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("031", "이바로", 70, 70, 65);
            students.Add(stu);
            _student.Add(stu);
            stu = new Student("033", "나나미", 60, 30, 100);
            students.Add(stu);
            _student.Add(stu);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clearinput();
        }
    }
}
