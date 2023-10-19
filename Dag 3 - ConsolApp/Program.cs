string[,] nameList = {
    {"John", "23"},
    {"Casper", "32"},
    {"Jenny", "29"},
    {"Kim", "24"}
};



for (int i = 0; i < nameList.GetLength(0); i++){
    for (int j = 0; j < nameList.GetLength(1); j++){
        System.Console.WriteLine(nameList[i, j] + " ");
    }
    System.Console.WriteLine();
}
