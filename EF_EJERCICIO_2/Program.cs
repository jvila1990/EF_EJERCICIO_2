using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_EJERCICIO_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el grafo 1
            Console.WriteLine("Distancia mas corta de casa a otros puntos \n ");
            int[,] graph =  {
                          { 0, 5, 6, 16, 17, 0, 0 },
                          { 7, 0, 9, 6, 15, 8, 0 },
                          { 0, 0, 0, 0, 0, 0, 0 },
                          { 0, 0, 0, 0, 10, 0, 7 },
                          { 6, 5, 25, 0, 0, 1, 0 },
                          { 0, 10, 7, 0, 0, 0, 4 },
                          { 0, 0, 12, 14, 0, 0, 0 },



            };

            //El camino más corto de Dijkstra
            Dijkstra.DijkstraAlgo(graph, 0, 7);

            Console.WriteLine("");

            const int INF = 9999999;

            //Creamos el grafo 2
            Console.WriteLine("Caminos más cortos para cada par de puntos.\n");

            int[,] graph2 = {
                          { 0, 5, 6, 16, 17, INF, INF },
                          { 7, 0, 9, 6, 15, 8, INF },
                          { INF, INF, 0, INF, INF, INF, INF },
                          { INF, INF, INF, 0, 10, INF, 7 },
                          { 6, 5, 25, INF, 0, 1, INF },
                          { INF, 10, 7, INF, INF, 0, 4 },
                          { INF, INF, 12, 14, INF, INF, 0 },
                        };

            //Algoritmo de Warshall
            FloydWarshall.FloydWarshallAlgo(graph2, 7);

            Console.Read();
        }
    }
}

