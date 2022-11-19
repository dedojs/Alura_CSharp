//Console.WriteLine("Aula 3 de arrays");

//Array amostra = Array.CreateInstance(typeof(double), 6); // new double [6];
//amostra.SetValue(5.9, 0);
//amostra.SetValue(1.8, 1);
//amostra.SetValue(7.1, 2);
//amostra.SetValue(10, 3);
//amostra.SetValue(14.3, 5);
//amostra.SetValue(11, 4);

//void TestaMediana(Array array)
//{
//    if (array == null || array.Length == 0)
//    {
//        Console.WriteLine("Array vazio ou nulo");
//    }

//    double[] numerosOrdenados = (double[])array.Clone(); // converte o array em um array de double
//    Array.Sort(numerosOrdenados);

//    int tamanho = numerosOrdenados.Length;
//    int meio = tamanho / 2;
//    double mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;

//    Console.WriteLine($"Com base na amostra a mediana é {mediana}");
//}

//// TestaMediana(amostra);

//int[] valores = { 10, 58, 36, 47 };

//for (int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine(valores[i]);
//}