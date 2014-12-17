using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RGR_semester_3
{
    public enum Faculty { UNDEFINED, FIOT, FEL, FPM, TEF, RTF, FMF, HTF, FSP, FMM, FL, FEA, FBT, FAKS, IFF, PBF, ZF };

    [Serializable()]
    public class LoginData
    {
        private string login;
        private string password;

        public LoginData(string loginStr, string passwordStr)
        {
            switch (setLogin(loginStr))
            {
                case 0: Console.WriteLine("OK"); break;
                default: Console.WriteLine("Error"); break;
            }
            switch (setPassword(passwordStr))
            {
                case 0: Console.WriteLine("OK"); break;
                default: Console.WriteLine("Error"); break;
            }
        }

        public string getLogin()
        {
            return login;
        }
        public string getPassword()
        {
            return password;
        }

        public int setPassword(string passStr)
        {
            int status = checkPassword(passStr);
            if (status == 0)
                password = passStr;

            return status;
        }
        public int setLogin(string loginStr)
        {
            int status = checkLogin(loginStr);
            if (status == 0)
                login = loginStr;

            return status;
        }

        private static int checkPassword(string passStr)
        {
            // TODO: check password string
            return 0;
        }
        private static int checkLogin(string passStr)
        {
            //TODO: check login string
            return 0;
        }
    }
    public class Account
    {
        private LoginData loginData;
        private string name;
        private string surname;

        public Account(string nameStr, string surnameStr, LoginData loginDataInst)
        {
            loginData = loginDataInst;
            switch (setName(nameStr))
            {
                case 0: Console.WriteLine("OK"); break;
                default: Console.WriteLine("Error"); break;
            }
            switch (setSurname(surnameStr))
            {
                case 0: Console.WriteLine("OK"); break;
                default: Console.WriteLine("Error"); break;
            }
        }

        public string getName()
        {
            return name;
        }
        public string getSurname()
        {
            return surname;
        }

        public int setName(string nameStr)
        {
            int status = checkString(nameStr);
            if (status == 0)
                name = nameStr;

            return status;
        }
        public int setSurname(string surnameStr)
        {
            int status = checkString(surnameStr);
            if (status == 0)
                surname = surnameStr;

            return status;
        }
        public LoginData getLoginData()
        {
            return loginData;
        }

        private static int checkString(string str)
        {
            //TODO: check string
            return 0;
        }
    }
    public class StudentAccount : Account
    {
        Faculty faculty;
        int recordBookNum;
        int specialityCode;

        public StudentAccount(string name, string surname, LoginData loginData, Faculty facultyVal,
        int recordBookVal, int specialityCodeVal)
            : base(name, surname, loginData)
        {
            faculty = facultyVal;
            setRecordBookNum(recordBookVal);
            setSpecialityCodeVal(specialityCodeVal);
        }

        public Faculty getFaculty()
        {
            return faculty;
        }
        public int getRecordBookNum()
        {
            return recordBookNum;
        }
        public int getSpecialityCode()
        {
            return specialityCode;
        }
        public int setRecordBookNum(int recordBookVal)
        {
            int status = checkRecordBookNum(recordBookVal);
            if (status == 0)
                recordBookNum = recordBookVal;
            return status;
        }
        public int setSpecialityCodeVal(int specialityCodeVal)
        {
            int status = checkSpecialityCode(specialityCodeVal);
            if (status == 0)
                specialityCode = specialityCodeVal;
            return status;
        }
        private static int checkRecordBookNum(int recordBookVal)
        {
            // TODO: check record book number
            return 0;
        }
        private static int checkSpecialityCode(int specialityCodeVal)
        {
            // TODO: check spec. code
            return 0;
        }
    }
    public class InstructorAccount : Account
    {
        InstructorAccount(string name, string surname, LoginData loginData)
            : base(name, surname, loginData)
        { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            LoginData a = new LoginData("dmitry", "1234");
            StudentAccount d = new StudentAccount("Dmitry", "Sinyukov", a, Faculty.FIOT, 3418, 23234);

            Console.WriteLine("Name, surname:");
            Console.WriteLine(d.getName() + " " + d.getSurname());
            Console.WriteLine("Login, password:");
            Console.WriteLine(d.getLoginData().getLogin() + " " + d.getLoginData().getPassword());
            Console.WriteLine(d.getFaculty() + " " + d.getRecordBookNum() + " " + d.getSpecialityCode());
        }
    }
}