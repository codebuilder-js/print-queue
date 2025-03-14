using System;
using System.Collections.Generic;

class Program {
    static void Main() {
        PrintQueue printer = new PrintQueue();
        
        printer.AddDocument("Contrato.pdf");
        printer.AddDocument("Relatório.docx");
        printer.AddDocument("Imagem.png");
        
        printer.PrintNext();
        printer.PrintNext();
        printer.PrintNext();
        printer.PrintNext();
    }
}
