// System.Console.WriteLine("Signed integral types:");

// System.Console.WriteLine($"sbyte\t: {sbyte.MinValue} to {sbyte.MaxValue}");
// System.Console.WriteLine($"short\t: {short.MinValue} to {short.MaxValue}");
// System.Console.WriteLine($"int\t: {int.MinValue} to {int.MaxValue}");
// System.Console.WriteLine($"long\t: {long.MinValue} to {long.MaxValue}");

// System.Console.WriteLine("");

// System.Console.WriteLine("Unsigned integral types:");
// System.Console.WriteLine($"byte\t: {byte.MinValue} to {byte.MaxValue}");
// System.Console.WriteLine($"ushort\t: {ushort.MinValue} to {ushort.MaxValue}");
// System.Console.WriteLine($"uint\t: {uint.MinValue} to {uint.MaxValue}");
// System.Console.WriteLine($"ulong\t: {ulong.MinValue} to {ulong.MaxValue}");



// System.Console.WriteLine("Signed floating point types:");
// System.Console.WriteLine($"float\t: {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// System.Console.WriteLine($"double\t: {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// System.Console.WriteLine($"decimal\t: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// int[] data = new int[3];




// int first = 2;
// string seccond = "4";
// int result = first + seccond;
// System.Console.WriteLine(result);


// int myInt = 3;
// System.Console.WriteLine($"int:\t{myInt}");

// decimal myDecimal = myInt;
// System.Console.WriteLine($"decimal:\t{myDecimal}");


// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);



// string value = "bob";
// int result = 0;
// if (int.TryParse(value, out result)){
//     System.Console.WriteLine($"Measurement: {result}");
// } else {
//     System.Console.WriteLine("Unable to report the measurement.");
// }
// string print = result > 0 ? $"Measurement (w/ offset): {50 + result}" : "";
// System.Console.WriteLine(print);



// string [] values = {"12.3", "45", "ABC", "11", "DEF"};
// decimal total = 0m;
// string message = "";
// foreach (string værdi in values) {
//     decimal number;
//     if(decimal.TryParse(værdi, out number)){
//         total += number;
//     } else {
//         message += værdi;
//     }
// }





// System.Console.WriteLine($"Message: {message}");
// System.Console.WriteLine($"Total: {total}");



// int value1 = 12;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// int result1 = value1 / Convert.ToInt32(value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");
// // Your code here to set result2
// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / (float)value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


// string[] pallets = {"B14", "A11", "B12", "A13"};

// System.Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (string pallet in pallets){
//     System.Console.WriteLine($"--{pallet}");
// }



// System.Console.WriteLine("");
// System.Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach(string pallet in pallets){
//     System.Console.WriteLine($"-- {pallet}");
// }


// string[] pallets = {"B14", "A11", "B12", "A13"};
// System.Console.WriteLine("");

// Array.Clear(pallets, 0, 2);
// System.Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (string pallet in pallets){
//     System.Console.WriteLine($"-- {pallet}");
// }


// System.Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// System.Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (string pallet in pallets){
//     System.Console.WriteLine($"-- {pallet}");
// }


// System.Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// System.Console.WriteLine($"Resizing 3 .. count: {pallets.Length}");

// foreach (string pallet in pallets){
//     System.Console.WriteLine($"-- {pallet}");
// }


// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// string result = String.Join(",", valueArray);
// System.Console.WriteLine(result);

// string[] items = result.Split(',');
// foreach (string item in items){
//     System.Console.WriteLine(item);
// }


// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] words = pangram.Split(" ");
// Array.Reverse(words);
// string result2 = String.Join(" ", words);
// char[] letters = result2.ToCharArray();
// Array.Reverse(letters);
// string result = String.Join("", letters);
// System.Console.WriteLine(result);
// string[] words = pangram.Split(" ");


// foreach (string word in words){
//     char[] letter = word.ToCharArray();
//     Array.Reverse(letter);
//     string joinInReverse = String.Join("", letter);
//     //string reverseSentence = String.Join(" ", joinInReverse);
//     words = letter.ToString();
// }

// string result = String.Join(" ", words);
// System.Console.WriteLine(pangram);



// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// string[] orderIDs = orderStream.Split(",");
// Array.Sort(orderIDs);

// foreach (string orderID in orderIDs){
//     //char[] orderNumber = orderID.ToCharArray();
//     if (orderID.Length != 4){

//     System.Console.WriteLine($"{orderID}\t- Error");
//     }else {

//     System.Console.WriteLine(orderID);
//     }

// }


// decimal price = 123.45m;
// int discount = 50;
// System.Console.WriteLine($"Price: {price:c} (Save {discount:c})");


// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");


// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);

// yourDiscount += $"A discount of {((price - salePrice) / price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);



// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");

// Console.WriteLine($"   Shares: {productShares:N3} Product");

// Console.WriteLine($"     Sub Total: {subtotal:C}");

// Console.WriteLine($"           Tax: {taxPercentage:P2}");

// Console.WriteLine($"     Total Billed: {total:C}");


// string input = "Pad this";
// System.Console.WriteLine(input.PadLeft(12));

// string paymentID = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";
// var formattedLine = paymentID.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);
// Console.WriteLine("1234567890123456789012345678901234567890");
// System.Console.WriteLine(formattedLine);

// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// // Your logic here
// System.Console.WriteLine($"Dear {customerName}\nAs a customer of our {currentProduct} offering we are excited to tell you about a new financial that would dramatically increase your return.\n\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n\nOur new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:c2}\n");
// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// // Your logic here
// comparisonMessage += currentProduct.PadRight(24);
// comparisonMessage += $"{currentReturn:p2}".PadRight(10);
// comparisonMessage += $"{currentProfit:c2}\n";
// comparisonMessage += newProduct.PadRight(24);
// comparisonMessage += $"{newReturn:p2}".PadRight(10);
// comparisonMessage += $"{newProfit:c2}";
// Console.WriteLine(comparisonMessage);


// string message = "Find what is (inside the parentheses)";

// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(')');

// Console.WriteLine(openingPosition);
// Console.WriteLine(closingPosition);
// openingPosition += 1;
// int length = closingPosition - openingPosition;
// System.Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// const string openPar = "(";
// const string closingPar = ")";

// int openingPosition = message.LastIndexOf(openPar);

// int closingPosition = message.LastIndexOf(closingPar);
// openingPosition += openPar.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));


// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//     int openingPosition = message.IndexOf('(');
//     if (openingPosition == -1) break;

//     openingPosition += 1;
//     int closingPosition = message.IndexOf(')');
//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));

//     // Note the overload of the Substring to return only the remaining 
//     // unprocessed message:
//     message = message.Substring(closingPosition + 1);
// }

// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 6;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition: {message.Substring(openingPosition)}");

using System.IO.Compression;

string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

// int closingPosition = 0;

// while (true)
// {
//     int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//     if (openingPosition == -1) break;

//     string currentSymbol = message.Substring(openingPosition, 1);

//     // Now  find the matching closing symbol
//     char matchingSymbol = ' ';

//     switch (currentSymbol)
//     {
//         case "[":
//             matchingSymbol = ']';
//             break;
//         case "{":
//             matchingSymbol = '}';
//             break;
//         case "(":
//             matchingSymbol = ')';
//             break;
//     }

//     // To find the closingPosition, use an overload of the IndexOf method to specify 
//     // that the search for the matchingSymbol should start at the openingPosition in the string. 

//     openingPosition += 1;
//     closingPosition = message.IndexOf(matchingSymbol, openingPosition);

//     // Finally, use the techniques you've already learned to display the sub-string:

//     int length = closingPosition - openingPosition;
//     Console.WriteLine(message.Substring(openingPosition, length));
// }

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// // Your work here
//  output += input.Replace("<div>", "");
//  output += input.Replace("</div>", "");
//  int openSpan = input.IndexOf("<span>");
//  int closingSpan = input.IndexOf("</span>");
//  int inputLength = input.Length;
//  openSpan += 6;
// // inputLength--;
//  quantity += input.Remove(0, openSpan);
// quantity += input.Replace("</span></div>", "");
// Console.WriteLine($"Quantity: {quantity}");
// Console.WriteLine($"Output: {output}");

const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here

// Extract the quantity
int quantityStart = input.IndexOf("<span>");
int quantityEnd = input.IndexOf("</span>");
quantityStart += "<span>".Length; // Added length of the tag so index moves to end of the tag
int quantityLength = quantityEnd - quantityStart;
quantity = input.Substring(quantityStart, quantityLength); //Extracts from end of open tag to beginning of close tag
quantity = $"Quantity: {quantity}";

// Set output to input, replacing the trademark symbol with the registered trademark symbol
output = input.Replace("&trade;", "&reg;");

// Remove the opening <div> tag
int divStart = input.IndexOf("<div>");
int divLength = "<div>".Length;
output = output.Remove(divStart, divLength);

// Remove the closing <div> tag
int divCloseStart = output.IndexOf("</div>");
int divCloseLength = "</div>".Length;
output = output.Remove(divCloseStart, divCloseLength);
output = $"Output: {output}";

Console.WriteLine(quantity);
Console.WriteLine(output);