// See https://aka.ms/new-console-template for more information

//====================================================================================
//Task no.1
//======

//Console.WriteLine("please insert the number of the students : ");
////store the inputs in a variable with int typed
//List<string> namesList = new List<string>();
//string higherGrade = "";
//string loweerGrade = "";
//List<int> gradesList = new List<int>();
//string studentsNum = Console.ReadLine();
//int operationLength = int.Parse(studentsNum);
// int higherGradevalue = 0;
// int lowerGradevalue = 0;
//for (int i = 0; i < operationLength ; i++)
//{
//Console.WriteLine("then please insert the name of the student  : ");
//string studentName = Console.ReadLine();
//Console.WriteLine(" and his grade : ");
//string studentGrade = Console.ReadLine();
//namesList.Add(studentName);
//gradesList.Add(int.Parse(studentGrade));

//    if (i < 1)
//    {
//        lowerGradevalue = gradesList[0];
//        higherGradevalue = gradesList[0];

//        continue;
//    }

//        //=================================

//        //we consider the current name has the higher degree

//        bool isHigher = higherGradevalue < gradesList[i];
//    if (isHigher)
//    {
//        higherGradevalue = gradesList[i];
//        higherGrade = namesList[i];

//    }
//    else if (!isHigher)

//    {
//        lowerGradevalue = gradesList[i];
//        loweerGrade = namesList[i];

//    }
//    if (i == operationLength - 1)
//    {
//        Console.WriteLine($"the student of the higher grade is : {higherGrade} , the lower is : {loweerGrade}");
//    }
//}



//================================================================
//Task no.2


//int[] array = new int[3];
//Console.WriteLine("please insert  number 1 : ");
//int num1 = int.Parse(Console.ReadLine());
//array[0] = num1;
//Console.WriteLine("please insert  number 2 : ");
//int num2 = int.Parse(Console.ReadLine());
//array[1] = num2;
//Console.WriteLine("please insert  number 3 : ");
//int num3 = int.Parse(Console.ReadLine());
//array[2] = num3;
//int empty = 0;
//int middle = array[1]; 

//if (array[0] > array[2])
//{
//    empty = array[2];
//    array[2] = array[0];
//    array[0] = empty;
//}
//if (middle > array[2])
//{
//    empty = array[2];
//    array[2] = middle;
//    array[1] = empty;
//}
//else if (middle < array[0])
//{
//    empty = array[0];
//    array[0] = middle;
//    array[1] = empty;
//}


//Console.WriteLine(String.Join("," , array));






//===============================================

//class Counter { 


//Task no. 4 :
//static int i = 0;
//static int[] nums = new int[4];
//static List<int> repeatedNums = new List<int>();
//    static void gettingRepeatedNums(int c ,int j)
//    {

//        if (j < 0) return;

//            if (c == nums[j])
//            {
//                repeatedNums.Add(c);
//                return;
//            }
//            j--;
//        gettingRepeatedNums(c, j);



//    }


//    static void checkRepeatedNum()
//    {

//        if (i < 4)
//        {
//            Console.WriteLine("please insert a number  : ");
//            int c = int.Parse(Console.ReadLine());
//            if (i > 0)
//            {

//                gettingRepeatedNums(c, i-1); 


//            }
//            nums[i] = c;
//            i++;
//        }
//        if (i == 4) return;
//        checkRepeatedNum();
//    }

//    static void Main(string[] args)
//    {
//    checkRepeatedNum();
//        Console.WriteLine(String.Join(",", repeatedNums));
//    }
//}




//===============================
//Task 3


//string statement = "";
//string[] array = new string[3];
//Console.WriteLine("please insert  word 1 : ");
//string str1 = Console.ReadLine();
//array[0] = str1;


//Console.WriteLine("please insert  word 2 : ");
//string str2 = Console.ReadLine();
//array[1] = str2;


//Console.WriteLine("please insert  word 3 : ");
//string str3 = Console.ReadLine();
//array[2] = str3;

//if (String.Compare(str1,str2,true) <= 0 && String.Compare(str2, str3, true) <= 0)
//{
//    statement = "the words are ascending";
//}
//else
//{
//    statement = "the words are not ascending";

//}

