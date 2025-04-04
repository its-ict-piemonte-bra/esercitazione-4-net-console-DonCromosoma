namespace lesson
{
    public class Program
    {
        private static int[,] matrix = { };
        /// <summary>
        /// The main entrypoint of your application.
        /// </summary>
        /// <param name="args">The arguments passed to the program</param>
        public static void Main(string[] args)
        {
            
            int scelta=CreateMenu();
            if (scelta == -1)
            {
                Console.WriteLine("Scelta non valida");
            }
            else
            {
                DoOperation(scelta);
            }
        }
        /// <summary>
        /// Menu
        /// 1-Carica matrice
        /// 2-stampa matrice caricata
        /// 3-stampa matrice identità
        /// </summary>
        /// <returns></returns>
        private static int CreateMenu()
        {
            Console.WriteLine(@"1 - Carica matrice");
            Console.WriteLine(@"2 - Stampa matrice caricata");
            Console.WriteLine(@"3 - Stampa matrice identità");
            Console.Write("Svcegli un'opzione: ");
            int scelta= Convert.ToInt32(Console.ReadLine());
            if (scelta < 1 || scelta > 3) 
            {
                Console.WriteLine("Hai sbagliato");
                return -1;
            }
            return scelta;
        }

        /// <summary>
        /// In base alla sceta dell'utente esegue una funzione
        /// </summary>
        private static void DoOperation(int scelta) 
        {
            switch (scelta) 
            {
                case 1:
                    Console.WriteLine("Hai scelto il CARICAMENTO DI MATRICE");
                    matrix=LoadMatrix();
                    break;
                case 2:
                    Console.WriteLine("Hai scelto la STAMPA DI MATRICE CARICATA");
                    PrintMatrix(matrix, "Matrice");
                    break;
                case 3:
                    Console.WriteLine("Hai scelto la STAMPA DI MATRICE IDENTITà");
                    PrintIdentityMatrix(matrix, "Matice Identità"); 
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }

        }

        private static int[,] LoadMatrix()
        {
            Console.Write("Inserire Righe: ");
            int r = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inserire Colonne: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] result = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    result[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return result;

        }
        private static void PrintMatrix(int[,] matrix, string nomeMatrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nomeMatrix}[{i},{j}] -> {matrix[i, j]} - ");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// Stampa una matrice identità
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="nomeMatrix"></param>
        private static void PrintIdentityMatrix(int[,] matrix, string nomeMatrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{nomeMatrix}[{i},{j}] -> {matrix[i, j]} - ");
                }
                Console.WriteLine();
            }
        }

    }
}
