// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Van a jugar uno o dos jugadores??");
        Console.WriteLine("1) un jugador");
        Console.WriteLine("2) dos jugadores");
        string opc = Console.ReadLine();
        Console.Clear();

        if (opc == "1")
        {
            string[] palabras = { "sol", "arena", "perro", "catapulta", "queso", "circunferencia", "hielo" };
            Random random = new Random();//guardamos un numero aleatorio a una variable
            int random_num = random.Next(0,palabras.Length);//que sea de 0 al tamanio del array
            // creamos un arreglo tipo solo caracteres donde se guarde una palabra 
            char[] letras = palabras[random_num].ToCharArray();
            // guardamos el numero de letras de la palagra que haya salido
            int word_length = letras.Length;
            // creamos un arreglo con el mismo tamanio de la palabra 
            int[] flagletras = new int[word_length];
            int intentos = 6;
            for (int i = 0; i < word_length; i++)
            {
                // llenamos de ceros al arreglo para que todas estes inactivas
                flagletras[i] = 0;
            }
            bool game = true;
            // hacer todo miestras en juego este activo
            do
            {
                int letras_check = 0;
                Console.WriteLine("Intentos restantes: " + intentos);
                for (int h = 0; h < word_length; h++)
                {
                    //si encuentra un cero es porque no se ha encontrado la letra
                    if (flagletras[h] == 0)
                    {
                        // write para escribir sin salto de linea
                        Console.Write(" _ ");
                    }
                    else
                    {
                        //si esncuentra un 1 entonces volvemos a escribir una y otra vez las letras encontradas
                        Console.Write(" " + letras[h]+" ");
                        //aunmentamos para saber si ya ganamos el juego
                        letras_check++;
                    }

                }
                if(letras_check == word_length)
                {
                    game = false;
                    Console.WriteLine("\n\n Has ganado el juego felicitaciones!!");
                }
                else
                {
                    Console.WriteLine("\n\nIngrese una letra:");
                    // leemos por entrada de usuario y que sea de tipo caracter
                    //
                    //Aqui hay un error de expception
                    //
                    char letr = Convert.ToChar(Console.ReadLine());
                    // se va activar cuando le atinemos a la letra
                    bool flagcheck = false;
                    // creamos un for para comparar la letra que se ingresa con el arreglo
                    for (int x = 0; x < word_length; x++)
                    {
                        // si le atina entonces cambiamos el estatus de 0 a 1 del arreglo
                        if (letr == letras[x])
                        {
                            flagletras[x] = 1;
                            flagcheck = true;
                        }
                    }
                    // para restar los intentos
                    if (flagcheck == false)
                    {
                        intentos--;
                    }
                    if(intentos == 0)
                    {
                        game = false;
                        Console.WriteLine("GAME OVER");
                    }
                }
            }while (game == true);
        }
        if (opc == "2")
        {
            Console.WriteLine("Jugador 1 ingresa una palabra sin que te vea el jugador 2.");
            String palabra = Console.ReadLine();
            Console.Clear();
            // creamos un arreglo tipo solo caracteres donde se guarde una palabra 
            // y guardamos de tipo caracter.
            char[] letras = palabra.ToCharArray();
            // guardamos el numero de letras de la palagra que haya salido
            int word_length = letras.Length;
            // creamos un arreglo con el mismo tamanio de la palabra 
            int[] flagletras = new int[word_length];
            int intentos = 6;
            for (int i = 0; i < word_length; i++)
            {
                // llenamos de ceros al arreglo para que todas estes inactivas
                flagletras[i] = 0;
            }
            bool game = true;
            // hacer todo miestras en juego este activo
            do
            {
                int letras_check = 0;
                Console.WriteLine("Intentos restantes: " + intentos);
                for (int h = 0; h < word_length; h++)
                {
                    //si encuentra un cero es porque no se ha encontrado la letra
                    if (flagletras[h] == 0)
                    {   
                        // para que no haya salto de linea
                        Console.Write(" _ ");
                    }
                    else
                    {
                        //si esncuentra un 1 entonces volvemos a escribir una y otra vez las letras encontradas
                        Console.Write(" " + letras[h] + " ");
                        //aunmentamos para saber si ya ganamos el juego
                        letras_check++;
                    }
                }
                if (letras_check == word_length)
                {
                    game = false;
                    Console.WriteLine("\n\n Has ganado el juego jugador 2 felicitaciones!!");
                }
                else
                {
                    Console.WriteLine("\n\nIngrese una letra:");
                    // leemos por entrada de usuario y que sea de tipo caracter
                    char letr = Convert.ToChar(Console.ReadLine());
                    // se va activar cuando le atinemos a la letra
                    bool flagcheck = false;
                    // creamos un for para comparar la letra que se ingresa con el arreglo
                    for (int x = 0; x < word_length; x++)
                    {
                        // si le atina entonces cambiamos el estatus de 0 a 1 del arreglo
                        if (letr == letras[x])
                        {
                            flagletras[x] = 1;
                            flagcheck = true;
                        }
                    }
                    // para restar los intentos
                    if (flagcheck == false)
                    {
                        intentos--;
                    }
                    if (intentos == 0)
                    {
                        game = false;
                        Console.WriteLine("\n\nHas ganado el juego jugador 1 felicitaciones!!");
                    }
                }
            } while (game == true);
        }
    }
}