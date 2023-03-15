using System.IO;
using System;

System.Console.WriteLine();

StreamReader read = new StreamReader("Litwa.txt");
while(!read.EndOfStream) System.Console.WriteLine(read.ReadLine()+"\t");