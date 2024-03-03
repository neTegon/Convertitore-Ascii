// See https://aka.ms/new-console-template for more information
using System.Text;

/*Console.WriteLine("Inserisci testo");
string x=Console.ReadLine();
byte[] asciiBytes = Encoding.ASCII.GetBytes(x);
foreach(byte b in asciiBytes) 
{
    Console.WriteLine(b);
}*/
StreamReader fs = new StreamReader("fileSorgente.txt");
StreamWriter fd = new StreamWriter("fileCopia.txt");
string riga = string.Empty;
while (!fs.EndOfStream)
{
    riga = fs.ReadLine();
    byte[] asciiBytes = Encoding.ASCII.GetBytes(riga);
    foreach(byte b in asciiBytes) 
    {
        fd.Write(b);
    }
    fd.WriteLine();
}
fd.Close();      
    
