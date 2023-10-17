// initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

Console.WriteLine($"Student\t\tGrade");
int totalSophiaGrade = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
double averageSophiaGrade = (double)totalSophiaGrade / currentAssignments;
Console.WriteLine($"Sophia scored:\t\t{averageSophiaGrade}\tA");

int totalNicolasGrade = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
double averageNicolasGrade = (double)totalNicolasGrade / currentAssignments;
Console.WriteLine($"Nicolas scored:\t\t{averageNicolasGrade}\tB");

int totalZahirahGrade = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
double averageZahirahGrade = (double)totalZahirahGrade / currentAssignments;
Console.WriteLine($"Zahirah scored:\t\t{averageZahirahGrade}\tB");

int totalJeongGrade = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
double averageJeongGrade = (double)totalJeongGrade / currentAssignments;
Console.WriteLine($"Jeong scored:\t\t{averageJeongGrade}\tA");

int totalGradeClass = totalJeongGrade + totalNicolasGrade + totalSophiaGrade + totalZahirahGrade;
double averageGradeClass = (double)totalGradeClass / (currentAssignments * 4);
Console.WriteLine($"The class scored an average grade of:\t\t{averageGradeClass}\tB+");
