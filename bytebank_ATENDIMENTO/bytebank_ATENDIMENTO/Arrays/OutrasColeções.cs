
//// Tipos de Listas

////Lita de numeros ordenados
//SortedList<int, string> times = new SortedList<int, string>();
//times.Add(0, "Flamengo");
//times.Add(1, "Santos");
//times.Add(2, "Juventus");

//foreach (var item in times.Values)
//{
//    Console.WriteLine(item);
//}

//// PILHA = ULTIMO A ENTRAR, PRIMEIRO A SAIR
//Stack<string> minhlaPilhaDeLivros = new Stack<string>();
//minhlaPilhaDeLivros.Push("Harry Porter e a Ordem da Fênix");
//minhlaPilhaDeLivros.Push("A Guerra do Velho.");
//minhlaPilhaDeLivros.Push("Protocolo Bluehand");
//minhlaPilhaDeLivros.Push("Crise nas Infinitas Terras.");

//Console.WriteLine(minhlaPilhaDeLivros.Peek());// Retorna o elemento do topo.
//Console.WriteLine(minhlaPilhaDeLivros.Pop()); //Remove o elemento do topo

//// FILA
//Queue<string> filaAtenndimento = new Queue<string>();
//filaAtenndimento.Enqueue("André Silva");
//filaAtenndimento.Enqueue("Lou Ferrigno");
//filaAtenndimento.Enqueue("Gal Gadot");
//filaAtenndimento.Dequeue();//Remove o primeiro elemento da fila.

////NÃO ACEITA VALORES DUPLICADOS
//HashSet<int> _numeros = new HashSet<int>();
//_numeros.Add(0);
//_numeros.Add(1);
//_numeros.Add(1);
//_numeros.Add(1);
//Console.WriteLine(_numeros.Count);// a saída é 2.
//foreach (var item in _numeros)
//{
//    Console.WriteLine(item);
//}