using System;
using System.Collections.Generic;

class PrintQueue {
    private Queue<string> printJobs = new Queue<string>();
    
    public void AddDocument(string documentName) {
        printJobs.Enqueue(documentName);
        Console.WriteLine($"Documento \"{documentName}\" adicionado à fila de impressão.");
    }
    
    public void PrintNext() {
        if(printJobs.Count > 0) {
            string document = printJobs.Dequeue();
            Console.WriteLine($"Imprimindo: {document}");
        } else {
            Console.WriteLine("Nenhum documento na fila.");
        }
    }
} 
