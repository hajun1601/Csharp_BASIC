String TenHocsinh = " Ngo Bao Long ";
String monhoc1 = "English 101";
String monhoc2 = "Algebra 101";
String monhoc3 = "Biology 101";
String monhoc5 = "Psychology 101";
String monhoc4 = "Computer";

int gradeA = 4;
int gradeB = 3;

int monhoc1Dat = gradeA;
int monhoc2Dat = gradeB;
int monhoc3Dat = gradeB;
int monhoc4Dat = gradeB;
int monhoc5Dat = gradeA;

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

Console.WriteLine("Sinh vien ten : " + TenHocsinh);
Console.WriteLine("Mon hoc \ttin chi\tCredit Hours");
Console.WriteLine($"{monhoc1}\t{monhoc1Dat}\t{course1Credit}");
Console.WriteLine($"{monhoc2}\t{monhoc2Dat}\t{course2Credit}");
Console.WriteLine($"{monhoc3}\t{monhoc3Dat}\t{course3Credit}");
Console.WriteLine($"{monhoc4}\t{monhoc4Dat}\t{course4Credit}");
Console.WriteLine($"{monhoc5}\t{monhoc5Dat}\t{course5Credit}");