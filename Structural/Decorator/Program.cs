using Decorator;

Console.WriteLine("Normal telebeler:");

ConcreteExam student = new ConcreteExam();
student.EnglishExam(86);
student.StatisticsExam(76);

Console.WriteLine("Onlar:");

CryingStudent cryingStudent = new(student);
cryingStudent.StatisticsExam(99);

SelfishStudent selfishStudent = new(student);
selfishStudent.EnglishExam(66);
