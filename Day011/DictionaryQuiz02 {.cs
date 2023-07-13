using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryQuiz02
{
    internal class Program
    {
        static string CheckLogin(Dictionary<string, string> userinfo, string id, string pwd) 
        {
            if (userinfo["userid"] == id && userinfo["password"] == pwd)
            {
                return "로그인에 성공하셨습니다.";
            }
            else 
            {
                return "로그인에 실패하셨습니다.";
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string,string> userinfo = new Dictionary<string, string> 
            {
                {"userid","admin"},
                {"password","1234"}
            };

            string id, pwd;
            Console.Write("아이디를 입력해주세요.");
            id = Console.ReadLine();
            Console.Write("비밀번호를 입력해주세요.");
            pwd = Console.ReadLine();
            Console.WriteLine(CheckLogin(userinfo, id, pwd));
        }
    }
}
