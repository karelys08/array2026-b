static void ImprimirNotas(int[] notasx)
{

for(int i = 0; i < notasx.Length; i++)
{
    Console.WriteLine($"nota {i + 1 }; {notasx[i]}"); 
}
}
//funicon de promedio de notas 
static double PromedioNotas(int[] notasx)
{
    int suma = 0; 
    for(int i= 0; i < notasx.Length; i++)
    {
        suma += notasx[i]; 
    }
    return(double)suma/ notasx.Length;
}

int[] notas = {15,18,12,17,20}; 

ImprimirNotas(notas); 

//promedio de notas 
double promedio = PromedioNotas (notas); 
Console.WriteLine($"Promedio de las notas : {promedio:F2}"); 


