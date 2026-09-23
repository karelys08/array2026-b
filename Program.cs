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

static int NotaMaxima(int[] notasx)
{
    int max= notasx[0]; 
    for(int i = 1 ; i <notasx.Length; i++)
    {
        if(notasx[1]> max)
        {
            max =notasx[i]; 
        }
    }
    return max; 
}
static int NotaMinina(int[] notasx)
{
    int min = notasx[0];
    for(int i = 1; i <notasx.Length; i++)
    {
        if(notasx[1]<min)
        {
            min=notasx[1]; 
        }
    }
    return min; 
}

ImprimirNotas(notas); 

//promedio de notas 
double promedio = PromedioNotas (notas); 
Console.WriteLine($"Promedio de las notas : {promedio:F2}"); 

//imprimir minino y maximo 
int maxima= NotaMaxima(notas); 
int minima= NotaMinina(notas); 
Console.WriteLine($"minimo de notas: {minima}"); 
Console.WriteLine($"maximo de notas: {maxima}"); 