static void ImprimirNotas(int[] notasx)
{

for(int i = 0; i < notasx.Length; i++)
{
    Console.WriteLine($"nota {i + 1 }; {notasx[i]}"); 
}
}

int[] notas = {15,18,12,17,20}; 

ImprimirNotas(notas); 

int[] notas2 = {2,4,9};

ImprimirNotas(notas2);  