// Se solicitan los datos iniciales.
Console.Write("Introduce la capacidad máxima del tanque (L): ");
double capacidadMaxima = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce el volumen inicial (L): ");
double volumenInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Introduce el volumen agregado por ciclo (L): ");
double volumenAgregado = Convert.ToDouble(Console.ReadLine());

// Se validan los datos ingresados.
if (capacidadMaxima <= 0)
{
    Console.WriteLine("Error: la capacidad máxima debe ser mayor a cero.");
}
else if (volumenInicial < 0 || volumenAgregado <= 0)
{
    Console.WriteLine("Error: el volumen inicial no puede ser negativo y el incremento debe ser positivo.");
}
else if (volumenInicial > capacidadMaxima)
{
    Console.WriteLine("Error: el volumen inicial supera la capacidad máxima del tanque.");
}
else
{
    // OBJETO: se crea una instancia de la clase Tanque.
    Tanque tanque = new Tanque();

    // PROPIEDADES: se asignan los datos iniciales.
    tanque.CapacidadMaxima = capacidadMaxima;
    tanque.VolumenActual = volumenInicial;

    // Se ejecuta el método de llenado.
    tanque.Llenar(volumenAgregado);
}

// CLASE: representa un tanque de líquido.
class Tanque
{
    // PROPIEDADES: almacenan la capacidad máxima y el volumen actual.
    public double CapacidadMaxima { get; set; }
    public double VolumenActual { get; set; }

    // MÉTODO: incrementa el volumen hasta alcanzar la capacidad máxima.
    public void Llenar(double volumenAgregado)
    {
        int ciclo = 0;

        // MIENTRAS el tanque no esté lleno...
        while (VolumenActual < CapacidadMaxima)
        {
            ciclo++;

            // Se incrementa el volumen en cada ciclo.
            VolumenActual += volumenAgregado;

            // Se limita el volumen máximo a la capacidad del tanque.
            if (VolumenActual > CapacidadMaxima)
            {
                VolumenActual = CapacidadMaxima;
            }

            // Se calcula el porcentaje de llenado.
            double porcentaje = (VolumenActual / CapacidadMaxima) * 100;

            // Se muestran los resultados de cada ciclo.
            Console.WriteLine($"\nCiclo: {ciclo}");
            Console.WriteLine($"Volumen actualizado: {VolumenActual:F2} L");
            Console.WriteLine($"Porcentaje de llenado: {porcentaje:F2} %");
        }

        Console.WriteLine("\nTanque lleno a su máxima capacidad.");
    }
}