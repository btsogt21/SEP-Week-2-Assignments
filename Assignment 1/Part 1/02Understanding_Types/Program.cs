// See https://aka.ms/new-console-template for more information
string[] names = {"sbyte", "byte", "short", "ushort", "int",
    "uint", "long", "ulong", "float", "double", "decimal"};

string[] sizes = { "Signed 8-bit integer", "unSigned 8-bit integer",
"Signed 16-bit integer", "unSigned 16-bit integer", "Signed 32-bit integer", "Unsigned 32-bit integer",
"Signed 64-bit integer", "unSigned 64-bit integer", "4 bytes", "8 bytes", "16 bytes"};

string[] ranges = { "-128 to 127", "0 to 255", "-32,768 to 32,767"
, "0 to 65,535", "-2,147,483,648 to 2,147,483,647", "0 to 4,294,967,295",
"-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807", "0 to 18,446,744,073,709,551,615"
, "±1.5 x 10^−45 to ±3.4 x 10^38", "±5.0 × 10^−324 to ±1.7 × 10^308", "±1.0 x 10^-28 to ±7.9228 x 10^28"};

Console.WriteLine("{0, -20} {1, -25} {2, -50}\n", "Name of Data Type", "Size", "Range");
for (int counter = 0; counter < names.Length; counter++)
    Console.WriteLine("{0, -20} {1, -25} {2, -50}\n", names[counter],
        sizes[counter], ranges[counter]);